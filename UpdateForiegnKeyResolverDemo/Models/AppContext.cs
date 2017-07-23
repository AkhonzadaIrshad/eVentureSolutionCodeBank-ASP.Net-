using System.Data.Entity;

namespace UpdateForiegnKeyResolverDemo.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=ConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}