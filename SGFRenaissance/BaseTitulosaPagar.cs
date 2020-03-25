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
    public partial class BaseTitulosaPagar : Form
    {
        public BaseTitulosaPagar()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BaseTitulosaPagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGVNumeroParcelasPagar1.Numero_Parcelas_a_Pagar' table. You can move, or remove it, as needed.
            this.numero_Parcelas_a_PagarTableAdapter.Fill(this.dGVNumeroParcelasPagar1.Numero_Parcelas_a_Pagar);
            // TODO: This line of code loads data into the 'dGVNumeroParcelasPagar.Numero_Parcelas_a_Pagar' table. You can move, or remove it, as needed.
           
            txt_TotalGeral.Text = dataGridViewNumeroParcelas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[Valor_Parcela.Name].Value ?? 0)).ToString("N2");
            btn_fechar.Focus();

            //  Alterar o valor da coluna 6 para os tipos correlacionados da tabela Status_Título

        }
    }
}
