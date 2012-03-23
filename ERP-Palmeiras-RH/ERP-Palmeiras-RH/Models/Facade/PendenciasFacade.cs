using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public class PendenciasFacade
    {
        private static volatile PendenciasFacade instance;

        private PendenciasFacade() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static PendenciasFacade GetInstance()
        {
            if (instance == null)
            {
                instance = new PendenciasFacade();
            }

            return instance;
        }

        public IEnumerable<Pendencia> BuscarPendencias()
        {
            ModelRH model = new ModelRH();
            return model.TblPendencias.Where<Pendencia>(b => true);
        }

        public Pendencia BuscarPendencia(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblPendencias.Where<Pendencia>(b => b.Id == id).First<Pendencia>();
        }

        public void InserirPendencia(Pendencia pendencia)
        {
            ModelRH model = new ModelRH();
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
                ModelRH model = new ModelRH();
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