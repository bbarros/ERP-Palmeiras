using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public class PagamentoFacade
    {
        private static volatile PagamentoFacade instance;

        private PagamentoFacade() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static PagamentoFacade GetInstance()
        {
            if (instance == null)
            {
                instance = new PagamentoFacade();
            }

            return instance;
        }

        public IEnumerable<Pagamento> GetPagamentos()
        {
            ModelRH model = new ModelRH();

            IEnumerable<Pagamento> pagamentos = model.TblPagamentos.Where(p => p.DataPagamento <= DateTime.Now);

            return pagamentos;
        }

    }
}