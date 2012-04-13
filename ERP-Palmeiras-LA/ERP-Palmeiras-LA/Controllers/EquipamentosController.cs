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
    public class EquipamentosController : Controller
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Equipamento> equipamentos = facade.BuscarEquipamentos();
            if (equipamentos == null)
                equipamentos = new List<Equipamento>();
            ViewBag.equipamentos = equipamentos;
            return View();
        }

        public ActionResult Criar()
        {
            ViewData["Fabricantes"] = facade.BuscarFabricantes();
            return View();
        }

        public ActionResult Cadastrar(String nome, String nserie, String descricao, int fabricanteId)
        {
            if (!String.IsNullOrEmpty(nserie))
            {
                Equipamento eq = new Equipamento();
                eq.Nome = nome;
                eq.NumeroSerie = nserie;
                eq.Descricao = descricao;
                eq.FabricanteId = fabricanteId;
                facade.CriarEquipamento(eq);

                return RedirectToAction("Index");
            }
            else
                throw new ERPException("Número de série inválido.");

        }

        public ActionResult Editar(int id)
        {
            ViewData["Fabricantes"] = facade.BuscarFabricantes();
            Equipamento eq = facade.BuscarEquipamento(id);
            return View(eq);
        }

        [HttpPost]
        public ActionResult Alterar(int id, String nome, String nserie, String descricao, int fabricanteId)
        {
            Equipamento eq = new Equipamento();
            eq.Nome = nome;
            eq.NumeroSerie = nserie;
            eq.Descricao = descricao;
            eq.FabricanteId = fabricanteId;
            eq.Id = id;
            facade.AlterarEquipamento(eq);
            return View();
        }

        public ActionResult SolicitarManutencao()
        {

            IEnumerable<Equipamento> equipamentos = facade.BuscarEquipamentos();
            if (equipamentos == null)
                equipamentos = new List<Equipamento>();
            ViewBag.equipamentos = equipamentos;
            return View();

        }

        public ActionResult CadastrarManutencao(Int32 equipamentoId, Int32 custo, DateTime dataprevista, String motivo )
        {

            SolicitacaoManutencao solmanu = new SolicitacaoManutencao();
           
            GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();

            solmanu.UsuarioId = sessao.Usuario.Id;
            solmanu.EquipamentoClinicaId = equipamentoId;
            solmanu.DataPrevista = dataprevista.Ticks;
            solmanu.Motivo = motivo;
            solmanu.Custo = custo;
            

            facade.CriarManutencao(solmanu);

            return View();
        }


    }
}
