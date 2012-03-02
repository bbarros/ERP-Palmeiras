using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models;

namespace ERP_Palmeiras_RH.Controllers
{
    public class HomeController : Controller
    {
        GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();

        /// <summary>
        /// Tela de login.
        /// </summary>
        public ActionResult Index()
        {
            if (sessao.SessaoAtiva)
                return View("Welcome");
            return View();
        }

        /// <summary>
        /// Action de autenticacao.
        /// Aceita Post Requests.
        /// </summary>
        [HttpPost]
        public ActionResult Login(String usuario, String senha)
        {
            return View("Welcome");
        }

        /// <summary>
        /// Action de Logout.
        /// </summary>
        public ActionResult Logout()
        {
            sessao.Funcionario = null;
            return View("Index");
        }

        /// <summary>
        /// Tela de boas vindas.
        /// </summary>
        public ActionResult Welcome()
        {
            return View();
        }

    }
}
