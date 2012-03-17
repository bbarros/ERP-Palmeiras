using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.WebServices
{
    public class EspecialidadeDTO
    {
        public String Nome;

        public EspecialidadeDTO(String nome)
        {
            Nome = nome;
        }

        public EspecialidadeDTO() { }
    }
}