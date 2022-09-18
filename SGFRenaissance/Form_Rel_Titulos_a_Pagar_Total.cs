using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SGFRenaissance
{
    public partial class Form_Rel_Titulos_a_Pagar_Total : Form
    {
        public Form_Rel_Titulos_a_Pagar_Total()
        {
            InitializeComponent();
        }

        private void Form_Titulos_a_Pagar_Total_Load(object sender, EventArgs e)
        {
          
       //     this.Numero_Parcelas_a_PagarTableAdapter.Fill(this.DataSet_Rel_Titulos_a_Pagar_Total.Numero_Parcelas_a_Pagar);

        //    this.reportViewer1.RefreshReport();
        }

        private void FormTitulosaPagarTotal(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data_inicial = Convert.ToDateTime(dateTimePicker_Inicio.Text);
                DateTime data_final = Convert.ToDateTime(dateTimePicker_Final.Text);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("ReportParameter1", dateTimePicker_Inicio.Text.ToString());
                parameters[1] = new ReportParameter("ReportParameter2", dateTimePicker_Final.Text.ToString());

             //   this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", dateTimePicker_Inicio.Text.ToString()));
            //    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", dateTimePicker_Final.Text.ToString()));
                this.Numero_Parcelas_a_PagarTableAdapter.Fill(this.DataSet_Rel_Titulos_a_Pagar_Total.Numero_Parcelas_a_Pagar, data_inicial, data_final);
            //    this.reportViewer1.RefreshReport();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao Executar o Relatório! " + Ex);
            }
        }

        private void dateTimePicker_Inicio_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_Inicio.CustomFormat = null;
        }

        private void dateTimePicker_Final_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_Final.CustomFormat = null;
        }
    }
}
