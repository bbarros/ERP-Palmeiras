using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.Models
{
    public partial class Telefone
    {
        public override String ToString()
        {
            return "(" + this.DDD + ")" + this.Numero.ToString().Substring(0, 4) + "-" + this.Numero.ToString().Substring(3);
        }
    }
}