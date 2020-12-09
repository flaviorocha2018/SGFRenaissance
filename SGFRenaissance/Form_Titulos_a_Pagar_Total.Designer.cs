namespace SGFRenaissance
{
    partial class Form_Titulos_a_Pagar_Total
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Titulos_a_Pagar_Total));
            this.Numero_Parcelas_a_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Rel_Titulos_a_Pagar_Total = new SGFRenaissance.DataSet_Rel_Titulos_a_Pagar_Total();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Final = new System.Windows.Forms.DateTimePicker();
            this.label_Traco = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Numero_Parcelas_a_PagarTableAdapter = new SGFRenaissance.DataSet_Rel_Titulos_a_Pagar_TotalTableAdapters.Numero_Parcelas_a_PagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Parcelas_a_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Rel_Titulos_a_Pagar_Total)).BeginInit();
            this.SuspendLayout();
            // 
            // Numero_Parcelas_a_PagarBindingSource
            // 
            this.Numero_Parcelas_a_PagarBindingSource.DataMember = "Numero_Parcelas_a_Pagar";
            this.Numero_Parcelas_a_PagarBindingSource.DataSource = this.DataSet_Rel_Titulos_a_Pagar_Total;
            // 
            // DataSet_Rel_Titulos_a_Pagar_Total
            // 
            this.DataSet_Rel_Titulos_a_Pagar_Total.DataSetName = "DataSet_Rel_Titulos_a_Pagar_Total";
            this.DataSet_Rel_Titulos_a_Pagar_Total.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(865, 21);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(112, 29);
            this.btn_Executar.TabIndex = 0;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(422, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de Títulos a Pagar - Total  - Todos os Fornecedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Inicial:";
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.CustomFormat = "       ";
            this.dateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(94, 30);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker_Inicio.TabIndex = 3;
            this.dateTimePicker_Inicio.DropDown += new System.EventHandler(this.dateTimePicker_Inicio_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Final:";
            // 
            // dateTimePicker_Final
            // 
            this.dateTimePicker_Final.CustomFormat = "    ";
            this.dateTimePicker_Final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Final.Location = new System.Drawing.Point(290, 30);
            this.dateTimePicker_Final.Name = "dateTimePicker_Final";
            this.dateTimePicker_Final.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker_Final.TabIndex = 5;
            this.dateTimePicker_Final.DropDown += new System.EventHandler(this.dateTimePicker_Final_DropDown);
            // 
            // label_Traco
            // 
            this.label_Traco.AutoSize = true;
            this.label_Traco.Location = new System.Drawing.Point(-9, 53);
            this.label_Traco.Name = "label_Traco";
            this.label_Traco.Size = new System.Drawing.Size(1021, 13);
            this.label_Traco.TabIndex = 6;
            this.label_Traco.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "________";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Relatorio_Titulos_a_Pagar_Total";
            reportDataSource1.Value = this.Numero_Parcelas_a_PagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report_Titulos_a_Pagar_Total.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 381);
            this.reportViewer1.TabIndex = 7;
            // 
            // Numero_Parcelas_a_PagarTableAdapter
            // 
            this.Numero_Parcelas_a_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Titulos_a_Pagar_Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label_Traco);
            this.Controls.Add(this.dateTimePicker_Final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_Inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Executar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Titulos_a_Pagar_Total";
            this.Text = "Relatório de Títulos a Pagar em Aberto - Todos os Fornecedores";
            this.Load += new System.EventHandler(this.Form_Titulos_a_Pagar_Total_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Parcelas_a_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Rel_Titulos_a_Pagar_Total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Final;
        private System.Windows.Forms.Label label_Traco;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Numero_Parcelas_a_PagarBindingSource;
        private DataSet_Rel_Titulos_a_Pagar_Total DataSet_Rel_Titulos_a_Pagar_Total;
        private DataSet_Rel_Titulos_a_Pagar_TotalTableAdapters.Numero_Parcelas_a_PagarTableAdapter Numero_Parcelas_a_PagarTableAdapter;
    }
}