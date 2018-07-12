using System.Web.Http;
using Unity;
using Unity.WebApi;

using AppLibrary.ViewModels;
using SerkoTestWebApi.Models.Inteface;
using SerkoTestWebApi.Models.Repositories;

namespace SerkoTestWebApi
{

    /// <summary>
    /// 12.07.2018
    /// </summary>
    public static class UnityConfig
    {

        /// <summary>
        /// 12.07.2018
        /// </summary>
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // Register repositories for client use.
            container.RegisterType<IRepository<VendorReservationVM>, VendorReservationRepository>();
            container.RegisterType<IRepository<ExpenseClaimVM>, ExpenseClaimRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}