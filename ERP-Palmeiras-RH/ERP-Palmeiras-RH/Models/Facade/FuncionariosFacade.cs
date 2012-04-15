﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using System.Data;
using ERP_Palmeiras_RH.Core;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public partial class RecursosHumanos
    {

        public void InserirFuncionario(Funcionario funcionario)
        {
            IEnumerable<Funcionario> result = model.TblFuncionarios.Where(f => f.DadosPessoais.CPF == funcionario.DadosPessoais.CPF || f.Credencial.Usuario == funcionario.Credencial.Usuario);

            if (result == null || result.Count<Funcionario>() == 0)
            {
                foreach (Beneficio b in funcionario.Beneficios)
                {
                    model.TblBeneficios.Attach(b);
                }
                model.TblFuncionarios.Add(funcionario);
            }
            else
            {
                throw new ERPException("Funcionário já cadastrado.");
            }

            model.SaveChanges();
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            model.TblFuncionarios.Attach(funcionario);
            model.Entry(funcionario).State = EntityState.Modified;
            model.SaveChanges();
        }

        public IEnumerable<Funcionario> BuscarFuncionarios()
        {
            IEnumerable<Funcionario> funcionarios = model.TblFuncionarios.Where<Funcionario>(f => true);

            return funcionarios;
        }

        public Funcionario BuscarFuncionario(int id)
        {
            try
            {
                Funcionario funcionario = model.TblFuncionarios.Single(f => f.Id == id);
                return funcionario;
            }
            catch (Exception)
            {
                throw new ERPException("Nenhum ou vários funcionários foram encontrados para o id=" + id.ToString());
            }
        }

        public Funcionario BuscarFuncionario(long cpf)
        {
            try
            {
                Funcionario funcionario = model.TblFuncionarios.Single(f => f.DadosPessoais.CPF == cpf);
                return funcionario;
            }
            catch (Exception)
            {
                throw new ERPException("Nenhum ou vários funcionários foram encontrados para o CPF=" + cpf.ToString());
            }
        }

        public Funcionario BuscarFuncionario(String login)
        {
            try
            {
                Funcionario funcionario = model.TblFuncionarios.Single(f => f.Credencial.Usuario == login);
                return funcionario;
            }
            catch (Exception)
            {
                throw new ERPException("Nenhum ou vários funcionários foram encontrados para o login=" + login.ToString());
            }
        }

        public void ExcluirTelefone(Telefone t)
        {
            Telefone tel = model.TblTelefones.Find(t.Id);
            model.TblTelefones.Remove(tel);
            model.SaveChanges();
        }

    }
}