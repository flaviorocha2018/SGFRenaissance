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
    public partial class TelaBancos : Form
    {

        public TelaBancos()
        {
            InitializeComponent();
        }
        public string formularioaberto = ActiveForm.Name;
        

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void bancosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancosDGV);

        }

        private void TelaBancos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancosDGV.Bancos' table. You can move, or remove it, as needed.
            this.bancosTableAdapter.Fill(this.bancosDGV.Bancos);

        }

        private void bancosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           ((Lancamentos)Owner).textBoxCod_banco.Text = bancosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
           ((Lancamentos)Owner).textBoxnomeBanco.Text = bancosDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();    
        }
    }
}
