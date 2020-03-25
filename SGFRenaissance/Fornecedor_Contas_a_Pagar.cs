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
    public partial class Fornecedor_Contas_a_Pagar : Form
    {
        string novo_fornecedor;

        private DateTime Data_Agora;
        public Fornecedor_Contas_a_Pagar()
        {
            InitializeComponent();
            
        }

        private void Fornecedor_Contas_a_Pagar_Load(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarBindingSource.DataSource = DataContextFactory.DataContext.Fornecedor_Contas_a_Pagars;
            this.grupoBindingSource.DataSource = DataContextFactory.DataContext.Grupos;
            cod_FornecedorTextBox.Enabled = false;
            nome_FornecedorTextBox.Enabled = false;
            enderecoTextBox.Enabled = false;
            bairroTextBox.Enabled = false;
            estadoTextBox.Enabled = false;
            cidadeTextBox.Enabled = false;
            celularTextBox.Enabled = false;
            cEPTextBox.Enabled = false;
            mtb_Telefone_1.Enabled = false;
            mtb_telefone_2.Enabled = false;
            emailTextBox.Enabled = false;
            cNPJTextBox.Enabled = false;
            cPFTextBox.Enabled = false;
            grupoTextBox.Enabled = false;
            identificacaoTextBox.Enabled = false;
            inscricao_EstadualTextBox.Enabled = false;
            data_CadastroDateTimePicker.Enabled = false;
            
            cod_Status_FornecedorTextBox.Enabled = false;
            data_CadastroDateTimePicker.Enabled = false;
         
            btn_novo.Focus();
        }

      
       

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarBindingSource.CancelEdit();
            this.Close();
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            cod_FornecedorTextBox.Enabled = true;
            nome_FornecedorTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            estadoTextBox.Enabled = true;
            cidadeTextBox.Enabled = true;
            celularTextBox.Enabled = true;
            cEPTextBox.Enabled = true;
            mtb_Telefone_1.Enabled = true;
            mtb_telefone_2.Enabled = true;
            emailTextBox.Enabled = true;
            cNPJTextBox.Enabled = true;
            cPFTextBox.Enabled = true;
            grupoTextBox.Enabled = true;
            identificacaoTextBox.Enabled = true;
            inscricao_EstadualTextBox.Enabled = true;
            data_CadastroDateTimePicker.Enabled = true;
            
            cod_Status_FornecedorTextBox.Enabled = true;
            data_CadastroDateTimePicker.Enabled = true;
           
            btn_salvar.Enabled = true;
            btn_fechar.Focus();

        }

        private void btn_proximo_Click_1(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarBindingSource.MoveNext();
        }

        private void btn_voltar_Click_1(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarBindingSource.MovePrevious();
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;

            novo_fornecedor = nome_FornecedorTextBox.Text;
            var verificar_fornecedor = DataContextFactory.DataContext.Fornecedor_Contas_a_Pagars.Count(
                x => x.Nome_Fornecedor == nome_FornecedorTextBox.Text);

            if (verificar_fornecedor > 0)
            {
                MessageBox.Show("Fornecedor já Cadastrado, Faça a Pesquisa Primeiro!");
                nome_FornecedorTextBox.Focus();
                nome_FornecedorTextBox.SelectAll();
                enderecoTextBox.Text = string.Empty;
                bairroTextBox.Text = string.Empty;
                cidadeTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                cEPTextBox.Text = string.Empty;
                celularTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                mtb_Telefone_1.Text = string.Empty;
                mtb_telefone_2.Text = string.Empty;
                cNPJTextBox.Text = string.Empty;
                cPFTextBox.Text = string.Empty;
                grupoTextBox.Text = string.Empty;
                identificacaoTextBox.Text = string.Empty;
                inscricao_EstadualTextBox.Text = string.Empty;
                data_CadastroDateTimePicker.Text = string.Empty;
                cod_Status_FornecedorTextBox.Text = string.Empty;

            }
            else
            {
              Data_Agora.Date.ToString("ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
              data_logintxtbox.Text = Data_Agora.ToString("dd/MM/yyyy");
              data_logintxtbox.Text = DateTime.Now.ToString();
              login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
              login_NameTextBox.Refresh();
              data_logintxtbox.Refresh();
              this.fornecedor_Contas_a_PagarBindingSource.EndEdit();
              DataContextFactory.DataContext.SubmitChanges();
              MessageBox.Show("Dados do Fornecedor Inseridos / Alterados com Sucesso!");

              cod_FornecedorTextBox.Enabled = false;
              nome_FornecedorTextBox.Enabled = false;
              enderecoTextBox.Enabled = false;
              bairroTextBox.Enabled = false;
              estadoTextBox.Enabled = false;
              cidadeTextBox.Enabled = false;
              celularTextBox.Enabled = false;
              cEPTextBox.Enabled = false;
              mtb_Telefone_1.Enabled = false;
              mtb_telefone_2.Enabled = false;
              emailTextBox.Enabled = false;
              cNPJTextBox.Enabled = false;
              cPFTextBox.Enabled = false;
              grupoTextBox.Enabled = false;
              identificacaoTextBox.Enabled = false;
              inscricao_EstadualTextBox.Enabled = false;
              data_CadastroDateTimePicker.Enabled = false;
           
              cod_Status_FornecedorTextBox.Enabled = false;
              data_CadastroDateTimePicker.Enabled = false;
           
              btn_salvar.Enabled = false;
              btn_fechar.Focus();
           
          }
      }

        private void btn_novo_Click_1(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarBindingSource.AddNew();
            cod_FornecedorTextBox.Enabled = true;
            nome_FornecedorTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            estadoTextBox.Enabled = true;
            cidadeTextBox.Enabled = true;
            celularTextBox.Enabled = true;
            cEPTextBox.Enabled = true;
            mtb_Telefone_1.Enabled = true;
            mtb_telefone_2.Enabled = true;
            emailTextBox.Enabled = true;
            cNPJTextBox.Enabled = true;
            cPFTextBox.Enabled = true;
            grupoTextBox.Enabled = true;
            identificacaoTextBox.Enabled = true;
            inscricao_EstadualTextBox.Enabled = true;
            data_CadastroDateTimePicker.Enabled = true;

            cod_Status_FornecedorTextBox.Enabled = true;
            data_CadastroDateTimePicker.Enabled = true;

            btn_salvar.Enabled = true;
            btn_fechar.Focus();

        }

        private void grupoTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void btn_PesquisarFornecedor_Click(object sender, EventArgs e)
        {
            PesquisarFornecedor frm = new PesquisarFornecedor();
            frm.Show();
        }
       
       
    }
}
