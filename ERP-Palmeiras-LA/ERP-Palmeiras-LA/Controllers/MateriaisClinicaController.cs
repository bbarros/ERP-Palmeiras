using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_LA.Models;
using ERP_Palmeiras_LA.Models.Facade;
using ERP_Palmeiras_LA.Core;

namespace ERP_Palmeiras_LA.Controllers
{
    public class MateriaisClinicaController : BaseController
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<MaterialClinica> materiais = facade.BuscarMateriaisClinica();
            if (materiais == null)
                materiais = new List<MaterialClinica>();
            ViewBag.materiais = materiais;
            return View();
        }

        public ActionResult Excluir(int id)
        {
            facade.ExcluirMaterialClinica(id);
            return RedirectToAction("Index");
        }
    }
}
