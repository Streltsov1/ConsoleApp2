using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class DbInitializer
    {
        public static void SeedData(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new Country() {Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Great Britain" },
                new Country() { Id = 3, Name = "USA" }
            });
            modelBuilder.Entity<City>().HasData(new City[]
            {
                new City() { Id = 1, Name= "Rivne", CountryId = 1},
                new City() { Id = 2, Name= "Lviv", CountryId = 1},
                new City() { Id = 3, Name= "New-York", CountryId = 3},
                new City() { Id = 4, Name= "London", CountryId = 2}
            });
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category() { Id = 1, Name = "Food"},
                new Category() { Id = 2, Name = "Household chemicals"},
                new Category() { Id = 3, Name = "For cars"}
            });
            modelBuilder.Entity<Position>().HasData(new Position[]
            {
                new Position() { Id = 1, Name = "Manager"},
                new Position() { Id = 2, Name = "Seller"},
                new Position() { Id = 3, Name = "Guard"}
            });
        }
    }
}
