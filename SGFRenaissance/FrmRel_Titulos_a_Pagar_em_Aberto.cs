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
    public partial class FrmRel_Titulos_a_Pagar_em_Aberto : Form
    {
        public FrmRel_Titulos_a_Pagar_em_Aberto()
        {
            InitializeComponent();
        }

        private void Frm_Rel_Titulos_a_Receber_em_Aberto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Rel_NumeroParcelaaPagar.Numero_Parcelas_a_Pagar' table. You can move, or remove it, as needed.
           
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {

            Int32 id_fornecedor = Convert.ToInt32(textbox_codFornecedor.Text);
            DateTime data_inicio = Convert.ToDateTime(maskedTextBoxInicio.Text);
            DateTime data_fim = Convert.ToDateTime(maskedTextBoxFim.Text);
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ReportParameter1", textbox_codFornecedor.Text.ToString());
            parameters[1] = new ReportParameter("ReportParameter2", maskedTextBoxInicio.Text.ToString());
            parameters[2] = new ReportParameter("ReportParameter3", maskedTextBoxFim.Text.ToString());
            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", textbox_codFornecedor.Text.ToString()));
            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", maskedTextBoxInicio.Text.ToString()));
            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter3", maskedTextBoxFim.Text.ToString()));
            this.Numero_Parcelas_a_PagarTableAdapter.FillNumeroParcelasaPagar(this.Rel_NumeroParcelaaPagar.Numero_Parcelas_a_Pagar,id_fornecedor, data_inicio, data_fim);
            this.reportViewer2.RefreshReport();
        }

        private void Frm_Rel_Titulos_a_Pagar_em_Aberto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }


}
