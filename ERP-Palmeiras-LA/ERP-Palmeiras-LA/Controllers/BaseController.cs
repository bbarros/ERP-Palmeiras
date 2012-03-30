using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ERP_Palmeiras_LA.Models;

namespace ERP_Palmeiras_LA.Controllers
{
    [HandleERPException]
    public class BaseController : Controller
    {
        public BaseController() : base()
        {
            GerenciadorDeSessao gerenciadorSessao = GerenciadorDeSessao.GetInstance();
            if (gerenciadorSessao.SessaoAtiva)
            {
                //String sexoStr = gerenciadorSessao.Funcionario.DadosPessoais.Sexo.ToLower().Equals("feminino") ? "a" : String.Empty;
                //ViewData["WelcomeMsg"] = (gerenciadorSessao.Funcionario is Medico) ? "Dr" + sexoStr + "." : "Sr" + sexoStr + ".";
                //ViewData["Funcionario.Nome"] = gerenciadorSessao.Funcionario.DadosPessoais.Nome;
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
