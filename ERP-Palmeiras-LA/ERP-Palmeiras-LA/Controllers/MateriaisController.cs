using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_LA.Models;
using ERP_Palmeiras_LA.Models.Facade;

namespace ERP_Palmeiras_LA.Controllers
{
    public class MateriaisController : Controller
    {
        //
        // GET: /Materiais/
        LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Material> materiais = facade.BuscarMateriais();
            IEnumerable<Fabricante> fabricantes = facade.BuscarFabricantes();
            
            ViewBag.materiais = materiais;
            ViewBag.fabricantes = fabricantes;
            return View();
        }

        public ActionResult Criar(String codigo, String nome, Fabricante fabricante, String descricao)
        {
            if (codigo != null)
            {
                Material material = new Material();
                material.Codigo = codigo;
                material.Nome = nome;
                material.Fabricante = fabricante;
                material.Descricao = descricao;

                facade.InserirMaterial(material);

                return RedirectToAction("Index");
            }

            IEnumerable<Fabricante> fabricantes = facade.BuscarFabricantes();
            ViewBag.fabricantes = fabricantes;

            return View();
        }
    }
}
