using FluentValidation;
using Logistics.Business.Abstract;
using Logistics.Business.Utilities;
using Logistics.Business.ValidationRules.FluentValidation;
using Logistics.DataAccess.Abstract;
using Logistics.DataAccess.Concrete.EntityFramework;
using Logistics.Entities.Concrete;
using Northwind.Business.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Logistics.Business.Concrete
{
    public class FactoryManager : IFactoryService
    {
        private IFactoryDal _factoryDal;

        public FactoryManager(IFactoryDal factoryDal)
        {
            _factoryDal = factoryDal;
        }

        public List<Factory> GetByTypeId(int typeId)
        {
            return _factoryDal.GetAll().Where(f => f.TypeId == typeId).ToList();
        }

        public List<Factory> GetAll()
        {
            return _factoryDal.GetAll();
        }

        public bool CheckPassword(int factoryId, string password)
        {
            Factory factory = _factoryDal.Get(f => f.FactoryID == factoryId);
            return factory != null && factory.Password == password;
        }

        public List<Factory> GetByFactoryId(int factoryId)
        {
            return _factoryDal.GetAll().Where(f => f.FactoryID == factoryId).ToList();
        }

        public List<Factory> GetAllCustomers(int typeId)
        {
            return _factoryDal.GetAllCustomers(typeId);
        }
        public List<Factory> GetByFactoryName(string searchKey)
        {
            return _factoryDal.GetAll(f => f.TypeId == 2 && f.CompanyName.ToLower().Contains(searchKey.ToLower()));

        }

        public void Add(Factory factory)
        {
            //var validator = new FactoryValidator();
            //var context = new ValidationContext<Factory>(factory);
            //ValidationTool.Validate(validator, context);
            _factoryDal.Add(factory);
        }

        public void Delete(Factory factory)
        {
            try
            {
                _factoryDal.Delete(factory);
            }
            catch
            {
                throw new Exception("Delete failed!");
            }
        }

        public void Update(Factory factory)
        {
            //var validator = new FactoryValidator();
            //var context = new ValidationContext<Factory>(factory);
            //ValidationTool.Validate(validator, context);
            try
            {
                _factoryDal.Update(factory);
            }
            catch
            {
                throw new Exception("Update failed!");
            }
        }

        public List<Factory> GetCustomersForDataGridView(int factoryID)
        {
            return _factoryDal.GetCustomersForDataGridView(factoryID);
        }

        public string GetCompanyNameById(int factoryId)
        {
            return _factoryDal.GetCompanyNameById(factoryId);
        }

        public Factory GetByCompanyName(string companyName)
        {
            return _factoryDal.Get(f => f.CompanyName.ToLower().Contains(companyName.ToLower()));
        }

        public Factory GetFactoryById(int factoryId)
        {
            return _factoryDal.Get(f => f.FactoryID == factoryId);
        }

        public string GetEncodedPassword(int factoryId)
        {
            return _factoryDal.Get(f => f.FactoryID == factoryId).Password;
        }
    }
}
