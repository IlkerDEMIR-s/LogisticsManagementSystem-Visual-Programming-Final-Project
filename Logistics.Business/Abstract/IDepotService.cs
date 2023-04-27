using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Abstract
{
    public interface IDepotService
    {
        List<Depot> GetAll();
        void Update(Depot depot);        
        List<Depot> GetByProductId(int productId);
        int GetCurrentStock(int depotId);
        void UpdateStockQuantity(int depotId, int newStockQuantity);
        List<Depot> GetByDepotNameAndFactoryID(string searchKey, int factoryId);
        List<Depot> GetByDepotName(string searchKey);
        void Delete(Depot depot);
        void Add(Depot depot);
        string CheckUnitInStock(int factoryId);
        List<Depot> GetByFactoryId(int factoryId);
        List<Depot> GetDepotsByCustomer(int customerId);
        List<Depot> GetDepotsByCustomerWithSearchKey(int customerId, string searchKey);

    }
}
