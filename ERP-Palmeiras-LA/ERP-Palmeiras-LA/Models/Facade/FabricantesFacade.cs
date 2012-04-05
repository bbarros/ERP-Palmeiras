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

        public Fabricante BuscarFabricante(string cnpj)
        {
            IEnumerable<Fabricante> result = model.TblFabricantes.Where(f => f.CNPJ == cnpj);
            if (result != null && result.Count<Fabricante>() > 0)
                return result.First<Fabricante>();
            else
                return null;
        }

        public Fabricante BuscarFabricante(int id)
        {
            IEnumerable<Fabricante> result = model.TblFabricantes.Where(f => f.Id == id);
            if (result != null && result.Count<Fabricante>() > 0)
                return result.First<Fabricante>();
            else
                return null;
        }

        public void AlterarFabricante(Fabricante f)
        {
            model.TblFabricantes.Attach(f);
            model.Entry(f).State = EntityState.Modified;
            model.SaveChanges();
        }

        public void CriarFabricante(Fabricante f)
        {
            model.TblFabricantes.Add(f);
            model.SaveChanges();
        }

        public IEnumerable<Fabricante> BuscarFabricantes()
        {
            return model.TblFabricantes.Where<Fabricante>(f => true);
        }
    }
}