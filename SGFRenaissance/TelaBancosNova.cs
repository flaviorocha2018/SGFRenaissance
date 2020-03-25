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
    public partial class TelaBancosNova : Form
    {
        Form f;
        TextBox t;
        public TelaBancosNova()
        {
        //    f = FrmDestino;
        //    t = TextBoxDestino;
            InitializeComponent();
        }

        private void bancosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancosDGV);

        }

        private void TelaBancosNova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancosDGV.Bancos' table. You can move, or remove it, as needed.
            this.bancosTableAdapter.Fill(this.bancosDGV.Bancos);

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bancosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ((RecebimentodeTitulos)Owner).banco_CreditadoTextBox.Text = bancosDataGridView.Rows[e.RowIndex].Cells["Codigo_Banco"].Value.ToString();
            this.Close();
           
        }
    }
}
