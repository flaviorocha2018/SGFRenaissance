namespace SGFRenaissance
{
    partial class BaseTitulosaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTitulosaReceber));
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblLinha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroParcelasaReceberDGV = new SGFRenaissance.NumeroParcelasaReceberDGV();
            this.numero_Parcelas_a_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numero_Parcelas_a_ReceberTableAdapter = new SGFRenaissance.NumeroParcelasaReceberDGVTableAdapters.Numero_Parcelas_a_ReceberTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.NumeroParcelasaReceberDGVTableAdapters.TableAdapterManager();
            this.numero_Parcelas_a_ReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaReceberDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_ReceberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this._lblLinha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 53);
            this.panel1.TabIndex = 1;
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-18, 26);
            this._lblLinha.Margin = new System.Windows.Forms.Padding(0);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(1144, 18);
            this._lblLinha.TabIndex = 125;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASE DE PARCELAS DE TÍTULOS A RECEBER  -  CONSULTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Controls.Add(this.textboxTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 55);
            this.panel2.TabIndex = 3;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(820, 10);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(95, 30);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // textboxTotal
            // 
            this.textboxTotal.Enabled = false;
            this.textboxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTotal.ForeColor = System.Drawing.Color.Red;
            this.textboxTotal.Location = new System.Drawing.Point(676, 14);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.ReadOnly = true;
            this.textboxTotal.Size = new System.Drawing.Size(119, 21);
            this.textboxTotal.TabIndex = 1;
            this.textboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(393, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de Parcelas de Títulos a Receber: ";
            // 
            // numeroParcelasaReceberDGV
            // 
            this.numeroParcelasaReceberDGV.DataSetName = "NumeroParcelasaReceberDGV";
            this.numeroParcelasaReceberDGV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numero_Parcelas_a_ReceberBindingSource
            // 
            this.numero_Parcelas_a_ReceberBindingSource.DataMember = "Numero_Parcelas_a_Receber";
            this.numero_Parcelas_a_ReceberBindingSource.DataSource = this.numeroParcelasaReceberDGV;
            // 
            // numero_Parcelas_a_ReceberTableAdapter
            // 
            this.numero_Parcelas_a_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Status_Titulos_a_ReceberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.NumeroParcelasaReceberDGVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numero_Parcelas_a_ReceberDataGridView
            // 
            this.numero_Parcelas_a_ReceberDataGridView.AllowUserToAddRows = false;
            this.numero_Parcelas_a_ReceberDataGridView.AllowUserToDeleteRows = false;
            this.numero_Parcelas_a_ReceberDataGridView.AutoGenerateColumns = false;
            this.numero_Parcelas_a_ReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numero_Parcelas_a_ReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Valor_Parcela,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.numero_Parcelas_a_ReceberDataGridView.DataSource = this.numero_Parcelas_a_ReceberBindingSource;
            this.numero_Parcelas_a_ReceberDataGridView.Location = new System.Drawing.Point(1, 62);
            this.numero_Parcelas_a_ReceberDataGridView.Name = "numero_Parcelas_a_ReceberDataGridView";
            this.numero_Parcelas_a_ReceberDataGridView.ReadOnly = true;
            this.numero_Parcelas_a_ReceberDataGridView.Size = new System.Drawing.Size(974, 425);
            this.numero_Parcelas_a_ReceberDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Entrada_Titulos_a_Receber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Entr. Tit. a Receber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_Numero_Parcelas_Receber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cód. Nº  Parc. a Receber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Numero_Parcela";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nº Parcela";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_Vencimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Valor_Parcela
            // 
            this.Valor_Parcela.DataPropertyName = "Valor_Parcela";
            this.Valor_Parcela.HeaderText = "Valor Parcela";
            this.Valor_Parcela.Name = "Valor_Parcela";
            this.Valor_Parcela.ReadOnly = true;
            this.Valor_Parcela.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Historico";
            this.dataGridViewTextBoxColumn6.HeaderText = "Histórico";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cod_Status_Titulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cód. Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descricao_Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descrição Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // BaseTitulosaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 568);
            this.Controls.Add(this.numero_Parcelas_a_ReceberDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseTitulosaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Parcelas de Títulos a Receber";
            this.Load += new System.EventHandler(this.BaseTitulosaReceber_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaReceberDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_ReceberDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.Label label2;
        private NumeroParcelasaReceberDGV numeroParcelasaReceberDGV;
        private System.Windows.Forms.BindingSource numero_Parcelas_a_ReceberBindingSource;
        private NumeroParcelasaReceberDGVTableAdapters.Numero_Parcelas_a_ReceberTableAdapter numero_Parcelas_a_ReceberTableAdapter;
        private NumeroParcelasaReceberDGVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView numero_Parcelas_a_ReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}