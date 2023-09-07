using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Place
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();
    }
}
