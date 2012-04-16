using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.Models
{
    public enum StatusCompra
    {
        ENTREGUE,
        COMPRA_SOLICITADA,
        ERRO_ORDEM_COMPRA,
        COMPRA_CONCLUIDA
    }

    public partial class StatusCompraWrapper
    {
        private StatusCompra status;

        public int Value
        {
            get { return (int)status; }
            set { status = (StatusCompra) value; }
        }

        public StatusCompra EnumValue
        {
            get { return status; }
            set { status = value; }
        }

        public static implicit operator StatusCompraWrapper(StatusCompra p)
        {
            return new StatusCompraWrapper { EnumValue = p };
        }

        public static implicit operator StatusCompra(StatusCompraWrapper pw)
        {
            if (pw == null) return StatusCompra.COMPRA_SOLICITADA;
            else return pw.EnumValue;
        }
    }
}