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
    
    public partial class CompraEquipamento
    {
        public int Id { get; set; }
        public Nullable<long> DataEntrega { get; set; }
        public long DataPrevista { get; set; }
        public int StatusCompra { get; set; }
    
        public virtual SolicitacaoCompraEquipamento SolicitacaoCompraEquipamento { get; set; }
    }
}
