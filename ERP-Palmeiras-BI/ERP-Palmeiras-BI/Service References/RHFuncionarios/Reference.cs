﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_Palmeiras_BI.RHFuncionarios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EspecialidadeDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class EspecialidadeDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicoDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MedicoDTO : ERP_Palmeiras_BI.RHFuncionarios.FuncionarioDTO {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CrmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EspecialidadeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Crm {
            get {
                return this.CrmField;
            }
            set {
                if ((object.ReferenceEquals(this.CrmField, value) != true)) {
                    this.CrmField = value;
                    this.RaisePropertyChanged("Crm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Especialidade {
            get {
                return this.EspecialidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadeField, value) != true)) {
                    this.EspecialidadeField = value;
                    this.RaisePropertyChanged("Especialidade");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FuncionarioDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO))]
    public partial class FuncionarioDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SobrenomeField;
        
        private long CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        private bool IsMedicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CargoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Sobrenome {
            get {
                return this.SobrenomeField;
            }
            set {
                if ((object.ReferenceEquals(this.SobrenomeField, value) != true)) {
                    this.SobrenomeField = value;
                    this.RaisePropertyChanged("Sobrenome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public long Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((this.CpfField.Equals(value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsMedico {
            get {
                return this.IsMedicoField;
            }
            set {
                if ((this.IsMedicoField.Equals(value) != true)) {
                    this.IsMedicoField = value;
                    this.RaisePropertyChanged("IsMedico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Cargo {
            get {
                return this.CargoField;
            }
            set {
                if ((object.ReferenceEquals(this.CargoField, value) != true)) {
                    this.CargoField = value;
                    this.RaisePropertyChanged("Cargo");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RHFuncionarios.FuncionariosWSSoap")]
    public interface FuncionariosWSSoap {
        
        // CODEGEN: Generating message contract since element name BuscarEspecialidadesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarEspecialidades", ReplyAction="*")]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesResponse BuscarEspecialidades(ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequest request);
        
        // CODEGEN: Generating message contract since element name BuscarMedicosResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarMedicos", ReplyAction="*")]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosResponse BuscarMedicos(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequest request);
        
        // CODEGEN: Generating message contract since element name BuscarMedicoPorCpfResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarMedicoPorCpf", ReplyAction="*")]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfResponse BuscarMedicoPorCpf(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequest request);
        
        // CODEGEN: Generating message contract since element name BuscarMedicoPorIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarMedicoPorId", ReplyAction="*")]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdResponse BuscarMedicoPorId(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequest request);
        
        // CODEGEN: Generating message contract since element name login from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarFuncionario", ReplyAction="*")]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioResponse BuscarFuncionario(ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarEspecialidadesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarEspecialidades", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequestBody Body;
        
        public BuscarEspecialidadesRequest() {
        }
        
        public BuscarEspecialidadesRequest(ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class BuscarEspecialidadesRequestBody {
        
        public BuscarEspecialidadesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarEspecialidadesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarEspecialidadesResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesResponseBody Body;
        
        public BuscarEspecialidadesResponse() {
        }
        
        public BuscarEspecialidadesResponse(ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarEspecialidadesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.EspecialidadeDTO[] BuscarEspecialidadesResult;
        
        public BuscarEspecialidadesResponseBody() {
        }
        
        public BuscarEspecialidadesResponseBody(ERP_Palmeiras_BI.RHFuncionarios.EspecialidadeDTO[] BuscarEspecialidadesResult) {
            this.BuscarEspecialidadesResult = BuscarEspecialidadesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarMedicosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarMedicos", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequestBody Body;
        
        public BuscarMedicosRequest() {
        }
        
        public BuscarMedicosRequest(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class BuscarMedicosRequestBody {
        
        public BuscarMedicosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarMedicosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarMedicosResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosResponseBody Body;
        
        public BuscarMedicosResponse() {
        }
        
        public BuscarMedicosResponse(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarMedicosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO[] BuscarMedicosResult;
        
        public BuscarMedicosResponseBody() {
        }
        
        public BuscarMedicosResponseBody(ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO[] BuscarMedicosResult) {
            this.BuscarMedicosResult = BuscarMedicosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarMedicoPorCpfRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarMedicoPorCpf", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequestBody Body;
        
        public BuscarMedicoPorCpfRequest() {
        }
        
        public BuscarMedicoPorCpfRequest(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarMedicoPorCpfRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long cpf;
        
        public BuscarMedicoPorCpfRequestBody() {
        }
        
        public BuscarMedicoPorCpfRequestBody(long cpf) {
            this.cpf = cpf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarMedicoPorCpfResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarMedicoPorCpfResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfResponseBody Body;
        
        public BuscarMedicoPorCpfResponse() {
        }
        
        public BuscarMedicoPorCpfResponse(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarMedicoPorCpfResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO BuscarMedicoPorCpfResult;
        
        public BuscarMedicoPorCpfResponseBody() {
        }
        
        public BuscarMedicoPorCpfResponseBody(ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO BuscarMedicoPorCpfResult) {
            this.BuscarMedicoPorCpfResult = BuscarMedicoPorCpfResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarMedicoPorIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarMedicoPorId", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequestBody Body;
        
        public BuscarMedicoPorIdRequest() {
        }
        
        public BuscarMedicoPorIdRequest(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarMedicoPorIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int medicoId;
        
        public BuscarMedicoPorIdRequestBody() {
        }
        
        public BuscarMedicoPorIdRequestBody(int medicoId) {
            this.medicoId = medicoId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarMedicoPorIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarMedicoPorIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdResponseBody Body;
        
        public BuscarMedicoPorIdResponse() {
        }
        
        public BuscarMedicoPorIdResponse(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarMedicoPorIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO BuscarMedicoPorIdResult;
        
        public BuscarMedicoPorIdResponseBody() {
        }
        
        public BuscarMedicoPorIdResponseBody(ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO BuscarMedicoPorIdResult) {
            this.BuscarMedicoPorIdResult = BuscarMedicoPorIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarFuncionarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarFuncionario", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequestBody Body;
        
        public BuscarFuncionarioRequest() {
        }
        
        public BuscarFuncionarioRequest(ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarFuncionarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        public BuscarFuncionarioRequestBody() {
        }
        
        public BuscarFuncionarioRequestBody(string login) {
            this.login = login;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarFuncionarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarFuncionarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioResponseBody Body;
        
        public BuscarFuncionarioResponse() {
        }
        
        public BuscarFuncionarioResponse(ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarFuncionarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ERP_Palmeiras_BI.RHFuncionarios.FuncionarioDTO BuscarFuncionarioResult;
        
        public BuscarFuncionarioResponseBody() {
        }
        
        public BuscarFuncionarioResponseBody(ERP_Palmeiras_BI.RHFuncionarios.FuncionarioDTO BuscarFuncionarioResult) {
            this.BuscarFuncionarioResult = BuscarFuncionarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FuncionariosWSSoapChannel : ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FuncionariosWSSoapClient : System.ServiceModel.ClientBase<ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap>, ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap {
        
        public FuncionariosWSSoapClient() {
        }
        
        public FuncionariosWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FuncionariosWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuncionariosWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuncionariosWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesResponse ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap.BuscarEspecialidades(ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequest request) {
            return base.Channel.BuscarEspecialidades(request);
        }
        
        public ERP_Palmeiras_BI.RHFuncionarios.EspecialidadeDTO[] BuscarEspecialidades() {
            ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequest inValue = new ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequest();
            inValue.Body = new ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesRequestBody();
            ERP_Palmeiras_BI.RHFuncionarios.BuscarEspecialidadesResponse retVal = ((ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap)(this)).BuscarEspecialidades(inValue);
            return retVal.Body.BuscarEspecialidadesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosResponse ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap.BuscarMedicos(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequest request) {
            return base.Channel.BuscarMedicos(request);
        }
        
        public ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO[] BuscarMedicos() {
            ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequest inValue = new ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequest();
            inValue.Body = new ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosRequestBody();
            ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicosResponse retVal = ((ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap)(this)).BuscarMedicos(inValue);
            return retVal.Body.BuscarMedicosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfResponse ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap.BuscarMedicoPorCpf(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequest request) {
            return base.Channel.BuscarMedicoPorCpf(request);
        }
        
        public ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO BuscarMedicoPorCpf(long cpf) {
            ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequest inValue = new ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequest();
            inValue.Body = new ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfRequestBody();
            inValue.Body.cpf = cpf;
            ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorCpfResponse retVal = ((ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap)(this)).BuscarMedicoPorCpf(inValue);
            return retVal.Body.BuscarMedicoPorCpfResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdResponse ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap.BuscarMedicoPorId(ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequest request) {
            return base.Channel.BuscarMedicoPorId(request);
        }
        
        public ERP_Palmeiras_BI.RHFuncionarios.MedicoDTO BuscarMedicoPorId(int medicoId) {
            ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequest inValue = new ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequest();
            inValue.Body = new ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdRequestBody();
            inValue.Body.medicoId = medicoId;
            ERP_Palmeiras_BI.RHFuncionarios.BuscarMedicoPorIdResponse retVal = ((ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap)(this)).BuscarMedicoPorId(inValue);
            return retVal.Body.BuscarMedicoPorIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioResponse ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap.BuscarFuncionario(ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequest request) {
            return base.Channel.BuscarFuncionario(request);
        }
        
        public ERP_Palmeiras_BI.RHFuncionarios.FuncionarioDTO BuscarFuncionario(string login) {
            ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequest inValue = new ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequest();
            inValue.Body = new ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioRequestBody();
            inValue.Body.login = login;
            ERP_Palmeiras_BI.RHFuncionarios.BuscarFuncionarioResponse retVal = ((ERP_Palmeiras_BI.RHFuncionarios.FuncionariosWSSoap)(this)).BuscarFuncionario(inValue);
            return retVal.Body.BuscarFuncionarioResult;
        }
    }
}
