﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.DataEntity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductAmount { get; set; }
    }
}
