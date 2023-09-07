using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Product
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }
        public virtual ICollection<Shop> Shops { get; set; } = new HashSet<Shop>();
    }
}
