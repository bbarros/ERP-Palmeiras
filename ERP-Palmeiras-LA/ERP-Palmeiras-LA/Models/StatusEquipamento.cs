using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.Models
{
    public enum StatusEquipamento
    {
        FUNCIONANDO,
        QUEBRADO
    }

    public partial class StatusEquipamentoWrapper
    {
        private StatusEquipamento status;

        public int Value
        {
            get { return (int)status; }
            set { status = (StatusEquipamento)value; }
        }

        public StatusEquipamento EnumValue
        {
            get { return status; }
            set { status = value; }
        }

        public static implicit operator StatusEquipamentoWrapper(StatusEquipamento p)
        {
            return new StatusEquipamentoWrapper { EnumValue = p };
        }

        public static implicit operator StatusEquipamento(StatusEquipamentoWrapper pw)
        {
            if (pw == null) return StatusEquipamento.FUNCIONANDO;
            else return pw.EnumValue;
        }
    }
}