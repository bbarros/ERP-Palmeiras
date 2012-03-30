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

        public IEnumerable<Permissao> BuscarPermissoes()
        {
            return model.TblPermissoes.Where<Permissao>(e => true);
        }

        public Permissao BuscarPermissao(int id)
        {
            return model.TblPermissoes.Where<Permissao>(p => p.Id == id).First<Permissao>();
        }

        public void ExcluirPermissao(Int32 pid)
        {
            Permissao p = model.TblPermissoes.Find(pid);
            model.TblPermissoes.Remove(p);
            model.SaveChanges();
        }

        public void InserirPermissao(Permissao permissao)
        {
            IEnumerable<Permissao> result = model.TblPermissoes.Where(p => p.Nome == permissao.Nome);

            if (result == null || result.Count<Permissao>() == 0)
            {
                model.TblPermissoes.Add(permissao);
            }
            else
            {
                throw new ERPException("Permissão já cadastrada.");
            }

            model.SaveChanges();
        }
    }
}