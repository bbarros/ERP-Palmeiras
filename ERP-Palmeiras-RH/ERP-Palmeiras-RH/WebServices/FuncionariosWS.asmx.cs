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
            try
            {
                IEnumerable<Especialidade> result = facade.BuscarEspecialidades();
                List<EspecialidadeDTO> dtos = new List<EspecialidadeDTO>();
                if (result != null && result.Count<Especialidade>() > 0)
                {
                    foreach (Especialidade e in result)
                    {
                        dtos.Add(new EspecialidadeDTO(e.Nome, e.Id));
                    }
                }

                return dtos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Busca todos os médicos cadastrados.
        /// </summary>
        /// <returns>Lista de médicos cadastrados.</returns>
        [WebMethod]
        public List<MedicoDTO> BuscarMedicos()
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Busca um médico pelo seu cpf.
        /// </summary>
        /// <param name="cpf">Cpf</param>
        /// <returns>MedicoDTO ou null.</returns>
        [WebMethod]
        public MedicoDTO BuscarMedicoPorCpf(long cpf)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Busca um médico pelo seu cpf.
        /// </summary>
        /// <param name="medicoId">Id do medico</param>
        /// <returns>MedicoDTO ou null.</returns>
        [WebMethod]
        public MedicoDTO BuscarMedicoPorId(int medicoId)
        {
            try
            {
                Funcionario result = facade.BuscarFuncionario(medicoId);
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
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Busca um médico pelo seu Nome.
        /// </summary>
        /// <param name="medicoNome">Nome do medico</param>
        /// <returns>List{MedicoDTO} ou null.</returns>
        [WebMethod]
        public List<MedicoDTO> BuscarMedicosPorNome(String medicoNome)
        {
            try
            {
                IEnumerable<Funcionario> result = facade.BuscarFuncionarios(medicoNome);

                List<MedicoDTO> medicos = new List<MedicoDTO>();
                
                if (result != null)
                {
                    foreach (Funcionario funcionario in result)
                    {
                        if (funcionario is Medico)
                        {
                            Medico m = (Medico)funcionario;
                            medicos.Add(new MedicoDTO(m.DadosPessoais.Nome,
                                m.DadosPessoais.Sobrenome,
                                m.DadosPessoais.CPF,
                                m.Credencial.Usuario,
                                m.Cargo.Nome,
                                m.CRM,
                                m.Especialidade.Nome));
                        }
                    }
                }

                return medicos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Busca médicos pela Especialidade.
        /// </summary>
        /// <param name="especid">Id da Especialidade</param>
        /// <returns>List{MedicoDTO}</MedicoDTO> ou null.</returns>
        [WebMethod]
        public List<MedicoDTO> BuscarMedicosPorEspecialidade(int especId)
        {
            try
            {
                IEnumerable<Funcionario> result = facade.BuscarMedicosPorEspec(especId);

                List<MedicoDTO> medicos = new List<MedicoDTO>();

                if (result != null)
                {
                    foreach (Medico m in result)
                    {
                        medicos.Add(new MedicoDTO(m.DadosPessoais.Nome,
                            m.DadosPessoais.Sobrenome,
                            m.DadosPessoais.CPF,
                            m.Credencial.Usuario,
                            m.Cargo.Nome,
                            m.CRM,
                            m.Especialidade.Nome));
                    }
                }

                return medicos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Busca um funcionário pelo seu login.
        /// </summary>
        /// <param name="login">login</param>
        /// <returns>FuncionarioDTO, MedicoDTO ou null.</returns>
        [WebMethod]
        public FuncionarioDTO BuscarFuncionario(String login)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        [WebMethod]
        public EspecialidadeDTO BuscarEspecialidade(int id)
        {
            Especialidade e = facade.BuscarEspecialidade(id);
            if (e != null)
                return new EspecialidadeDTO(e.Nome, e.Id);
            return null;
        }
    }
}
