using Logistics.Business.Abstract;
using Logistics.Business.Concrete;
using Logistics.DataAccess.Abstract;
using Logistics.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Logistics.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        // Ninject ioc container
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); // InSingletonScope() use for when a person produces an object, gives the same object to everyone
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<IFactoryDetailService>().To<FactoryDetailManager>().InSingletonScope();
            Bind<IFactoryDetailDal>().To<EfFactoryDetailDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IFactoryService>().To<FactoryManager>().InSingletonScope();
            Bind<IFactoryDal>().To<EfFactoryDal>().InSingletonScope();

            Bind<IDepotService>().To<DepotManager>().InSingletonScope();
            Bind<IDepotDal>().To<EfDepotDal>().InSingletonScope();

            Bind<IStockUpdaterService>().To<StockUpdaterManager>().InSingletonScope();

            Bind<ICustomerSupplierService>().To<CustomerSupplierManager>().InSingletonScope();
            Bind<ICustomerSupplierDal>().To<EfCustomerSupplierDal>().InSingletonScope();

            Bind<IOrderService>().To<OrderManager>().InSingletonScope();
            Bind<IOrderDal>().To<EfOrderDal>().InSingletonScope();
                        
            Bind<IStatusDetailService>().To<StatusDetailManager>().InSingletonScope();
            Bind<IStatusDetailDal>().To<EfStatusDetailDal>().InSingletonScope();

            Bind<IExpeditionService>().To<ExpeditionManager>().InSingletonScope();
            Bind<IExpeditionDal>().To<EfExpeditionDal>().InSingletonScope();

        }
    }
}
