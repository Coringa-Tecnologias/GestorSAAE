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
            //senha_textBox.Enabled = true;
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
                                CarregarObjTabela();

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
                            if (identificador_textBox.Text.Trim() != "" &&
                            senha_textBox.Text.Trim() != "")
                            {
                                objTabela.Codigo = Convert.ToInt32(codigo_label1.Text);
                                CarregarObjTabela();

                                bool altSenha = altSenha_checkBox.Checked;

                                if (FuncionarioModel.Editar(objTabela, altSenha))
                                {
                                    MessageBox.Show(string.Format("Funcionário {0} foi editado com sucesso!", nome_textBox.Text),
                                        "Informação:",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(string.Format("Funcionário {0} NÃO foi editado!", nome_textBox.Text),
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
                    try
                    {
                        if (codigo_label1.Text != "")
                        {
                            objTabela.Codigo = Convert.ToInt32(codigo_label1.Text);
                            CarregarObjTabela();

                            DialogResult result = new DialogResult();

                            result = MessageBox.Show(string.Format("Tem certeza que deseja excluir o funcionário {0}?", nome_textBox.Text),
                                "Atenção!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            switch (result)
                            {
                                case DialogResult.Yes:
                                    if (FuncionarioModel.Excluir(objTabela))
                                    {
                                        MessageBox.Show(string.Format("Funcionário {0} foi excluído com sucesso!", nome_textBox.Text),
                                            "Informação:",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(string.Format("Funcionário {0} NÃO foi excluído!", nome_textBox.Text),
                                            "ERRO! CONTACTE O SUPORTE!",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                    }
                                    break;
                                case DialogResult.No:
                                    MessageBox.Show("Exclusão cancelada pelo usuário!",
                                            "Informação:",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                    break;
                                default:
                                    break;
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("Localize um código válido!",
                                    "Atenção!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                            localizar_button.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Excluir: \n" + ex.Message,
                            "ERRO! CONTACTE O SUPORTE!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //LimparCampos();
                        DesabilitarCampos();
                        LimparCampos();
                        novo = false;
                    }
                    break;
                    break;
                case "Editar":
                    HabilitarCampos();
                    break;
                default:
                    break;
            }

        }

        private void CarregarObjTabela()
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
        }

        private Image GerarQrContato(FuncionarioEnt objTabela)
        {
            FuncionarioModel.GerarQr(objTabela);

            return objTabela.QrContato;
        }

        private void novo_button_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            novo = true;
            iniciarOpc();

            senha_textBox.Enabled = true;

            localizar_button.Enabled = false;
            novo_button.Enabled = false;
            salvar_button.Enabled = true;
            editar_button.Enabled = false;
            excluir_button.Enabled = false;
            qr_button.Enabled = false;
            altSenha_checkBox.Enabled = false;
            altSenha_checkBox.CheckState = CheckState.Unchecked;
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
            qr_button.Enabled = false;
            altSenha_checkBox.Enabled = false;
            altSenha_checkBox.CheckState = CheckState.Unchecked;
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
            qr_button.Enabled = false;
            altSenha_checkBox.Enabled = false;
            altSenha_checkBox.CheckState = CheckState.Unchecked;
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
            qr_button.Enabled = false;
            altSenha_checkBox.Enabled = true;
            altSenha_checkBox.CheckState = CheckState.Unchecked;
        }

        private void localizar_button_Click(object sender, EventArgs e)
        {
            LocalizarForm form = new LocalizarForm();
            DialogResult result = new DialogResult();

            result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
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
                    qr_button.Enabled = true;
                    altSenha_checkBox.Enabled = false;
                    altSenha_checkBox.CheckState = CheckState.Unchecked;
                    break;
                default:
                    break;  
            }
        }

        private void qr_button_Click(object sender, EventArgs e)
        {
            objTabela.Codigo = Convert.ToInt32(codigo_label1.Text);
            CarregarObjTabela();
            QrFuncionarioForm formQrContato = new QrFuncionarioForm();
            formQrContato.qrContato = GerarQrContato(objTabela);
            formQrContato.ShowDialog();
        }

        private void altSenha_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (altSenha_checkBox.Checked)
                senha_textBox.Enabled = true;
            else
                senha_textBox.Enabled = false;
        }
    }
}
