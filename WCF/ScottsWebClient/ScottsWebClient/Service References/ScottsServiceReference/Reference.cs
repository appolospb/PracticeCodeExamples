﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScottsWebClient.ScottsServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetMoneyRequest", Namespace="http://schemas.datacontract.org/2004/07/ScottsService.Models")]
    [System.SerializableAttribute()]
    public partial class GetMoneyRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnnualSalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal WeeklyHoursWorkedField;
        
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
        public int AnnualSalary {
            get {
                return this.AnnualSalaryField;
            }
            set {
                if ((this.AnnualSalaryField.Equals(value) != true)) {
                    this.AnnualSalaryField = value;
                    this.RaisePropertyChanged("AnnualSalary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal WeeklyHoursWorked {
            get {
                return this.WeeklyHoursWorkedField;
            }
            set {
                if ((this.WeeklyHoursWorkedField.Equals(value) != true)) {
                    this.WeeklyHoursWorkedField = value;
                    this.RaisePropertyChanged("WeeklyHoursWorked");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetMoneyResponse", Namespace="http://schemas.datacontract.org/2004/07/ScottsService.Models")]
    [System.SerializableAttribute()]
    public partial class GetMoneyResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DailyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HourlyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MonthlyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeeklyField;
        
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
        public int Daily {
            get {
                return this.DailyField;
            }
            set {
                if ((this.DailyField.Equals(value) != true)) {
                    this.DailyField = value;
                    this.RaisePropertyChanged("Daily");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Hourly {
            get {
                return this.HourlyField;
            }
            set {
                if ((this.HourlyField.Equals(value) != true)) {
                    this.HourlyField = value;
                    this.RaisePropertyChanged("Hourly");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Monthly {
            get {
                return this.MonthlyField;
            }
            set {
                if ((this.MonthlyField.Equals(value) != true)) {
                    this.MonthlyField = value;
                    this.RaisePropertyChanged("Monthly");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Weekly {
            get {
                return this.WeeklyField;
            }
            set {
                if ((this.WeeklyField.Equals(value) != true)) {
                    this.WeeklyField = value;
                    this.RaisePropertyChanged("Weekly");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ScottsServiceReference.IScottsService")]
    public interface IScottsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScottsService/GetMessage", ReplyAction="http://tempuri.org/IScottsService/GetMessageResponse")]
        string GetMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScottsService/GetMessage", ReplyAction="http://tempuri.org/IScottsService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScottsService/GetMoney", ReplyAction="http://tempuri.org/IScottsService/GetMoneyResponse")]
        ScottsWebClient.ScottsServiceReference.GetMoneyResponse GetMoney(ScottsWebClient.ScottsServiceReference.GetMoneyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScottsService/GetMoney", ReplyAction="http://tempuri.org/IScottsService/GetMoneyResponse")]
        System.Threading.Tasks.Task<ScottsWebClient.ScottsServiceReference.GetMoneyResponse> GetMoneyAsync(ScottsWebClient.ScottsServiceReference.GetMoneyRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScottsServiceChannel : ScottsWebClient.ScottsServiceReference.IScottsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScottsServiceClient : System.ServiceModel.ClientBase<ScottsWebClient.ScottsServiceReference.IScottsService>, ScottsWebClient.ScottsServiceReference.IScottsService {
        
        public ScottsServiceClient() {
        }
        
        public ScottsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScottsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScottsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScottsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage(string name) {
            return base.Channel.GetMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string name) {
            return base.Channel.GetMessageAsync(name);
        }
        
        public ScottsWebClient.ScottsServiceReference.GetMoneyResponse GetMoney(ScottsWebClient.ScottsServiceReference.GetMoneyRequest request) {
            return base.Channel.GetMoney(request);
        }
        
        public System.Threading.Tasks.Task<ScottsWebClient.ScottsServiceReference.GetMoneyResponse> GetMoneyAsync(ScottsWebClient.ScottsServiceReference.GetMoneyRequest request) {
            return base.Channel.GetMoneyAsync(request);
        }
    }
}
