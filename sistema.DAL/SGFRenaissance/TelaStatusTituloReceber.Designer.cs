namespace SGFRenaissance
{
    partial class TelaStatusTituloReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaStatusTituloReceber));
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.status_Titulos_a_ReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.status_Titulos_a_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cod_Status_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_Titulos_a_ReceberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_Titulos_a_ReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.btn_consulta);
            this.gb_Consulta.Controls.Add(this.txt_Consulta);
            this.gb_Consulta.Location = new System.Drawing.Point(1, 12);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(453, 74);
            this.gb_Consulta.TabIndex = 3;
            this.gb_Consulta.TabStop = false;
            this.gb_Consulta.Text = "Consulta Status Título a Receber";
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta.Image")));
            this.btn_consulta.Location = new System.Drawing.Point(332, 19);
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
            this.txt_Consulta.Size = new System.Drawing.Size(300, 23);
            this.txt_Consulta.TabIndex = 0;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(179, 300);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(95, 34);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // status_Titulos_a_ReceberDataGridView
            // 
            this.status_Titulos_a_ReceberDataGridView.AllowUserToAddRows = false;
            this.status_Titulos_a_ReceberDataGridView.AllowUserToDeleteRows = false;
            this.status_Titulos_a_ReceberDataGridView.AutoGenerateColumns = false;
            this.status_Titulos_a_ReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.status_Titulos_a_ReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Status_Titulo,
            this.dataGridViewTextBoxColumn2,
            this.Selecionar});
            this.status_Titulos_a_ReceberDataGridView.DataSource = this.status_Titulos_a_ReceberBindingSource;
            this.status_Titulos_a_ReceberDataGridView.Location = new System.Drawing.Point(1, 92);
            this.status_Titulos_a_ReceberDataGridView.Name = "status_Titulos_a_ReceberDataGridView";
            this.status_Titulos_a_ReceberDataGridView.ReadOnly = true;
            this.status_Titulos_a_ReceberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.status_Titulos_a_ReceberDataGridView.Size = new System.Drawing.Size(453, 190);
            this.status_Titulos_a_ReceberDataGridView.TabIndex = 6;
            this.status_Titulos_a_ReceberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.status_Titulos_a_ReceberDataGridView_CellContentClick);
            // 
            // status_Titulos_a_ReceberBindingSource
            // 
            this.status_Titulos_a_ReceberBindingSource.DataSource = typeof(sistema.DAL.Status_Titulos_a_Receber);
            // 
            // Cod_Status_Titulo
            // 
            this.Cod_Status_Titulo.DataPropertyName = "Codigo_Status_Tit_a_Receber";
            this.Cod_Status_Titulo.HeaderText = "Cód. Status Título a Receber";
            this.Cod_Status_Titulo.Name = "Cod_Status_Titulo";
            this.Cod_Status_Titulo.ReadOnly = true;
            this.Cod_Status_Titulo.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao_Status";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 120;
            // 
            // TelaStatusTituloReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 346);
            this.Controls.Add(this.status_Titulos_a_ReceberDataGridView);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.gb_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaStatusTituloReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Status Título a Receber";
            this.Load += new System.EventHandler(this.TelaStatusTituloReceber_Load);
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_Titulos_a_ReceberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_Titulos_a_ReceberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.BindingSource status_Titulos_a_ReceberBindingSource;
        private System.Windows.Forms.DataGridView status_Titulos_a_ReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Status_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}