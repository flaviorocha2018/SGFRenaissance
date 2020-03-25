namespace SGFRenaissance
{
    partial class TelaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.gb_Fornecedores = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientesContasaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_fechar = new System.Windows.Forms.Button();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Consulta.SuspendLayout();
            this.gb_Fornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesContasaReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.btn_consulta);
            this.gb_Consulta.Controls.Add(this.txt_Consulta);
            this.gb_Consulta.Location = new System.Drawing.Point(12, 12);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(512, 74);
            this.gb_Consulta.TabIndex = 1;
            this.gb_Consulta.TabStop = false;
            this.gb_Consulta.Text = "Consulta Clientes";
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
            // gb_Fornecedores
            // 
            this.gb_Fornecedores.Controls.Add(this.dataGridView1);
            this.gb_Fornecedores.Location = new System.Drawing.Point(12, 106);
            this.gb_Fornecedores.Name = "gb_Fornecedores";
            this.gb_Fornecedores.Size = new System.Drawing.Size(520, 365);
            this.gb_Fornecedores.TabIndex = 2;
            this.gb_Fornecedores.TabStop = false;
            this.gb_Fornecedores.Text = "Lista de Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCliente,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.Column_Selecionar});
            this.dataGridView1.DataSource = this.clientesContasaReceberBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(514, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientesContasaReceberBindingSource
            // 
            this.clientesContasaReceberBindingSource.DataSource = typeof(sistema.DAL.Clientes_Contas_a_Receber);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(226, 479);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(80, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // codCliente
            // 
            this.codCliente.DataPropertyName = "Cod_Cliente_Contas_a_Receber";
            this.codCliente.HeaderText = "Cód. Cliente";
            this.codCliente.Name = "codCliente";
            this.codCliente.ReadOnly = true;
            this.codCliente.Width = 80;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome  Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeClienteDataGridViewTextBoxColumn.Width = 280;
            // 
            // Column_Selecionar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Column_Selecionar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Selecionar.HeaderText = "Selecionar";
            this.Column_Selecionar.Name = "Column_Selecionar";
            this.Column_Selecionar.ReadOnly = true;
            this.Column_Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Selecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Selecionar.Text = "Selecionar";
            this.Column_Selecionar.UseColumnTextForButtonValue = true;
            this.Column_Selecionar.Width = 110;
            // 
            // TelaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.gb_Fornecedores);
            this.Controls.Add(this.gb_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaClientes";
            this.Load += new System.EventHandler(this.TelaClientes_Load);
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            this.gb_Fornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesContasaReceberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.GroupBox gb_Fornecedores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientesContasaReceberBindingSource;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Selecionar;
    }
}