using System;

namespace ConsoleClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var svc = new BetServiceClient();
                Console.WriteLine(
                    "1-GetAccount, 2-GetAccountById, 3-InsertAccount, 4-GetBet, 5-GetBetById, 6-InsertBet, 7-Внести деньги,\n8-Вывести деньги, 9-Вывести Аккаунт по вхождении фамилии, 10-Вывести ставку по сумме ставки");
                Console.WriteLine("Enter number or press [ENTER] to quit...");
                var caseItem = Console.ReadLine();
                int caseSwitch;
                if (string.IsNullOrEmpty(caseItem)) return;
                if (!int.TryParse(caseItem, out caseSwitch)) continue;
                
                switch (caseSwitch)
                {
                    case 1:
                        var accounts = svc.GetAccounts();
                        foreach (var account in accounts) Console.WriteLine(account.Name);
                        break;
                    case 2:
                        Console.WriteLine("Введите id Account");
                        if (!Int32.TryParse(Console.ReadLine(), out var accountId)) continue;
                        var accountById = svc.GetAccount(accountId);
                        if (accountById != null)
                            Console.WriteLine(accountById.SurName);
                        else
                            Console.WriteLine("Данный аккаунт не найден");
                        break;
                    case 3:
                        svc.SetAccount("Ivanov", "Ivan", "Ivanovich", DateTime.Now, 0);
                        Console.WriteLine("Account inserted successfully");
                        break;
                    case 4:
                        var bets = svc.GetBets();
                        foreach (var bet in bets) Console.WriteLine(bet.Id);
                        break;
                    case 5:
                        Console.WriteLine("Введите id Bet");
                        if (!Int32.TryParse(Console.ReadLine(), out var betId)) continue;
                        var betById = svc.GetBet(betId);
                        if (betById != null)
                            Console.WriteLine(betById.InValue);
                        else
                            Console.WriteLine("Данная ставка не найдена");
                        break;
                    case 6:
                        svc.SetBet(DateTime.Now, 10, 2, false, 0);
                        Console.WriteLine("Bet inserted successfully");
                        break;
                    case 7:
                        Console.WriteLine("Введите AccountId и кол-во средств, которое хотите внести");
                        var str1 = Console.ReadLine().Split(' ');
                        if (!Int32.TryParse(str1[0], out var id1)) continue;
                        if (!double.TryParse(str1[1], out var value1)) continue;
                        svc.AccountBalanceUp(id1, value1);
                        break;
                    case 8:
                        Console.WriteLine("Введите AccountId и кол-во средств, которое хотите внести");
                        var str2 = Console.ReadLine().Split(' ');
                        if (!Int32.TryParse(str2[0], out var id2)) continue;
                        if (!double.TryParse(str2[1], out var value2)) continue;
                        svc.AccountBalanceDown(id2, value2);
                        break;
                    case 9:
                        Console.WriteLine("Введите Surname");
                        var accountsBySurname = svc.GetAccountsBySurname(Console.ReadLine());
                        foreach (var account in accountsBySurname) Console.WriteLine(account.Name);
                        break;
                    case 10:
                        Console.WriteLine("Введите Сумму ставки");
                        if (!double.TryParse(Console.ReadLine(), out var result))
                        {
                            Console.WriteLine("Неправильная сумма");
                            break;
                        }

                        var betsByInValue = svc.GetBetsByInValue(result);
                        if (betsByInValue.Length == 0) Console.WriteLine("Нет таких");
                        foreach (var bet in betsByInValue) Console.WriteLine(bet.Id);
                        break;

                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}