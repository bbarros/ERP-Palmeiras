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

        public IEnumerable<SolicitacaoCompraEquipamento> BuscarSolicitacoesCompraEquipamentos(StatusSolicitacaoCompra status)
        {
            return model.TblSolicitacoesCompraEquipamento.Where(s => s.Status.Value == (int) status);
        }

        public SolicitacaoCompraEquipamento BuscarSolicitacaoCompraEquipamento(int id)
        {
            IEnumerable<SolicitacaoCompraEquipamento> result = model.TblSolicitacoesCompraEquipamento.Where(s => s.Id == id);
            if (result != null && result.Count<SolicitacaoCompraEquipamento>() > 0)
                return result.First<SolicitacaoCompraEquipamento>();
            else
                return null;
        }

        public void AlterarSolicitacaoCompraEquipamento(SolicitacaoCompraEquipamento s)
        {
            IEnumerable<SolicitacaoCompraEquipamento> result = model.TblSolicitacoesCompraEquipamento.Where(sce => sce.Id == s.Id);
            if (result != null && result.Count<SolicitacaoCompraEquipamento>() > 0)
            {
                model.TblSolicitacoesCompraEquipamento.Attach(s);
                model.Entry(s).State = EntityState.Modified;
                model.SaveChanges();
            }
            else
                throw new ERPException("Solicitação " + s.Id + " não encontrado.");
        }

        public void CriarSolicitacaoCompraEquipamento(SolicitacaoCompraEquipamento s)
        {
            model.TblSolicitacoesCompraEquipamento.Add(s);
            model.SaveChanges();
        }

        public IEnumerable<SolicitacaoCompraEquipamento> BuscarSolicitacoesCompraEquipamentos()
        {
            return model.TblSolicitacoesCompraEquipamento.Where<SolicitacaoCompraEquipamento>(s => true);
        }

        public void ExcluirSolicitacaoCompraEquipamento(int id)
        {
            SolicitacaoCompraEquipamento s = BuscarSolicitacaoCompraEquipamento(id);
            try
            {
                model.TblSolicitacoesCompraEquipamento.Remove(s);
                model.SaveChanges();
            }
            catch (Exception)
            {
                throw new ERPException("Esta solicitação de compra de equipamento já está associada a um processo de compra. Ela não pode ser removida.");
            }
        }
    }
}