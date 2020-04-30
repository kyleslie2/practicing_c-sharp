﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_2.Lab6Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RestaurantInfo", Namespace="http://schemas.datacontract.org/2004/07/Lab6Service")]
    [System.SerializableAttribute()]
    public partial class RestaurantInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Lab_2.Lab6Service.Address LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
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
        public Lab_2.Lab6Service.Address Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
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
        public string Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((object.ReferenceEquals(this.RatingField, value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/Lab6Service")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Province {
            get {
                return this.ProvinceField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinceField, value) != true)) {
                    this.ProvinceField = value;
                    this.RaisePropertyChanged("Province");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Lab6Service.IRestaurantReviewService")]
    public interface IRestaurantReviewService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/GetRestaurantNames", ReplyAction="http://tempuri.org/IRestaurantReviewService/GetRestaurantNamesResponse")]
        string[] GetRestaurantNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/GetRestaurantNames", ReplyAction="http://tempuri.org/IRestaurantReviewService/GetRestaurantNamesResponse")]
        System.Threading.Tasks.Task<string[]> GetRestaurantNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/GetRestaurantByName", ReplyAction="http://tempuri.org/IRestaurantReviewService/GetRestaurantByNameResponse")]
        Lab_2.Lab6Service.RestaurantInfo GetRestaurantByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/GetRestaurantByName", ReplyAction="http://tempuri.org/IRestaurantReviewService/GetRestaurantByNameResponse")]
        System.Threading.Tasks.Task<Lab_2.Lab6Service.RestaurantInfo> GetRestaurantByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/GetRestaurantsByRating", ReplyAction="http://tempuri.org/IRestaurantReviewService/GetRestaurantsByRatingResponse")]
        Lab_2.Lab6Service.RestaurantInfo[] GetRestaurantsByRating(int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/GetRestaurantsByRating", ReplyAction="http://tempuri.org/IRestaurantReviewService/GetRestaurantsByRatingResponse")]
        System.Threading.Tasks.Task<Lab_2.Lab6Service.RestaurantInfo[]> GetRestaurantsByRatingAsync(int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/SaveRestaurant", ReplyAction="http://tempuri.org/IRestaurantReviewService/SaveRestaurantResponse")]
        bool SaveRestaurant(Lab_2.Lab6Service.RestaurantInfo restInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantReviewService/SaveRestaurant", ReplyAction="http://tempuri.org/IRestaurantReviewService/SaveRestaurantResponse")]
        System.Threading.Tasks.Task<bool> SaveRestaurantAsync(Lab_2.Lab6Service.RestaurantInfo restInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRestaurantReviewServiceChannel : Lab_2.Lab6Service.IRestaurantReviewService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestaurantReviewServiceClient : System.ServiceModel.ClientBase<Lab_2.Lab6Service.IRestaurantReviewService>, Lab_2.Lab6Service.IRestaurantReviewService {
        
        public RestaurantReviewServiceClient() {
        }
        
        public RestaurantReviewServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestaurantReviewServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantReviewServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantReviewServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetRestaurantNames() {
            return base.Channel.GetRestaurantNames();
        }
        
        public System.Threading.Tasks.Task<string[]> GetRestaurantNamesAsync() {
            return base.Channel.GetRestaurantNamesAsync();
        }
        
        public Lab_2.Lab6Service.RestaurantInfo GetRestaurantByName(string name) {
            return base.Channel.GetRestaurantByName(name);
        }
        
        public System.Threading.Tasks.Task<Lab_2.Lab6Service.RestaurantInfo> GetRestaurantByNameAsync(string name) {
            return base.Channel.GetRestaurantByNameAsync(name);
        }
        
        public Lab_2.Lab6Service.RestaurantInfo[] GetRestaurantsByRating(int rating) {
            return base.Channel.GetRestaurantsByRating(rating);
        }
        
        public System.Threading.Tasks.Task<Lab_2.Lab6Service.RestaurantInfo[]> GetRestaurantsByRatingAsync(int rating) {
            return base.Channel.GetRestaurantsByRatingAsync(rating);
        }
        
        public bool SaveRestaurant(Lab_2.Lab6Service.RestaurantInfo restInfo) {
            return base.Channel.SaveRestaurant(restInfo);
        }
        
        public System.Threading.Tasks.Task<bool> SaveRestaurantAsync(Lab_2.Lab6Service.RestaurantInfo restInfo) {
            return base.Channel.SaveRestaurantAsync(restInfo);
        }
    }
}
