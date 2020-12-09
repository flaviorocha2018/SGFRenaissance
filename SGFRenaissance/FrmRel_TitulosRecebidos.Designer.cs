namespace SGFRenaissance
{
    partial class FrmRel_TitulosRecebidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRel_TitulosRecebidos));
            this.Base_Parcelas_RecebidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SGFRenaissanceDataSet2 = new SGFRenaissance.SGFRenaissanceDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Base_Parcelas_RecebidasTableAdapter = new SGFRenaissance.SGFRenaissanceDataSet2TableAdapters.Base_Parcelas_RecebidasTableAdapter();
            this.Btn_executar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_data_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_data_final = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Base_Parcelas_RecebidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SGFRenaissanceDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Base_Parcelas_RecebidasBindingSource
            // 
            this.Base_Parcelas_RecebidasBindingSource.DataMember = "Base_Parcelas_Recebidas";
            this.Base_Parcelas_RecebidasBindingSource.DataSource = this.SGFRenaissanceDataSet2;
            // 
            // SGFRenaissanceDataSet2
            // 
            this.SGFRenaissanceDataSet2.DataSetName = "SGFRenaissanceDataSet2";
            this.SGFRenaissanceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(398, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de Títulos Recebidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Período:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Titulos_Recebidos";
            reportDataSource1.Value = this.Base_Parcelas_RecebidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report_Titulos_Recebidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(930, 369);
            this.reportViewer1.TabIndex = 5;
            // 
            // Base_Parcelas_RecebidasTableAdapter
            // 
            this.Base_Parcelas_RecebidasTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_executar
            // 
            this.Btn_executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_executar.Location = new System.Drawing.Point(727, 20);
            this.Btn_executar.Name = "Btn_executar";
            this.Btn_executar.Size = new System.Drawing.Size(114, 23);
            this.Btn_executar.TabIndex = 6;
            this.Btn_executar.Text = "Executar";
            this.Btn_executar.UseVisualStyleBackColor = true;
            this.Btn_executar.Click += new System.EventHandler(this.Btn_executar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(210, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "a";
            // 
            // dtp_data_inicio
            // 
            this.dtp_data_inicio.CustomFormat = "    ";
            this.dtp_data_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_inicio.Location = new System.Drawing.Point(82, 20);
            this.dtp_data_inicio.Name = "dtp_data_inicio";
            this.dtp_data_inicio.Size = new System.Drawing.Size(107, 22);
            this.dtp_data_inicio.TabIndex = 8;
            this.dtp_data_inicio.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_data_final
            // 
            this.dtp_data_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_final.Location = new System.Drawing.Point(243, 20);
            this.dtp_data_final.Name = "dtp_data_final";
            this.dtp_data_final.Size = new System.Drawing.Size(105, 22);
            this.dtp_data_final.TabIndex = 9;
            this.dtp_data_final.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // FrmRel_TitulosRecebidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 435);
            this.Controls.Add(this.dtp_data_final);
            this.Controls.Add(this.dtp_data_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_executar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRel_TitulosRecebidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Títulos Recebidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Base_Parcelas_RecebidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SGFRenaissanceDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Base_Parcelas_RecebidasBindingSource;
        private SGFRenaissanceDataSet2 SGFRenaissanceDataSet2;
        private SGFRenaissanceDataSet2TableAdapters.Base_Parcelas_RecebidasTableAdapter Base_Parcelas_RecebidasTableAdapter;
        private System.Windows.Forms.Button Btn_executar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_data_inicio;
        private System.Windows.Forms.DateTimePicker dtp_data_final;
    }
}