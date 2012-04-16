using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_BI.Models;
using ERP_Palmeiras_BI.Models.Facade;
using ERP_Palmeiras_BI.Core;

namespace ERP_Palmeiras_BI.Controllers
{
    public class RelatoriosController : BaseController
    {
        private BusinessIntelligence facade = BusinessIntelligence.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Relatorio> relatorios = facade.BuscarRelatorios();
            if (relatorios == null)
                relatorios = new List<Relatorio>();
            ViewBag.relatorios = relatorios;
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(String titulo, TipoRelatorio tipo, DateTime dataInicio, DateTime dataFim)
        {
            if (!String.IsNullOrEmpty(titulo))
            {
                GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();
                String fileName = "RLT" + DateTime.Now.Ticks.ToString() + ".png";
                String imgUrl = Url.Content(BusinessIntelligence.GRAPHICS_PATH + fileName);
                Relatorio r = facade.CriarRelatorio(tipo, dataInicio, dataFim, titulo, sessao.Usuario, imgUrl, fileName);
                return RedirectToAction("Visualizar", new { id = r.Id });
            }
            else
                throw new ERPException("Título inválido.");
        }

        public ActionResult Editar(int id)
        {
            Relatorio r = facade.BuscarRelatorio(id);
            return View(r);
        }

        public ActionResult Visualizar(int id)
        {
            Relatorio r = facade.BuscarRelatorio(id);
            return View(r);
        }

        [HttpPost]
        public ActionResult Alterar(int id, String titulo, TipoRelatorio tipo, DateTime dataInicio, DateTime dataFim)
        {
            if (!String.IsNullOrEmpty(titulo))
            {
                GerenciadorDeSessao sessao = GerenciadorDeSessao.GetInstance();
                String fileName = "RLT" + DateTime.Now.Ticks.ToString() + ".png";
                String imgUrl = Url.Content(BusinessIntelligence.GRAPHICS_PATH + fileName);
                facade.AlterarRelatorio(id, tipo, dataInicio, dataFim, titulo, sessao.Usuario, imgUrl, fileName);
                return RedirectToAction("Index");
            }
            else
                throw new ERPException("Título inválido.");
        }
    }
}
