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

    }
}
