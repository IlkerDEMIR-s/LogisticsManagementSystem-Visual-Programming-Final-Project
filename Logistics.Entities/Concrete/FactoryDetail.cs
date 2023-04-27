using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class FactoryDetail : IEntity
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
    }
}
