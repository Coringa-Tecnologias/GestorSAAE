using GestorSAAE.Entidades;
using GestorSAAE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorSAAE.View

{
    public partial class LocalizarForm : Form
    {
        public LocalizarForm()
        {
            InitializeComponent();
        }

        private void ListarGrid()
        {
            try
            {
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                lista = new FuncionarioModel().Lista();
                localizar_dataGridView.AutoGenerateColumns = false;
                localizar_dataGridView.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar Dados " + ex.Message);
            }
        }

        private void filtrar_button_Click(object sender, EventArgs e)
        {
            if(codigo_textBox.Text.Trim() == "" &&
                nome_textBox.Text.Trim() == "" &&
                email_textBox.Text.Trim() == "")
            {
                ListarGrid();
            }

            MessageBox.Show(localizar_tabControl.TabPages.ToString());
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codigo_textBox_Leave(object sender, EventArgs e)
        {
            filtrar_button_Click(sender, e);
        }

        private void nome_textBox_Leave(object sender, EventArgs e)
        {
            filtrar_button_Click(sender, e);
        }

        private void email_textBox_Leave(object sender, EventArgs e)
        {
            filtrar_button_Click(sender, e);
        }
    }
}
