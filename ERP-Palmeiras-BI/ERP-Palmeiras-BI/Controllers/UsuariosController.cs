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
    public class UsuariosController : Controller
    {
        private BusinessIntelligence facade = BusinessIntelligence.GetInstance();

        public ActionResult Index()
        {
            IEnumerable<Usuario> usuarios = facade.BuscarUsuarios();
            if (usuarios == null)
                usuarios = new List<Usuario>();
            ViewBag.usuarios = usuarios;
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Cadastrar(String login, String password)
        {
            if (!String.IsNullOrEmpty(login))
            {
                Usuario user = new Usuario();
                user.Login = login;
                user.Senha = password;
                facade.CriarUsuario(user);

                return RedirectToAction("Index");
            }
            else
                throw new ERPException("Login inválido.");

        }

        public ActionResult Editar(int id)
        {
            Usuario u = facade.BuscarUsuario(id);
            return View(u);
        }

        [HttpPost]
        public ActionResult Alterar(int id, String login, String password)
        {
            facade.AlterarUsuario(id, login, password);
            return View();
        }
    }
}
