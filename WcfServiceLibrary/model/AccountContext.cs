using System.Data.Entity;

namespace WcfServiceLibrary.model
{
    public class AccountContext : DbContext
    {
        public AccountContext() : base("DefaultConnection")
        {
        }
        public DbSet<Account> Accounts { get; set; }
    }
}