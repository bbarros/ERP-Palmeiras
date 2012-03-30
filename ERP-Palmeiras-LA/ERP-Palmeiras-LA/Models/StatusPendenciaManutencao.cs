using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.Models
{
    public enum StatusPendenciaManutencao
    {
        PENDENTE,
        GERADA_SOLICITACAO_MANUTENCAO
    }

    public partial class StatusPendenciaManutencaoWrapper
    {
        private StatusPendenciaManutencao status;

        public int Value
        {
            get { return (int)status; }
            set { status = (StatusPendenciaManutencao)value; }
        }

        public StatusPendenciaManutencao EnumValue
        {
            get { return status; }
            set { status = value; }
        }

        public static implicit operator StatusPendenciaManutencaoWrapper(StatusPendenciaManutencao p)
        {
            return new StatusPendenciaManutencaoWrapper { EnumValue = p };
        }

        public static implicit operator StatusPendenciaManutencao(StatusPendenciaManutencaoWrapper pw)
        {
            if (pw == null) return StatusPendenciaManutencao.PENDENTE;
            else return pw.EnumValue;
        }
    }
}