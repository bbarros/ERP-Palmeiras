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
    /// Summary description for EquipamentosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EquipamentosWS : System.Web.Services.WebService
    {

        LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        [WebMethod]
        public void ReportarEquipamentoDefeituoso(int equipamentoId)
        {
            EquipamentoClinica ec = facade.BuscarEquipamentoClinica(equipamentoId);
            if(ec.Status == StatusEquipamento.FUNCIONANDO)
            {
                ec.Status = StatusEquipamento.QUEBRADO;
                // TODO: Criar Pendencia de Manutencao
                facade.AlterarEquipamentoClinica(ec);
            }
        }

        [WebMethod]
        public List<EquipamentoClinicaDTO> BuscarEquipamentos()
        {
            IEnumerable<EquipamentoClinica> eqs = facade.BuscarEquipamentosClinica();
            List<EquipamentoClinicaDTO> list = new List<EquipamentoClinicaDTO>();
            foreach (EquipamentoClinica ec in eqs)
            {
                list.Add(new EquipamentoClinicaDTO(ec.Equipamento.Nome, 
                    ec.Status == StatusEquipamento.FUNCIONANDO? "Funcionando" : "Quebrado",
                    ec.Id,
                    ec.Equipamento.Fabricante.Nome,
                    ec.Equipamento.NumeroSerie));
            }
            return list;
        }
    }
}
