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
        decimal valorMovimento = 0;
        decimal saldoAtual = 0;
        decimal Total = 0;
        public decimal saldoanterior = 0;
        public decimal saldo = 0;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        Int32 LastID = 0;
        Int32 ID = 0;
        Int32 IDLancamento;


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

            da.Fill(dtResultado);





        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lancamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lancamentos_Movimentos.Lancamentos' table. You can move, or remove it, as needed.
            this.lancamentosTableAdapter.Fill(this.lancamentos_Movimentos.Lancamentos);

            lancamentosDataGridView.Enabled = true;
            numero_ContaTextBox.Enabled = false;
       //   data_LancamentoDateTimePicker.CustomFormat = "   ";
            data_LancamentoDateTimePicker.Enabled = false;
            numero_ChequeTextBox.Enabled = false;
            descricao_OperacaoTextBox.Enabled = false;
            valor_MovimentoTextBox.Enabled = false;
            saldo_AnteriorTextBox.Enabled = false;
            saldoTextBox.Enabled = false;
            btn_novo.Enabled = true;
            btn_operacao.Enabled = false;
            btn_Banco.Enabled = false;
            btn_base_Titulos_Pagos.Enabled = false;
            btn_Base_Titulos_Recebidos.Enabled = false;
            btn_salvar.Enabled = false;
            btn_Update.Enabled = false;
            btn_editar.Enabled = true;
            btn_proximo.Enabled = true;
            btn_Anterior.Enabled = true;
            btn_fechar.Enabled = true;
            btn_novo.Focus();
            BuscarNomeBanco();
            BuscarNomeOperacao();
        }

        void BuscarDadosConta()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select Numero_Conta from Bancos where Cod_Banco='{0}'", textBoxCod_banco.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    numero_ContaTextBox.Text = reader["Numero_Conta"].ToString();
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao buscar dados do Banco!" + Ex.Message);
            }
        }

        void BuscarSaldoConta()
        {
            try
            {
              
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select Saldo from Lancamentos where Cod_Banco='{0}'", textBoxCod_banco.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    saldoanterior = Convert.ToDecimal(reader["Saldo"]);
                    saldo_AnteriorTextBox.Text = reader["Saldo"].ToString();
                }

                sqlConnection.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao buscar Saldo do Banco!" + Ex.Message);
            }
        }

        void BuscarNomeBanco()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select Nome_Banco from Bancos where Cod_Banco='{0}'", textBoxCod_banco.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    textBoxnomeBanco.Text = reader["Nome_Banco"].ToString();
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao buscar dados do Banco!" + Ex.Message);
            }


        }


        void BuscarNomeOperacao()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select Descricao_Op from Operacao where Cod_Operacao ='{0}'", textBoxCodOperacao.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    textBox_desc_operacao.Text = reader["Descricao_Op"].ToString();
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao buscar dados do Banco!" + Ex.Message);
            }

        }

        void BuscarUltimoID()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = "SELECT MAX(Cod_Lancamento) FROM Lancamentos";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                var MAXID = command.ExecuteScalar();
                int UltimoID = Convert.ToInt32(MAXID);
                cod_LancamentoTextBox.Text = Convert.ToString(UltimoID);
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao buscar Último ID!" + Ex.Message);
            }

        }

        void BuscarUlitmoIDDataContext()
        {

            var ultimoID = DataContextFactory.DataContext.Lancamentos.Max(x => x.Cod_Lancamento);
            cod_LancamentoTextBox.Text = Convert.ToString(ultimoID);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
            txt_datalogin.Text = DateTime.Now.ToString();

            // FAZER O INSERT NA TABELA COM OS CAMPOS DOS TEXTBOX
            if( cod_LancamentoTextBox.Text != null && textBoxCodOperacao.Text !=null && data_LancamentoDateTimePicker.Text !=null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Lancamentos(Cod_Operacao, Cod_Base_Tit_Pagos, Cod_Base_Tit_Recebidos, Cod_Banco, Numero_Conta, Numero_Chque, Data_Lancamento, Descricao_Operacao, Recebimento_Titulos, Pagamento_Titulos, Valor_Movimento, Saldo_Anterior, Saldo, Data_Login, Login_Name)"
                        + "VALUES(@Cod_Operacao, @Cod_Base_Tit_Pagos, @Cod_Base_Tit_Recebidos, @Cod_Banco, @Numero_Conta, @Numero_Chque, @Data_Lancamento, @Descricao_Operacao, @Recebimento_Titulos, @Pagamento_Titulos, @Valor_Movimento, @Saldo_Anterior, @Saldo, @Data_Login, @Login_Name)", conn);
                    conn.Open();
                    Int32 CodOperacao = Convert.ToInt32(textBoxCodOperacao.Text);
                    cmd.Parameters.AddWithValue("@Cod_Operacao", CodOperacao);
                    Int32 CodBaseTitPagos = Convert.ToInt32(cod_Tit_Pagos.Text);
                    cmd.Parameters.AddWithValue("@Cod_Base_Tit_Pagos", CodBaseTitPagos);
                    Int32 CodBaseTitRecebidos = Convert.ToInt32(cod_Titulos_recebidos.Text);
                    cmd.Parameters.AddWithValue("@Cod_Base_Tit_Recebidos", CodBaseTitRecebidos);
                    Int32 Codbanco = Convert.ToInt32(textBoxCod_banco.Text);
                    cmd.Parameters.AddWithValue("@Cod_Banco", Codbanco);
                    string NumeroConta = Convert.ToString(numero_ContaTextBox.Text);
                    cmd.Parameters.AddWithValue("@Numero_Conta", NumeroConta);
                    string numerocheque = Convert.ToString(numero_ChequeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Numero_Chque", numerocheque);
                    DateTime datalancamento = Convert.ToDateTime(data_LancamentoDateTimePicker.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Data_Lancamento", datalancamento);
                    string descricaooperacao = Convert.ToString(descricao_OperacaoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Descricao_Operacao", descricaooperacao);
                    decimal recebimentotitulos = Convert.ToDecimal(Valor_Tit_Recebidos.Text);
                    cmd.Parameters.AddWithValue("@Recebimento_Titulos", recebimentotitulos);
                    decimal pagamentotitulos = Convert.ToDecimal(Valor_Tit_Pagos.Text);
                    cmd.Parameters.AddWithValue("@Pagamento_Titulos", pagamentotitulos);
                    decimal valormovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Valor_Movimento", valormovimento);
                    decimal saldoanterior = Convert.ToDecimal(saldo_AnteriorTextBox.Text);
                    cmd.Parameters.AddWithValue("@Saldo_Anterior", saldoanterior);
                    decimal Saldo = Convert.ToDecimal(saldoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Saldo", Saldo);
                    DateTime datalogin = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Data_Login", datalogin);
                    string loginname = Login.DadosGerais.Loginusuario;
                    cmd.Parameters.AddWithValue("@Login_Name", loginname);
                    int result01 = cmd.ExecuteNonQuery();
                    //    EXECUTA A RECUPERAÇÃO DO ULTIMO ID NA TABELA DE LANÇAMENTO
                    BuscarUltimoID();
                    
                    MessageBox.Show("Lançamento Realizao com Sucesso!" + result01.ToString() + "Registro Lançado!");
             //     UPDATE DO SALDO NA TABELA BANCO
                    Int32 IDBanco = Convert.ToInt32(textBoxCod_banco.Text);
                    cmd = new SqlCommand("UPDATE Bancos SET Saldo=@Saldo, Data_Login=@Data_Login, Login_Name=@Login_Name  WHERE Cod_Banco=@Cod_Banco", conn);
                    cmd.Parameters.AddWithValue("@Cod_Banco", IDBanco);
                    cmd.Parameters.AddWithValue("@Saldo", Saldo);
                    DateTime datalogin2 = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Data_Login", datalogin2);
                    string loginname2 = Login.DadosGerais.Loginusuario;
                    cmd.Parameters.AddWithValue("@Login_Name", loginname2);
                    int result02 = cmd.ExecuteNonQuery();
                    MessageBox.Show("Saldo Atualizado com Sucesso!" + result02.ToString() + "Registro Atualizado!");
                    cod_LancamentoTextBox.Refresh();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao Inserir Lançamento! " + Ex.Message);

                }
                finally
                {
                    conn.Close();
                    btn_fechar.Enabled = true;
                    btn_salvar.Enabled = false;
                    this.lancamentosTableAdapter.Fill(this.lancamentos_Movimentos.Lancamentos);
                    lancamentosBindingSource.MoveLast();
                    btn_salvar.BackColor = Color.LightGray;
                    btn_salvar.ForeColor = Color.Black;
                    btn_novo.Enabled = true;
                    btn_Base_Titulos_Recebidos.BackColor = Color.Gainsboro;
                    btn_Base_Titulos_Recebidos.ForeColor = Color.Black;
                    btn_Base_Titulos_Recebidos.Enabled = false;
                }
                // LIMPAR TEXTBOXES
                cod_LancamentoTextBox.Text = string.Empty;
                textBoxCodOperacao.Text = string.Empty;
                textBox_desc_operacao.Text = string.Empty;
                data_LancamentoDateTimePicker.CustomFormat = "   ";
                textBoxCod_banco.Text = string.Empty;
                textBoxnomeBanco.Text = string.Empty;
                numero_ContaTextBox.Text = string.Empty;
                numero_ChequeTextBox.Text = string.Empty;
                cod_Titulos_recebidos.Text = string.Empty;
                cod_Tit_Pagos.Text = string.Empty;
                Valor_Tit_Recebidos.Text = string.Empty;
                Valor_Tit_Pagos.Text = string.Empty;
                valor_MovimentoTextBox.Text = string.Empty;
                saldo_AnteriorTextBox.Text = string.Empty;
                saldoTextBox.Text = string.Empty;
                descricao_OperacaoTextBox.Text = string.Empty;
                login_NameTextBox.Text = string.Empty;
                txt_datalogin.Text = string.Empty;
                numero_ContaTextBox.Enabled = false;
                data_LancamentoDateTimePicker.Enabled = false;
                numero_ChequeTextBox.Enabled = false;
                descricao_OperacaoTextBox.Enabled = false;
                valor_MovimentoTextBox.Enabled = false;
                saldo_AnteriorTextBox.Enabled = false;
                saldoTextBox.Enabled = false;
                lancamentosDataGridView.Enabled = true;
                btn_Banco.BackColor = Color.Gainsboro;
                btn_Banco.ForeColor = Color.Black;
                btn_Banco.Enabled = false;
            }
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            data_LancamentoDateTimePicker.Enabled = true;
            descricao_OperacaoTextBox.Enabled = true;
            valor_MovimentoTextBox.Enabled = true;
            btn_salvar.Enabled = false;
            btn_Update.Enabled = true;
            btn_Update.Focus();
            btn_proximo.Enabled = false;
            btn_novo.Enabled = false;
            btn_Anterior.Enabled = false;
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            this.lancamentosBindingSource.MoveNext();
            BuscarNomeOperacao();
            BuscarNomeBanco();
            descricao_OperacaoTextBox.Enabled = false;
        //  BuscarDadosConta();
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            this.lancamentosBindingSource.MovePrevious();
            BuscarNomeOperacao();
            BuscarNomeBanco();
            descricao_OperacaoTextBox.Enabled = false;
            //  BuscarDadosConta();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //     Limpar Campos TextBox
            cod_LancamentoTextBox.Text = string.Empty;
            textBoxCodOperacao.Text = string.Empty;
            textBox_desc_operacao.Text = string.Empty;
            data_LancamentoDateTimePicker.CustomFormat = "   ";
            textBoxCod_banco.Text = string.Empty;
            textBoxnomeBanco.Text = string.Empty;
            numero_ContaTextBox.Text = string.Empty;
            numero_ChequeTextBox.Text = string.Empty;
            cod_Titulos_recebidos.Text = string.Empty;
            cod_Tit_Pagos.Text = string.Empty;
            Valor_Tit_Recebidos.Text = string.Empty;
            Valor_Tit_Pagos.Text = string.Empty;
            valor_MovimentoTextBox.Text = string.Empty;
            saldo_AnteriorTextBox.Text = string.Empty;
            saldoTextBox.Text = string.Empty;
            descricao_OperacaoTextBox.Text = string.Empty;
            txt_datalogin.Text = string.Empty;
            login_NameTextBox.Text = string.Empty;
            //  Habilitar Campos textbox
            numero_ContaTextBox.Enabled = true;
            data_LancamentoDateTimePicker.Enabled = true;
            data_LancamentoDateTimePicker.CustomFormat = "   ";
            btn_novo.Enabled = false;
            btn_operacao.Enabled = true;
            btn_operacao.Focus();
            btn_operacao.BackColor = Color.Orange;
            btn_operacao.ForeColor = Color.Navy;

        }

        private void btn_operacao_Click(object sender, EventArgs e)
        {
            Tela_Operacao frm = new Tela_Operacao() { Owner = this };
            frm.Show();
            btn_operacao.BackColor = Color.Gainsboro;
            btn_operacao.ForeColor = Color.Black;

        }

        private void data_LancamentoDateTimePicker_Leave(object sender, EventArgs e)
        {

            if (textBoxCodOperacao.Text == "1")
            {
                
                btn_Base_Titulos_Recebidos.Enabled = true;
                btn_Base_Titulos_Recebidos.Focus();
                btn_Base_Titulos_Recebidos.BackColor = Color.Orange;
                btn_Base_Titulos_Recebidos.ForeColor = Color.Navy;
                descricao_OperacaoTextBox.Enabled = true;
                btn_operacao.Enabled = false;
                cod_Tit_Pagos.Text = "000";
                Valor_Tit_Pagos.Text = "0,00";
                valor_MovimentoTextBox.Enabled = true;
              

            }
            if (textBoxCodOperacao.Text == "2")
            {
                btn_base_Titulos_Pagos.Enabled = true;
                btn_base_Titulos_Pagos.BackColor = Color.Orange;
                btn_base_Titulos_Pagos.ForeColor = Color.Navy;
                btn_base_Titulos_Pagos.Focus();
                valor_MovimentoTextBox.Enabled = false;
                valor_MovimentoTextBox.ReadOnly = true;
                descricao_OperacaoTextBox.Enabled = true;
                btn_operacao.Enabled = false;
                cod_Titulos_recebidos.Text = "000";
                Valor_Tit_Recebidos.Text = "0,00";
              

            }
            if (textBoxCodOperacao.Text == "3" )
            {
                btn_Banco.Enabled = true;
                btn_Banco.BackColor = Color.Orange;
                btn_Banco.ForeColor = Color.Navy;
                btn_Banco.Focus();
                btn_operacao.Enabled = false;
                numero_ChequeTextBox.Enabled = true;
                valor_MovimentoTextBox.Enabled = true;
                descricao_OperacaoTextBox.Enabled = true;
                cod_Titulos_recebidos.Text = "000";
                cod_Tit_Pagos.Text = "000";
                Valor_Tit_Recebidos.Text = "0,00";
                Valor_Tit_Pagos.Text = "0,00";

            }
            if( textBoxCodOperacao.Text == "4")
            {
                btn_Banco.Enabled = true;
                btn_Banco.BackColor = Color.Orange;
                btn_Banco.ForeColor = Color.Navy;
                btn_Banco.Focus();
                btn_operacao.Enabled = false;
                numero_ChequeTextBox.Enabled = true;
                valor_MovimentoTextBox.Enabled = true;
                descricao_OperacaoTextBox.Enabled = true;
                cod_Titulos_recebidos.Text = "000";
                cod_Tit_Pagos.Text = "000";
                Valor_Tit_Recebidos.Text = "0,00";
                Valor_Tit_Pagos.Text = "0,00";


            }

            if (textBoxCodOperacao.Text == "5")
            {
                btn_Banco.Enabled = true;
                btn_Banco.BackColor = Color.Orange;
                btn_Banco.ForeColor = Color.Navy;
                btn_Banco.Focus();
                btn_operacao.Enabled = false;
                valor_MovimentoTextBox.Enabled = true;
                descricao_OperacaoTextBox.Enabled = true;
                numero_ChequeTextBox.Enabled = false;
                btn_salvar.Enabled = true;
                numero_ChequeTextBox.Text = "   ";
                cod_Titulos_recebidos.Text = "000";
                cod_Tit_Pagos.Text = "000";
                Valor_Tit_Recebidos.Text = "0,00";
                Valor_Tit_Pagos.Text = "0,00";

            }
            if (textBoxCodOperacao.Text == "6")
            {
                btn_Banco.Enabled = true;
                btn_Banco.BackColor = Color.Orange;
                btn_Banco.ForeColor = Color.Navy;
                btn_Banco.Focus();
                btn_operacao.Enabled = false;
                valor_MovimentoTextBox.Enabled = true;
                descricao_OperacaoTextBox.Enabled = true;
                numero_ChequeTextBox.Enabled = false;
                btn_salvar.Enabled = true;
                numero_ChequeTextBox.Text = "   ";
                cod_Titulos_recebidos.Text = "000";
                cod_Tit_Pagos.Text = "000";
                Valor_Tit_Recebidos.Text = "0,00";
                Valor_Tit_Pagos.Text = "0,00";

            }
        }

        private void data_LancamentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            data_LancamentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void data_LancamentoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                data_LancamentoDateTimePicker.CustomFormat = "   ";
            }
        }

        private void btn_Banco_Click(object sender, EventArgs e)
        {
           TelaBancos frm = new TelaBancos {Owner = this};
            frm.ShowDialog();
            numero_ContaTextBox.Focus();
        }

        private void numero_ContaTextBox_Enter(object sender, EventArgs e)
        {
            BuscarDadosConta();
            BuscarNomeBanco();
            BuscarSaldoConta();
        }

        

        private void lancamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lancamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lancamentos_Movimentos);

        }

        private void btn_base_Titulos_Pagos_Click(object sender, EventArgs e)
        {
            TelaBaseTitulosPagos frm = new TelaBaseTitulosPagos() { Owner = this };
            frm.Show();
        }

        private void btn_Base_Titulos_Recebidos_Click(object sender, EventArgs e)
        {
            TelaBaseTitulosRecebidos frm = new TelaBaseTitulosRecebidos() { Owner = this };
            frm.Show();
        }

        private void Valor_Tit_Recebidos_Leave(object sender, EventArgs e)
        {
            Decimal.TryParse(valor_MovimentoTextBox.Text, out valorMovimento);
            BuscarDadosConta();
            BuscarNomeBanco();
            BuscarSaldoConta();
            btn_Base_Titulos_Recebidos.Enabled = false;
            valor_MovimentoTextBox.Enabled = true;
            valor_MovimentoTextBox.Text = Valor_Tit_Recebidos.Text;
            valorMovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
            saldo_AnteriorTextBox.Text = Convert.ToString(saldoanterior);
            saldoAtual = (saldoanterior + valorMovimento);
            saldoTextBox.Text = Convert.ToString(saldoAtual);
            descricao_OperacaoTextBox.Enabled = true;
            descricao_OperacaoTextBox.Focus();
            btn_salvar.Enabled = true;
            btn_salvar.BackColor = Color.Orange;
            btn_salvar.ForeColor = Color.DarkBlue;
        }

        private void Valor_Tit_Pagos_Leave(object sender, EventArgs e)
        {
            BuscarDadosConta();
            BuscarNomeBanco();
            BuscarSaldoConta();
            btn_base_Titulos_Pagos.Enabled = false;
            valor_MovimentoTextBox.Enabled = true;
            valor_MovimentoTextBox.Text = Valor_Tit_Pagos.Text;
            valorMovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
            saldo_AnteriorTextBox.Text = Convert.ToString(saldoanterior);
            saldoAtual = (saldoanterior - valorMovimento);
            saldoTextBox.Text = Convert.ToString(saldoAtual);
            descricao_OperacaoTextBox.Enabled = true;
            descricao_OperacaoTextBox.Focus();
            btn_salvar.Enabled = true;
            btn_salvar.BackColor = Color.Orange;
            btn_salvar.ForeColor = Color.DarkBlue;
            btn_base_Titulos_Pagos.Enabled = false;
            btn_base_Titulos_Pagos.BackColor = Color.Gainsboro;
            btn_base_Titulos_Pagos.ForeColor = Color.Black;
        }

        private void cod_Titulos_recebidos_TextChanged(object sender, EventArgs e)
        {
            btn_Base_Titulos_Recebidos.Enabled = false;
            saldo_AnteriorTextBox.Enabled = false;
            saldoTextBox.Enabled = false;
            descricao_OperacaoTextBox.Enabled = true;
            
        }

        private void descricao_OperacaoTextBox_Enter(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            btn_editar.Enabled = false;
            btn_Update.Enabled = true;
            
        }

        private void data_LancamentoDateTimePicker_Enter(object sender, EventArgs e)
        {
            data_LancamentoDateTimePicker.AllowDrop = true;
     
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (cod_LancamentoTextBox.Text != null && textBoxCodOperacao.Text != null && data_LancamentoDateTimePicker.Text != null)
            {
                ID = Convert.ToInt32(cod_LancamentoTextBox.Text);
                IDLancamento = ID;
                try
                {
                    cmd = new SqlCommand("UPDATE Lancamentos SET  Descricao_Operacao=@Descricao_Operacao,  Data_Login=@Data_Login, Login_Name=@Login_Name WHERE Cod_Lancamento=@Cod_Lancamento", conn);
                    conn.Open();
                  
                    cmd.Parameters.AddWithValue("@Cod_Lancamento", IDLancamento);
             
                    string descricaooperacao = Convert.ToString(descricao_OperacaoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Descricao_Operacao", descricaooperacao);
            
                    DateTime datalogin = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Data_Login", datalogin);
                    string loginname = Login.DadosGerais.Loginusuario;
                    cmd.Parameters.AddWithValue("@Login_Name", loginname);
                    int result01 = cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados do Lançamento atualizados com Sucesso! " + result01.ToString()+ "Registro Atualizado");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao Inserir Lançamento! " + Ex.Message);

                }
                finally
                {
                    conn.Close();
                    btn_fechar.Enabled = true;
                    btn_Update.Enabled = false;
                    btn_editar.Enabled = false;
                    btn_salvar.Enabled = false;
                    descricao_OperacaoTextBox.Enabled = false;
                    descricao_OperacaoTextBox.ReadOnly = true;
                    data_LancamentoDateTimePicker.Enabled = false;
                    numero_ChequeTextBox.Enabled = false;
                    valor_MovimentoTextBox.Enabled = false;
                    btn_fechar.Focus();
                }


            }
        }

        private void descricao_OperacaoTextBox_Leave(object sender, EventArgs e)
        {

            if (textBoxCodOperacao.Text == "3")
            {
                valorMovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
                saldo_AnteriorTextBox.Text = Convert.ToString(saldoanterior);
                saldoAtual = (saldoanterior - valorMovimento);
                saldoTextBox.Text = Convert.ToString(saldoAtual);
                btn_salvar.Enabled = true;
                btn_salvar.BackColor = Color.Orange;
                btn_salvar.ForeColor = Color.DarkBlue;

            }
            if (textBoxCodOperacao.Text == "4")
            {
                valorMovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
                saldo_AnteriorTextBox.Text = Convert.ToString(saldoanterior);
                saldoAtual = (saldoanterior + valorMovimento);
                saldoTextBox.Text = Convert.ToString(saldoAtual);
                btn_salvar.Enabled = true;
                btn_salvar.BackColor = Color.Orange;
                btn_salvar.ForeColor = Color.DarkBlue;

            }
            if (textBoxCodOperacao.Text == "5")
            {
                valorMovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
                saldo_AnteriorTextBox.Text = Convert.ToString(saldoanterior);
                saldoAtual = (saldoanterior - valorMovimento);
                saldoTextBox.Text = Convert.ToString(saldoAtual);
                btn_salvar.Enabled = true;
                btn_salvar.BackColor = Color.Orange;
                btn_salvar.ForeColor = Color.DarkBlue;
            }

            if (textBoxCodOperacao.Text == "6")
            {
                valorMovimento = Convert.ToDecimal(valor_MovimentoTextBox.Text);
                saldo_AnteriorTextBox.Text = Convert.ToString(saldoanterior);
                saldoAtual = (saldoanterior + valorMovimento);
                saldoTextBox.Text = Convert.ToString(saldoAtual);
                btn_salvar.Enabled = true;
                btn_salvar.BackColor = Color.Orange;
                btn_salvar.ForeColor = Color.DarkBlue;
            }
        }

       
    }
}
