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
                if (!int.TryParse(caseItem, out caseSwitch))
                {
                    Console.WriteLine("Enter number or press [ENTER] to quit...");
                    continue;
                }

                switch (caseSwitch)
                {
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                    case 1:
                        var accounts = svc.GetAccounts();
                        foreach (var account in accounts) Console.WriteLine(account.Name);
                        break;
                    case 2:
                        Console.WriteLine("Введите id Account");
                        var accountId = Convert.ToInt32(Console.ReadLine());
                        var accountById = svc.GetAccount(accountId);
                        if (accountById != null)
                            Console.WriteLine(accountById.SurName);
                        else
                            Console.WriteLine("Данный аккаунт не найден");
                        break;
                    case 3:
                        svc.SetAccount("Ivanov", "Ivan", "Ivanovich", DateTime.Now, 0);
                        Console.WriteLine("Account insert Sucsed");
                        break;
                    case 4:
                        var bets = svc.GetBets();
                        foreach (var bet in bets) Console.WriteLine(bet.Id);
                        break;
                    case 5:
                        Console.WriteLine("Введите id Bet");
                        var betId = Convert.ToInt32(Console.ReadLine());
                        var betById = svc.GetBet(betId);
                        if (betById != null)
                            Console.WriteLine(betById.InValue);
                        else
                            Console.WriteLine("Данная ставка не найдена");
                        break;
                    case 6:
                        svc.SetBet(DateTime.Now, 10, 2, false, 0);
                        Console.WriteLine("Bet insert Sucsed");
                        break;
                    case 7:
                        Console.WriteLine("Введите AccountId и кол-во средств, которое хотите внести");
                        var str1 = Console.ReadLine().Split(' ');
                        var id1 = Convert.ToInt32(str1[0]);
                        var value1 = Convert.ToDouble(str1[1]);
                        svc.AccountBalanceUp(id1, value1);
                        break;
                    case 8:
                        Console.WriteLine("Введите AccountId и кол-во средств, которое хотите внести");
                        var str2 = Console.ReadLine().Split(' ');
                        var id2 = Convert.ToInt32(str2[0]);
                        var value2 = Convert.ToDouble(str2[1]);
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
                }
            }
        }
    }
}