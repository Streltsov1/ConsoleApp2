using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DbInitializer
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new Country() {Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Great Britain" },
                new Country() { Id = 3, Name = "USA" }
            });
            modelBuilder.Entity<Gender>().HasData(new Gender[]
            {
                new Gender() {Id = 1, Name = "Man"},
                new Gender() { Id = 2, Name = "Woman" },
            });
            modelBuilder.Entity<Place>().HasData(new Place[]
            {
                new Place() {Id = 1, Name = "London"},
                new Place() { Id = 2, Name = "Kiev" },
                new Place() { Id = 3, Name = "New-York" },
            });
        }
    }
}
