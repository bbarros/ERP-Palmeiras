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
    public class BeneficiosController : Controller
    {
        private BeneficiosFacade facade = BeneficiosFacade.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Beneficio> beneficios = facade.BuscarBeneficios();
            ViewBag.beneficios = beneficios;
            return View();
        }

        public ActionResult Criar(String nome, String valor)
        {
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(valor))
            {
                Beneficio b = new Beneficio();
                b.Nome = nome;
                b.Valor = Double.Parse(valor);
                facade.InserirBeneficio(b);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult ExcluirBeneficio(Int32 bid)
        {
            facade.ExcluirBeneficio(bid);
            return RedirectToAction("Index");
        }
    }
}
