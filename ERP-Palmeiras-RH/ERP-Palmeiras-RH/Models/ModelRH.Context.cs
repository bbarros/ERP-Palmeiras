﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_RH.Models
{
    public partial class ModelRH : DbContext
    {
        public ModelRH()
            : base("name=ModelRH")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Funcionario> TblFuncionarios { get; set; }
        public DbSet<Pagamento> TblPagamentos { get; set; }
        public DbSet<Credencial> TblCredenciais { get; set; }
        public DbSet<Permissao> TblPermissoes { get; set; }
        public DbSet<Curriculum> TblCurricula { get; set; }
        public DbSet<CartaoPonto> TblCartoesPonto { get; set; }
        public DbSet<EntradasCartaoPonto> TblEntradasCartaoPonto { get; set; }
        public DbSet<DadoPessoal> TblDadosPessoais { get; set; }
        public DbSet<Endereco> TblEnderecos { get; set; }
        public DbSet<Telefone> TblTelefones { get; set; }
        public DbSet<Beneficio> TblBeneficios { get; set; }
        public DbSet<Cargo> TblCargos { get; set; }
        public DbSet<Especialidade> TblEspecialidades { get; set; }
        public DbSet<DadoBancario> TblDadosBancarios { get; set; }
        public DbSet<Admissao> TblAdmissoes { get; set; }
    }
}