using BettingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingAPI.Data
{
    public class BettingDbContext : DbContext
    {
        public BettingDbContext(DbContextOptions<BettingDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}
