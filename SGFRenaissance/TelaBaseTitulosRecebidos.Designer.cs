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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBaseTitulosRecebidos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.base_Titulos_RecebidosDataGridView = new System.Windows.Forms.DataGridView();
            this.base_Titulos_RecebidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGV_BaseTitulosRecebidosXNomeBanco = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBanco();
            this.base_Titulos_RecebidosTableAdapter = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.Base_Titulos_RecebidosTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalRecebido = new System.Windows.Forms.TextBox();
            this.dGV_BaseTitulosRecebidosXNomeBanco1 = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBanco();
            this.dGVBaseTitulosRecebidosXNomeBanco1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Recebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoCreditadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBaseTitulosRecebidosXNomeBanco1BindingSource)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1044, 410);
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
            this.Numero_Documento,
            this.Total_Recebido,
            this.bancoCreditadoDataGridViewTextBoxColumn,
            this.nomeBancoDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.Selecionar});
            this.base_Titulos_RecebidosDataGridView.DataSource = this.base_Titulos_RecebidosBindingSource;
            this.base_Titulos_RecebidosDataGridView.Location = new System.Drawing.Point(6, 32);
            this.base_Titulos_RecebidosDataGridView.Name = "base_Titulos_RecebidosDataGridView";
            this.base_Titulos_RecebidosDataGridView.ReadOnly = true;
            this.base_Titulos_RecebidosDataGridView.Size = new System.Drawing.Size(1038, 375);
            this.base_Titulos_RecebidosDataGridView.TabIndex = 0;
            this.base_Titulos_RecebidosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.base_Titulos_RecebidosDataGridView_CellContentClick_1);
            // 
            // base_Titulos_RecebidosBindingSource
            // 
            this.base_Titulos_RecebidosBindingSource.DataMember = "Base_Titulos_Recebidos";
            this.base_Titulos_RecebidosBindingSource.DataSource = this.dGV_BaseTitulosRecebidosXNomeBanco;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Base_Parcelas_RecebidasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // dGV_BaseTitulosRecebidosXNomeBanco1
            // 
            this.dGV_BaseTitulosRecebidosXNomeBanco1.DataSetName = "DGV_BaseTitulosRecebidosXNomeBanco";
            this.dGV_BaseTitulosRecebidosXNomeBanco1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dGVBaseTitulosRecebidosXNomeBanco1BindingSource
            // 
            this.dGVBaseTitulosRecebidosXNomeBanco1BindingSource.DataSource = this.dGV_BaseTitulosRecebidosXNomeBanco1;
            this.dGVBaseTitulosRecebidosXNomeBanco1BindingSource.Position = 0;
            // 
            // codBaseTitulosaRecebidosDataGridViewTextBoxColumn
            // 
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.DataPropertyName = "Cod_Base_Titulos_a_Recebidos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.HeaderText = "Cód. Base Tít. Recebidos";
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.Name = "codBaseTitulosaRecebidosDataGridViewTextBoxColumn";
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBaseTitulosaRecebidosDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataRecebimentoDataGridViewTextBoxColumn
            // 
            this.dataRecebimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Recebimento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataRecebimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRecebimentoDataGridViewTextBoxColumn.HeaderText = "Data Recebimento";
            this.dataRecebimentoDataGridViewTextBoxColumn.Name = "dataRecebimentoDataGridViewTextBoxColumn";
            this.dataRecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRecebimentoDataGridViewTextBoxColumn.Width = 90;
            // 
            // Numero_Documento
            // 
            this.Numero_Documento.DataPropertyName = "Numero_Documento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Numero_Documento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Numero_Documento.HeaderText = "Nº Nota Fiscal";
            this.Numero_Documento.Name = "Numero_Documento";
            this.Numero_Documento.ReadOnly = true;
            this.Numero_Documento.Width = 55;
            // 
            // Total_Recebido
            // 
            this.Total_Recebido.DataPropertyName = "Total_Recebido";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Total_Recebido.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total_Recebido.HeaderText = "Total Recebido";
            this.Total_Recebido.Name = "Total_Recebido";
            this.Total_Recebido.ReadOnly = true;
            this.Total_Recebido.Width = 95;
            // 
            // bancoCreditadoDataGridViewTextBoxColumn
            // 
            this.bancoCreditadoDataGridViewTextBoxColumn.DataPropertyName = "Banco_Creditado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.bancoCreditadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.bancoCreditadoDataGridViewTextBoxColumn.HeaderText = "Banco Creditado";
            this.bancoCreditadoDataGridViewTextBoxColumn.Name = "bancoCreditadoDataGridViewTextBoxColumn";
            this.bancoCreditadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bancoCreditadoDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeBancoDataGridViewTextBoxColumn
            // 
            this.nomeBancoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Banco";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.nomeBancoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.nomeBancoDataGridViewTextBoxColumn.HeaderText = "Nome do Banco";
            this.nomeBancoDataGridViewTextBoxColumn.Name = "nomeBancoDataGridViewTextBoxColumn";
            this.nomeBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeBancoDataGridViewTextBoxColumn.Width = 140;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            this.historicoDataGridViewTextBoxColumn.DataPropertyName = "Historico";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.historicoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            this.historicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.historicoDataGridViewTextBoxColumn.Width = 354;
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
            // TelaBaseTitulosRecebidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 517);
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
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBaseTitulosRecebidosXNomeBanco1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private DGV_BaseTitulosRecebidosXNomeBanco dGV_BaseTitulosRecebidosXNomeBanco;
        private System.Windows.Forms.BindingSource base_Titulos_RecebidosBindingSource;
        private DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.Base_Titulos_RecebidosTableAdapter base_Titulos_RecebidosTableAdapter;
        private DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalRecebido;
        private System.Windows.Forms.DataGridView base_Titulos_RecebidosDataGridView;
        private DGV_BaseTitulosRecebidosXNomeBanco dGV_BaseTitulosRecebidosXNomeBanco1;
        private System.Windows.Forms.BindingSource dGVBaseTitulosRecebidosXNomeBanco1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBaseTitulosaRecebidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Recebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoCreditadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}