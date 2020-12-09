namespace SGFRenaissance
{
    partial class Form_Relatorio_Lancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Relatorio_Lancamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_final = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Banco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_Rel_Lancamentos = new SGFRenaissance.DataSet_Rel_Lancamentos();
            this.LancamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LancamentosTableAdapter = new SGFRenaissance.DataSet_Rel_LancamentosTableAdapters.LancamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Rel_Lancamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LancamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(198, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final:";
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.CustomFormat = "      ";
            this.dateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(81, 31);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker_Inicio.TabIndex = 3;
            this.dateTimePicker_Inicio.DropDown += new System.EventHandler(this.dateTimePicker_Inicio_DropDown);
            // 
            // dateTimePicker_final
            // 
            this.dateTimePicker_final.CustomFormat = "         ";
            this.dateTimePicker_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_final.Location = new System.Drawing.Point(262, 31);
            this.dateTimePicker_final.Name = "dateTimePicker_final";
            this.dateTimePicker_final.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker_final.TabIndex = 4;
            this.dateTimePicker_final.DropDown += new System.EventHandler(this.dateTimePicker_final_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Relatório Bancário de Lançamentos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(723, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Banco
            // 
            this.btn_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Banco.ForeColor = System.Drawing.Color.Black;
            this.btn_Banco.Location = new System.Drawing.Point(758, 30);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(786, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selecionar Banco:";
            // 
            // btn_Execute
            // 
            this.btn_Execute.ForeColor = System.Drawing.Color.Black;
            this.btn_Execute.Location = new System.Drawing.Point(899, 29);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(92, 24);
            this.btn_Execute.TabIndex = 10;
            this.btn_Execute.Text = "Executar";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetRel_Lancamentos";
            reportDataSource1.Value = this.LancamentosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFRenaissance.Report_Lancamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1003, 394);
            this.reportViewer1.TabIndex = 11;
            // 
            // DataSet_Rel_Lancamentos
            // 
            this.DataSet_Rel_Lancamentos.DataSetName = "DataSet_Rel_Lancamentos";
            this.DataSet_Rel_Lancamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LancamentosBindingSource
            // 
            this.LancamentosBindingSource.DataMember = "Lancamentos";
            this.LancamentosBindingSource.DataSource = this.DataSet_Rel_Lancamentos;
            // 
            // LancamentosTableAdapter
            // 
            this.LancamentosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Relatorio_Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 470);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Banco);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_final);
            this.Controls.Add(this.dateTimePicker_Inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Relatorio_Lancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Lançamentos Bancários";
            this.Load += new System.EventHandler(this.Form_Relatorio_Lancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Rel_Lancamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LancamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Banco;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Execute;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LancamentosBindingSource;
        private DataSet_Rel_Lancamentos DataSet_Rel_Lancamentos;
        private DataSet_Rel_LancamentosTableAdapters.LancamentosTableAdapter LancamentosTableAdapter;
    }
}