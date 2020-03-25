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
    public partial class FrmRel_TitulosaPagaremAberto : Form
    {
       
        public FrmRel_TitulosaPagaremAberto()
        {
            InitializeComponent();
        }

        private void FrmRel_TitulosaPagaremAberto_Load(object sender, EventArgs e)
        {

            //     this.reportViewer1.RefreshReport();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
          
            DateTime datainicio = Convert.ToDateTime(maskedTextBox1.Text);
            DateTime datafim = Convert.ToDateTime(maskedTextBox2.Text);
            Int32 CodFornecedor = Convert.ToInt32(textBox1.Text);
            this.reportViewer1.LocalReport.ReportPath = "Rel_TitulosaPagaremAberto.rdlc";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ReportParameter1_DataInicio", maskedTextBox1.ToString());
            parameters[1] = new ReportParameter("ReportParameter2_DataFinal", maskedTextBox2.ToString());
            parameters[2] = new ReportParameter("Parameter_CodFornecedor", textBox1.ToString());
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1_DataInicio", datainicio.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2_DataFinal", datafim.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Parameter_CodFornecedor", CodFornecedor.ToString()));
   
     //     this.Numero_Parcelas_a_PagarTableAdapter.FillNumeroParcelasaPagar(this.Rel_NumeroParcelaaPagar.Numero_Parcelas_a_Pagar, datainicio, datafim, CodFornecedor);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_ReportError(object sender, ReportErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Erro! Verifique a Conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Fornecedor_Click(object sender, EventArgs e)
        {

        }
    }
}
