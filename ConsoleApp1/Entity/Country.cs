﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Country
    {
        public int Id { get; set; }
        //[MaxLength(100)]

        public string Name { get; set; }
        public virtual ICollection<Airplane> Airplanes { get; set; } = new HashSet<Airplane>();
    }
}
