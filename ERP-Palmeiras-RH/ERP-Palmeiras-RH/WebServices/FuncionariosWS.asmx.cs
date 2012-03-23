using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Models;

namespace ERP_Palmeiras_RH.WebServices
{
    /// <summary>
    /// Summary description for FuncionariosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FuncionariosWS : System.Web.Services.WebService
    {

        RecursosHumanos facade = RecursosHumanos.GetInstance();

        /// <summary>
        /// Busca todas as especialidades.
        /// </summary>
        /// <returns>Lista de especialidades.</returns>
        [WebMethod]
        public List<EspecialidadeDTO> BuscarEspecialidades()
        {
            IEnumerable<Especialidade> result = facade.BuscarEspecialidades();
            List<EspecialidadeDTO> dtos = new List<EspecialidadeDTO>();
            if (result != null && result.Count<Especialidade>() > 0)
            {
                foreach (Especialidade e in result)
                {
                    dtos.Add(new EspecialidadeDTO(e.Nome));
                }
            }

            return dtos;
        }

        /// <summary>
        /// Busca todos os médicos cadastrados.
        /// </summary>
        /// <returns>Lista de médicos cadastrados.</returns>
        [WebMethod]
        public List<MedicoDTO> BuscarMedicos()
        {
            IEnumerable<Funcionario> result = facade.BuscarFuncionarios();
            List<MedicoDTO> dtos = new List<MedicoDTO>();
            if (result != null && result.Count<Funcionario>() > 0)
            {
                foreach (Funcionario f in result)
                {
                    if (f is Medico)
                    {
                        Medico m = (Medico)f;
                        dtos.Add(new MedicoDTO(m.DadosPessoais.Nome,
                            m.DadosPessoais.Sobrenome,
                            m.DadosPessoais.CPF,
                            m.Credencial.Usuario,
                            m.Cargo.Nome,
                            m.CRM,
                            m.Especialidade.Nome));
                    }
                }
            }

            return dtos;
        }

        /// <summary>
        /// Busca um médico pelo seu cpf.
        /// </summary>
        /// <param name="cpf">Cpf</param>
        /// <returns>MedicoDTO ou null.</returns>
        [WebMethod]
        public MedicoDTO BuscarMedico(long cpf)
        {
            Funcionario result = facade.BuscarFuncionario(cpf);
            if (result != null)
            {
                if (result is Medico)
                {
                    Medico m = (Medico)result;
                    return new MedicoDTO(m.DadosPessoais.Nome,
                        m.DadosPessoais.Sobrenome,
                        m.DadosPessoais.CPF,
                        m.Credencial.Usuario,
                        m.Cargo.Nome,
                        m.CRM,
                        m.Especialidade.Nome);
                }
            }

            return null;
        }

        /// <summary>
        /// Busca um funcionário pelo seu login.
        /// </summary>
        /// <param name="login">login</param>
        /// <returns>FuncionarioDTO, MedicoDTO ou null.</returns>
        [WebMethod]
        public FuncionarioDTO BuscarFuncionario(String login)
        {
            Funcionario result = facade.BuscarFuncionario(login);
            if (result != null)
            {
                if (result is Medico)
                {
                    Medico m = (Medico)result;
                    return new MedicoDTO(m.DadosPessoais.Nome,
                        m.DadosPessoais.Sobrenome,
                        m.DadosPessoais.CPF,
                        m.Credencial.Usuario,
                        m.Cargo.Nome,
                        m.CRM,
                        m.Especialidade.Nome);
                }
                else
                {
                    return new FuncionarioDTO(result.DadosPessoais.Nome,
                        result.DadosPessoais.Sobrenome,
                        result.DadosPessoais.CPF,
                        result.Credencial.Usuario,
                        result.Cargo.Nome,
                        false);
                }
            }

            return null;
        }
    }
}
