﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BFH.NetDS.WebServices.Benchmark.SOAPServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HostInformation", Namespace="http://schemas.datacontract.org/2004/07/BFH.NetDS.WebServices.Benchmark")]
    [System.SerializableAttribute()]
    public partial class HostInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char[] drivesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> environmentVariablesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hostNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string operatingSystemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int processorCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<System.Environment.SpecialFolder, string> specialFoldersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long workingSetField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char[] drives {
            get {
                return this.drivesField;
            }
            set {
                if ((object.ReferenceEquals(this.drivesField, value) != true)) {
                    this.drivesField = value;
                    this.RaisePropertyChanged("drives");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> environmentVariables {
            get {
                return this.environmentVariablesField;
            }
            set {
                if ((object.ReferenceEquals(this.environmentVariablesField, value) != true)) {
                    this.environmentVariablesField = value;
                    this.RaisePropertyChanged("environmentVariables");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hostName {
            get {
                return this.hostNameField;
            }
            set {
                if ((object.ReferenceEquals(this.hostNameField, value) != true)) {
                    this.hostNameField = value;
                    this.RaisePropertyChanged("hostName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operatingSystem {
            get {
                return this.operatingSystemField;
            }
            set {
                if ((object.ReferenceEquals(this.operatingSystemField, value) != true)) {
                    this.operatingSystemField = value;
                    this.RaisePropertyChanged("operatingSystem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int processorCount {
            get {
                return this.processorCountField;
            }
            set {
                if ((this.processorCountField.Equals(value) != true)) {
                    this.processorCountField = value;
                    this.RaisePropertyChanged("processorCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<System.Environment.SpecialFolder, string> specialFolders {
            get {
                return this.specialFoldersField;
            }
            set {
                if ((object.ReferenceEquals(this.specialFoldersField, value) != true)) {
                    this.specialFoldersField = value;
                    this.RaisePropertyChanged("specialFolders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                if ((object.ReferenceEquals(this.userNameField, value) != true)) {
                    this.userNameField = value;
                    this.RaisePropertyChanged("userName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long workingSet {
            get {
                return this.workingSetField;
            }
            set {
                if ((this.workingSetField.Equals(value) != true)) {
                    this.workingSetField = value;
                    this.RaisePropertyChanged("workingSet");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPServiceClient.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetHostInformation", ReplyAction="http://tempuri.org/IService/GetHostInformationResponse")]
        BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.HostInformation GetHostInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetHostInformation", ReplyAction="http://tempuri.org/IService/GetHostInformationResponse")]
        System.Threading.Tasks.Task<BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.HostInformation> GetHostInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.IService>, BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.HostInformation GetHostInformation() {
            return base.Channel.GetHostInformation();
        }
        
        public System.Threading.Tasks.Task<BFH.NetDS.WebServices.Benchmark.SOAPServiceClient.HostInformation> GetHostInformationAsync() {
            return base.Channel.GetHostInformationAsync();
        }
    }
}