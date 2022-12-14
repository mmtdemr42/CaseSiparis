using CaseSiparis.BusinessLayer.Abstract.IService;
using CaseSiparis.DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.BusinessLayer.Concrete.GenericServiceManager
{
    public class GenericServiceManager<TEntity> : IService<TEntity> where TEntity : class
    {
        private IRepository<TEntity> _manager;
        public GenericServiceManager(IRepository<TEntity> manager)
        {
            _manager = manager;
        }
        public void Add(TEntity entity)
        {
            _manager.Insert(entity);
        }

        public void Delete(TEntity entity)
        {
            _manager.Delete(entity);
        }

        public List<TEntity> List()
        {
            return _manager.List();
        }

        public void Update(TEntity entity)
        {
            _manager.Update(entity);
        }
    }
}
