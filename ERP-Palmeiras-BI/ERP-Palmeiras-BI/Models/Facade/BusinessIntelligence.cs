using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_BI.Core;
using ERP_Palmeiras_BI.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_BI.Models.Facade
{
    public partial class BusinessIntelligence
    {
        private static volatile BusinessIntelligence instance;
        private ModelBIContainer model;

        private BusinessIntelligence() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static BusinessIntelligence GetInstance()
        {
            if (instance == null)
            {
                instance = new BusinessIntelligence();
                instance.model = new ModelBIContainer();
            }

            return instance;
        }

        public Usuario AutenticaUsuario(string username, string password)
        {
            ModelBIContainer model = new ModelBIContainer();
            IEnumerable<Usuario> result = model.TblUsuarios.Where(user => user.Login == username && user.Senha == password);

            if (result != null && result.Count<Usuario>() > 0)
                return result.First<Usuario>();
            else
                return null;

        }

    }
}
