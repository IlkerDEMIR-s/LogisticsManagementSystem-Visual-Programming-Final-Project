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
        List<Order> GetAllBySupplierId(int supplierId);
        List<Order> GetAllByCustomerId(int customerId);
        Order GetOrderById(int orderId);
        void Update(Order order);
        List<Order> GetAllCompletedOrdersByFactoryId(int factoryId);
        List<Order> GetByDepotName(string searchKey, int factoryId);
        List<Order> GetByDateRange(DateTime startDate, DateTime endDate, int factoryId);
    }
}
