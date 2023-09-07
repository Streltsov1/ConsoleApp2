using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Shop
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        //[MaxLength(100)]
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public int? ParkingArea { get; set; }
        public virtual ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();

    }
}
