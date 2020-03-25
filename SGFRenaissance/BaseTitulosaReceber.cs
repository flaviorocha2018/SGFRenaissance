using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace SGFRenaissance
{
    public partial class BaseTitulosaReceber : Form
    {
        public BaseTitulosaReceber()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BaseTitulosaReceber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber' table. You can move, or remove it, as needed.
            this.numero_Parcelas_a_ReceberTableAdapter.Fill(this.numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);
            // TODO: This line of code loads data into the 'numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber' table. You can move, or remove it, as needed.
            this.numero_Parcelas_a_ReceberTableAdapter.Fill(this.numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);

            //   entrada_Titulos_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Entrada_Titulos_a_Recebers;
            textboxTotal.Text = numero_Parcelas_a_ReceberDataGridView.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[Valor_Parcela.Name].Value ?? 0)).ToString("N2");
            btn_fechar.Focus();

        }
    }
}
