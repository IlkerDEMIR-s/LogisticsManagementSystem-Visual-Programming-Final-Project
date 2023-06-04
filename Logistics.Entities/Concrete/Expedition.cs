using Logistics.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Entities.Concrete
{
    public class Expedition : IEntity
    {
        public int ExpeditionID { get; set; }
        public int OrderId { get; set; }
        public int SupplierID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string CargoName { get; set; }
        public int CargoParcelAmount { get; set; }
        public int TotalCargoVolume { get; set; }
        public int TotalCargoWeight { get; set; }
        public DateTime EstimatedDepartureDate { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
        public DateTime? ActualDepartureDate { get; set; }
        public DateTime? ActualArrivalDate { get; set; }
        public int CargoStatusID { get; set; }
        public string CargoStatusName { get; set; }

    }
}
