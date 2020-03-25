namespace SGFRenaissance
{
    partial class FrmRelLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelLancamentos));
            this.LancamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rel_Lancamentos = new SGFRenaissance.Rel_Lancamentos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lancamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_executar = new System.Windows.Forms.Button();
            this.btn_Banco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBanco = new System.Windows.Forms.TextBox();
            this.mtboxdatafinal = new System.Windows.Forms.MaskedTextBox();
            this.mtboxdatainicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LancamentosTableAdapter = new SGFRenaissance.Rel_LancamentosTableAdapters.LancamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LancamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_Lancamentos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LancamentosBindingSource
            // 
            this.LancamentosBindingSource.DataMember = "Lancamentos";
            this.LancamentosBindingSource.DataSource = this.Rel_Lancamentos;
            // 
            // Rel_Lancamentos
            // 
            this.Rel_Lancamentos.DataSetName = "Rel_Lancamentos";
            this.Rel_Lancamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lancamentosDataGridView);
            this.panel1.Controls.Add(this.btn_executar);
            this.panel1.Controls.Add(this.btn_Banco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxBanco);
            this.panel1.Controls.Add(this.mtboxdatafinal);
            this.panel1.Controls.Add(this.mtboxdatainicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 47);
            this.panel1.TabIndex = 2;
            // 
            // lancamentosDataGridView
            // 
            this.lancamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lancamentosDataGridView.Location = new System.Drawing.Point(198, 57);
            this.lancamentosDataGridView.Name = "lancamentosDataGridView";
            this.lancamentosDataGridView.Size = new System.Drawing.Size(300, 69);
            this.lancamentosDataGridView.TabIndex = 9;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(496, 13);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(85, 25);
            this.btn_executar.TabIndex = 9;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // btn_Banco
            // 
            this.btn_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Banco.Location = new System.Drawing.Point(446, 13);
            this.btn_Banco.Name = "btn_Banco";
            this.btn_Banco.Size = new System.Drawing.Size(22, 24);
            this.btn_Banco.TabIndex = 8;
            this.btn_Banco.Text = "+";
            this.btn_Banco.UseVisualStyleBackColor = true;
            this.btn_Banco.Click += new System.EventHandler(this.btn_Banco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Banco:";
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBanco.Location = new System.Drawing.Point(412, 15);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(34, 21);
            this.textBoxBanco.TabIndex = 6;
            this.textBoxBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtboxdatafinal
            // 
            this.mtboxdatafinal.Location = new System.Drawing.Point(278, 14);
            this.mtboxdatafinal.Mask = "00/00/0000";
            this.mtboxdatafinal.Name = "mtboxdatafinal";
            this.mtboxdatafinal.Size = new System.Drawing.Size(71, 20);
            this.mtboxdatafinal.TabIndex = 4;
            this.mtboxdatafinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtboxdatafinal.ValidatingType = typeof(System.DateTime);
            // 
            // mtboxdatainicio
            // 
            this.mtboxdatainicio.Location = new System.Drawing.Point(118, 14);
            this.mtboxdatainicio.Mask = "00/00/0000";
            this.mtboxdatainicio.Name = "mtboxdatainicio";
            this.mtboxdatainicio.Size = new System.Drawing.Size(71, 20);
            this.mtboxdatainicio.TabIndex = 3;
            this.mtboxdatainicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtboxdatainicio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(596, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Relatório de Lançamentos Conta/Corrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Início:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Rel_Lancamentos";
            reportDataSource1.Value = this.LancamentosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report_Lancamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(901, 398);
            this.reportViewer1.TabIndex = 3;
            // 
            // LancamentosTableAdapter
            // 
            this.LancamentosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Lançamentos";
            this.Load += new System.EventHandler(this.FrmRelLancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LancamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_Lancamentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lancamentosDataGridView;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Button btn_Banco;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxBanco;
        private System.Windows.Forms.MaskedTextBox mtboxdatafinal;
        private System.Windows.Forms.MaskedTextBox mtboxdatainicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LancamentosBindingSource;
        private Rel_Lancamentos Rel_Lancamentos;
        private Rel_LancamentosTableAdapters.LancamentosTableAdapter LancamentosTableAdapter;
    }
}