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

        RecursosHumanos facade = RecursosHumanos.GetInstance();

        public ActionResult CadastrarCenario()
        {
            Permissao p = new Permissao();
            p.Nome = "Administrador";
            facade.InserirPermissao(p);

            Cargo c = new Cargo();
            c.Nome = "Médico";
            c.SalarioBase = 2000;

            Beneficio b1 = new Beneficio();
            b1.Nome = "Vale-Refeição";
            b1.Valor = 300;
            facade.InserirBeneficio(b1);

            Beneficio b2 = new Beneficio();
            b2.Nome = "Vale-Transporte";
            b2.Valor = 300;
            facade.InserirBeneficio(b2);

            Especialidade e1 = new Especialidade();
            e1.Nome = "Urologia";
            facade.InserirEspecialidade(e1);

            Especialidade e2 = new Especialidade();
            e2.Nome = "Pediatria";
            facade.InserirEspecialidade(e2);

            return RedirectToAction("CadastrarMedico");
        }

        public ActionResult CadastrarMedico()
        {
            facade.InserirFuncionario(CriarMedico());

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

            Permissao p = facade.BuscarPermissoes().First<Permissao>();
            func.Permissao = p;

            DadoBancario db = new DadoBancario();
            db.Agencia = rd.Next().ToString().ToLower() + "-2";
            db.Banco = 231;
            db.ContaCorrente = rd.Next().ToString().ToLower() + "-97";
            func.DadosBancarios = db;

            func.Status = 1;
            func.CRM = "CRMSP-" + rd.Next().ToString().ToLower();
            func.Especialidade = facade.BuscarEspecialidades().First<Especialidade>();

            func.CartaoPonto = new CartaoPonto();

            return func;
        }

    }
}
