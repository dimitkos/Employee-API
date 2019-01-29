﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyApi.Types
{
    public class ProxyEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
        public string Job { get; set; }
    }
}
