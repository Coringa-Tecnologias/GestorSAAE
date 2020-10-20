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
    public partial class CadFuncionarioForm : Form
    {
        private string opc = "";
        public CadFuncionarioForm()
        {
            InitializeComponent();
        }

        private void novo_button_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }

        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;
                case "Salvar":
                    break;
                case "Excluir":
                    break;
                case "Editar":
                    break;
                default:
                    break;
            }

        }

        private void HabilitarCampos()
        {
            nome_textBox.Enabled = true;
            funcionario_textBox.Enabled = true;
            senha_textBox.Enabled = true;
            autenticacao_comboBox.Enabled = true;
            email_textBox.Enabled = true;
            tipo_comboBox.Enabled = true;           
        }

        private void LimparCampos()
        {
            nome_textBox.Clear();
            funcionario_textBox.Clear();
            senha_textBox.Clear();
            email_textBox.Clear();
            autenticacao_comboBox.Text = "";
            tipo_comboBox.Text = "";
        }

        private void salvar_button_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
        }

        private void excluir_button_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();
        }

        private void editar_button_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();
        }
    }
}
