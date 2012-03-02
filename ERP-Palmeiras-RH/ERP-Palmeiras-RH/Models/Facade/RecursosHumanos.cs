using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP_Palmeiras_RH.Models.Facade
{
    class RecursosHumanos
    {
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
                throw new Exception("Funcionário já cadastrado.");
            }

            model.SaveChanges();
        }

    }
}
