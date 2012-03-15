using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Models;

namespace ERP_Palmeiras_RH.Controllers
{
    public class BeneficiosController : Controller
    {
        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        public ActionResult Index()
        {
            return View();
        }

        public Beneficio CadastrarBeneficio(String nome, double valor)
        {
            Beneficio b = new Beneficio();
            b.Nome = nome;
            b.Valor = valor;

            return b;
        }
    }
}
