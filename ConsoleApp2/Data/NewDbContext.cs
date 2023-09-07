using ConsoleApp3.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class NewDbContext : DbContext
    {
        public NewDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Category>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Position>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.ApplyConfiguration(new CityConfigs());
            modelBuilder.ApplyConfiguration(new ProductConfigs());
            modelBuilder.ApplyConfiguration(new ShopConfigs());
            modelBuilder.ApplyConfiguration(new WorkerConfigs());
            DbInitializer.SeedData(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
