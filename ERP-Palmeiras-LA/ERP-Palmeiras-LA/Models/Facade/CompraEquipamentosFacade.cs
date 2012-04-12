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

        public void CriarCompraEquipamento(SolicitacaoCompraEquipamento s, DateTime dataPrevista)
        {
            s = model.TblSolicitacoesCompraEquipamento.Attach(s);
            CompraEquipamento c = new CompraEquipamento();
            c.DataPrevista = dataPrevista.Ticks;
            c.Status = StatusCompra.COMPRA_SOLICITADA;
            c.SolicitacaoCompraEquipamento = s;
            s.CompraEquipamento = c;
            model.TblCompraEquipamento.Add(c);
            model.SaveChanges();
            // TODO: Criar requisicao no Financeiro!
        }

        public void AlterarCompraEquipamento(CompraEquipamento c)
        {
            model.TblCompraEquipamento.Attach(c);
            model.Entry(c).State = EntityState.Modified;
            model.SaveChanges();
        }

        public CompraEquipamento BuscarCompraEquipamento(int id)
        {
            return model.TblCompraEquipamento.Find(id);
        }

        public IEnumerable<CompraEquipamento> BuscarComprasEquipamento()
        {
            return model.TblCompraEquipamento.Where<CompraEquipamento>(c => true);
        }

        public IEnumerable<CompraEquipamento> BuscarComprasEquipamento(StatusCompra status)
        {
            return model.TblCompraEquipamento.Where<CompraEquipamento>(c => c.Status.Value == (int) status);
        }
    }
}