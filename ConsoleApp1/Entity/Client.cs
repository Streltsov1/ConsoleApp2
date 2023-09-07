using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Client
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        //[MaxLength(100)]
        public string Surname { get; set; }
        //[MaxLength(100)]
        public string Email { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public virtual ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();

    }
}
