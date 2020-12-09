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
    public partial class Form_Relatorio_Lancamentos : Form 
    {
        public Form_Relatorio_Lancamentos()
        {
            InitializeComponent();
        }



        private void Form_Relatorio_Lancamentos_Load(object sender, EventArgs e)
        {
            //  TODO: This line of code loads data into the 'DataSet_Rel_Lancamentos.Lancamentos' table. You can move, or remove it, as needed.
           //   this.LancamentosTableAdapter.Fill(this.DataSet_Rel_Lancamentos.Lancamentos);
        }

        private void btn_Banco_Click(object sender, EventArgs e)
        {
            TelaBancoRel_Lancamentos frm = new TelaBancoRel_Lancamentos() { Owner = this };
            frm.ShowDialog();
        }

        private void dateTimePicker_Inicio_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_Inicio.CustomFormat = null;
        }

        private void dateTimePicker_final_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_final.CustomFormat = null;
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
           

            if (dateTimePicker_Inicio.Text != null || dateTimePicker_final.Text != null || textBox1.Text != " ")
            {
                try
                {
                    //  Parâmetros para o Relatório
                    Int32 Cod_banco = Convert.ToInt32(textBox1.Text);
                    DateTime datainicio = Convert.ToDateTime(dateTimePicker_Inicio.Text);
                    DateTime datafinal = Convert.ToDateTime(dateTimePicker_final.Text);
                    ReportParameter[] parameters = new ReportParameter[3];
                    parameters[0] = new ReportParameter("ReportParameter1", textBox1.Text.ToString());
                    parameters[1] = new ReportParameter("ReportParameter2", dateTimePicker_Inicio.Text.ToString());
                    parameters[2] = new ReportParameter("ReportParameter3", dateTimePicker_final.Text.ToString());
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", textBox1.Text.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", dateTimePicker_Inicio.Text.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter3", dateTimePicker_final.Text.ToString()));
                  
                    this.LancamentosTableAdapter.Fill(this.DataSet_Rel_Lancamentos.Lancamentos, Cod_banco, datainicio, datafinal);
                    this.reportViewer1.RefreshReport();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show("Erro ao Executar o Relatório !" + Ex);

                }
            }

            else
            {
                MessageBox.Show("Todos os campos do Formulário devem ser preenchidos!");
            }

        }

        private void Relatorio_Lancamentos_Closing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

       
    }
}
