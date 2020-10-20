using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorSAAE.Entidades
{
    public class FuncionarioEnt
    {
        private int id;
        private string nome;
        private string funcionario;
        private string senha;
        private bool autenticacao;
        private string email;
        private int tipo;


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
        public string Funcionario 
        { 
            get => funcionario; 
            set => funcionario = value; 
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
        public string Email 
        { 
            get => email; 
            set => email = value; 
        }
        public int Tipo 
        { 
            get => tipo;
            set => tipo = value; 
        }
    }
}
