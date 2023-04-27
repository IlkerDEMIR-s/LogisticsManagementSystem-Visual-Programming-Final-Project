using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Abstract
{
    public interface ICustomerSupplierService
    {
        void Delete(CustomerSupplier customerSupplier);
        void Add(CustomerSupplier customerSupplier);
        void AddCustomerToSuppliers(int customerId, int supplierId);
        List<CustomerSupplier> GetAllCustomersBySupplierId(int supplierId);
        bool CheckIfCustomerExists(int customerId, int factoryId);
    }
}
