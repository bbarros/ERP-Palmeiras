using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public partial class RecursosHumanos
    {

        public IEnumerable<Beneficio> BuscarBeneficios()
        {
            return model.TblBeneficios.Where<Beneficio>(b => true);
        }

        public Beneficio BuscarBeneficio(int id)
        {
            return model.TblBeneficios.Where<Beneficio>(b => b.Id == id).First<Beneficio>();
        }

        public void InserirBeneficio(Beneficio beneficio)
        {
            IEnumerable<Beneficio> result = model.TblBeneficios.Where(b => (b.Nome == beneficio.Nome && b.Valor == beneficio.Valor));

            if (result == null || result.Count<Beneficio>() == 0)
            {
                model.TblBeneficios.Add(beneficio);
            }
            else
            {
                throw new ERPException("Benefício já cadastrado.");
            }

            model.SaveChanges();
        }

        public void ExcluirBeneficio(Int32 bid)
        {
            try
            {
                Beneficio beneficio = model.TblBeneficios.Find(bid);
                model.TblBeneficios.Remove(beneficio);
                model.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new ERPException("O benefício não pode ser excluído pois está atribuído a algum funcionário");
            }
        }
    }
}