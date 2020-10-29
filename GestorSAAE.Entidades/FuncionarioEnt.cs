using System.Drawing;

namespace GestorSAAE.Entidades
{
    /// <summary>
    /// Dados do Funcionário.
    /// </summary>
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
        private Image qrContato;

        /// <summary>
        /// Código do funcionário.
        /// </summary>
        public int Codigo 
        { 
            get => codigo; 
            set => codigo = value; 
        }

        /// <summary>
        /// Nome do funcionário.
        /// </summary>
        public string Nome 
        { 
            get => nome; 
            set => nome = value; 
        }

        /// <summary>
        /// Identificador do funcionário (é a identificação que o funcionário usa ao acessar o sistema.
        /// </summary>
        public string Identificador 
        { 
            get => identificador; 
            set => identificador = value; 
        }

        /// <summary>
        /// Senha do funcionário para acessar o sistema.
        /// </summary>
        public string Senha 
        { 
            get => senha; 
            set => senha = value; 
        }

        /// <summary>
        /// Definição se o funcionário quer usar uma camada de autenticação ao acessar o sistema.
        /// </summary>
        public bool Autenticacao 
        { 
            get => autenticacao; 
            set => autenticacao = value; 
        }

        /// <summary>
        /// Email do funcionário.
        /// </summary>
        public string Email 
        { 
            get => email; 
            set => email = value; 
        }

        /// <summary>
        /// Tipo de funcionário, Administrador com acesso completo ao sistema, ou Usuário com acesso limitado ao sistema.
        /// </summary>
        public int Tipo 
        { 
            get => tipo;
            set => tipo = value; 
        }

        /// <summary>
        /// Celular do funcionário.
        /// </summary>
        public string Celular 
        { 
            get => celular; 
            set => celular = value; 
        }

        /// <summary>
        /// Contato do funcionário.
        /// </summary>
        public Image QrContato
        {
            get => qrContato; 
            set => qrContato = value; 
        }
    }
}
