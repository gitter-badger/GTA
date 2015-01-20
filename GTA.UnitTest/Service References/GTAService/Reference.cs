﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GTA.UnitTest.GTAService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GTAService.IGTAService")]
    public interface IGTAService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/AddNumbers", ReplyAction="http://tempuri.org/IGTAService/AddNumbersResponse")]
        double AddNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/AddNumbers", ReplyAction="http://tempuri.org/IGTAService/AddNumbersResponse")]
        System.Threading.Tasks.Task<double> AddNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/SubstractNumbers", ReplyAction="http://tempuri.org/IGTAService/SubstractNumbersResponse")]
        double SubstractNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/SubstractNumbers", ReplyAction="http://tempuri.org/IGTAService/SubstractNumbersResponse")]
        System.Threading.Tasks.Task<double> SubstractNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/MultiplyNumbers", ReplyAction="http://tempuri.org/IGTAService/MultiplyNumbersResponse")]
        double MultiplyNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/MultiplyNumbers", ReplyAction="http://tempuri.org/IGTAService/MultiplyNumbersResponse")]
        System.Threading.Tasks.Task<double> MultiplyNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/DivisionNumbers", ReplyAction="http://tempuri.org/IGTAService/DivisionNumbersResponse")]
        double DivisionNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGTAService/DivisionNumbers", ReplyAction="http://tempuri.org/IGTAService/DivisionNumbersResponse")]
        System.Threading.Tasks.Task<double> DivisionNumbersAsync(double number1, double number2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGTAServiceChannel : GTA.UnitTest.GTAService.IGTAService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GTAServiceClient : System.ServiceModel.ClientBase<GTA.UnitTest.GTAService.IGTAService>, GTA.UnitTest.GTAService.IGTAService {
        
        public GTAServiceClient() {
        }
        
        public GTAServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GTAServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GTAServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GTAServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double AddNumbers(double number1, double number2) {
            return base.Channel.AddNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> AddNumbersAsync(double number1, double number2) {
            return base.Channel.AddNumbersAsync(number1, number2);
        }
        
        public double SubstractNumbers(double number1, double number2) {
            return base.Channel.SubstractNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> SubstractNumbersAsync(double number1, double number2) {
            return base.Channel.SubstractNumbersAsync(number1, number2);
        }
        
        public double MultiplyNumbers(double number1, double number2) {
            return base.Channel.MultiplyNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyNumbersAsync(double number1, double number2) {
            return base.Channel.MultiplyNumbersAsync(number1, number2);
        }
        
        public double DivisionNumbers(double number1, double number2) {
            return base.Channel.DivisionNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DivisionNumbersAsync(double number1, double number2) {
            return base.Channel.DivisionNumbersAsync(number1, number2);
        }
    }
}
