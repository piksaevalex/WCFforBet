using System;
using System.Collections.Generic;
using System.Linq;
using WcfServiceLibrary.Model;

namespace WcfServiceLibrary
{
    public class BetService : IBetService
    {
        public void AccountBalanceDown(int id, double value)
        {
            using (var context = new MyDBContext())
            {
                var account = context.Accounts.FirstOrDefault(c => c.Id == id);
                if (account != null) account.Balance = account.Balance - value;
                context.SaveChanges();
            }
        }

        public void AccountBalanceUp(int id, double value)
        {
            using (var context = new MyDBContext())
            {
                var account = context.Accounts.Find(id);
                if (account != null) account.Balance = account.Balance + value;
                context.SaveChanges();
            }
        }

        public Account GetAccount(int id)
        {
            using (var context = new MyDBContext())
            {
                return context.Accounts.Find(id);
            }
        }

        public List<Account> GetAccounts()
        {
            using (var context = new MyDBContext())
            {
                return context.Accounts.ToList();
            }
        }

        public Bet GetBet(int id)
        {
            using (var context = new MyDBContext())
            {
                return context.Bets.Find(id);
            }
        }

        public List<Bet> GetBets()
        {
            using (var context = new MyDBContext())
            {
                return context.Bets.ToList();
            }
        }

        public void SetAccount(string surName, string name, string middleName, DateTime dateOfBirth, double balance = 0)
        {
            using (var context = new MyDBContext())
            {
                context.Accounts.Add(new Account
                {
                    SurName = surName,
                    Name = name,
                    MiddleName = middleName,
                    Balance = balance,
                    DateOfBirth = dateOfBirth.Date
                });
                context.SaveChanges();
            }
        }

        public void SetBet(DateTime date, double valueIn, double coefficient, bool result, double valueOut)
        {
            using (var context = new MyDBContext())
            {
                context.Bets.Add(new Bet
                {
                    Date = date.Date,
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