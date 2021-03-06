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
    public class CompraMateriaisController : BaseController
    {
        private LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<CompraMaterial> compras = facade.BuscarComprasMaterial();
            if (compras == null)
                compras = new List<CompraMaterial>();
            ViewBag.compras = compras;
            return View();
        }

        public ActionResult Solicitadas()
        {
            IEnumerable<CompraMaterial> compras = facade.BuscarComprasMaterial(StatusCompra.COMPRA_SOLICITADA);
            if (compras == null)
                compras = new List<CompraMaterial>();
            ViewBag.compras = compras;
            return View("Index");
        }

        public ActionResult EmErro()
        {
            IEnumerable<CompraMaterial> compras = facade.BuscarComprasMaterial(StatusCompra.ERRO_ORDEM_COMPRA);
            if (compras == null)
                compras = new List<CompraMaterial>();
            ViewBag.compras = compras;
            return View("Index");
        }

        public ActionResult Entregas()
        {
            IEnumerable<CompraMaterial> compras = facade.BuscarComprasMaterial(StatusCompra.ENTREGUE);
            if (compras == null)
                compras = new List<CompraMaterial>();
            ViewBag.compras = compras;
            return View("Index");
        }

        public ActionResult RegistrarEntrega(int id)
        {
            CompraMaterial c = facade.BuscarCompraMaterial(id);
            c.DataEntrega = DateTime.Now.Ticks;
            c.Status = StatusCompra.ENTREGUE;
            facade.AlterarCompraMaterial(c);
            Material m = c.SolicitacaoCompraMaterial.Material;
            m.QuantidadeEstoque += c.SolicitacaoCompraMaterial.Quantidade;
            facade.AlterarMaterial(m);
            return RedirectToAction("Entregas");
        }

        public ActionResult Editar(int id)
        {
            CompraMaterial c = facade.BuscarCompraMaterial(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Alterar(int id, DateTime dataPrevista)
        {
            CompraMaterial c = facade.BuscarCompraMaterial(id);
            c.DataPrevista = dataPrevista.Ticks;
            facade.AlterarCompraMaterial(c);
            return View();
        }

        public ActionResult RefazerCompra(int id)
        {
            CompraMaterial ce = facade.BuscarCompraMaterial(id);
            facade.SolicitarCompra(ce);
            if(ce.Status == StatusCompra.ERRO_ORDEM_COMPRA)
                return RedirectToAction("EmErro");
            return RedirectToAction("Solicitadas");
        }
    }
}
