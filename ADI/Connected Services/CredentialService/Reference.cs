﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADI.CredentialService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DimensionsLogonObject", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    public partial class DimensionsLogonObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatabaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DomainField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SiteReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WindowsAuthenticationField;
        
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
        public string Database {
            get {
                return this.DatabaseField;
            }
            set {
                if ((object.ReferenceEquals(this.DatabaseField, value) != true)) {
                    this.DatabaseField = value;
                    this.RaisePropertyChanged("Database");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Domain {
            get {
                return this.DomainField;
            }
            set {
                if ((object.ReferenceEquals(this.DomainField, value) != true)) {
                    this.DomainField = value;
                    this.RaisePropertyChanged("Domain");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Server {
            get {
                return this.ServerField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerField, value) != true)) {
                    this.ServerField = value;
                    this.RaisePropertyChanged("Server");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SiteReference {
            get {
                return this.SiteReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteReferenceField, value) != true)) {
                    this.SiteReferenceField = value;
                    this.RaisePropertyChanged("SiteReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WindowsAuthentication {
            get {
                return this.WindowsAuthenticationField;
            }
            set {
                if ((this.WindowsAuthenticationField.Equals(value) != true)) {
                    this.WindowsAuthenticationField = value;
                    this.RaisePropertyChanged("WindowsAuthentication");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectHRLogonObject", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    public partial class SelectHRLogonObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatabaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DomainField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SiteReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WindowsAuthenticationField;
        
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
        public string Database {
            get {
                return this.DatabaseField;
            }
            set {
                if ((object.ReferenceEquals(this.DatabaseField, value) != true)) {
                    this.DatabaseField = value;
                    this.RaisePropertyChanged("Database");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Domain {
            get {
                return this.DomainField;
            }
            set {
                if ((object.ReferenceEquals(this.DomainField, value) != true)) {
                    this.DomainField = value;
                    this.RaisePropertyChanged("Domain");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Server {
            get {
                return this.ServerField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerField, value) != true)) {
                    this.ServerField = value;
                    this.RaisePropertyChanged("Server");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SiteReference {
            get {
                return this.SiteReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteReferenceField, value) != true)) {
                    this.SiteReferenceField = value;
                    this.RaisePropertyChanged("SiteReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WindowsAuthentication {
            get {
                return this.WindowsAuthenticationField;
            }
            set {
                if ((this.WindowsAuthenticationField.Equals(value) != true)) {
                    this.WindowsAuthenticationField = value;
                    this.RaisePropertyChanged("WindowsAuthentication");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="baseRequest", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ADI.CredentialService.ObjectDefinitionRequest))]
    public partial class baseRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TicketField;
        
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
        public string Ticket {
            get {
                return this.TicketField;
            }
            set {
                if ((object.ReferenceEquals(this.TicketField, value) != true)) {
                    this.TicketField = value;
                    this.RaisePropertyChanged("Ticket");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectDefinitionRequest", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    public partial class ObjectDefinitionRequest : ADI.CredentialService.baseRequest {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObjectNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ObjectName {
            get {
                return this.ObjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectNameField, value) != true)) {
                    this.ObjectNameField = value;
                    this.RaisePropertyChanged("ObjectName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="baseResponse", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ADI.CredentialService.ObjectDefinitionResponse))]
    public partial class baseResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TicketField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VersionNoField;
        
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
        public int ErrorID {
            get {
                return this.ErrorIDField;
            }
            set {
                if ((this.ErrorIDField.Equals(value) != true)) {
                    this.ErrorIDField = value;
                    this.RaisePropertyChanged("ErrorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ticket {
            get {
                return this.TicketField;
            }
            set {
                if ((object.ReferenceEquals(this.TicketField, value) != true)) {
                    this.TicketField = value;
                    this.RaisePropertyChanged("Ticket");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VersionNo {
            get {
                return this.VersionNoField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionNoField, value) != true)) {
                    this.VersionNoField = value;
                    this.RaisePropertyChanged("VersionNo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectDefinitionResponse", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    public partial class ObjectDefinitionResponse : ADI.CredentialService.baseResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ADI.CredentialService.PropertyDefinition[] PropertiesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ADI.CredentialService.PropertyDefinition[] Properties {
            get {
                return this.PropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertiesField, value) != true)) {
                    this.PropertiesField = value;
                    this.RaisePropertyChanged("Properties");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PropertyDefinition", Namespace="http://schemas.datacontract.org/2004/07/AccessUKWebService.DimensionsWebService")]
    [System.SerializableAttribute()]
    public partial class PropertyDefinition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DefaultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool MandatoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValidationField;
        
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
        public string Default {
            get {
                return this.DefaultField;
            }
            set {
                if ((object.ReferenceEquals(this.DefaultField, value) != true)) {
                    this.DefaultField = value;
                    this.RaisePropertyChanged("Default");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Mandatory {
            get {
                return this.MandatoryField;
            }
            set {
                if ((this.MandatoryField.Equals(value) != true)) {
                    this.MandatoryField = value;
                    this.RaisePropertyChanged("Mandatory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Validation {
            get {
                return this.ValidationField;
            }
            set {
                if ((object.ReferenceEquals(this.ValidationField, value) != true)) {
                    this.ValidationField = value;
                    this.RaisePropertyChanged("Validation");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CredentialService.ICredentialsService")]
    public interface ICredentialsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewTicket", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewTicketResponse")]
        string CreateNewTicket(ADI.CredentialService.DimensionsLogonObject DimensionsCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewTicket", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewTicketResponse")]
        System.Threading.Tasks.Task<string> CreateNewTicketAsync(ADI.CredentialService.DimensionsLogonObject DimensionsCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicket", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicketResponse")]
        string CreateNewSelectHRTicket(ADI.CredentialService.SelectHRLogonObject SelectHRCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicket", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicketResponse")]
        System.Threading.Tasks.Task<string> CreateNewSelectHRTicketAsync(ADI.CredentialService.SelectHRLogonObject SelectHRCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewTicket_Basic", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewTicket_BasicResponse")]
        string CreateNewTicket_Basic(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewTicket_Basic", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewTicket_BasicResponse")]
        System.Threading.Tasks.Task<string> CreateNewTicket_BasicAsync(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicket_Basic", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicket_BasicResponse")]
        string CreateNewSelectHRTicket_Basic(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password, string Domain, bool WindowsAuthentication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicket_Basic", ReplyAction="http://tempuri.org/ICredentialsService/CreateNewSelectHRTicket_BasicResponse")]
        System.Threading.Tasks.Task<string> CreateNewSelectHRTicket_BasicAsync(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password, string Domain, bool WindowsAuthentication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/GenericGateway", ReplyAction="http://tempuri.org/ICredentialsService/GenericGatewayResponse")]
        string GenericGateway(string XmlMessage, string Ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/GenericGateway", ReplyAction="http://tempuri.org/ICredentialsService/GenericGatewayResponse")]
        System.Threading.Tasks.Task<string> GenericGatewayAsync(string XmlMessage, string Ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/ReturnObjectDefinition", ReplyAction="http://tempuri.org/ICredentialsService/ReturnObjectDefinitionResponse")]
        ADI.CredentialService.ObjectDefinitionResponse ReturnObjectDefinition(ADI.CredentialService.ObjectDefinitionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/ReturnObjectDefinition", ReplyAction="http://tempuri.org/ICredentialsService/ReturnObjectDefinitionResponse")]
        System.Threading.Tasks.Task<ADI.CredentialService.ObjectDefinitionResponse> ReturnObjectDefinitionAsync(ADI.CredentialService.ObjectDefinitionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/DeleteTicket", ReplyAction="http://tempuri.org/ICredentialsService/DeleteTicketResponse")]
        string DeleteTicket(string ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICredentialsService/DeleteTicket", ReplyAction="http://tempuri.org/ICredentialsService/DeleteTicketResponse")]
        System.Threading.Tasks.Task<string> DeleteTicketAsync(string ticket);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICredentialsServiceChannel : ADI.CredentialService.ICredentialsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CredentialsServiceClient : System.ServiceModel.ClientBase<ADI.CredentialService.ICredentialsService>, ADI.CredentialService.ICredentialsService {
        
        public CredentialsServiceClient() {
        }
        
        public CredentialsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CredentialsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CredentialsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CredentialsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreateNewTicket(ADI.CredentialService.DimensionsLogonObject DimensionsCredentials) {
            return base.Channel.CreateNewTicket(DimensionsCredentials);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewTicketAsync(ADI.CredentialService.DimensionsLogonObject DimensionsCredentials) {
            return base.Channel.CreateNewTicketAsync(DimensionsCredentials);
        }
        
        public string CreateNewSelectHRTicket(ADI.CredentialService.SelectHRLogonObject SelectHRCredentials) {
            return base.Channel.CreateNewSelectHRTicket(SelectHRCredentials);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewSelectHRTicketAsync(ADI.CredentialService.SelectHRLogonObject SelectHRCredentials) {
            return base.Channel.CreateNewSelectHRTicketAsync(SelectHRCredentials);
        }
        
        public string CreateNewTicket_Basic(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password) {
            return base.Channel.CreateNewTicket_Basic(SiteReference, ServerName, DatabaseName, UserName, UserID, Password);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewTicket_BasicAsync(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password) {
            return base.Channel.CreateNewTicket_BasicAsync(SiteReference, ServerName, DatabaseName, UserName, UserID, Password);
        }
        
        public string CreateNewSelectHRTicket_Basic(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password, string Domain, bool WindowsAuthentication) {
            return base.Channel.CreateNewSelectHRTicket_Basic(SiteReference, ServerName, DatabaseName, UserName, UserID, Password, Domain, WindowsAuthentication);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewSelectHRTicket_BasicAsync(string SiteReference, string ServerName, string DatabaseName, string UserName, string UserID, string Password, string Domain, bool WindowsAuthentication) {
            return base.Channel.CreateNewSelectHRTicket_BasicAsync(SiteReference, ServerName, DatabaseName, UserName, UserID, Password, Domain, WindowsAuthentication);
        }
        
        public string GenericGateway(string XmlMessage, string Ticket) {
            return base.Channel.GenericGateway(XmlMessage, Ticket);
        }
        
        public System.Threading.Tasks.Task<string> GenericGatewayAsync(string XmlMessage, string Ticket) {
            return base.Channel.GenericGatewayAsync(XmlMessage, Ticket);
        }
        
        public ADI.CredentialService.ObjectDefinitionResponse ReturnObjectDefinition(ADI.CredentialService.ObjectDefinitionRequest request) {
            return base.Channel.ReturnObjectDefinition(request);
        }
        
        public System.Threading.Tasks.Task<ADI.CredentialService.ObjectDefinitionResponse> ReturnObjectDefinitionAsync(ADI.CredentialService.ObjectDefinitionRequest request) {
            return base.Channel.ReturnObjectDefinitionAsync(request);
        }
        
        public string DeleteTicket(string ticket) {
            return base.Channel.DeleteTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<string> DeleteTicketAsync(string ticket) {
            return base.Channel.DeleteTicketAsync(ticket);
        }
    }
}
