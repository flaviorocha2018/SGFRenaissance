namespace SGFRenaissance
{
    partial class TelaBaseLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBaseLancamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lancamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGFRenaissanceDataSet3 = new SGFRenaissance.SGFRenaissanceDataSet3();
            this.lancamentosTableAdapter = new SGFRenaissance.SGFRenaissanceDataSet3TableAdapters.LancamentosTableAdapter();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.codLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOperacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBaseTitPagosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBaseTitRecebidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoOperacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recebimentoTitulosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoTitulosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMovimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoAnteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGFRenaissanceDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "LANÇAMENTOS BANCÁRIOS EFETUADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1225, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLancamentoDataGridViewTextBoxColumn,
            this.codOperacaoDataGridViewTextBoxColumn,
            this.codBaseTitPagosDataGridViewTextBoxColumn,
            this.codBaseTitRecebidosDataGridViewTextBoxColumn,
            this.codBancoDataGridViewTextBoxColumn,
            this.numeroChqueDataGridViewTextBoxColumn,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.descricaoOperacaoDataGridViewTextBoxColumn,
            this.recebimentoTitulosDataGridViewTextBoxColumn,
            this.pagamentoTitulosDataGridViewTextBoxColumn,
            this.valorMovimentoDataGridViewTextBoxColumn,
            this.saldoAnteriorDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lancamentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 425);
            this.dataGridView1.TabIndex = 4;
            // 
            // lancamentosBindingSource
            // 
            this.lancamentosBindingSource.DataMember = "Lancamentos";
            this.lancamentosBindingSource.DataSource = this.sGFRenaissanceDataSet3;
            // 
            // sGFRenaissanceDataSet3
            // 
            this.sGFRenaissanceDataSet3.DataSetName = "SGFRenaissanceDataSet3";
            this.sGFRenaissanceDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lancamentosTableAdapter
            // 
            this.lancamentosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(1037, 497);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(106, 30);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // codLancamentoDataGridViewTextBoxColumn
            // 
            this.codLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Lancamento";
            this.codLancamentoDataGridViewTextBoxColumn.HeaderText = "Id.";
            this.codLancamentoDataGridViewTextBoxColumn.Name = "codLancamentoDataGridViewTextBoxColumn";
            this.codLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLancamentoDataGridViewTextBoxColumn.Width = 40;
            // 
            // codOperacaoDataGridViewTextBoxColumn
            // 
            this.codOperacaoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Operacao";
            this.codOperacaoDataGridViewTextBoxColumn.HeaderText = "Op.Id.";
            this.codOperacaoDataGridViewTextBoxColumn.Name = "codOperacaoDataGridViewTextBoxColumn";
            this.codOperacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codOperacaoDataGridViewTextBoxColumn.Width = 40;
            // 
            // codBaseTitPagosDataGridViewTextBoxColumn
            // 
            this.codBaseTitPagosDataGridViewTextBoxColumn.DataPropertyName = "Cod_Base_Tit_Pagos";
            this.codBaseTitPagosDataGridViewTextBoxColumn.HeaderText = "Id.TitPagos";
            this.codBaseTitPagosDataGridViewTextBoxColumn.Name = "codBaseTitPagosDataGridViewTextBoxColumn";
            this.codBaseTitPagosDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBaseTitPagosDataGridViewTextBoxColumn.Width = 60;
            // 
            // codBaseTitRecebidosDataGridViewTextBoxColumn
            // 
            this.codBaseTitRecebidosDataGridViewTextBoxColumn.DataPropertyName = "Cod_Base_Tit_Recebidos";
            this.codBaseTitRecebidosDataGridViewTextBoxColumn.HeaderText = "Id.TitReceb.";
            this.codBaseTitRecebidosDataGridViewTextBoxColumn.Name = "codBaseTitRecebidosDataGridViewTextBoxColumn";
            this.codBaseTitRecebidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBaseTitRecebidosDataGridViewTextBoxColumn.Width = 60;
            // 
            // codBancoDataGridViewTextBoxColumn
            // 
            this.codBancoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Banco";
            this.codBancoDataGridViewTextBoxColumn.HeaderText = "Id.Banco";
            this.codBancoDataGridViewTextBoxColumn.Name = "codBancoDataGridViewTextBoxColumn";
            this.codBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBancoDataGridViewTextBoxColumn.Width = 50;
            // 
            // numeroChqueDataGridViewTextBoxColumn
            // 
            this.numeroChqueDataGridViewTextBoxColumn.DataPropertyName = "Numero_Chque";
            this.numeroChqueDataGridViewTextBoxColumn.HeaderText = "Nº Cheque";
            this.numeroChqueDataGridViewTextBoxColumn.Name = "numeroChqueDataGridViewTextBoxColumn";
            this.numeroChqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data Lançamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            this.dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLancamentoDataGridViewTextBoxColumn.Width = 90;
            // 
            // descricaoOperacaoDataGridViewTextBoxColumn
            // 
            this.descricaoOperacaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao_Operacao";
            this.descricaoOperacaoDataGridViewTextBoxColumn.HeaderText = "Descrição Operação";
            this.descricaoOperacaoDataGridViewTextBoxColumn.Name = "descricaoOperacaoDataGridViewTextBoxColumn";
            this.descricaoOperacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoOperacaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // recebimentoTitulosDataGridViewTextBoxColumn
            // 
            this.recebimentoTitulosDataGridViewTextBoxColumn.DataPropertyName = "Recebimento_Titulos";
            this.recebimentoTitulosDataGridViewTextBoxColumn.HeaderText = "Receb. Títulos";
            this.recebimentoTitulosDataGridViewTextBoxColumn.Name = "recebimentoTitulosDataGridViewTextBoxColumn";
            this.recebimentoTitulosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagamentoTitulosDataGridViewTextBoxColumn
            // 
            this.pagamentoTitulosDataGridViewTextBoxColumn.DataPropertyName = "Pagamento_Titulos";
            this.pagamentoTitulosDataGridViewTextBoxColumn.HeaderText = "Pagto Títulos";
            this.pagamentoTitulosDataGridViewTextBoxColumn.Name = "pagamentoTitulosDataGridViewTextBoxColumn";
            this.pagamentoTitulosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorMovimentoDataGridViewTextBoxColumn
            // 
            this.valorMovimentoDataGridViewTextBoxColumn.DataPropertyName = "Valor_Movimento";
            this.valorMovimentoDataGridViewTextBoxColumn.HeaderText = "Valor Movimento";
            this.valorMovimentoDataGridViewTextBoxColumn.Name = "valorMovimentoDataGridViewTextBoxColumn";
            this.valorMovimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoAnteriorDataGridViewTextBoxColumn
            // 
            this.saldoAnteriorDataGridViewTextBoxColumn.DataPropertyName = "Saldo_Anterior";
            this.saldoAnteriorDataGridViewTextBoxColumn.HeaderText = "Saldo Anterior";
            this.saldoAnteriorDataGridViewTextBoxColumn.Name = "saldoAnteriorDataGridViewTextBoxColumn";
            this.saldoAnteriorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Width = 110;
            // 
            // TelaBaseLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 539);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaBaseLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas de Lançamentos";
            this.Load += new System.EventHandler(this.TelaBaseLancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGFRenaissanceDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SGFRenaissanceDataSet3 sGFRenaissanceDataSet3;
        private System.Windows.Forms.BindingSource lancamentosBindingSource;
        private SGFRenaissanceDataSet3TableAdapters.LancamentosTableAdapter lancamentosTableAdapter;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOperacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBaseTitPagosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBaseTitRecebidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoOperacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recebimentoTitulosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoTitulosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMovimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoAnteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
    }
}