using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;
using System.Text.RegularExpressions;
using ERP_Palmeiras_RH.Core;


namespace ERP_Palmeiras_RH.Controllers
{
    /// <summary>
    /// Controller para Actions de Cadastro de Funcionarios.
    /// </summary>
    [HandleERPException]
    public class FuncionariosController : Controller
    {

        private RecursosHumanos facade = RecursosHumanos.GetInstance();

        /// <summary>
        /// Exibe a lista dos funcionários.
        /// </summary>
        public ActionResult Index()
        {
            RecursosHumanos facadeRH = RecursosHumanos.GetInstance();
            IEnumerable<Funcionario> listaFuncionarios = facadeRH.BuscarFuncionarios();

            return View(listaFuncionarios);
        }

        public ActionResult Criar()
        {
            PopularViewDataCadastro();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(String nome, String sobrenome,
            String sexo, DateTime nascimento, String telefone,
            String emailpes, String rua, int num, String complemento, String bairro,
            String cep, String cidade, String estado, String pais, String cpf, String rg,
            String crm, String formacao, HttpPostedFileBase flCurriculum,
            int banco, String agencia, String conta, double salario,
            int[] beneficios, int status, String carteira, DateTime dataadmissao, String motivo,
            DateTime? datademissao, int ramal, int cargo, int especialidade, String usuario, String senha, int permissao)
        {

            Funcionario func = CriarFuncionarioOuMedico(nome, sobrenome, salario, 0.0f, sexo, nascimento, emailpes, rua, num, telefone, complemento, cep, bairro, cidade, estado, pais, cpf, rg, crm, formacao, flCurriculum, banco, agencia, conta, beneficios, status, carteira, dataadmissao, motivo, datademissao, especialidade, cargo, usuario, senha, permissao);
            func.CartaoPonto = new CartaoPonto();

            facade.InserirFuncionario(func);

            return View();
        }

        public ActionResult Editar(int id)
        {
            RecursosHumanos facadeRH = RecursosHumanos.GetInstance();
            Funcionario funcionario = facadeRH.BuscarFuncionario(id);
            PopularViewDataCadastro();
            ViewData["Id"] = id;
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Alterar(int id, String nome, String sobrenome,
            String sexo, DateTime nascimento, String telefone,
            String emailpes, String rua, int num, String complemento, String bairro,
            String cep, String cidade, String estado, String pais, String cpf, String rg,
            String crm, String formacao, HttpPostedFileBase flCurriculum,
            int banco, String agencia, String conta, double salario,
            int[] beneficios, int status, String carteira, DateTime dataadmissao, String motivo,
            DateTime? datademissao, int ramal, int cargo, int especialidade, String usuario, String senha, int permissao)
        {

            Funcionario old = facade.BuscarFuncionario(id);
            Funcionario func = CriarFuncionarioOuMedico(nome, sobrenome, salario, old.Salario, sexo, nascimento, emailpes, rua, num, telefone, complemento, cep, bairro, cidade, estado, pais, cpf, rg, crm, formacao, flCurriculum, banco, agencia, conta, beneficios, status, carteira, dataadmissao, motivo, datademissao, especialidade, cargo, usuario, senha, permissao);

            facade.AtualizarFuncionario(func);

            return View();
        }

        private Funcionario CriarFuncionarioOuMedico(String nome, String sobrenome, double salario,  double ultimoSalario, String sexo, DateTime nascimento, String emailpes, String rua, int num, String telefone, String complemento, String cep, String bairro, String cidade, String estado, String pais, String cpf, String rg, String crm, String formacao, HttpPostedFileBase flCurriculum, int banco, String agencia, String conta, int[] beneficios, int status, String carteira, DateTime dataadmissao, String motivo, DateTime? datademissao, int especialidade, int cargo, String usuario, String senha, int permissao)
        {
            Funcionario func;
            func = new Funcionario();

            func.Salario = salario;

            Admissao adm = new Admissao();
            adm.DataAdmissao = dataadmissao;
            adm.DataDesligamento = datademissao;
            adm.MotivoDesligamento = motivo;
            adm.UltimoSalario = ultimoSalario.ToString();
            func.Admissao = adm;

            if (beneficios != null && beneficios.Count<int>() > 0)
            {
                foreach (int beneficioId in beneficios)
                {
                    Beneficio b = facade.BuscarBeneficio(beneficioId);
                    func.Beneficios.Add(b);
                }
            }

            Cargo cg = facade.BuscarCargo(cargo);
            func.Cargo = cg;

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
            end.Bairro = bairro;

            Telefone tel = new Telefone();
            telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "");
            String ddd = telefone.Remove(1); // deixa os 2 primeiros numeros apenas
            String telStr = telefone.Remove(0, 2); // os demais numeros apenas
            tel.DDD = int.Parse(ddd);
            tel.Numero = int.Parse(telStr);
            dp.Telefones.Add(tel);

            dp.Endereco = end;
            func.DadosPessoais = dp;

            if (flCurriculum == null)
                throw new ERPException("Por favor, forneça um curriculum.");

            Curriculum curriculum = new Curriculum();
            byte[] cv = new byte[flCurriculum.ContentLength];
            flCurriculum.InputStream.Read(cv, 0, flCurriculum.ContentLength);
            curriculum.Arquivo = cv;
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

            func.Status = status;

            if (especialidade != 0 && !String.IsNullOrEmpty(crm))
            {
                // é um médico.. converter o func para médico!
                Especialidade e = facade.BuscarEspecialidade(especialidade);
                func = new Medico(func, crm, e);
            }
            return func;
        }

        private void PopularViewDataCadastro()
        {
            IEnumerable<Cargo> cargos = facade.BuscarCargos();
            IEnumerable<Beneficio> beneficios = facade.BuscarBeneficios();
            IEnumerable<Especialidade> especialidades = facade.BuscarEspecialidades();
            IEnumerable<Permissao> permissoes = facade.BuscarPermissoes();

            ViewData["Cargos"] = cargos;
            ViewData["Beneficios"] = beneficios;
            ViewData["Especialidades"] = especialidades;
            ViewData["Permissoes"] = permissoes;
        }
    }
}
