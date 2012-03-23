using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;

namespace ERP_Palmeiras_RH.Controllers
{
    [HandleERPException]
    public class CargosController : Controller
    {
        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Cargo> Cargos = facade.BuscarCargos();
            ViewBag.Cargos = Cargos;
            return View();
        }

        public ActionResult Criar(String nome, String salarioBase)
        {
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(salarioBase))
            {
                Cargo c = new Cargo();
                c.Nome = nome;
                c.SalarioBase = Double.Parse(salarioBase);
                facade.InserirCargo(c);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult ExcluirCargo(Int32 cid)
        {
            facade.ExcluirCargo(cid);
            return RedirectToAction("Index");
        }
    }
}
