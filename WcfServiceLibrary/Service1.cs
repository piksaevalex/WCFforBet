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
        public void AccountBalanceDown(int id, double value)
        {
            AccountContext context = new AccountContext();
            Account account = context.Accounts.Where(c => c.Id == id).FirstOrDefault();
            account.Balance = account.Balance - value;
            context.SaveChanges();
            context.Dispose();
        }

        public void AccountBalanceUp(int id, double value)
        {
            AccountContext context = new AccountContext();
            Account account = context.Accounts.Find(id);
            account.Balance = account.Balance + value;
            context.SaveChanges();
            context.Dispose();
        }

        public Account GetAccount(int id)
        {
            AccountContext context = new AccountContext();
            {
                var account = context.Accounts.Find(id);
                context.Dispose();
                return account;
            } 
        }

        public DbSet<Account> GetAccounts()
        {
            AccountContext context = new AccountContext();
            {
                //context.Accounts.Load();
                var accounts = context.Accounts;
                context.Dispose();
                return accounts;
            }
        }

        public Bet GetBet(int id)
        {
            BetContext context = new BetContext();
            {
                var bet = context.Bets.Find(id);
                context.Dispose();
                return bet;
            }   
        }

        public DbSet<Bet> GetBets()
        {
            BetContext context = new BetContext();
            {
                var bets = context.Bets;
                context.Dispose();
                return bets;
            }
        }

        public void SetAccount(string surName, string name, string middleName, DateTime dateOfBirth, double balance = 0)
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
            context.Dispose();
        }

        public void SetBet(DateTime date, double valueIn, double coefficient, bool result, double valueOut)
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
            context.Dispose();
        }
    }
}
