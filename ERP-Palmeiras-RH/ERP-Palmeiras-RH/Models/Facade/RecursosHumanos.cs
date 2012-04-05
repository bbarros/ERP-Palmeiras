using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_RH.Core;
using ERP_Palmeiras_RH.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public partial class RecursosHumanos
    {
        private static volatile RecursosHumanos instance;
        private ModelRH model;

        private RecursosHumanos() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static RecursosHumanos GetInstance()
        {
            if (instance == null)
            {
                instance = new RecursosHumanos();
                instance.model = new ModelRH();
            }

            return instance;
        }

        public Funcionario AutenticaUsuario(string user, string password)
        {
            ModelRH model = new ModelRH();
            IEnumerable<Funcionario> result = model.TblFuncionarios.Where(f => f.Credencial.Usuario == user && f.Credencial.Senha == password);

            if (result != null && result.Count<Funcionario>() > 0)
                return result.First<Funcionario>();
            else 
                 return null;

        }

        public EntradasCartaoPonto BuscarEntrada(Int32 id)
        {
            try
            {
                Funcionario funcionario = model.TblFuncionarios.Single(f => f.Id == id);
                EntradasCartaoPonto cartao = model.TblEntradasCartaoPonto.First(c => c.cartoesPontoId == funcionario.CartaoPonto.Id && c.Saida == 0 );
                return cartao;
            }
            catch (Exception)
            {
                throw new ERPException("Não foi encontrada a entrada desse Funcionário. Registre a entrada ante da saida");
            }
        }



        public void InserirEntrada(Int32 id, DateTime tempo)
        {
            ModelRH model = new ModelRH();

            Funcionario funcionario = BuscarFuncionario(id);
            EntradasCartaoPonto ecp = new EntradasCartaoPonto();
            ecp.cartoesPontoId = funcionario.CartaoPonto.Id;
            ecp.Entrada = tempo.Ticks;

   
            //funcionario.CartaoPonto.EntradasPonto.Add(ecp);
            model.TblEntradasCartaoPonto.Add(ecp);

            model.SaveChanges();

        }

        public void InserirSaida(Int32 id, DateTime tempo)
        {

            Funcionario funcionario = BuscarFuncionario(id);
            EntradasCartaoPonto cartao = BuscarEntrada(id);

            model.TblEntradasCartaoPonto.Attach(cartao);

            cartao.Saida = tempo.Ticks;

          
            model.Entry(cartao).State = EntityState.Modified;
            model.SaveChanges();
               

        }


    }
}
