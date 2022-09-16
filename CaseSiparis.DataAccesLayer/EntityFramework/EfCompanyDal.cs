using CaseSiparis.DataAccesLayer.Abstract;
using CaseSiparis.DataAccesLayer.Concrete.Repository;
using CaseSiparis.DataEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.DataAccesLayer.EntityFramework
{
    public class EfCompanyDal : GenericRepository<Company>, ICompanyDal
    {
    }
}
