using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StockContext : DbContext
    {
        
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
    }
}