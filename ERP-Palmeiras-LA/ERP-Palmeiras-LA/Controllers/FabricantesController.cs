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
    public class FabricantesController : BaseController
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Fabricante> fabricantes = facade.BuscarFabricantes();
            if (fabricantes == null)
                fabricantes = new List<Fabricante>();
            ViewBag.fabricantes = fabricantes;
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Cadastrar(String nome, String cnpj, int banco, String agencia, String contaCorrente)
        {
            if (!String.IsNullOrEmpty(cnpj))
            {
                Fabricante f = new Fabricante();
                f.Nome = nome;
                f.CNPJ = cnpj;
                f.Banco = banco;
                f.Agencia = agencia;
                f.ContaCorrente = contaCorrente;
                facade.CriarFabricante(f);

                return RedirectToAction("Index");
            }
            else
                throw new ERPException("CNPJ inválido.");
        }

        public ActionResult Editar(int id)
        {
            Fabricante f = facade.BuscarFabricante(id);
            return View(f);
        }

        [HttpPost]
        public ActionResult Alterar(int id, String nome, String cnpj, int banco, String agencia, String contaCorrente)
        {
            Fabricante f = facade.BuscarFabricante(id);
            f.Nome = nome;
            f.CNPJ = cnpj;
            f.Banco = banco;
            f.Agencia = agencia;
            f.ContaCorrente = contaCorrente;
            facade.AlterarFabricante(f);
            return View();
        }
    }
}
