﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 


[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="RefreshDataCT", Namespace="http://schemas.datacontract.org/2004/07/")]
public partial class RefreshDataCT : object
{
    
    private byte[] DataTableArrayField;
    
    private string DbNameClientField;
    
    private string DbNameServerField;
    
    private string DeleteKeyField;
    
    private bool HasCreateTableField;
    
    private bool IsCreateTmpTableField;
    
    private long LenField;

    private int SystemCodeField;
    
    private string QueryAfterExec1Field;
    
    private string QueryAfterExec2Field;
    
    private string QueryAfterExec3Field;
    
    private string QueryBeforeExec1Field;
    
    private string QueryBeforeExec2Field;
    
    private string QueryCreateTableField;
    
    private string StrDebugField;
    
    private int TableCodeField;
    
    private int TableDataVersionField;
    
    private string TableNameField;
    
    private int UserCodeField;
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] DataTableArray
    {
        get
        {
            return this.DataTableArrayField;
        }
        set
        {
            this.DataTableArrayField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string DbNameClient
    {
        get
        {
            return this.DbNameClientField;
        }
        set
        {
            this.DbNameClientField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string DbNameServer
    {
        get
        {
            return this.DbNameServerField;
        }
        set
        {
            this.DbNameServerField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string DeleteKey
    {
        get
        {
            return this.DeleteKeyField;
        }
        set
        {
            this.DeleteKeyField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public bool HasCreateTable
    {
        get
        {
            return this.HasCreateTableField;
        }
        set
        {
            this.HasCreateTableField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public bool IsCreateTmpTable
    {
        get
        {
            return this.IsCreateTmpTableField;
        }
        set
        {
            this.IsCreateTmpTableField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public long Len
    {
        get
        {
            return this.LenField;
        }
        set
        {
            this.LenField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public int SystemCode
    {
        get
        {
            return this.SystemCodeField;
        }
        set
        {
            this.SystemCodeField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string QueryAfterExec1
    {
        get
        {
            return this.QueryAfterExec1Field;
        }
        set
        {
            this.QueryAfterExec1Field = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string QueryAfterExec2
    {
        get
        {
            return this.QueryAfterExec2Field;
        }
        set
        {
            this.QueryAfterExec2Field = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string QueryAfterExec3
    {
        get
        {
            return this.QueryAfterExec3Field;
        }
        set
        {
            this.QueryAfterExec3Field = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string QueryBeforeExec1
    {
        get
        {
            return this.QueryBeforeExec1Field;
        }
        set
        {
            this.QueryBeforeExec1Field = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string QueryBeforeExec2
    {
        get
        {
            return this.QueryBeforeExec2Field;
        }
        set
        {
            this.QueryBeforeExec2Field = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string QueryCreateTable
    {
        get
        {
            return this.QueryCreateTableField;
        }
        set
        {
            this.QueryCreateTableField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string StrDebug
    {
        get
        {
            return this.StrDebugField;
        }
        set
        {
            this.StrDebugField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public int TableCode
    {
        get
        {
            return this.TableCodeField;
        }
        set
        {
            this.TableCodeField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public int TableDataVersion
    {
        get
        {
            return this.TableDataVersionField;
        }
        set
        {
            this.TableDataVersionField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string TableName
    {
        get
        {
            return this.TableNameField;
        }
        set
        {
            this.TableNameField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public int UserCode
    {
        get
        {
            return this.UserCodeField;
        }
        set
        {
            this.UserCodeField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService")]
public interface IService
{
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
    System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState);
    
    string EndGetData(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/RefreshData", ReplyAction="http://tempuri.org/IService/RefreshDataResponse")]
    System.IAsyncResult BeginRefreshData(RefreshDataCT composite, System.AsyncCallback callback, object asyncState);
    
    RefreshDataCT EndRefreshData(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public string Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class RefreshDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public RefreshDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public RefreshDataCT Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((RefreshDataCT)(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    private BeginOperationDelegate onBeginGetDataDelegate;
    
    private EndOperationDelegate onEndGetDataDelegate;
    
    private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
    
    private BeginOperationDelegate onBeginRefreshDataDelegate;
    
    private EndOperationDelegate onEndRefreshDataDelegate;
    
    private System.Threading.SendOrPostCallback onRefreshDataCompletedDelegate;
    
    private BeginOperationDelegate onBeginOpenDelegate;
    
    private EndOperationDelegate onEndOpenDelegate;
    
    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
    private BeginOperationDelegate onBeginCloseDelegate;
    
    private EndOperationDelegate onEndCloseDelegate;
    
    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Net.CookieContainer CookieContainer
    {
        get
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                return httpCookieContainerManager.CookieContainer;
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                httpCookieContainerManager.CookieContainer = value;
            }
            else
            {
                throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                        "ookieContainerBindingElement.");
            }
        }
    }
    
    public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
    
    public event System.EventHandler<RefreshDataCompletedEventArgs> RefreshDataCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IService.BeginGetData(int value, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetData(value, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    string IService.EndGetData(System.IAsyncResult result)
    {
        return base.Channel.EndGetData(result);
    }
    
    private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        int value = ((int)(inValues[0]));
        return ((IService)(this)).BeginGetData(value, callback, asyncState);
    }
    
    private object[] OnEndGetData(System.IAsyncResult result)
    {
        string retVal = ((IService)(this)).EndGetData(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetDataCompleted(object state)
    {
        if ((this.GetDataCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetDataAsync(int value)
    {
        this.GetDataAsync(value, null);
    }
    
    public void GetDataAsync(int value, object userState)
    {
        if ((this.onBeginGetDataDelegate == null))
        {
            this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
        }
        if ((this.onEndGetDataDelegate == null))
        {
            this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
        }
        if ((this.onGetDataCompletedDelegate == null))
        {
            this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
        }
        base.InvokeAsync(this.onBeginGetDataDelegate, new object[] {
                    value}, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IService.BeginRefreshData(RefreshDataCT composite, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginRefreshData(composite, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    RefreshDataCT IService.EndRefreshData(System.IAsyncResult result)
    {
        return base.Channel.EndRefreshData(result);
    }
    
    private System.IAsyncResult OnBeginRefreshData(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        RefreshDataCT composite = ((RefreshDataCT)(inValues[0]));
        return ((IService)(this)).BeginRefreshData(composite, callback, asyncState);
    }
    
    private object[] OnEndRefreshData(System.IAsyncResult result)
    {
        RefreshDataCT retVal = ((IService)(this)).EndRefreshData(result);
        return new object[] {
                retVal};
    }
    
    private void OnRefreshDataCompleted(object state)
    {
        if ((this.RefreshDataCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.RefreshDataCompleted(this, new RefreshDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void RefreshDataAsync(RefreshDataCT composite)
    {
        this.RefreshDataAsync(composite, null);
    }
    
    public void RefreshDataAsync(RefreshDataCT composite, object userState)
    {
        if ((this.onBeginRefreshDataDelegate == null))
        {
            this.onBeginRefreshDataDelegate = new BeginOperationDelegate(this.OnBeginRefreshData);
        }
        if ((this.onEndRefreshDataDelegate == null))
        {
            this.onEndRefreshDataDelegate = new EndOperationDelegate(this.OnEndRefreshData);
        }
        if ((this.onRefreshDataCompletedDelegate == null))
        {
            this.onRefreshDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRefreshDataCompleted);
        }
        base.InvokeAsync(this.onBeginRefreshDataDelegate, new object[] {
                    composite}, this.onEndRefreshDataDelegate, this.onRefreshDataCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }
    
    private object[] OnEndOpen(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
        return null;
    }
    
    private void OnOpenCompleted(object state)
    {
        if ((this.OpenCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void OpenAsync()
    {
        this.OpenAsync(null);
    }
    
    public void OpenAsync(object userState)
    {
        if ((this.onBeginOpenDelegate == null))
        {
            this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
        }
        if ((this.onEndOpenDelegate == null))
        {
            this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
        }
        if ((this.onOpenCompletedDelegate == null))
        {
            this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
        }
        base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }
    
    private object[] OnEndClose(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
        return null;
    }
    
    private void OnCloseCompleted(object state)
    {
        if ((this.CloseCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void CloseAsync()
    {
        this.CloseAsync(null);
    }
    
    public void CloseAsync(object userState)
    {
        if ((this.onBeginCloseDelegate == null))
        {
            this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
        }
        if ((this.onEndCloseDelegate == null))
        {
            this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
        }
        if ((this.onCloseCompletedDelegate == null))
        {
            this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
        }
        base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    
    protected override IService CreateChannel()
    {
        return new ServiceClientChannel(this);
    }
    
    private class ServiceClientChannel : ChannelBase<IService>, IService
    {
        
        public ServiceClientChannel(System.ServiceModel.ClientBase<IService> client) : 
                base(client)
        {
        }
        
        public System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = value;
            System.IAsyncResult _result = base.BeginInvoke("GetData", _args, callback, asyncState);
            return _result;
        }
        
        public string EndGetData(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            string _result = ((string)(base.EndInvoke("GetData", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginRefreshData(RefreshDataCT composite, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = composite;
            System.IAsyncResult _result = base.BeginInvoke("RefreshData", _args, callback, asyncState);
            return _result;
        }
        
        public RefreshDataCT EndRefreshData(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            RefreshDataCT _result = ((RefreshDataCT)(base.EndInvoke("RefreshData", _args, result)));
            return _result;
        }
    }
}
