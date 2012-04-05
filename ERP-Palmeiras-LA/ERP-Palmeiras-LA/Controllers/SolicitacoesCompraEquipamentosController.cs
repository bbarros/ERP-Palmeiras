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
    public class SolicitacoesCompraEquipamentosController : Controller
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<SolicitacaoCompraEquipamento> solicitacoes = facade.BuscarSolicitacoesCompraEquipamentos();
            if (solicitacoes == null)
                solicitacoes = new List<SolicitacaoCompraEquipamento>();
            ViewBag.solicitacoes = solicitacoes;
            return View();
        }

        public ActionResult Criar()
        {
            ViewData["Equipamentos"] = facade.BuscarEquipamentos();
            return View();
        }

        public ActionResult Cadastrar(DateTime data, double preco, int equipamentoId)
        {
            SolicitacaoCompraEquipamento s = new SolicitacaoCompraEquipamento();
            s.Status = StatusSolicitacaoCompra.PENDENTE;
            s.Preco = preco;
            s.EquipamentoId = equipamentoId;
            s.DataValidade = data.Ticks;
            facade.CriarSolicitacaoCompraEquipamento(s);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            SolicitacaoCompraEquipamento s = facade.BuscarSolicitacaoCompraEquipamento(id);
            ViewData["Equipamentos"] = facade.BuscarEquipamentos();
            return View(s);
        }

        [HttpPost]
        public ActionResult Alterar(int id, DateTime data, double preco, int equipamentoId, StatusSolicitacaoCompra status)
        {
            SolicitacaoCompraEquipamento s = facade.BuscarSolicitacaoCompraEquipamento(id);
            s.DataValidade = data.Ticks;
            s.Preco = preco;
            s.EquipamentoId = equipamentoId;
            s.Status = status;
            facade.AlterarSolicitacaoCompraEquipamento(s);
            return View();
        }
    }
}
