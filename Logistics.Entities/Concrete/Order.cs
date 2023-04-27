using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string DepotName { get; set; }
        public int SupplierID { get; set; }
        public int CustomerID { get; set; }
        public int DepotId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
