namespace SGFRenaissance
{
    partial class FrmRel_Titulos_a_Pagar_em_Aberto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRel_Titulos_a_Pagar_em_Aberto));
            this.Numero_Parcelas_a_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rel_NumeroParcelaaPagar = new SGFRenaissance.Rel_NumeroParcelaaPagar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Fornecedor = new System.Windows.Forms.Button();
            this.btn_executar = new System.Windows.Forms.Button();
            this.textbox_codFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Numero_Parcelas_a_PagarTableAdapter = new SGFRenaissance.Rel_NumeroParcelaaPagarTableAdapters.Numero_Parcelas_a_PagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Parcelas_a_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_NumeroParcelaaPagar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numero_Parcelas_a_PagarBindingSource
            // 
            this.Numero_Parcelas_a_PagarBindingSource.DataMember = "Numero_Parcelas_a_Pagar";
            this.Numero_Parcelas_a_PagarBindingSource.DataSource = this.Rel_NumeroParcelaaPagar;
            // 
            // Rel_NumeroParcelaaPagar
            // 
            this.Rel_NumeroParcelaaPagar.DataSetName = "Rel_NumeroParcelaaPagar";
            this.Rel_NumeroParcelaaPagar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Fornecedor);
            this.panel1.Controls.Add(this.btn_executar);
            this.panel1.Controls.Add(this.textbox_codFornecedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maskedTextBoxFim);
            this.panel1.Controls.Add(this.maskedTextBoxInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 61);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(607, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Relatório Títulos a Pagar em Aberto";
            // 
            // btn_Fornecedor
            // 
            this.btn_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fornecedor.Location = new System.Drawing.Point(446, 17);
            this.btn_Fornecedor.Name = "btn_Fornecedor";
            this.btn_Fornecedor.Size = new System.Drawing.Size(22, 24);
            this.btn_Fornecedor.TabIndex = 9;
            this.btn_Fornecedor.Text = "+";
            this.btn_Fornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(499, 17);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(92, 23);
            this.btn_executar.TabIndex = 7;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // textbox_codFornecedor
            // 
            this.textbox_codFornecedor.Location = new System.Drawing.Point(412, 19);
            this.textbox_codFornecedor.Name = "textbox_codFornecedor";
            this.textbox_codFornecedor.Size = new System.Drawing.Size(34, 20);
            this.textbox_codFornecedor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // maskedTextBoxFim
            // 
            this.maskedTextBoxFim.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxFim.Location = new System.Drawing.Point(249, 19);
            this.maskedTextBoxFim.Mask = "00/00/0000";
            this.maskedTextBoxFim.Name = "maskedTextBoxFim";
            this.maskedTextBoxFim.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxFim.TabIndex = 3;
            this.maskedTextBoxFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxInicio
            // 
            this.maskedTextBoxInicio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxInicio.Location = new System.Drawing.Point(99, 19);
            this.maskedTextBoxInicio.Mask = "00/00/0000";
            this.maskedTextBoxInicio.Name = "maskedTextBoxInicio";
            this.maskedTextBoxInicio.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBoxInicio.TabIndex = 2;
            this.maskedTextBoxInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Numero_Parcelas_a_PagarBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(2, 68);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(905, 381);
            this.reportViewer2.TabIndex = 2;
            // 
            // Numero_Parcelas_a_PagarTableAdapter
            // 
            this.Numero_Parcelas_a_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rel_Titulos_a_Pagar_em_Aberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rel_Titulos_a_Pagar_em_Aberto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Títulos a Pagar em Aberto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Rel_Titulos_a_Pagar_em_Aberto_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Rel_Titulos_a_Receber_em_Aberto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Parcelas_a_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_NumeroParcelaaPagar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Fornecedor;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.TextBox textbox_codFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Numero_Parcelas_a_PagarBindingSource;
        private Rel_NumeroParcelaaPagar Rel_NumeroParcelaaPagar;
        private Rel_NumeroParcelaaPagarTableAdapters.Numero_Parcelas_a_PagarTableAdapter Numero_Parcelas_a_PagarTableAdapter;
    }
}