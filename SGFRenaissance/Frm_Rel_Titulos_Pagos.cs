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
    public partial class Frm_Rel_Titulos_Pagos : Form
    {
        public Frm_Rel_Titulos_Pagos()
        {
            InitializeComponent();
        }

        private void FrmTitulosPagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SGFRenaissance_Base_Parcelas_Pagas.Base_Parcelas_Pagas' table. You can move, or remove it, as needed.
           
           
         
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            if (dtp_inicio.Text!=null && dtp_final.Text!=null)
            {
                try
                {
                    DateTime data_inicio = Convert.ToDateTime(dtp_inicio.Text);
                    DateTime data_fim = Convert.ToDateTime(dtp_final.Text);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("ReportParameter1", dtp_inicio.Text.ToString());
                    parameters[1] = new ReportParameter("ReportParameter2", dtp_final.Text.ToString());
                  //  this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", dtp_inicio.Text.ToString()));
                 //   this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", dtp_final.Text.ToString()));

                    this.Base_Parcelas_PagasTableAdapter.Fill(this.SGFRenaissance_Base_Parcelas_Pagas.Base_Parcelas_Pagas, data_inicio, data_fim );
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

        private void FrmTitulosPagos_Closing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
