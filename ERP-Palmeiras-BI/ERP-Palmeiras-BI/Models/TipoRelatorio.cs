using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_BI.Models
{
    public enum TipoRelatorio
    {
        ESPECIALIDADES_REQUISITADAS,
        CONSULTAS_REALIZADAS
    }

    public partial class TipoRelatorioWrapper
    {
        private TipoRelatorio tipo;

        public int Value
        {
            get { return (int)tipo; }
            set { tipo = (TipoRelatorio)value; }
        }

        public TipoRelatorio EnumValue
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public static implicit operator TipoRelatorioWrapper(TipoRelatorio p)
        {
            return new TipoRelatorioWrapper { EnumValue = p };
        }

        public static implicit operator TipoRelatorio(TipoRelatorioWrapper pw)
        {
            if (pw == null) return TipoRelatorio.ESPECIALIDADES_REQUISITADAS;
            else return pw.EnumValue;
        }
    }
}