using System.Data.Entity;
namespace WcfServiceLibrary.model
{
    public class BetContext : DbContext
    {
        public BetContext() : base("DefaultConnection")
        {

        }
        public DbSet<Bet> Bets { get; set; }

    }
}