namespace GestorSAAE
{
    partial class CadFuncionarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionarioForm));
            this.nome_label = new System.Windows.Forms.Label();
            this.identificador_label = new System.Windows.Forms.Label();
            this.senha_label = new System.Windows.Forms.Label();
            this.autenticacao_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.tipo_label = new System.Windows.Forms.Label();
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.identificador_textBox = new System.Windows.Forms.TextBox();
            this.senha_textBox = new System.Windows.Forms.TextBox();
            this.autenticacao_comboBox = new System.Windows.Forms.ComboBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.tipo_comboBox = new System.Windows.Forms.ComboBox();
            this.novo_button = new System.Windows.Forms.Button();
            this.imgBotões_imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.salvar_button = new System.Windows.Forms.Button();
            this.excluir_button = new System.Windows.Forms.Button();
            this.editar_button = new System.Windows.Forms.Button();
            this.funcionario_groupBox = new System.Windows.Forms.GroupBox();
            this.celular_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celular_label = new System.Windows.Forms.Label();
            this.qr_button = new System.Windows.Forms.Button();
            this.codigo_label1 = new System.Windows.Forms.Label();
            this.codigo_label = new System.Windows.Forms.Label();
            this.localizar_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.funcionario_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(8, 48);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "Nome:";
            // 
            // identificador_label
            // 
            this.identificador_label.AutoSize = true;
            this.identificador_label.Location = new System.Drawing.Point(8, 74);
            this.identificador_label.Name = "identificador_label";
            this.identificador_label.Size = new System.Drawing.Size(68, 13);
            this.identificador_label.TabIndex = 4;
            this.identificador_label.Text = "Identificador:";
            // 
            // senha_label
            // 
            this.senha_label.AutoSize = true;
            this.senha_label.Location = new System.Drawing.Point(8, 100);
            this.senha_label.Name = "senha_label";
            this.senha_label.Size = new System.Drawing.Size(41, 13);
            this.senha_label.TabIndex = 6;
            this.senha_label.Text = "Senha:";
            // 
            // autenticacao_label
            // 
            this.autenticacao_label.AutoSize = true;
            this.autenticacao_label.Location = new System.Drawing.Point(8, 126);
            this.autenticacao_label.Name = "autenticacao_label";
            this.autenticacao_label.Size = new System.Drawing.Size(73, 13);
            this.autenticacao_label.TabIndex = 8;
            this.autenticacao_label.Text = "Autenticação:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(8, 153);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(38, 13);
            this.email_label.TabIndex = 12;
            this.email_label.Text = "E-mail:";
            // 
            // tipo_label
            // 
            this.tipo_label.AutoSize = true;
            this.tipo_label.Location = new System.Drawing.Point(8, 179);
            this.tipo_label.Name = "tipo_label";
            this.tipo_label.Size = new System.Drawing.Size(31, 13);
            this.tipo_label.TabIndex = 14;
            this.tipo_label.Text = "Tipo:";
            // 
            // nome_textBox
            // 
            this.nome_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nome_textBox.Enabled = false;
            this.nome_textBox.Location = new System.Drawing.Point(88, 45);
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(371, 20);
            this.nome_textBox.TabIndex = 3;
            // 
            // identificador_textBox
            // 
            this.identificador_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.identificador_textBox.Enabled = false;
            this.identificador_textBox.Location = new System.Drawing.Point(88, 71);
            this.identificador_textBox.Name = "identificador_textBox";
            this.identificador_textBox.Size = new System.Drawing.Size(371, 20);
            this.identificador_textBox.TabIndex = 5;
            // 
            // senha_textBox
            // 
            this.senha_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.senha_textBox.Enabled = false;
            this.senha_textBox.Location = new System.Drawing.Point(88, 97);
            this.senha_textBox.Name = "senha_textBox";
            this.senha_textBox.Size = new System.Drawing.Size(371, 20);
            this.senha_textBox.TabIndex = 7;
            // 
            // autenticacao_comboBox
            // 
            this.autenticacao_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.autenticacao_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.autenticacao_comboBox.Enabled = false;
            this.autenticacao_comboBox.FormattingEnabled = true;
            this.autenticacao_comboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.autenticacao_comboBox.Location = new System.Drawing.Point(88, 123);
            this.autenticacao_comboBox.Name = "autenticacao_comboBox";
            this.autenticacao_comboBox.Size = new System.Drawing.Size(159, 21);
            this.autenticacao_comboBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            this.email_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.email_textBox.Enabled = false;
            this.email_textBox.Location = new System.Drawing.Point(88, 150);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(371, 20);
            this.email_textBox.TabIndex = 13;
            // 
            // tipo_comboBox
            // 
            this.tipo_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipo_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipo_comboBox.Enabled = false;
            this.tipo_comboBox.FormattingEnabled = true;
            this.tipo_comboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.tipo_comboBox.Location = new System.Drawing.Point(88, 176);
            this.tipo_comboBox.Name = "tipo_comboBox";
            this.tipo_comboBox.Size = new System.Drawing.Size(159, 21);
            this.tipo_comboBox.TabIndex = 15;
            // 
            // novo_button
            // 
            this.novo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novo_button.ImageIndex = 1;
            this.novo_button.ImageList = this.imgBotões_imageList1;
            this.novo_button.Location = new System.Drawing.Point(483, 162);
            this.novo_button.Name = "novo_button";
            this.novo_button.Size = new System.Drawing.Size(70, 33);
            this.novo_button.TabIndex = 4;
            this.novo_button.Text = "&Novo";
            this.novo_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novo_button.UseVisualStyleBackColor = true;
            this.novo_button.Click += new System.EventHandler(this.novo_button_Click);
            // 
            // imgBotões_imageList1
            // 
            this.imgBotões_imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBotões_imageList1.ImageStream")));
            this.imgBotões_imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBotões_imageList1.Images.SetKeyName(0, "editar.png");
            this.imgBotões_imageList1.Images.SetKeyName(1, "adicionar-ficheiro.png");
            this.imgBotões_imageList1.Images.SetKeyName(2, "salvar-arquivo.png");
            this.imgBotões_imageList1.Images.SetKeyName(3, "excluir.png");
            // 
            // salvar_button
            // 
            this.salvar_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvar_button.Enabled = false;
            this.salvar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvar_button.ImageIndex = 2;
            this.salvar_button.ImageList = this.imgBotões_imageList1;
            this.salvar_button.Location = new System.Drawing.Point(483, 195);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(70, 33);
            this.salvar_button.TabIndex = 5;
            this.salvar_button.Text = "&Salvar";
            this.salvar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // excluir_button
            // 
            this.excluir_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excluir_button.Enabled = false;
            this.excluir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluir_button.ImageIndex = 3;
            this.excluir_button.ImageList = this.imgBotões_imageList1;
            this.excluir_button.Location = new System.Drawing.Point(483, 228);
            this.excluir_button.Name = "excluir_button";
            this.excluir_button.Size = new System.Drawing.Size(70, 33);
            this.excluir_button.TabIndex = 6;
            this.excluir_button.Text = "&Excluir";
            this.excluir_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excluir_button.UseVisualStyleBackColor = true;
            this.excluir_button.Click += new System.EventHandler(this.excluir_button_Click);
            // 
            // editar_button
            // 
            this.editar_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editar_button.Enabled = false;
            this.editar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar_button.ImageIndex = 0;
            this.editar_button.ImageList = this.imgBotões_imageList1;
            this.editar_button.Location = new System.Drawing.Point(483, 129);
            this.editar_button.Name = "editar_button";
            this.editar_button.Size = new System.Drawing.Size(70, 33);
            this.editar_button.TabIndex = 3;
            this.editar_button.Text = "&Editar";
            this.editar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editar_button.UseVisualStyleBackColor = true;
            this.editar_button.Click += new System.EventHandler(this.editar_button_Click);
            // 
            // funcionario_groupBox
            // 
            this.funcionario_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcionario_groupBox.Controls.Add(this.celular_maskedTextBox);
            this.funcionario_groupBox.Controls.Add(this.celular_label);
            this.funcionario_groupBox.Controls.Add(this.qr_button);
            this.funcionario_groupBox.Controls.Add(this.codigo_label1);
            this.funcionario_groupBox.Controls.Add(this.codigo_label);
            this.funcionario_groupBox.Controls.Add(this.nome_textBox);
            this.funcionario_groupBox.Controls.Add(this.nome_label);
            this.funcionario_groupBox.Controls.Add(this.identificador_label);
            this.funcionario_groupBox.Controls.Add(this.senha_label);
            this.funcionario_groupBox.Controls.Add(this.autenticacao_label);
            this.funcionario_groupBox.Controls.Add(this.email_label);
            this.funcionario_groupBox.Controls.Add(this.tipo_comboBox);
            this.funcionario_groupBox.Controls.Add(this.tipo_label);
            this.funcionario_groupBox.Controls.Add(this.email_textBox);
            this.funcionario_groupBox.Controls.Add(this.identificador_textBox);
            this.funcionario_groupBox.Controls.Add(this.autenticacao_comboBox);
            this.funcionario_groupBox.Controls.Add(this.senha_textBox);
            this.funcionario_groupBox.Location = new System.Drawing.Point(12, 56);
            this.funcionario_groupBox.Name = "funcionario_groupBox";
            this.funcionario_groupBox.Size = new System.Drawing.Size(465, 207);
            this.funcionario_groupBox.TabIndex = 2;
            this.funcionario_groupBox.TabStop = false;
            // 
            // celular_maskedTextBox
            // 
            this.celular_maskedTextBox.Enabled = false;
            this.celular_maskedTextBox.Location = new System.Drawing.Point(301, 123);
            this.celular_maskedTextBox.Mask = "(99) 9 0000-0000";
            this.celular_maskedTextBox.Name = "celular_maskedTextBox";
            this.celular_maskedTextBox.Size = new System.Drawing.Size(158, 20);
            this.celular_maskedTextBox.TabIndex = 11;
            this.celular_maskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // celular_label
            // 
            this.celular_label.AutoSize = true;
            this.celular_label.Location = new System.Drawing.Point(253, 128);
            this.celular_label.Name = "celular_label";
            this.celular_label.Size = new System.Drawing.Size(42, 13);
            this.celular_label.TabIndex = 10;
            this.celular_label.Text = "Celular:";
            // 
            // qr_button
            // 
            this.qr_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qr_button.Enabled = false;
            this.qr_button.Location = new System.Drawing.Point(365, 174);
            this.qr_button.Name = "qr_button";
            this.qr_button.Size = new System.Drawing.Size(94, 23);
            this.qr_button.TabIndex = 16;
            this.qr_button.Text = "Qr de &Cadastro";
            this.qr_button.UseVisualStyleBackColor = true;
            // 
            // codigo_label1
            // 
            this.codigo_label1.AutoSize = true;
            this.codigo_label1.Location = new System.Drawing.Point(85, 19);
            this.codigo_label1.Name = "codigo_label1";
            this.codigo_label1.Size = new System.Drawing.Size(0, 13);
            this.codigo_label1.TabIndex = 1;
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(8, 19);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 0;
            this.codigo_label.Text = "Código:";
            // 
            // localizar_button
            // 
            this.localizar_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizar_button.Image = ((System.Drawing.Image)(resources.GetObject("localizar_button.Image")));
            this.localizar_button.Location = new System.Drawing.Point(483, 61);
            this.localizar_button.Name = "localizar_button";
            this.localizar_button.Size = new System.Drawing.Size(70, 60);
            this.localizar_button.TabIndex = 1;
            this.localizar_button.Text = "&Localizar";
            this.localizar_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizar_button.UseVisualStyleBackColor = true;
            this.localizar_button.Click += new System.EventHandler(this.localizar_button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Funcionários";
            // 
            // CadFuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localizar_button);
            this.Controls.Add(this.funcionario_groupBox);
            this.Controls.Add(this.editar_button);
            this.Controls.Add(this.excluir_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.novo_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 310);
            this.Name = "CadFuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.funcionario_groupBox.ResumeLayout(false);
            this.funcionario_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label identificador_label;
        private System.Windows.Forms.Label senha_label;
        private System.Windows.Forms.Label autenticacao_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label tipo_label;
        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.TextBox identificador_textBox;
        private System.Windows.Forms.TextBox senha_textBox;
        private System.Windows.Forms.ComboBox autenticacao_comboBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.ComboBox tipo_comboBox;
        private System.Windows.Forms.Button novo_button;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button excluir_button;
        private System.Windows.Forms.Button editar_button;
        private System.Windows.Forms.GroupBox funcionario_groupBox;
        private System.Windows.Forms.Label codigo_label1;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.Button localizar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imgBotões_imageList1;
        private System.Windows.Forms.Button qr_button;
        private System.Windows.Forms.Label celular_label;
        private System.Windows.Forms.MaskedTextBox celular_maskedTextBox;
    }
}