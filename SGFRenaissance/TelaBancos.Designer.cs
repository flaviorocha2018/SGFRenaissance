namespace SGFRenaissance
{
    partial class TelaBancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBancos));
            this._lblLinha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.bancosDGV = new SGFRenaissance.BancosDGV();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancosTableAdapter = new SGFRenaissance.BancosDGVTableAdapters.BancosTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.BancosDGVTableAdapters.TableAdapterManager();
            this.bancosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-140, 34);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(776, 18);
            this._lblLinha.TabIndex = 118;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "_______________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 119;
            this.label1.Text = "Selecione o Banco para a Operação";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Location = new System.Drawing.Point(419, 268);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(93, 34);
            this.Btn_Fechar.TabIndex = 121;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Selecionar});
            this.bancosDataGridView.DataSource = this.bancosBindingSource;
            this.bancosDataGridView.Location = new System.Drawing.Point(1, 65);
            this.bancosDataGridView.Name = "bancosDataGridView";
            this.bancosDataGridView.ReadOnly = true;
            this.bancosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bancosDataGridView.Size = new System.Drawing.Size(522, 187);
            this.bancosDataGridView.TabIndex = 122;
            this.bancosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bancosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Banco";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.Banco";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Banco";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Banco";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 270;
            // 
            // Selecionar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecionar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 120;
            // 
            // TelaBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 323);
            this.Controls.Add(this.bancosDataGridView);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblLinha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Banco";
            this.Load += new System.EventHandler(this.TelaBancos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Fechar;
        private BancosDGV bancosDGV;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private BancosDGVTableAdapters.BancosTableAdapter bancosTableAdapter;
        private BancosDGVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bancosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}