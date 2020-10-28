namespace GestorSAAE.View
{
    partial class LocalizarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarForm));
            this.localizar_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.codigo_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.filtrar_button = new System.Windows.Forms.Button();
            this.localizar_dataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exibir_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.localizar_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // localizar_tabControl
            // 
            this.localizar_tabControl.Controls.Add(this.tabPage1);
            this.localizar_tabControl.Controls.Add(this.tabPage2);
            this.localizar_tabControl.Controls.Add(this.tabPage3);
            this.localizar_tabControl.Location = new System.Drawing.Point(12, 12);
            this.localizar_tabControl.Name = "localizar_tabControl";
            this.localizar_tabControl.SelectedIndex = 0;
            this.localizar_tabControl.Size = new System.Drawing.Size(505, 60);
            this.localizar_tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.codigo_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 34);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // codigo_textBox
            // 
            this.codigo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigo_textBox.Location = new System.Drawing.Point(6, 7);
            this.codigo_textBox.Name = "codigo_textBox";
            this.codigo_textBox.Size = new System.Drawing.Size(485, 20);
            this.codigo_textBox.TabIndex = 0;
            this.codigo_textBox.Leave += new System.EventHandler(this.codigo_textBox_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nome_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 34);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nome_textBox
            // 
            this.nome_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nome_textBox.Location = new System.Drawing.Point(6, 7);
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(485, 20);
            this.nome_textBox.TabIndex = 1;
            this.nome_textBox.Leave += new System.EventHandler(this.nome_textBox_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.email_textBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(497, 34);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "E-mail";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // email_textBox
            // 
            this.email_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_textBox.Location = new System.Drawing.Point(6, 7);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(485, 20);
            this.email_textBox.TabIndex = 1;
            this.email_textBox.Leave += new System.EventHandler(this.email_textBox_Leave);
            // 
            // filtrar_button
            // 
            this.filtrar_button.Image = ((System.Drawing.Image)(resources.GetObject("filtrar_button.Image")));
            this.filtrar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtrar_button.Location = new System.Drawing.Point(523, 34);
            this.filtrar_button.Name = "filtrar_button";
            this.filtrar_button.Size = new System.Drawing.Size(99, 34);
            this.filtrar_button.TabIndex = 1;
            this.filtrar_button.Text = "&Filtrar";
            this.filtrar_button.UseVisualStyleBackColor = true;
            this.filtrar_button.Click += new System.EventHandler(this.filtrar_button_Click);
            // 
            // localizar_dataGridView
            // 
            this.localizar_dataGridView.AllowUserToAddRows = false;
            this.localizar_dataGridView.AllowUserToDeleteRows = false;
            this.localizar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.localizar_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.localizar_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.localizar_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.localizar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localizar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.identificador,
            this.email});
            this.localizar_dataGridView.EnableHeadersVisualStyles = false;
            this.localizar_dataGridView.Location = new System.Drawing.Point(12, 78);
            this.localizar_dataGridView.MultiSelect = false;
            this.localizar_dataGridView.Name = "localizar_dataGridView";
            this.localizar_dataGridView.ReadOnly = true;
            this.localizar_dataGridView.RowHeadersVisible = false;
            this.localizar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.localizar_dataGridView.Size = new System.Drawing.Size(505, 111);
            this.localizar_dataGridView.TabIndex = 2;
            this.localizar_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.localizar_dataGridView_CellClick);
            this.localizar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.localizar_dataGridView_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 60;
            // 
            // identificador
            // 
            this.identificador.DataPropertyName = "Identificador";
            this.identificador.HeaderText = "Identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Width = 90;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 60;
            // 
            // exibir_button
            // 
            this.exibir_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exibir_button.Enabled = false;
            this.exibir_button.Image = ((System.Drawing.Image)(resources.GetObject("exibir_button.Image")));
            this.exibir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibir_button.Location = new System.Drawing.Point(523, 78);
            this.exibir_button.Name = "exibir_button";
            this.exibir_button.Size = new System.Drawing.Size(99, 34);
            this.exibir_button.TabIndex = 3;
            this.exibir_button.Text = "&Exibir";
            this.exibir_button.UseVisualStyleBackColor = true;
            this.exibir_button.Click += new System.EventHandler(this.exibir_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar_button.Location = new System.Drawing.Point(523, 155);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(99, 34);
            this.cancelar_button.TabIndex = 4;
            this.cancelar_button.Text = "&Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // LocalizarForm
            // 
            this.AcceptButton = this.exibir_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar_button;
            this.ClientSize = new System.Drawing.Size(624, 201);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.exibir_button);
            this.Controls.Add(this.localizar_dataGridView);
            this.Controls.Add(this.filtrar_button);
            this.Controls.Add(this.localizar_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(640, 240);
            this.MinimumSize = new System.Drawing.Size(640, 240);
            this.Name = "LocalizarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.localizar_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl localizar_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox codigo_textBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Button filtrar_button;
        private System.Windows.Forms.DataGridView localizar_dataGridView;
        private System.Windows.Forms.Button exibir_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button cancelar_button;
    }
}