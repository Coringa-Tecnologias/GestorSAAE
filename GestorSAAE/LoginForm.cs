using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorSAAE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpar_button_Click(object sender, EventArgs e)
        {
            id_textBox.Clear();
            senha_maskedTextBox.Clear();
            id_textBox.Focus();
        }

        private void entrar_button_Click(object sender, EventArgs e)
        {
            ///Autenticar com aplicativo de QrCode do usuário
            if(autenticar_checkBox.Checked)
            {

            }
            ///Entrar sem autenticação
            else
            {

            }
        }
    }
}
