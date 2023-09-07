using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Position
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();
    }
}
