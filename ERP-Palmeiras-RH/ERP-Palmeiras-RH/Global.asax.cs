using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ERP_Palmeiras_RH.Models;
using System.Threading;
using ERP_Palmeiras_RH.Controllers;

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
                        pagamentoFunc.Status = PagamentoController.PAGAMENTO_PENDENTE;
                        model.TblPagamentos.Add(pagamentoFunc);
                        model.SaveChanges();
                    }

                } //end foreach
                Thread.Sleep(new TimeSpan(0, 1, 0));
            
            } // end while   
        
        }

    }
}