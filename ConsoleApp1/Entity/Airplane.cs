using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Airplane
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Model { get; set; }
        //[MaxLength(100)]
        public string Type { get; set; }
        public int MaxPassengers { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();
    }
}
