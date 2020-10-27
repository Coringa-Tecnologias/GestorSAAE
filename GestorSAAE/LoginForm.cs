using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestorSAAE.Model;
using GestorSAAE.Entidades;

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
            try
            {
                FuncionarioEnt obj = new FuncionarioEnt();
                obj.Identificador = id_textBox.Text;
                obj.Senha = senha_maskedTextBox.Text;

                obj = new FuncionarioModel().Login(obj);

                if(obj.Identificador == null)
                {
                    MessageBox.Show("Usuário e/ou senha não encontrado(s)!",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    limpar_button_Click(sender, e);
                }
                else
                {
                    CadFuncionarioForm form = new CadFuncionarioForm();
                    this.Hide();
                    form.Show();

                    /////Autenticar com aplicativo de QrCode do usuário
                    //if (autenticar_checkBox.Checked)
                    //{

                    //}
                    /////Entrar sem autenticação
                    //else
                    //{

                    //}
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de logon, entre em contato com o suporte! \n\n" + ex.Message,
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            
        }
    }
}
