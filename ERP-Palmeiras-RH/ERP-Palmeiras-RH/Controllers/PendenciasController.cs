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
    public class PendenciasController : Controller
    {
        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Pendencia> pendencias = facade.BuscarPendencias();
            ViewBag.pendencias = pendencias;
            return View();
        }

        public ActionResult Excluir(int pid)
        {
            facade.ExcluirPendencia(pid);
            return RedirectToAction("Index");
        }
    }
}
