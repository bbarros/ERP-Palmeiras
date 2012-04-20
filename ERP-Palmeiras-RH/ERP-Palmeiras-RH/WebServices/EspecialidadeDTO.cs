using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_RH.WebServices
{
    public class EspecialidadeDTO
    {
        public String Nome;
        public Int32 Id;

        public EspecialidadeDTO(String nome, Int32 id)
        {
            Nome = nome;
            Id = id;
        }

        public EspecialidadeDTO() { }
    }
}