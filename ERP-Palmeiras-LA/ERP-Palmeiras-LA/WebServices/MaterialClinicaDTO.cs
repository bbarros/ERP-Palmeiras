using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.WebServices
{
    public struct MaterialClinicaDTO
    {
        public String NomeMaterial;
        public int Id;
        public String Fabricante;
        public String Codigo;
        public String Descricao;
        public int QuantidadeEstoque;

        public MaterialClinicaDTO(String nome, int id, String fabricante, String cod, String descricao, int qEstoque)
        {
            NomeMaterial = nome;
            Id = id;
            Fabricante = fabricante;
            Codigo = cod;
            Descricao = descricao;
            QuantidadeEstoque = qEstoque;
        }

    }
}