﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sample.ServiceReference {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.NBASoap")]
    public interface NBASoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        sample.ServiceReference.HelloWorldResponse HelloWorld(sample.ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<sample.ServiceReference.HelloWorldResponse> HelloWorldAsync(sample.ServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name pos from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerData", ReplyAction="*")]
        sample.ServiceReference.GetPlayerDataResponse GetPlayerData(sample.ServiceReference.GetPlayerDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerData", ReplyAction="*")]
        System.Threading.Tasks.Task<sample.ServiceReference.GetPlayerDataResponse> GetPlayerDataAsync(sample.ServiceReference.GetPlayerDataRequest request);
        
        // CODEGEN: Generating message contract since element name GetPlayerDatajsonResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerDatajson", ReplyAction="*")]
        sample.ServiceReference.GetPlayerDatajsonResponse GetPlayerDatajson(sample.ServiceReference.GetPlayerDatajsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPlayerDatajson", ReplyAction="*")]
        System.Threading.Tasks.Task<sample.ServiceReference.GetPlayerDatajsonResponse> GetPlayerDatajsonAsync(sample.ServiceReference.GetPlayerDatajsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public sample.ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(sample.ServiceReference.HelloWorldRequestBody Body) {
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
        public sample.ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(sample.ServiceReference.HelloWorldResponseBody Body) {
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
        public sample.ServiceReference.GetPlayerDataRequestBody Body;
        
        public GetPlayerDataRequest() {
        }
        
        public GetPlayerDataRequest(sample.ServiceReference.GetPlayerDataRequestBody Body) {
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
        public sample.ServiceReference.GetPlayerDataResponseBody Body;
        
        public GetPlayerDataResponse() {
        }
        
        public GetPlayerDataResponse(sample.ServiceReference.GetPlayerDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPlayerDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public sample.ServiceReference.PlayerData[] GetPlayerDataResult;
        
        public GetPlayerDataResponseBody() {
        }
        
        public GetPlayerDataResponseBody(sample.ServiceReference.PlayerData[] GetPlayerDataResult) {
            this.GetPlayerDataResult = GetPlayerDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPlayerDatajsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPlayerDatajson", Namespace="http://tempuri.org/", Order=0)]
        public sample.ServiceReference.GetPlayerDatajsonRequestBody Body;
        
        public GetPlayerDatajsonRequest() {
        }
        
        public GetPlayerDatajsonRequest(sample.ServiceReference.GetPlayerDatajsonRequestBody Body) {
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
        public sample.ServiceReference.GetPlayerDatajsonResponseBody Body;
        
        public GetPlayerDatajsonResponse() {
        }
        
        public GetPlayerDatajsonResponse(sample.ServiceReference.GetPlayerDatajsonResponseBody Body) {
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
    public interface NBASoapChannel : sample.ServiceReference.NBASoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NBASoapClient : System.ServiceModel.ClientBase<sample.ServiceReference.NBASoap>, sample.ServiceReference.NBASoap {
        
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
        sample.ServiceReference.HelloWorldResponse sample.ServiceReference.NBASoap.HelloWorld(sample.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            sample.ServiceReference.HelloWorldRequest inValue = new sample.ServiceReference.HelloWorldRequest();
            inValue.Body = new sample.ServiceReference.HelloWorldRequestBody();
            sample.ServiceReference.HelloWorldResponse retVal = ((sample.ServiceReference.NBASoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<sample.ServiceReference.HelloWorldResponse> sample.ServiceReference.NBASoap.HelloWorldAsync(sample.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<sample.ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            sample.ServiceReference.HelloWorldRequest inValue = new sample.ServiceReference.HelloWorldRequest();
            inValue.Body = new sample.ServiceReference.HelloWorldRequestBody();
            return ((sample.ServiceReference.NBASoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        sample.ServiceReference.GetPlayerDataResponse sample.ServiceReference.NBASoap.GetPlayerData(sample.ServiceReference.GetPlayerDataRequest request) {
            return base.Channel.GetPlayerData(request);
        }
        
        public sample.ServiceReference.PlayerData[] GetPlayerData(string pos) {
            sample.ServiceReference.GetPlayerDataRequest inValue = new sample.ServiceReference.GetPlayerDataRequest();
            inValue.Body = new sample.ServiceReference.GetPlayerDataRequestBody();
            inValue.Body.pos = pos;
            sample.ServiceReference.GetPlayerDataResponse retVal = ((sample.ServiceReference.NBASoap)(this)).GetPlayerData(inValue);
            return retVal.Body.GetPlayerDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<sample.ServiceReference.GetPlayerDataResponse> sample.ServiceReference.NBASoap.GetPlayerDataAsync(sample.ServiceReference.GetPlayerDataRequest request) {
            return base.Channel.GetPlayerDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<sample.ServiceReference.GetPlayerDataResponse> GetPlayerDataAsync(string pos) {
            sample.ServiceReference.GetPlayerDataRequest inValue = new sample.ServiceReference.GetPlayerDataRequest();
            inValue.Body = new sample.ServiceReference.GetPlayerDataRequestBody();
            inValue.Body.pos = pos;
            return ((sample.ServiceReference.NBASoap)(this)).GetPlayerDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        sample.ServiceReference.GetPlayerDatajsonResponse sample.ServiceReference.NBASoap.GetPlayerDatajson(sample.ServiceReference.GetPlayerDatajsonRequest request) {
            return base.Channel.GetPlayerDatajson(request);
        }
        
        public string GetPlayerDatajson(int teamid) {
            sample.ServiceReference.GetPlayerDatajsonRequest inValue = new sample.ServiceReference.GetPlayerDatajsonRequest();
            inValue.Body = new sample.ServiceReference.GetPlayerDatajsonRequestBody();
            inValue.Body.teamid = teamid;
            sample.ServiceReference.GetPlayerDatajsonResponse retVal = ((sample.ServiceReference.NBASoap)(this)).GetPlayerDatajson(inValue);
            return retVal.Body.GetPlayerDatajsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<sample.ServiceReference.GetPlayerDatajsonResponse> sample.ServiceReference.NBASoap.GetPlayerDatajsonAsync(sample.ServiceReference.GetPlayerDatajsonRequest request) {
            return base.Channel.GetPlayerDatajsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<sample.ServiceReference.GetPlayerDatajsonResponse> GetPlayerDatajsonAsync(int teamid) {
            sample.ServiceReference.GetPlayerDatajsonRequest inValue = new sample.ServiceReference.GetPlayerDatajsonRequest();
            inValue.Body = new sample.ServiceReference.GetPlayerDatajsonRequestBody();
            inValue.Body.teamid = teamid;
            return ((sample.ServiceReference.NBASoap)(this)).GetPlayerDatajsonAsync(inValue);
        }
    }
}