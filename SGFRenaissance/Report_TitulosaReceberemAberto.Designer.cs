namespace SGFRenaissance
{
    partial class Report_TitulosaReceberemAberto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_TitulosaReceberemAberto));
            this.Entrada_Titulos_a_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rel_NumeroParcelasaReceber = new SGFRenaissance.Rel_NumeroParcelasaReceber();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.textBoxCodCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Entrada_Titulos_a_ReceberTableAdapter = new SGFRenaissance.Rel_NumeroParcelasaReceberTableAdapters.Entrada_Titulos_a_ReceberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Entrada_Titulos_a_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_NumeroParcelasaReceber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entrada_Titulos_a_ReceberBindingSource
            // 
            this.Entrada_Titulos_a_ReceberBindingSource.DataMember = "Entrada_Titulos_a_Receber";
            this.Entrada_Titulos_a_ReceberBindingSource.DataSource = this.Rel_NumeroParcelasaReceber;
            // 
            // Rel_NumeroParcelasaReceber
            // 
            this.Rel_NumeroParcelasaReceber.DataSetName = "Rel_NumeroParcelasaReceber";
            this.Rel_NumeroParcelasaReceber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Executar);
            this.panel1.Controls.Add(this.btn_Clientes);
            this.panel1.Controls.Add(this.textBoxCodCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBoxFim);
            this.panel1.Controls.Add(this.maskedTextBoxInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 53);
            this.panel1.TabIndex = 0;
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(802, 18);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(92, 23);
            this.btn_Executar.TabIndex = 137;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Location = new System.Drawing.Point(420, 18);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(22, 24);
            this.btn_Clientes.TabIndex = 136;
            this.btn_Clientes.Text = "+";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // textBoxCodCliente
            // 
            this.textBoxCodCliente.Location = new System.Drawing.Point(387, 20);
            this.textBoxCodCliente.Name = "textBoxCodCliente";
            this.textBoxCodCliente.Size = new System.Drawing.Size(33, 20);
            this.textBoxCodCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo:";
            // 
            // maskedTextBoxFim
            // 
            this.maskedTextBoxFim.Location = new System.Drawing.Point(216, 19);
            this.maskedTextBoxFim.Mask = "00/00/0000";
            this.maskedTextBoxFim.Name = "maskedTextBoxFim";
            this.maskedTextBoxFim.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxFim.TabIndex = 2;
            this.maskedTextBoxFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxInicio
            // 
            this.maskedTextBoxInicio.Location = new System.Drawing.Point(78, 19);
            this.maskedTextBoxInicio.Mask = "00/00/0000";
            this.maskedTextBoxInicio.Name = "maskedTextBoxInicio";
            this.maskedTextBoxInicio.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxInicio.TabIndex = 1;
            this.maskedTextBoxInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(486, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Títulos a Receber em Aberto";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Entrada_Titulos_a_ReceberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(954, 297);
            this.reportViewer1.TabIndex = 1;
            // 
            // Entrada_Titulos_a_ReceberTableAdapter
            // 
            this.Entrada_Titulos_a_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // Report_TitulosaReceberemAberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 358);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_TitulosaReceberemAberto";
            this.Text = "Titulos a Receber em Aberto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_TitulosaReceberemAberto_FormClosing);
            this.Load += new System.EventHandler(this.Report_TitulosaReceberemAberto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Entrada_Titulos_a_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_NumeroParcelasaReceber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.Button btn_Clientes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Entrada_Titulos_a_ReceberBindingSource;
        private Rel_NumeroParcelasaReceber Rel_NumeroParcelasaReceber;
        private Rel_NumeroParcelasaReceberTableAdapters.Entrada_Titulos_a_ReceberTableAdapter Entrada_Titulos_a_ReceberTableAdapter;
        public System.Windows.Forms.TextBox textBoxCodCliente;
    }
}