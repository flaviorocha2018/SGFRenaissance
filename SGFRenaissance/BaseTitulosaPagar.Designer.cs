namespace SGFRenaissance
{
    partial class BaseTitulosaPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTitulosaPagar));
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblLinha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TotalGeral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numero_Parcelas_a_PagarTableAdapter = new SGFRenaissance.DGVNumeroParcelasPagarTableAdapters.Numero_Parcelas_a_PagarTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.DGVNumeroParcelasPagarTableAdapters.TableAdapterManager();
            this.dataGridViewNumeroParcelas = new System.Windows.Forms.DataGridView();
            this.dGVNumeroParcelasPagar1 = new SGFRenaissance.DGVNumeroParcelasPagar();
            this.numeroParcelasaPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codStatusTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoStatusTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumeroParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumeroParcelasPagar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this._lblLinha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 53);
            this.panel1.TabIndex = 0;
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-20, 23);
            this._lblLinha.Margin = new System.Windows.Forms.Padding(0);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(1264, 18);
            this._lblLinha.TabIndex = 125;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASE DE PARCELAS DE  TÍTULOS A PAGAR  -  CONSULTA";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(882, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(95, 30);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Controls.Add(this.txt_TotalGeral);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 55);
            this.panel2.TabIndex = 0;
            // 
            // txt_TotalGeral
            // 
            this.txt_TotalGeral.Enabled = false;
            this.txt_TotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalGeral.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalGeral.Location = new System.Drawing.Point(734, 16);
            this.txt_TotalGeral.Name = "txt_TotalGeral";
            this.txt_TotalGeral.ReadOnly = true;
            this.txt_TotalGeral.Size = new System.Drawing.Size(117, 21);
            this.txt_TotalGeral.TabIndex = 1;
            this.txt_TotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(461, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de Parcelas de Títulos a Pagar: ";
            // 
            // numero_Parcelas_a_PagarTableAdapter
            // 
            this.numero_Parcelas_a_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.DGVNumeroParcelasPagarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewNumeroParcelas
            // 
            this.dataGridViewNumeroParcelas.AllowUserToAddRows = false;
            this.dataGridViewNumeroParcelas.AllowUserToDeleteRows = false;
            this.dataGridViewNumeroParcelas.AutoGenerateColumns = false;
            this.dataGridViewNumeroParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumeroParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn,
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn,
            this.numeroParcelaDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.Valor_Parcela,
            this.historicoDataGridViewTextBoxColumn,
            this.codStatusTituloDataGridViewTextBoxColumn,
            this.descricaoStatusTituloDataGridViewTextBoxColumn});
            this.dataGridViewNumeroParcelas.DataSource = this.numeroParcelasaPagarBindingSource;
            this.dataGridViewNumeroParcelas.Location = new System.Drawing.Point(2, 60);
            this.dataGridViewNumeroParcelas.Name = "dataGridViewNumeroParcelas";
            this.dataGridViewNumeroParcelas.ReadOnly = true;
            this.dataGridViewNumeroParcelas.Size = new System.Drawing.Size(1034, 407);
            this.dataGridViewNumeroParcelas.TabIndex = 1;
            // 
            // dGVNumeroParcelasPagar1
            // 
            this.dGVNumeroParcelasPagar1.DataSetName = "DGVNumeroParcelasPagar";
            this.dGVNumeroParcelasPagar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numeroParcelasaPagarBindingSource
            // 
            this.numeroParcelasaPagarBindingSource.DataMember = "Numero_Parcelas_a_Pagar";
            this.numeroParcelasaPagarBindingSource.DataSource = this.dGVNumeroParcelasPagar1;
            // 
            // codEntradaTitulosaPagarDataGridViewTextBoxColumn
            // 
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.DataPropertyName = "Cod_Entrada_Titulos_a_Pagar";
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.HeaderText = "Cód. Entrada Tít. a Pagar";
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.Name = "codEntradaTitulosaPagarDataGridViewTextBoxColumn";
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.Width = 80;
            // 
            // codNumeroParcelasaPagarDataGridViewTextBoxColumn
            // 
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn.DataPropertyName = "Cod_Numero_Parcelas_a_Pagar";
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn.HeaderText = "Cód. Nº Parc. a Pagar";
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn.Name = "codNumeroParcelasaPagarDataGridViewTextBoxColumn";
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn.ReadOnly = true;
            this.codNumeroParcelasaPagarDataGridViewTextBoxColumn.Width = 80;
            // 
            // numeroParcelaDataGridViewTextBoxColumn
            // 
            this.numeroParcelaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Parcela";
            this.numeroParcelaDataGridViewTextBoxColumn.HeaderText = "Nº Parcela";
            this.numeroParcelaDataGridViewTextBoxColumn.Name = "numeroParcelaDataGridViewTextBoxColumn";
            this.numeroParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroParcelaDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data Vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 90;
            // 
            // Valor_Parcela
            // 
            this.Valor_Parcela.DataPropertyName = "Valor_Parcela";
            this.Valor_Parcela.HeaderText = "Valor Parcela R$";
            this.Valor_Parcela.Name = "Valor_Parcela";
            this.Valor_Parcela.ReadOnly = true;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            this.historicoDataGridViewTextBoxColumn.DataPropertyName = "Historico";
            this.historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            this.historicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.historicoDataGridViewTextBoxColumn.Width = 355;
            // 
            // codStatusTituloDataGridViewTextBoxColumn
            // 
            this.codStatusTituloDataGridViewTextBoxColumn.DataPropertyName = "Cod_Status_Titulo";
            this.codStatusTituloDataGridViewTextBoxColumn.HeaderText = "Cód. Status Tit.";
            this.codStatusTituloDataGridViewTextBoxColumn.Name = "codStatusTituloDataGridViewTextBoxColumn";
            this.codStatusTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codStatusTituloDataGridViewTextBoxColumn.Width = 80;
            // 
            // descricaoStatusTituloDataGridViewTextBoxColumn
            // 
            this.descricaoStatusTituloDataGridViewTextBoxColumn.DataPropertyName = "Descricao_Status_Titulo";
            this.descricaoStatusTituloDataGridViewTextBoxColumn.HeaderText = "Descrição Status";
            this.descricaoStatusTituloDataGridViewTextBoxColumn.Name = "descricaoStatusTituloDataGridViewTextBoxColumn";
            this.descricaoStatusTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoStatusTituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // BaseTitulosaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 548);
            this.Controls.Add(this.dataGridViewNumeroParcelas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseTitulosaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Parcelas de Títulos a Pagar";
            this.Load += new System.EventHandler(this.BaseTitulosaPagar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumeroParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumeroParcelasPagar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaPagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TotalGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblLinha;
        private DGVNumeroParcelasPagarTableAdapters.Numero_Parcelas_a_PagarTableAdapter numero_Parcelas_a_PagarTableAdapter;
        private DGVNumeroParcelasPagarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewNumeroParcelas;
        private DGVNumeroParcelasPagar dGVNumeroParcelasPagar1;
        private System.Windows.Forms.BindingSource numeroParcelasaPagarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEntradaTitulosaPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codNumeroParcelasaPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codStatusTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoStatusTituloDataGridViewTextBoxColumn;
    }
}