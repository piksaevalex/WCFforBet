using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using WcfServiceLibrary.model;

namespace WcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public void AccountBalanceDown(int id, float value)
        {
            throw new NotImplementedException();
        }

        public void AccountBalanceUp(int id, float value)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(int id)
        {
            AccountContext context = new AccountContext();
            {
                var account = context.Accounts.Find(id);
                return account;
            } 
            throw new NotImplementedException();
        }

        public DbSet<Account> GetAccounts()
        {
            AccountContext context = new AccountContext();
            {
                context.Accounts.Load();
                var accounts = context.Accounts;
                return accounts;
            }
            throw new NotImplementedException();
        }

        public Bet GetBet(int id)
        {
            BetContext context = new BetContext();
            {
                var bet = context.Bets.Find(id);
                return bet;
            }   
            throw new NotImplementedException();
        }

        public DbSet<Bet> GetBets()
        {
            BetContext context = new BetContext();
            {
                var bets = context.Bets;
                return bets;
            }
            throw new NotImplementedException();
        }

        public void SetAccount(string surName, string name, string middleName, DateTime dateOfBirth, float balance = 0)
        {
            AccountContext context = new AccountContext();
            {
                context.Accounts.Add(new Account
                {
                    SurName = surName,
                    Name = name,
                    MiddleName = middleName,
                    Balance = balance,
                    DateOfBirth = dateOfBirth
                });
                context.SaveChanges();
            }
        }

        public void SetBet(DateTime date, float valueIn, float coefficient, bool result, float valueOut)
        {
            BetContext context = new BetContext();
            {
                context.Bets.Add(new Bet
                {
                    Date = date,
                    InValue = valueIn,
                    Coefficent = coefficient,
                    Result = result,
                    OutValue = valueOut
                });
                context.SaveChanges();
            }
        }
    }
}
