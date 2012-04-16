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

        public Usuario BuscarUsuario(string login)
        {
            IEnumerable<Usuario> result = model.TblUsuarios.Where(user => user.Login == login);
            if (result != null && result.Count<Usuario>() > 0)
                return result.First<Usuario>();
            else
                return null;
        }

        public Usuario BuscarUsuario(int id)
        {
            IEnumerable<Usuario> result = model.TblUsuarios.Where(user => user.Id == id);
            if (result != null && result.Count<Usuario>() > 0)
                return result.First<Usuario>();
            else
                return null;
        }

        public void AlterarUsuario(int id, string login, string senha)
        {
            IEnumerable<Usuario> result = model.TblUsuarios.Where(user => user.Id == id);
            if (result != null && result.Count<Usuario>() > 0)
            {
                Usuario user = result.First<Usuario>();
                String loginAntigo = user.Login;
                user.Login = login;
                user.Senha = senha;
                model.Entry(user).State = EntityState.Modified;
                model.SaveChanges();
                rhClient.AlterarUsuario(user.Login, loginAntigo, user.Senha);
                opClient.AlterarUsuario(user.Login, loginAntigo, user.Senha);
            }
            else
                throw new ERPException("Usuário " + login + " não encontrado.");
        }

        public void CriarUsuario(Usuario user, bool requestOtherModules)
        {
            model.TblUsuarios.Add(user);
            model.SaveChanges();
            rhClient.InserirUsuario(user.Login, user.Senha);
            opClient.InserirUsuario(user.Login, user.Senha, 0);
        }

        public IEnumerable<Usuario> BuscarUsuarios()
        {
            return model.TblUsuarios.Where<Usuario>(user => true);
        }
    }
}