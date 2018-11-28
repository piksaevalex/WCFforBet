﻿using System;
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
        void SetAccount(string surName, string name, string middleName, DateTime dateOfBirth, double balance);

        [OperationContract]
        void AccountBalanceUp(int id, double value);

        [OperationContract]
        void AccountBalanceDown(int id, double value);

        [OperationContract]
        DbSet<Bet> GetBets();

        [OperationContract]
        Bet GetBet(int id);

        [OperationContract]
        void SetBet(DateTime date, double valueIn, double coefficient, bool result, double valueOut);

        
    }

}
