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
        public List<FuncionarioEnt> funcionario;
        FuncionarioEnt objTabela = new FuncionarioEnt();
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
            exibir_button.Enabled = false;

            if (codigo_textBox.Text.Trim() == "" &&
                nome_textBox.Text.Trim() == "" &&
                email_textBox.Text.Trim() == "")
            {
                ListarGrid();
            }
            else
            {
                try
                {
                    if (localizar_tabControl.SelectedTab.Text == "Código")
                        objTabela.Codigo = Int32.Parse(codigo_textBox.Text);
                    else if (localizar_tabControl.SelectedTab.Text == "Nome")
                        objTabela.Nome = nome_textBox.Text.Trim();
                    else if (localizar_tabControl.SelectedTab.Text == "E-mail")
                        objTabela.Email = email_textBox.Text.Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valor inválido! Se você estiver digitando um código, digite um valor numérico inteiro.",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    codigo_textBox.Clear();
                    codigo_textBox.Focus();
                }
                ListarGrid(localizar_tabControl.SelectedTab.Text);
                if (localizar_dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum funcionário encontrado!",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Refresh();
                }
            }
        }

        private void ListarGrid(string campo)
        {
            try
            {
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                lista = new FuncionarioModel().Lista(campo, objTabela);
                localizar_dataGridView.AutoGenerateColumns = false;
                localizar_dataGridView.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar Dados " + ex.Message);
            }
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

        private void exibir_button_Click(object sender, EventArgs e)
        {
            try
            {
                objTabela.Codigo = Convert.ToInt32(codigo_textBox.Text);
                funcionario = new List<FuncionarioEnt>();
                funcionario = new FuncionarioModel().Exibir(objTabela);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar Dados " + ex.Message);
            }
            finally
            {
                this.Hide();
            }
        }

        private void localizar_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_textBox.Text = localizar_dataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_textBox.Text = localizar_dataGridView.CurrentRow.Cells[1].Value.ToString();
            email_textBox.Text = localizar_dataGridView.CurrentRow.Cells[3].Value.ToString();
            exibir_button.Enabled = true;
        }

        private void localizar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            exibir_button_Click(sender, e);
        }
    }
}
