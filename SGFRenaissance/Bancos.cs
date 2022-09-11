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
    public partial class Bancos : Form
    {
        public Bancos()
        {
            InitializeComponent();
        }

        public void Bancos_Load(object sender, EventArgs e)
        {
            this.bancosBindingSource.DataSource = DataContextFactory.DataContext.Bancos;
          
            cod_BancoTextBox.Enabled = false;
            nome_BancoTextBox.Enabled = false;
            numero_BancoTextBox.Enabled = false;
            agenciaTextBox.Enabled = false;
            numero_ContaTextBox.Enabled = false;
            numero_BancoTextBox.Enabled = false;
            enderecoTextBox.Enabled = false;
            bairroTextBox.Enabled = false;
            municipioTextBox.Enabled = false;
            contatoTextBox.Enabled = false;
            estadoTextBox.Enabled = false;
            telefoneTextBox.Enabled = false;
            telefone_2.Enabled = false;
            txt_Email.Enabled = false;
            dtp_datacadastro.Enabled = false;
            saldoTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btn_Novo.Focus();

        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.bancosBindingSource.AddNew();
         
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cod_BancoTextBox.Enabled = false;
            nome_BancoTextBox.Enabled = false;
            numero_BancoTextBox.Enabled = false;
            agenciaTextBox.Enabled = false;
            numero_ContaTextBox.Enabled = false;
            numero_BancoTextBox.Enabled = false;
            enderecoTextBox.Enabled = false;
            bairroTextBox.Enabled = false;
            municipioTextBox.Enabled = false;
            contatoTextBox.Enabled = false;
            estadoTextBox.Enabled = false;
            telefoneTextBox.Enabled = false;
            saldoTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            telefone_2.Enabled = false;
            txt_Email.Enabled = false;
            dtp_datacadastro.Enabled = false;
            btnFechar.Focus();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
            txt_datalogin.Text = DateTime.Now.ToString();
            this.bancosBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Dados Bancários inseridos / alterados com Sucesso!");

        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.bancosBindingSource.EndEdit();
            this.bancosBindingSource.CancelEdit();
            this.Close();

        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            this.bancosBindingSource.MoveNext();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.bancosBindingSource.MovePrevious();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            cod_BancoTextBox.Enabled = true;
            nome_BancoTextBox.Enabled = true;
            numero_BancoTextBox.Enabled = true;
            agenciaTextBox.Enabled = true;
            numero_ContaTextBox.Enabled = true;
            numero_BancoTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            municipioTextBox.Enabled = true;
            contatoTextBox.Enabled = true;
            estadoTextBox.Enabled = true;
            telefoneTextBox.Enabled = true;
            telefone_2.Enabled = true;
            txt_Email.Enabled = true;
            dtp_datacadastro.Enabled = true;
            saldoTextBox.Enabled = false;
            btnSalvar.Enabled = true;

        }

       

       

      
    }
}