﻿using System;
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
            return model.TblMateriais.Where<Material>(e => true);
        }

        public Material BuscarMaterial(int id)
        {
            try
            {
                return model.TblMateriais.Where<Material>(b => b.Id == id).First<Material>();
            }
            catch (Exception)
            {
                throw new ERPException("Nenhum ou várias Materials foram encontrados para o id=" + id.ToString());
            }
        }

        public Material BuscarMaterial(String codigo)
        {
             IEnumerable<Material> result = model.TblMateriais.Where<Material>(b => b.Codigo == codigo);
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
            Material e = model.TblMateriais.Find(eid);
            model.TblMateriais.Remove(e);
            model.SaveChanges();
        }

        public void InserirMaterial(Material mat)
        {
            Material result = BuscarMaterial(mat.Codigo);

            if (result == null)
            {
                model.TblMateriais.Add(mat);
            }
            else
            {
                throw new ERPException("Material já cadastrado.");
            }

            model.SaveChanges();
        }

        public void AlterarMaterial(Material mat)
        {
            model.TblMateriais.Attach(mat);
            model.Entry(mat).State = EntityState.Modified;
            model.SaveChanges();
        }
    }
}