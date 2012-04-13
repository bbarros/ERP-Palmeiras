//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_Palmeiras_LA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SolicitacaoManutencao
    {
        public SolicitacaoManutencao()
        {
            this.Status = new StatusSolicitacaoManutencaoWrapper();
        }
    
        public int Id { get; set; }
        public long DataPrevista { get; set; }
        public string Motivo { get; set; }
        public double Custo { get; set; }
        public long DataTerminoManutencao { get; set; }
        public int UsuarioId { get; set; }
        public int EquipamentoClinicaId { get; set; }
    
        public StatusSolicitacaoManutencaoWrapper Status { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual EquipamentoClinica EquipamentoClinica { get; set; }
    }
}
