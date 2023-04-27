using Logistics.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Concrete
{
        public class StockUpdaterManager: IStockUpdaterService
        {
            private readonly IDepotService _depotService;
            private readonly IProductService _productService;

            public StockUpdaterManager(IDepotService depotService, IProductService productService)
            {
                _depotService = depotService;
                _productService = productService;
            }

            public bool UpdateStockQuantityAfterShipmentToDepot(int productId, int depotId, int increaseAmount)
            {
                var depot = _depotService.GetByProductId(productId);

                if (depot != null)
                {
                    int currentProductStock = _productService.GetCurrentStock(productId);
                    int currentDepotStock = _depotService.GetCurrentStock(depotId);

                    if (currentProductStock >= increaseAmount)
                    {
                        currentDepotStock += increaseAmount;
                        currentProductStock -= increaseAmount;

                        _depotService.UpdateStockQuantity(depotId, currentDepotStock);
                        _productService.UpdateStockQuantity(productId, currentProductStock);

                        return true;
                    }
                }

                return false;
            }
            public bool UpdateStockQuantityAfterReceivingProductFromDepot(int depotId, int increaseAmount)
            {

                int currentStock = _depotService.GetCurrentStock(depotId);

                if (currentStock - increaseAmount > 0)
                {
                    currentStock -= increaseAmount;
                    _depotService.UpdateStockQuantity(depotId, currentStock);
                    return true;
                }
                return false;             
            }

             public bool SendReceivedProductsToOurOwnDepot(int depotId, int quantity)
             {
                 int currentOwnStock = _depotService.GetCurrentStock(depotId);

                 currentOwnStock += quantity;

                 _depotService.UpdateStockQuantity(depotId, currentOwnStock);

                  return true;
             }




    }
}



        


