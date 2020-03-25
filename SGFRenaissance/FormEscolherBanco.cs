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
   

    public partial class FormEscolherBanco : Form
    {
        Form f;
        TextBox t;

        public FormEscolherBanco ()    //(Form frmDestino, TextBox TextBoxDestino)
        {
         //  f = frmDestino;
         //  t = TextBoxDestino;
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FormEscolherBanco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancosDGV.Bancos' table. You can move, or remove it, as needed.
            this.bancosTableAdapter.Fill(this.bancosDGV.Bancos);

        }

        private void bancosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && bancosDataGridView.Rows[e.RowIndex].Cells[0].Value != null )
            {
                string Codigo = Convert.ToString(bancosDataGridView.Rows[e.RowIndex].Cells["Cod_Banco"].Value.ToString());
                //    f.Controls[t.Name].Text = Codigo;
                //    this.Close();
                ((Pagamento_de_Titulos)Owner).banco_DebitadoTextBox1.Text = Codigo;
                this.Close();
            }
           
        }
    }
}
