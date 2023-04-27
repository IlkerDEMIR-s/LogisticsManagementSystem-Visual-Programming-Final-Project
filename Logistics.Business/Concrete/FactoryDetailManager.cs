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
    public class FactoryDetailManager : IFactoryDetailService
    {
        private IFactoryDetailDal _detailDal;

        public FactoryDetailManager(IFactoryDetailDal detailDal)
        {
            _detailDal = detailDal;
        }

        public List<FactoryDetail> GetAll()
        {
            return _detailDal.GetAll();
        }

        public string GetFactoryTypeNameById(int id)
        {
            return _detailDal.GetFactoryTypeNameById(id);
        }
    }
}
