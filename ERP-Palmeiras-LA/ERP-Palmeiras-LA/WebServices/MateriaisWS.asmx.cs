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
            IEnumerable<MaterialClinica> mats = facade.BuscarMateriaisClinica();
            IEnumerable<MaterialClinica> distinctMats = mats.Distinct<MaterialClinica>();
            foreach (MaterialClinica mat in distinctMats)
            {
                MaterialClinicaDTO dto = new MaterialClinicaDTO(
                    mat.Material.Nome,
                    mat.Id,
                    mat.Material.Fabricante.Nome,
                    mat.Material.Codigo,
                    mat.Material.Descricao,
                    mats.Count<MaterialClinica>(m => m.MaterialId == mat.MaterialId));
                dtos.Add(dto);
            }
            return dtos;
        }

        [WebMethod]
        public bool DescartarMaterial(int materialId)
        {
            try
            {
                facade.ExcluirMaterial(materialId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
