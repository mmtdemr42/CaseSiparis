using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.DataEntity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(20)]
        public string ProductName { get; set; }
        public int? ProductCount { get; set; }
        public decimal? ProductAmount { get; set; }
        public int CompanyId { get; set; }
    }
}
