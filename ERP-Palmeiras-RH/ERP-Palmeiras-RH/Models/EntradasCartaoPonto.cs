//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace ERP_Palmeiras_RH.Models
{
    public partial class EntradasCartaoPonto
    {
        public int Id { get; set; }
        public System.DateTime Dia { get; set; }
        public System.TimeSpan EntradaManha { get; set; }
        public System.TimeSpan SaidaManha { get; set; }
        public System.TimeSpan EntradaTarde { get; set; }
        public System.TimeSpan SaidaTarde { get; set; }
        public System.TimeSpan EntradaNoite { get; set; }
        public System.TimeSpan SaidaNoite { get; set; }
        private int cartoesPontoId { get; set; }
    
        public virtual CartaoPonto CartaoPonto { get; set; }
    }
    
}