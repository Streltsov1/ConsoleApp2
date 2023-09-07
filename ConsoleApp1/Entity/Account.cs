using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Login { get; set; }
        //[MaxLength(100)]
        public string Password { get; set; }
        public virtual ICollection<Client> Clients { get; set; } = new HashSet<Client>();
    }
}
