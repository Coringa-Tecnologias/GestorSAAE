namespace GestorSAAE
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gestor_label = new System.Windows.Forms.Label();
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autenticar_checkBox = new System.Windows.Forms.CheckBox();
            this.logotipo_pictureBox = new System.Windows.Forms.PictureBox();
            this.senha_label = new System.Windows.Forms.Label();
            this.senha_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.limpar_button = new System.Windows.Forms.Button();
            this.entrar_button = new System.Windows.Forms.Button();
            this.login_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.login_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gestor_label
            // 
            this.gestor_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gestor_label.AutoSize = true;
            this.gestor_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestor_label.ForeColor = System.Drawing.Color.SteelBlue;
            this.gestor_label.Location = new System.Drawing.Point(124, 29);
            this.gestor_label.Name = "gestor_label";
            this.gestor_label.Size = new System.Drawing.Size(104, 45);
            this.gestor_label.TabIndex = 0;
            this.gestor_label.Text = "Login";
            // 
            // login_groupBox
            // 
            this.login_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_groupBox.Controls.Add(this.pictureBox1);
            this.login_groupBox.Controls.Add(this.autenticar_checkBox);
            this.login_groupBox.Controls.Add(this.logotipo_pictureBox);
            this.login_groupBox.Controls.Add(this.senha_label);
            this.login_groupBox.Controls.Add(this.senha_maskedTextBox);
            this.login_groupBox.Controls.Add(this.id_textBox);
            this.login_groupBox.Controls.Add(this.id_label);
            this.login_groupBox.Controls.Add(this.cancelar_button);
            this.login_groupBox.Controls.Add(this.limpar_button);
            this.login_groupBox.Controls.Add(this.entrar_button);
            this.login_groupBox.Controls.Add(this.gestor_label);
            this.login_groupBox.Location = new System.Drawing.Point(12, 7);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Size = new System.Drawing.Size(335, 191);
            this.login_groupBox.TabIndex = 0;
            this.login_groupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // autenticar_checkBox
            // 
            this.autenticar_checkBox.AutoSize = true;
            this.autenticar_checkBox.Location = new System.Drawing.Point(214, 120);
            this.autenticar_checkBox.Name = "autenticar_checkBox";
            this.autenticar_checkBox.Size = new System.Drawing.Size(74, 17);
            this.autenticar_checkBox.TabIndex = 5;
            this.autenticar_checkBox.Text = "Autenticar";
            this.autenticar_checkBox.UseVisualStyleBackColor = true;
            // 
            // logotipo_pictureBox
            // 
            this.logotipo_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logotipo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logotipo_pictureBox.Image")));
            this.logotipo_pictureBox.Location = new System.Drawing.Point(272, 19);
            this.logotipo_pictureBox.Name = "logotipo_pictureBox";
            this.logotipo_pictureBox.Size = new System.Drawing.Size(56, 55);
            this.logotipo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotipo_pictureBox.TabIndex = 9;
            this.logotipo_pictureBox.TabStop = false;
            // 
            // senha_label
            // 
            this.senha_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.senha_label.AutoSize = true;
            this.senha_label.Location = new System.Drawing.Point(48, 121);
            this.senha_label.Name = "senha_label";
            this.senha_label.Size = new System.Drawing.Size(41, 13);
            this.senha_label.TabIndex = 3;
            this.senha_label.Text = "Senha:";
            // 
            // senha_maskedTextBox
            // 
            this.senha_maskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.senha_maskedTextBox.Location = new System.Drawing.Point(95, 118);
            this.senha_maskedTextBox.Name = "senha_maskedTextBox";
            this.senha_maskedTextBox.Size = new System.Drawing.Size(112, 20);
            this.senha_maskedTextBox.TabIndex = 4;
            this.login_toolTip.SetToolTip(this.senha_maskedTextBox, "Senha do usuário");
            this.senha_maskedTextBox.UseSystemPasswordChar = true;
            // 
            // id_textBox
            // 
            this.id_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_textBox.Location = new System.Drawing.Point(95, 92);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(193, 20);
            this.id_textBox.TabIndex = 2;
            this.login_toolTip.SetToolTip(this.id_textBox, "Identificador do usuário");
            // 
            // id_label
            // 
            this.id_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(48, 95);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "ID:";
            // 
            // cancelar_button
            // 
            this.cancelar_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelar_button.Location = new System.Drawing.Point(213, 150);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 8;
            this.cancelar_button.Text = "&Cancelar";
            this.login_toolTip.SetToolTip(this.cancelar_button, "Clique aqui para cancelar a entrada no sistema");
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // limpar_button
            // 
            this.limpar_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.limpar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limpar_button.Location = new System.Drawing.Point(132, 150);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(75, 23);
            this.limpar_button.TabIndex = 7;
            this.limpar_button.Text = "&Limpar";
            this.login_toolTip.SetToolTip(this.limpar_button, "Clique aqui para limpar os dados inseridos");
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.limpar_button_Click);
            // 
            // entrar_button
            // 
            this.entrar_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entrar_button.Location = new System.Drawing.Point(51, 150);
            this.entrar_button.Name = "entrar_button";
            this.entrar_button.Size = new System.Drawing.Size(75, 23);
            this.entrar_button.TabIndex = 6;
            this.entrar_button.Text = "&Entrar";
            this.login_toolTip.SetToolTip(this.entrar_button, "Clique aqui para validar a senha e entrar no sistema");
            this.entrar_button.UseVisualStyleBackColor = true;
            this.entrar_button.Click += new System.EventHandler(this.entrar_button_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.entrar_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.limpar_button;
            this.ClientSize = new System.Drawing.Size(359, 210);
            this.Controls.Add(this.login_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Wsly";
            this.TopMost = true;
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gestor_label;
        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.Label senha_label;
        private System.Windows.Forms.MaskedTextBox senha_maskedTextBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button limpar_button;
        private System.Windows.Forms.Button entrar_button;
        private System.Windows.Forms.PictureBox logotipo_pictureBox;
        private System.Windows.Forms.CheckBox autenticar_checkBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip login_toolTip;
    }
}

