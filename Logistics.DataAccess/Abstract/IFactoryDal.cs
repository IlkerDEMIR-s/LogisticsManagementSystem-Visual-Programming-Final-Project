using Logistics.DataAccess.Concrete.EntityFramework;
using Logistics.Entities.Concrete;
using System.Collections.Generic;

namespace Logistics.DataAccess.Abstract
{
    public interface IFactoryDal : IEntityRepository<Factory>
    {
        List<Factory> GetAllCustomers(int typeId);
        List<Factory> GetCustomersForDataGridView(int factoryID);
        string GetCompanyNameById(int factoryId);


    }
}
