using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext() : base() 
        { this.Database.EnsureCreated(); }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AirportDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AccountConfigs());
            modelBuilder.ApplyConfiguration(new AirplaneConfigs());
            modelBuilder.ApplyConfiguration(new ClientConfigs());
            modelBuilder.ApplyConfiguration(new CountryConfigs());
            modelBuilder.ApplyConfiguration(new FlightConfigs());
            modelBuilder.ApplyConfiguration(new GenderConfigs());
            modelBuilder.ApplyConfiguration(new PlaceConfigs());
            DbInitializer.SeedData(modelBuilder);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Place> Places { get; set; }

    }
}
