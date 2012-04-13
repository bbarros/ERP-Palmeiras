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

        public void CriarEquipamentoClinica(Equipamento e)
        {
            e = model.TblEquipamentos.Attach(e);
            EquipamentoClinica ec = new EquipamentoClinica();
            ec.Equipamento = e;
            ec.Status = StatusEquipamento.FUNCIONANDO;
            model.TblEquipamentosClinica.Add(ec);
            model.SaveChanges();
        }

        public void AlterarEquipamentoClinica(EquipamentoClinica c)
        {
            model.TblEquipamentosClinica.Attach(c);
            model.Entry(c).State = EntityState.Modified;
            model.SaveChanges();
        }

        public EquipamentoClinica BuscarEquipamentoClinica(int id)
        {
            return model.TblEquipamentosClinica.Find(id);
        }

        public IEnumerable<EquipamentoClinica> BuscarEquipamentosClinica()
        {
            return model.TblEquipamentosClinica.Where<EquipamentoClinica>(c => true);
        }

        public IEnumerable<EquipamentoClinica> BuscarEquipamentosClinica(StatusEquipamento status)
        {
            return model.TblEquipamentosClinica.Where<EquipamentoClinica>(c => c.Status.Value == (int)status);
        }

        public void ExcluirEquipamentoClinica(int id)
        {
            EquipamentoClinica s = BuscarEquipamentoClinica(id);
            try
            {
                model.TblEquipamentosClinica.Remove(s);
                model.SaveChanges();
            }
            catch (Exception)
            {
                throw new ERPException("Não foi possível remover o equipamento da clínica.");
            }
        }
    }
}