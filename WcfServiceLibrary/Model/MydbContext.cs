using System.Data.Entity;

namespace WcfServiceLibrary.Model
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DefaultConnection")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bet> Bets { get; set; }
    }
}