using CaseSiparis.DataEntity;
using CaseSiparis.DataEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaseSiparis.DataAccesLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=CaseSiparisDb;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
