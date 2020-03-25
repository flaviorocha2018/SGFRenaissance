namespace SGFRenaissance
{
    partial class FormEscolherBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscolherBanco));
            this.label1 = new System.Windows.Forms.Label();
            this._lblLinha = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.bancosDGV = new SGFRenaissance.BancosDGV();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancosTableAdapter = new SGFRenaissance.BancosDGVTableAdapters.BancosTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.BancosDGVTableAdapters.TableAdapterManager();
            this.bancosDataGridView = new System.Windows.Forms.DataGridView();
            this.Cod_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 121;
            this.label1.Text = "Selecione o Banco para a Operação";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-63, 34);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(680, 18);
            this._lblLinha.TabIndex = 122;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "___";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(442, 278);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(93, 33);
            this.btn_fechar.TabIndex = 124;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            this.Cod_Banco,
            this.nome_banco,
            this.Selecionar});
            this.bancosDataGridView.DataSource = this.bancosBindingSource;
            this.bancosDataGridView.Location = new System.Drawing.Point(3, 65);
            this.bancosDataGridView.Name = "bancosDataGridView";
            this.bancosDataGridView.ReadOnly = true;
            this.bancosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bancosDataGridView.Size = new System.Drawing.Size(532, 194);
            this.bancosDataGridView.TabIndex = 125;
            this.bancosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bancosDataGridView_CellContentClick);
            // 
            // Cod_Banco
            // 
            this.Cod_Banco.DataPropertyName = "Cod_Banco";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Cod_Banco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod_Banco.HeaderText = "Código Banco";
            this.Cod_Banco.Name = "Cod_Banco";
            this.Cod_Banco.ReadOnly = true;
            // 
            // nome_banco
            // 
            this.nome_banco.DataPropertyName = "Nome_Banco";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nome_banco.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome_banco.HeaderText = "Nome do Banco";
            this.nome_banco.Name = "nome_banco";
            this.nome_banco.ReadOnly = true;
            this.nome_banco.Width = 255;
            // 
            // Selecionar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            this.Selecionar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.ToolTipText = "Selecione o Banco";
            this.Selecionar.UseColumnTextForButtonValue = true;
            this.Selecionar.Width = 125;
            // 
            // FormEscolherBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 320);
            this.Controls.Add(this.bancosDataGridView);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEscolherBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Banco para Operação";
            this.Load += new System.EventHandler(this.FormEscolherBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Button btn_fechar;
        private BancosDGV bancosDGV;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private BancosDGVTableAdapters.BancosTableAdapter bancosTableAdapter;
        private BancosDGVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bancosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_banco;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}