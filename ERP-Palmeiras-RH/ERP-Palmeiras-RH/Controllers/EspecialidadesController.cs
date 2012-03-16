using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;

namespace ERP_Palmeiras_RH.Controllers
{
    public class EspecialidadesController : Controller
    {
        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Especialidade> especialidades = facade.BuscarEspecialidades();
            ViewBag.especialidades = especialidades;
            return View();
        }

        public ActionResult Criar(String nome)
        {
            if (nome != null)
            {
                Especialidade espec = new Especialidade();
                espec.Nome = nome;
                facade.InserirEspecialidade(espec);

                return RedirectToAction("Index");
            }

            return View();

        }

    }
}
