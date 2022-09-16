using CaseSiparis.BusinessLayer.Abstract;
using CaseSiparis.BusinessLayer.Concrete.GenericServiceManager;
using CaseSiparis.DataAccesLayer.Abstract;
using CaseSiparis.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.BusinessLayer.Concrete
{
    public class ProductManager : GenericServiceManager<Product>, IProductService
    {
        private readonly IRepository<Product> _productDal;
        public ProductManager(IRepository<Product> manager) : base(manager)
        {
            _productDal = manager;
        }
    }
}
