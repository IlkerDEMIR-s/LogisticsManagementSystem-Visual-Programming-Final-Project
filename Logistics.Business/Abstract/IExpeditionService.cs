using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Abstract
{
    public interface IExpeditionService
    {
        List<Expedition> GetAll();
        List<Expedition> GetAllByFactoryId(int factoryId);
        List<Expedition> GetAllCompletedExpeditionsByFactoryId(int factoryId);
        void Add(Expedition expedition);
        void Update(Expedition expedition);
        Expedition GetExpeditionById(int expeditionId);
        Expedition GetExpeditionByOrderId(int orderId);
        List<Expedition> GetByDepotName(string searchKey, int factoryId);
        List<Expedition> GetByDateRange(DateTime startDate, DateTime endDate, int factoryId);
        int GetExpeditionStatusIdByOrderId(int orderId);
        DateTime GetExpeditionActualDepatureDateByOrderId(int orderId);
    }
}
