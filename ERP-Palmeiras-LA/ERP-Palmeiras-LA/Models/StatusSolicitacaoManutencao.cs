using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.Models
{
    public enum StatusSolicitacaoManutencao
    {
        CONCLUIDA,
        EM_PROGRESSO,
        PENDENTE
    }

    public partial class StatusSolicitacaoManutencaoWrapper
    {
        private StatusSolicitacaoManutencao status;

        public int Value
        {
            get { return (int)status; }
            set { status = (StatusSolicitacaoManutencao)value; }
        }

        public StatusSolicitacaoManutencao EnumValue
        {
            get { return status; }
            set { status = value; }
        }

        public static implicit operator StatusSolicitacaoManutencaoWrapper(StatusSolicitacaoManutencao p)
        {
            return new StatusSolicitacaoManutencaoWrapper { EnumValue = p };
        }

        public static implicit operator StatusSolicitacaoManutencao(StatusSolicitacaoManutencaoWrapper pw)
        {
            if (pw == null) return StatusSolicitacaoManutencao.EM_PROGRESSO;
            else return pw.EnumValue;
        }
    }
}