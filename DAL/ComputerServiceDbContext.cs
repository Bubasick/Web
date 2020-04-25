using System;
using System.Collections.Generic;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ComputerServiceDbContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<ComputerParts> ComputerParts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public ComputerServiceDbContext(DbContextOptions<ComputerServiceDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Part part = new Part()
            {
                PartName = "SHS",
                DateOfCreation = DateTime.Today,
                Id = 1,
            };

            Owner owner = new Owner()
            {
                Id = 1,
                Name = "Nameless dude"

            };
            Computer computer = new Computer()
            {
                Id = 1,
                OwnerId = 1
            };
            Order order = new Order()
            {
                Id = 1

            };

            ComputerParts computerParts = new ComputerParts()
            {
                Id = 1,
            };
            modelBuilder.Entity<Order>().HasData(order);
            modelBuilder.Entity<Owner>().HasData(owner);
            modelBuilder.Entity<Part>().HasData(part);
            modelBuilder.Entity<Computer>().HasData(computer);
            modelBuilder.Entity<ComputerParts>().HasData(computerParts);
    
        }
    }
}