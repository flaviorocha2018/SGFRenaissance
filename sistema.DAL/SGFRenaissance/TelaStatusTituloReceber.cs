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
    public partial class TelaStatusTituloReceber : Form
    {
        public TelaStatusTituloReceber()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaStatusTituloReceber_Load(object sender, EventArgs e)
        {
            this.status_Titulos_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Status_Titulos_a_Recebers;
        }

        private void status_Titulos_a_ReceberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ((EntradaTitulosaReceber)Owner).DescricaoStatusTitulo.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
                ((EntradaTitulosaReceber)Owner).Cod_StatusTextBox.Text = status_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                 this.Close();

            }
        }
    }
}
