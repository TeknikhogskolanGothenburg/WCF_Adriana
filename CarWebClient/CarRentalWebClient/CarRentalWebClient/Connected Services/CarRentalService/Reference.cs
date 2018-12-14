﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalWebClient.CarRentalService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/CarService.Domain")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarRentalWebClient.CarRentalService.Booking[] BookingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsReturnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegistrationNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public CarRentalWebClient.CarRentalService.Booking[] Bookings {
            get {
                return this.BookingsField;
            }
            set {
                if ((object.ReferenceEquals(this.BookingsField, value) != true)) {
                    this.BookingsField = value;
                    this.RaisePropertyChanged("Bookings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsReturned {
            get {
                return this.IsReturnedField;
            }
            set {
                if ((this.IsReturnedField.Equals(value) != true)) {
                    this.IsReturnedField = value;
                    this.RaisePropertyChanged("IsReturned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mark {
            get {
                return this.MarkField;
            }
            set {
                if ((object.ReferenceEquals(this.MarkField, value) != true)) {
                    this.MarkField = value;
                    this.RaisePropertyChanged("Mark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegistrationNumber {
            get {
                return this.RegistrationNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.RegistrationNumberField, value) != true)) {
                    this.RegistrationNumberField = value;
                    this.RaisePropertyChanged("RegistrationNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/CarService.Domain")]
    [System.SerializableAttribute()]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarRentalWebClient.CarRentalService.Car TheCarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarRentalWebClient.CarRentalService.Customer TheCustomerField;
        
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
        public int CarId {
            get {
                return this.CarIdField;
            }
            set {
                if ((this.CarIdField.Equals(value) != true)) {
                    this.CarIdField = value;
                    this.RaisePropertyChanged("CarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarRentalWebClient.CarRentalService.Car TheCar {
            get {
                return this.TheCarField;
            }
            set {
                if ((object.ReferenceEquals(this.TheCarField, value) != true)) {
                    this.TheCarField = value;
                    this.RaisePropertyChanged("TheCar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarRentalWebClient.CarRentalService.Customer TheCustomer {
            get {
                return this.TheCustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.TheCustomerField, value) != true)) {
                    this.TheCustomerField = value;
                    this.RaisePropertyChanged("TheCustomer");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/CarService.Domain")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarRentalWebClient.CarRentalService.Booking[] BookingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelephoneNumeberField;
        
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
        public CarRentalWebClient.CarRentalService.Booking[] Bookings {
            get {
                return this.BookingsField;
            }
            set {
                if ((object.ReferenceEquals(this.BookingsField, value) != true)) {
                    this.BookingsField = value;
                    this.RaisePropertyChanged("Bookings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TelephoneNumeber {
            get {
                return this.TelephoneNumeberField;
            }
            set {
                if ((this.TelephoneNumeberField.Equals(value) != true)) {
                    this.TelephoneNumeberField = value;
                    this.RaisePropertyChanged("TelephoneNumeber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarRentalService.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/GetMessage", ReplyAction="http://tempuri.org/IHelloService/GetMessageResponse")]
        string GetMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/GetMessage", ReplyAction="http://tempuri.org/IHelloService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Add", ReplyAction="http://tempuri.org/IHelloService/AddResponse")]
        void Add(CarRentalWebClient.CarRentalService.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Add", ReplyAction="http://tempuri.org/IHelloService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(CarRentalWebClient.CarRentalService.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/RemoveCar", ReplyAction="http://tempuri.org/IHelloService/RemoveCarResponse")]
        void RemoveCar(int carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/RemoveCar", ReplyAction="http://tempuri.org/IHelloService/RemoveCarResponse")]
        System.Threading.Tasks.Task RemoveCarAsync(int carId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : CarRentalWebClient.CarRentalService.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<CarRentalWebClient.CarRentalService.IHelloService>, CarRentalWebClient.CarRentalService.IHelloService {
        
        public HelloServiceClient() {
        }
        
        public HelloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage(string name) {
            return base.Channel.GetMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string name) {
            return base.Channel.GetMessageAsync(name);
        }
        
        public void Add(CarRentalWebClient.CarRentalService.Car car) {
            base.Channel.Add(car);
        }
        
        public System.Threading.Tasks.Task AddAsync(CarRentalWebClient.CarRentalService.Car car) {
            return base.Channel.AddAsync(car);
        }
        
        public void RemoveCar(int carId) {
            base.Channel.RemoveCar(carId);
        }
        
        public System.Threading.Tasks.Task RemoveCarAsync(int carId) {
            return base.Channel.RemoveCarAsync(carId);
        }
    }
}
