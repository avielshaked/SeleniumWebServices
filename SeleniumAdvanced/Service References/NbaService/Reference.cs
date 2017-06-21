﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeleniumAdvanced.NbaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerData", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PlayerData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int playeridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string positionField;
        
        private int teamidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int playerid {
            get {
                return this.playeridField;
            }
            set {
                if ((this.playeridField.Equals(value) != true)) {
                    this.playeridField = value;
                    this.RaisePropertyChanged("playerid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string position {
            get {
                return this.positionField;
            }
            set {
                if ((object.ReferenceEquals(this.positionField, value) != true)) {
                    this.positionField = value;
                    this.RaisePropertyChanged("position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int teamid {
            get {
                return this.teamidField;
            }
            set {
                if ((this.teamidField.Equals(value) != true)) {
                    this.teamidField = value;
                    this.RaisePropertyChanged("teamid");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NbaService.NBASoap")]
    public interface NBASoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        SeleniumAdvanced.NbaService.HelloWorldResponse HelloWorld(SeleniumAdvanced.NbaService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.HelloWorldResponse> HelloWorldAsync(SeleniumAdvanced.NbaService.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name pos from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerData", ReplyAction="*")]
        SeleniumAdvanced.NbaService.GetPlayerDataResponse GetPlayerData(SeleniumAdvanced.NbaService.GetPlayerDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerData", ReplyAction="*")]
        System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.GetPlayerDataResponse> GetPlayerDataAsync(SeleniumAdvanced.NbaService.GetPlayerDataRequest request);
        
        // CODEGEN: Generating message contract since element name GetPlayerDatajsonResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerDatajson", ReplyAction="*")]
        SeleniumAdvanced.NbaService.GetPlayerDatajsonResponse GetPlayerDatajson(SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerDatajson", ReplyAction="*")]
        System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.GetPlayerDatajsonResponse> GetPlayerDatajsonAsync(SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public SeleniumAdvanced.NbaService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(SeleniumAdvanced.NbaService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public SeleniumAdvanced.NbaService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(SeleniumAdvanced.NbaService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPlayerDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPlayerData", Namespace="http://tempuri.org/", Order=0)]
        public SeleniumAdvanced.NbaService.GetPlayerDataRequestBody Body;
        
        public GetPlayerDataRequest() {
        }
        
        public GetPlayerDataRequest(SeleniumAdvanced.NbaService.GetPlayerDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPlayerDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pos;
        
        public GetPlayerDataRequestBody() {
        }
        
        public GetPlayerDataRequestBody(string pos) {
            this.pos = pos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPlayerDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPlayerDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public SeleniumAdvanced.NbaService.GetPlayerDataResponseBody Body;
        
        public GetPlayerDataResponse() {
        }
        
        public GetPlayerDataResponse(SeleniumAdvanced.NbaService.GetPlayerDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPlayerDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SeleniumAdvanced.NbaService.PlayerData[] GetPlayerDataResult;
        
        public GetPlayerDataResponseBody() {
        }
        
        public GetPlayerDataResponseBody(SeleniumAdvanced.NbaService.PlayerData[] GetPlayerDataResult) {
            this.GetPlayerDataResult = GetPlayerDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPlayerDatajsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPlayerDatajson", Namespace="http://tempuri.org/", Order=0)]
        public SeleniumAdvanced.NbaService.GetPlayerDatajsonRequestBody Body;
        
        public GetPlayerDatajsonRequest() {
        }
        
        public GetPlayerDatajsonRequest(SeleniumAdvanced.NbaService.GetPlayerDatajsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPlayerDatajsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int teamid;
        
        public GetPlayerDatajsonRequestBody() {
        }
        
        public GetPlayerDatajsonRequestBody(int teamid) {
            this.teamid = teamid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPlayerDatajsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPlayerDatajsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public SeleniumAdvanced.NbaService.GetPlayerDatajsonResponseBody Body;
        
        public GetPlayerDatajsonResponse() {
        }
        
        public GetPlayerDatajsonResponse(SeleniumAdvanced.NbaService.GetPlayerDatajsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPlayerDatajsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetPlayerDatajsonResult;
        
        public GetPlayerDatajsonResponseBody() {
        }
        
        public GetPlayerDatajsonResponseBody(string GetPlayerDatajsonResult) {
            this.GetPlayerDatajsonResult = GetPlayerDatajsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NBASoapChannel : SeleniumAdvanced.NbaService.NBASoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NBASoapClient : System.ServiceModel.ClientBase<SeleniumAdvanced.NbaService.NBASoap>, SeleniumAdvanced.NbaService.NBASoap {
        
        public NBASoapClient() {
        }
        
        public NBASoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NBASoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NBASoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NBASoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SeleniumAdvanced.NbaService.HelloWorldResponse SeleniumAdvanced.NbaService.NBASoap.HelloWorld(SeleniumAdvanced.NbaService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            SeleniumAdvanced.NbaService.HelloWorldRequest inValue = new SeleniumAdvanced.NbaService.HelloWorldRequest();
            inValue.Body = new SeleniumAdvanced.NbaService.HelloWorldRequestBody();
            SeleniumAdvanced.NbaService.HelloWorldResponse retVal = ((SeleniumAdvanced.NbaService.NBASoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.HelloWorldResponse> SeleniumAdvanced.NbaService.NBASoap.HelloWorldAsync(SeleniumAdvanced.NbaService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.HelloWorldResponse> HelloWorldAsync() {
            SeleniumAdvanced.NbaService.HelloWorldRequest inValue = new SeleniumAdvanced.NbaService.HelloWorldRequest();
            inValue.Body = new SeleniumAdvanced.NbaService.HelloWorldRequestBody();
            return ((SeleniumAdvanced.NbaService.NBASoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SeleniumAdvanced.NbaService.GetPlayerDataResponse SeleniumAdvanced.NbaService.NBASoap.GetPlayerData(SeleniumAdvanced.NbaService.GetPlayerDataRequest request) {
            return base.Channel.GetPlayerData(request);
        }
        
        public SeleniumAdvanced.NbaService.PlayerData[] GetPlayerData(string pos) {
            SeleniumAdvanced.NbaService.GetPlayerDataRequest inValue = new SeleniumAdvanced.NbaService.GetPlayerDataRequest();
            inValue.Body = new SeleniumAdvanced.NbaService.GetPlayerDataRequestBody();
            inValue.Body.pos = pos;
            SeleniumAdvanced.NbaService.GetPlayerDataResponse retVal = ((SeleniumAdvanced.NbaService.NBASoap)(this)).GetPlayerData(inValue);
            return retVal.Body.GetPlayerDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.GetPlayerDataResponse> SeleniumAdvanced.NbaService.NBASoap.GetPlayerDataAsync(SeleniumAdvanced.NbaService.GetPlayerDataRequest request) {
            return base.Channel.GetPlayerDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.GetPlayerDataResponse> GetPlayerDataAsync(string pos) {
            SeleniumAdvanced.NbaService.GetPlayerDataRequest inValue = new SeleniumAdvanced.NbaService.GetPlayerDataRequest();
            inValue.Body = new SeleniumAdvanced.NbaService.GetPlayerDataRequestBody();
            inValue.Body.pos = pos;
            return ((SeleniumAdvanced.NbaService.NBASoap)(this)).GetPlayerDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SeleniumAdvanced.NbaService.GetPlayerDatajsonResponse SeleniumAdvanced.NbaService.NBASoap.GetPlayerDatajson(SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest request) {
            return base.Channel.GetPlayerDatajson(request);
        }
        
        public string GetPlayerDatajson(int teamid) {
            SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest inValue = new SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest();
            inValue.Body = new SeleniumAdvanced.NbaService.GetPlayerDatajsonRequestBody();
            inValue.Body.teamid = teamid;
            SeleniumAdvanced.NbaService.GetPlayerDatajsonResponse retVal = ((SeleniumAdvanced.NbaService.NBASoap)(this)).GetPlayerDatajson(inValue);
            return retVal.Body.GetPlayerDatajsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.GetPlayerDatajsonResponse> SeleniumAdvanced.NbaService.NBASoap.GetPlayerDatajsonAsync(SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest request) {
            return base.Channel.GetPlayerDatajsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<SeleniumAdvanced.NbaService.GetPlayerDatajsonResponse> GetPlayerDatajsonAsync(int teamid) {
            SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest inValue = new SeleniumAdvanced.NbaService.GetPlayerDatajsonRequest();
            inValue.Body = new SeleniumAdvanced.NbaService.GetPlayerDatajsonRequestBody();
            inValue.Body.teamid = teamid;
            return ((SeleniumAdvanced.NbaService.NBASoap)(this)).GetPlayerDatajsonAsync(inValue);
        }
    }
}