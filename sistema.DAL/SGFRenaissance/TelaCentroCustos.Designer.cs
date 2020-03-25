namespace SGFRenaissance
{
    partial class TelaCentroCustos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCentroCustos));
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.gb_Centro_Custos = new System.Windows.Forms.GroupBox();
            this.dataGridView_centro_custos = new System.Windows.Forms.DataGridView();
            this.centroCustoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_fechar = new System.Windows.Forms.Button();
            this.codCentroCustos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCentroCustosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Consulta.SuspendLayout();
            this.gb_Centro_Custos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_centro_custos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroCustoBindingSource)).BeginInit();
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
            this.gb_Consulta.Text = "Consulta Centro de Custos";
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
            // gb_Centro_Custos
            // 
            this.gb_Centro_Custos.Controls.Add(this.dataGridView_centro_custos);
            this.gb_Centro_Custos.Location = new System.Drawing.Point(4, 92);
            this.gb_Centro_Custos.Name = "gb_Centro_Custos";
            this.gb_Centro_Custos.Size = new System.Drawing.Size(520, 368);
            this.gb_Centro_Custos.TabIndex = 2;
            this.gb_Centro_Custos.TabStop = false;
            this.gb_Centro_Custos.Text = "Lista de Centro de Custos";
            // 
            // dataGridView_centro_custos
            // 
            this.dataGridView_centro_custos.AllowUserToAddRows = false;
            this.dataGridView_centro_custos.AllowUserToDeleteRows = false;
            this.dataGridView_centro_custos.AutoGenerateColumns = false;
            this.dataGridView_centro_custos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_centro_custos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCentroCustos,
            this.descricaoCentroCustosDataGridViewTextBoxColumn,
            this.Selecionar});
            this.dataGridView_centro_custos.DataSource = this.centroCustoBindingSource;
            this.dataGridView_centro_custos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_centro_custos.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_centro_custos.Name = "dataGridView_centro_custos";
            this.dataGridView_centro_custos.ReadOnly = true;
            this.dataGridView_centro_custos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_centro_custos.Size = new System.Drawing.Size(514, 349);
            this.dataGridView_centro_custos.TabIndex = 0;
            this.dataGridView_centro_custos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_centro_custos_CellContentClick);
            // 
            // centroCustoBindingSource
            // 
            this.centroCustoBindingSource.DataSource = typeof(sistema.DAL.Centro_Custo);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(209, 466);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(86, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // codCentroCustos
            // 
            this.codCentroCustos.DataPropertyName = "Cod_Centro_Custos";
            this.codCentroCustos.HeaderText = "Código";
            this.codCentroCustos.Name = "codCentroCustos";
            this.codCentroCustos.ReadOnly = true;
            this.codCentroCustos.Width = 60;
            // 
            // descricaoCentroCustosDataGridViewTextBoxColumn
            // 
            this.descricaoCentroCustosDataGridViewTextBoxColumn.DataPropertyName = "Descricao_Centro_Custos";
            this.descricaoCentroCustosDataGridViewTextBoxColumn.HeaderText = "Descrição Centro de Custos";
            this.descricaoCentroCustosDataGridViewTextBoxColumn.Name = "descricaoCentroCustosDataGridViewTextBoxColumn";
            this.descricaoCentroCustosDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoCentroCustosDataGridViewTextBoxColumn.Width = 300;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 110;
            // 
            // TelaCentroCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 500);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.gb_Centro_Custos);
            this.Controls.Add(this.gb_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCentroCustos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCentroCustos";
            this.Load += new System.EventHandler(this.TelaCentroCustos_Load);
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            this.gb_Centro_Custos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_centro_custos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroCustoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.GroupBox gb_Centro_Custos;
        private System.Windows.Forms.DataGridView dataGridView_centro_custos;
        private System.Windows.Forms.BindingSource centroCustoBindingSource;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCentroCustos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoCentroCustosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}