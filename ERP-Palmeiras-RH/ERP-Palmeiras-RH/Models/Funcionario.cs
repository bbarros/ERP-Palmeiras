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
    public partial class Funcionario
    {
        public Funcionario()
        {
            this.Beneficios = new HashSet<Beneficio>();
        }
    
        public int Id { get; set; }
        public int Status { get; set; }
        public double Salario { get; set; }
        public int Ramal { get; set; }
        internal string EntityType { get; set; }
        public int PermissaoId { get; private set; }
        public int CargoId { get; private set; }
    
        public virtual Credencial Credencial { get; set; }
        public virtual Permissao Permissao { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual DadoPessoal DadosPessoais { get; set; }
        public virtual CartaoPonto CartaoPonto { get; set; }
        public virtual ICollection<Beneficio> Beneficios { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual DadoBancario DadosBancarios { get; set; }
        public virtual Admissao Admissao { get; set; }
    }
    
}
