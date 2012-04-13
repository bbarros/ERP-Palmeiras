using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Web;
using ERP_Palmeiras_BI.Models;

namespace ERP_Palmeiras_BI.Controllers
{
    /// <summary>
    /// Gerenciador (Singleton) da sessão atual do usuário.
    /// </summary>
    public class GerenciadorDeSessao
    {
        private static volatile GerenciadorDeSessao uniqueInstance;
        private const String USR_SESSION_KEY = "Usuario";

        /// <summary>
        /// Retorna verdadeiro se a sessão está ativa.
        /// </summary>
        public bool SessaoAtiva
        {
            get { return (HttpContext.Current.Session[USR_SESSION_KEY] != null); }
        }

        /// <summary>
        /// Retorna o usuário associado a sessão atual.
        /// </summary>
        public Usuario Usuario
        {
            get { return (Usuario)HttpContext.Current.Session[USR_SESSION_KEY]; }
            set { HttpContext.Current.Session[USR_SESSION_KEY] = value; }
        }

        /// <summary>
        /// Construtor privado.
        /// </summary>
        private GerenciadorDeSessao()
        {

        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static GerenciadorDeSessao GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new GerenciadorDeSessao();
            }

            return uniqueInstance;
        }
    }
}
