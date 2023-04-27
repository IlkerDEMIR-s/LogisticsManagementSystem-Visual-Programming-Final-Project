using Logistics.DataAccess.Abstract;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class EfFactoryDal : EfEntityRepositoryBase<Factory, LogisticsContext>, IFactoryDal
    {
        public List<Factory> GetAllCustomers(int typeID)
        {
            using (var context = new LogisticsContext())
            {
                return context.Factories.Where(f => f.TypeId == typeID).ToList();
            }
        }

        public List<Factory> GetCustomersForDataGridView(int factoryID)
        {
            using (var context = new LogisticsContext())
            {
                var result = from f in context.Factories
                             join cs in context.CustomerSupplier on f.FactoryID equals cs.CustomerId
                             where cs.SupplierId == factoryID
                             select f;

                return result.ToList();
            }
        }

        public string GetCompanyNameById(int factoryId)
        {
            using (var context = new LogisticsContext())
            {
                var factory = context.Factories.SingleOrDefault(f => f.FactoryID == factoryId);

                if (factory != null)
                {
                    return factory.CompanyName;
                }
                return null;
            }
        }




    }
}
