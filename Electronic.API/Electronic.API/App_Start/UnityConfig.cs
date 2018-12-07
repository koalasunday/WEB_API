using Electronic.BussinessLogic.Service;
using Electronic.BussinessLogic.Service.Master;
using Electronic.Common.Repository;
using Electronic.Common.Repository.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Electronic.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IItemService, ItemService>();
            container.RegisterType<IItemRepository, ItemRepository>();

            container.RegisterType<ITransactionService, TransactionService>();
            container.RegisterType<ITransactionRepository, TransactionRepository>();

            container.RegisterType<IDetailTransactionService, DetailTransactionService>();
            container.RegisterType<IDetailTransactionRepository, DetailTransactionRepository>();

            container.RegisterType<ISupplierRepository, SupplierRepository>();
            container.RegisterType<ISupplierService, SupplierService>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}