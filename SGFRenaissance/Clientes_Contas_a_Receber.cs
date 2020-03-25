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
   
    public partial class Clientes_Contas_a_Receber : Form
    {
        string novo_cliente;
        string connString = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";

        SqlDataAdapter dataAdapter; // este objeto nos permite contruir a conexão entre o programa e o banco de dados.
        DataTable table; // tabela para receber o conteúdo para preencher o DataGridView.
        public Clientes_Contas_a_Receber()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.clientes_Contas_a_ReceberBindingSource.CancelEdit();
            this.Close();
        }

        private void GetData(String selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString); // passa para o SelectCommand e a string de conexão
                table = new DataTable(); // um novo datatable  objeto.
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table); // preenche a tabela.
                clientes_Contas_a_ReceberBindingSource.DataSource = table; // Coloca o DataSource e o BindingSource na Tabela
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message); // mostrar uma mensagem ao usuário em caso de exceção.
            }
        }

        private void Clientes_Contas_a_Receber_Load(object sender, EventArgs e)
        {
            
           // nome_ClienteTextBox.Text = PesquisarCliente.dados_Clientes.nome_cliente;


            this.clientes_Contas_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Clientes_Contas_a_Recebers;
            this.status_Fornecedor_ClienteBindingSource.DataSource = DataContextFactory.DataContext.Status_Fornecedor_Clientes;
            this.grupoBindingSource.DataSource = DataContextFactory.DataContext.Grupos;
            this.pesquisa_Por_NomeBindingSource.DataSource = DataContextFactory.DataContext.Pesquisa_Por_Nomes;
            CB_Grupo.DataSource = DataContextFactory.DataContext.Grupos;
            dataGrid_Cliente.DataSource = clientes_Contas_a_ReceberBindingSource;
            nome_ClienteTextBox.Enabled = false;
            endereço_ClienteTextBox.Enabled = false;
            bairro_ClienteTextBox.Enabled = false;
            estadoTextBox.Enabled = false;
            municipio_ClienteTextBox.Enabled = false;
            telefoneTextBox.Enabled = false;
            celularTextBox.Enabled = false;
            cNPJTextBox.Enabled = false;
            CB_Grupo.Enabled = false;
            CB_Status.Enabled = false;
            identificacaoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            btn_Pesquisar.Enabled = true;

            // GetData("Select * from Clientes_Contas_a_Receber");
        }

        private void endereço_ClienteTextBox_TextChanged(object sender, EventArgs e)
        {
           // deletar
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            novo_cliente = nome_ClienteTextBox.Text;
            var verificar_cliente = DataContextFactory.DataContext.Clientes_Contas_a_Recebers.Count(
                x => x.Nome_Cliente == nome_ClienteTextBox.Text);

            if (verificar_cliente > 0)
            {
                MessageBox.Show("Cliente já Cadastrado, Faça a Pesquisa Primeiro!");
                nome_ClienteTextBox.Focus();
                nome_ClienteTextBox.SelectAll();

            }
            else
            {
              login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
              login_NameTextBox.Refresh();
              txt_datalogin.Text = DateTime.Now.ToString();
              this.clientes_Contas_a_ReceberBindingSource.EndEdit();
              DataContextFactory.DataContext.SubmitChanges();
              nome_ClienteTextBox.Enabled = false;
              endereço_ClienteTextBox.Enabled = false;
              bairro_ClienteTextBox.Enabled = false;
              estadoTextBox.Enabled = false;
              municipio_ClienteTextBox.Enabled = false;
              telefoneTextBox.Enabled = false;
              celularTextBox.Enabled = false;
              cNPJTextBox.Enabled = false;
              CB_Grupo.Enabled = false;
              CB_Status.Enabled = false;
              identificacaoTextBox.Enabled = false;
              emailTextBox.Enabled = false;
              btn_Pesquisar.Enabled = false;
            
              MessageBox.Show("Dados do Cliente Inseridos / Alterados com Sucesso!");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            nome_ClienteTextBox.Enabled = true;
            endereço_ClienteTextBox.Enabled = true;
            bairro_ClienteTextBox.Enabled = true;
            estadoTextBox.Enabled = true;
            municipio_ClienteTextBox.Enabled = true;
            telefoneTextBox.Enabled = true;
            celularTextBox.Enabled = true;
            cNPJTextBox.Enabled = true;
            CB_Grupo.Enabled = true;
            CB_Status.Enabled = true;
            identificacaoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            btn_Pesquisar.Enabled = true;
           
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            this.clientes_Contas_a_ReceberBindingSource.MoveNext();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.clientes_Contas_a_ReceberBindingSource.MovePrevious();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.clientes_Contas_a_ReceberBindingSource.AddNew();
            nome_ClienteTextBox.Focus();
            nome_ClienteTextBox.Enabled = true;
            endereço_ClienteTextBox.Enabled = true;
            bairro_ClienteTextBox.Enabled = true;
            estadoTextBox.Enabled = true;
            municipio_ClienteTextBox.Enabled = true;
            telefoneTextBox.Enabled = true;
            celularTextBox.Enabled = true;
            cNPJTextBox.Enabled = true;
            CB_Grupo.Enabled = true;
            CB_Status.Enabled = true;
            identificacaoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            btn_Pesquisar.Enabled = true;

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCliente frm = new PesquisarCliente();
            frm.Show();
        }

       

       
         
         
        
     }
}
