﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PX.Api.ContractBased.Maintenance.Cli.Maintenance531 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.acumatica.com/entity/", ConfigurationName="Maintenance531.EntityMaintenanceSoap")]
    public interface EntityMaintenanceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://www.acumatica.com/entity/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/Login", ReplyAction="*")]
        PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponse Login(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponse> LoginAsync(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/Logout", ReplyAction="*")]
        void Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/Logout", ReplyAction="*")]
        System.Threading.Tasks.Task LogoutAsync();
        
        // CODEGEN: Generating message contract since element name version from namespace http://www.acumatica.com/entity/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/GetSchema", ReplyAction="*")]
        PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponse GetSchema(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/GetSchema", ReplyAction="*")]
        System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponse> GetSchemaAsync(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest request);
        
        // CODEGEN: Generating message contract since element name schema from namespace http://www.acumatica.com/entity/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/PutSchema", ReplyAction="*")]
        PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponse PutSchema(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.acumatica.com/entity/PutSchema", ReplyAction="*")]
        System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponse> PutSchemaAsync(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://www.acumatica.com/entity/", Order=0)]
        public PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.acumatica.com/entity/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string company;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string branch;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string locale;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string name, string password, string company, string branch, string locale) {
            this.name = name;
            this.password = password;
            this.company = company;
            this.branch = branch;
            this.locale = locale;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://www.acumatica.com/entity/", Order=0)]
        public PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class LoginResponseBody {
        
        public LoginResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSchemaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSchema", Namespace="http://www.acumatica.com/entity/", Order=0)]
        public PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequestBody Body;
        
        public GetSchemaRequest() {
        }
        
        public GetSchemaRequest(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.acumatica.com/entity/")]
    public partial class GetSchemaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string version;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string endpoint;
        
        public GetSchemaRequestBody() {
        }
        
        public GetSchemaRequestBody(string version, string endpoint) {
            this.version = version;
            this.endpoint = endpoint;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSchemaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSchemaResponse", Namespace="http://www.acumatica.com/entity/", Order=0)]
        public PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponseBody Body;
        
        public GetSchemaResponse() {
        }
        
        public GetSchemaResponse(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.acumatica.com/entity/")]
    public partial class GetSchemaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetSchemaResult;
        
        public GetSchemaResponseBody() {
        }
        
        public GetSchemaResponseBody(string GetSchemaResult) {
            this.GetSchemaResult = GetSchemaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PutSchemaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PutSchema", Namespace="http://www.acumatica.com/entity/", Order=0)]
        public PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequestBody Body;
        
        public PutSchemaRequest() {
        }
        
        public PutSchemaRequest(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.acumatica.com/entity/")]
    public partial class PutSchemaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string schema;
        
        public PutSchemaRequestBody() {
        }
        
        public PutSchemaRequestBody(string schema) {
            this.schema = schema;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PutSchemaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PutSchemaResponse", Namespace="http://www.acumatica.com/entity/", Order=0)]
        public PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponseBody Body;
        
        public PutSchemaResponse() {
        }
        
        public PutSchemaResponse(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class PutSchemaResponseBody {
        
        public PutSchemaResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EntityMaintenanceSoapChannel : PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntityMaintenanceSoapClient : System.ServiceModel.ClientBase<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap>, PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap {
        
        public EntityMaintenanceSoapClient() {
        }
        
        public EntityMaintenanceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntityMaintenanceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityMaintenanceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityMaintenanceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponse PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap.Login(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public void Login(string name, string password, string company, string branch, string locale) {
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest inValue = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest();
            inValue.Body = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequestBody();
            inValue.Body.name = name;
            inValue.Body.password = password;
            inValue.Body.company = company;
            inValue.Body.branch = branch;
            inValue.Body.locale = locale;
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponse retVal = ((PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap)(this)).Login(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponse> PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap.LoginAsync(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginResponse> LoginAsync(string name, string password, string company, string branch, string locale) {
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest inValue = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequest();
            inValue.Body = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.LoginRequestBody();
            inValue.Body.name = name;
            inValue.Body.password = password;
            inValue.Body.company = company;
            inValue.Body.branch = branch;
            inValue.Body.locale = locale;
            return ((PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap)(this)).LoginAsync(inValue);
        }
        
        public void Logout() {
            base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponse PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap.GetSchema(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest request) {
            return base.Channel.GetSchema(request);
        }
        
        public string GetSchema(string version, string endpoint) {
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest inValue = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest();
            inValue.Body = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequestBody();
            inValue.Body.version = version;
            inValue.Body.endpoint = endpoint;
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponse retVal = ((PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap)(this)).GetSchema(inValue);
            return retVal.Body.GetSchemaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponse> PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap.GetSchemaAsync(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest request) {
            return base.Channel.GetSchemaAsync(request);
        }
        
        public System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaResponse> GetSchemaAsync(string version, string endpoint) {
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest inValue = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequest();
            inValue.Body = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.GetSchemaRequestBody();
            inValue.Body.version = version;
            inValue.Body.endpoint = endpoint;
            return ((PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap)(this)).GetSchemaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponse PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap.PutSchema(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest request) {
            return base.Channel.PutSchema(request);
        }
        
        public void PutSchema(string schema) {
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest inValue = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest();
            inValue.Body = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequestBody();
            inValue.Body.schema = schema;
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponse retVal = ((PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap)(this)).PutSchema(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponse> PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap.PutSchemaAsync(PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest request) {
            return base.Channel.PutSchemaAsync(request);
        }
        
        public System.Threading.Tasks.Task<PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaResponse> PutSchemaAsync(string schema) {
            PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest inValue = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequest();
            inValue.Body = new PX.Api.ContractBased.Maintenance.Cli.Maintenance531.PutSchemaRequestBody();
            inValue.Body.schema = schema;
            return ((PX.Api.ContractBased.Maintenance.Cli.Maintenance531.EntityMaintenanceSoap)(this)).PutSchemaAsync(inValue);
        }
    }
}
