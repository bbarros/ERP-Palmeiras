using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.Models
{
    public partial class Endereco
    {
        public override string ToString()
        {
            return this.Rua + ", " + this.Numero.ToString() + " - " + this.Cidade + "/" + this.Estado;
        }
    }
}