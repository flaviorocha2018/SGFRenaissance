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
    public partial class TelaClientes : Form      
    {
       
       

        public TelaClientes()
        {
            InitializeComponent();
        }

        public static class DadosCliente
        {
            public static string NomeCliente;
            public static int CodigoCliente;
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            this.clientesContasaReceberBindingSource.DataSource = DataContextFactory.DataContext.Clientes_Contas_a_Recebers;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 )
            {
                ((EntradaTitulosaReceber)Owner).nome_ClienteTextBox.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
          //    ((EntradaTitulosaReceber)Owner).cod_ClienteTextBox.Tag = ((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[0]).Value;
                ((EntradaTitulosaReceber)Owner).cod_ClienteTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["codCliente"].Value.ToString();
                this.Close();
            }
        }
    }
}
