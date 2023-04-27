using Logistics.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;

namespace Logistics.DataAccess.Abstract
{
    public interface ICustomerSupplierDal : IEntityRepository<CustomerSupplier>
    {
        void AddCustomerToSuppliers(int customerId, int supplierId);
        bool CheckIfCustomerExists(int customerId, int factoryId);
    }
}
