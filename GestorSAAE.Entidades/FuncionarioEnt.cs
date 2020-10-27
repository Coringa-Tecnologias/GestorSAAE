using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GestorSAAE.Entidades
{
    public class FuncionarioEnt
    {
        private int codigo;
        private string nome;
        private string identificador;
        private string senha;
        private bool autenticacao;
        private string celular;
        private string email;
        private int tipo;

        public int Codigo 
        { 
            get => codigo; 
            set => codigo = value; 
        }
        public string Nome 
        { 
            get => nome; 
            set => nome = value; 
        }
        public string Identificador 
        { 
            get => identificador; 
            set => identificador = value; 
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
        public string Celular 
        { 
            get => celular; 
            set => celular = value; 
        }
    }
}
