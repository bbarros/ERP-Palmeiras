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
    /// Summary description for UsuariosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UsuariosWS : System.Web.Services.WebService
    {

        RecursosHumanos facade = RecursosHumanos.GetInstance();

        [WebMethod]
        public Boolean InserirUsuario(String login, String senha)
        {
            // Caso o usuario seja criado em outro modulo,
            // é necessário criá-lo neste módulo, também.
            // Esta função cria um Funcionário Externo,
            // com dados stubs, com o login e senha fornecidos,
            // de forma que se mantenha a consistência de existência
            // dos logins nos módulos.
            // No entanto, as informações deste usuário devem ser editadas no módulo de RH.
            // Para isto, cria-se uma pendência de cadastro. Há uma tela de monitoramento de pendências.
            try
            {
                Funcionario f = CriarFuncionarioExterno(login, senha);
                facade.InserirFuncionario(f);

                Pendencia p = new Pendencia();
                p.Funcionario = f;
                facade.InserirPendencia(p);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public Boolean AlterarUsuario(String loginNovo, String loginAntigo, String senhaNova)
        {
            try
            {
                Funcionario f = facade.BuscarFuncionario(loginAntigo);
                f.Credencial.Usuario = loginNovo;
                f.Credencial.Senha = senhaNova;
                facade.AtualizarFuncionario(f);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private Funcionario CriarFuncionarioExterno(String login, String senha)
        {
            Funcionario func;
            func = new Funcionario();

            func.Ramal = 12;
            func.Salario = 2000;

            Admissao adm = new Admissao();
            adm.DataAdmissao = new DateTime(1967, 9, 12);
            adm.DataDesligamento = null;
            adm.MotivoDesligamento = null;
            adm.UltimoSalario = null;
            func.Admissao = adm;

            IEnumerable<Beneficio> beneficios = facade.BuscarBeneficios();
            foreach (Beneficio b in beneficios)
            {
                func.Beneficios.Add(b);
            }

            Cargo cg = facade.BuscarCargos().First<Cargo>();
            func.Cargo = cg;

            Random rd = new Random();

            DadoPessoal dp = new DadoPessoal();
            int sulfixNome = rd.Next();
            dp.Nome = "Funcionario" + sulfixNome;
            dp.RG = rd.Next();
            dp.Sexo = "Masculino";
            dp.Sobrenome = "Externo";
            dp.CPF = rd.Next();
            dp.DataNascimento = new DateTime(1967, 9, 12);
            dp.Email = "funcionario.externo" + sulfixNome.ToString() + "@xxx.com";
            dp.CLT = rd.Next().ToString();

            Endereco end = new Endereco();
            end.Rua = "??";
            end.Pais = "??";
            end.Numero = rd.Next();
            end.Estado = "??";
            end.CEP = "00000-000";
            end.Complemento = "";
            end.Cidade = "??";
            end.Bairro = "??";

            Telefone tel = new Telefone();
            String ddd = "00";
            String telStr = "00000000";
            tel.DDD = int.Parse(ddd);
            tel.Numero = int.Parse(telStr);
            dp.Telefones.Add(tel);

            dp.Endereco = end;
            func.DadosPessoais = dp;

            Curriculum curriculum = new Curriculum();
            byte[] cv = new byte[1000];
            curriculum.Arquivo = cv;
            curriculum.Formacao = "??";
            func.Curriculum = curriculum;

            Credencial c = new Credencial();
            c.Senha = senha;
            c.Usuario = login;
            func.Credencial = c;

            Permissao p = facade.BuscarPermissoes().First<Permissao>();
            func.Permissao = p;

            DadoBancario db = new DadoBancario();
            db.Agencia = rd.Next().ToString().ToLower() + "-0";
            db.Banco = 231;
            db.ContaCorrente = rd.Next().ToString().ToLower() + "-00";
            func.DadosBancarios = db;

            func.Status = 1;
            func.CartaoPonto = new CartaoPonto();

            return func;
        }
    }
}
