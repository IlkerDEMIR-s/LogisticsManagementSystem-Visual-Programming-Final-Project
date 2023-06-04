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
    internal class StatusDetailManager : IStatusDetailService
    {
        private IStatusDetailDal _statusDetailDal;

        public StatusDetailManager(IStatusDetailDal statusDetailDal)
        {
            _statusDetailDal = statusDetailDal;
        }

        public List<StatusDetail> GetAll()
        {
            return _statusDetailDal.GetAll();
        }

        public List<StatusDetail> GetByStatusId(int statusId)
        {
            return _statusDetailDal.GetAll().Where(x => x.Id == statusId).ToList();
        }
    }
}
