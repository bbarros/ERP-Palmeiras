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

        public IEnumerable<Pendencia> BuscarPendencias()
        {
            return model.TblPendencias.Where<Pendencia>(b => true);
        }

        public Pendencia BuscarPendencia(int id)
        {
            return model.TblPendencias.Where<Pendencia>(b => b.Id == id).First<Pendencia>();
        }

        public void InserirPendencia(Pendencia pendencia)
        {
            IEnumerable<Pendencia> result = model.TblPendencias.Where(b => (b.Funcionario.Id == pendencia.Funcionario.Id));

            if (result == null || result.Count<Pendencia>() == 0)
            {
                model.TblPendencias.Add(pendencia);
            }
            else
            {
                throw new ERPException("Já existe uma pendência para este funcionário.");
            }

            model.SaveChanges();
        }

        public void ExcluirPendencia(Int32 pid)
        {
            try
            {
                Pendencia pendencia = model.TblPendencias.Find(pid);
                model.TblPendencias.Remove(pendencia);
                model.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new ERPException("Não foi possível remover a pendência do funcionário.");
            }
        }
    }
}