using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.DataEntity.Concrete
{
   public  class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [StringLength(20)]
        public string CompanyName { get; set; }
        public List<Product> Products { get; set; }
    }
}
