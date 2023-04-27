using Logistics.Entities.Concrete;
using System.Collections.Generic;

namespace Logistics.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        int GetCurrentStock(int productId);
        void UpdateStockQuantity(int productId, int newStockQuantity);
        List<Product> GetAllWithNames();
    }
}
