using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public partial class RecursosHumanos
    {

        public IEnumerable<Pagamento> GetPagamentos()
        {
            ModelRH model = new ModelRH();


            IEnumerable<Pagamento> pagamentos = model.TblPagamentos.Where(p => true);


            return pagamentos;
        }

    }
}