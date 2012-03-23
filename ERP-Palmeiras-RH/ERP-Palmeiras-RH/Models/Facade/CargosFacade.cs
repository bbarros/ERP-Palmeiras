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

        public IEnumerable<Cargo> BuscarCargos()
        {
            ModelRH model = new ModelRH();
            return model.TblCargos.Where<Cargo>(c => true);
        }

        public Cargo BuscarCargo(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblCargos.Where<Cargo>(c => c.Id == id).First<Cargo>();
        }

        public void InserirCargo(Cargo Cargo)
        {
            ModelRH model = new ModelRH();
            IEnumerable<Cargo> result = model.TblCargos.Where(c => (c.Nome == Cargo.Nome && c.SalarioBase == Cargo.SalarioBase));

            if (result == null || result.Count<Cargo>() == 0)
            {
                model.TblCargos.Add(Cargo);
            }
            else
            {
                throw new ERPException("Cargo já cadastrado.");
            }

            model.SaveChanges();
        }

        public void ExcluirCargo(Int32 cid)
        {
            try
            {
                ModelRH model = new ModelRH();
                Cargo Cargo = model.TblCargos.Find(cid);
                model.TblCargos.Remove(Cargo);
                model.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new ERPException("O cargo não pode ser excluído pois está atribuído a algum funcionário");
            }
        }
    }
}