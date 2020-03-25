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
    public partial class TiposdeAcesso : Form
    {
        public TiposdeAcesso()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.tipos_AcessoBindingSource.EndEdit();
            this.Close(); 

        }

        private void TiposdeAcesso_Load(object sender, EventArgs e)
        {
            this.tipos_AcessoBindingSource.DataSource = DataContextFactory.DataContext.Tipos_Acessos;
            descricaoTextBox.Enabled = false;


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            descricaoTextBox.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            nome_LoginTextBox.Text = Login.DadosGerais.Loginusuario;
            nome_LoginTextBox.Refresh();
            txtdatalogin.Text = DateTime.Now.ToString();
            this.tipos_AcessoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            descricaoTextBox.Enabled = false;
            MessageBox.Show("Dados do Tipo de Acesso Inseridos / Alterados com Sucesso!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tipos_AcessoBindingSource.MoveNext();
        }
    }
}
