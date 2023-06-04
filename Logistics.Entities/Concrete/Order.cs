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
        public int SupplierID { get; set; }
        public int SupplierDepotId { get; set; }
        public string SupplierDepotName { get; set; }    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerDepotId { get; set; }
        public string CustomerDepotName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
    }
}
