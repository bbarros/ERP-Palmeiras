using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
//using ERP_Palmeiras_BI.Models;

namespace ERP_Palmeiras_BI.Controllers
{
    [HandleERPException]
    public class BaseController : Controller
    {
        public BaseController() : base()
        {
            GerenciadorDeSessao gerenciadorSessao = GerenciadorDeSessao.GetInstance();
            if (gerenciadorSessao.SessaoAtiva)
            {
                ViewData["WelcomeMsg"] = "Sr.";
                //ViewData["Usuario.Nome"] = gerenciadorSessao.Usuario.Login;
            }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            // A página de erro não precisa de roles (durr)..
            if (filterContext.RouteData.Values["action"].Equals("Error"))
            {
                base.OnActionExecuting(filterContext);
                return;
            }

            // Se não houver sessão ativa, não abre a View
            GerenciadorDeSessao gerenciadorSessao = GerenciadorDeSessao.GetInstance();
            if (!gerenciadorSessao.SessaoAtiva && filterContext.ActionDescriptor.ControllerDescriptor.ControllerName != "Home")
            {
                filterContext.Result = RedirectToAction("Index", "Home");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
