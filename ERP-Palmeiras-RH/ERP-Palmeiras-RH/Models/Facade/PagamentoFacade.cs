using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using System.Data;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public partial class RecursosHumanos
    {

        public IEnumerable<Pagamento> GetPagamentos()
        {
            IEnumerable<Pagamento> pagamentos = model.TblPagamentos.Where(p => true);
            return pagamentos;
        }

        public Pagamento GetPagamento(int id)
        {
            Pagamento pagamento = model.TblPagamentos.Find(id);
            return pagamento;
        }

        public void UpdatePagamento(Pagamento pagamento)
        {
            model.Entry(pagamento).State = EntityState.Modified;
            model.SaveChanges();
        }
    }
}