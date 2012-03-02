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

        public static void InserirFuncionario(Funcionario funcionario)
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

        public static void AtualizarFuncionario(Funcionario funcionario)
        {
            ModelRH model = new ModelRH();

            //IEnumerable<Funcionario> oldFunc = model.TblFuncionarios.Where(f => f.DadosPessoais.CPF = funcionario.DadosPessoais.CPF);
        }

    }
}
