using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.DataAccess.Concrete.EntityFramework
{
    public class LogisticsContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryDetail> FactoryDetails { get; set; }
        public DbSet<Depot> Depots { get; set; }
        public DbSet<CustomerSupplier> CustomerSupplier { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<StatusDetail> StatusDetails { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }

    }
}
