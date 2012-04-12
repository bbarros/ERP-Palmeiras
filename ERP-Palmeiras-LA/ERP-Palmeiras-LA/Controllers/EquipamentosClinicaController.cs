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
    public class EquipamentosClinicaController : BaseController
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<EquipamentoClinica> equipamentos = facade.BuscarEquipamentosClinica();
            if (equipamentos == null)
                equipamentos = new List<EquipamentoClinica>();
            ViewBag.equipamentos = equipamentos;
            return View();
        }

        public ActionResult Quebrados()
        {
            IEnumerable<EquipamentoClinica> equipamentos = facade.BuscarEquipamentosClinica(StatusEquipamento.QUEBRADO);
            if (equipamentos == null)
                equipamentos = new List<EquipamentoClinica>();
            ViewBag.equipamentos = equipamentos;
            return View("Index");
        }

        public ActionResult Funcionando()
        {
            IEnumerable<EquipamentoClinica> equipamentos = facade.BuscarEquipamentosClinica(StatusEquipamento.FUNCIONANDO);
            if (equipamentos == null)
                equipamentos = new List<EquipamentoClinica>();
            ViewBag.equipamentos = equipamentos;
            return View("Index");
        }

        public ActionResult RegistrarDefeito(int id)
        {
            EquipamentoClinica eq = facade.BuscarEquipamentoClinica(id);
            if (eq.Status == StatusEquipamento.FUNCIONANDO)
            {
                eq.Status = StatusEquipamento.QUEBRADO;
                facade.AlterarEquipamentoClinica(eq);
                // TODO: Criar Pendencia de Manutencao!!
            }
            return RedirectToAction("Quebrados");
        }

        public ActionResult Excluir(int id)
        {
            facade.ExcluirEquipamentoClinica(id);
            return RedirectToAction("Index");
        }
    }
}
