using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Service1Client svc = new Service1Client();
                Console.WriteLine("1-GetAccount, 2-GetAccountById, 3-InsertAccount, 4-GetBet, 5-GetBetById, 6-InsertBet");
                Console.WriteLine("Enter number or press [ENTER] to quit...");
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        var accounts = svc.GetAccounts();
                        foreach (Account account in accounts)
                        {
                            Console.WriteLine(account.Name);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите id Account");
                        int accountId = Convert.ToInt32(Console.ReadLine());
                        var accountById = svc.GetAccount(accountId);
                        if (accountById != null) { Console.WriteLine(accountById.Name); }
                        break;
                    case 3:
                        svc.SetAccount("ads", "asd", "sadad", DateTime.Now, 0);
                        Console.WriteLine("Account insert Sucsed");
                        break;
                    case 4:
                        var bets = svc.GetBets();
                        foreach (Bet bet in bets)
                        {
                            Console.WriteLine(bet.Id);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите id Bet");
                        int betId = Convert.ToInt32(Console.ReadLine());
                        var betById = svc.GetBet(betId);
                        if (betById != null) { Console.WriteLine(betById.InValue); }
                        break;
                    case 6:
                        svc.SetBet(DateTime.Now, 10, 2, false, 0);
                        Console.WriteLine("Bet insert Sucsed");
                        break;
                        
                }
                //if (string.IsNullOrEmpty(emailAddress))
                    //return;

            }
        }
    }
}
