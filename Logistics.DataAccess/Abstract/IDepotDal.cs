using Logistics.DataAccess.Concrete.EntityFramework;
using Logistics.Entities.Concrete;
using System.Collections.Generic;

namespace Logistics.DataAccess.Abstract
{
    public interface IDepotDal : IEntityRepository<Depot>
    {
        int GetCurrentStock(int depotId);

       void UpdateStockQuantity(int depotId, int newStockQuantity);
        string CheckUnitInStock(int factoryId);
        List<Depot> GetDepotsByCustomer(int customerId);
        List<Depot> GetDepotsByCustomerWithSearchKey(int customerId, string searchKey);
    }
}
