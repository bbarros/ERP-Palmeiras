using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_LA.Core;
using ERP_Palmeiras_LA.Models;
using System.Data;

namespace ERP_Palmeiras_LA.Models.Facade
{
    public partial class LogisticaAbastecimento
    {

        public void CriarMaterialClinica(Material m, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                m = model.TblMateriais.Attach(m);
                MaterialClinica ec = new MaterialClinica();
                ec.Material = m;
                model.TblMateriaisClinica.Add(ec);
                model.SaveChanges();
            }
        }

        public void AlterarMaterialClinica(MaterialClinica c)
        {
            model.TblMateriaisClinica.Attach(c);
            model.Entry(c).State = EntityState.Modified;
            model.SaveChanges();
        }

        public MaterialClinica BuscarMaterialClinica(int id)
        {
            return model.TblMateriaisClinica.Find(id);
        }

        public IEnumerable<MaterialClinica> BuscarMateriaisClinica()
        {
            return model.TblMateriaisClinica.Where<MaterialClinica>(c => true);
        }

        public void ExcluirMaterialClinica(int id)
        {
            MaterialClinica s = BuscarMaterialClinica(id);
            try
            {
                model.TblMateriaisClinica.Remove(s);
                model.SaveChanges();
            }
            catch (Exception)
            {
                throw new ERPException("Não foi possível remover o material da clínica.");
            }
        }
    }
}