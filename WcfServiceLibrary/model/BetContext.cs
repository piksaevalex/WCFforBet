using System.Data.Entity;
namespace WcfServiceLibrary.Model
{
    public class BetContext : DbContext
    {
        public BetContext() : base("DefaultConnection")
        {

        }
        public DbSet<Bet> Bets { get; set; }

    }
}