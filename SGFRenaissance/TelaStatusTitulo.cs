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
    public partial class TelaStatusTitulo : Form
    {
        public TelaStatusTitulo()
        {
            InitializeComponent();
        }

       

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaStatusTitulo_Load(object sender, EventArgs e)
        {
            this.statusTituloBindingSource.DataSource = DataContextFactory.DataContext.Status_Titulos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == 2)
            {
            //   ((EntradaTitulosaPagar)Owner).Status_Titulo_Textbox.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
                ((CadastroTitulosaPagar)Owner).Status_Titulo_Textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                ((CadastroTitulosaPagar)Owner).cod_Status_TituloTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Cod_Status"].Value.ToString();
                Close();
            }
            else
            {
                if(e.ColumnIndex == 3)
                {
                    ((CadastroTitulosaPagar)Owner).cod_Status_TituloTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Cod_Status"].Value.ToString();
                    ((CadastroTitulosaPagar)Owner).DescricaoParcela.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Close();
                }
            }

        }


    }
}
