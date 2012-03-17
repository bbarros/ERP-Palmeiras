using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.WebServices
{
    public class FuncionarioDTO
    {
        public String Nome;
        public String Sobrenome;
        public long Cpf;
        public String Login;
        public Boolean IsMedico;
        public String Cargo;

        public FuncionarioDTO(String nome, String sobrenome, long cpf, String login, String cargo, Boolean isMedico)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Login = login;
            IsMedico = isMedico;
        }

        public FuncionarioDTO() { }
    }
}