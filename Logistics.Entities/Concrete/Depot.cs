using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class Depot:IEntity
    {
        public int DepotID { get; set; }
        public string DepotName { get; set; }
        public int FactoryID { get; set; }
        public int ProductID { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int? UnitInStock { get; set; }     
    }
}
