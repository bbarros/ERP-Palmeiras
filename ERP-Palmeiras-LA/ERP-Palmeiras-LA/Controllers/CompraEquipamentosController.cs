﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_LA.Models;
using ERP_Palmeiras_LA.Models.Facade;
using ERP_Palmeiras_LA.Core;

namespace ERP_Palmeiras_LA.Controllers
{
    public class CompraEquipamentosController : BaseController
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<CompraEquipamento> compras = facade.BuscarComprasEquipamento();
            if (compras == null)
                compras = new List<CompraEquipamento>();
            ViewBag.compras = compras;
            return View();
        }

        public ActionResult Solicitadas()
        {
            IEnumerable<CompraEquipamento> compras = facade.BuscarComprasEquipamento(StatusCompra.COMPRA_SOLICITADA);
            if (compras == null)
                compras = new List<CompraEquipamento>();
            ViewBag.compras = compras;
            return View("Index");
        }

        public ActionResult Entregas()
        {
            IEnumerable<CompraEquipamento> compras = facade.BuscarComprasEquipamento(StatusCompra.ENTREGUE);
            if (compras == null)
                compras = new List<CompraEquipamento>();
            ViewBag.compras = compras;
            return View("Index");
        }

        public ActionResult RegistrarEntrega(int id)
        {
            CompraEquipamento c = facade.BuscarCompraEquipamento(id);
            c.DataEntrega = DateTime.Now.Ticks;
            c.Status = StatusCompra.ENTREGUE;
            facade.AlterarCompraEquipamento(c);
            facade.CriarEquipamentoClinica(c.SolicitacaoCompraEquipamento.Equipamento);
            return RedirectToAction("Entregas");
        }

        public ActionResult Editar(int id)
        {
            CompraEquipamento c = facade.BuscarCompraEquipamento(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Alterar(int id, DateTime dataPrevista)
        {
            CompraEquipamento c = facade.BuscarCompraEquipamento(id);
            c.DataPrevista = dataPrevista.Ticks;
            facade.AlterarCompraEquipamento(c);
            return View();
        }
    }
}
