using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class ProductInDepot: IEntity
    {
        public int Id { get; set; }
        public int DepotID { get; set; }
        public int ProductID { get; set; }
        public int UnitInStock { get; set; }
    }
}
