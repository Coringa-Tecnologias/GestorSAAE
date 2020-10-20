using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorSAAE.Entidades
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string usuario;
        private string senha;
        private bool autenticacao;

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string Nome 
        { 
            get => nome; 
            set => nome = value; 
        }
        public string Usuario 
        { 
            get => usuario; 
            set => usuario = value; 
        }
        public string Senha 
        { 
            get => senha; 
            set => senha = value; 
        }
        public bool Autenticacao 
        { 
            get => autenticacao; 
            set => autenticacao = value; 
        }
    }
}
