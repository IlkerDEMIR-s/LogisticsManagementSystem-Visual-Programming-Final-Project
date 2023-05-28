using Logistics.Entities.Abstract;


namespace Logistics.Entities.Concrete
{
    public class CustomerSupplier:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string CustomerName { get; set; }
    }
}
