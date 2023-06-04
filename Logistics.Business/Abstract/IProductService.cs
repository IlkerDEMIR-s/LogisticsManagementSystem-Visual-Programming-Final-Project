using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId, int factoryId);
        List<Product> GetByProductName(string searchKey, int factoryId);
        void Update(Product product);
        int GetCurrentStock(int productId);
        void UpdateStockQuantity(int productId, int newStockQuantity);
        List<Product> GetByFactoryId(int factoryId);

        List<Product> GetByProductId(int productId);



    }
}
