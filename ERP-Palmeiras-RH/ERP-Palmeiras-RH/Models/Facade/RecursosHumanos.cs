using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;

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
                model.AddToTblFuncionarios(funcionario);
            }
            else
            {
                throw new ERPException("Funcionário já cadastrado.");
            }

            model.SaveChanges();
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            ModelRH model = new ModelRH();

            //IEnumerable<Funcionario> oldFunc = model.TblFuncionarios.Where(f => f.DadosPessoais.CPF = funcionario.DadosPessoais.CPF);
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

    }
}
