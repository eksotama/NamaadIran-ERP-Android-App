/*
 * Author: Shahrooz Sabet
 * Date: 20140628
 * */
#region using
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using NamaadMobile.aSQLiteManager;
using NamaadMobile.Entity;
using NamaadMobile.Util;
using System;
using System.Collections.Generic;
#endregion
namespace NamaadMobile.WebService
{
    /// <summary>
    /// TODO: Should be completed with Web service call func
    /// </summary>
    [Activity(Label = "@string/RefreshData")]
    public class WSManager : NamaadMobile.SharedElement.NamaadFormBase
    {
        #region Defins
        /// <summary>
        /// The tag For Debugging purpose
        /// </summary>
        private const string TAG = "NamaadMobile.WebService.WSManager";
        private IList<string> FieldNames { get; set; }
        private IList<string> FieldDisplayNames { get; set; }
        private string _tableDisplayName;
        private int sourceType;
        private string _table;
        private string _tvQ;
        private bool _logging;
        /// Note: This class should use Javatype in accessing Arrayadapter and filing it with list items,
        /// See: Collections, Bad and good adapter example at:
        /// http://docs.xamarin.com/guides/android/advanced_topics/api_design/ (Accessed 2014/04/14)
        private JavaList<IParcelable> listRec = new JavaList<IParcelable>();//Should be Android.Runtime.JavaList<T> to be matched with adapter
        private ArrayAdapter<IParcelable> adapter;

        private bool notATable;

        // UI references.
        private Button btnCreate;
        private ListView listView;
        private Button btnChkAll;
        private Button btnRef;
        #endregion
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ws_man);
            _logging = Pref.getLogging(this);
            SetActionBarTitle(GetString(Resource.String.RefreshData));
            btnCreate = (Button)FindViewById(Resource.Id.btnCreate);
            listView = FindViewById<ListView>(Resource.Id.listView);
            btnChkAll = (Button)FindViewById(Resource.Id.btnChkAll);
            btnRef = (Button)FindViewById(Resource.Id.btnRef);

            Bundle extras = Intent.Extras;
            if (extras != null)
            {
                FieldNames = extras.GetStringArrayList("FieldNames");
                FieldDisplayNames = extras.GetStringArrayList("FieldDisplayNames");
                _tableDisplayName = extras.GetString("TableDisplayName");
                sourceType = extras.GetInt("type");
                _table = extras.GetString("Table");
                _tvQ = extras.GetString("sql");

                if (bundle != null)
                {
                    listRec = (JavaList<IParcelable>)bundle.GetParcelableArrayList("listRec");
                }
                listView.ItemsCanFocus = false;
                listView.ChoiceMode = ChoiceMode.Multiple;
                listView.TextFilterEnabled = true;
                notATable = string.IsNullOrEmpty(_table);
                if ((notATable && string.IsNullOrEmpty(_tvQ)) || string.IsNullOrEmpty(_tableDisplayName) || FieldNames == null || FieldDisplayNames == null)
                {
                    InvalidateUI(btnChkAll, btnRef);
                }
                else
                {
                    adapter = new ArrayAdapter<IParcelable>(this, Android.Resource.Layout.SimpleListItemMultipleChoice, listRec);
                    listView.Adapter = adapter;
                    listView.ItemsCanFocus = false;
                    listView.ChoiceMode = ChoiceMode.Multiple;
                    listView.TextFilterEnabled = true;
                }
            }
            else
            {
                InvalidateUI(btnChkAll, btnRef);
            }

        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnChkAllClick(object sender, EventArgs e)
        {
            bool check = listView.IsItemChecked(0);
            int size = listView.Count;
            for (int i = 0; i <= size; i++)
                listView.SetItemChecked(i, !check);
        }

        private void BtnCreateClick(object sender, EventArgs e)
        {
            Intent intent = null;
            if (!notATable)
            {
                intent = new Intent(this, typeof(TableViewer));
                intent.PutExtra("Table", _table);
                intent.PutExtra("type", Types.TABLE);

            }
            else
            {
                intent = new Intent(this, typeof(QueryViewer));
                string sql = _tvQ;
                intent.PutExtra("sql", sql);
            }
            intent.PutExtra("TableDisplayName", _tableDisplayName);
            intent.PutStringArrayListExtra("FieldNames", FieldNames);
            intent.PutStringArrayListExtra("FieldDisplayNames", FieldDisplayNames);
            StartActivityForResult(intent, 0);
        }
        protected override void OnResume()
        {
            base.OnResume();
            btnCreate.Click += BtnCreateClick;
            btnChkAll.Click += BtnChkAllClick;
            //refbtn.Click += refbtn_Click;
        }
        protected override void OnPause()
        {
            base.OnPause();
            btnCreate.Click -= BtnCreateClick;
            btnChkAll.Click -= BtnChkAllClick;
            //refbtn.Click -= refbtn_Click;
        }
        private void InvalidateUI(Button chkAllbtn, Button refbtn)
        {
            btnCreate.Enabled = false;
            chkAllbtn.Enabled = false;
            refbtn.Enabled = false;
        }
        /// <summary>
        /// Called when the activity receives a results. Catch result
        /// </summary>
        /// <param name="requestCode">The integer request code originally
        /// supplied to startActivityForResult(), allowing you to identify
        /// who this result came from.</param>
        /// <param name="resultCode">The integer result code returned by 
        /// the child activity through its setResult().</param>
        /// <param name="data">An Intent, which can return result data to the caller 
        /// (various data can be attached to Intent "extras").</param>
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (resultCode == Result.Ok)
            {
                if (requestCode == 0)
                {
                    IParcelable[] recData = data.GetParcelableArrayExtra("TableField[]");
                    Record rec = TableFieldArrayToRecord(recData);
                    AddRec(rec);
                }
            }
        }
        private Record TableFieldArrayToRecord(IParcelable[] recData)
        {
            int size = recData.Length;
            Record rec = new Record();
            AField[] aFieldArr = new AField[size];
            for (int i = 0; i < size; i++)
            {
                AField aF = new AField();
                aF.setFieldData(((TableField)recData[i]).getValue());
                aFieldArr[i] = aF;
            }
            rec.setFields(aFieldArr);
            return rec;
        }
        /// <summary>
        /// Adds the record.
        /// </summary>
        /// <param name="rec">The record.</param>
        private void AddRec(IParcelable rec)
        {
            listRec.Add(rec);
            adapter.NotifyDataSetChanged();
            //if (adapter.Count == listRec.Count)
            //	adapter.NotifyDataSetChanged();
            //else //After using Android.Runtime.JavaList<T> this will be corrected, now aditional add is required.
            //	adapter.Add(rec);
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutParcelableArrayList("listRec", listRec);
            base.OnSaveInstanceState(outState);
        }
    }
}