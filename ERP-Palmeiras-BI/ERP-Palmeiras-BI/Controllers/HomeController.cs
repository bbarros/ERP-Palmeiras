﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_BI.Models;
using ERP_Palmeiras_BI.Core;
using ERP_Palmeiras_BI.Models.Facade;
using System.IO;

namespace ERP_Palmeiras_BI.Controllers
{
    [HandleERPException]
    public class HomeController : Controller
    {
        GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();

        /// <summary>
        /// Tela de login.
        /// </summary>
        public ActionResult Index()
        {
            String fileName = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/Graphics"), "RLT" + DateTime.Now.Ticks.ToString()) + ".png";
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
            BusinessIntelligence facade = BusinessIntelligence.GetInstance();
            Usuario u = facade.AutenticaUsuario(usuario, senha);
            sessao.Usuario = u;
            if (!sessao.SessaoAtiva)
            {
                ViewData["Message"] = "Usuário inválido!";
                return View("Error");
            }
            return View("Welcome");
        }

        /// <summary>
        /// Action de Logout.
        /// </summary>
        [HttpPost]
        public ActionResult Logout()
        {
            //sessao.Usuario = null;
            return View("Index");
        }

        /// <summary>
        /// Tela de boas vindas.
        /// </summary>
        public ActionResult Welcome()
        {
            if (!sessao.SessaoAtiva)
            {
                ViewData["Message"] = "É necessário se autenticar!";
                return View("Error");
            }
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

    }
}
