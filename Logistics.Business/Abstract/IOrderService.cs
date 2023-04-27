using Logistics.Business.Utilities;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetAll();
        List<Order> GetAllbyFactoryId(int factoryId);
    }
}
