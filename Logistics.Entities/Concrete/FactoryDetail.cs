using Logistics.Entities.Abstract;
using System.ComponentModel.DataAnnotations;


namespace Logistics.Entities.Concrete
{
    public class FactoryDetail : IEntity
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
    }
}
