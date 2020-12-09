using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFRenaissance
{
    public partial class TelaBaseTitulosPagos : Form
    {
        public TelaBaseTitulosPagos()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaBaseTitulosPagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGV_BaseTitulosPagosXNomeBanco.Base_Titulos_Pagos' table. You can move, or remove it, as needed.
            this.base_Titulos_PagosTableAdapter.Fill(this.dGV_BaseTitulosPagosXNomeBanco.Base_Titulos_Pagos);
            textboxTotalPago.Text = base_Titulos_PagosDataGridView.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[Total_Pago.Name].Value ?? 0)).ToString("N2");
            btn_fechar.Focus();

        }

        private void base_Titulos_PagosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                ((Lancamentos)Owner).cod_Tit_Pagos.Text = base_Titulos_PagosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ((Lancamentos)Owner).Valor_Tit_Pagos.Text = base_Titulos_PagosDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                ((Lancamentos)Owner).textBoxCod_banco.Text = base_Titulos_PagosDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                ((Lancamentos)Owner).numero_ChequeTextBox.Text = base_Titulos_PagosDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                ((Lancamentos)Owner).Valor_Tit_Pagos.Focus();
                this.Close();
            }
        }
    }
}
