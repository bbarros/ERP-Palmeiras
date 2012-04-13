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
    /// Summary description for MateriaisWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MateriaisWS : System.Web.Services.WebService
    {
        LogisticaAbastecimento facade = LogisticaAbastecimento.GetInstance();

        [WebMethod]
        public List<MaterialClinicaDTO> BuscarMateriais()
        {
            List<MaterialClinicaDTO> dtos = new List<MaterialClinicaDTO>();
            IEnumerable<Material> mats = facade.BuscarMateriais();
            foreach (Material mat in mats)
            {
                MaterialClinicaDTO dto = new MaterialClinicaDTO(
                    mat.Nome,
                    mat.Id,
                    mat.Fabricante.Nome,
                    mat.Codigo,
                    mat.Descricao,
                    mat.QuantidadeEstoque);
                dtos.Add(dto);
            }
            return dtos;
        }

        [WebMethod]
        public bool DescartarMateriais(int materialId, int quantidadeDescartada)
        {
            try
            {
                Material m = facade.BuscarMaterial(materialId);
                m.QuantidadeEstoque -= quantidadeDescartada;
                facade.AlterarMaterial(m);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
