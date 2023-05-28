using Logistics.Business.Abstract;
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
    public class CustomerSupplierManager : ICustomerSupplierService
    {
        private ICustomerSupplierDal _customerDal;        

        public CustomerSupplierManager(ICustomerSupplierDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(CustomerSupplier customerSupplier)
        {
            _customerDal.Add(customerSupplier);
        }

        public void AddCustomerToSuppliers(int customerId, int supplierId, string customerName)
        {
            _customerDal.AddCustomerToSuppliers(customerId, supplierId, customerName);
        }

        public bool CheckIfCustomerExists(int customerId, int factoryId)
        {
            return _customerDal.CheckIfCustomerExists(customerId, factoryId);
        }

        public void Delete(CustomerSupplier customerSupplier)
        {                
            try
            {
                _customerDal.Delete(customerSupplier);
            }
            catch
            {
                throw new Exception("Delete failed!");
            }
        }

        public List<CustomerSupplier> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<CustomerSupplier> GetAllCustomersBySupplierId(int supplierId)
        {
            return _customerDal.GetAll(c => c.SupplierId == supplierId);
        }
    }
}
