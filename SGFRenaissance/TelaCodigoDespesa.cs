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
    public partial class TelaCodigoDespesa : Form
    {
        public TelaCodigoDespesa()
        {
            InitializeComponent();
        }

      


        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaCodigoDespesa_Load(object sender, EventArgs e)
        {
            this.contasDespesaBindingSource.DataSource = DataContextFactory.DataContext.Contas_Despesas;
        }

        private void dataGridView_cod_despesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == 4)
            {
       //       ((EntradaTitulosaPagar)Owner).descricao_Despesa_textBox.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
                ((CadastroTitulosaPagar)Owner).descricao_Despesa_textBox.Text = dataGridView_cod_despesas.Rows[e.RowIndex].Cells[1].Value.ToString();
                ((CadastroTitulosaPagar)Owner).cod_DespesaTextBox.Text = dataGridView_cod_despesas.Rows[e.RowIndex].Cells["codDespesa"].Value.ToString();
                Close();

            }
        }
    }
}
