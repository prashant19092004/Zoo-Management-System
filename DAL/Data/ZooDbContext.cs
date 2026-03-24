using Microsoft.EntityFrameworkCore;
using ZooManagement.DAL.Entities;

namespace ZooManagement.DAL.Data
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext()
        {
            
        }
        public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=192.168.1.250,51434;Database=Prashant;User Id=Prashant;Password=Prashant;TrustServerCertificate=True;");
            }
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     // Configure your database connection string here
        //     // For SQLite, the database file will be created in the project directory
        //     optionsBuilder.UseSqlServer("Server=192.168.1.250,51434;Database=Prashant;User Id=Prashant;Password=Prashant;TrustServerCertificate=True;"); 
        // }
    }    
}