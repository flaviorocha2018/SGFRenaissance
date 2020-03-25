namespace SGFRenaissance
{
    partial class TelaBancosNova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBancosNova));
            this.label1 = new System.Windows.Forms.Label();
            this._lblLinha = new System.Windows.Forms.Label();
            this.bancosDGV = new SGFRenaissance.BancosDGV();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancosTableAdapter = new SGFRenaissance.BancosDGVTableAdapters.BancosTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.BancosDGVTableAdapters.TableAdapterManager();
            this.bancosDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.Codigo_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "Selecione o Banco para Crédito";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-57, 34);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(680, 18);
            this._lblLinha.TabIndex = 121;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "___";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bancosDGV
            // 
            this.bancosDGV.DataSetName = "BancosDGV";
            this.bancosDGV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.bancosDGV;
            // 
            // bancosTableAdapter
            // 
            this.bancosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancosTableAdapter = this.bancosTableAdapter;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.BancosDGVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bancosDataGridView
            // 
            this.bancosDataGridView.AllowUserToAddRows = false;
            this.bancosDataGridView.AllowUserToDeleteRows = false;
            this.bancosDataGridView.AutoGenerateColumns = false;
            this.bancosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bancosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Banco,
            this.dataGridViewTextBoxColumn2,
            this.Selecionar});
            this.bancosDataGridView.DataSource = this.bancosBindingSource;
            this.bancosDataGridView.Location = new System.Drawing.Point(2, 67);
            this.bancosDataGridView.Name = "bancosDataGridView";
            this.bancosDataGridView.ReadOnly = true;
            this.bancosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bancosDataGridView.Size = new System.Drawing.Size(559, 220);
            this.bancosDataGridView.TabIndex = 122;
            this.bancosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bancosDataGridView_CellContentClick);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(456, 311);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(93, 33);
            this.btn_fechar.TabIndex = 123;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Codigo_Banco
            // 
            this.Codigo_Banco.DataPropertyName = "Cod_Banco";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_Banco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo_Banco.HeaderText = "Código do Banco";
            this.Codigo_Banco.Name = "Codigo_Banco";
            this.Codigo_Banco.ReadOnly = true;
            this.Codigo_Banco.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Banco";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Banco";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 270;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 130;
            // 
            // TelaBancosNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 368);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.bancosDataGridView);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaBancosNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Banco";
            this.Load += new System.EventHandler(this.TelaBancosNova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblLinha;
        private BancosDGV bancosDGV;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private BancosDGVTableAdapters.BancosTableAdapter bancosTableAdapter;
        private BancosDGVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bancosDataGridView;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}