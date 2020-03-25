using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;
using System.Diagnostics;

namespace SGFRenaissance
{
    public partial class Pagamento_de_Titulos : Form
    {
        DateTime Data_Agora;
        decimal Total;
        decimal pagamento = 0;
        decimal saldo = 0;
        decimal Acrescimos = 0;
        decimal Desconto = 0;
        public decimal valorparcelaPublic = 0;
        public string NumeroParcelasTitulo;
        public int numeroparcelastituloInt = 0;
        public int numeroparcelaDGVInt  = 0;
        public int CodigoTituloPagar = 0;
        
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        Int32 LastID = 0;
        Int32 ID = 0;
        public Pagamento_de_Titulos()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numero_Parcelas_a_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.numero_Parcelas_a_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.numeroParcelasaPagarDGV);

        }

        private void Pagamento_de_Titulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'base_Parcelas_PagasDGV.Base_Parcelas_Pagas' table. You can move, or remove it, as needed.
            this.base_Parcelas_PagasTableAdapter.Fill(this.base_Parcelas_PagasDGV.Base_Parcelas_Pagas);
            // TODO: This line of code loads data into the 'baseTitulosPago.Base_Titulos_Pagos' table. You can move, or remove it, as needed.
            this.base_Titulos_PagosTableAdapter.Fill(this.baseTitulosPago.Base_Titulos_Pagos);
            // TODO: This line of code loads data into the 'numeroParcelasaPagarDGV.Numero_Parcelas_a_Pagar' table. You can move, or remove it, as needed.
            this.numero_Parcelas_a_PagarTableAdapter.Fill(this.numeroParcelasaPagarDGV.Numero_Parcelas_a_Pagar);
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_proximo.Enabled = false;
            btn_Anterior.Enabled = false;
            btn_Localizar.Enabled = false;
            btn_InserirPagto.Enabled = false;
            btn_Pagar.Enabled = false;
            numero_Parcelas_a_PagarDataGridView.Enabled = false;
            data_PagamentoDateTimePicker1.CustomFormat = null;
            data_PagamentoDateTimePicker1.Value.ToShortDateString();
            cod_Base_Titulos_PagosTextBox1.Enabled = false;
            data_PagamentoDateTimePicker1.Enabled = false;
            valor_PagoTextBox1.Enabled = false;
            banco_DebitadoTextBox1.Enabled = false;
            historicoTextBox1.Enabled = false;
            numero_ChequeTextBox1.Enabled = false;
            data_PagamentoDateTimePicker.CustomFormat = "   ";
        }

        void BuscarDadosDoFornecedor()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES 
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Cod_Fornecedor from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Cod_Fornecedor.Text = reader["Cod_Fornecedor"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }
        }

        void BuscarDadosNF()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES 
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Numero_Documento from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Numero_NF.Text = reader["Numero_Documento"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }

        }

        void BuscarValorTitulo()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Valor_Titulo from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Valor_Titulo.Text = reader["Valor_Titulo"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }
        }

        void BuscarValorPagoaVista()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Valor_Pago_a_Vista from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    valor_pago_a_vista.Text = reader["Valor_Pago_a_Vista"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }
        }

        void BuscarDataNF()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Data_Documento from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    DataNF.Text = reader["Data_Documento"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }

        }

        void BuscarCentroCustos()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Cod_Centro_Custos from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    CentroCustosTextbox.Text = reader["Cod_Centro_Custos"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }

        }

        void BuscarCodigoDespesa()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Cod_Despesa from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    CodDespesaTextbox.Text = reader["Cod_Despesa"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }
        }

        void BuscarHistoricoTitulo()
        {
            // BUSCAR AS INFORMAÇÕES DO TÍTULO E PASSAR PARA OS TEXTBOXES
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Historico_Titulo from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", cod_Titulo_a_PagarTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    hitorico_titulo.Text = reader["Historico_Titulo"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }

        }

        void BuscarNumeroParcelasTitulo()
        {
            // BUSCAR NÚMERO DE PARCELAS DO TÍTULO E COMPARAR COM A PARCELA QUE ESTÁ SENDO PAGA
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Numero_Parcelas from Entrada_Titulos_a_Pagar where Cod_Entrada_Titulos_a_Pagar='{0}'", numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[0].Value.ToString());
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection); // cod_Titulo_a_PagarTextBox.Text
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                   NumeroParcelasTitulo = reader["Numero_Parcelas"].ToString();
                   numeroparcelastituloInt = Convert.ToInt32(NumeroParcelasTitulo);
                }
                CodigoTituloPagar = Convert.ToInt32(numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[0].Value.ToString());
                sqlConnection.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro!");
            }
        }

        private void numero_Parcelas_a_PagarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // transferindo os dados do DataGridView de Títulos para confirmar o pagamento.
            if(e.ColumnIndex == 7)
            {
                cod_Titulo_a_PagarTextBox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[0].Value.ToString();
                cod_Numero_Parcela_a_PagarTextBox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[1].Value.ToString();
                valor_PagoTextBox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[4].Value.ToString();
                valorparcelatextbox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[4].Value.ToString();
                Numero_Parcela.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[2].Value.ToString();
                vencimento_Parcela.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[3].Value.ToString();
                historicoTextBox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[5].Value.ToString();
            //  cod_Status_TituloTextBox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[6].Value.ToString();
                int IDBanco = Int32.Parse(banco_DebitadoTextBox1.Text);
                banco_DebitadoTextBox.Text = Convert.ToString(IDBanco);
                string NumeroCheque1 = numero_ChequeTextBox1.Text;
                numero_ChequeTextBox.Text = NumeroCheque1;
                data_PagamentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
                data_PagamentoDateTimePicker.Value = data_PagamentoDateTimePicker1.Value;
                acrescimosTextBox.Text = "0,00";
                descontosTextBox.Text = "0,00";
                btn_editar.Enabled = false;
                btn_novo.Enabled = false;
                btn_proximo.Enabled = false;
                btn_Localizar.Enabled = false;
                btn_Anterior.Enabled = false;
                btn_salvar.Enabled = false;
                btn_fechar.Enabled = false;
                btn_Pagar.Enabled = true;
                //  AQUI EU BUSCO AS INFORMAÇÕES DO TÍTULO SELECIONADO NO BANCO E PASSO PARA OS TEXTBOXES COM O MÉTODO
                BuscarDadosDoFornecedor();
                BuscarDadosNF();
                BuscarValorTitulo();
                BuscarValorPagoaVista();
                BuscarDataNF();
                BuscarCentroCustos();
                BuscarCodigoDespesa();
                BuscarHistoricoTitulo();
                decimal valorparcela = 0;
                decimal valorpago = 0;
                decimal acrescimos = 0;
                decimal descontos = 0;
                decimal saldo = 0;
                decimal valorTotalPago = 0;
                valor_PagoTextBox.Text = valorparcelatextbox.Text;
                valorparcela = Convert.ToDecimal(valorparcelatextbox.Text);
                acrescimos = Convert.ToDecimal(acrescimosTextBox.Text);
                valorpago = Convert.ToDecimal(valor_PagoTextBox.Text);
                descontos = Convert.ToDecimal(descontosTextBox.Text);
                valorTotalPago = valorpago + acrescimos;
                valor_PagoTextBox.Text = Convert.ToString(valorTotalPago);
                saldo = ((valorTotalPago) - (valorparcela - descontos));
                saldoTextBox.Text = saldo.ToString();

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
            data_LoginTextBox.Text = Data_Agora.ToShortDateString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            valor_PagoTextBox1.Text = textBoxTotal.Text;
            ID = Convert.ToInt32(cod_Base_Titulos_PagosTextBox1.Text);
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
              
            if (cod_Base_Titulos_PagosTextBox1.Text != null && banco_DebitadoTextBox1.Text != null && numero_ChequeTextBox1.Text !=null)
             {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Base_Titulos_Pagos SET Data_Pagamento=@Data_Pagamento, Total_Pago=@Total_Pago, Banco_Debitado=@Banco_Debitado," 
                         +   "Numero_Cheque=@Numero_Cheque, Historico=@Historico, Data_Login=@Data_Login, Login_Name=@Login_Name WHERE Cod_Base_Titulos_Pagos=@Cod_Base_Titulos_Pagos", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Cod_Base_Titulos_Pagos", ID);
                        DateTime datapagamento = Convert.ToDateTime(data_PagamentoDateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Data_Pagamento", datapagamento);
                        decimal totalpago = Convert.ToDecimal(textBoxTotal.Text);
                        cmd.Parameters.AddWithValue("@Total_Pago", totalpago);
                        Int32 bancodebitado = Convert.ToInt32(banco_DebitadoTextBox1.Text);
                        cmd.Parameters.AddWithValue("@Banco_Debitado", bancodebitado);
                        string numerocheque = Convert.ToString(numero_ChequeTextBox1.Text);
                        cmd.Parameters.AddWithValue("@Numero_Cheque", numerocheque);
                        string historico = Convert.ToString(historicoTextBox1.Text);
                        cmd.Parameters.AddWithValue("@Historico", historico);
                        cmd.Parameters.AddWithValue("@Data_Login", Data_Agora);
                        string Loginname = login_NameTextBox.Text;
                        cmd.Parameters.AddWithValue("@Login_Name", Loginname);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Pagamento dos Títulos Salvos com Sucesso!" + result.ToString() + " Registro Atualizado!");
                        btn_salvar.Enabled = false;
                        numero_Parcelas_a_PagarDataGridView.Enabled = false;
                        btn_fechar.Enabled = true;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! ao Salvar/Atualizar Parcela! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        textBoxTotal.Text = string.Empty;
                        Total = 0;
                        pagamento = 0;
                        cod_Base_Titulos_PagosTextBox.Text = string.Empty;
                        cod_Base_Titulos_PagosTextBox1.Text = string.Empty;
                        data_PagamentoDateTimePicker1.CustomFormat = "   ";
                        valor_PagoTextBox1.Text = "0,00";
                        banco_DebitadoTextBox1.Text = string.Empty;
                        historicoTextBox1.Text = string.Empty;
                        numero_ChequeTextBox1.Text = string.Empty;
                        btn_InserirPagto.Enabled = true;
                    }

             }
              else
                {
                    ActiveForm.Enabled = true;
                }               
        }

        private void btn_Bancos_Click_1(object sender, EventArgs e)
        {
        
          FormEscolherBanco frm = new FormEscolherBanco {Owner = this};
          frm.ShowDialog();

        }


        private void btn_InserirPagto_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
        //  data_LoginTextBox.Text = Data_Agora.ToShortDateString();
        //  login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            btn_salvar.Enabled = true;
            btn_Pagar.Enabled = true;
            btn_salvar.BackColor = Color.DarkOrange;
            btn_Pagar.BackColor = Color.Coral;
            btn_Pagar.ForeColor = Color.Black;
            string sql = "SELECT MAX(Cod_Base_Titulos_Pagos) FROM Base_Titulos_Pagos";
            if (data_PagamentoDateTimePicker1.Text != "" && banco_DebitadoTextBox1.Text != "" && numero_ChequeTextBox1.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Base_Titulos_Pagos(Data_Pagamento, Total_Pago, Banco_Debitado, Numero_Cheque, Historico, Data_Login, Login_Name)"
                    + "VALUES(@Data_Pagamento, @Total_Pago, @Banco_Debitado, @Numero_Cheque, @Historico, @Data_Login, @Login_Name)", conn);
                    conn.Open();
                    DateTime DataPagamento = Convert.ToDateTime(data_PagamentoDateTimePicker1.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Data_Pagamento", DataPagamento);
                    decimal TotalPago = Convert.ToDecimal(valor_PagoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Total_Pago", TotalPago);
                    Int32 BancoDebitado = Convert.ToInt32(banco_DebitadoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Banco_Debitado", BancoDebitado);
                    String NumeroCheque = Convert.ToString(numero_ChequeTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Numero_Cheque", NumeroCheque);
                    String Historico = Convert.ToString(historicoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Historico", Historico);
                    DateTime Data_Agora = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Data_Login", Data_Agora);
                    String LoginName = Login.DadosGerais.Loginusuario;
                    cmd.Parameters.AddWithValue("@Login_Name", LoginName);
                    Int32 result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Inicie a Seleção de Títulos para Pagamentos! " + result.ToString() + "Cheque Inserido!");
                    cod_Base_Titulos_PagosTextBox1.Refresh();
         //         Here I select the Last ID from the table tha was Inserted above and pass to the textboxes.
                    SqlCommand command = new SqlCommand(sql, conn);
                    var UltimoID = command.ExecuteScalar();
                    int LastID = Convert.ToInt32(UltimoID);
                    cod_Base_Titulos_PagosTextBox.Text = Convert.ToString(LastID);
                    cod_Base_Titulos_PagosTextBox1.Text = Convert.ToString(LastID);
                    cod_Base_Titulos_PagosTextBox.Refresh();
                    numero_Parcelas_a_PagarDataGridView.Enabled = true;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao Inserir Pagamento! " + Ex.Message);
                }
                finally
                {
                    conn.Close();
                    btn_fechar.Enabled = true;
                    btn_InserirPagto.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Informe todos os Dados necessários para incluir o Pagamento do Título!");
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            numero_Parcelas_a_PagarDataGridView.Enabled = true;
            cod_Base_Titulos_PagosTextBox1.Enabled = false;
            data_PagamentoDateTimePicker1.Enabled = true;
            data_PagamentoDateTimePicker1.CustomFormat = "   ";
            valor_PagoTextBox1.Enabled = true;
            banco_DebitadoTextBox1.Enabled = true;
            historicoTextBox1.Enabled = true;
            numero_ChequeTextBox1.Enabled = true;
            cod_Base_Titulos_PagosTextBox1.Text = string.Empty;
            valor_PagoTextBox1.Text = "0,00";
            banco_DebitadoTextBox1.Text = string.Empty;
            historicoTextBox1.Text = string.Empty;
            numero_ChequeTextBox1.Text = string.Empty;
            login_NameTextBox.Text = string.Empty;
            data_LoginTextBox.Text = string.Empty;
            btn_InserirPagto.Enabled = true;
        }

        private void data_PagamentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            data_PagamentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void data_PagamentoDateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                data_PagamentoDateTimePicker1.CustomFormat = "   ";
            }
        }

        private void data_PagamentoDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data_PagamentoDateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

       

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            decimal valorpago = 0;
            BuscarNumeroParcelasTitulo();
            string numeroparcelaDGV = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[2].Value.ToString();
            numeroparcelaDGVInt = Convert.ToInt32(numeroparcelaDGV);
          
            if(cod_Titulo_a_PagarTextBox.Text == "")
            {
                MessageBox.Show("Selecione uma Parcela para pagamento! É necessário preencher as Informações do Título!");
            }
            else
            {
                if (MessageBox.Show("Adiciona este Título para Pagamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        pagamento = Convert.ToDecimal(valor_PagoTextBox.Text);
                        Total = Total + pagamento;
                        textBoxTotal.Text = Convert.ToString(pagamento);
                        //   FAZER O INSERT DOS NOVOS CAMPOS NA TABELA - INCLUSIVE NO SELECT 
                        cmd = new SqlCommand("INSERT INTO Base_Parcelas_Pagas(Cod_Base_Titulos_Pagos, Cod_Titulo_a_Pagar, Cod_Numero_Parc_a_Pagar, Cod_Fornecedor, Numero_Documento, Numero_Parcela, Valor_Titulo, Data_Documento, Data_Pagamento, Data_Venc_Parcela, Cod_Centro_Custos, Cod_Despesa, Valor_Pago_a_Vista,  Valor_Pago, Numero_banco, Numero_cheque, Acrescimos, Descontos, Saldo, StatusTitulo, Historico, Historico_Titulo)"
                                            + "VALUES(@Cod_Base_Titulos_Pagos, @Cod_Titulo_a_Pagar, @Cod_Numero_Parc_a_Pagar, @Cod_Fornecedor, @Numero_Documento, @Numero_Parcela, @Valor_Titulo, @Data_Documento, @Data_Pagamento, @Data_Venc_Parcela, @Cod_Centro_Custos, @Cod_Despesa, @Valor_Pago_a_Vista,  @Valor_Pago, @Numero_banco, @Numero_cheque, @Acrescimos, @Descontos, @Saldo, @StatusTitulo, @Historico, @Historico_Titulo)", conn);
                        conn.Open();
                        Int32 UltimoID = Convert.ToInt32(cod_Base_Titulos_PagosTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Base_Titulos_Pagos", UltimoID);
                        Int32 CodTituloaPagar = Convert.ToInt32(cod_Titulo_a_PagarTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Titulo_a_Pagar", CodTituloaPagar);
                        Int32 CodNumeroParcelaaPagar = Convert.ToInt32(cod_Numero_Parcela_a_PagarTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Numero_Parc_a_Pagar", CodNumeroParcelaaPagar);
                        Int32 CodFornecedor = Convert.ToInt32(Cod_Fornecedor.Text);
                        cmd.Parameters.AddWithValue("@Cod_Fornecedor", CodFornecedor);
                        string NumeroDocumento = Numero_NF.Text.ToString();
                        cmd.Parameters.AddWithValue("@Numero_Documento", NumeroDocumento);
                        Int32 NumeroParcela = Convert.ToInt32(Numero_Parcela.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcela", NumeroParcela);
                        decimal ValorTitulo = Convert.ToDecimal(Valor_Titulo.Text);
                        cmd.Parameters.AddWithValue("@Valor_Titulo", ValorTitulo);
                        DateTime DataDocumento = Convert.ToDateTime(DataNF.Text);
                        cmd.Parameters.AddWithValue("@Data_Documento", DataDocumento);
                        DateTime DataPagamento = Convert.ToDateTime(data_PagamentoDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@Data_Pagamento", DataPagamento);
                        DateTime DataVencParcela = Convert.ToDateTime(vencimento_Parcela.Text);
                        cmd.Parameters.AddWithValue("@Data_Venc_Parcela", DataVencParcela);
                        Int32 CodCentroCustos = Convert.ToInt32(CentroCustosTextbox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Centro_Custos", CodCentroCustos);
                        Int32 CodDespesa = Convert.ToInt32(CodDespesaTextbox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Despesa", CodDespesa);
                        decimal ValorPagoaVista = Convert.ToDecimal(valor_pago_a_vista.Text);
                        cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", ValorPagoaVista);
                        decimal ValorPago = Convert.ToDecimal(valor_PagoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_Pago", ValorPago);
                        Int32 NumeroBanco = Convert.ToInt32(banco_DebitadoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Numero_banco", NumeroBanco);
                        string NumeroCheque = numero_ChequeTextBox.Text.ToString();
                        cmd.Parameters.AddWithValue("@Numero_cheque", NumeroCheque);
                        decimal Acrescimos = Convert.ToDecimal(acrescimosTextBox.Text);
                        cmd.Parameters.AddWithValue("@Acrescimos", Acrescimos);
                        decimal Descontos = Convert.ToDecimal(descontosTextBox.Text);
                        cmd.Parameters.AddWithValue("@Descontos", Descontos);
                        decimal Saldo = Convert.ToDecimal(saldoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Saldo", Saldo);
                        Int32 StatusTitulo = Convert.ToInt32(cod_Status_TituloTextBox.Text);
                        cmd.Parameters.AddWithValue("@StatusTitulo", StatusTitulo);
                        string historico = historicoTextBox.Text;
                        cmd.Parameters.AddWithValue("@Historico", historico);
                        string historicoTitulo = hitorico_titulo.Text;
                        cmd.Parameters.AddWithValue("@Historico_Titulo", historicoTitulo);
                        Int32 result = cmd.ExecuteNonQuery();
                        Total = Total + valorpago;
                        textBoxTotal.Text = Convert.ToString(Total);
                        this.base_Parcelas_PagasTableAdapter.Fill(this.base_Parcelas_PagasDGV.Base_Parcelas_Pagas);
                        MessageBox.Show("Dados do Título Inseridos com Sucesso na Base de Parcelas Pagas! " + result.ToString() + " Registro Inserido!");
                        numero_Parcelas_a_PagarBindingSource.MoveFirst();
                        btn_Pagar.Enabled = false;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! Falha ao Tentar Inserir o Registro! " + Ex.Message);
                    }
                    finally
                    {
                        //  DELETAR DA BASE DE PARCELAS A PAGAR 0 REGISTRO INSERIDO ACIMA - DELETAR O TÍTULO SE FOR A ÚLTIMA PARCELA A PAGAR
                        int IDParcela = Convert.ToInt32(cod_Numero_Parcela_a_PagarTextBox.Text);
                        int IDTitulo = Convert.ToInt32(cod_Titulo_a_PagarTextBox.Text);
                        // VERIFICAR SE O NÚMERO DA PARCELA A PAGAR É DIFERENTE DO NÚMERO DE PARCELAS DO TÍTULO (SE FOR DIFERENTE - DELETAR apenas A PARCELA)
                        if (numeroparcelaDGVInt != numeroparcelastituloInt)
                        {
                            try
                            {
                                cmd = new SqlCommand("DELETE Numero_Parcelas_a_Pagar WHERE Cod_Numero_Parcelas_a_Pagar= @Cod_Numero_Parcelas_a_Pagar", conn);
                                cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_a_Pagar", IDParcela);
                                int result0 = cmd.ExecuteNonQuery();
                                MessageBox.Show("Parcela Excluida com Sucesso!" + result0.ToString() + " Registro Excluído!");
                                numero_Parcelas_a_PagarDataGridView.Rows.Remove(numero_Parcelas_a_PagarDataGridView.CurrentRow);
                                this.numero_Parcelas_a_PagarTableAdapter.Fill(this.numeroParcelasaPagarDGV.Numero_Parcelas_a_Pagar);
                                this.numero_Parcelas_a_PagarBindingSource.MoveLast();
                                this.numero_Parcelas_a_PagarDataGridView.RowsDefaultCellStyle.BackColor = Color.OrangeRed;
                                this.base_Parcelas_PagasDataGridView.DefaultCellStyle.BackColor = Color.Beige;
                            }
                            catch (Exception Ex)
                            {
                                MessageBox.Show("Erro! Falha ao Tentar Excluir o Registro! " + Ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                                btn_salvar.Enabled = true;
                            }
                        }
                        else
                        {
                            try
                            {
                                // DELETAR PARCELA E TÍTULO
                                cmd = new SqlCommand("DELETE Numero_Parcelas_a_Pagar WHERE Cod_Numero_Parcelas_a_Pagar= @Cod_Numero_Parcelas_a_Pagar", conn);
                                cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_a_Pagar", IDParcela);
                                int result0 = cmd.ExecuteNonQuery();
                                MessageBox.Show("Parcela Excluida com Sucesso!" + result0.ToString() + " Registro Excluído!");
                                numero_Parcelas_a_PagarDataGridView.Rows.Remove(numero_Parcelas_a_PagarDataGridView.CurrentRow);
                                this.numero_Parcelas_a_PagarTableAdapter.Fill(this.numeroParcelasaPagarDGV.Numero_Parcelas_a_Pagar);
                                this.numero_Parcelas_a_PagarBindingSource.MoveLast();
                                this.base_Parcelas_PagasDataGridView.BackgroundColor = Color.OrangeRed;

                                //       DELETAR TÍTULO
                                //       VERIFICAR SE O CÓDIGO DO TÍTULO É O MESMO DA PARCELA QUE ESTÁ SENDO EXCLUÍDA
                                if (IDTitulo == CodigoTituloPagar)
                                {
                                    cmd = new SqlCommand("DELETE Entrada_Titulos_a_Pagar WHERE Cod_Entrada_Titulos_a_Pagar = @Cod_Titulo_a_Pagar", conn);
                                    cmd.Parameters.AddWithValue("@Cod_Titulo_a_Pagar", IDTitulo);
                                    int result1 = cmd.ExecuteNonQuery();
                                    MessageBox.Show("Título Excluido com Sucesso!" + result1.ToString() + " Registro Excluído!");

                                }
                            }
                            catch (Exception Ex)
                            {
                                MessageBox.Show("Erro! Falha ao Tentar Excluir o Título! " + Ex.Message);
                            }

                            finally
                            {
                                conn.Close();
                                btn_salvar.Enabled = true;
                            }
                        }

                    }

                    numero_Parcelas_a_PagarDataGridView.Enabled = true;
                //  Limpar campos para fazer nova inserção
               //   cod_Base_Titulos_PagosTextBox.Text = string.Empty;
                    Cod_Fornecedor.Text = string.Empty;
                    Numero_NF.Text = string.Empty;
                    Valor_Titulo.Text = string.Empty;
                    valor_pago_a_vista.Text = string.Empty;
                    DataNF.Text = string.Empty;
                    Numero_Parcela.Text = string.Empty;
                    CodDespesaTextbox.Text = string.Empty;
                    CentroCustosTextbox.Text = string.Empty;
                    hitorico_titulo.Text = string.Empty;
                    vencimento_Parcela.Text = string.Empty;
                    cod_Titulo_a_PagarTextBox.Text = string.Empty;
                    cod_Numero_Parcela_a_PagarTextBox.Text = string.Empty;
                    data_PagamentoDateTimePicker.CustomFormat = "   ";
                    data_PagamentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
                    data_PagamentoDateTimePicker.CustomFormat = null;
                    valorparcelatextbox.Text = string.Empty;
                    valorparcelatextbox.Text = " ";
                    valor_PagoTextBox.Text = string.Empty;
                    banco_DebitadoTextBox.Text = string.Empty;
                    numero_ChequeTextBox.Text = string.Empty;
                    acrescimosTextBox.Text = string.Empty;
                    descontosTextBox.Text = string.Empty;
                    saldoTextBox.Text = string.Empty;
                    cod_Status_TituloTextBox.Text = string.Empty;
                    textBoxdescricaostatus.Text = string.Empty;
                    historicoTextBox.Text = string.Empty;
                    decimal valorparcela = 0;
                    decimal acrescimos = 0;
                    decimal descontos = 0;
                    decimal saldo = 0;
                    this.base_Parcelas_PagasTableAdapter.Fill(this.base_Parcelas_PagasDGV.Base_Parcelas_Pagas);
                    this.base_Parcelas_PagasBindingSource.MoveLast();
                    this.numero_Parcelas_a_PagarBindingSource.MoveFirst();


                }

            }
        }

      

        private void saldoTextBox_TextChanged(object sender, EventArgs e)
         {
             if (saldo >= 0)
             {
                
                    cod_Status_TituloTextBox.Text = "2".ToString();
                    textBoxdescricaostatus.Text = "Quitado";
                
            }
             if(saldo < 0)
            {
                cod_Status_TituloTextBox.Text = "3".ToString();
                textBoxdescricaostatus.Text = "Saldo Pendente";
                string saldotexto = Convert.ToString(saldo);
                saldoTextBox.Text = (saldotexto);
            }
        }

        private void acrescimosTextBox_Leave(object sender, EventArgs e)
        {
            valorparcelaPublic = Convert.ToDecimal(valorparcelatextbox.Text);
            decimal valorparcela = 0;
            decimal valorpago = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;
            decimal valorTotalPago = 0;
            Decimal.TryParse(valor_PagoTextBox.Text, out valorpago);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            Decimal.TryParse(valorparcelatextbox.Text, out valorparcela);
            valorparcela = valorparcelaPublic;
            valorTotalPago = ((valorpago + acrescimos)-(descontos));
            valor_PagoTextBox.Text = Convert.ToString(valorTotalPago);
            saldo = ((valorTotalPago) - (valorparcela - descontos));
            saldoTextBox.Text = saldo.ToString();
        }

        private void descontosTextBox_Leave(object sender, EventArgs e)
        {
            valorparcelatextbox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[4].Value.ToString();
            valorparcelaPublic = Convert.ToDecimal(valorparcelatextbox.Text);
            decimal valorparcela = 0;
            decimal valorpago = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;
            Decimal.TryParse(valor_PagoTextBox.Text, out valorpago);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            Decimal.TryParse(valorparcelatextbox.Text, out valorparcela);
            valorparcela = valorparcelaPublic;
            decimal valorTotalPago = Convert.ToDecimal(valor_PagoTextBox.Text);
            valorTotalPago = (valorTotalPago - descontos);
            valor_PagoTextBox.Text = Convert.ToString(valorTotalPago);
            saldo = ((valorTotalPago) - (valorparcela - descontos));
            saldoTextBox.Text = saldo.ToString();

            if (saldo >= 0)
            {

                cod_Status_TituloTextBox.Text = "2".ToString();
                textBoxdescricaostatus.Text = "Quitado";

            }
            if (saldo < 0)
            {
                cod_Status_TituloTextBox.Text = "3".ToString();
                textBoxdescricaostatus.Text = "Saldo Pendente";
                string saldotexto = Convert.ToString(saldo);
                saldoTextBox.Text = (saldotexto);
            }

        }

        private void valor_PagoTextBox_Leave(object sender, EventArgs e)
        {
         // valorparcelatextbox.Text = numero_Parcelas_a_PagarDataGridView.CurrentRow.Cells[4].Value.ToString();
            valorparcelaPublic = Convert.ToDecimal(valorparcelatextbox.Text);
            decimal valorparcela = 0;
            decimal valorpago = 0;
            decimal acrescimos = 0;
            decimal descontos = 0;
            decimal saldo = 0;
            decimal valorTotalPago = 0;
            Decimal.TryParse(valor_PagoTextBox.Text, out valorpago);
            Decimal.TryParse(acrescimosTextBox.Text, out acrescimos);
            Decimal.TryParse(descontosTextBox.Text, out descontos);
            Decimal.TryParse(valorparcelatextbox.Text, out valorparcela);
            valorparcela = valorparcelaPublic;
            valorTotalPago = ((valorpago + acrescimos)-(descontos));
            valor_PagoTextBox.Text = Convert.ToString(valorTotalPago);
            saldo = ((valorTotalPago) - (valorparcela));
            saldoTextBox.Text = saldo.ToString();

            
                if (saldo >= 0)
                {

                    cod_Status_TituloTextBox.Text = "2".ToString();
                    textBoxdescricaostatus.Text = "Quitado";

                }
                if (saldo < 0)
                {
                    cod_Status_TituloTextBox.Text = "3".ToString();
                    textBoxdescricaostatus.Text = "Saldo Pendente";
                    string saldotexto = Convert.ToString(saldo);
                    saldoTextBox.Text = (saldotexto);
                }

            }
    }
}
