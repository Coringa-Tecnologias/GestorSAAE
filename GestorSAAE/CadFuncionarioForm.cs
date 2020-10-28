using GestorSAAE.View;
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
    public partial class CadFuncionarioForm : Form
    {
        FuncionarioEnt objTabela = new FuncionarioEnt();
        bool novo = false;
        
        private string opc = "";
        public CadFuncionarioForm()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            nome_textBox.Enabled = true;
            identificador_textBox.Enabled = true;
            senha_textBox.Enabled = true;
            autenticacao_comboBox.Enabled = true;
            email_textBox.Enabled = true;
            tipo_comboBox.Enabled = true;
            celular_maskedTextBox.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            nome_textBox.Enabled = false;
            identificador_textBox.Enabled = false;
            senha_textBox.Enabled = false;
            autenticacao_comboBox.Enabled = false;
            email_textBox.Enabled = false;
            tipo_comboBox.Enabled = false;
            celular_maskedTextBox.Enabled = false;
        }

        private void LimparCampos()
        {
            codigo_label1.Text = "";
            nome_textBox.Clear();
            identificador_textBox.Clear();
            senha_textBox.Clear();
            email_textBox.Clear();
            autenticacao_comboBox.Text = "";
            tipo_comboBox.Text = "";
            celular_maskedTextBox.Clear();
        }

        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    nome_textBox.Focus();
                    break;
                case "Salvar":
                    try
                    {
                        if (novo)
                        {
                            if (identificador_textBox.Text.Trim() != "" &&
                            senha_textBox.Text.Trim() != "")
                            {
                                objTabela.Nome = nome_textBox.Text.Trim();
                                objTabela.Identificador = identificador_textBox.Text.Trim();
                                objTabela.Senha = senha_textBox.Text.Trim();
                                if (autenticacao_comboBox.Text == "Sim")
                                    objTabela.Autenticacao = true;
                                else
                                    objTabela.Autenticacao = false;
                                objTabela.Celular = celular_maskedTextBox.Text;
                                objTabela.Email = email_textBox.Text.Trim();
                                if (tipo_comboBox.Text == "Administrador")
                                    objTabela.Tipo = 0;
                                else
                                    objTabela.Tipo = 1;

                                if (FuncionarioModel.Inserir(objTabela))
                                {
                                    MessageBox.Show(string.Format("Funcionário {0} foi inserido com sucesso!", nome_textBox.Text),
                                        "Informação:",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(string.Format("Funcionário {0} NÃO foi inserido!", nome_textBox.Text),
                                        "ERRO! CONTACTE O SUPORTE!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite um identificador e uma senha válidos!",
                                        "Atenção!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);

                                nome_textBox.Focus();
                            }
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Salvar: \n" + ex.Message,
                            "ERRO! CONTACTE O SUPORTE!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //LimparCampos();
                        DesabilitarCampos();
                        novo = false;
                    }
                    break;
                case "Excluir":
                    break;
                case "Editar":
                    HabilitarCampos();
                    break;
                default:
                    break;
            }

        }

        private void novo_button_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            novo = true;
            iniciarOpc();

            localizar_button.Enabled = false;
            novo_button.Enabled = false;
            salvar_button.Enabled = true;
            editar_button.Enabled = false;
            excluir_button.Enabled = false;
        }

        private void salvar_button_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();

            localizar_button.Enabled = true;
            novo_button.Enabled = true;
            salvar_button.Enabled = false;
            editar_button.Enabled = false;
            excluir_button.Enabled = false;
        }

        private void excluir_button_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();

            localizar_button.Enabled = true;
            novo_button.Enabled = true;
            salvar_button.Enabled = false;
            editar_button.Enabled = false;
            excluir_button.Enabled = false;
        }

        private void editar_button_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();

            localizar_button.Enabled = false;
            novo_button.Enabled = false;
            salvar_button.Enabled = true;
            editar_button.Enabled = false;
            excluir_button.Enabled = false;
        }

        private void localizar_button_Click(object sender, EventArgs e)
        {
            LocalizarForm form = new LocalizarForm();
            form.ShowDialog();

            codigo_label1.Text = form.funcionario[0].Codigo.ToString();
            nome_textBox.Text = form.funcionario[0].Nome;
            identificador_textBox.Text = form.funcionario[0].Identificador;
            senha_textBox.Text = form.funcionario[0].Senha;
            if (form.funcionario[0].Autenticacao == false)
                autenticacao_comboBox.Text = "Não";
            else
                autenticacao_comboBox.Text = "Sim";
            celular_maskedTextBox.Text = form.funcionario[0].Celular;
            email_textBox.Text = form.funcionario[0].Email;
            if (form.funcionario[0].Tipo == 0)
                tipo_comboBox.Text = "Administrador";
            else
                tipo_comboBox.Text = "Usuário";

            localizar_button.Enabled = true;
            novo_button.Enabled = false;
            salvar_button.Enabled = false;
            editar_button.Enabled = true;
            excluir_button.Enabled = true;
        }
    }
}
