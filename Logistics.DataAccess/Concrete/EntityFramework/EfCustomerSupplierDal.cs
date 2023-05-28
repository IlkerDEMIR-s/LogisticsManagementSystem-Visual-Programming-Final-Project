using Logistics.DataAccess.Abstract;
using Logistics.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerSupplierDal : EfEntityRepositoryBase<CustomerSupplier, LogisticsContext>, ICustomerSupplierDal
    {
        public void AddCustomerToSuppliers(int customerId, int supplierId, string customerName)
        {

            var customerSupplier = new CustomerSupplier
            {
                CustomerId = customerId,
                SupplierId = supplierId,
                CustomerName = customerName
            };

            Add(customerSupplier);
        }

        public bool CheckIfCustomerExists(int customerId, int factoryId)
        {
            using (var context = new LogisticsContext())
            {
                bool customerExists = context.CustomerSupplier
                                .Any(c => c.CustomerId == customerId && c.SupplierId == factoryId);
                return customerExists;
            }

        }

    }
}
