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

        public void CriarCompraMaterial(SolicitacaoCompraMaterial s, DateTime dataPrevista)
        {
            s = model.TblSolicitacoesCompraMaterial.Attach(s);
            CompraMaterial c = new CompraMaterial();
            c.DataPrevista = dataPrevista.Ticks;
            c.Status = StatusCompra.COMPRA_SOLICITADA;
            c.SolicitacaoCompraMaterial = s;
            s.CompraMaterial = c;
            model.TblCompraMaterial.Add(c);
            model.SaveChanges();

            SolicitarCompra(c);
        }

        public void SolicitarCompra(CompraMaterial c)
        {
            model.TblCompraMaterial.Attach(c);
            // TODO: UTILIZAR NOVOS METODOS DE FINANCEIRO
            //bool compraExternaSuccess = finClient.comprarEquipamento(
            //    c.SolicitacaoCompraEquipamento.Equipamento.Nome,
            //    c.SolicitacaoCompraEquipamento.Equipamento.Descricao,
            //    c.SolicitacaoCompraEquipamento.Equipamento.NumeroSerie,
            //    DateTime.Now, // quero comprar AGORA né?
            //    c.SolicitacaoCompraEquipamento.Preco);
            //if (!compraExternaSuccess)
            //{
            //    c.Status = StatusCompra.COMPRA_RECUSADA;
            //}
        }

        public void AlterarCompraMaterial(CompraMaterial c)
        {
            model.TblCompraMaterial.Attach(c);
            model.Entry(c).State = EntityState.Modified;
            model.SaveChanges();
        }

        public CompraMaterial BuscarCompraMaterial(int id)
        {
            return model.TblCompraMaterial.Find(id);
        }

        public IEnumerable<CompraMaterial> BuscarComprasMaterial()
        {
            return model.TblCompraMaterial.Where<CompraMaterial>(c => true);
        }

        public IEnumerable<CompraMaterial> BuscarComprasMaterial(StatusCompra status)
        {
            return model.TblCompraMaterial.Where<CompraMaterial>(c => c.Status.Value == (int)status);
        }
    }
}