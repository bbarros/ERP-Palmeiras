using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ERP_Palmeiras_LA.Models.Facade;
using ERP_Palmeiras_LA.Models;

namespace ERP_Palmeiras_LA.WebServices
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
        LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        [WebMethod]
        public bool EquipamentoPago(int idCompra)
        {
            try
            {
                CompraEquipamento ce = facade.BuscarCompraEquipamento(idCompra);
                ce.Status = StatusCompra.COMPRA_CONCLUIDA;
                ce.DataEntrega = DateTime.Now.Ticks;
                facade.AlterarCompraEquipamento(ce);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool MaterialPago(int idCompra)
        {
            try
            {
                CompraMaterial ce = facade.BuscarCompraMaterial(idCompra);
                ce.Status = StatusCompra.COMPRA_CONCLUIDA;
                ce.DataEntrega = DateTime.Now.Ticks;
                facade.AlterarCompraMaterial(ce);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool ManutencaoPaga(int idSolicitacao)
        {
            try
            {
                SolicitacaoManutencao se = facade.BuscarManutencao(idSolicitacao);
                se.Status = StatusSolicitacaoManutencao.PAGA;
                se.DataTerminoManutencao = DateTime.Now.Ticks;
                facade.AlterarManutencao(se);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
