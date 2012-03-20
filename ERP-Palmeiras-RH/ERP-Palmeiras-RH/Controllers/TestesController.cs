using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;

namespace ERP_Palmeiras_RH.Controllers
{
    public class TestesController : Controller
    {
        //
        // GET: /Testes/

        PermissoesFacade permissoesFacade = PermissoesFacade.GetInstance();
        EspecialidadesFacade especFacade = EspecialidadesFacade.GetInstance();
        FuncionariosFacade funcFacade = FuncionariosFacade.GetInstance();
        CargosFacade cargosFacade = CargosFacade.GetInstance();
        BeneficiosFacade beneficiosFacade = BeneficiosFacade.GetInstance();

        public ActionResult CadastrarCenario()
        {
            Permissao p1 = new Permissao();
            p1.Nome = "Administrador";
            permissoesFacade.InserirPermissao(p1);

            Permissao p2 = new Permissao();
            p2.Nome = "Convidado";
            permissoesFacade.InserirPermissao(p2);

            Cargo c1 = new Cargo();
            c1.Nome = "Médico";
            c1.SalarioBase = 2000;
            cargosFacade.InserirCargo(c1);

            Cargo c2 = new Cargo();
            c2.Nome = "Gerente RH";
            c2.SalarioBase = 5000;
            cargosFacade.InserirCargo(c2);

            Beneficio b1 = new Beneficio();
            b1.Nome = "Vale-Refeição";
            b1.Valor = 300;
            beneficiosFacade.InserirBeneficio(b1);

            Beneficio b2 = new Beneficio();
            b2.Nome = "Vale-Transporte";
            b2.Valor = 300;
            beneficiosFacade.InserirBeneficio(b2);

            Especialidade e1 = new Especialidade();
            e1.Nome = "Urologia";
            especFacade.InserirEspecialidade(e1);

            Especialidade e2 = new Especialidade();
            e2.Nome = "Pediatria";
            especFacade.InserirEspecialidade(e2);

            return RedirectToAction("CadastrarMedico");
        }

        public ActionResult CadastrarMedico()
        {
            funcFacade.InserirFuncionario(CriarMedico());

            return RedirectToAction("Index", "Funcionarios");
        }

        private Medico CriarMedico()
        {
            Medico func;
            func = new Medico();

            func.Ramal = 12;
            func.Salario = 2000;

            Admissao adm = new Admissao();
            adm.DataAdmissao = new DateTime(1967, 9, 12);
            adm.DataDesligamento = null;
            adm.MotivoDesligamento = null;
            adm.UltimoSalario = null;
            func.Admissao = adm;

            IEnumerable<Beneficio> beneficios = beneficiosFacade.BuscarBeneficios();
            foreach (Beneficio b in beneficios)
            {
                func.Beneficios.Add(b);
            }

            Cargo cg = cargosFacade.BuscarCargos().First<Cargo>();
            func.Cargo = cg;

            Random rd = new Random();

            DadoPessoal dp = new DadoPessoal();
            int sulfixNome = rd.Next();
            dp.Nome = "João" + sulfixNome;
            dp.RG = rd.Next();
            dp.Sexo = "Masculino";
            dp.Sobrenome = "Marcelo";
            dp.CPF = rd.Next();
            dp.DataNascimento = new DateTime(1967, 9, 12);
            dp.Email = "joao" + sulfixNome.ToString() + "@gmail.com";
            dp.CLT = rd.Next().ToString();

            Endereco end = new Endereco();
            end.Rua = "Rua dos Bobos";
            end.Pais = "Brasil";
            end.Numero = rd.Next();
            end.Estado = "SP";
            end.CEP = "02878-982";
            end.Complemento = "";
            end.Cidade = "São Paulo";
            end.Bairro = "Vila Leopoldina";

            Telefone tel = new Telefone();
            String ddd = "11";
            String telStr = "72629282";
            tel.DDD = int.Parse(ddd);
            tel.Numero = int.Parse(telStr);
            dp.Telefones.Add(tel);

            dp.Endereco = end;
            func.DadosPessoais = dp;

            Curriculum curriculum = new Curriculum();
            byte[] cv = new byte[1000];
            curriculum.Arquivo = cv;
            curriculum.Formacao = "Urologia";
            func.Curriculum = curriculum;

            Credencial c = new Credencial();
            c.Senha = "123mudar";
            c.Usuario = "joao" + sulfixNome.ToString();
            func.Credencial = c;

            Permissao p = permissoesFacade.BuscarPermissoes().First<Permissao>();
            func.Permissao = p;

            DadoBancario db = new DadoBancario();
            db.Agencia = rd.Next().ToString().ToLower() + "-2";
            db.Banco = 231;
            db.ContaCorrente = rd.Next().ToString().ToLower() + "-97";
            func.DadosBancarios = db;

            func.Status = 1;
            func.CRM = "CRMSP-" + rd.Next().ToString().ToLower();
            func.Especialidade = especFacade.BuscarEspecialidades().First<Especialidade>();

            func.CartaoPonto = new CartaoPonto();

            return func;
        }

    }
}
