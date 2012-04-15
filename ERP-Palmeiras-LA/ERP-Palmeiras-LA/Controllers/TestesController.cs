using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_LA.Models;
using ERP_Palmeiras_LA.Models.Facade;

namespace ERP_Palmeiras_LA.Controllers
{
    public class TestesController : BaseController
    {
        //
        // GET: /Testes/

        LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult CriarCenario()
        {
            // verifica se o cenário ja foi criado..
            IEnumerable<Fabricante> ff1 = facade.BuscarFabricantes();
            if (ff1 == null || ff1.Count<Fabricante>() > 0)
                return RedirectToAction("Welcome", "Home");

            Fabricante f1 = new Fabricante();
            f1.Agencia = "222-2";
            f1.Banco = 210;
            f1.CNPJ = "111.111.111-11";
            f1.ContaCorrente = "1010-1";
            f1.Nome = "Jonas Equipamentos";

            facade.CriarFabricante(f1);

            Fabricante f2 = new Fabricante();
            f2.Agencia = "333-3";
            f2.Banco = 210;
            f2.CNPJ = "333.333.333-33";
            f2.ContaCorrente = "2020-2";
            f2.Nome = "Jonas Materiais";

            facade.CriarFabricante(f2);

            Material m1 = new Material();
            m1.Codigo = "M-001";
            m1.Descricao = "Luva Cirúrgica de Látex";
            m1.Nome = "Luva Cirúrgica";
            m1.QuantidadeEstoque = 100;
            m1.FabricanteId = f2.Id;
            facade.InserirMaterial(m1);

            Material m2 = new Material();
            m2.Codigo = "M-002";
            m2.Descricao = "Pinça Descartável";
            m2.Nome = "Pinça cirúrgica descartável de alumínio";
            m2.QuantidadeEstoque = 50;
            m2.FabricanteId = f2.Id;

            facade.InserirMaterial(m2);

            Equipamento e1 = new Equipamento();
            e1.Nome = "Máquina de Raio-X";
            e1.NumeroSerie = "E-001";
            e1.Descricao = "Máquina de Raio-X";
            e1.FabricanteId = f1.Id;
            facade.CriarEquipamento(e1);

            Equipamento e2 = new Equipamento();
            e2.Nome = "Máquina de Ultrassom";
            e2.NumeroSerie = "E-002";
            e2.Descricao = "Máquina de Ultrassom";
            e2.FabricanteId = f1.Id;
            facade.CriarEquipamento(e2);

            return RedirectToAction("Welcome", "Home");
        }

    }
}
