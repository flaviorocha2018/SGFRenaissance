using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;


namespace SGFRenaissance
{
    public partial class Lancamentos : Form
    {
        public Lancamentos()
        {
            InitializeComponent();
        }

        private void PreencherCB_Box_Operacao()

         {
             String scon = "Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            SqlConnection con = new SqlConnection(scon);
             try
             {
                 con.Open();
             }
             catch (SqlException sqle)
             {
                 MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
             }
             String scom = "select * from departamento";
             SqlDataAdapter da = new SqlDataAdapter(scom, con);
             DataTable dtResultado = new DataTable();
             dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
             CB_Operacao.DataSource = null;
             da.Fill(dtResultado);
             CB_Operacao.DataSource = dtResultado;
             CB_Operacao.ValueMember = "Cod_Operacao";
             CB_Operacao.DisplayMember = "Descricao_Op";
             CB_Operacao.SelectedItem = "";

         }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lancamentos_Load(object sender, EventArgs e)
        {
            this.lancamentoBindingSource.DataSource = DataContextFactory.DataContext.Lancamentos;
            this.bancoBindingSource.DataSource = DataContextFactory.DataContext.Bancos;
            this.operacaoBindingSource1.DataSource = DataContextFactory.DataContext.Operacaos;
            CB_Operacao.Refresh();
         // this.CB_Operacao.DisplayMember.Where(Operacao = Cod_Operacao.Lancamentos);
            cod_BancoComboBox.Enabled = false;
            CB_Operacao.Enabled = false;
            numero_ContaTextBox.Enabled = false;
            data_LancamentoDateTimePicker.Enabled = false;
            numero_DocumentoTextBox.Enabled = false;
            descricao_OperacaoTextBox.Enabled = false;
            valor_MovimentoTextBox.Enabled = false;
            btn_novo.Focus();
  

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
           login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
            txt_datalogin.Text = DateTime.Now.ToString();
            this.lancamentoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            cod_BancoComboBox.Enabled = false;
            CB_Operacao.Enabled = false;
            numero_ContaTextBox.Enabled = false;
            data_LancamentoDateTimePicker.Enabled = false;
            numero_DocumentoTextBox.Enabled = false;
            descricao_OperacaoTextBox.Enabled = false;
            valor_MovimentoTextBox.Enabled = false;
            MessageBox.Show("Dados do Lançamento Inseridos com Sucesso!");

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            cod_BancoComboBox.Enabled = true;
            CB_Operacao.Enabled = true;
            numero_ContaTextBox.Enabled = true;
            data_LancamentoDateTimePicker.Enabled = true;
            numero_DocumentoTextBox.Enabled = true;
            descricao_OperacaoTextBox.Enabled = true;
            valor_MovimentoTextBox.Enabled = true;
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            this.lancamentoBindingSource.MoveNext();
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            this.lancamentoBindingSource.MovePrevious();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.lancamentoBindingSource.AddNew();
            cod_BancoComboBox.Enabled = true;
            CB_Operacao.Enabled = true;
            numero_ContaTextBox.Enabled = true;
            data_LancamentoDateTimePicker.Enabled = true;
            numero_DocumentoTextBox.Enabled = true;
            descricao_OperacaoTextBox.Enabled = true;
            valor_MovimentoTextBox.Enabled = true; 
            data_LancamentoDateTimePicker.Refresh();

        }
    }
}
