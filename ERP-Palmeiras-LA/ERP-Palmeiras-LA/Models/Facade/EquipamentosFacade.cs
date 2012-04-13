using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_LA.Core;
using ERP_Palmeiras_LA.Models;
using System.Data;

namespace ERP_Palmeiras_LA.Models.Facade
{
    public partial class LogisticaAbastecimento
    {

        public Equipamento BuscarEquipamento(string nserie)
        {
            IEnumerable<Equipamento> result = model.TblEquipamentos.Where(eq => eq.NumeroSerie == nserie);
            if (result != null && result.Count<Equipamento>() > 0)
                return result.First<Equipamento>();
            else
                return null;
        }

        public Equipamento BuscarEquipamento(int id)
        {
            IEnumerable<Equipamento> result = model.TblEquipamentos.Where(eq => eq.Id == id);
            if (result != null && result.Count<Equipamento>() > 0)
                return result.First<Equipamento>();
            else
                return null;
        }

        public void AlterarEquipamento(Equipamento eq)
        {
            model.TblEquipamentos.Attach(eq);
            model.Entry(eq).State = EntityState.Modified;
            model.SaveChanges();
        }

        public void CriarEquipamento(Equipamento eq)
        {
            model.TblEquipamentos.Add(eq);
            model.SaveChanges();
        }

        public void CriarManutencao(SolicitacaoManutencao manu)
        {
            model.TblSolicitacoesManutencao.Add(manu);
            model.SaveChanges();
        }

        public IEnumerable<Equipamento> BuscarEquipamentos()
        {
            return model.TblEquipamentos.Where<Equipamento>(eq => true);
        }
    }
}