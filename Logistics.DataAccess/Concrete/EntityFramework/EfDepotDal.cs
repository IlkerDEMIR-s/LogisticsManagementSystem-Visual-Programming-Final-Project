using Logistics.DataAccess.Abstract;
using Logistics.Entities.Abstract;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class EfDepotDal : EfEntityRepositoryBase<Depot, LogisticsContext>, IDepotDal
    {
        public int GetCurrentStock(int depotId)
        {
            using (var context = new LogisticsContext())
            {
                var depot = context.Depots.FirstOrDefault(d => d.DepotID == depotId);
                return depot?.UnitInStock ?? 0;
            }
        }

        public void UpdateStockQuantity(int depotId, int newStockQuantity)
        {
            using (var context = new LogisticsContext())
            {
                // Retrieve the existing Depot object from the database
                var existingDepot = context.Depots.FirstOrDefault(d => d.DepotID == depotId);

                if (existingDepot != null)
                {
                    // Update the UnitInStock property with the new value
                    existingDepot.UnitInStock = newStockQuantity;

                    // Save the changes to the database
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Depot not found.");
                }
            }
        }

        public string CheckUnitInStock(int factoryId)
        {
            using (var context = new LogisticsContext())
            {
                var depots = context.Depots
                                    .Where(d => d.UnitInStock < 100)
                                    .Join(context.Products, d => d.ProductID, p => p.ProductID, (d, p) => new { Depot = d, Product = p })
                                    .Where(d => d.Depot.FactoryID == factoryId)
                                    .ToList();
                if (depots.Any())
                {
                    var message = new StringBuilder();
                    message.AppendLine("Warning: The following depots have a UnitInStock value below 100:\n");
                    foreach (var item in depots)
                    {
                        message.AppendLine($"* DepotId: {item.Depot.DepotID}\n" +
                                            $"* DepotName: {item.Depot.DepotName}\n" +
                                            $"* FactoryID: {item.Depot.FactoryID}\n" +
                                            $"* ProductID: {item.Depot.ProductID}\n" +
                                            $"* ProductName: {item.Product.ProductName}\n" +
                                            $"* UnitInStock: {item.Depot.UnitInStock}\n");
                    }
                    return message.ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Depot> GetDepotsByCustomer(int customerId)
        {
            using (var context = new LogisticsContext()) // assuming your DbContext is named LogisticsContext
            {
                var factories = context.CustomerSupplier
                    .Where(cs => cs.CustomerId == customerId)
                    .Select(cs => cs.SupplierId) // factories that the customer is associated with
                    .ToList();

                var depots = context.Depots
                    .Where(d => factories.Contains(d.FactoryID)) // depots that belong to those factories
                    .ToList();

                return depots;
            }
        }

        public List<Depot> GetDepotsByCustomerWithSearchKey(int customerId, string searchKey)
        {
            using (var context = new LogisticsContext())  
            {
                var factories = context.CustomerSupplier
                    .Where(cs => cs.CustomerId == customerId)
                    .Select(cs => cs.SupplierId)  
                    .ToList();

                var depots = context.Depots
                    .Where(d => factories.Contains(d.FactoryID) && d.DepotName.Contains(searchKey))  
                    .ToList();

                return depots;
            }
        }
    }


}
