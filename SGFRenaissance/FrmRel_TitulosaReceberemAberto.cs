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
using Microsoft.ReportingServices.Diagnostics;

namespace SGFRenaissance
{
    public partial class FrmRel_TitulosaReceberemAberto : Form
    {
        public FrmRel_TitulosaReceberemAberto()
        {
            InitializeComponent();
        }

        private void Report_TitulosaReceberemAberto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Rel_NumeroParcelasaReceber.Entrada_Titulos_a_Receber' table. You can move, or remove it, as needed.
         
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            Int32 id_Cliente = Convert.ToInt32(textBoxCodCliente.Text);
            DateTime data_inicio = Convert.ToDateTime(maskedTextBoxInicio.Text);
            DateTime data_fim = Convert.ToDateTime(maskedTextBoxFim.Text);
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ReportParameter1", textBoxCodCliente.Text.ToString());
            parameters[1] = new ReportParameter("ReportParameter2", maskedTextBoxInicio.Text.ToString());
            parameters[2] = new ReportParameter("ReportParameter3", maskedTextBoxFim.Text.ToString());
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", textBoxCodCliente.Text.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", maskedTextBoxInicio.Text.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter3", maskedTextBoxFim.Text.ToString()));

            this.Entrada_Titulos_a_ReceberTableAdapter.Fill(this.Rel_NumeroParcelasaReceber.Entrada_Titulos_a_Receber,id_Cliente, data_inicio, data_fim);
            this.reportViewer1.RefreshReport();
        }

        private void Report_TitulosaReceberemAberto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
