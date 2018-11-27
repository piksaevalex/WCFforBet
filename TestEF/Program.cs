using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.model;

namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountContext db;
            db = new AccountContext();
            db.Accounts.Load();
            var m = db.Accounts.Local.ToBindingList();
            var array = db.Accounts.Local.ToArray();
            Console.WriteLine("PPPPPPP");
            Console.ReadKey();
            db.Dispose();
        }
    }
}
