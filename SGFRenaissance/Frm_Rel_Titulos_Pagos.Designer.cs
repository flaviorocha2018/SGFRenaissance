namespace SGFRenaissance
{
    partial class Frm_Rel_Titulos_Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rel_Titulos_Pagos));
            this.Base_Parcelas_PagasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SGFRenaissance_Base_Parcelas_Pagas = new SGFRenaissance.SGFRenaissance_Base_Parcelas_Pagas();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Base_Parcelas_PagasTableAdapter = new SGFRenaissance.SGFRenaissance_Base_Parcelas_PagasTableAdapters.Base_Parcelas_PagasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Base_Parcelas_PagasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SGFRenaissance_Base_Parcelas_Pagas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Base_Parcelas_PagasBindingSource
            // 
            this.Base_Parcelas_PagasBindingSource.DataMember = "Base_Parcelas_Pagas";
            this.Base_Parcelas_PagasBindingSource.DataSource = this.SGFRenaissance_Base_Parcelas_Pagas;
            // 
            // SGFRenaissance_Base_Parcelas_Pagas
            // 
            this.SGFRenaissance_Base_Parcelas_Pagas.DataSetName = "SGFRenaissance_Base_Parcelas_Pagas";
            this.SGFRenaissance_Base_Parcelas_Pagas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_final);
            this.panel1.Controls.Add(this.dtp_inicio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_executar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 56);
            this.panel1.TabIndex = 2;
            // 
            // dtp_final
            // 
            this.dtp_final.CustomFormat = "            ";
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_final.Location = new System.Drawing.Point(314, 21);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(101, 20);
            this.dtp_final.TabIndex = 12;
            this.dtp_final.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CustomFormat = "           ";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(104, 21);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(105, 20);
            this.dtp_inicio.TabIndex = 11;
            this.dtp_inicio.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(481, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Relatório de Títulos  Pagos";
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(811, 17);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(92, 24);
            this.btn_executar.TabIndex = 7;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Parcelas_Pagas";
            reportDataSource1.Value = this.Base_Parcelas_PagasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report_Titulos_Pagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(937, 376);
            this.reportViewer1.TabIndex = 3;
            // 
            // Base_Parcelas_PagasTableAdapter
            // 
            this.Base_Parcelas_PagasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTitulosPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 444);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTitulosPagos";
            this.Text = "Relatórios de Títulos Pagos";
            this.Load += new System.EventHandler(this.FrmTitulosPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Base_Parcelas_PagasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SGFRenaissance_Base_Parcelas_Pagas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Base_Parcelas_PagasBindingSource;
        private SGFRenaissance_Base_Parcelas_Pagas SGFRenaissance_Base_Parcelas_Pagas;
        private SGFRenaissance_Base_Parcelas_PagasTableAdapters.Base_Parcelas_PagasTableAdapter Base_Parcelas_PagasTableAdapter;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
    }
}