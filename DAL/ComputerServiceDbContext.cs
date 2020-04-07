using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ComputerServiceDbContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<ComputerParts>  ComputerParts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public ComputerServiceDbContext(DbContextOptions<ComputerServiceDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}