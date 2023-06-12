using Logistics.Business.Abstract;
using Logistics.Business.Utilities;
using Logistics.DataAccess.Abstract;
using Logistics.DataAccess.Concrete.EntityFramework;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetAllByCustomerId(int customerId)
        {
            return _orderDal.GetAll(o => o.CustomerID == customerId);
        }

        public List<Order> GetAllBySupplierId(int supplierId)
        {
            return _orderDal.GetAll(o => o.SupplierID == supplierId);
        }

        public List<Order> GetAllCompletedOrdersByFactoryId(int factoryId)
        {
            return _orderDal.GetAll(o => (o.Status == FixedValues.ConfirmedStatusId ||
                                           o.Status == FixedValues.RejectedStatusId) && (o.SupplierID == factoryId));
        }

        public List<Order> GetByDateRange(DateTime startDate, DateTime endDate, int factoryId)
        {
            return _orderDal.GetAll(o => (o.OrderDate >= startDate && o.OrderDate <= endDate)
                             && o.SupplierID == factoryId);
        }

        public List<Order> GetByDepotName(string searchKey, int factoryId)
        {
            return _orderDal.GetAll(o => ( o.SupplierDepotName.ToLower().Contains(searchKey.ToLower()) ||
                                                       o.CustomerDepotName.ToLower().Contains(searchKey.ToLower()))
                                                         && o.SupplierID == factoryId 
                                                         && (o.Status == FixedValues.ConfirmedStatusId || o.Status ==  FixedValues.RejectedStatusId));
        }

        public Order GetOrderById(int orderId)
        {
            return _orderDal.Get(o => o.OrderId == orderId);
        }

        public void Update(Order order)
        {          
            try
            {
                _orderDal.Update(order);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
