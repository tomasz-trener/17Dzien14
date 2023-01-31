using Microsoft.EntityFrameworkCore;
using P05Sklep.Shared;

namespace P04Sklep.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
