using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class Factory: IEntity
    {
        public int FactoryID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int TypeId { get; set; }
        public string HomePage { get; set; }
        public string Password { get; set; }
    }
}
