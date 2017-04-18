﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolhadePagamento.Model;

namespace FolhadePagamento.DAL
{
    class FuncionarioDao
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (BuscarFuncionarioPorCPF(funcionario) != null)
            {
                return false;
            }
            funcionarios.Add(funcionario);
            return true;
        }

        public static Funcionario BuscarFuncionarioPorCPF(Funcionario funcionario)
        {
            foreach (Funcionario funcionarioCadastrado in funcionarios)
            {
                if (funcionario.Cpf.Equals(funcionarioCadastrado.Cpf))
                {
                    return funcionarioCadastrado;
                }
            }
            return null;
        }

        public static List<Funcionario> RetornarLista()
        {
            return funcionarios;
        }
    }
}
