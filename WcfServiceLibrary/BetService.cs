using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using WcfServiceLibrary.Model;

namespace WcfServiceLibrary
{
    public class BetService : IBetService
    {
        public void AccountBalanceDown(int id, double value)
        {
            using (AccountContext context = new AccountContext())
            {
                Account account = context.Accounts.FirstOrDefault(c => c.Id == id);
                account.Balance = account.Balance - value;
                context.SaveChanges();
            }
        }

        public void AccountBalanceUp(int id, double value)
        {
            using (AccountContext context = new AccountContext())
            {
                Account account = context.Accounts.Find(id);
                account.Balance = account.Balance + value;
                context.SaveChanges();
            }
        }

        public Account GetAccount(int id)
        {
            using (AccountContext context = new AccountContext())
            {
                var account = context.Accounts.Find(id);
                return account;
            } 
        }

        public List<Account> GetAccounts()
        {
            using (AccountContext context = new AccountContext())
            {
                var accounts = context.Accounts.ToList();
                return accounts;
            }
        }

        public Bet GetBet(int id)
        {
            using (BetContext context = new BetContext())
            {
                var bet = context.Bets.Find(id);
                return bet;
            }   
        }

        public List<Bet> GetBets()
        {
            using (BetContext context = new BetContext())
            {
                var bets = context.Bets.ToList();
                return bets;
            }
        }

        public void SetAccount(string surName, string name, string middleName, DateTime dateOfBirth, double balance = 0)
        {
            using (AccountContext context = new AccountContext())
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

        public void SetBet(DateTime date, double valueIn, double coefficient, bool result, double valueOut)
        {
            using (BetContext context = new BetContext())
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
