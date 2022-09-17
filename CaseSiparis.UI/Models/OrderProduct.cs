using CaseSiparis.DataEntity;
using CaseSiparis.DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseSiparis.UI.Models
{
    public class OrderProduct
    {
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductAmount { get; set; }
        public int CompanyId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
