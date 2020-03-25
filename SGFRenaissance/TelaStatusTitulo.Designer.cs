namespace SGFRenaissance
{
    partial class TelaStatusTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaStatusTitulo));
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusTituloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_fechar = new System.Windows.Forms.Button();
            this.Cod_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoStatusTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SelecionarParcela = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Consulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTituloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.btn_consulta);
            this.gb_Consulta.Controls.Add(this.txt_Consulta);
            this.gb_Consulta.Location = new System.Drawing.Point(5, 12);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(565, 74);
            this.gb_Consulta.TabIndex = 2;
            this.gb_Consulta.TabStop = false;
            this.gb_Consulta.Text = "Consulta Status do Título";
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta.Image")));
            this.btn_consulta.Location = new System.Drawing.Point(445, 19);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(94, 42);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Consulta.Location = new System.Drawing.Point(17, 32);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(385, 23);
            this.txt_Consulta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status do Título";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Status,
            this.descricaoStatusTituloDataGridViewTextBoxColumn,
            this.Selecionar,
            this.SelecionarParcela});
            this.dataGridView1.DataSource = this.statusTituloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusTituloBindingSource
            // 
            this.statusTituloBindingSource.DataSource = typeof(sistema.DAL.Status_Titulo);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(450, 343);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(86, 30);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Cod_Status
            // 
            this.Cod_Status.DataPropertyName = "Cod_Status_Titulo";
            this.Cod_Status.HeaderText = "Código";
            this.Cod_Status.Name = "Cod_Status";
            this.Cod_Status.ReadOnly = true;
            this.Cod_Status.Width = 60;
            // 
            // descricaoStatusTituloDataGridViewTextBoxColumn
            // 
            this.descricaoStatusTituloDataGridViewTextBoxColumn.DataPropertyName = "Descricao_Status_Titulo";
            this.descricaoStatusTituloDataGridViewTextBoxColumn.HeaderText = " Status do Título";
            this.descricaoStatusTituloDataGridViewTextBoxColumn.Name = "descricaoStatusTituloDataGridViewTextBoxColumn";
            this.descricaoStatusTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoStatusTituloDataGridViewTextBoxColumn.Width = 220;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar Título";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar Título";
            this.Selecionar.UseColumnTextForButtonValue = true;
            // 
            // SelecionarParcela
            // 
            this.SelecionarParcela.HeaderText = "Selecionar Parcela";
            this.SelecionarParcela.Name = "SelecionarParcela";
            this.SelecionarParcela.ReadOnly = true;
            this.SelecionarParcela.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelecionarParcela.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelecionarParcela.Text = "Selecionar Parcela";
            this.SelecionarParcela.UseColumnTextForButtonValue = true;
            this.SelecionarParcela.Width = 120;
            // 
            // TelaStatusTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 385);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaStatusTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusTítulo a Pagar";
            this.Load += new System.EventHandler(this.TelaStatusTitulo_Load);
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTituloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource statusTituloBindingSource;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoStatusTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
        private System.Windows.Forms.DataGridViewButtonColumn SelecionarParcela;
    }
}