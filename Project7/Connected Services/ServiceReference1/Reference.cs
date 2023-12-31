﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project7.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EnergyUnitConversion", ReplyAction="http://tempuri.org/IService1/EnergyUnitConversionResponse")]
        double EnergyUnitConversion(double energy, string unit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EnergyUnitConversion", ReplyAction="http://tempuri.org/IService1/EnergyUnitConversionResponse")]
        System.Threading.Tasks.Task<double> EnergyUnitConversionAsync(double energy, string unit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnZipByLatLong", ReplyAction="http://tempuri.org/IService1/ReturnZipByLatLongResponse")]
        string ReturnZipByLatLong(string latString, string longString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnZipByLatLong", ReplyAction="http://tempuri.org/IService1/ReturnZipByLatLongResponse")]
        System.Threading.Tasks.Task<string> ReturnZipByLatLongAsync(string latString, string longString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnAddressFromZip", ReplyAction="http://tempuri.org/IService1/ReturnAddressFromZipResponse")]
        string ReturnAddressFromZip(string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnAddressFromZip", ReplyAction="http://tempuri.org/IService1/ReturnAddressFromZipResponse")]
        System.Threading.Tasks.Task<string> ReturnAddressFromZipAsync(string zip);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Project7.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Project7.ServiceReference1.IService1>, Project7.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double EnergyUnitConversion(double energy, string unit) {
            return base.Channel.EnergyUnitConversion(energy, unit);
        }
        
        public System.Threading.Tasks.Task<double> EnergyUnitConversionAsync(double energy, string unit) {
            return base.Channel.EnergyUnitConversionAsync(energy, unit);
        }
        
        public string ReturnZipByLatLong(string latString, string longString) {
            return base.Channel.ReturnZipByLatLong(latString, longString);
        }
        
        public System.Threading.Tasks.Task<string> ReturnZipByLatLongAsync(string latString, string longString) {
            return base.Channel.ReturnZipByLatLongAsync(latString, longString);
        }
        
        public string ReturnAddressFromZip(string zip) {
            return base.Channel.ReturnAddressFromZip(zip);
        }
        
        public System.Threading.Tasks.Task<string> ReturnAddressFromZipAsync(string zip) {
            return base.Channel.ReturnAddressFromZipAsync(zip);
        }
    }
}
