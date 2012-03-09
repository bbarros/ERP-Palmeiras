using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.Models
{
    public partial class Medico
    {

        /// <summary>
        /// Cria um médico a partir de um funcionário.
        /// Se este objeto for persistido posteriormente e o objeto funcionário estiver persistido, recomenda-se remover o objeto funcionário.
        /// </summary>
        /// <param name="func"></param>
        public Medico(Funcionario func, String crm, Especialidade e)
        {
            Admissao = func.Admissao;
            Beneficios = func.Beneficios;
            Cargo = func.Cargo;
            Credencial = func.Credencial;
            Curriculum = func.Curriculum;
            CRM = crm;
            DadosPessoais = func.DadosPessoais;
            DadosBancarios = func.DadosBancarios;
            Especialidade = e;
            Permissao = func.Permissao;
            Ramal = func.Ramal;
            Salario = func.Salario;
            Status = func.Status;
        }
    }
}