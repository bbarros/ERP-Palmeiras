using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ERP_Palmeiras_BI.Models.Facade;
using ERP_Palmeiras_BI.Models;

namespace ERP_Palmeiras_BI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BusinessIntelligence facade = BusinessIntelligence.GetInstance();
            Usuario u = facade.BuscarUsuario("admin-bi");
            if (u == null)
            {
                u = new Usuario();
                u.Login = "admin-bi";
                u.Senha = "admin";
                facade.CriarUsuario(u, false);
            }
        }
    }
}