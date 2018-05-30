﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="ServiceReference1.Listar")]
    public interface Listar {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarRolRequest", ReplyAction="http://ws/Listar/listarRolResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WcfService1.ServiceReference1.listarRolResponse listarRol(WcfService1.ServiceReference1.listarRolRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarRolRequest", ReplyAction="http://ws/Listar/listarRolResponse")]
        System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarRolResponse> listarRolAsync(WcfService1.ServiceReference1.listarRolRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarFichaRequest", ReplyAction="http://ws/Listar/listarFichaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WcfService1.ServiceReference1.listarFichaResponse listarFicha(WcfService1.ServiceReference1.listarFichaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarFichaRequest", ReplyAction="http://ws/Listar/listarFichaResponse")]
        System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarFichaResponse> listarFichaAsync(WcfService1.ServiceReference1.listarFichaRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarUsuarioRequest", ReplyAction="http://ws/Listar/listarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WcfService1.ServiceReference1.listarUsuarioResponse listarUsuario(WcfService1.ServiceReference1.listarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarUsuarioRequest", ReplyAction="http://ws/Listar/listarUsuarioResponse")]
        System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarUsuarioResponse> listarUsuarioAsync(WcfService1.ServiceReference1.listarUsuarioRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class rol : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private int idRolField;
        
        private bool idRolFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int idRol {
            get {
                return this.idRolField;
            }
            set {
                this.idRolField = value;
                this.RaisePropertyChanged("idRol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idRolSpecified {
            get {
                return this.idRolFieldSpecified;
            }
            set {
                this.idRolFieldSpecified = value;
                this.RaisePropertyChanged("idRolSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string claveField;
        
        private ficha fichaField;
        
        private int idUsuarioField;
        
        private bool idUsuarioFieldSpecified;
        
        private string nombreUsuarioField;
        
        private rol rolField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string clave {
            get {
                return this.claveField;
            }
            set {
                this.claveField = value;
                this.RaisePropertyChanged("clave");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ficha ficha {
            get {
                return this.fichaField;
            }
            set {
                this.fichaField = value;
                this.RaisePropertyChanged("ficha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("idUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idUsuarioSpecified {
            get {
                return this.idUsuarioFieldSpecified;
            }
            set {
                this.idUsuarioFieldSpecified = value;
                this.RaisePropertyChanged("idUsuarioSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombreUsuario {
            get {
                return this.nombreUsuarioField;
            }
            set {
                this.nombreUsuarioField = value;
                this.RaisePropertyChanged("nombreUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public rol rol {
            get {
                return this.rolField;
            }
            set {
                this.rolField = value;
                this.RaisePropertyChanged("rol");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class ficha : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string direccionField;
        
        private byte[] fotografiaField;
        
        private int huellaField;
        
        private int idFichaField;
        
        private bool idFichaFieldSpecified;
        
        private string nombresField;
        
        private string rutField;
        
        private string telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=2)]
        public byte[] fotografia {
            get {
                return this.fotografiaField;
            }
            set {
                this.fotografiaField = value;
                this.RaisePropertyChanged("fotografia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int huella {
            get {
                return this.huellaField;
            }
            set {
                this.huellaField = value;
                this.RaisePropertyChanged("huella");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idFicha {
            get {
                return this.idFichaField;
            }
            set {
                this.idFichaField = value;
                this.RaisePropertyChanged("idFicha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idFichaSpecified {
            get {
                return this.idFichaFieldSpecified;
            }
            set {
                this.idFichaFieldSpecified = value;
                this.RaisePropertyChanged("idFichaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                this.nombresField = value;
                this.RaisePropertyChanged("nombres");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("rut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarRol", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listarRolRequest {
        
        public listarRolRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarRolResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listarRolResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WcfService1.ServiceReference1.rol[] @return;
        
        public listarRolResponse() {
        }
        
        public listarRolResponse(WcfService1.ServiceReference1.rol[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarFicha", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listarFichaRequest {
        
        public listarFichaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarFichaResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listarFichaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WcfService1.ServiceReference1.ficha[] @return;
        
        public listarFichaResponse() {
        }
        
        public listarFichaResponse(WcfService1.ServiceReference1.ficha[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarUsuario", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listarUsuarioRequest {
        
        public listarUsuarioRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarUsuarioResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WcfService1.ServiceReference1.usuario[] @return;
        
        public listarUsuarioResponse() {
        }
        
        public listarUsuarioResponse(WcfService1.ServiceReference1.usuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ListarChannel : WcfService1.ServiceReference1.Listar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListarClient : System.ServiceModel.ClientBase<WcfService1.ServiceReference1.Listar>, WcfService1.ServiceReference1.Listar {
        
        public ListarClient() {
        }
        
        public ListarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ListarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfService1.ServiceReference1.listarRolResponse WcfService1.ServiceReference1.Listar.listarRol(WcfService1.ServiceReference1.listarRolRequest request) {
            return base.Channel.listarRol(request);
        }
        
        public WcfService1.ServiceReference1.rol[] listarRol() {
            WcfService1.ServiceReference1.listarRolRequest inValue = new WcfService1.ServiceReference1.listarRolRequest();
            WcfService1.ServiceReference1.listarRolResponse retVal = ((WcfService1.ServiceReference1.Listar)(this)).listarRol(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarRolResponse> WcfService1.ServiceReference1.Listar.listarRolAsync(WcfService1.ServiceReference1.listarRolRequest request) {
            return base.Channel.listarRolAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarRolResponse> listarRolAsync() {
            WcfService1.ServiceReference1.listarRolRequest inValue = new WcfService1.ServiceReference1.listarRolRequest();
            return ((WcfService1.ServiceReference1.Listar)(this)).listarRolAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfService1.ServiceReference1.listarFichaResponse WcfService1.ServiceReference1.Listar.listarFicha(WcfService1.ServiceReference1.listarFichaRequest request) {
            return base.Channel.listarFicha(request);
        }
        
        public WcfService1.ServiceReference1.ficha[] listarFicha() {
            WcfService1.ServiceReference1.listarFichaRequest inValue = new WcfService1.ServiceReference1.listarFichaRequest();
            WcfService1.ServiceReference1.listarFichaResponse retVal = ((WcfService1.ServiceReference1.Listar)(this)).listarFicha(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarFichaResponse> WcfService1.ServiceReference1.Listar.listarFichaAsync(WcfService1.ServiceReference1.listarFichaRequest request) {
            return base.Channel.listarFichaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarFichaResponse> listarFichaAsync() {
            WcfService1.ServiceReference1.listarFichaRequest inValue = new WcfService1.ServiceReference1.listarFichaRequest();
            return ((WcfService1.ServiceReference1.Listar)(this)).listarFichaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfService1.ServiceReference1.listarUsuarioResponse WcfService1.ServiceReference1.Listar.listarUsuario(WcfService1.ServiceReference1.listarUsuarioRequest request) {
            return base.Channel.listarUsuario(request);
        }
        
        public WcfService1.ServiceReference1.usuario[] listarUsuario() {
            WcfService1.ServiceReference1.listarUsuarioRequest inValue = new WcfService1.ServiceReference1.listarUsuarioRequest();
            WcfService1.ServiceReference1.listarUsuarioResponse retVal = ((WcfService1.ServiceReference1.Listar)(this)).listarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarUsuarioResponse> WcfService1.ServiceReference1.Listar.listarUsuarioAsync(WcfService1.ServiceReference1.listarUsuarioRequest request) {
            return base.Channel.listarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfService1.ServiceReference1.listarUsuarioResponse> listarUsuarioAsync() {
            WcfService1.ServiceReference1.listarUsuarioRequest inValue = new WcfService1.ServiceReference1.listarUsuarioRequest();
            return ((WcfService1.ServiceReference1.Listar)(this)).listarUsuarioAsync(inValue);
        }
    }
}
