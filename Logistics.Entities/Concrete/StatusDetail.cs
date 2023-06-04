using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class StatusDetail: IEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

    }
}
