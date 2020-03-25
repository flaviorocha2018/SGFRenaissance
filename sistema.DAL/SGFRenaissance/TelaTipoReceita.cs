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
    public partial class TelaTipoReceita : Form
    {
        public TelaTipoReceita()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaTipoReceita_Load(object sender, EventArgs e)
        {
            this.tipos_ReceitaBindingSource.DataSource = DataContextFactory.DataContext.Tipos_Receitas;
        }

        private void tipos_ReceitaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ((EntradaTitulosaReceber)Owner).DescricaoReceita.Text = (string)((DataGridViewTextBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[1]).Value;
                ((EntradaTitulosaReceber)Owner).Cod_ReceitaTextBox.Text = tipos_ReceitaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
