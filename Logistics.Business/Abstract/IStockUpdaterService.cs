using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Abstract
{
    public interface IStockUpdaterService
    {
        bool UpdateStockQuantityAfterShipmentToDepot(int productId, int depotId, int increaseAmount);
        bool UpdateStockQuantityAfterReceivingProductFromDepot(int depotId, int quantity);
        bool SendReceivedProductsToOurOwnDepot(int depotId, int quantity);
    }
}
