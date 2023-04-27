using Logistics.DataAccess.Abstract;
using Logistics.Entities.Abstract;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class EfFactoryDetailDal:EfEntityRepositoryBase<FactoryDetail, LogisticsContext>, IFactoryDetailDal
    {
        public string GetFactoryTypeNameById(int id)
        {
            using (var context = new LogisticsContext())
            {
                var factoryDetail = context.FactoryDetails.Find(id);
                return factoryDetail?.TypeName;
            }
        }

    }
}
