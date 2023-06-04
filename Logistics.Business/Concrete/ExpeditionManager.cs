using FluentValidation;
using Logistics.Business.Abstract;
using Logistics.Business.Utilities;
using Logistics.Business.ValidationRules.FluentValidation;
using Logistics.DataAccess.Abstract;
using Logistics.Entities.Concrete;
using Northwind.Business.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Concrete
{
    public class ExpeditionManager : IExpeditionService
    {
        private IExpeditionDal _expeditionDal;

        public ExpeditionManager(IExpeditionDal expeditionDal)
        {
            _expeditionDal = expeditionDal;
        }

        public void Add(Expedition expedition)
        {
            try
            {
                var validator = new ExpeditionValidator();
                var context = new ValidationContext<Expedition>(expedition);
                ValidationTool.Validate(validator, context);
                _expeditionDal.Add(expedition);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public List<Expedition> GetAll()
        {
            return _expeditionDal.GetAll();
        }

        public List<Expedition> GetAllByFactoryId(int factoryId)
        {
            return _expeditionDal.GetAll(e => e.SupplierID == factoryId);
        }

        public List<Expedition> GetAllCompletedExpeditionsByFactoryId(int factoryId)
        {
            return _expeditionDal.GetAll(e => (e.CargoStatusID == FixedValues.DeliveredStatusId ||
                                e.CargoStatusID == FixedValues.NotDeliveredStatusId ) && (e.SupplierID == factoryId));
        }

        public List<Expedition> GetByDateRange(DateTime startDate, DateTime endDate, int factoryId)
        {
            return _expeditionDal.GetAll(e => e.ActualArrivalDate >= startDate && e.ActualArrivalDate <= endDate && e.SupplierID == factoryId);
        }

        public List<Expedition> GetByDepotName(string searchKey, int factoryId)
        {
            return _expeditionDal.GetAll(e => (e.Source.ToLower().Contains(searchKey.ToLower()) ||
                                            e.Destination.ToLower().Contains(searchKey.ToLower()))
                                            && e.SupplierID == factoryId);
        }

        public Expedition GetExpeditionById(int expeditionId)
        {
            return _expeditionDal.Get(e => e.ExpeditionID == expeditionId);
        }

        public Expedition GetExpeditionByOrderId(int orderId)
        {
            return _expeditionDal.Get(e => e.OrderId == orderId);
        }

        public void Update(Expedition expedition)
        {
            try
            {
                //var validator = new ExpeditionValidator();
                //var context = new ValidationContext<Expedition>(expedition);
                //ValidationTool.Validate(validator, context);
                _expeditionDal.Update(expedition);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


    }
}
