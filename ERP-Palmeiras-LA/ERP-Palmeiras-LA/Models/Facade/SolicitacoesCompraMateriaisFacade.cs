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

        public IEnumerable<SolicitacaoCompraMaterial> BuscarSolicitacoesCompraMateriais(StatusSolicitacaoCompra status)
        {
            return model.TblSolicitacoesCompraMaterial.Where(s => s.Status.Value == (int) status);
        }

        public SolicitacaoCompraMaterial BuscarSolicitacaoCompraMaterial(int id)
        {
            IEnumerable<SolicitacaoCompraMaterial> result = model.TblSolicitacoesCompraMaterial.Where(s => s.Id == id);
            if (result != null && result.Count<SolicitacaoCompraMaterial>() > 0)
                return result.First<SolicitacaoCompraMaterial>();
            else
                return null;
        }

        public void AlterarSolicitacaoCompraMaterial(SolicitacaoCompraMaterial s)
        {
            IEnumerable<SolicitacaoCompraMaterial> result = model.TblSolicitacoesCompraMaterial.Where(sce => sce.Id == s.Id);
            if (result != null && result.Count<SolicitacaoCompraMaterial>() > 0)
            {
                model.TblSolicitacoesCompraMaterial.Attach(s);
                model.Entry(s).State = EntityState.Modified;
                model.SaveChanges();
            }
            else
                throw new ERPException("Solicitação " + s.Id + " não encontrado.");
        }

        public void CriarSolicitacaoCompraMaterial(SolicitacaoCompraMaterial s)
        {
            model.TblSolicitacoesCompraMaterial.Add(s);
            model.SaveChanges();
        }

        public IEnumerable<SolicitacaoCompraMaterial> BuscarSolicitacoesCompraMateriais()
        {
            return model.TblSolicitacoesCompraMaterial.Where<SolicitacaoCompraMaterial>(s => true);
        }

        public void ExcluirSolicitacaoCompraMaterial(int id)
        {
            SolicitacaoCompraMaterial s = BuscarSolicitacaoCompraMaterial(id);
            try
            {
                model.TblSolicitacoesCompraMaterial.Remove(s);
                model.SaveChanges();
            }
            catch (Exception)
            {
                throw new ERPException("Esta solicitação de compra de material já está associada a um processo de compra. Ela não pode ser removida.");
            }
        }
    }
}