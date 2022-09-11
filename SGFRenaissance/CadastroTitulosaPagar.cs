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
using System.Diagnostics;
using System.Data.OleDb;
using System.Globalization;
using sistema.DAL;

namespace SGFRenaissance
{
    public partial class CadastroTitulosaPagar : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adapt2;
        Int32 ID = 0;
        Int32 IDparcela = 0;
        private DateTime Data_Agora;
        private int ultimoCodigoEntradaTP = 0;

        public CadastroTitulosaPagar()
        {
            InitializeComponent();
            ExibirDadosTitulo();
            ExibirDadosParcela();
            DataGridViewTitulo.AllowUserToAddRows = false;
            DataGridViewParcela.AllowUserToAddRows = false;
            int currentIndex;
            int flag = -1;
        }

        private void ExibirDadosTitulo()
        {
            try
            {
                conn.Open();
                DataTable Dt = new DataTable();
                adapt = new SqlDataAdapter("Select * from Entrada_Titulos_a_Pagar", conn);
                adapt.Fill(Dt);
                DataGridViewTitulo.DataSource = Dt;
                DataGridViewTitulo.DataSource = entradaTitulosaPagarBindingSource;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro! " + Ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ExibirDadosParcela()
        {
            try
            {
                conn.Open();
                DataTable Dt = new DataTable();
                adapt = new SqlDataAdapter("Select * from Numero_Parcelas_a_Pagar", conn);
                adapt.Fill(Dt);
                DataGridViewParcela.DataSource = Dt;
                DataGridViewParcela.DataSource = numero_Parcelas_a_PagarBindingSource;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro! " + Ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void TryRefreshFornecedor()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Nome_Fornecedor from Fornecedor_Contas_a_Pagar where Cod_Fornecedor='{0}'", Cod_FornecedorTextbox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    textBox_Fornecedor.Text = reader["Nome_Fornecedor"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro");
            }
        }

        void TryRefreshCustos()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Descricao_Centro_Custos from Centro_Custos where Cod_Centro_Custos ='{0}'", TextBox_Cod_CentroCustos.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    TexBoxNome_CentroCustos.Text = reader["Descricao_Centro_Custos"].ToString();
                }
                sqlConnection.Close();

            }
            catch (Exception)
            {
                Debug.WriteLine("Erro");
            }
        }

        void TryRefreshDespesa()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Descricao_Despesa from Contas_Despesas where Cod_Despesa ='{0}'", cod_DespesaTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    descricao_Despesa_textBox.Text = reader["Descricao_Despesa"].ToString();
                }
                sqlConnection.Close();

            }
            catch (Exception)
            {
                Debug.WriteLine("Erro");
            }

        }

        void TryRefreshStatusTitulo()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Descricao_Status_Titulo from Status_Titulo where Cod_Status_Titulo ='{0}'", cod_Status_TituloTextBox1.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Status_Titulo_Textbox.Text = reader["Descricao_Status_Titulo"].ToString();
                }
                sqlConnection.Close();

            }
            catch (Exception)
            {
                Debug.WriteLine("Erro");
            }

        }


        private void LimparDados()
        {           
            cod_Entr_Tit_a_Pagartextbox.Text = "";
            Cod_FornecedorTextbox.Text = "";
            textBox_Fornecedor.Text = "";
            TextBox_Cod_CentroCustos.Text = "";
            TexBoxNome_CentroCustos.Text = "";
            cod_Status_TituloTextBox1.Text = "";
            Status_Titulo_Textbox.Text = "";
            cod_DespesaTextBox.Text = "";
            descricao_Despesa_textBox.Text = "";
            Numero_Titulo.Text = "";
            numero_ParcelasTextBox.Text = "";
            DataDocumentodateTimePicker1.CustomFormat = "   ";
            datavencimento.CustomFormat = "   ";
            observacaoTextBox.Text = "";
            valor_TituloTextBox.Text = "";
            valor_Pago_a_VistaTextBox.Text = "";
            acrescimosTextBox.Text = "";
            descontosTextBox.Text = "";
            saldoTextBox.Text = "";
            historico_TituloTextBox.Text = "";
            data_logintxtbox.Text = "";
            login_NameTextBox.Text = "";
            // Limpar campo de parcelas 
            cod_Entrada_Titulos_a_PagarTextBox2.Text = "";
            numero_ParcelaTextBox1.Text = "";
            //dateTimePicker1.Text = "";
            valor_ParcelaTextBox1.Text = "";
            cod_Status_TituloTextBox2.Text = "";
            historicoTextBox1.Text = "";
            dateTimePickerParcela.CustomFormat = "   ";
            numero_ParcelaTextBox1.Text = "";
            Cod_Numero_Parcelas_a_PagarTextBox.Text = " ";
            cod_Entrada_Titulos_a_PagarTextBox2.Text = " ";
        }

           private void LimparDadosParcela()
        {
            cod_Entrada_Titulos_a_PagarTextBox2.Text = "";
            Cod_Numero_Parcelas_a_PagarTextBox.Text = " ";
            numero_ParcelaTextBox1.Text = " ";
            valor_ParcelaTextBox1.Text = " ";
            cod_Status_TituloTextBox2.Text = " ";
            historicoTextBox1.Text = "";
            dateTimePickerParcela.CustomFormat = "   ";
            DescricaoParcela.Text = " ";

        }
           private void btn_fechar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Sair do Forumulário ?", "Cadastrar Títulos a Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.entradaTitulosaPagarBindingSource.EndEdit();
                    this.numero_Parcelas_a_PagarBindingSource.EndEdit();
                    this.Close();
                }
                else
                {
                    ActiveForm.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Problema para fechar o formulário Entrada de Títulos a Pagar! " + Ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {

            LimparDados();
            cod_Entr_Tit_a_Pagartextbox.Enabled = true;
            Cod_FornecedorTextbox.Enabled = true;
            textBox_Fornecedor.Enabled = true;
            TextBox_Cod_CentroCustos.Enabled = true;
            TexBoxNome_CentroCustos.Enabled = true;
            cod_Status_TituloTextBox1.Enabled = true;
            Status_Titulo_Textbox.Enabled = true;
            cod_DespesaTextBox.Enabled = true;
            descricao_Despesa_textBox.Enabled = true;
            Numero_Titulo.Enabled = true;
            DataDocumentodateTimePicker1.Enabled = true;
            DataDocumentodateTimePicker1.Value.ToShortDateString();
            datavencimento.Enabled = true;
            datavencimento.Value.ToShortDateString();
            numero_ParcelasTextBox.Enabled = true;
            observacaoTextBox.Enabled = true;
            valor_TituloTextBox.Enabled = true;
            valor_Pago_a_VistaTextBox.Enabled = true;
            acrescimosTextBox.Enabled = true;
            descontosTextBox.Enabled = true;
            saldoTextBox.Enabled = true;
            historico_TituloTextBox.Enabled = true;
            data_logintxtbox.Enabled = true;
            login_NameTextBox.Enabled = true;
            // Limpar campo de parcelas 
            cod_Entrada_Titulos_a_PagarTextBox2.Enabled = true;
            numero_ParcelaTextBox1.Enabled = true;
            dateTimePickerParcela.Enabled = true;
            dateTimePickerParcela.CustomFormat = "   ";
            valor_ParcelaTextBox1.Enabled = true;
            cod_Status_TituloTextBox2.Enabled = true;
            historicoTextBox1.Enabled = true;
            // Ativar e desativar botões
            btn_salvar.Enabled = true;
            btn_salvar.BackColor = Color.DarkOrange;
            btn_Novo.Enabled = false;
            btn_atualizar.Enabled = false;
            btn_proximo.Enabled = false;
            btn_voltar.Enabled = false;
            btn_deletar.Enabled = false;
            btn_InserirParcela.Enabled = false;
            btn_AdicionarParcela.Enabled = false;
            btn_atualizarParcela.Enabled = false;
            btn_fechar.Enabled = false;
            btn_Localizar.Enabled = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
            data_logintxtbox.Text = Data_Agora.ToLongDateString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;

            if (Cod_FornecedorTextbox.Text !="" && TextBox_Cod_CentroCustos.Text!="" && cod_Status_TituloTextBox1.Text !="" && cod_DespesaTextBox.Text !="" &&  Numero_Titulo.Text != "" && valor_TituloTextBox.Text !=""  
                && acrescimosTextBox.Text !="" && descontosTextBox.Text !="" && valor_Pago_a_VistaTextBox.Text !="")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Entrada_Titulos_a_Pagar(Cod_Fornecedor, Numero_Documento, Data_Documento, Data_Vencimento, Valor_Titulo,"
                  + " Valor_Pago_a_Vista, Acrescimos, Descontos, Saldo, Numero_Parcelas, Cod_Centro_Custos, Cod_Status_Titulo, Cod_Despesa, Historico_Titulo, Observacao, Data_Login, Login_Name)Values(@Cod_Fornecedor,@Numero_Documento,"
                  + " @Data_Documento,@Data_Vencimento,@Valor_Titulo,@Valor_Pago_a_Vista,@Acrescimos,@Descontos,@Saldo,@Numero_Parcelas,@Cod_Centro_Custos,@Cod_Status_Titulo,@Cod_Despesa,@Historico_Titulo,@Observacao,@Data_Login,@Login_Name)", conn);
                    conn.Open();

                    Int32 Cod_Fornecedor = Int32.Parse(Cod_FornecedorTextbox.Text);
                    cmd.Parameters.AddWithValue("@Cod_Fornecedor", Cod_Fornecedor);
                    cmd.Parameters.AddWithValue("@Numero_Documento", Numero_Titulo.Text);
                    cmd.Parameters.AddWithValue("@Data_Documento", DataDocumentodateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Data_Vencimento", datavencimento.Value);
                    decimal valor_Titulo = decimal.Parse(valor_TituloTextBox.Text);
                    cmd.Parameters.AddWithValue("@Valor_Titulo", valor_Titulo);
                    decimal valor_Pago_a_Vista = decimal.Parse(valor_Pago_a_VistaTextBox.Text);
                    cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", valor_Pago_a_Vista);
                    decimal Acrescimos = decimal.Parse(acrescimosTextBox.Text);
                    cmd.Parameters.AddWithValue("@Acrescimos", Acrescimos);
                    decimal Descontos = decimal.Parse(descontosTextBox.Text);
                    cmd.Parameters.AddWithValue("@Descontos", Descontos);
                    decimal Saldo = decimal.Parse(saldoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Saldo", Saldo);
                    Int32 Numero_Parcelas = Int32.Parse(numero_ParcelasTextBox.Text);
                    cmd.Parameters.AddWithValue("@Numero_Parcelas", Numero_Parcelas);
                    Int32 Cod_Centro_Custos = Int32.Parse(TextBox_Cod_CentroCustos.Text);
                    cmd.Parameters.AddWithValue("@Cod_Centro_Custos", Cod_Centro_Custos);
                    Int32 Cod_Status_Titulo = Int32.Parse(cod_Status_TituloTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Cod_Status_Titulo", Cod_Status_Titulo);
                    Int32 Cod_Despesa = Int32.Parse(cod_DespesaTextBox.Text);
                    cmd.Parameters.AddWithValue("@Cod_Despesa", Cod_Despesa);
                    cmd.Parameters.AddWithValue("@Historico_Titulo", historico_TituloTextBox.Text);
                    cmd.Parameters.AddWithValue("@Observacao", observacaoTextBox.Text);
                    DateTime Data_Login = Convert.ToDateTime(data_logintxtbox.Text);
                    cmd.Parameters.AddWithValue("@Data_Login", Data_Login);
                    cmd.Parameters.AddWithValue("@Login_Name", login_NameTextBox.Text); 
                    Int32 result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados do Título Incluídos com Sucesso!" +result.ToString()+ " Registro Inserido!");
                    entrada_Titulos_a_PagarTableAdapter.Fill(this.entradaTitulosaPagarDGV.Entrada_Titulos_a_Pagar);
                    DataGridViewTitulo.DataSource = this.entradaTitulosaPagarBindingSource;
                    entradaTitulosaPagarBindingSource.MoveLast();
             //     aqui Inabilito a informação para a parcela - Cód. Tit. a Pagar. Obriga a clicar para inserir Parcela
                    cod_Entrada_Titulos_a_PagarTextBox2.Enabled = false;
                    numero_ParcelaTextBox1.Enabled = false;
                    valor_ParcelaTextBox1.Enabled = false;
                    cod_Status_TituloTextBox2.Enabled = false;
                    historicoTextBox1.Enabled = false;
                    dateTimePickerParcela.Enabled = false; 
                    numero_ParcelaTextBox1.Enabled = false;
                    Cod_Numero_Parcelas_a_PagarTextBox.Enabled = false;
                    btn_salvar.Enabled = false;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro! " + Ex.Message);
                }
                finally
                {
                    conn.Close();
                    ExibirDadosTitulo();
                    btn_AdicionarParcela.Enabled = true;
                }
              } 
            else
            {
                MessageBox.Show("Informe todos os Dados necessários para incluir o Título");
            } 
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
            data_logintxtbox.Text = Data_Agora.ToShortDateString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            
            string constr = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))

                if (Cod_FornecedorTextbox.Text != "" && TextBox_Cod_CentroCustos.Text != "" && cod_Status_TituloTextBox1.Text != "" && cod_DespesaTextBox.Text != "" && Numero_Titulo.Text != "" && valor_TituloTextBox.Text != "" && valor_TituloTextBox.Text != "" && valor_Pago_a_VistaTextBox.Text !="" && descontosTextBox.Text!="" && acrescimosTextBox.Text !="" )
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Entrada_Titulos_a_Pagar SET Cod_Fornecedor=@Cod_Fornecedor, Numero_Documento=@Numero_Documento, Data_Documento=@Data_Documento, Data_Vencimento=@Data_Vencimento, Valor_Titulo=@Valor_Titulo, Valor_Pago_a_Vista=@Valor_Pago_a_Vista, Acrescimos=@Acrescimos, Descontos=@Descontos, Saldo=@Saldo, Numero_Parcelas=@Numero_Parcelas, Cod_Centro_Custos=@Cod_Centro_Custos, Cod_Status_Titulo=@Cod_Status_Titulo, Cod_Despesa=@Cod_Despesa, Historico_Titulo=@Historico_Titulo, Observacao=@Observacao, Data_Login=@Data_Login, Login_Name=@Login_Name WHERE Cod_Entrada_Titulos_a_Pagar=@Cod_Entrada_Titulos_a_Pagar", conn);
                        conn.Open();

                        cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Pagar", ID);
                        Int32 Cod_Fornecedor = Int32.Parse(Cod_FornecedorTextbox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Fornecedor", Cod_Fornecedor);
                        cmd.Parameters.AddWithValue("@Numero_Documento", Numero_Titulo.Text);
                        cmd.Parameters.AddWithValue("@Data_Documento", DataDocumentodateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Data_Vencimento", datavencimento.Value);
                        decimal valor_Titulo = decimal.Parse(valor_TituloTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_Titulo", valor_Titulo);
                        decimal valor_Pago_a_Vista = decimal.Parse(valor_Pago_a_VistaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", valor_Pago_a_Vista);
                        decimal Acrescimos = decimal.Parse(acrescimosTextBox.Text);
                        cmd.Parameters.AddWithValue("@Acrescimos", Acrescimos);
                        decimal Descontos = decimal.Parse(descontosTextBox.Text);
                        cmd.Parameters.AddWithValue("@Descontos", Descontos);
                        decimal Saldo = decimal.Parse(saldoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Saldo", Saldo);
                        Int32 Numero_Parcelas = Int32.Parse(numero_ParcelasTextBox.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcelas", Numero_Parcelas);
                        Int32 Cod_Centro_Custos = Int32.Parse(TextBox_Cod_CentroCustos.Text);
                        cmd.Parameters.AddWithValue("@Cod_Centro_Custos", Cod_Centro_Custos);
                        Int32 Cod_Status_Titulo = Int32.Parse(cod_Status_TituloTextBox1.Text);
                        cmd.Parameters.AddWithValue("@Cod_Status_Titulo", Cod_Status_Titulo);
                        Int32 Cod_Despesa = Int32.Parse(cod_DespesaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Despesa", Cod_Despesa);
                        cmd.Parameters.AddWithValue("@Historico_Titulo", historico_TituloTextBox.Text);
                        cmd.Parameters.AddWithValue("@Observacao", observacaoTextBox.Text);
                        DateTime dataagora = Convert.ToDateTime(data_logintxtbox.Text);
                        cmd.Parameters.AddWithValue("@Data_Login", dataagora);
                        cmd.Parameters.AddWithValue("@Login_Name", login_NameTextBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Show! Dados do Título Atualizados com Sucesso!");
                        conn.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ExibirDadosTitulo();
                        ExibirDadosParcela();
                        btn_atualizar.Enabled = false;
                        LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("Informe todos os Dados Necessários para Atualizar o Título!");
                }
        }
        int currentIndex;
        int flag = -1;
        private void CadastroTitulosaPagar_Load(object sender, EventArgs e)
        {     
    //      Colocar Foco no Form_Load
            Cod_FornecedorTextbox.Focus();
   //       Desabilitar os botões no Form_Load
            btn_salvar.Enabled = false;
            btn_atualizar.Enabled = false;
            btn_deletar.Enabled = true;
            btn_AdicionarParcela.Enabled = false;
            btn_atualizarParcela.Enabled = false;
            btn_InserirParcela.Enabled = false;
            btn_fechar.Enabled = true;
            btn_Localizar.Enabled = true;

   //       Desabilitar campos - Textboxes - do Título
            cod_Entr_Tit_a_Pagartextbox.Enabled = false;
            Cod_FornecedorTextbox.Enabled = false;
            textBox_Fornecedor.Enabled = false;
            TextBox_Cod_CentroCustos.Enabled = false;
            TexBoxNome_CentroCustos.Enabled = false;
            cod_Status_TituloTextBox1.Enabled = false;
            Status_Titulo_Textbox.Enabled = false;
            cod_DespesaTextBox.Enabled = false;
            descricao_Despesa_textBox.Enabled = false;
            Numero_Titulo.Enabled = false;
            DataDocumentodateTimePicker1.Enabled = false;
            datavencimento.Enabled = false;
            DataDocumentodateTimePicker1.CustomFormat = null;
            datavencimento.CustomFormat = null;
            numero_ParcelasTextBox.Enabled = false;
            observacaoTextBox.Enabled = false;
            valor_TituloTextBox.Enabled = false;
            valor_Pago_a_VistaTextBox.Enabled = false;
            acrescimosTextBox.Enabled = false;            
            descontosTextBox.Enabled = false;
            saldoTextBox.Enabled = false;
            historico_TituloTextBox.Enabled = false;
            data_logintxtbox.Enabled = false;
            login_NameTextBox.Enabled = false;
      //    Desabilitar campos - Textboxes - da Parcela
            cod_Entrada_Titulos_a_PagarTextBox2.Enabled = false;
            numero_ParcelaTextBox1.Enabled = false;
            dateTimePickerParcela.Enabled = false;
            dateTimePickerParcela.CustomFormat ="   ";
            valor_ParcelaTextBox1.Enabled = false;
            cod_Status_TituloTextBox2.Enabled = false;
            historicoTextBox1.Enabled = false;

            // TODO: This line of code loads data into the 'entradaTitulosaPagarDGV.Entrada_Titulos_a_Pagar' table. You can move, or remove it, as needed.
            this.entrada_Titulos_a_PagarTableAdapter.Fill(this.entradaTitulosaPagarDGV.Entrada_Titulos_a_Pagar);
     //     this.numero_Parcelas_a_PagarTableAdapter.Fill(this.dGVNumeroParcelasPagar.Numero_Parcelas_a_Pagar);
            this.numero_Parcelas_a_PagarBindingSource.DataSource = DataContextFactory.DataContext.Numero_Parcelas_a_Pagars;
          
            ExibirDadosTitulo();
            ExibirDadosParcela();
            // Atualizar nomes nos TextBoxes 
            TryRefreshFornecedor();
            TryRefreshCustos();
            TryRefreshDespesa();
            TryRefreshStatusTitulo();
            string constr = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Entrada_Titulos_a_Pagar", conn);
                DataSet Ds = new DataSet();
                sda.Fill(Ds, "T1");
                DataGridViewTitulo.DataSource = Ds.Tables["T1"];
            }
            // Bind the "SelectionChanged" here
            DataGridViewTitulo.SelectionChanged += DataGridViewTitulo_SelectionChanged;
            GetDetails();
            
        }

        void GetDetails()
        {
            string constr = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
            int currentId;
            int index = DataGridViewTitulo.CurrentCell.RowIndex;
            currentId = Convert.ToInt32(DataGridViewTitulo.Rows[index].Cells["Cod_Id"].Value);
            using (SqlConnection conn = new SqlConnection(constr))
            {
                if (cod_Entr_Tit_a_Pagartextbox.Text !=null)
                {
                    var select = "Select * From Numero_Parcelas_a_Pagar Where Cod_Entrada_Titulos_a_Pagar=" + currentId;
                    SqlDataAdapter sda = new SqlDataAdapter(select, conn);
                    DataSet Ds = new DataSet();
                    sda.Fill(Ds, "T2");
                    DataGridViewParcela.DataSource = Ds.Tables["T2"];
                }
                else
                {
                    MessageBox.Show("Não é Possível navegar sem Parcelas! Exclua o Título!");
                }
            }
        }

        private void DataGridViewTitulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
        //      Habilitar campos do formulário
                cod_Entr_Tit_a_Pagartextbox.Enabled = true;
                Cod_FornecedorTextbox.Enabled = true;
                textBox_Fornecedor.Enabled = true;
                TextBox_Cod_CentroCustos.Enabled = true;
                TexBoxNome_CentroCustos.Enabled = true;
                cod_Status_TituloTextBox1.Enabled = true;
                Status_Titulo_Textbox.Enabled = true;
                cod_DespesaTextBox.Enabled = true;
                descricao_Despesa_textBox.Enabled = true;
                Numero_Titulo.Enabled = true;
                DataDocumentodateTimePicker1.Value.ToShortDateString();
                DataDocumentodateTimePicker1.Enabled = true;
                datavencimento.Value.ToShortTimeString();
                datavencimento.Enabled = true;
                numero_ParcelasTextBox.Enabled = true;
                observacaoTextBox.Enabled = true;
                valor_TituloTextBox.Enabled = true;
                valor_Pago_a_VistaTextBox.Enabled = true;
                acrescimosTextBox.Enabled = true;
                descontosTextBox.Enabled = true;
                saldoTextBox.Enabled = true;
                historico_TituloTextBox.Enabled = true;
                data_logintxtbox.Enabled = true;
                login_NameTextBox.Enabled = true;
                // Habilitar botão Atualizar
                btn_atualizar.Enabled = true;
                btn_AdicionarParcela.Enabled = true;
                // Passar valores do DataGridView para os Textboxes do Título
                ID = Convert.ToInt32(DataGridViewTitulo.Rows[e.RowIndex].Cells[0].Value.ToString());
                cod_Entr_Tit_a_Pagartextbox.Text = DataGridViewTitulo.CurrentRow.Cells[0].Value.ToString();
                Cod_FornecedorTextbox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[1].Value.ToString();
                Numero_Titulo.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[2].Value.ToString();
                DataDocumentodateTimePicker1.Value = Convert.ToDateTime(DataGridViewTitulo.Rows[e.RowIndex].Cells[3].Value);
                datavencimento.Value = Convert.ToDateTime(DataGridViewTitulo.Rows[e.RowIndex].Cells[4].Value);
                valor_TituloTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[5].Value.ToString();
                valor_Pago_a_VistaTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[6].Value.ToString();
                acrescimosTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[7].Value.ToString();
                descontosTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[8].Value.ToString();
                saldoTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[9].Value.ToString();
                numero_ParcelasTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[10].Value.ToString();
                TextBox_Cod_CentroCustos.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[11].Value.ToString();
                cod_Status_TituloTextBox1.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[12].Value.ToString();
                cod_DespesaTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[13].Value.ToString();
                historico_TituloTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[14].Value.ToString();
                observacaoTextBox.Text = DataGridViewTitulo.Rows[e.RowIndex].Cells[15].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }

        }

        private void DataGridViewTitulo_SelectionChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                GetDetails();
            }
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {

            btn_deletar.Enabled = true;
            // Check the index, and move the focus
            int currentIndex;
            currentIndex = DataGridViewTitulo.CurrentRow.Index;
            if (currentIndex < DataGridViewTitulo.Rows.Count - 1)
            {
                DataGridViewTitulo.CurrentCell = DataGridViewTitulo.Rows[currentIndex + 1].Cells[0];
                DataGridViewTitulo.CurrentCell.Selected = false;
                flag *= -1;
                DataGridViewTitulo.Rows[currentIndex + 1].Cells[0].Selected = true;
                this.DataGridViewTitulo.DataSource = this.entradaTitulosaPagarBindingSource;
                // Passar os valores do DataGridView para os Textboxes
                if (cod_Entrada_Titulos_a_PagarTextBox2.Text !=null)
                {
                    try
                    {
                        cod_Entrada_Titulos_a_PagarTextBox2.Text = DataGridViewParcela.CurrentRow.Cells[0].Value.ToString();
                        Cod_Numero_Parcelas_a_PagarTextBox.Text = DataGridViewParcela.CurrentRow.Cells[1].Value.ToString();
                        numero_ParcelaTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[2].Value.ToString();
                        dateTimePickerParcela.Text = DataGridViewParcela.CurrentRow.Cells[3].Value.ToString();
                        valor_ParcelaTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[4].Value.ToString();
                        historicoTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[5].Value.ToString();
                        cod_Status_TituloTextBox2.Text = DataGridViewParcela.CurrentRow.Cells[6].Value.ToString();
                        // Atualizar nomes nos TextBoxes 
                        TryRefreshFornecedor();
                        TryRefreshCustos();
                        TryRefreshDespesa();
                        TryRefreshStatusTitulo();

                    }
                    catch (Exception)
                    {
                      MessageBox.Show("Erro! Não é Possível Navegar nos Registros sem as Parcelas, Exclua o Título!");
                    }

                }
                else
                {
                    if (cod_Entrada_Titulos_a_PagarTextBox2.Text != cod_Entr_Tit_a_Pagartextbox.Text)
                    MessageBox.Show("Erro!, não é possivel navegar nos Registros sem as Parcelas, Exclua o Título!");
                    btn_proximo.Enabled = false;

                }       
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Check the index, and move the focus
            int currentIndex;
            currentIndex = DataGridViewTitulo.CurrentCell.RowIndex;
            if (currentIndex > 0)
            {
                DataGridViewTitulo.CurrentCell = DataGridViewTitulo.Rows[currentIndex - 1].Cells[0];
                DataGridViewTitulo.CurrentCell.Selected = false;
                flag *= -1;
                DataGridViewTitulo.Rows[currentIndex - 1].Cells[0].Selected = true;
                this.DataGridViewTitulo.DataSource = this.entradaTitulosaPagarBindingSource;
                // Passar os valores do DataGridView para os Textboxes
                cod_Entrada_Titulos_a_PagarTextBox2.Text = DataGridViewParcela.CurrentRow.Cells[0].Value.ToString();
                Cod_Numero_Parcelas_a_PagarTextBox.Text = DataGridViewParcela.CurrentRow.Cells[1].Value.ToString();
                numero_ParcelaTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerParcela.Text = DataGridViewParcela.CurrentRow.Cells[3].Value.ToString();
                valor_ParcelaTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[4].Value.ToString();
                historicoTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[5].Value.ToString();
                cod_Status_TituloTextBox2.Text = DataGridViewParcela.CurrentRow.Cells[6].Value.ToString();
                // Atualizar nomes nos TextBoxes 
                TryRefreshFornecedor();
                TryRefreshCustos();
                TryRefreshDespesa();
                TryRefreshStatusTitulo();
            }
        }

    

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cod_Entr_Tit_a_Pagartextbox.Text);  
            if (cod_Entr_Tit_a_Pagartextbox.Text != null)
            {  
                if (DataGridViewParcela.RowCount == 0)
                {
                    if (MessageBox.Show("Deseja deletar este Título ?", "Cadastro de Títulos a Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            cmd = new SqlCommand("DELETE Entrada_Titulos_a_Pagar WHERE Cod_Entrada_Titulos_a_Pagar= @Cod_Entrada_Titulos_a_Pagar", conn);
                            conn.Open();
                            cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Pagar", ID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Título Excluído com Sucesso...!");
                            this.entrada_Titulos_a_PagarTableAdapter.Fill(this.entradaTitulosaPagarDGV.Entrada_Titulos_a_Pagar);
                            this.entradaTitulosaPagarBindingSource.MoveFirst();
                            btn_deletar.Enabled = false;
                        
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("Erro! " + Ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                            ExibirDadosTitulo();
                            ExibirDadosParcela();
                            LimparDados();
                        }


                    }
                    
                }
                else
                {
                    MessageBox.Show("É necessário Excluir todas as Parcelas antes de Deletar o Título!");
                }

            }
        }
      
        private void btn_atualizarParcela_Click(object sender, EventArgs e)
        {
            TelaUpdateParcelaTitPagar frm = new TelaUpdateParcelaTitPagar();
            frm.Show();
        }


        private void btn_Tela_Centro_Custos_Click(object sender, EventArgs e)
        {
            TelaCentroCustos frm = new TelaCentroCustos();
            frm.Show();
        }

        private void DataGridViewParcela_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
      //       Habilitar campos da Parcela
                cod_Entrada_Titulos_a_PagarTextBox2.Enabled = true;
                Cod_Numero_Parcelas_a_PagarTextBox.Enabled = true;
                numero_ParcelaTextBox1.Enabled = true;
                dateTimePickerParcela.Enabled = true;
                valor_ParcelaTextBox1.Enabled = true;
                cod_Status_TituloTextBox2.Enabled = true;
                historicoTextBox1.Enabled = true;
             // Transferir dados do DataGridView para os TextBoxes
                cod_Entrada_Titulos_a_PagarTextBox2.Text = DataGridViewParcela.CurrentRow.Cells[0].Value.ToString();
                IDparcela = Convert.ToInt32(DataGridViewParcela.Rows[e.RowIndex].Cells[0].Value.ToString());
                Cod_Numero_Parcelas_a_PagarTextBox.Text = DataGridViewParcela.CurrentRow.Cells[1].Value.ToString();
                numero_ParcelaTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerParcela.Text = DataGridViewParcela.CurrentRow.Cells[3].Value.ToString();
                valor_ParcelaTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[4].Value.ToString();
                historicoTextBox1.Text = DataGridViewParcela.CurrentRow.Cells[5].Value.ToString();
                cod_Status_TituloTextBox2.Text = DataGridViewParcela.CurrentRow.Cells[6].Value.ToString();
           //   Habilitar botão Atualizar Parcela
                btn_atualizarParcela.Enabled = true;
                btn_AdicionarParcela.Enabled = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }

        private void DataGridViewParcela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string constr = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
                if (e.ColumnIndex == 7)
                {
                  if (MessageBox.Show("Deseja Excluir esta Parcela?", "Número de Parcelas do Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                  {
                    try
                    {
                        int IDParcela = Convert.ToInt32(Cod_Numero_Parcelas_a_PagarTextBox.Text);
                        cmd = new SqlCommand("DELETE Numero_Parcelas_a_Pagar WHERE Cod_Numero_Parcelas_a_Pagar = @Cod_Numero_Parcelas_a_Pagar", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_a_Pagar", IDParcela);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Parcela do Título Excluída com Sucesso!");
                        DataGridViewParcela.Rows.Remove(DataGridViewParcela.Rows[e.RowIndex]);
                    //  Atualizar o DataGridView Parcelas
                 //     this.numero_Parcelas_a_PagarTableAdapter.Fill(dGVNumeroParcelasPagar.Numero_Parcelas_a_Pagar);
                        ExibirDadosParcela();
                        this.entradaTitulosaPagarBindingSource.MoveFirst();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! " + Ex.Message);
                    }
                    finally
                    {
                            conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi possível Excluir a Parcela Selecionada!");
            }
        }

        private void btn_InserirParcela_Click(object sender, EventArgs e)
        {
            if (cod_Entrada_Titulos_a_PagarTextBox2.Text != "" && numero_ParcelaTextBox1.Text != "" && dateTimePickerParcela.Text != "" && valor_ParcelaTextBox1.Text != " ")
            {
                int CodIDEntrTitPagar = 0;
                // Aqui busco o último ID - Cod_Entrada_Titulos_a_Pagar da tabela Entrada_Titulos_a_Pagar utilizando uma expressão lambda e guardo na váriavel ultimoId
                // var ultimoId = DataContextFactory.DataContext.Entrada_Titulos_a_Pagars.Max(x => x.Cod_Entrada_Titulos_a_Pagar);
                var ultimoId = cod_Entrada_Titulos_a_PagarTextBox2.Text;
                // Aqui coloco o valor do proximo id no TextBox - cod_Entrada_Titulos_a_PagarTextBox1
                   cod_Entrada_Titulos_a_PagarTextBox2.Text = (ultimoId).ToString();
                   CodIDEntrTitPagar = Convert.ToInt32(cod_Entrada_Titulos_a_PagarTextBox2.Text);
                   
                try
                {
                    cmd = new SqlCommand("INSERT INTO Numero_Parcelas_a_Pagar( Cod_Entrada_Titulos_a_Pagar, Numero_Parcela, Data_Vencimento, Valor_Parcela,"
                 + " Historico, Cod_Status_Titulo)Values( @Cod_Entrada_Titulos_a_Pagar, @Numero_Parcela, @Data_Vencimento, @Valor_Parcela, @Historico, @Cod_Status_Titulo)", conn);
                    conn.Open();
               //   cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_a_Pagar", ID);
                    cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Pagar", CodIDEntrTitPagar);
                    Int32 NumeroParcelas = Convert.ToInt32(numero_ParcelaTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Numero_Parcela", NumeroParcelas);
                    DateTime DataVencimento = Convert.ToDateTime(dateTimePickerParcela.Value); 
                    cmd.Parameters.AddWithValue("@Data_Vencimento", DataVencimento);
                    Decimal ValorParcela = Convert.ToDecimal(valor_ParcelaTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Valor_Parcela", ValorParcela);
                    string Historico = historicoTextBox1.Text;
                    cmd.Parameters.AddWithValue("@Historico", Historico);
                    Int32 CodStatusParcela = Convert.ToInt32(cod_Status_TituloTextBox2.Text);
                    cmd.Parameters.AddWithValue("@Cod_Status_Titulo", CodStatusParcela);
                    Int32 result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados da Parcela Inseridos com Sucesso! " + result.ToString() + " Registro Inserido!");
                    btn_AdicionarParcela.Enabled = true;
                    btn_fechar.Enabled = true;
                    btn_proximo.Enabled = false;
                    btn_voltar.Enabled = false;
                    btn_Novo.Enabled = true;
                    btn_salvar.Enabled = false;
                    btn_atualizar.Enabled = false;
                    btn_deletar.Enabled = false;
                    btn_InserirParcela.Enabled = false;
                    // Atualizar o Grid e os textboxes
                    numero_Parcelas_a_PagarTableAdapter.Fill(this.dGVNumeroParcelasPagar.Numero_Parcelas_a_Pagar);
                    DataGridViewParcela.DataSource = this.numero_Parcelas_a_PagarBindingSource;
                    LimparDadosParcela();
                    cod_Entrada_Titulos_a_PagarTextBox2.Enabled = false;
                    Cod_Numero_Parcelas_a_PagarTextBox.Enabled = false;
                    numero_ParcelaTextBox1.Enabled = false;
                    dateTimePickerParcela.Enabled = false;
                    dateTimePickerParcela.CustomFormat = "   ";
                    valor_ParcelaTextBox1.Enabled = false;
                    cod_Status_TituloTextBox2.Enabled = false;
                    historicoTextBox1.Enabled = false;
                    DescricaoParcela.Enabled = false;




                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro! ao Inserir Parcela! " + Ex.Message);
                }
                finally
                {
                    conn.Close();
                    ExibirDadosParcela();
                    
                }
            }
            else
            {
                MessageBox.Show("Informe Todos os Dados Para Inserir a Parcela!");
            }
        }

        private void btn_AdicionarParcela_Click(object sender, EventArgs e)
        {
            cod_Entrada_Titulos_a_PagarTextBox2.Text = " ";
            numero_ParcelaTextBox1.Text = "";
            valor_ParcelaTextBox1.Text = "";
            cod_Status_TituloTextBox2.Text = " ";
            historicoTextBox1.Text = " ";
            dateTimePickerParcela.Enabled = true;
            dateTimePickerParcela.CustomFormat = "   ";
            numero_ParcelaTextBox1.Text = " ";
            Cod_Numero_Parcelas_a_PagarTextBox.Text = " ";
            DescricaoParcela.Text = "";
            cod_Entrada_Titulos_a_PagarTextBox2.Enabled = true;
            numero_ParcelaTextBox1.Enabled = true;
            valor_ParcelaTextBox1.Enabled = true;
            cod_Status_TituloTextBox2.Enabled = true;
            historicoTextBox1.Enabled = true;
            DescricaoParcela.Enabled = true;
            Cod_Numero_Parcelas_a_PagarTextBox.Enabled = true;
            int CodIDEntrTitPagar = 0;
            cod_Entr_Tit_a_Pagartextbox.Refresh();
            CodIDEntrTitPagar = Convert.ToInt32(cod_Entr_Tit_a_Pagartextbox.Text);
            cod_Entrada_Titulos_a_PagarTextBox2.Text = CodIDEntrTitPagar.ToString();
            btn_InserirParcela.Enabled = true;
            btn_AdicionarParcela.Enabled = false;
            numero_ParcelaTextBox1.Focus();


        }

        private void valor_TituloTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valortitulo = 0;
            decimal valorpagoavista = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;

            Decimal.TryParse(valor_TituloTextBox.Text, out valortitulo);
            Decimal.TryParse(valor_Pago_a_VistaTextBox.Text, out valorpagoavista);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            saldo = ((valortitulo + acrescimos) - (valorpagoavista + descontos));
            saldoTextBox.Text = saldo.ToString();
        }

        private void descontosTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valortitulo = 0;
            decimal valorpagoavista = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;
            Decimal.TryParse(valor_TituloTextBox.Text,out valortitulo);
            Decimal.TryParse(valor_Pago_a_VistaTextBox.Text, out valorpagoavista);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            saldo = ((valortitulo + acrescimos) - (valorpagoavista + descontos));
            saldoTextBox.Text = saldo.ToString();
        }

        private void valor_Pago_a_VistaTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valortitulo = 0;
            decimal valorpagoavista = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;
            Decimal.TryParse(valor_TituloTextBox.Text, out valortitulo);
            Decimal.TryParse(valor_Pago_a_VistaTextBox.Text, out valorpagoavista);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            saldo = ((valortitulo + acrescimos) - (valorpagoavista + descontos));
            saldoTextBox.Text = saldo.ToString();
        }

        private void acrescimosTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valortitulo = 0;
            decimal valorpagoavista = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;
            Decimal.TryParse(valor_TituloTextBox.Text, out valortitulo);
            Decimal.TryParse(valor_Pago_a_VistaTextBox.Text, out valorpagoavista);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            saldo = ((valortitulo + acrescimos) - (valorpagoavista + descontos));
            saldoTextBox.Text = saldo.ToString();
        }

        private void btn_fornecedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores frm = new TelaFornecedores() { Owner = this };
            frm.ShowDialog();
        }

        private void btn_Tela_Centro_Custos_Click_1(object sender, EventArgs e)
        {
            TelaCentroCustos frm = new TelaCentroCustos() { Owner = this };
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaStatusTitulo frm = new TelaStatusTitulo() { Owner = this };
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCodigoDespesa frm = new TelaCodigoDespesa() { Owner = this };
            frm.ShowDialog();
        }

        private void DataDocumentodateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataDocumentodateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void datavencimento_ValueChanged(object sender, EventArgs e)
        {
            datavencimento.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerParcela_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerParcela.CustomFormat = "dd/MM/yyyy";
        }

        private void DataDocumentodateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataDocumentodateTimePicker1.CustomFormat = "   ";
            }
        }

        private void datavencimento_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                datavencimento.CustomFormat = "   ";
            }
        }

        private void dateTimePickerParcela_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePickerParcela.CustomFormat = "   ";
            }
        }

        private void btn_StatusParcela_Click(object sender, EventArgs e)
        {
            TelaStatusTitulo frm = new TelaStatusTitulo() { Owner = this };
            frm.ShowDialog();
        }
    }
}
