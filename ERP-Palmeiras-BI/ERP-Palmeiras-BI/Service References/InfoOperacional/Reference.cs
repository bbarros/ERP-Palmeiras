﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_Palmeiras_BI.InfoOperacional {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InfoOperacional.InfoOperacionalSoap")]
    public interface InfoOperacionalSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInfoConsultas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RelatedEnd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Consulta[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        Consulta[] GetInfoConsultas(System.DateTime startDate, System.DateTime endDate);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Consulta : EntityObject {
        
        private int idField;
        
        private int iDPacienteField;
        
        private int iDMedicoField;
        
        private System.DateTime dataField;
        
        private string descricaoField;
        
        private string nomePacienteField;
        
        private string nomeMedicoField;
        
        private bool finalizadaField;
        
        private string pedidoExamesField;
        
        private string pedidoReceitasField;
        
        private EntityReferenceOfMedicos medicosReferenceField;
        
        private EntityReferenceOfPacientes pacientesReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int IDPaciente {
            get {
                return this.iDPacienteField;
            }
            set {
                this.iDPacienteField = value;
                this.RaisePropertyChanged("IDPaciente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int IDMedico {
            get {
                return this.iDMedicoField;
            }
            set {
                this.iDMedicoField = value;
                this.RaisePropertyChanged("IDMedico");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
                this.RaisePropertyChanged("Data");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
                this.RaisePropertyChanged("Descricao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string NomePaciente {
            get {
                return this.nomePacienteField;
            }
            set {
                this.nomePacienteField = value;
                this.RaisePropertyChanged("NomePaciente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string NomeMedico {
            get {
                return this.nomeMedicoField;
            }
            set {
                this.nomeMedicoField = value;
                this.RaisePropertyChanged("NomeMedico");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool Finalizada {
            get {
                return this.finalizadaField;
            }
            set {
                this.finalizadaField = value;
                this.RaisePropertyChanged("Finalizada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string PedidoExames {
            get {
                return this.pedidoExamesField;
            }
            set {
                this.pedidoExamesField = value;
                this.RaisePropertyChanged("PedidoExames");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string PedidoReceitas {
            get {
                return this.pedidoReceitasField;
            }
            set {
                this.pedidoReceitasField = value;
                this.RaisePropertyChanged("PedidoReceitas");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public EntityReferenceOfMedicos MedicosReference {
            get {
                return this.medicosReferenceField;
            }
            set {
                this.medicosReferenceField = value;
                this.RaisePropertyChanged("MedicosReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public EntityReferenceOfPacientes PacientesReference {
            get {
                return this.pacientesReferenceField;
            }
            set {
                this.pacientesReferenceField = value;
                this.RaisePropertyChanged("PacientesReference");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityReferenceOfMedicos : EntityReference {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOfPacientes))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOfMedicos))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityReference : RelatedEnd {
        
        private EntityKey entityKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EntityKey EntityKey {
            get {
                return this.entityKeyField;
            }
            set {
                this.entityKeyField = value;
                this.RaisePropertyChanged("EntityKey");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKey : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string entitySetNameField;
        
        private string entityContainerNameField;
        
        private EntityKeyMember[] entityKeyValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EntitySetName {
            get {
                return this.entitySetNameField;
            }
            set {
                this.entitySetNameField = value;
                this.RaisePropertyChanged("EntitySetName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string EntityContainerName {
            get {
                return this.entityContainerNameField;
            }
            set {
                this.entityContainerNameField = value;
                this.RaisePropertyChanged("EntityContainerName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public EntityKeyMember[] EntityKeyValues {
            get {
                return this.entityKeyValuesField;
            }
            set {
                this.entityKeyValuesField = value;
                this.RaisePropertyChanged("EntityKeyValues");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKeyMember : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private object valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("Key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOfPacientes))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOfMedicos))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class RelatedEnd : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Consulta))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class StructuralObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Consulta))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityObject : StructuralObject {
        
        private EntityKey entityKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EntityKey EntityKey {
            get {
                return this.entityKeyField;
            }
            set {
                this.entityKeyField = value;
                this.RaisePropertyChanged("EntityKey");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityReferenceOfPacientes : EntityReference {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InfoOperacionalSoapChannel : ERP_Palmeiras_BI.InfoOperacional.InfoOperacionalSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InfoOperacionalSoapClient : System.ServiceModel.ClientBase<ERP_Palmeiras_BI.InfoOperacional.InfoOperacionalSoap>, ERP_Palmeiras_BI.InfoOperacional.InfoOperacionalSoap {
        
        public InfoOperacionalSoapClient() {
        }
        
        public InfoOperacionalSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfoOperacionalSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoOperacionalSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoOperacionalSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Consulta[] GetInfoConsultas(System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetInfoConsultas(startDate, endDate);
        }
    }
}