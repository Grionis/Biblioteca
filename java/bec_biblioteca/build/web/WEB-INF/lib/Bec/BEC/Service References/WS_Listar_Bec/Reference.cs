﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEC.WS_Listar_Bec {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="WS_Listar_Bec.Listar")]
    public interface Listar {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarRolRequest", ReplyAction="http://ws/Listar/listarRolResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        BEC.WS_Listar_Bec.listarRolResponse listarRol(BEC.WS_Listar_Bec.listarRolRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarRolRequest", ReplyAction="http://ws/Listar/listarRolResponse")]
        System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarRolResponse> listarRolAsync(BEC.WS_Listar_Bec.listarRolRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarFichaRequest", ReplyAction="http://ws/Listar/listarFichaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        BEC.WS_Listar_Bec.listarFichaResponse listarFicha(BEC.WS_Listar_Bec.listarFichaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarFichaRequest", ReplyAction="http://ws/Listar/listarFichaResponse")]
        System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarFichaResponse> listarFichaAsync(BEC.WS_Listar_Bec.listarFichaRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarUsuarioRequest", ReplyAction="http://ws/Listar/listarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        BEC.WS_Listar_Bec.listarUsuarioResponse listarUsuario(BEC.WS_Listar_Bec.listarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/Listar/listarUsuarioRequest", ReplyAction="http://ws/Listar/listarUsuarioResponse")]
        System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarUsuarioResponse> listarUsuarioAsync(BEC.WS_Listar_Bec.listarUsuarioRequest request);
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
        public BEC.WS_Listar_Bec.rol[] @return;
        
        public listarRolResponse() {
        }
        
        public listarRolResponse(BEC.WS_Listar_Bec.rol[] @return) {
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
        public BEC.WS_Listar_Bec.ficha[] @return;
        
        public listarFichaResponse() {
        }
        
        public listarFichaResponse(BEC.WS_Listar_Bec.ficha[] @return) {
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
        public BEC.WS_Listar_Bec.usuario[] @return;
        
        public listarUsuarioResponse() {
        }
        
        public listarUsuarioResponse(BEC.WS_Listar_Bec.usuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ListarChannel : BEC.WS_Listar_Bec.Listar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListarClient : System.ServiceModel.ClientBase<BEC.WS_Listar_Bec.Listar>, BEC.WS_Listar_Bec.Listar {
        
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
        BEC.WS_Listar_Bec.listarRolResponse BEC.WS_Listar_Bec.Listar.listarRol(BEC.WS_Listar_Bec.listarRolRequest request) {
            return base.Channel.listarRol(request);
        }
        
        public BEC.WS_Listar_Bec.rol[] listarRol() {
            BEC.WS_Listar_Bec.listarRolRequest inValue = new BEC.WS_Listar_Bec.listarRolRequest();
            BEC.WS_Listar_Bec.listarRolResponse retVal = ((BEC.WS_Listar_Bec.Listar)(this)).listarRol(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarRolResponse> BEC.WS_Listar_Bec.Listar.listarRolAsync(BEC.WS_Listar_Bec.listarRolRequest request) {
            return base.Channel.listarRolAsync(request);
        }
        
        public System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarRolResponse> listarRolAsync() {
            BEC.WS_Listar_Bec.listarRolRequest inValue = new BEC.WS_Listar_Bec.listarRolRequest();
            return ((BEC.WS_Listar_Bec.Listar)(this)).listarRolAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BEC.WS_Listar_Bec.listarFichaResponse BEC.WS_Listar_Bec.Listar.listarFicha(BEC.WS_Listar_Bec.listarFichaRequest request) {
            return base.Channel.listarFicha(request);
        }
        
        public BEC.WS_Listar_Bec.ficha[] listarFicha() {
            BEC.WS_Listar_Bec.listarFichaRequest inValue = new BEC.WS_Listar_Bec.listarFichaRequest();
            BEC.WS_Listar_Bec.listarFichaResponse retVal = ((BEC.WS_Listar_Bec.Listar)(this)).listarFicha(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarFichaResponse> BEC.WS_Listar_Bec.Listar.listarFichaAsync(BEC.WS_Listar_Bec.listarFichaRequest request) {
            return base.Channel.listarFichaAsync(request);
        }
        
        public System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarFichaResponse> listarFichaAsync() {
            BEC.WS_Listar_Bec.listarFichaRequest inValue = new BEC.WS_Listar_Bec.listarFichaRequest();
            return ((BEC.WS_Listar_Bec.Listar)(this)).listarFichaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BEC.WS_Listar_Bec.listarUsuarioResponse BEC.WS_Listar_Bec.Listar.listarUsuario(BEC.WS_Listar_Bec.listarUsuarioRequest request) {
            return base.Channel.listarUsuario(request);
        }
        
        public BEC.WS_Listar_Bec.usuario[] listarUsuario() {
            BEC.WS_Listar_Bec.listarUsuarioRequest inValue = new BEC.WS_Listar_Bec.listarUsuarioRequest();
            BEC.WS_Listar_Bec.listarUsuarioResponse retVal = ((BEC.WS_Listar_Bec.Listar)(this)).listarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarUsuarioResponse> BEC.WS_Listar_Bec.Listar.listarUsuarioAsync(BEC.WS_Listar_Bec.listarUsuarioRequest request) {
            return base.Channel.listarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<BEC.WS_Listar_Bec.listarUsuarioResponse> listarUsuarioAsync() {
            BEC.WS_Listar_Bec.listarUsuarioRequest inValue = new BEC.WS_Listar_Bec.listarUsuarioRequest();
            return ((BEC.WS_Listar_Bec.Listar)(this)).listarUsuarioAsync(inValue);
        }
    }
}
