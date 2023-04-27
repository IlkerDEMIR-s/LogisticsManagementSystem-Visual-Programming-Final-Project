using Logistics.DataAccess.Abstract;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, LogisticsContext>, IProductDal
    {
        public int GetCurrentStock(int productId)
        {
            using (var context = new LogisticsContext())
            {
                var product = context.Products.FirstOrDefault(p => p.ProductID == productId);
                return product?.UnitInStock ?? 0;
            }
        }

        public void UpdateStockQuantity(int productId, int newStockQuantity)
        {
            using (var context = new LogisticsContext())
            {
                // Retrieve the existing Depot object from the database
                var existingProduct = context.Products.FirstOrDefault(p => p.ProductID == productId);

                if (existingProduct != null)
                {
                    // Update the UnitInStock property with the new value
                    existingProduct.UnitInStock = newStockQuantity;

                    // Save the changes to the database
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product not found.");
                }
            }
        }

        public List<Product> GetAllWithNames()
        {
            using (var context = new LogisticsContext())
            {
                var products = context.Products
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName
                    })
                    .ToList();

                return products.Select(p => new Product
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName
                }).ToList();
            }
        }
    }
}