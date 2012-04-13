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

        public ActionResult Criar()
        {
            IEnumerable<Fabricante> fabricantes = facade.BuscarFabricantes();
            ViewBag.fabricantes = fabricantes;

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(String codigo, String nome, Int32 fabricante, String descricao)
        {
            if (!String.IsNullOrEmpty(codigo))
            {
                Material material = new Material();
                material.Codigo = codigo;
                material.Nome = nome;
                material.FabricanteId = fabricante;
                material.Descricao = descricao;

                facade.InserirMaterial(material);

                return RedirectToAction("Index");
            }

            IEnumerable<Fabricante> fabricantes = facade.BuscarFabricantes();
            ViewBag.fabricantes = fabricantes;

            return RedirectToAction("Criar");
        }

        public ActionResult Editar(Int32 materialID)
        {
            IEnumerable<Fabricante> fabricantes = facade.BuscarFabricantes();
            Material mat = facade.BuscarMaterial(materialID);
            ViewBag.fabricantes = fabricantes;
            ViewBag.mat = mat;
            return View();
        }

        [HttpPost]
        public ActionResult Alterar(Int32 materialID, String codigo, String nome, String descricao, Int32 fabricante)
        {
            Material mat = facade.BuscarMaterial(materialID);
            mat.Codigo = codigo;
            mat.Nome = nome;
            mat.Descricao = descricao;
            mat.FabricanteId = fabricante;
            facade.AlterarMaterial(mat);
            return RedirectToAction("Index");
        }
    }
}
