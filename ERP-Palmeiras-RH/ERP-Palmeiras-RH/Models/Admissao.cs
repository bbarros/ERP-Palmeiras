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
    public partial class Admissao
    {
        public int Id { get; set; }
        public System.DateTime DataAdmissao { get; set; }
        public Nullable<System.DateTime> DataDesligamento { get; set; }
        public string MotivoDesligamento { get; set; }
        public string UltimoSalario { get; set; }
    }
    
}