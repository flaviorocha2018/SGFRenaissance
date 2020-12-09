namespace SGFRenaissance
{
    partial class Form_Relatorio_Contas_Receber_Total
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Relatorio_Contas_Receber_Total));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_final = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_Relatorio_NF_Total_a_Receber = new SGFRenaissance.DataSet_Relatorio_NF_Total_a_Receber();
            this.DataTable_NF_TotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_NF_TotalTableAdapter = new SGFRenaissance.DataSet_Relatorio_NF_Total_a_ReceberTableAdapters.DataTable_NF_TotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Relatorio_NF_Total_a_Receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_NF_TotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Período:";
            // 
            // dateTimePicker_inicio
            // 
            this.dateTimePicker_inicio.CustomFormat = "   ";
            this.dateTimePicker_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_inicio.Location = new System.Drawing.Point(85, 28);
            this.dateTimePicker_inicio.Name = "dateTimePicker_inicio";
            this.dateTimePicker_inicio.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker_inicio.TabIndex = 1;
            this.dateTimePicker_inicio.DropDown += new System.EventHandler(this.dateTimePicker_inicio_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // dateTimePicker_final
            // 
            this.dateTimePicker_final.CustomFormat = "    ";
            this.dateTimePicker_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_final.Location = new System.Drawing.Point(226, 28);
            this.dateTimePicker_final.Name = "dateTimePicker_final";
            this.dateTimePicker_final.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker_final.TabIndex = 3;
            this.dateTimePicker_final.DropDown += new System.EventHandler(this.dateTimePicker_final_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contas a Receber no Período - Todos os Clientes";
            // 
            // btn_executar
            // 
            this.btn_executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_executar.Location = new System.Drawing.Point(814, 29);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(116, 23);
            this.btn_executar.TabIndex = 5;
            this.btn_executar.Text = "Executar ";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1045, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "____________";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_NF_TotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report_Relatorio_NF_Total.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1014, 364);
            this.reportViewer1.TabIndex = 7;
            // 
            // DataSet_Relatorio_NF_Total_a_Receber
            // 
            this.DataSet_Relatorio_NF_Total_a_Receber.DataSetName = "DataSet_Relatorio_NF_Total_a_Receber";
            this.DataSet_Relatorio_NF_Total_a_Receber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_NF_TotalBindingSource
            // 
            this.DataTable_NF_TotalBindingSource.DataMember = "DataTable_NF_Total";
            this.DataTable_NF_TotalBindingSource.DataSource = this.DataSet_Relatorio_NF_Total_a_Receber;
            // 
            // DataTable_NF_TotalTableAdapter
            // 
            this.DataTable_NF_TotalTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Relatorio_Contas_Receber_Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 439);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_inicio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Relatorio_Contas_Receber_Total";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Contas a Receber Total - Todos os Clientes";
            this.Load += new System.EventHandler(this.Form_Relatorio_Contas_Receber_Total_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Relatorio_NF_Total_a_Receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_NF_TotalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable_NF_TotalBindingSource;
        private DataSet_Relatorio_NF_Total_a_Receber DataSet_Relatorio_NF_Total_a_Receber;
        private DataSet_Relatorio_NF_Total_a_ReceberTableAdapters.DataTable_NF_TotalTableAdapter DataTable_NF_TotalTableAdapter;
    }
}