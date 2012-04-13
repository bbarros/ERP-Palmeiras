using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.Models
{
    public enum StatusSolicitacaoCompra
    {
        APROVADO,
        REPROVADO,
        PENDENTE
    }

    public partial class StatusSolicitacaoCompraWrapper
    {
        private StatusSolicitacaoCompra status;

        public StatusSolicitacaoCompra EnumValue
        {
            get { return status; }
            set { status = value; }
        }

        public static implicit operator StatusSolicitacaoCompraWrapper(StatusSolicitacaoCompra p)
        {
            return new StatusSolicitacaoCompraWrapper { EnumValue = p };
        }

        public static implicit operator StatusSolicitacaoCompra(StatusSolicitacaoCompraWrapper pw)
        {
            if (pw == null) return StatusSolicitacaoCompra.PENDENTE;
            else return pw.EnumValue;
        }
    }
}