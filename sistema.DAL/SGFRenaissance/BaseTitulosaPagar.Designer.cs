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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTitulosaPagar));
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblLinha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.DG_TitulosaPagar = new System.Windows.Forms.DataGridView();
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPagoaVistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDespesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCentroCustosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codStatusTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada_Titulos_a_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TotalGeral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TitulosaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrada_Titulos_a_PagarBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASE DE TÍTULOS A PAGAR";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1092, 19);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(86, 23);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // DG_TitulosaPagar
            // 
            this.DG_TitulosaPagar.AllowUserToAddRows = false;
            this.DG_TitulosaPagar.AllowUserToDeleteRows = false;
            this.DG_TitulosaPagar.AutoGenerateColumns = false;
            this.DG_TitulosaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TitulosaPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn,
            this.codFornecedorDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.valorTitulo,
            this.valorPagoaVistaDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.numeroParcelasDataGridViewTextBoxColumn,
            this.codDespesaDataGridViewTextBoxColumn,
            this.codCentroCustosDataGridViewTextBoxColumn,
            this.codStatusTituloDataGridViewTextBoxColumn,
            this.historicoTituloDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.DG_TitulosaPagar.DataSource = this.entrada_Titulos_a_PagarBindingSource;
            this.DG_TitulosaPagar.Location = new System.Drawing.Point(2, 60);
            this.DG_TitulosaPagar.Name = "DG_TitulosaPagar";
            this.DG_TitulosaPagar.ReadOnly = true;
            this.DG_TitulosaPagar.Size = new System.Drawing.Size(1213, 407);
            this.DG_TitulosaPagar.TabIndex = 1;
            // 
            // codEntradaTitulosaPagarDataGridViewTextBoxColumn
            // 
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.DataPropertyName = "Cod_Entrada_Titulos_a_Pagar";
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.HeaderText = "Cód. Entr. Títulos a Pagar";
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.Name = "codEntradaTitulosaPagarDataGridViewTextBoxColumn";
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEntradaTitulosaPagarDataGridViewTextBoxColumn.Width = 75;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "Cod_Fornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Width = 120;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nº Documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDocumentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data Vcto.";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 85;
            // 
            // valorTitulo
            // 
            this.valorTitulo.DataPropertyName = "Valor_Titulo";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0,00";
            this.valorTitulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorTitulo.HeaderText = "Valor Título R$";
            this.valorTitulo.Name = "valorTitulo";
            this.valorTitulo.ReadOnly = true;
            this.valorTitulo.Width = 90;
            // 
            // valorPagoaVistaDataGridViewTextBoxColumn
            // 
            this.valorPagoaVistaDataGridViewTextBoxColumn.DataPropertyName = "Valor_Pago_a_Vista";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            this.valorPagoaVistaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorPagoaVistaDataGridViewTextBoxColumn.HeaderText = "Valor Pago à Vista R$";
            this.valorPagoaVistaDataGridViewTextBoxColumn.Name = "valorPagoaVistaDataGridViewTextBoxColumn";
            this.valorPagoaVistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorPagoaVistaDataGridViewTextBoxColumn.Width = 90;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Width = 70;
            // 
            // numeroParcelasDataGridViewTextBoxColumn
            // 
            this.numeroParcelasDataGridViewTextBoxColumn.DataPropertyName = "Numero_Parcelas";
            this.numeroParcelasDataGridViewTextBoxColumn.HeaderText = "Nº Parcelas";
            this.numeroParcelasDataGridViewTextBoxColumn.Name = "numeroParcelasDataGridViewTextBoxColumn";
            this.numeroParcelasDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroParcelasDataGridViewTextBoxColumn.Width = 65;
            // 
            // codDespesaDataGridViewTextBoxColumn
            // 
            this.codDespesaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Despesa";
            this.codDespesaDataGridViewTextBoxColumn.HeaderText = "Despesa";
            this.codDespesaDataGridViewTextBoxColumn.Name = "codDespesaDataGridViewTextBoxColumn";
            this.codDespesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDespesaDataGridViewTextBoxColumn.Width = 80;
            // 
            // codCentroCustosDataGridViewTextBoxColumn
            // 
            this.codCentroCustosDataGridViewTextBoxColumn.DataPropertyName = "Cod_Centro_Custos";
            this.codCentroCustosDataGridViewTextBoxColumn.HeaderText = "Centro de Custos";
            this.codCentroCustosDataGridViewTextBoxColumn.Name = "codCentroCustosDataGridViewTextBoxColumn";
            this.codCentroCustosDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCentroCustosDataGridViewTextBoxColumn.Width = 90;
            // 
            // codStatusTituloDataGridViewTextBoxColumn
            // 
            this.codStatusTituloDataGridViewTextBoxColumn.DataPropertyName = "Cod_Status_Titulo";
            this.codStatusTituloDataGridViewTextBoxColumn.HeaderText = "Status do Título";
            this.codStatusTituloDataGridViewTextBoxColumn.Name = "codStatusTituloDataGridViewTextBoxColumn";
            this.codStatusTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codStatusTituloDataGridViewTextBoxColumn.Width = 80;
            // 
            // historicoTituloDataGridViewTextBoxColumn
            // 
            this.historicoTituloDataGridViewTextBoxColumn.DataPropertyName = "Historico_Titulo";
            this.historicoTituloDataGridViewTextBoxColumn.HeaderText = "Histórico do Título";
            this.historicoTituloDataGridViewTextBoxColumn.Name = "historicoTituloDataGridViewTextBoxColumn";
            this.historicoTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.historicoTituloDataGridViewTextBoxColumn.Width = 120;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // entrada_Titulos_a_PagarBindingSource
            // 
            this.entrada_Titulos_a_PagarBindingSource.DataSource = typeof(sistema.DAL.Entrada_Titulos_a_Pagar);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Controls.Add(this.txt_TotalGeral);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 55);
            this.panel2.TabIndex = 0;
            // 
            // txt_TotalGeral
            // 
            this.txt_TotalGeral.Enabled = false;
            this.txt_TotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalGeral.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalGeral.Location = new System.Drawing.Point(925, 19);
            this.txt_TotalGeral.Name = "txt_TotalGeral";
            this.txt_TotalGeral.ReadOnly = true;
            this.txt_TotalGeral.Size = new System.Drawing.Size(135, 21);
            this.txt_TotalGeral.TabIndex = 1;
            this.txt_TotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(751, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de Títulos a Pagar: ";
            // 
            // BaseTitulosaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DG_TitulosaPagar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseTitulosaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Títulos a Pagar";
            this.Load += new System.EventHandler(this.BaseTitulosaPagar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TitulosaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrada_Titulos_a_PagarBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_TitulosaPagar;
        private System.Windows.Forms.BindingSource entrada_Titulos_a_PagarBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TotalGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEntradaTitulosaPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPagoaVistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDespesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCentroCustosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codStatusTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
    }
}