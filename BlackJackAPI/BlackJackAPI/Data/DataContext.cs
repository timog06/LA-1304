using Microsoft.EntityFrameworkCore;

namespace BlackJackAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
