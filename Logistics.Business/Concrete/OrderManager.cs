using Logistics.Business.Abstract;
using Logistics.DataAccess.Abstract;
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

        public List<Order> GetAllbyFactoryId(int factoryId)
        {
            return _orderDal.GetAllbyFactoryId(factoryId);
        }

    }
}
