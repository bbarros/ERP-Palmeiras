﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_Palmeiras_RH.LogisticaAbastecimento {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LogisticaAbastecimento.UsuariosWSSoap")]
    public interface UsuariosWSSoap {
        
        // CODEGEN: Generating message contract since element name login from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InserirUsuario", ReplyAction="*")]
        ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioResponse InserirUsuario(ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name loginNovo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AlterarUsuario", ReplyAction="*")]
        ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioResponse AlterarUsuario(ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InserirUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InserirUsuario", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequestBody Body;
        
        public InserirUsuarioRequest() {
        }
        
        public InserirUsuarioRequest(ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InserirUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string senha;
        
        public InserirUsuarioRequestBody() {
        }
        
        public InserirUsuarioRequestBody(string login, string senha) {
            this.login = login;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InserirUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InserirUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioResponseBody Body;
        
        public InserirUsuarioResponse() {
        }
        
        public InserirUsuarioResponse(ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InserirUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InserirUsuarioResult;
        
        public InserirUsuarioResponseBody() {
        }
        
        public InserirUsuarioResponseBody(bool InserirUsuarioResult) {
            this.InserirUsuarioResult = InserirUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AlterarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AlterarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequestBody Body;
        
        public AlterarUsuarioRequest() {
        }
        
        public AlterarUsuarioRequest(ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AlterarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string loginNovo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string loginAntigo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string senhaNova;
        
        public AlterarUsuarioRequestBody() {
        }
        
        public AlterarUsuarioRequestBody(string loginNovo, string loginAntigo, string senhaNova) {
            this.loginNovo = loginNovo;
            this.loginAntigo = loginAntigo;
            this.senhaNova = senhaNova;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AlterarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AlterarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioResponseBody Body;
        
        public AlterarUsuarioResponse() {
        }
        
        public AlterarUsuarioResponse(ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AlterarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AlterarUsuarioResult;
        
        public AlterarUsuarioResponseBody() {
        }
        
        public AlterarUsuarioResponseBody(bool AlterarUsuarioResult) {
            this.AlterarUsuarioResult = AlterarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UsuariosWSSoapChannel : ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuariosWSSoapClient : System.ServiceModel.ClientBase<ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap>, ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap {
        
        public UsuariosWSSoapClient() {
        }
        
        public UsuariosWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuariosWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioResponse ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap.InserirUsuario(ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequest request) {
            return base.Channel.InserirUsuario(request);
        }
        
        public bool InserirUsuario(string login, string senha) {
            ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequest inValue = new ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequest();
            inValue.Body = new ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioRequestBody();
            inValue.Body.login = login;
            inValue.Body.senha = senha;
            ERP_Palmeiras_RH.LogisticaAbastecimento.InserirUsuarioResponse retVal = ((ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap)(this)).InserirUsuario(inValue);
            return retVal.Body.InserirUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioResponse ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap.AlterarUsuario(ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequest request) {
            return base.Channel.AlterarUsuario(request);
        }
        
        public bool AlterarUsuario(string loginNovo, string loginAntigo, string senhaNova) {
            ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequest inValue = new ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequest();
            inValue.Body = new ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioRequestBody();
            inValue.Body.loginNovo = loginNovo;
            inValue.Body.loginAntigo = loginAntigo;
            inValue.Body.senhaNova = senhaNova;
            ERP_Palmeiras_RH.LogisticaAbastecimento.AlterarUsuarioResponse retVal = ((ERP_Palmeiras_RH.LogisticaAbastecimento.UsuariosWSSoap)(this)).AlterarUsuario(inValue);
            return retVal.Body.AlterarUsuarioResult;
        }
    }
}
