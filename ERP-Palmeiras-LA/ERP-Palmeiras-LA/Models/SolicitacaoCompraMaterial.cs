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
    
    public partial class SolicitacaoCompraMaterial
    {
        public SolicitacaoCompraMaterial()
        {
            this.Status = new StatusSolicitacaoCompraWrapper();
        }
    
        public int Id { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public long DataValidade { get; set; }
        public int MaterialId { get; set; }
    
        public StatusSolicitacaoCompraWrapper Status { get; set; }
    
        public virtual CompraMaterial CompraMaterial { get; set; }
        public virtual Material Material { get; set; }
    }
}