using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data.Entity;
using System.Text;
using WcfServiceLibrary.model;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DbSet<Account> GetAccounts();

        [OperationContract]
        Account GetAccount(int id);

        [OperationContract]
        void SetAccount(string surName, string name, string middleName, DateTime dateOfBirth, float balance);

        [OperationContract]
        void AccountBalanceUp(int id, float value);

        [OperationContract]
        void AccountBalanceDown(int id, float value);

        [OperationContract]
        DbSet<Bet> GetBets();

        [OperationContract]
        Bet GetBet(int id);

        [OperationContract]
        void SetBet(DateTime date, float valueIn, float coefficient, bool result, float valueOut);

        
    }

}
