namespace SGFRenaissance
{
    partial class TelaBaseTitulosPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBaseTitulosPagos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_titulospagos = new System.Windows.Forms.GroupBox();
            this.base_Titulos_PagosDataGridView = new System.Windows.Forms.DataGridView();
            this.base_Titulos_PagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGV_BaseTitulosPagosXNomeBanco = new SGFRenaissance.DGV_BaseTitulosPagosXNomeBanco();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.base_Titulos_PagosTableAdapter = new SGFRenaissance.DGV_BaseTitulosPagosXNomeBancoTableAdapters.Base_Titulos_PagosTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.DGV_BaseTitulosPagosXNomeBancoTableAdapters.TableAdapterManager();
            this.textboxTotalPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_titulospagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_PagosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_PagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosPagosXNomeBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECIONE O CÓDIGO DE TÍTULOS PAGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(949, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________________";
            // 
            // groupBox_titulospagos
            // 
            this.groupBox_titulospagos.Controls.Add(this.base_Titulos_PagosDataGridView);
            this.groupBox_titulospagos.Location = new System.Drawing.Point(3, 49);
            this.groupBox_titulospagos.Name = "groupBox_titulospagos";
            this.groupBox_titulospagos.Size = new System.Drawing.Size(929, 370);
            this.groupBox_titulospagos.TabIndex = 3;
            this.groupBox_titulospagos.TabStop = false;
            this.groupBox_titulospagos.Text = "Selecione o Código Títulos Pagos";
            // 
            // base_Titulos_PagosDataGridView
            // 
            this.base_Titulos_PagosDataGridView.AllowUserToAddRows = false;
            this.base_Titulos_PagosDataGridView.AllowUserToDeleteRows = false;
            this.base_Titulos_PagosDataGridView.AutoGenerateColumns = false;
            this.base_Titulos_PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_Titulos_PagosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Total_Pago,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Selecionar});
            this.base_Titulos_PagosDataGridView.DataSource = this.base_Titulos_PagosBindingSource;
            this.base_Titulos_PagosDataGridView.Location = new System.Drawing.Point(9, 30);
            this.base_Titulos_PagosDataGridView.Name = "base_Titulos_PagosDataGridView";
            this.base_Titulos_PagosDataGridView.ReadOnly = true;
            this.base_Titulos_PagosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.base_Titulos_PagosDataGridView.Size = new System.Drawing.Size(914, 325);
            this.base_Titulos_PagosDataGridView.TabIndex = 0;
            this.base_Titulos_PagosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.base_Titulos_PagosDataGridView_CellContentClick);
            // 
            // base_Titulos_PagosBindingSource
            // 
            this.base_Titulos_PagosBindingSource.DataMember = "Base_Titulos_Pagos";
            this.base_Titulos_PagosBindingSource.DataSource = this.dGV_BaseTitulosPagosXNomeBanco;
            // 
            // dGV_BaseTitulosPagosXNomeBanco
            // 
            this.dGV_BaseTitulosPagosXNomeBanco.DataSetName = "DGV_BaseTitulosPagosXNomeBanco";
            this.dGV_BaseTitulosPagosXNomeBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(802, 427);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(81, 32);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // base_Titulos_PagosTableAdapter
            // 
            this.base_Titulos_PagosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.DGV_BaseTitulosPagosXNomeBancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textboxTotalPago
            // 
            this.textboxTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTotalPago.ForeColor = System.Drawing.Color.Red;
            this.textboxTotalPago.Location = new System.Drawing.Point(641, 434);
            this.textboxTotalPago.Name = "textboxTotalPago";
            this.textboxTotalPago.Size = new System.Drawing.Size(114, 22);
            this.textboxTotalPago.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total de Títulos Pagos:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Base_Titulos_Pagos";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.  Base Títulos Pagos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data_Pagamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Pagamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // Total_Pago
            // 
            this.Total_Pago.DataPropertyName = "Total_Pago";
            this.Total_Pago.HeaderText = "Total Pago";
            this.Total_Pago.Name = "Total_Pago";
            this.Total_Pago.ReadOnly = true;
            this.Total_Pago.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Banco_Debitado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Banco Debitado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome_Banco";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome Banco";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numero_Cheque";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nº Cheque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Historico";
            this.dataGridViewTextBoxColumn6.HeaderText = "Historico";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.ToolTipText = "Selecione o Código";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 128;
            // 
            // TelaBaseTitulosPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxTotalPago);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.groupBox_titulospagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaBaseTitulosPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Títulos Pagos";
            this.Load += new System.EventHandler(this.TelaBaseTitulosPagos_Load);
            this.groupBox_titulospagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_PagosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_PagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosPagosXNomeBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_titulospagos;
        private System.Windows.Forms.Button btn_fechar;
        private DGV_BaseTitulosPagosXNomeBanco dGV_BaseTitulosPagosXNomeBanco;
        private System.Windows.Forms.BindingSource base_Titulos_PagosBindingSource;
        private DGV_BaseTitulosPagosXNomeBancoTableAdapters.Base_Titulos_PagosTableAdapter base_Titulos_PagosTableAdapter;
        private DGV_BaseTitulosPagosXNomeBancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView base_Titulos_PagosDataGridView;
        private System.Windows.Forms.TextBox textboxTotalPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}