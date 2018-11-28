﻿using System;
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
                BetServiceClient svc = new BetServiceClient();
                Console.WriteLine("1-GetAccount, 2-GetAccountById, 3-InsertAccount, 4-GetBet, 5-GetBetById, 6-InsertBet, 7-Внести деньги, 8-Вывести деньги");
                Console.WriteLine("Enter number or press [ENTER] to quit...");
                var caseItem = Console.ReadLine();
                int caseSwitch;
                if (string.IsNullOrEmpty(caseItem))  return;
                if (!(int.TryParse(caseItem, out caseSwitch)))
                {
                    Console.WriteLine("Enter number or press [ENTER] to quit...");
                    continue;
                }
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
                        svc.SetAccount("Ivanov", "Ivan", "Ivanovich", DateTime.Now, 0);
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
                    case 7:
                        Console.WriteLine("Введите AccountId и кол-во средств, которое хотите внести");
                        var str1 = Console.ReadLine().Split(' ');
                        int id1 = Convert.ToInt32(str1[0]);
                        double value1 = Convert.ToDouble(str1[1]);
                        svc.AccountBalanceUp(id1, value1);
                        break;
                    case 8:
                        Console.WriteLine("Введите AccountId и кол-во средств, которое хотите внести");
                        var str2 = Console.ReadLine().Split(' ');
                        int id2 = Convert.ToInt32(str2[0]);
                        double value2 = Convert.ToDouble(str2[1]);
                        svc.AccountBalanceDown(id2, value2);
                        break;
                        
                }
                

            }
        }
    }
}
