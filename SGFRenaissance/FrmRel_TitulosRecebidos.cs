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
    public partial class FrmRel_TitulosRecebidos : Form
    {
        public FrmRel_TitulosRecebidos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SGFRenaissanceDataSet2.Base_Parcelas_Recebidas' table. You can move, or remove it, as needed. 
           
           
        }

        private void Btn_executar_Click(object sender, EventArgs e)
        {
            if( dtp_data_inicio.Text!=null && dtp_data_final.Text !=null)
            {
                try
                {
                    DateTime Data_inicio = Convert.ToDateTime(dtp_data_inicio.Text);
                    DateTime Data_final = Convert.ToDateTime(dtp_data_final.Text);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("ReportParameter1", dtp_data_inicio.Text.ToString());
                    parameters[1] = new ReportParameter("ReportParameter2", dtp_data_final.Text.ToString());
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", dtp_data_inicio.Text.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", dtp_data_final.Text.ToString()));
                    this.Base_Parcelas_RecebidasTableAdapter.Fill(this.SGFRenaissanceDataSet2.Base_Parcelas_Recebidas, Data_inicio, Data_final);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro na Execução do Relatório!  " + Ex.Message);
                }

            }
            else
            {
                MessageBox.Show("É Necessário o preenchimento de todos os campos do Formulário!");
            }

        }


        private void FrmRel_TitulosRecebidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
