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
            this.dGV_BaseTitulosRecebidosXNomeBanco = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBanco();
            this.base_Titulos_RecebidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_Titulos_RecebidosTableAdapter = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.Base_Titulos_RecebidosTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.TableAdapterManager();
            this.base_Titulos_RecebidosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosDataGridView)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(949, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________________";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(759, 473);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(84, 32);
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
            this.groupBox1.Size = new System.Drawing.Size(893, 410);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Código";
            // 
            // dGV_BaseTitulosRecebidosXNomeBanco
            // 
            this.dGV_BaseTitulosRecebidosXNomeBanco.DataSetName = "DGV_BaseTitulosRecebidosXNomeBanco";
            this.dGV_BaseTitulosRecebidosXNomeBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // base_Titulos_RecebidosBindingSource
            // 
            this.base_Titulos_RecebidosBindingSource.DataMember = "Base_Titulos_Recebidos";
            this.base_Titulos_RecebidosBindingSource.DataSource = this.dGV_BaseTitulosRecebidosXNomeBanco;
            // 
            // base_Titulos_RecebidosTableAdapter
            // 
            this.base_Titulos_RecebidosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.DGV_BaseTitulosRecebidosXNomeBancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // base_Titulos_RecebidosDataGridView
            // 
            this.base_Titulos_RecebidosDataGridView.AllowUserToAddRows = false;
            this.base_Titulos_RecebidosDataGridView.AllowUserToDeleteRows = false;
            this.base_Titulos_RecebidosDataGridView.AutoGenerateColumns = false;
            this.base_Titulos_RecebidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_Titulos_RecebidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.Selecionar});
            this.base_Titulos_RecebidosDataGridView.DataSource = this.base_Titulos_RecebidosBindingSource;
            this.base_Titulos_RecebidosDataGridView.Location = new System.Drawing.Point(6, 19);
            this.base_Titulos_RecebidosDataGridView.Name = "base_Titulos_RecebidosDataGridView";
            this.base_Titulos_RecebidosDataGridView.ReadOnly = true;
            this.base_Titulos_RecebidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.base_Titulos_RecebidosDataGridView.Size = new System.Drawing.Size(881, 385);
            this.base_Titulos_RecebidosDataGridView.TabIndex = 0;
            this.base_Titulos_RecebidosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.base_Titulos_RecebidosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Base_Titulos_a_Recebidos";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Base Títulos Recebidos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data_Recebimento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Recebimento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total_Recebido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total Recebido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Banco_Creditado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Banco Creditado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nome_Banco";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome Banco";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Historico";
            this.dataGridViewTextBoxColumn5.HeaderText = "Histórico";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.ToolTipText = "Selecione o Código";
            this.Selecionar.UseColumnTextForButtonValue = true;
            // 
            // TelaBaseTitulosRecebidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 517);
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
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BaseTitulosRecebidosXNomeBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_Titulos_RecebidosDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView base_Titulos_RecebidosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}