using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Models;

namespace ERP_Palmeiras_RH.WebServices
{
    /// <summary>
    /// Summary description for InfoPagamentoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InfoPagamentoWS : System.Web.Services.WebService
    {
        RecursosHumanos facade = RecursosHumanos.GetInstance();

        [WebMethod]
        public bool FuncionarioPago(int idPagamento)
        {
            try
            {
                Pagamento p = facade.GetPagamento(idPagamento);
                p.Status = RecursosHumanos.PAGAMENTO_OK;
                facade.UpdatePagamento(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
