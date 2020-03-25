namespace SGFRenaissance
{
    partial class TelaTipoReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTipoReceita));
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.tipos_ReceitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_ReceitaDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.Cod_Receita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_ReceitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_ReceitaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta.Image")));
            this.btn_consulta.Location = new System.Drawing.Point(393, 19);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(104, 42);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Consulta.Location = new System.Drawing.Point(17, 32);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(370, 23);
            this.txt_Consulta.TabIndex = 0;
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.btn_consulta);
            this.gb_Consulta.Controls.Add(this.txt_Consulta);
            this.gb_Consulta.Location = new System.Drawing.Point(3, 12);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(512, 74);
            this.gb_Consulta.TabIndex = 2;
            this.gb_Consulta.TabStop = false;
            this.gb_Consulta.Text = "Consulta Tipos de Receita";
            // 
            // tipos_ReceitaBindingSource
            // 
            this.tipos_ReceitaBindingSource.DataSource = typeof(sistema.DAL.Tipos_Receita);
            // 
            // tipos_ReceitaDataGridView
            // 
            this.tipos_ReceitaDataGridView.AllowUserToAddRows = false;
            this.tipos_ReceitaDataGridView.AllowUserToDeleteRows = false;
            this.tipos_ReceitaDataGridView.AutoGenerateColumns = false;
            this.tipos_ReceitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipos_ReceitaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Receita,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Btn_Selecionar});
            this.tipos_ReceitaDataGridView.DataSource = this.tipos_ReceitaBindingSource;
            this.tipos_ReceitaDataGridView.Location = new System.Drawing.Point(3, 92);
            this.tipos_ReceitaDataGridView.Name = "tipos_ReceitaDataGridView";
            this.tipos_ReceitaDataGridView.ReadOnly = true;
            this.tipos_ReceitaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tipos_ReceitaDataGridView.Size = new System.Drawing.Size(522, 270);
            this.tipos_ReceitaDataGridView.TabIndex = 3;
            this.tipos_ReceitaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tipos_ReceitaDataGridView_CellContentClick);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(205, 368);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(96, 35);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Cod_Receita
            // 
            this.Cod_Receita.DataPropertyName = "Codigo_Tipo_Receita";
            this.Cod_Receita.HeaderText = "Cod. Tipo Receita";
            this.Cod_Receita.Name = "Cod_Receita";
            this.Cod_Receita.ReadOnly = true;
            this.Cod_Receita.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao_Receita";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição da Receita";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo_contabilidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código  Contabilidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // Btn_Selecionar
            // 
            this.Btn_Selecionar.HeaderText = "Selecionar";
            this.Btn_Selecionar.Name = "Btn_Selecionar";
            this.Btn_Selecionar.ReadOnly = true;
            this.Btn_Selecionar.Text = "Selecionar";
            this.Btn_Selecionar.UseColumnTextForButtonValue = true;
            // 
            // TelaTipoReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 415);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.tipos_ReceitaDataGridView);
            this.Controls.Add(this.gb_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaTipoReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Receita";
            this.Load += new System.EventHandler(this.TelaTipoReceita_Load);
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_ReceitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_ReceitaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.BindingSource tipos_ReceitaBindingSource;
        private System.Windows.Forms.DataGridView tipos_ReceitaDataGridView;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Receita;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Selecionar;
    }
}