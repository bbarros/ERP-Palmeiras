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

        public SolicitacaoCompraEquipamento BuscarSolicitacoesCompraEquipamento(StatusSolicitacaoCompra status)
        {
            IEnumerable<SolicitacaoCompraEquipamento> result = model.TblSolicitacoesCompraEquipamento.Where(s => s.Status == status);
            if (result != null && result.Count<SolicitacaoCompraEquipamento>() > 0)
                return result.First<SolicitacaoCompraEquipamento>();
            else
                return null;
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
                SolicitacaoCompraEquipamento sce = result.First<SolicitacaoCompraEquipamento>();
                sce.EquipamentoId = s.EquipamentoId;
                sce.Preco = s.Preco;
                sce.Status = s.Status;
                sce.DataValidade = s.DataValidade;
                model.TblSolicitacoesCompraEquipamento.Attach(sce);
                model.Entry(sce).State = EntityState.Modified;
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
    }
}