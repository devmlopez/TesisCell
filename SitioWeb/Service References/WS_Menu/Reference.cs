﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioWeb.WS_Menu {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_Menu.WS_MenuSoap")]
    public interface WS_MenuSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Select", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SitioWeb.WS_Menu.SelectResponse Select(SitioWeb.WS_Menu.SelectRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Select", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectResponse> SelectAsync(SitioWeb.WS_Menu.SelectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectDynamic", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SitioWeb.WS_Menu.SelectDynamicResponse SelectDynamic(SitioWeb.WS_Menu.SelectDynamicRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectDynamic", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectDynamicResponse> SelectDynamicAsync(SitioWeb.WS_Menu.SelectDynamicRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectDataTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SitioWeb.WS_Menu.SelectDataTableResponse SelectDataTable(SitioWeb.WS_Menu.SelectDataTableRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectDataTable", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectDataTableResponse> SelectDataTableAsync(SitioWeb.WS_Menu.SelectDataTableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectFirst", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SitioWeb.WS_Menu.SelectFirstResponse SelectFirst(SitioWeb.WS_Menu.SelectFirstRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectFirst", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectFirstResponse> SelectFirstAsync(SitioWeb.WS_Menu.SelectFirstRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertInto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultado")]
        string InsertInto(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertInto", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultado")]
        System.Threading.Tasks.Task<string> InsertIntoAsync(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultado")]
        string Update(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultado")]
        System.Threading.Tasks.Task<string> UpdateAsync(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultado")]
        string Delete(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultado")]
        System.Threading.Tasks.Task<string> DeleteAsync(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ClassMenu : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uidmenuField;
        
        private string uidrolField;
        
        private string uidpaginaField;
        
        private System.Nullable<bool> esvisibleField;
        
        private System.Nullable<bool> semuestraField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string uidmenu {
            get {
                return this.uidmenuField;
            }
            set {
                this.uidmenuField = value;
                this.RaisePropertyChanged("uidmenu");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string uidrol {
            get {
                return this.uidrolField;
            }
            set {
                this.uidrolField = value;
                this.RaisePropertyChanged("uidrol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string uidpagina {
            get {
                return this.uidpaginaField;
            }
            set {
                this.uidpaginaField = value;
                this.RaisePropertyChanged("uidpagina");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<bool> esvisible {
            get {
                return this.esvisibleField;
            }
            set {
                this.esvisibleField = value;
                this.RaisePropertyChanged("esvisible");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<bool> semuestra {
            get {
                return this.semuestraField;
            }
            set {
                this.semuestraField = value;
                this.RaisePropertyChanged("semuestra");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Select", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UidUserLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public SitioWeb.WS_Menu.ClassMenu VALUE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string EstadoExistencia;
        
        public SelectRequest() {
        }
        
        public SelectRequest(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE, string EstadoExistencia) {
            this.UidUserLogin = UidUserLogin;
            this.VALUE = VALUE;
            this.EstadoExistencia = EstadoExistencia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SitioWeb.WS_Menu.ClassMenu[] SelectResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string resultado;
        
        public SelectResponse() {
        }
        
        public SelectResponse(SitioWeb.WS_Menu.ClassMenu[] SelectResult, string resultado) {
            this.SelectResult = SelectResult;
            this.resultado = resultado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectDynamic", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectDynamicRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UidUserLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public SitioWeb.WS_Menu.ClassMenu VALUE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string EstadoExistencia;
        
        public SelectDynamicRequest() {
        }
        
        public SelectDynamicRequest(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE, string EstadoExistencia) {
            this.UidUserLogin = UidUserLogin;
            this.VALUE = VALUE;
            this.EstadoExistencia = EstadoExistencia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectDynamicResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectDynamicResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SitioWeb.WS_Menu.ClassMenu[] SelectDynamicResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string resultado;
        
        public SelectDynamicResponse() {
        }
        
        public SelectDynamicResponse(SitioWeb.WS_Menu.ClassMenu[] SelectDynamicResult, string resultado) {
            this.SelectDynamicResult = SelectDynamicResult;
            this.resultado = resultado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectDataTable", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectDataTableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UidUserLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public SitioWeb.WS_Menu.ClassMenu VALUE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string EstadoExistencia;
        
        public SelectDataTableRequest() {
        }
        
        public SelectDataTableRequest(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE, string EstadoExistencia) {
            this.UidUserLogin = UidUserLogin;
            this.VALUE = VALUE;
            this.EstadoExistencia = EstadoExistencia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectDataTableResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectDataTableResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable SelectDataTableResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string resultado;
        
        public SelectDataTableResponse() {
        }
        
        public SelectDataTableResponse(System.Data.DataTable SelectDataTableResult, string resultado) {
            this.SelectDataTableResult = SelectDataTableResult;
            this.resultado = resultado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectFirst", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectFirstRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UidUserLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string uidmenu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string EstadoExistencia;
        
        public SelectFirstRequest() {
        }
        
        public SelectFirstRequest(string UidUserLogin, string uidmenu, string EstadoExistencia) {
            this.UidUserLogin = UidUserLogin;
            this.uidmenu = uidmenu;
            this.EstadoExistencia = EstadoExistencia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectFirstResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectFirstResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SitioWeb.WS_Menu.ClassMenu SelectFirstResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string resultado;
        
        public SelectFirstResponse() {
        }
        
        public SelectFirstResponse(SitioWeb.WS_Menu.ClassMenu SelectFirstResult, string resultado) {
            this.SelectFirstResult = SelectFirstResult;
            this.resultado = resultado;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_MenuSoapChannel : SitioWeb.WS_Menu.WS_MenuSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_MenuSoapClient : System.ServiceModel.ClientBase<SitioWeb.WS_Menu.WS_MenuSoap>, SitioWeb.WS_Menu.WS_MenuSoap {
        
        public WS_MenuSoapClient() {
        }
        
        public WS_MenuSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_MenuSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_MenuSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_MenuSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioWeb.WS_Menu.SelectResponse SitioWeb.WS_Menu.WS_MenuSoap.Select(SitioWeb.WS_Menu.SelectRequest request) {
            return base.Channel.Select(request);
        }
        
        public SitioWeb.WS_Menu.ClassMenu[] Select(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE, string EstadoExistencia, out string resultado) {
            SitioWeb.WS_Menu.SelectRequest inValue = new SitioWeb.WS_Menu.SelectRequest();
            inValue.UidUserLogin = UidUserLogin;
            inValue.VALUE = VALUE;
            inValue.EstadoExistencia = EstadoExistencia;
            SitioWeb.WS_Menu.SelectResponse retVal = ((SitioWeb.WS_Menu.WS_MenuSoap)(this)).Select(inValue);
            resultado = retVal.resultado;
            return retVal.SelectResult;
        }
        
        public System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectResponse> SelectAsync(SitioWeb.WS_Menu.SelectRequest request) {
            return base.Channel.SelectAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioWeb.WS_Menu.SelectDynamicResponse SitioWeb.WS_Menu.WS_MenuSoap.SelectDynamic(SitioWeb.WS_Menu.SelectDynamicRequest request) {
            return base.Channel.SelectDynamic(request);
        }
        
        public SitioWeb.WS_Menu.ClassMenu[] SelectDynamic(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE, string EstadoExistencia, out string resultado) {
            SitioWeb.WS_Menu.SelectDynamicRequest inValue = new SitioWeb.WS_Menu.SelectDynamicRequest();
            inValue.UidUserLogin = UidUserLogin;
            inValue.VALUE = VALUE;
            inValue.EstadoExistencia = EstadoExistencia;
            SitioWeb.WS_Menu.SelectDynamicResponse retVal = ((SitioWeb.WS_Menu.WS_MenuSoap)(this)).SelectDynamic(inValue);
            resultado = retVal.resultado;
            return retVal.SelectDynamicResult;
        }
        
        public System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectDynamicResponse> SelectDynamicAsync(SitioWeb.WS_Menu.SelectDynamicRequest request) {
            return base.Channel.SelectDynamicAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioWeb.WS_Menu.SelectDataTableResponse SitioWeb.WS_Menu.WS_MenuSoap.SelectDataTable(SitioWeb.WS_Menu.SelectDataTableRequest request) {
            return base.Channel.SelectDataTable(request);
        }
        
        public System.Data.DataTable SelectDataTable(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE, string EstadoExistencia, out string resultado) {
            SitioWeb.WS_Menu.SelectDataTableRequest inValue = new SitioWeb.WS_Menu.SelectDataTableRequest();
            inValue.UidUserLogin = UidUserLogin;
            inValue.VALUE = VALUE;
            inValue.EstadoExistencia = EstadoExistencia;
            SitioWeb.WS_Menu.SelectDataTableResponse retVal = ((SitioWeb.WS_Menu.WS_MenuSoap)(this)).SelectDataTable(inValue);
            resultado = retVal.resultado;
            return retVal.SelectDataTableResult;
        }
        
        public System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectDataTableResponse> SelectDataTableAsync(SitioWeb.WS_Menu.SelectDataTableRequest request) {
            return base.Channel.SelectDataTableAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioWeb.WS_Menu.SelectFirstResponse SitioWeb.WS_Menu.WS_MenuSoap.SelectFirst(SitioWeb.WS_Menu.SelectFirstRequest request) {
            return base.Channel.SelectFirst(request);
        }
        
        public SitioWeb.WS_Menu.ClassMenu SelectFirst(string UidUserLogin, string uidmenu, string EstadoExistencia, out string resultado) {
            SitioWeb.WS_Menu.SelectFirstRequest inValue = new SitioWeb.WS_Menu.SelectFirstRequest();
            inValue.UidUserLogin = UidUserLogin;
            inValue.uidmenu = uidmenu;
            inValue.EstadoExistencia = EstadoExistencia;
            SitioWeb.WS_Menu.SelectFirstResponse retVal = ((SitioWeb.WS_Menu.WS_MenuSoap)(this)).SelectFirst(inValue);
            resultado = retVal.resultado;
            return retVal.SelectFirstResult;
        }
        
        public System.Threading.Tasks.Task<SitioWeb.WS_Menu.SelectFirstResponse> SelectFirstAsync(SitioWeb.WS_Menu.SelectFirstRequest request) {
            return base.Channel.SelectFirstAsync(request);
        }
        
        public string InsertInto(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE) {
            return base.Channel.InsertInto(UidUserLogin, VALUE);
        }
        
        public System.Threading.Tasks.Task<string> InsertIntoAsync(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE) {
            return base.Channel.InsertIntoAsync(UidUserLogin, VALUE);
        }
        
        public string Update(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE) {
            return base.Channel.Update(UidUserLogin, VALUE);
        }
        
        public System.Threading.Tasks.Task<string> UpdateAsync(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE) {
            return base.Channel.UpdateAsync(UidUserLogin, VALUE);
        }
        
        public string Delete(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE) {
            return base.Channel.Delete(UidUserLogin, VALUE);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAsync(string UidUserLogin, SitioWeb.WS_Menu.ClassMenu VALUE) {
            return base.Channel.DeleteAsync(UidUserLogin, VALUE);
        }
    }
}
