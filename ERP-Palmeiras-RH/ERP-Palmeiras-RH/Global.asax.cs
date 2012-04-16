using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ERP_Palmeiras_RH.Models;
using System.Threading;
using ERP_Palmeiras_RH.Controllers;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Core;

namespace ERP_Palmeiras_RH
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            RecursosHumanos facade = RecursosHumanos.GetInstance();
            Funcionario f = null;
            try
            {
                f = facade.BuscarFuncionario("admin-rh");
            }
            catch (ERPException)
            {
                // cria o admin
                f = CriarAdminRH();
                facade.InserirFuncionario(f, false);
            }

            // Inicia Thread Periódica para geração de ordens de pagamentos de salários
            Thread geraOrdemPag = new Thread(GeraOrdemPagamento);
            geraOrdemPag.Start();
        }

        private void GeraOrdemPagamento()
        {
            while (true)
            {
                ModelRH model = new ModelRH();
                DateTime current = DateTime.Now;
                DateTime firstDayMonth = new DateTime(current.Year, current.Month, 1);

                IList<Funcionario> listaFuncionarios = model.TblFuncionarios.Where(f => true).ToList<Funcionario>();

                foreach (Funcionario funcionario in listaFuncionarios)
                {
                    IEnumerable<Pagamento> listaPagamentoFunc = model.TblPagamentos.Where(p => p.DataOrdem <= current.Ticks
                                                                            && p.DataOrdem >= firstDayMonth.Ticks
                                                                            && p.funcionariosId == funcionario.Id);

                    if (listaPagamentoFunc == null || listaPagamentoFunc.Count<Pagamento>() == 0)
                    {
                        Pagamento pagamentoFunc = new Pagamento();
                        pagamentoFunc.Funcionario = funcionario;
                        pagamentoFunc.Cargo = funcionario.Cargo.Nome;
                        pagamentoFunc.Salario = funcionario.Salario;
                        pagamentoFunc.DataOrdem = current.Ticks;
                        pagamentoFunc.Status = RecursosHumanos.PAGAMENTO_PENDENTE;
                        model.TblPagamentos.Add(pagamentoFunc);
                        model.SaveChanges();
                    }

                } //end foreach
                Thread.Sleep(new TimeSpan(0, 1, 0));
            
            } // end while   
        
        }

        private Funcionario CriarAdminRH()
        {
            RecursosHumanos facade = RecursosHumanos.GetInstance();
            Funcionario func;
            func = new Funcionario();

            func.Ramal = 0;
            func.Salario = 0;

            Admissao adm = new Admissao();
            DateTime DataAdmissao = new DateTime(1967, 9, 12);
            adm.DataAdmissao = DataAdmissao.Ticks;
            adm.DataDesligamento = null;
            adm.MotivoDesligamento = null;
            adm.UltimoSalario = null;
            func.Admissao = adm;

            Cargo cg = new Cargo();
            cg.Nome = "Admin-RH";
            cg.SalarioBase = 0;
            facade.InserirCargo(cg);
            func.CargoId = facade.BuscarCargos().First<Cargo>(cargo => cargo.Nome == "Admin-RH").Id;

            Random rd = new Random();

            DadoPessoal dp = new DadoPessoal();
            int sulfixNome = rd.Next();
            dp.Nome = "Admin";
            dp.RG = rd.Next();
            dp.Sexo = "Masculino";
            dp.Sobrenome = "RH";
            dp.CPF = rd.Next();
            DateTime DataNascimento = new DateTime(1967, 9, 12);
            dp.DataNascimento = DataNascimento.Ticks;
            dp.Email = "adminrh@sepsystems.com";
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
            String telStr = "1111-1111";
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
            c.Senha = "admin";
            c.Usuario = "admin-rh";
            func.Credencial = c;

            Permissao p = new Permissao();
            p.Nome = "Administrador do Sistema";
            facade.InserirPermissao(p);
            func.PermissaoId = facade.BuscarPermissoes().First<Permissao>(permissao => permissao.Nome == "Administrador do Sistema").Id;

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