using System.Data.Entity;

namespace TestEF.model
{
    public class AccountContext : DbContext
    {
        public AccountContext() : base("DefaultConnection")
        {

        }
        public DbSet<Account> Accounts { get; set; }
    }
}