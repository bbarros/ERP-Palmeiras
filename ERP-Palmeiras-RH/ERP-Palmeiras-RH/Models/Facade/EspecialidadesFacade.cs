using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public class EspecialidadesFacade
    {
        private static volatile EspecialidadesFacade instance;

        private EspecialidadesFacade() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static EspecialidadesFacade GetInstance()
        {
            if (instance == null)
            {
                instance = new EspecialidadesFacade();
            }

            return instance;
        }

        public IEnumerable<Especialidade> BuscarEspecialidades()
        {
            ModelRH model = new ModelRH();
            return model.TblEspecialidades.Where<Especialidade>(e => true);
        }

        public Especialidade BuscarEspecialidade(int id)
        {
            ModelRH model = new ModelRH();
            try
            {
                return model.TblEspecialidades.Where<Especialidade>(b => b.Id == id).First<Especialidade>();
            }
            catch (Exception)
            {
                throw new ERPException("Nenhum ou várias especialidades foram encontrados para o id=" + id.ToString());
            }
        }

        public Especialidade BuscarEspecialidade(String nome)
        {
            ModelRH model = new ModelRH();
             IEnumerable<Especialidade> result = model.TblEspecialidades.Where<Especialidade>(b => b.Nome == nome);
             if (result == null || result.Count<Especialidade>() == 0)
             {
                 return null;
             }
             else
             {
                 return result.First<Especialidade>();
             }
        }

        public void ExcluirEspecialidade(Int32 eid)
        {
            ModelRH model = new ModelRH();
            Especialidade e = model.TblEspecialidades.Find(eid);
            model.TblEspecialidades.Remove(e);
            model.SaveChanges();
        }

        public void InserirEspecialidade(Especialidade espec)
        {
            ModelRH model = new ModelRH();
            Especialidade result = BuscarEspecialidade(espec.Nome);

            if (result == null)
            {
                model.TblEspecialidades.Add(espec);
            }
            else
            {
                throw new ERPException("Especialidade já cadastrada.");
            }

            model.SaveChanges();
        }

    }
}