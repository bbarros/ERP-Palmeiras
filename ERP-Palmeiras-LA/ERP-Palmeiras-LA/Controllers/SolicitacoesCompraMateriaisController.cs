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
    public class SolicitacoesCompraMateriaisController : BaseController
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<SolicitacaoCompraMaterial> solicitacoes = facade.BuscarSolicitacoesCompraMateriais();
            if (solicitacoes == null)
                solicitacoes = new List<SolicitacaoCompraMaterial>();
            ViewBag.solicitacoes = solicitacoes;
            return View();
        }

        public ActionResult Pendencias()
        {
            IEnumerable<SolicitacaoCompraMaterial> solicitacoes = facade.BuscarSolicitacoesCompraMateriais(StatusSolicitacaoCompra.PENDENTE);
            if (solicitacoes == null)
                solicitacoes = new List<SolicitacaoCompraMaterial>();
            ViewBag.solicitacoes = solicitacoes;
            return View("Index");
        }

        public ActionResult Aprovadas()
        {
            IEnumerable<SolicitacaoCompraMaterial> solicitacoes = facade.BuscarSolicitacoesCompraMateriais(StatusSolicitacaoCompra.APROVADO);
            if (solicitacoes == null)
                solicitacoes = new List<SolicitacaoCompraMaterial>();
            ViewBag.solicitacoes = solicitacoes;
            return View("Index");
        }

        public ActionResult Reprovadas()
        {
            IEnumerable<SolicitacaoCompraMaterial> solicitacoes = facade.BuscarSolicitacoesCompraMateriais(StatusSolicitacaoCompra.REPROVADO);
            if (solicitacoes == null)
                solicitacoes = new List<SolicitacaoCompraMaterial>();
            ViewBag.solicitacoes = solicitacoes;
            return View("Index");
        }

        public ActionResult Criar()
        {
            ViewData["Materiais"] = facade.BuscarEquipamentos();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(DateTime data, double preco, int materialId, int quantidade)
        {
            SolicitacaoCompraMaterial s = new SolicitacaoCompraMaterial();
            s.Status = StatusSolicitacaoCompra.PENDENTE;
            s.PrecoUnitario = preco;
            s.MaterialId = materialId;
            s.DataValidade = data.Ticks;
            s.UsuarioId = GerenciadorDeSessao.GetInstance().Usuario.Id;
            facade.CriarSolicitacaoCompraMaterial(s);
            return View();
        }

        public ActionResult Editar(int id)
        {
            SolicitacaoCompraMaterial s = facade.BuscarSolicitacaoCompraMaterial(id);
            ViewData["Materiais"] = facade.BuscarMateriais();
            return View(s);
        }

        [HttpPost]
        public ActionResult Alterar(int id, DateTime data, double preco, int materialId, int quantidade)
        {
            SolicitacaoCompraMaterial s = facade.BuscarSolicitacaoCompraMaterial(id);
            s.DataValidade = data.Ticks;
            s.PrecoUnitario = preco;
            s.Quantidade = quantidade;
            s.MaterialId = materialId;
            s.UsuarioId = GerenciadorDeSessao.GetInstance().Usuario.Id;
            facade.AlterarSolicitacaoCompraMaterial(s);
            return View();
        }

        public ActionResult Rejeitar(int id)
        {
            SolicitacaoCompraMaterial s = facade.BuscarSolicitacaoCompraMaterial(id);
            s.Status = StatusSolicitacaoCompra.REPROVADO;
            return RedirectToAction("Reprovadas");
        }

        public ActionResult Aprovar(int id)
        {
            SolicitacaoCompraMaterial s = facade.BuscarSolicitacaoCompraMaterial(id);
            s.Status = StatusSolicitacaoCompra.APROVADO;
            facade.AlterarSolicitacaoCompraMaterial(s);
            facade.CriarCompraMaterial(s, new DateTime(s.DataValidade));
            return RedirectToAction("Aprovadas");
        }
    }
}
