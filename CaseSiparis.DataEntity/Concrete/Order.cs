using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.DataEntity
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderCompanyId { get; set; }
        public int ProductId { get; set; }
        public int OrderProductCount { get; set; }
        public decimal OrderProductAmount { get; set; }
    }
}
