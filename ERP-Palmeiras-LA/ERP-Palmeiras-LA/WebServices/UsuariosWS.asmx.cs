using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ERP_Palmeiras_LA.Models.Facade;
using ERP_Palmeiras_LA.Models;
using ERP_Palmeiras_LA.Core;

namespace ERP_Palmeiras_LA.WebServices
{
    /// <summary>
    /// Summary description for UsuariosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UsuariosWS : System.Web.Services.WebService
    {

        LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        [WebMethod]
        public Boolean InserirUsuario(String login, String senha)
        {
            try
            {
                IEnumerable<Usuario> users = facade.BuscarUsuarios();
                IEnumerable<Usuario> result = users.Where<Usuario>(u => u.Login == login);
                if (result == null || result.Count<Usuario>() == 0)
                    facade.CriarUsuario(new Usuario { Login = login, Senha = senha });
                facade.CriarUsuario(new Usuario { Login = login, Senha = senha });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public Boolean AlterarUsuario(String loginNovo, String loginAntigo, String senhaNova)
        {
            try
            {
                Usuario u = facade.BuscarUsuario(loginAntigo);
                facade.AlterarUsuario(u.Id, loginNovo, senhaNova);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
