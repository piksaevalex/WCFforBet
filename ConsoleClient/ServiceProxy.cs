﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary.model")]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private float BalanceField;
        
        private System.DateTime DateOfBirthField;
        
        private int IdField;
        
        private string MiddleNameField;
        
        private string NameField;
        
        private string SurNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Balance
        {
            get
            {
                return this.BalanceField;
            }
            set
            {
                this.BalanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.DateOfBirthField;
            }
            set
            {
                this.DateOfBirthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName
        {
            get
            {
                return this.MiddleNameField;
            }
            set
            {
                this.MiddleNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SurName
        {
            get
            {
                return this.SurNameField;
            }
            set
            {
                this.SurNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bet", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary.model")]
    public partial class Bet : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private float CoefficentField;
        
        private System.DateTime DateField;
        
        private int IdField;
        
        private float InValueField;
        
        private System.Nullable<float> OutValueField;
        
        private System.Nullable<bool> ResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Coefficent
        {
            get
            {
                return this.CoefficentField;
            }
            set
            {
                this.CoefficentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float InValue
        {
            get
            {
                return this.InValueField;
            }
            set
            {
                this.InValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> OutValue
        {
            get
            {
                return this.OutValueField;
            }
            set
            {
                this.OutValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsoleClient.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccounts", ReplyAction="http://tempuri.org/IService1/GetAccountsResponse")]
        ConsoleClient.Account[] GetAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccounts", ReplyAction="http://tempuri.org/IService1/GetAccountsResponse")]
        System.Threading.Tasks.Task<ConsoleClient.Account[]> GetAccountsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccount", ReplyAction="http://tempuri.org/IService1/GetAccountResponse")]
        ConsoleClient.Account GetAccount(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccount", ReplyAction="http://tempuri.org/IService1/GetAccountResponse")]
        System.Threading.Tasks.Task<ConsoleClient.Account> GetAccountAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetAccount", ReplyAction="http://tempuri.org/IService1/SetAccountResponse")]
        void SetAccount(string surName, string name, string middleName, System.DateTime dateOfBirth, float balance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetAccount", ReplyAction="http://tempuri.org/IService1/SetAccountResponse")]
        System.Threading.Tasks.Task SetAccountAsync(string surName, string name, string middleName, System.DateTime dateOfBirth, float balance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AccountBalanceUp", ReplyAction="http://tempuri.org/IService1/AccountBalanceUpResponse")]
        void AccountBalanceUp(int id, float value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AccountBalanceUp", ReplyAction="http://tempuri.org/IService1/AccountBalanceUpResponse")]
        System.Threading.Tasks.Task AccountBalanceUpAsync(int id, float value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AccountBalanceDown", ReplyAction="http://tempuri.org/IService1/AccountBalanceDownResponse")]
        void AccountBalanceDown(int id, float value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AccountBalanceDown", ReplyAction="http://tempuri.org/IService1/AccountBalanceDownResponse")]
        System.Threading.Tasks.Task AccountBalanceDownAsync(int id, float value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBets", ReplyAction="http://tempuri.org/IService1/GetBetsResponse")]
        ConsoleClient.Bet[] GetBets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBets", ReplyAction="http://tempuri.org/IService1/GetBetsResponse")]
        System.Threading.Tasks.Task<ConsoleClient.Bet[]> GetBetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBet", ReplyAction="http://tempuri.org/IService1/GetBetResponse")]
        ConsoleClient.Bet GetBet(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBet", ReplyAction="http://tempuri.org/IService1/GetBetResponse")]
        System.Threading.Tasks.Task<ConsoleClient.Bet> GetBetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetBet", ReplyAction="http://tempuri.org/IService1/SetBetResponse")]
        void SetBet(System.DateTime date, float valueIn, float coefficient, bool result, float valueOut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetBet", ReplyAction="http://tempuri.org/IService1/SetBetResponse")]
        System.Threading.Tasks.Task SetBetAsync(System.DateTime date, float valueIn, float coefficient, bool result, float valueOut);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleClient.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleClient.IService1>, ConsoleClient.IService1
    {
        
        public Service1Client()
        {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ConsoleClient.Account[] GetAccounts()
        {
            return base.Channel.GetAccounts();
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.Account[]> GetAccountsAsync()
        {
            return base.Channel.GetAccountsAsync();
        }
        
        public ConsoleClient.Account GetAccount(int id)
        {
            return base.Channel.GetAccount(id);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.Account> GetAccountAsync(int id)
        {
            return base.Channel.GetAccountAsync(id);
        }
        
        public void SetAccount(string surName, string name, string middleName, System.DateTime dateOfBirth, float balance)
        {
            base.Channel.SetAccount(surName, name, middleName, dateOfBirth, balance);
        }
        
        public System.Threading.Tasks.Task SetAccountAsync(string surName, string name, string middleName, System.DateTime dateOfBirth, float balance)
        {
            return base.Channel.SetAccountAsync(surName, name, middleName, dateOfBirth, balance);
        }
        
        public void AccountBalanceUp(int id, float value)
        {
            base.Channel.AccountBalanceUp(id, value);
        }
        
        public System.Threading.Tasks.Task AccountBalanceUpAsync(int id, float value)
        {
            return base.Channel.AccountBalanceUpAsync(id, value);
        }
        
        public void AccountBalanceDown(int id, float value)
        {
            base.Channel.AccountBalanceDown(id, value);
        }
        
        public System.Threading.Tasks.Task AccountBalanceDownAsync(int id, float value)
        {
            return base.Channel.AccountBalanceDownAsync(id, value);
        }
        
        public ConsoleClient.Bet[] GetBets()
        {
            return base.Channel.GetBets();
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.Bet[]> GetBetsAsync()
        {
            return base.Channel.GetBetsAsync();
        }
        
        public ConsoleClient.Bet GetBet(int id)
        {
            return base.Channel.GetBet(id);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.Bet> GetBetAsync(int id)
        {
            return base.Channel.GetBetAsync(id);
        }
        
        public void SetBet(System.DateTime date, float valueIn, float coefficient, bool result, float valueOut)
        {
            base.Channel.SetBet(date, valueIn, coefficient, result, valueOut);
        }
        
        public System.Threading.Tasks.Task SetBetAsync(System.DateTime date, float valueIn, float coefficient, bool result, float valueOut)
        {
            return base.Channel.SetBetAsync(date, valueIn, coefficient, result, valueOut);
        }
    }
}
