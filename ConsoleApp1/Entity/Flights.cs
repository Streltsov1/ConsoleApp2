using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Flights
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public virtual ICollection<Airplane> Airplanes { get; set; } = new HashSet<Airplane>();
        public virtual ICollection<Client> Clients { get; set; } = new HashSet<Client>();
        public DateTime DispatchDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int ArrivalPlaceId { get; set; }
        public Place Arrival { get; set; }
    }
}
