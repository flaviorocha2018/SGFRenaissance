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
using sistema.DAL;


namespace SGFRenaissance
{
    public partial class TelaCentroCustos : Form
    {
        public TelaCentroCustos()
        {
            InitializeComponent();
        }

        private void Conexao_Centro_Custos()
        {
            this.centroCustoBindingSource.DataSource = DataContextFactory.DataContext.Centro_Custos; 
          
        }
        

      

        private void TelaCentroCustos_Load(object sender, EventArgs e)
        {
            Conexao_Centro_Custos();
        }

        private void dataGridView_centro_custos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    //  Alterar a propriedade do Design "Modifiers" para Public
            if (e.ColumnIndex == 2)
            {
                ((CadastroTitulosaPagar)Owner).TexBoxNome_CentroCustos.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
                ((CadastroTitulosaPagar)Owner).TextBox_Cod_CentroCustos.Tag = ((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[0]).Value;
                ((CadastroTitulosaPagar)Owner).TextBox_Cod_CentroCustos.Text = dataGridView_centro_custos.Rows[e.RowIndex].Cells["codCentroCustos"].Value.ToString();
                Close();
            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
