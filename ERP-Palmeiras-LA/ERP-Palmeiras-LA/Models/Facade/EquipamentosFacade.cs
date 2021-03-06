﻿using System;
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

        public SolicitacaoManutencao BuscarManutencao(int id)
        {
            IEnumerable<SolicitacaoManutencao> result = model.TblSolicitacoesManutencao.Where(eq => eq.Id == id);
            if (result != null && result.Count<SolicitacaoManutencao>() > 0)
                return result.First<SolicitacaoManutencao>();
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
            Equipamento e = BuscarEquipamento(eq.NumeroSerie);
            if (e != null)
                throw new ERPException("Equipamento com número de série: " + eq.NumeroSerie + " já cadastrado.");
            model.TblEquipamentos.Add(eq);
            model.SaveChanges();
        }

        public void CriarManutencao(SolicitacaoManutencao manu)
        {
            model.TblSolicitacoesManutencao.Add(manu);
            model.SaveChanges();
            EnviarSolicitacaoManutencao(manu);
        }

        public void EnviarSolicitacaoManutencao(SolicitacaoManutencao manu)
        {
            bool success = finClient.pagarManutencao(
                new DateTime(manu.DataPrevista),
                manu.Custo,
                manu.Motivo,
                manu.EquipamentoClinica.Equipamento.Fabricante.Banco.ToString(),
                manu.EquipamentoClinica.Equipamento.Fabricante.Agencia,
                manu.EquipamentoClinica.Equipamento.Fabricante.ContaCorrente,
                manu.Id);
            if (success)
            {
                manu.Status = StatusSolicitacaoManutencao.EM_PROGRESSO;
            }
            else
            {
                manu.Status = StatusSolicitacaoManutencao.PENDENTE;
            }
        }

        public void AlterarManutencao(SolicitacaoManutencao manu)
        {
            model.TblSolicitacoesManutencao.Attach(manu);
            model.Entry(manu).State = EntityState.Modified;
            model.SaveChanges();
        }

        public IEnumerable<Equipamento> BuscarEquipamentos()
        {
            return model.TblEquipamentos.Where<Equipamento>(eq => true);
        }

        public IEnumerable<SolicitacaoManutencao> BuscarManutencao()
        {
            return model.TblSolicitacoesManutencao.Where<SolicitacaoManutencao>(eq => true);
        }
    }
}