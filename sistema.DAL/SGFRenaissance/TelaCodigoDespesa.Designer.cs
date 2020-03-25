namespace SGFRenaissance
{
    partial class TelaCodigoDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCodigoDespesa));
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.gb_cod_despesa = new System.Windows.Forms.GroupBox();
            this.dataGridView_cod_despesas = new System.Windows.Forms.DataGridView();
            this.contasDespesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_fechar = new System.Windows.Forms.Button();
            this.codDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDespesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDespesaContabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Consulta.SuspendLayout();
            this.gb_cod_despesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cod_despesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDespesaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.btn_consulta);
            this.gb_Consulta.Controls.Add(this.txt_Consulta);
            this.gb_Consulta.Location = new System.Drawing.Point(12, 12);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(684, 74);
            this.gb_Consulta.TabIndex = 2;
            this.gb_Consulta.TabStop = false;
            this.gb_Consulta.Text = "Consulta Código de Despesa";
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta.Image")));
            this.btn_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta.Location = new System.Drawing.Point(502, 18);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(138, 42);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "        Pesquisar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Consulta.Location = new System.Drawing.Point(36, 28);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(427, 23);
            this.txt_Consulta.TabIndex = 0;
            // 
            // gb_cod_despesa
            // 
            this.gb_cod_despesa.Controls.Add(this.dataGridView_cod_despesas);
            this.gb_cod_despesa.Location = new System.Drawing.Point(4, 101);
            this.gb_cod_despesa.Name = "gb_cod_despesa";
            this.gb_cod_despesa.Size = new System.Drawing.Size(699, 368);
            this.gb_cod_despesa.TabIndex = 3;
            this.gb_cod_despesa.TabStop = false;
            this.gb_cod_despesa.Text = "Lista de Códigos de Despesas";
            // 
            // dataGridView_cod_despesas
            // 
            this.dataGridView_cod_despesas.AllowUserToAddRows = false;
            this.dataGridView_cod_despesas.AllowUserToDeleteRows = false;
            this.dataGridView_cod_despesas.AutoGenerateColumns = false;
            this.dataGridView_cod_despesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cod_despesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDespesa,
            this.descricaoDespesaDataGridViewTextBoxColumn,
            this.codigoDespesaContabDataGridViewTextBoxColumn,
            this.Selecionar});
            this.dataGridView_cod_despesas.DataSource = this.contasDespesaBindingSource;
            this.dataGridView_cod_despesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_cod_despesas.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_cod_despesas.Name = "dataGridView_cod_despesas";
            this.dataGridView_cod_despesas.ReadOnly = true;
            this.dataGridView_cod_despesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cod_despesas.Size = new System.Drawing.Size(693, 349);
            this.dataGridView_cod_despesas.TabIndex = 0;
            this.dataGridView_cod_despesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cod_despesas_CellContentClick);
            // 
            // contasDespesaBindingSource
            // 
            this.contasDespesaBindingSource.DataSource = typeof(sistema.DAL.Contas_Despesa);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(314, 475);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(86, 30);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // codDespesa
            // 
            this.codDespesa.DataPropertyName = "Cod_Despesa";
            this.codDespesa.HeaderText = "Código";
            this.codDespesa.Name = "codDespesa";
            this.codDespesa.ReadOnly = true;
            this.codDespesa.Width = 65;
            // 
            // descricaoDespesaDataGridViewTextBoxColumn
            // 
            this.descricaoDespesaDataGridViewTextBoxColumn.DataPropertyName = "Descricao_Despesa";
            this.descricaoDespesaDataGridViewTextBoxColumn.HeaderText = "Descrição da Despesa";
            this.descricaoDespesaDataGridViewTextBoxColumn.Name = "descricaoDespesaDataGridViewTextBoxColumn";
            this.descricaoDespesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDespesaDataGridViewTextBoxColumn.Width = 320;
            // 
            // codigoDespesaContabDataGridViewTextBoxColumn
            // 
            this.codigoDespesaContabDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Despesa_Contab";
            this.codigoDespesaContabDataGridViewTextBoxColumn.HeaderText = "Cod. Despesa Contabil.";
            this.codigoDespesaContabDataGridViewTextBoxColumn.Name = "codigoDespesaContabDataGridViewTextBoxColumn";
            this.codigoDespesaContabDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDespesaContabDataGridViewTextBoxColumn.Width = 150;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 115;
            // 
            // TelaCodigoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 512);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.gb_cod_despesa);
            this.Controls.Add(this.gb_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCodigoDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Código de Despesa";
            this.Load += new System.EventHandler(this.TelaCodigoDespesa_Load);
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            this.gb_cod_despesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cod_despesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDespesaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.GroupBox gb_cod_despesa;
        private System.Windows.Forms.DataGridView dataGridView_cod_despesas;
        private System.Windows.Forms.BindingSource contasDespesaBindingSource;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDespesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDespesaContabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}