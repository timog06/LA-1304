using BlackJackAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlackJackAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
    }
}
