using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public partial class RecursosHumanos
    {

        public IEnumerable<Especialidade> BuscarEspecialidades()
        {
            return model.TblEspecialidades.Where<Especialidade>(e => true);
        }

        public Especialidade BuscarEspecialidade(int id)
        {
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
            Especialidade e = model.TblEspecialidades.Find(eid);
            model.TblEspecialidades.Remove(e);
            model.SaveChanges();
            finClient.excluiEspecialidade(eid);
        }

        public void InserirEspecialidade(Especialidade espec)
        {
            Especialidade result = BuscarEspecialidade(espec.Nome);

            if (result == null)
            {
                // sabe deus para que eles precisam disso....
                model.TblEspecialidades.Add(espec);
            }
            else
            {
                throw new ERPException("Especialidade já cadastrada.");
            }

            model.SaveChanges();
            finClient.cadastraEspecialidade(espec.Id, espec.Nome); 
        }

    }
}