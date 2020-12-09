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
// CÓDIGO REQUERIDO NA INSTALAÇÃO DO PACOTE 
    public partial class Principal_Sistema : Form
    {
        public Principal_Sistema()
        {
            InitializeComponent();
        }

        private void Principal_Sistema_Load(object sender, EventArgs e )
        {

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

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor_Contas_a_Pagar frm = new Fornecedor_Contas_a_Pagar();
            frm.Show();
        }

        private void titulosAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTitulosaPagar frm = new CadastroTitulosaPagar();
            frm.Show();
        }

        private void gruposToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Grupo frm = new Grupo();
            frm.Show();
        }

        private void tiposDeAcessoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TiposdeAcesso frm = new TiposdeAcesso();
            frm.Show();
        }

        private void usuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();

        }

        private void lançamentoBancárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancamentos frm = new Lancamentos();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clientes_Contas_a_Receber frm = new Clientes_Contas_a_Receber();
            frm.Show();
        }

        private void pesquisarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarCliente frm = new PesquisarCliente();
            frm.Show();
        }

        private void baseDeTítulosAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaseTitulosaPagar frm = new BaseTitulosaPagar();
            frm.Show();
        }

        private void baseDeTítulosAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaseTitulosaReceber frm = new BaseTitulosaReceber();
            frm.Show();
        }

        private void títulosAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaTitulosaReceber frm = new EntradaTitulosaReceber();
            frm.Show();
            
        }

        private void tiposDeReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagamentoDeTítulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamento_de_Titulos frm = new Pagamento_de_Titulos();
            frm.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recebimentoDeTítulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecebimentodeTitulos frm = new RecebimentodeTitulos();
            frm.Show();
        }

        private void extratoDeLançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Relatorio_Lancamentos frm = new Form_Relatorio_Lancamentos();
            frm.Show();
        }

        private void títulosAPagarEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rel_Titulos_a_Pagar_em_Aberto frm = new Frm_Rel_Titulos_a_Pagar_em_Aberto();
            frm.Show();
        }

        private void titulosAReceberEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_TitulosaReceberemAberto frm = new Report_TitulosaReceberemAberto();
            frm.Show();
        }

        private void dREOperacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DRE_Exercicio frm = new Form_DRE_Exercicio();
            frm.Show();
        }

        private void baseDeTítulosPagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaBaseTitulosPagos frm = new TelaBaseTitulosPagos();
            frm.Show();
        }

        private void baseDeTítulosRecebidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaBaseTitulosRecebidos frm = new TelaBaseTitulosRecebidos();
            frm.Show();
        }

        private void titulosAReceberQuitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRel_TitulosRecebidos frm = new FrmRel_TitulosRecebidos();
            frm.Show();
        }

        private void títulosAPagarQuitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTitulosPagos frm = new FrmTitulosPagos();
            frm.Show();
        }

        private void títulosAPagarTotalTodosOsFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Titulos_a_Pagar_Total frm = new Form_Titulos_a_Pagar_Total();
            frm.Show();
        }

        private void títulosAReceberEmAbertoTodosOsClientesTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Relatorio_Contas_Receber_Total frm = new Form_Relatorio_Contas_Receber_Total();
            frm.Show();
        }
    }
}
