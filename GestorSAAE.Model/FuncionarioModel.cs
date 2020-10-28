﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestorSAAE.DAO;
using GestorSAAE.Entidades;

namespace GestorSAAE.Model
{
    public class FuncionarioModel
    {
        public static bool Inserir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Inserir(objTabela);
        }

        public List<FuncionarioEnt> Lista()
        {
            return new FuncionarioDAO().Lista();
        }

        public FuncionarioEnt Login(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Login(objTabela);
        }

        public List<FuncionarioEnt> Lista(string campo, FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Lista(campo, objTabela);
        }

        public List<FuncionarioEnt> Exibir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Exibe(objTabela);
        }
    }
}
