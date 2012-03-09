using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;

namespace ERP_Palmeiras_RH.Controllers
{
    /// <summary>
    /// Controller para Actions de Cadastro de Funcionarios.
    /// </summary>
    public class FuncionariosController : Controller
    {

        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        /// <summary>
        /// Exibe a lista dos funcionários.
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            IEnumerable<Cargo> cargos = facade.BuscarCargos();
            IEnumerable<Beneficio> beneficios = facade.BuscarBeneficios();
            IEnumerable<Especialidade> especialidades = facade.BuscarEspecialidades();
            IEnumerable<Permissao> permissoes = facade.BuscarPermissoes();

            ViewData["Cargos"] = cargos;
            ViewData["Beneficios"] = beneficios;
            ViewData["Especialidades"] = especialidades;
            ViewData["Permissoes"] = permissoes;
            return View();
        }


        public ActionResult Cadastrar(String nome, String sobrenome,
            String sexo, DateTime nascimento, String telefone,
            String emailpes, String rua, int num, String complemento, String bairro,
            String cep, String cidade, String estado, String pais, String cpf, String rg,
            String crm, String formacao, HttpPostedFileBase flCurriculum,
            int banco, String agencia, String conta, double salario,
            int[] beneficios, int status, String carteira, DateTime dataadmissao, String motivo,
            DateTime? datademissao, int ramal, int cargo, int especialidade, String usuario, String senha, int permissao)
        {

            Funcionario func;
            func = new Funcionario();
            Admissao adm = new Admissao();
            adm.DataAdmissao = dataadmissao;
            adm.DataDesligamento = datademissao;
            adm.MotivoDesligamento = motivo;
            func.Admissao = adm;

            foreach (int beneficioId in beneficios)
            {
                Beneficio b = facade.BuscarBeneficio(beneficioId);
                func.Beneficios.Add(b);
            }

            DadoPessoal dp = new DadoPessoal();
            dp.Nome = nome;
            dp.RG = long.Parse(rg.Replace(".", "").Replace("-", ""));
            dp.Sexo = sexo;
            dp.Sobrenome = sobrenome;
            dp.CPF = long.Parse(cpf.Replace(".", "").Replace("-", ""));
            dp.DataNascimento = nascimento;
            dp.Email = emailpes;
            dp.CLT = carteira;

            Endereco end = new Endereco();
            end.Rua = rua;
            end.Pais = pais;
            end.Numero = num;
            end.Estado = estado;
            end.CEP = cep;
            end.Complemento = complemento;
            end.Cidade = cidade;

            dp.Endereco = end;
            func.DadosPessoais = dp;

            Curriculum curriculum = new Curriculum();
            curriculum.Arquivo = new byte[flCurriculum.ContentLength];
            flCurriculum.InputStream.Read(curriculum.Arquivo, 0, flCurriculum.ContentLength);
            curriculum.Formacao = formacao;
            func.Curriculum = curriculum;

            Credencial c = new Credencial();
            c.Senha = senha;
            c.Usuario = usuario;
            func.Credencial = c;

            Permissao p = facade.BuscarPermissao(permissao);
            func.Permissao = p;

            DadoBancario db = new DadoBancario();
            db.Agencia = agencia;
            db.Banco = banco;
            db.ContaCorrente = conta;
            func.DadosBancarios = db;

            facade.InserirFuncionario(func);

            return View();
        }
    }
}
