using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SGFRenaissance
{
    public partial class Form_Relatorio_Contas_Receber_Total : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;

        public Form_Relatorio_Contas_Receber_Total()
        {
            InitializeComponent();
        }

        private void Form_Relatorio_Contas_Receber_Total_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Relatorio_NF_Total_a_Receber.DataTable_NF_Total' table. You can move, or remove it, as needed.
          

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
                try
                {
                   
                    if (dateTimePicker_inicio.Text !=null && dateTimePicker_final.Text !=null)
                    {
                        
                        // Inserting and Filtering with Parameters 
                        DateTime datainicio = Convert.ToDateTime(dateTimePicker_inicio.Text);
                        DateTime datafinal = Convert.ToDateTime(dateTimePicker_final.Text);
                        ReportParameter[] parameters = new ReportParameter[2];
                        parameters[0] = new ReportParameter("ReportParameter1", dateTimePicker_inicio.Text.ToString());
                        parameters[1] = new ReportParameter("ReportParameter2", dateTimePicker_final.Text.ToString());

                        // Preenchendo o DataSet com os Dados do Relatório
                        this.DataTable_NF_TotalTableAdapter.Fill(this.DataSet_Relatorio_NF_Total_a_Receber.DataTable_NF_Total, datainicio, datafinal);

                        this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", dateTimePicker_inicio.Text.ToString()));
                        this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter2", dateTimePicker_final.Text.ToString()));

                        this.reportViewer1.RefreshReport();

                }
                    else
                    {
                    MessageBox.Show("Todos os Campos de Data devem ser Preenchidos");
                    }

                }
                catch (Exception EX)
                {
                    MessageBox.Show("Erro ao Executar Consulta ao Banco de Dados! " + EX.Message);
                }
                finally
                {
                    conn.Close();
                }
        }


        private void Form_Closing_Contas_Receber_Total(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker_inicio_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_inicio.CustomFormat = null;
        }

        private void dateTimePicker_final_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_final.CustomFormat = null;
        }

    }
}
