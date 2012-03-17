using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.WebServices
{
    public class MedicoDTO : FuncionarioDTO
    {
        public String Crm;
        public String Especialidade;

        public MedicoDTO(String nome, String sobrenome, long cpf, String login, String cargo, String crm, String especialidade)
            : base(nome, sobrenome, cpf, login, cargo, true)
        {
            Crm = crm;
            Especialidade = especialidade;
        }

        public MedicoDTO() : base() { }
    }
}