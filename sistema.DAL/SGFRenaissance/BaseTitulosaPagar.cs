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
           entrada_Titulos_a_PagarBindingSource.DataSource = DataContextFactory.DataContext.Entrada_Titulos_a_Pagars;
           txt_TotalGeral.Text = DG_TitulosaPagar.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valorTitulo.Name].Value ?? 0)).ToString("N2");
           btn_fechar.Focus();
        }

      

      
    }
}
