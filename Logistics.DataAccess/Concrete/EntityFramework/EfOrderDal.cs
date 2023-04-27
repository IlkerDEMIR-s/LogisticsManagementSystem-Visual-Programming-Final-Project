using Logistics.DataAccess.Abstract;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, LogisticsContext>, IOrderDal
    {
        public List<Order> GetAllbyFactoryId(int factoryId)
        {
            using (var context = new LogisticsContext())
            {
                var result = GetAll().Where(o => o.SupplierID == factoryId).ToList();
                return result;
            }
        }

    }
}
