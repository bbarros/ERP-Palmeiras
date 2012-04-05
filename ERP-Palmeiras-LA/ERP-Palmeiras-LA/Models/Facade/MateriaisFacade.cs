using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_LA.Core;
using ERP_Palmeiras_LA.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_LA.Models.Facade
{
    public partial class LogisticaAbastecimento
    {

        public IEnumerable<Material> BuscarMateriais()
        {
            return model.TblMaterial.Where<Material>(e => true);
        }

        public Material BuscarMaterial(int id)
        {
            try
            {
                return model.TblMaterial.Where<Material>(b => b.Id == id).First<Material>();
            }
            catch (Exception)
            {
                throw new ERPException("Nenhum ou várias Materials foram encontrados para o id=" + id.ToString());
            }
        }

        public Material BuscarMaterial(String nome)
        {
             IEnumerable<Material> result = model.TblMaterial.Where<Material>(b => b.Nome == nome);
             if (result == null || result.Count<Material>() == 0)
             {
                 return null;
             }
             else
             {
                 return result.First<Material>();
             }
        }

        public void ExcluirMaterial(Int32 eid)
        {
            Material e = model.TblMaterial.Find(eid);
            model.TblMaterial.Remove(e);
            model.SaveChanges();
        }

        public void InserirMaterial(Material espec)
        {
            Material result = BuscarMaterial(espec.Codigo);

            if (result == null)
            {
                model.TblMaterial.Add(espec);
            }
            else
            {
                throw new ERPException("Material já cadastrado.");
            }

            model.SaveChanges();
        }

    }
}