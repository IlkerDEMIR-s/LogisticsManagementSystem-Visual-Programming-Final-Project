using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        List<Order> GetAllbyFactoryId(int factoryId);
    }
}
