using Logistics.DataAccess.Concrete.EntityFramework;
using Logistics.Entities.Concrete;
using System.Collections.Generic;


namespace Logistics.Business.Abstract
{
    public interface IFactoryService
    {
        List<Factory> GetAll();
        List<Factory> GetByTypeId(int typeId);
        bool CheckPassword(int factoryId, string password);
        List<Factory> GetByFactoryId(int factoryId);
        List<Factory> GetAllCustomers(int typeId);
        List<Factory> GetByFactoryName(string searchKey);
        void Add(Factory factory);
        void Delete(Factory factory);
        void Update(Factory factory);
        List<Factory> GetCustomersForDataGridView(int factoryID);
        string GetCompanyNameById(int factoryId);
        Factory GetByCompanyName(string companyName);
        Factory GetFactoryById(int factoryId);
        string GetEncodedPassword(int factoryId);



    }
}
