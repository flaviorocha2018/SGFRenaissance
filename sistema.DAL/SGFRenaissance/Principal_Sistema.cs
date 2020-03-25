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
    public partial class Principal_Sistema : Form
    {
        public Principal_Sistema()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor_Contas_a_Pagar frm = new Fornecedor_Contas_a_Pagar();
            frm.Show();


        }

        private void títulosAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaTitulosaPagar frm = new EntradaTitulosaPagar();
            frm.Show();

        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bancos frm = new Bancos();
            frm.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo frm = new Grupo();
            frm.Show();

        }

      

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void tiposDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposdeAcesso frm = new TiposdeAcesso();
            frm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();

        }

        private void lançamentosBancáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancamentos frm = new Lancamentos();
            frm.Show();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes_Contas_a_Receber frm = new Clientes_Contas_a_Receber();
            frm.Show();

        }

        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarCliente frm = new PesquisarCliente();
            frm.Show();
        }

        private void títulosAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EntradaTitulosaPagar frm = new EntradaTitulosaPagar();
            frm.Show();

        }

        private void baseDeTítulosAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseTitulosaPagar frm = new BaseTitulosaPagar();
            frm.Show();
        }

        private void baseDeTítulosAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BaseTitulosaReceber frm = new BaseTitulosaReceber();
            frm.Show();

        }

      

        private void cadastroTítulosAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTitulosaPagar frm = new CadastroTitulosaPagar();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do programa ?", "SGFRenaissance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                cadastrosToolStripMenuItem.Enabled = true;
            }
        }

        private void Principal_Sistema_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do programa ?", "SGFRenaissance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                cadastrosToolStripMenuItem.Enabled = true;
            }

        }

        private void bancosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bancos frm = new Bancos();
            frm.Show();
        }

        private void centroDeCustosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Centro_de_Custos frm = new Centro_de_Custos();
            frm.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Despesas frm = new Cadastro_Despesas();
            frm.Show();
        }
    }
}
