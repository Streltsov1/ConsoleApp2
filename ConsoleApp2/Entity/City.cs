using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class City
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<Shop> Shops { get; set; } = new HashSet<Shop>();
    }
}
