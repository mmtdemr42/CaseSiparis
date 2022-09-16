using CaseSiparis.BusinessLayer.Abstract;
using CaseSiparis.BusinessLayer.Concrete.GenericServiceManager;
using CaseSiparis.DataAccesLayer.Abstract;
using CaseSiparis.DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.BusinessLayer.Concrete
{
    public class CompanyManager : GenericServiceManager<Company>, ICompanyService
    {
        private readonly IRepository<Company> _companyDal;
        public CompanyManager(IRepository<Company> manager) : base(manager)
        {
            _companyDal = manager;
        }
    }
}
