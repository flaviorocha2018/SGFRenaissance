using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;
using sistema.DAL;


namespace SGFRenaissance
{
    public partial class TelaFornecedores : Form
    {
        public TelaFornecedores()
        {
            InitializeComponent();
        }

        private void TelaFornecedores_Load(object sender, EventArgs e)
        {
            Conexao_Fornecedor();
        }

        private void Conexao_Fornecedor()
        {
            this.fornecedorContasaPagarBindingSource.DataSource = DataContextFactory.DataContext.Fornecedor_Contas_a_Pagars;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_telaFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
             
       //     ((CadastroTitulosaPagar)Owner).textBox_Fornecedor.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
              ((CadastroTitulosaPagar)Owner).textBox_Fornecedor.Text = dataGridView_telaFornecedores.Rows[e.RowIndex].Cells[1].Value.ToString();
              ((CadastroTitulosaPagar)Owner).Cod_FornecedorTextbox.Text = dataGridView_telaFornecedores.Rows[e.RowIndex].Cells["codFornecedor"].Value.ToString();
                Close();
            }
        }

       
    }
}
