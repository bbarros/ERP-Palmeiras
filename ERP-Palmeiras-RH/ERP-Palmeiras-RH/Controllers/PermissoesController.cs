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
    public class PermissoesController : Controller
    {
        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Permissao> permissoes = facade.BuscarPermissoes();
            ViewBag.permissoes = permissoes;
            return View();
        }

        public ActionResult Criar(String nome)
        {
            if (nome != null)
            {
                Permissao perm = new Permissao();
                perm.Nome = nome;
                facade.InserirPermissao(perm);
                return RedirectToAction("Index");
            }

            return View();

        }

        public ActionResult Excluir(Int32 pid)
        {
            facade.ExcluirPermissao(pid);
            return RedirectToAction("Index");
        }

    }
}
