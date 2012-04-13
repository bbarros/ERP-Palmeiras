using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Palmeiras_RH.Models;
using ERP_Palmeiras_RH.Models.Facade;
using ERP_Palmeiras_RH.Core;


namespace ERP_Palmeiras_RH.Controllers
{
    [HandleERPException]
    public class PagamentoController : BaseController
    {

        public const int PAGAMENTO_OK = 1;
        public const int PAGAMENTO_PENDENTE = 2;
        public const int PAGAMENTO_EM_AVALIACAO = 3;

        public ActionResult Index()
        {
            RecursosHumanos facade = RecursosHumanos.GetInstance();

            IEnumerable<Pagamento> pagamentos = facade.GetPagamentos();
            ViewBag.pagamentos = pagamentos;

            return View();
        }

        public ActionResult Pagar()
        {
            return View();
        }

        public ActionResult Confirmar(Int32 pag)
        {
            RecursosHumanos facade = RecursosHumanos.GetInstance();
            Pagamento pagamento = facade.GetPagamento(pag);

            ViewBag.pagamento = pagamento;

            return View();
        }

        public ActionResult Salvar(Int32 pag, Double acrescimo, Double desconto, Double imposto, Double total, String info)
        {
            RecursosHumanos facade = RecursosHumanos.GetInstance();
            Pagamento pagamento = facade.GetPagamento(pag);

            pagamento.Adicionais = acrescimo;
            pagamento.Descontos = desconto;
            pagamento.Impostos = imposto;
            pagamento.Total = total;
            pagamento.Informacoes = info;

            facade.UpdatePagamento(pagamento);

            return View();
        }

        public ActionResult Enviar(Int32 pag, Double acrescimo, Double desconto, Double imposto, Double total, String info)
        {
            RecursosHumanos facade = RecursosHumanos.GetInstance();
            Pagamento pagamento = facade.GetPagamento(pag);

            pagamento.Adicionais = acrescimo;
            pagamento.Descontos = desconto;
            pagamento.Impostos = imposto;
            pagamento.Total = total;
            pagamento.Informacoes = info;

            facade.UpdatePagamento(pagamento);

            Boolean ack = false;
            try
            {
                // Acionar webservice do financeiro que solicita pagamento de salário
                ack = true;
            }
            catch
            {
                ack = false;
            }

            if (ack)
            {
                pagamento.Status = PagamentoController.PAGAMENTO_EM_AVALIACAO;
                facade.UpdatePagamento(pagamento);
            }

            ViewBag.resposta = ack;

            return View();
        }
    
    }
}
