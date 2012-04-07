using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_Palmeiras_LA.WebServices
{
    public struct EquipamentoClinicaDTO
    {
        public String NomeEquipamento;
        public String Status;
        public int Id;
        public String Fabricante;
        public String NumeroSerie;

        public EquipamentoClinicaDTO(String nome, String status, int id, String fabricante, String nSerie)
        {
            NomeEquipamento = nome;
            Status = status;
            Id = id;
            Fabricante = fabricante;
            NumeroSerie = nSerie;
        }

    }
}