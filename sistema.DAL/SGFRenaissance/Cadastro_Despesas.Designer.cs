namespace SGFRenaissance
{
    partial class Cadastro_Despesas
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
            System.Windows.Forms.Label cod_DespesaLabel;
            System.Windows.Forms.Label codigo_Despesa_ContabLabel;
            System.Windows.Forms.Label descricao_DespesaLabel;
            System.Windows.Forms.Label login_NameLabel;
            System.Windows.Forms.Label data_LoginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Despesas));
            this._lblTituloJanela = new System.Windows.Forms.Label();
            this._lblLinha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descricao_DespesaTextBox = new System.Windows.Forms.TextBox();
            this.contas_DespesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigo_Despesa_ContabTextBox = new System.Windows.Forms.TextBox();
            this.cod_DespesaTextBox = new System.Windows.Forms.TextBox();
            this.contas_DespesaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_LoginTextBox = new System.Windows.Forms.TextBox();
            this.login_NameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            cod_DespesaLabel = new System.Windows.Forms.Label();
            codigo_Despesa_ContabLabel = new System.Windows.Forms.Label();
            descricao_DespesaLabel = new System.Windows.Forms.Label();
            login_NameLabel = new System.Windows.Forms.Label();
            data_LoginLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DespesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DespesaDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_DespesaLabel
            // 
            cod_DespesaLabel.AutoSize = true;
            cod_DespesaLabel.Location = new System.Drawing.Point(10, 22);
            cod_DespesaLabel.Name = "cod_DespesaLabel";
            cod_DespesaLabel.Size = new System.Drawing.Size(74, 13);
            cod_DespesaLabel.TabIndex = 0;
            cod_DespesaLabel.Text = "Cod Despesa:";
            // 
            // codigo_Despesa_ContabLabel
            // 
            codigo_Despesa_ContabLabel.AutoSize = true;
            codigo_Despesa_ContabLabel.Location = new System.Drawing.Point(189, 22);
            codigo_Despesa_ContabLabel.Name = "codigo_Despesa_ContabLabel";
            codigo_Despesa_ContabLabel.Size = new System.Drawing.Size(125, 13);
            codigo_Despesa_ContabLabel.TabIndex = 2;
            codigo_Despesa_ContabLabel.Text = "Codigo Despesa Contab:";
            // 
            // descricao_DespesaLabel
            // 
            descricao_DespesaLabel.AutoSize = true;
            descricao_DespesaLabel.Location = new System.Drawing.Point(10, 52);
            descricao_DespesaLabel.Name = "descricao_DespesaLabel";
            descricao_DespesaLabel.Size = new System.Drawing.Size(103, 13);
            descricao_DespesaLabel.TabIndex = 4;
            descricao_DespesaLabel.Text = "Descricao Despesa:";
            // 
            // login_NameLabel
            // 
            login_NameLabel.AutoSize = true;
            login_NameLabel.Location = new System.Drawing.Point(9, 6);
            login_NameLabel.Name = "login_NameLabel";
            login_NameLabel.Size = new System.Drawing.Size(36, 13);
            login_NameLabel.TabIndex = 0;
            login_NameLabel.Text = "Login:";
            // 
            // data_LoginLabel
            // 
            data_LoginLabel.AutoSize = true;
            data_LoginLabel.Location = new System.Drawing.Point(189, 6);
            data_LoginLabel.Name = "data_LoginLabel";
            data_LoginLabel.Size = new System.Drawing.Size(62, 13);
            data_LoginLabel.TabIndex = 2;
            data_LoginLabel.Text = "Data Login:";
            // 
            // _lblTituloJanela
            // 
            this._lblTituloJanela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTituloJanela.AutoSize = true;
            this._lblTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloJanela.ForeColor = System.Drawing.Color.Maroon;
            this._lblTituloJanela.Location = new System.Drawing.Point(-1, 9);
            this._lblTituloJanela.Name = "_lblTituloJanela";
            this._lblTituloJanela.Size = new System.Drawing.Size(249, 29);
            this._lblTituloJanela.TabIndex = 114;
            this._lblTituloJanela.Text = "Cadastrar Despesas";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.Location = new System.Drawing.Point(-84, 38);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(688, 18);
            this._lblLinha.TabIndex = 115;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_proximo);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 64);
            this.panel1.TabIndex = 116;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(138, 15);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(85, 30);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(18, 15);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(85, 30);
            this.btn_novo.TabIndex = 3;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(248, 15);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 30);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(356, 15);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(85, 30);
            this.btn_proximo.TabIndex = 1;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(463, 15);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(85, 30);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(descricao_DespesaLabel);
            this.groupBox1.Controls.Add(this.descricao_DespesaTextBox);
            this.groupBox1.Controls.Add(codigo_Despesa_ContabLabel);
            this.groupBox1.Controls.Add(this.codigo_Despesa_ContabTextBox);
            this.groupBox1.Controls.Add(cod_DespesaLabel);
            this.groupBox1.Controls.Add(this.cod_DespesaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 99);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Despesa";
            // 
            // descricao_DespesaTextBox
            // 
            this.descricao_DespesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_DespesaBindingSource, "Descricao_Despesa", true));
            this.descricao_DespesaTextBox.Location = new System.Drawing.Point(119, 49);
            this.descricao_DespesaTextBox.Name = "descricao_DespesaTextBox";
            this.descricao_DespesaTextBox.Size = new System.Drawing.Size(312, 20);
            this.descricao_DespesaTextBox.TabIndex = 5;
            // 
            // contas_DespesaBindingSource
            // 
            this.contas_DespesaBindingSource.DataSource = typeof(sistema.DAL.Contas_Despesa);
            // 
            // codigo_Despesa_ContabTextBox
            // 
            this.codigo_Despesa_ContabTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_DespesaBindingSource, "Codigo_Despesa_Contab", true));
            this.codigo_Despesa_ContabTextBox.Location = new System.Drawing.Point(320, 19);
            this.codigo_Despesa_ContabTextBox.Name = "codigo_Despesa_ContabTextBox";
            this.codigo_Despesa_ContabTextBox.Size = new System.Drawing.Size(111, 20);
            this.codigo_Despesa_ContabTextBox.TabIndex = 3;
            // 
            // cod_DespesaTextBox
            // 
            this.cod_DespesaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cod_DespesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_DespesaBindingSource, "Cod_Despesa", true));
            this.cod_DespesaTextBox.Location = new System.Drawing.Point(119, 23);
            this.cod_DespesaTextBox.Name = "cod_DespesaTextBox";
            this.cod_DespesaTextBox.ReadOnly = true;
            this.cod_DespesaTextBox.Size = new System.Drawing.Size(63, 13);
            this.cod_DespesaTextBox.TabIndex = 1;
            // 
            // contas_DespesaDataGridView
            // 
            this.contas_DespesaDataGridView.AllowUserToAddRows = false;
            this.contas_DespesaDataGridView.AllowUserToDeleteRows = false;
            this.contas_DespesaDataGridView.AutoGenerateColumns = false;
            this.contas_DespesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contas_DespesaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.contas_DespesaDataGridView.DataSource = this.contas_DespesaBindingSource;
            this.contas_DespesaDataGridView.Location = new System.Drawing.Point(0, 164);
            this.contas_DespesaDataGridView.Name = "contas_DespesaDataGridView";
            this.contas_DespesaDataGridView.ReadOnly = true;
            this.contas_DespesaDataGridView.Size = new System.Drawing.Size(567, 171);
            this.contas_DespesaDataGridView.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(data_LoginLabel);
            this.panel2.Controls.Add(this.data_LoginTextBox);
            this.panel2.Controls.Add(login_NameLabel);
            this.panel2.Controls.Add(this.login_NameTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 53);
            this.panel2.TabIndex = 119;
            // 
            // data_LoginTextBox
            // 
            this.data_LoginTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.data_LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_DespesaBindingSource, "Data_Login", true));
            this.data_LoginTextBox.Location = new System.Drawing.Point(257, 7);
            this.data_LoginTextBox.Name = "data_LoginTextBox";
            this.data_LoginTextBox.ReadOnly = true;
            this.data_LoginTextBox.Size = new System.Drawing.Size(115, 13);
            this.data_LoginTextBox.TabIndex = 3;
            // 
            // login_NameTextBox
            // 
            this.login_NameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.login_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_DespesaBindingSource, "Login_Name", true));
            this.login_NameTextBox.Location = new System.Drawing.Point(82, 7);
            this.login_NameTextBox.Name = "login_NameTextBox";
            this.login_NameTextBox.ReadOnly = true;
            this.login_NameTextBox.Size = new System.Drawing.Size(100, 13);
            this.login_NameTextBox.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Despesa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Despesa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao_Despesa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição da Despesa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 290;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo_Despesa_Contab";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cód. Despesa Contábil";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Responsável pela Última Alteração:";
            // 
            // Cadastro_Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contas_DespesaDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this._lblTituloJanela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Despesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.Cadastro_Despesas_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DespesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DespesaDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloJanela;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource contas_DespesaBindingSource;
        private System.Windows.Forms.DataGridView contas_DespesaDataGridView;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox descricao_DespesaTextBox;
        private System.Windows.Forms.TextBox codigo_Despesa_ContabTextBox;
        private System.Windows.Forms.TextBox cod_DespesaTextBox;
        private System.Windows.Forms.TextBox data_LoginTextBox;
        private System.Windows.Forms.TextBox login_NameTextBox;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}