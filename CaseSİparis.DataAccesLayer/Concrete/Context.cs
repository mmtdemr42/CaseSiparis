using CaseSiparis.DataEntity;
using CaseSiparis.DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSİparis.DataAccesLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
