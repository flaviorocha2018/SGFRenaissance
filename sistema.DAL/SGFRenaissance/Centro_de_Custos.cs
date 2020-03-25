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
    public partial class Centro_de_Custos : Form
    {
        public Centro_de_Custos()
        {
            InitializeComponent();
        }

        private void Centro_de_Custos_Load(object sender, EventArgs e)
        {
            this.centro_CustoBindingSource.DataSource = DataContextFactory.DataContext.Centro_Custos;
            cod_Centro_CustosTextBox.Enabled = false;
            descricao_Centro_CustosTextBox.Enabled = false;
            _btnSalvar.Enabled = false;
            btn_Novo.Focus();



        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.centro_CustoBindingSource.AddNew();
            descricao_Centro_CustosTextBox.Enabled = true;
        }

        private void _btnSalvar_Click(object sender, EventArgs e)
        {
            txt_datetime.Text = DateTime.Now.ToString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
           
            this.centro_CustoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Dados inseridos / Alterados com Sucesso!");
            cod_Centro_CustosTextBox.Enabled = false;
            descricao_Centro_CustosTextBox.Enabled = false;
            _btnSalvar.Enabled = false;
            btnFechar.Focus();


        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            this.centro_CustoBindingSource.MoveNext();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.centro_CustoBindingSource.MovePrevious();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            descricao_Centro_CustosTextBox.Enabled = true;
            _btnSalvar.Enabled = true;
            _btnSalvar.Focus();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.centro_CustoBindingSource.CancelEdit();
            this.centro_CustoBindingSource.EndEdit();
            this.Close();
        }

      
    }
}
