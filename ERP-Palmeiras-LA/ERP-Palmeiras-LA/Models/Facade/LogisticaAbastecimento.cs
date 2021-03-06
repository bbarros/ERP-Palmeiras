﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using ERP_Palmeiras_LA.Core;
using ERP_Palmeiras_LA.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;

namespace ERP_Palmeiras_LA.Models.Facade
{
    public partial class LogisticaAbastecimento
    {
        private static volatile LogisticaAbastecimento instance;
        private ModelLAContainer model;
        RecursosHumanos.UsuariosWSSoapClient rhClient;
        Financeiro.MedSoftSoapClient finClient;
        Operacional.ControleUsuariosSoapClient opClient;
        BusinessIntelligence.UsuariosWSSoapClient biClient;

        private LogisticaAbastecimento() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static LogisticaAbastecimento GetInstance()
        {
            if (instance == null)
            {
                instance = new LogisticaAbastecimento();
                instance.model = new ModelLAContainer();
                instance.rhClient = new RecursosHumanos.UsuariosWSSoapClient();
                instance.finClient = new Financeiro.MedSoftSoapClient();
                instance.opClient = new Operacional.ControleUsuariosSoapClient();
                instance.biClient = new BusinessIntelligence.UsuariosWSSoapClient();
            }

            return instance;
        }

        public Usuario AutenticaUsuario(string username, string password)
        {
            ModelLAContainer model = new ModelLAContainer();
            IEnumerable<Usuario> result = model.TblUsuarios.Where(user => user.Login == username && user.Senha == password);

            if (result != null && result.Count<Usuario>() > 0)
                return result.First<Usuario>();
            else 
                 return null;

        }

    }
}
