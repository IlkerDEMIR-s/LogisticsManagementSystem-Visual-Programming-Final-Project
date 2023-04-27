using Logistics.Business.Abstract;
using Logistics.DataAccess.Abstract;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Concrete
{
    public class ProductInDepotManager : IProductInDepotService
    {
        private IProductInDepotDal _productInDepotDal;

        public ProductInDepotManager(IProductInDepotDal productInDepotDal)
        {
            _productInDepotDal = productInDepotDal;
        }

        public List<ProductInDepot> GetByDepotId(int depotId)
        {
            return _productInDepotDal.GetAll().Where(d => d.DepotID == depotId).ToList();
        }
    }
}
