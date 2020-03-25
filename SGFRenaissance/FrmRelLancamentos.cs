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
    public partial class FrmRelLancamentos : Form
    {
        
        public FrmRelLancamentos()
        {
            InitializeComponent();
           
        }

        private void FrmRelLancamentos_Load(object sender, EventArgs e)
        {
           
  // TODO: This line of code loads data into the 'Rel_Lancamentos.Lancamentos' table. You can move, or remove it, as needed.
          
          
        }

        private void btn_Banco_Click(object sender, EventArgs e)
        {
            TelaRelatorioBancosLancamento frm = new TelaRelatorioBancosLancamento() { Owner = this };
            frm.ShowDialog();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            Int32 Cod_Banco = Convert.ToInt32(textBoxBanco.Text);
            DateTime datainicio = Convert.ToDateTime(mtboxdatainicio.Text);
            DateTime datafinal = Convert.ToDateTime(mtboxdatafinal.Text);
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ReportParameter1", textBoxBanco.Text.ToString());
            parameters[1] = new ReportParameter("ReportParameter2", mtboxdatainicio.Text.ToString());
            parameters[2] = new ReportParameter("ReportParameter3", mtboxdatafinal.Text.ToString());
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", Cod_Banco.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", mtboxdatainicio.Text.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter3", mtboxdatafinal.Text.ToString()));
            this.LancamentosTableAdapter.Fill(this.Rel_Lancamentos.Lancamentos,datainicio,datafinal, Cod_Banco);
            this.reportViewer1.RefreshReport();
        }
    }
}
