using Logistics.Entities.Abstract;
using System;

namespace Logistics.Entities.Concrete
{
    public class Product: IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? FactoryID { get; set; } // set default value to null
        public int? CategoryID { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitInStock { get; set; }
    }
}

