using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;
using ERP_Palmeiras_RH.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public class RecursosHumanos
    {
        private static volatile RecursosHumanos instance;

        private RecursosHumanos() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static RecursosHumanos GetInstance()
        {
            if (instance == null)
            {
                instance = new RecursosHumanos();
            }

            return instance;
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            ModelRH model = new ModelRH();

            IEnumerable<Funcionario> result = model.TblFuncionarios.Where(f => f.DadosPessoais.CPF == funcionario.DadosPessoais.CPF);

            if (result == null || result.Count<Funcionario>() == 0)
            {
                model.TblFuncionarios.Add(funcionario);
            }
            else
            {
                throw new ERPException("Funcionário já cadastrado.");
            }

            try
            {
                model.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            ModelRH model = new ModelRH();

            model.Entry(funcionario).State = EntityState.Modified;
            model.SaveChanges();
        }

        public Funcionario AutenticaUsuario(string user, string password)
        {
            ModelRH model = new ModelRH();
            IEnumerable<Funcionario> result = model.TblFuncionarios.Where(f => f.Credencial.Usuario == user && f.Credencial.Senha == password);

            if (result != null && result.Count<Funcionario>() > 0)
                return result.First<Funcionario>();
            else 
                 return null;

        }

        public IEnumerable<Cargo> BuscarCargos()
        {
            ModelRH model = new ModelRH();
            return model.TblCargos.Where<Cargo>(c => true);
        }

        public Cargo BuscarCargo(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblCargos.Where<Cargo>(c => c.Id == id).First<Cargo>();
        }

        public IEnumerable<Beneficio> BuscarBeneficios()
        {
            ModelRH model = new ModelRH();
            return model.TblBeneficios.Where<Beneficio>(b => true);
        }

        public Beneficio BuscarBeneficio(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblBeneficios.Where<Beneficio>(b => b.Id == id).First<Beneficio>();
        }

        public IEnumerable<Especialidade> BuscarEspecialidades()
        {
            ModelRH model = new ModelRH();
            return model.TblEspecialidades.Where<Especialidade>(e => true);
        }

        public Especialidade BuscarEspecialidade(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblEspecialidades.Where<Especialidade>(b => b.Id == id).First<Especialidade>();
        }

        public void ExcluirEspecialidade(Int32 eid)
        {
            ModelRH model = new ModelRH();
            Especialidade e = model.TblEspecialidades.Find(eid);
            model.TblEspecialidades.Remove(e);
            model.SaveChanges();
        }

        public IEnumerable<Permissao> BuscarPermissoes()
        {
            ModelRH model = new ModelRH();
            return model.TblPermissoes.Where<Permissao>(e => true);
        }

        public Permissao BuscarPermissao(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblPermissoes.Where<Permissao>(p => p.Id == id).First<Permissao>();
        }

        public void ExcluirPermissao(Int32 pid)
        {
            ModelRH model = new ModelRH();
            Permissao p = model.TblPermissoes.Find(pid);
            model.TblPermissoes.Remove(p);
            model.SaveChanges();
        }

        public IEnumerable<Funcionario> BuscarFuncionarios()
        {
            ModelRH model = new ModelRH();

            IEnumerable<Funcionario> funcionarios = model.TblFuncionarios.Where<Funcionario>(f => true);

            return funcionarios;
        }

        public Funcionario BuscarFuncionario(int id)
        {
            ModelRH model = new ModelRH();

            Funcionario funcionario = model.TblFuncionarios.Single(f => f.Id == id);

            return funcionario;
        }

        public void InserirPermissao(Permissao permissao)
        {
            ModelRH model = new ModelRH();
            IEnumerable<Permissao> result = model.TblPermissoes.Where(p => p.Nome == permissao.Nome);

            if (result == null || result.Count<Permissao>() == 0)
            {
                model.TblPermissoes.Add(permissao);
            }
            else
            {
                throw new ERPException("Permissão já cadastrada.");
            }

            model.SaveChanges();
        }

        public void InserirEspecialidade(Especialidade espec)
        {
            ModelRH model = new ModelRH();
            IEnumerable<Especialidade> result = model.TblEspecialidades.Where(e => e.Nome == espec.Nome);

            if (result == null || result.Count<Especialidade>() == 0)
            {
                model.TblEspecialidades.Add(espec);
            }
            else
            {
                throw new ERPException("Especialidade já cadastrada.");
            }

            model.SaveChanges();
        }

        public void InserirBeneficio(Beneficio beneficio)
        {
            ModelRH model = new ModelRH();
            IEnumerable<Beneficio> result = model.TblBeneficios.Where(b => (b.Nome == beneficio.Nome && b.Valor == beneficio.Valor));

            if (result == null || result.Count<Beneficio>() == 0)
            {
                model.TblBeneficios.Add(beneficio);
            }
            else
            {
                //throw new ERPException("Benefício já cadastrado.");
            }

            model.SaveChanges();
        }

        public void ExcluirBeneficio(Int32 bid)
        {
            try
            {
                ModelRH model = new ModelRH();
                Beneficio beneficio = model.TblBeneficios.Find(bid);
                model.TblBeneficios.Remove(beneficio);
                model.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new ERPException("O benefício não pode ser excluído pois está atribuído a algum funcionário");
            }
        }



    }
}
