namespace SGFRenaissance
{
    partial class TelaBaseTitulosRecebidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBaseTitulosRecebidos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.base_Titulos_RecebidosDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalRecebido = new System.Windows.Forms.TextBox();
            this.baseTitulosRecebidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGV_BaseTitulosRecebidosXNomeBanco = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBanco();
            this.base_Titulos_RecebidosTableAdapter = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.Base_Titulos_RecebidosTableAdapter();
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Recebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoCreditadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTitulosRecebidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE O CÓDIGO DE TÍTULOS RECEBIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1075, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(760, 477);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(90, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.base_Titulos_RecebidosDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(1, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 427);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Código";
            // 
            // base_Titulos_RecebidosDataGridView
            // 
            this.base_Titulos_RecebidosDataGridView.AllowUserToAddRows = false;
            this.base_Titulos_RecebidosDataGridView.AllowUserToDeleteRows = false;
            this.base_Titulos_RecebidosDataGridView.AutoGenerateColumns = false;
            this.base_Titulos_RecebidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_Titulos_RecebidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn,
            this.dataRecebimentoDataGridViewTextBoxColumn,
            this.Total_Recebido,
            this.NumeroNF,
            this.bancoCreditadoDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.nomeBancoDataGridViewTextBoxColumn,
            this.Selecionar});
            this.base_Titulos_RecebidosDataGridView.DataSource = this.baseTitulosRecebidosBindingSource;
            this.base_Titulos_RecebidosDataGridView.Location = new System.Drawing.Point(6, 32);
            this.base_Titulos_RecebidosDataGridView.Name = "base_Titulos_RecebidosDataGridView";
            this.base_Titulos_RecebidosDataGridView.ReadOnly = true;
            this.base_Titulos_RecebidosDataGridView.Size = new System.Drawing.Size(1046, 375);
            this.base_Titulos_RecebidosDataGridView.TabIndex = 0;
            this.base_Titulos_RecebidosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.base_Titulos_RecebidosDataGridView_CellContentClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Recebido:";
            // 
            // textBoxTotalRecebido
            // 
            this.textBoxTotalRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalRecebido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxTotalRecebido.Location = new System.Drawing.Point(611, 481);
            this.textBoxTotalRecebido.Name = "textBoxTotalRecebido";
            this.textBoxTotalRecebido.Size = new System.Drawing.Size(106, 22);
            this.textBoxTotalRecebido.TabIndex = 6;
            this.textBoxTotalRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseTitulosRecebidosBindingSource
            // 
            this.baseTitulosRecebidosBindingSource.DataMember = "Base_Titulos_Recebidos";
            this.baseTitulosRecebidosBindingSource.DataSource = this.dGV_BaseTitulosRecebidosXNomeBanco;
            // 
            // dGV_BaseTitulosRecebidosXNomeBanco
            // 
            this.dGV_BaseTitulosRecebidosXNomeBanco.DataSetName = "DGV_BaseTitulosRecebidosXNomeBanco";
            this.dGV_BaseTitulosRecebidosXNomeBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // base_Titulos_RecebidosTableAdapter
            // 
            this.base_Titulos_RecebidosTableAdapter.ClearBeforeFill = true;
            // 
            // codBaseTitulosaRecebidosDataGridViewTextBoxColumn
            // 
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.DataPropertyName = "Cod_Base_Titulos_a_Recebidos";
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.HeaderText = "Cod. Base Tit. Recebidos";
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.Name = "codBaseTitulosaRecebidosDataGridViewTextBoxColumn";
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRecebimentoDataGridViewTextBoxColumn
            // 
            this.dataRecebimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Recebimento";
            this.dataRecebimentoDataGridViewTextBoxColumn.HeaderText = "Data Rcebnto.";
            this.dataRecebimentoDataGridViewTextBoxColumn.Name = "dataRecebimentoDataGridViewTextBoxColumn";
            this.dataRecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Total_Recebido
            // 
            this.Total_Recebido.DataPropertyName = "Total_Recebido";
            this.Total_Recebido.HeaderText = "Total Recebido";
            this.Total_Recebido.Name = "Total_Recebido";
            this.Total_Recebido.ReadOnly = true;
            this.Total_Recebido.Width = 110;
            // 
            // NumeroNF
            // 
            this.NumeroNF.DataPropertyName = "NumeroNF";
            this.NumeroNF.HeaderText = "Nº NF";
            this.NumeroNF.Name = "NumeroNF";
            this.NumeroNF.ReadOnly = true;
            this.NumeroNF.Width = 63;
            // 
            // bancoCreditadoDataGridViewTextBoxColumn
            // 
            this.bancoCreditadoDataGridViewTextBoxColumn.DataPropertyName = "Banco_Creditado";
            this.bancoCreditadoDataGridViewTextBoxColumn.HeaderText = "Banco Creditado";
            this.bancoCreditadoDataGridViewTextBoxColumn.Name = "bancoCreditadoDataGridViewTextBoxColumn";
            this.bancoCreditadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bancoCreditadoDataGridViewTextBoxColumn.Width = 70;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            this.historicoDataGridViewTextBoxColumn.DataPropertyName = "Historico";
            this.historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            this.historicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.historicoDataGridViewTextBoxColumn.Width = 298;
            // 
            // nomeBancoDataGridViewTextBoxColumn
            // 
            this.nomeBancoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Banco";
            this.nomeBancoDataGridViewTextBoxColumn.HeaderText = "Nome do Banco";
            this.nomeBancoDataGridViewTextBoxColumn.Name = "nomeBancoDataGridViewTextBoxColumn";
            this.nomeBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeBancoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 112;
            // 
            // TelaBaseTitulosRecebidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 517);
            this.Controls.Add(this.textBoxTotalRecebido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaBaseTitulosRecebidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Títulos Recebidos";
            this.Load += new System.EventHandler(this.TelaBaseTitulosRecebidos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTitulosRecebidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalRecebido;
        private System.Windows.Forms.DataGridView base_Titulos_RecebidosDataGridView;
        private DGV_BaseTitulosRecebidosXNomeBanco dGV_BaseTitulosRecebidosXNomeBanco;
        private System.Windows.Forms.BindingSource baseTitulosRecebidosBindingSource;
        private DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.Base_Titulos_RecebidosTableAdapter base_Titulos_RecebidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBaseTitulosaRecebidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Recebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoCreditadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}