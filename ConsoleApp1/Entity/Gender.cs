using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gender
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; } = new HashSet<Client>();
    }
}
