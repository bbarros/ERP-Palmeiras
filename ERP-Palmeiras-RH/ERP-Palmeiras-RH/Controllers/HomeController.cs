﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Core;

namespace ERP_Palmeiras_RH.Controllers
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

            RecursosHumanos facadeRH = RecursosHumanos.GetInstance();

            sessao.Funcionario = facadeRH.AutenticaUsuario(usuario, senha);

            if (sessao.Funcionario == null)
            {
                ViewData["Message"] = "Usuário inválido!";
                return View("Error");
            }
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

        public ActionResult Error()
        {
            return View();
        }

    }
}
