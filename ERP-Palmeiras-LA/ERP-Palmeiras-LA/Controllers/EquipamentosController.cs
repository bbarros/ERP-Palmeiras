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
    public class EquipamentosController : BaseController
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

        public ActionResult IndexManutencao()
        {
            IEnumerable<SolicitacaoManutencao> solicitacoes = facade.BuscarManutencao();

            if (solicitacoes == null)
                solicitacoes = new List<SolicitacaoManutencao>();
            ViewBag.solicitacoes = solicitacoes;

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
            Equipamento eq = facade.BuscarEquipamento(id);
            eq.Nome = nome;
            eq.NumeroSerie = nserie;
            eq.Descricao = descricao;
            eq.FabricanteId = fabricanteId;
            facade.AlterarEquipamento(eq);
            return View();
        }

        public ActionResult SolicitarManutencao()
        {

            IEnumerable<EquipamentoClinica> equipamentosClinica = facade.BuscarEquipamentosClinica();
            GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();
            if (equipamentosClinica == null)
                equipamentosClinica = new List<EquipamentoClinica>();
            ViewBag.equipamentos = equipamentosClinica;        
            ViewBag.usuario = sessao.Usuario.Login;
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
            solmanu.Status = StatusSolicitacaoManutencao.PENDENTE;

            facade.CriarManutencao(solmanu);

            return RedirectToAction("IndexManutencao");
        }

        public ActionResult RefazerPedido(int id)
        {
            SolicitacaoManutencao solmanu = facade.BuscarManutencao(id);
            facade.EnviarSolicitacaoManutencao(solmanu);
            return RedirectToAction("IndexManutencao");
        }

        public ActionResult EditarManutencao(int id)
        {
            SolicitacaoManutencao solmanu = facade.BuscarManutencao(id);
            IEnumerable<EquipamentoClinica> equipamentosClinica = facade.BuscarEquipamentosClinica();
            GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();
            if (equipamentosClinica == null)
                equipamentosClinica = new List<EquipamentoClinica>();
            
            ViewBag.equipamentos = equipamentosClinica;
            ViewBag.usuario = sessao.Usuario.Login;
            ViewBag.solmanu = solmanu;
            return View();
        }

        public ActionResult AlterarManutencao( int id, Int32 custo, DateTime dataprevista, String status, DateTime? dataentregue)
        {

            SolicitacaoManutencao solicitacao = facade.BuscarManutencao(id);

            //solicitacao.Custo = custo;
            solicitacao.DataPrevista = dataprevista.Ticks;
            if (status == "CONCLUIDA")
                solicitacao.Status = StatusSolicitacaoManutencao.CONCLUIDA;
            else if (status == "EM_PROGRESSO")
                solicitacao.Status = StatusSolicitacaoManutencao.EM_PROGRESSO;
            else if (status == "PENDENTE")
                solicitacao.Status = StatusSolicitacaoManutencao.PENDENTE;

            if ( dataentregue.HasValue )
                solicitacao.DataTerminoManutencao = dataentregue.Value.Ticks;
            facade.AlterarManutencao(solicitacao);

            return RedirectToAction("IndexManutencao");

        }

    }
}
