using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ERP_Palmeiras_RH.Controllers
{
    /// <summary>
    /// Controller para Actions de Cadastro de Funcionarios.
    /// </summary>
    public class FuncionariosController : BaseController
    {

        /// <summary>
        /// Exibe a lista dos funcionários.
        /// </summary>
        public ActionResult Index()
        {
            return View();   
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Cadastrar(String strNome, String strSobrenome, 
            String strSexo, DateTime dtDataNascimento, String strEmail,
            String strRua, int strNumero, String strComplemento, String strBairro,
            String strCep, String strCidade, String strEstado, String strPais, long lgCpf, long lgRg,
            String strCrm, String strFormacao)
        {
            return View();
        }
    }
}
