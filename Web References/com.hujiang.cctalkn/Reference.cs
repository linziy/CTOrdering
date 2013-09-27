﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18331
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18331.
// 
#pragma warning disable 1591

namespace CTOrder.com.hujiang.cctalkn {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ct_apiSoap", Namespace="http://tempuri.org/")]
    public partial class ct_api : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddUserNoticeOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUserHasLoginLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUserIsOnLineOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUsersIsOnLineOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddFriendRequestOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ct_api() {
            this.Url = global::CTOrder.Properties.Settings.Default.CTOrder_com_hujiang_cctalkn_ct_api;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddUserNoticeCompletedEventHandler AddUserNoticeCompleted;
        
        /// <remarks/>
        public event CheckUserHasLoginLogCompletedEventHandler CheckUserHasLoginLogCompleted;
        
        /// <remarks/>
        public event CheckUserIsOnLineCompletedEventHandler CheckUserIsOnLineCompleted;
        
        /// <remarks/>
        public event CheckUsersIsOnLineCompletedEventHandler CheckUsersIsOnLineCompleted;
        
        /// <remarks/>
        public event AddFriendRequestCompletedEventHandler AddFriendRequestCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddUserNotice", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddUserNotice(int userId, int toUserId, string title, string frameUrl) {
            object[] results = this.Invoke("AddUserNotice", new object[] {
                        userId,
                        toUserId,
                        title,
                        frameUrl});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddUserNoticeAsync(int userId, int toUserId, string title, string frameUrl) {
            this.AddUserNoticeAsync(userId, toUserId, title, frameUrl, null);
        }
        
        /// <remarks/>
        public void AddUserNoticeAsync(int userId, int toUserId, string title, string frameUrl, object userState) {
            if ((this.AddUserNoticeOperationCompleted == null)) {
                this.AddUserNoticeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddUserNoticeOperationCompleted);
            }
            this.InvokeAsync("AddUserNotice", new object[] {
                        userId,
                        toUserId,
                        title,
                        frameUrl}, this.AddUserNoticeOperationCompleted, userState);
        }
        
        private void OnAddUserNoticeOperationCompleted(object arg) {
            if ((this.AddUserNoticeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddUserNoticeCompleted(this, new AddUserNoticeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckUserHasLoginLog", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckUserHasLoginLog(int userId) {
            object[] results = this.Invoke("CheckUserHasLoginLog", new object[] {
                        userId});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUserHasLoginLogAsync(int userId) {
            this.CheckUserHasLoginLogAsync(userId, null);
        }
        
        /// <remarks/>
        public void CheckUserHasLoginLogAsync(int userId, object userState) {
            if ((this.CheckUserHasLoginLogOperationCompleted == null)) {
                this.CheckUserHasLoginLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUserHasLoginLogOperationCompleted);
            }
            this.InvokeAsync("CheckUserHasLoginLog", new object[] {
                        userId}, this.CheckUserHasLoginLogOperationCompleted, userState);
        }
        
        private void OnCheckUserHasLoginLogOperationCompleted(object arg) {
            if ((this.CheckUserHasLoginLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUserHasLoginLogCompleted(this, new CheckUserHasLoginLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckUserIsOnLine", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckUserIsOnLine(int userId) {
            object[] results = this.Invoke("CheckUserIsOnLine", new object[] {
                        userId});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUserIsOnLineAsync(int userId) {
            this.CheckUserIsOnLineAsync(userId, null);
        }
        
        /// <remarks/>
        public void CheckUserIsOnLineAsync(int userId, object userState) {
            if ((this.CheckUserIsOnLineOperationCompleted == null)) {
                this.CheckUserIsOnLineOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUserIsOnLineOperationCompleted);
            }
            this.InvokeAsync("CheckUserIsOnLine", new object[] {
                        userId}, this.CheckUserIsOnLineOperationCompleted, userState);
        }
        
        private void OnCheckUserIsOnLineOperationCompleted(object arg) {
            if ((this.CheckUserIsOnLineCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUserIsOnLineCompleted(this, new CheckUserIsOnLineCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckUsersIsOnLine", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckUsersIsOnLine(string userIds) {
            object[] results = this.Invoke("CheckUsersIsOnLine", new object[] {
                        userIds});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUsersIsOnLineAsync(string userIds) {
            this.CheckUsersIsOnLineAsync(userIds, null);
        }
        
        /// <remarks/>
        public void CheckUsersIsOnLineAsync(string userIds, object userState) {
            if ((this.CheckUsersIsOnLineOperationCompleted == null)) {
                this.CheckUsersIsOnLineOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUsersIsOnLineOperationCompleted);
            }
            this.InvokeAsync("CheckUsersIsOnLine", new object[] {
                        userIds}, this.CheckUsersIsOnLineOperationCompleted, userState);
        }
        
        private void OnCheckUsersIsOnLineOperationCompleted(object arg) {
            if ((this.CheckUsersIsOnLineCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUsersIsOnLineCompleted(this, new CheckUsersIsOnLineCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddFriendRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddFriendRequest(int userId, int toUserId, string msg) {
            object[] results = this.Invoke("AddFriendRequest", new object[] {
                        userId,
                        toUserId,
                        msg});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddFriendRequestAsync(int userId, int toUserId, string msg) {
            this.AddFriendRequestAsync(userId, toUserId, msg, null);
        }
        
        /// <remarks/>
        public void AddFriendRequestAsync(int userId, int toUserId, string msg, object userState) {
            if ((this.AddFriendRequestOperationCompleted == null)) {
                this.AddFriendRequestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddFriendRequestOperationCompleted);
            }
            this.InvokeAsync("AddFriendRequest", new object[] {
                        userId,
                        toUserId,
                        msg}, this.AddFriendRequestOperationCompleted, userState);
        }
        
        private void OnAddFriendRequestOperationCompleted(object arg) {
            if ((this.AddFriendRequestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddFriendRequestCompleted(this, new AddFriendRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    public delegate void AddUserNoticeCompletedEventHandler(object sender, AddUserNoticeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddUserNoticeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddUserNoticeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    public delegate void CheckUserHasLoginLogCompletedEventHandler(object sender, CheckUserHasLoginLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUserHasLoginLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUserHasLoginLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    public delegate void CheckUserIsOnLineCompletedEventHandler(object sender, CheckUserIsOnLineCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUserIsOnLineCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUserIsOnLineCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    public delegate void CheckUsersIsOnLineCompletedEventHandler(object sender, CheckUsersIsOnLineCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUsersIsOnLineCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUsersIsOnLineCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    public delegate void AddFriendRequestCompletedEventHandler(object sender, AddFriendRequestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18331")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddFriendRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddFriendRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591