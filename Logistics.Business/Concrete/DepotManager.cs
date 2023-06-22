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
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Concrete
{
    public class DepotManager: IDepotService
    {
        private IDepotDal _depotDal;

        public DepotManager(IDepotDal depotDal)
        {
            _depotDal = depotDal;
        }

        public List<Depot> GetAll()
        {
            return _depotDal.GetAll();
        }

        public List<Depot> GetByProductId(int productId)
        {
            return _depotDal.GetAll().Where(d => d.ProductID == productId).ToList();
        }

        public int GetCurrentStock(int depotId)
        {
            return _depotDal.GetCurrentStock(depotId);
        }

        public void Update(Depot depot)
        {
            var validator = new DepotValidator();
            var context = new ValidationContext<Depot>(depot);
            ValidationTool.Validate(validator, context);
            try
            {
                _depotDal.Update(depot);
            }
            catch(Exception ex)
            {     
                throw new Exception(ex.Message);
            }

        }

        public void UpdateStockQuantity(int depotId, int newStockQuantity)
        {
            _depotDal.UpdateStockQuantity(depotId, newStockQuantity);
        }

        public List<Depot> GetByDepotNameAndFactoryID(string searchKey, int factoryId)
        {
            return _depotDal.GetAll(d => d.DepotName.ToLower().Contains(searchKey.ToLower()) && d.FactoryID == factoryId);

        }
        public void Delete(Depot depot)
        {
            _depotDal.Delete(depot);
        }

        public void Add(Depot depot)
        {
            var validator = new DepotValidator();
            var context = new ValidationContext<Depot>(depot);
            ValidationTool.Validate(validator, context);
            _depotDal.Add(depot);
        }

        public string CheckUnitInStock(int factoryId)
        {
            return _depotDal.CheckUnitInStock(factoryId);
        }

        public List<Depot> GetByFactoryId(int factoryId)
        {
            return _depotDal.GetAll(d => d.FactoryID == factoryId);
        }

        public List<Depot> GetByDepotName(string searchKey)
        {
            return _depotDal.GetAll(d => d.DepotName.ToLower().Contains(searchKey.ToLower()));
        }

        public List<Depot> GetDepotsByCustomer(int customerId)
        {
            return _depotDal.GetDepotsByCustomer(customerId);
        }

        public List<Depot> GetDepotsByCustomerWithSearchKey(int customerId, string searchKey)
        {
            return _depotDal.GetDepotsByCustomerWithSearchKey(customerId, searchKey);
        }

        public List<Depot> GetDepotsByCountry(int customerId, string countryName)
        {
            return _depotDal.GetDepotsByCountry(customerId, countryName);
        }
    }
}
