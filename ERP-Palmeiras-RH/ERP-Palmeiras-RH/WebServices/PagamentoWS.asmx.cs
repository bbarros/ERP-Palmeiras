using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Controllers;

namespace ERP_Palmeiras_RH.WebServices
{
    /// <summary>
    /// Summary description for PagamentoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PagamentoWS : System.Web.Services.WebService
    {

        [WebMethod]
        public bool InformarPagamento(Int32 pagamentoId)
        {
            RecursosHumanos facade = RecursosHumanos.GetInstance();
            Pagamento pag = facade.GetPagamento(pagamentoId);

            pag.Status = RecursosHumanos.PAGAMENTO_OK;
            
            facade.UpdatePagamento(pag);
            
            return true;
        }
    }
}
