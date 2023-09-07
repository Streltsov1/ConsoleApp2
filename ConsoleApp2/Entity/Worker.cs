using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Worker
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        //[MaxLength(100)]
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        //[MaxLength(100)]
        public string Email { get; set; }
        //[MaxLength(12)]
        public string PhoneNumber { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
