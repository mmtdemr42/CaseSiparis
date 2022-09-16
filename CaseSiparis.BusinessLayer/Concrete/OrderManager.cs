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
    public class OrderManager : GenericServiceManager<Order>, IOrderService
    {
        private readonly IRepository<Order> _orderDal;

        public OrderManager(IRepository<Order> manager) : base(manager)
        {
            _orderDal = manager;
        }
    }
}
