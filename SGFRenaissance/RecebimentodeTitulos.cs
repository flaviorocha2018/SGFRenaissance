using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SGFRenaissance
{
    public partial class RecebimentodeTitulos : Form
    {
        DateTime Data_Agora = DateTime.Now;
        decimal Total;
        decimal Recebimento = 0;
        decimal Saldo = 0;
        decimal Acrescimos = 0;
        decimal Desconto = 0;
        decimal valorrecebido = 0;
        public decimal valorparcelaPublic = 0;
        public string NumeroParcelasTituloaReceber;
        public int numeroparcelastituloaReceberInt = 0;
        public int numeroparcelaDGVInt = 0;
        public int CodigoTituloaReceber = 0;
        public string Public_NumeroNF;


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        Int32 LastID = 0;
        Int32 ID = 0;


        public RecebimentodeTitulos()
        {
            InitializeComponent();
        }

        private void base_Titulos_RecebidosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.base_Titulos_RecebidosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseTitulosRecebidos);

        }

        private void RecebimentodeTitulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseParcelasRecebidasDGV.Base_Parcelas_Recebidas' table. You can move, or remove it, as needed.
            this.base_Parcelas_RecebidasTableAdapter.Fill(this.baseParcelasRecebidasDGV.Base_Parcelas_Recebidas);
            // TODO: This line of code loads data into the 'baseParcelasRecebidasDGV.Base_Parcelas_Recebidas' table. You can move, or remove it, as needed.
            this.base_Parcelas_RecebidasTableAdapter.Fill(this.baseParcelasRecebidasDGV.Base_Parcelas_Recebidas);
            // TODO: This line of code loads data into the 'numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber' table. You can move, or remove it, as needed.
            this.numero_Parcelas_a_ReceberTableAdapter.Fill(this.numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);
            // TODO: This line of code loads data into the 'baseTitulosRecebidos.Base_Titulos_Recebidos' table. You can move, or remove it, as needed.
            this.base_Titulos_RecebidosTableAdapter.Fill(this.baseTitulosRecebidos.Base_Titulos_Recebidos);
            this.numero_Parcelas_a_ReceberDataGridView.Enabled = false;
            btn_recebido.Enabled = false;
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_proximo.Enabled = false;
            btn_Anterior.Enabled = false;
            btn_Localizar.Enabled = false;
            btn_Bancos.Enabled = false;
            btn_Inserir_Recebimentos.Enabled = false;
            btn_novo.Enabled = true;
            btn_fechar.Enabled = true;
            data_RecebimentoDateTimePicker.Format = DateTimePickerFormat.Custom;
            data_RecebimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            data_RecebimentoDateTimePicker.Value.ToShortDateString();
            cod_Base_Titulos_a_RecebidosTextBox.Enabled = false;
            data_RecebimentoDateTimePicker.Enabled = false;
            historicoTextBox.Enabled = false;
            data_RecebimentoDateTimePicker.CustomFormat = "   ";
            data_RecebimentoDateTimePicker.Text = null;
            Valor_Pago_a_Vista.Enabled = false;
            data_Recebimento_NF.Enabled = false;
            Valor_recebido.Enabled = false;
            AcrescimosTextbox.Enabled = false;
            Descontotextbox.Enabled = false;
            historico_Titulo.Enabled = false;
            btn_novo.Focus();
            btn_novo.BackColor = Color.Gray;
            btn_novo.ForeColor = Color.DarkBlue;
            //  LIMPARA CAMPOS NO LOAD
            data_RecebimentoDateTimePicker.Enabled = false;
            historicoTextBox.Text = string.Empty;
            cod_Base_Titulos_a_RecebidosTextBox.Text = string.Empty;
            banco_CreditadoTextBox.Text = string.Empty;
            data_RecebimentoDateTimePicker.CustomFormat = "   ";
            total_RecebidoTextBox.Text = string.Empty;
            data_Recebimento_NF.Text = string.Empty;
            Valor_Pago_a_Vista.Text = string.Empty;
            Valor_recebido.Text = string.Empty;
            AcrescimosTextbox.Text = string.Empty;
            Descontotextbox.Text = string.Empty;
            historico_Titulo.Text = string.Empty;
            Cod_numero_parcela.Text = string.Empty;
            Cod_Receita.Text = string.Empty;
            Status_Titulo.Text = string.Empty;
            StatusDescricao.Text = string.Empty;
            historico_parcela.Text = string.Empty;
            Cod_Base_Tit_Recebidos.Text = string.Empty;
            data_LoginTextBox.Text = string.Empty;
            login_NameTextBox.Text = string.Empty;
            MessageBox.Show("Para Iniciar o Recebimento de Título Clicar em NOVO e Escolha o Banco!");
            btn_fechar.Focus();

        }

        // BUSCAR O ÚLTIMO ID CÓDIGO_BASE_TITULOS_RECEBIDOS DA TABELA Base_Titulos_Recebidos
        void SelecionarMaxID()
        {
            string sql = "SELECT MAX (Cod_Base_Titulos_a_Recebidos) FROM Base_Titulos_Recebidos";
            SqlCommand command = new SqlCommand(sql, conn);
            var UltimoID = command.ExecuteScalar();
            LastID = Convert.ToInt32(UltimoID);
            string LastIDTextbox = Convert.ToString(LastID);
            cod_Base_Titulos_a_RecebidosTextBox.Text = LastIDTextbox;
            Cod_Base_Tit_Recebidos.Text = LastIDTextbox;
        }
        // BUSCAR INFORMAÇÕES DO TÍTULO (NOTA FISCAL) E PASSAR PARA OS TEXTBOXES
        void buscar_dados_cliente()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Cod_Cliente from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Codigo_Cliente.Text = reader["Cod_Cliente"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar dados do Cliente!" + Ex.Message);
            }
        }

        void buscar_numero_NF()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Numero_NF from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Numero_NF.Text = reader["Numero_NF"].ToString();
                    Public_NumeroNF = Numero_NF.Text.ToString();
                    
                }

                sqlConnection.Close();


            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar dados da N.F.!" + Ex.Message);
            }

        }

        void buscar_Valor_NF()
        {
            try
            {
                String StrConn;
                string ValorNF;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Valor_NF from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    ValorNF = reader["Valor_NF"].ToString();
                    Valor_NF_text_box.Text = ValorNF;
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Valor da N.F.!" + Ex.Message);
            }

        }

        void buscar_Valor_Pago_a_vista()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Valor_Pago_a_Vista from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Valor_Pago_a_Vista.Text = reader["Valor_Pago_a_Vista"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Valor Pago à Vista da N.F.!" + Ex.Message);
            }

        }

        void buscar_Data_NF()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Data_NF from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    DateTime Data_Nota_Fiscal =Convert.ToDateTime(reader["Data_NF"].ToString());
                    Data_NF_textbox.Text = (Data_Nota_Fiscal.ToShortDateString());
                    
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Data da N.F.!" + Ex.Message);
            }
        }

        void buscar_CodigoReceita()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Cod_Receita from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Cod_Receita.Text = reader["Cod_Receita"].ToString();
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Código da Receita da N.F.!" + Ex.Message);
            }
        }

        void buscar_StatusTitulo()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Cod_Status_Titulo, from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Status_Titulo.Text = reader["Cod_Status_Titulo"].ToString();
                  
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Status do Título da N.F.!" + Ex.Message);
            }

        }
         
        void buscar_Descricao_Titulo()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select Descricao_Status from Status_Titulos_a_Receber where Codigo_Status_Tit_a_Receber='{0}'", Status_Titulo.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    StatusDescricao.Text = reader["Descricao_Status"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Status do Título da N.F.!" + Ex.Message);
            }

        }


        void buscar_historicoTitulo()
        {
            try
            {
                string historico;
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Historico from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    historico = reader["Historico"].ToString();
                    historico_Titulo.Text = historico;
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Histórico da Parcela na N.F.!" + Ex.Message);
            }

        }

        void buscar_ControleVenda()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Codigo_CV from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    Cod_CV.Text = reader["Codigo_CV"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Histórico da Parcela na N.F.!" + Ex.Message);
            }

        }
        void BuscarNumeroParcelaTituloaReceber()
        {
            // BUSCAR NÚMERO DE PARCELAS DO TÍTULO A RECEBER E COMPARAR COM A PARCELA QUE ESTÁ SENDO RECEBIDA
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Numero_Parcelas from Entrada_Titulos_a_Receber where Cod_Entrada_Titulos_a_Receber='{0}'", Cod_Entr_Tit_a_Receber.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection); // cod_Titulo_a_PagarTextBox.Text
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    NumeroParcelasTituloaReceber = reader["Numero_Parcelas"].ToString();
                    numeroparcelastituloaReceberInt = Convert.ToInt32(NumeroParcelasTituloaReceber);
                }
                CodigoTituloaReceber = Convert.ToInt32(numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[0].Value.ToString());
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                Debug.WriteLine("Erro ao buscar Número de parcelas do título !" + Ex.Message);
            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Bancos_Click(object sender, EventArgs e)
        {
            TelaBancosNova frm = new TelaBancosNova() { Owner = this };
            frm.ShowDialog();
            btn_Inserir_Recebimentos.Enabled = true;

            //    TelaBancosNova f = new TelaBancosNova(this,banco_CreditadoTextBox);
            //    f.ShowDialog();
        }

        private void btn_Inserir_Recebimentos_Click(object sender, EventArgs e)
        {
            btn_Bancos.Enabled = true;
            btn_salvar.Enabled = true;
            btn_recebido.Enabled = false;
            btn_salvar.BackColor = Color.Orange;
            btn_salvar.ForeColor = Color.Navy;
            btn_recebido.BackColor = Color.Coral;
            btn_recebido.ForeColor = Color.White;

            if (data_RecebimentoDateTimePicker.Text == " ")
            {
                MessageBox.Show("É necessário o preenchimento da data de recebimento!");

            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Base_Titulos_Recebidos(Data_Recebimento, Total_Recebido, Banco_Creditado, Historico, Data_Login, Login_Name)"
                        + "VALUES(@Data_Recebimento, @Total_Recebido, @Banco_Creditado, @Historico, @Data_Login, @Login_Name)", conn);
                    conn.Open();
                    DateTime DataRecebimento = Convert.ToDateTime(data_RecebimentoDateTimePicker.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Data_Recebimento", DataRecebimento);
                    decimal totalrecebido = Convert.ToDecimal(total_RecebidoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Total_Recebido", totalrecebido);
                    Int32 bancocreditado = Convert.ToInt32(banco_CreditadoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Banco_Creditado", bancocreditado);
                    string historicopagamento = historicoTextBox.Text;
                    cmd.Parameters.AddWithValue("@Historico", historicopagamento);
             //     string NumeroNF = Public_NumeroNF;
            //      cmd.Parameters.AddWithValue("@NumeroNF", NumeroNF);
                    cmd.Parameters.AddWithValue("@Data_Login", Data_Agora);
                    string LoginName = Login.DadosGerais.Loginusuario;
                    cmd.Parameters.AddWithValue("@Login_Name", LoginName);
                    Int32 result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Inicie a Seleção de Títulos Recebidos para Crédito! " + result.ToString() + "Registro Inserido!");
                    cod_Base_Titulos_a_RecebidosTextBox.Refresh();
                    this.numero_Parcelas_a_ReceberDataGridView.Enabled = true;
                    SelecionarMaxID(); // Método acima para passar valores do Último ID para os TextBox

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao Inserir Recebimentos! " + Ex.Message);
                }
                finally
                {
                    conn.Close();
                    btn_fechar.Enabled = true;
                    btn_Inserir_Recebimentos.Enabled = false;
                }

            }

        }           


        private void btn_novo_Click(object sender, EventArgs e)
        {
            cod_Base_Titulos_a_RecebidosTextBox.Text = string.Empty;
            data_RecebimentoDateTimePicker.Format = DateTimePickerFormat.Custom;
            data_RecebimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            data_RecebimentoDateTimePicker.Text =null;
            total_RecebidoTextBox.Text = "0,00";
            historicoTextBox.Text = string.Empty;
            banco_CreditadoTextBox.Text = string.Empty;
            btn_Inserir_Recebimentos.Enabled = false;
            numero_Parcelas_a_ReceberDataGridView.Enabled = false;
            data_LoginTextBox.Text = string.Empty;
            login_NameTextBox.Text = string.Empty;
            
            // HABILITAR CAMPOS DE EDIÇÃO
            data_RecebimentoDateTimePicker.Enabled = true;
            historicoTextBox.Enabled = true;
            AcrescimosTextbox.Enabled = true;
            Descontotextbox.Enabled = true;
            data_Recebimento_NF.Enabled = true;
            Valor_recebido.Enabled = true;
            historico_Titulo.Enabled = true;
            btn_novo.Enabled = false;
            btn_Bancos.Enabled = true;

        }

        private void numero_Parcelas_a_ReceberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Cod_Entr_Tit_a_Receber.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[0].Value.ToString();
                Cod_numero_parcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[1].Value.ToString();
                Numero_Parcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[2].Value.ToString();
                Venc_Parcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[3].Value.ToString();
                Valor_Parcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[4].Value.ToString();
                historico_parcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[5].Value.ToString();
                Status_Titulo.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[6].Value.ToString();
                data_RecebimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
                AcrescimosTextbox.Text = "0,00";
                Descontotextbox.Text = "0,00";
                Valor_recebido.Text = Valor_Parcela.Text;
                numero_banco.Text = banco_CreditadoTextBox.Text;
                btn_editar.Enabled = false;
                btn_Bancos.Enabled = false;
                btn_proximo.Enabled = false;
                btn_Anterior.Enabled = false;
                btn_salvar.Enabled = false;
                btn_fechar.Enabled = false;
                btn_recebido.Enabled = false;
                btn_novo.Enabled = false;
                //  AQUI EU BUSCO AS INFORMAÇÕES DO TÍTULO SELECIONADO NO BANCO de DADOS E PASSO PARA OS TEXTBOXES COM O MÉTODO
                buscar_dados_cliente();
                buscar_numero_NF();
                buscar_Valor_NF();
                buscar_Valor_Pago_a_vista();
                buscar_Data_NF();
                buscar_CodigoReceita();
                buscar_StatusTitulo();
                buscar_historicoTitulo();
                buscar_ControleVenda();
                data_Recebimento_NF.Focus();

            }
        }

        private void data_RecebimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            data_RecebimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

      

        private void btn_recebido_Click(object sender, EventArgs e)
        {
            //  decimal valorrecebido = 0;
            BuscarNumeroParcelaTituloaReceber();
            string numeroparcelaDGV = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[2].Value.ToString();
            numeroparcelaDGVInt = Convert.ToInt32(numeroparcelaDGV);
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))

                if (data_Recebimento_NF.Text == " " && Cod_Entr_Tit_a_Receber.Text != " ")
            {
                MessageBox.Show("Insira a Data de Pagamento da Nota Fiscal!");
            }
            else
            {
                if (MessageBox.Show("Adiciona este Título para Recebimento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Recebimento = Convert.ToDecimal(Valor_recebido.Text);
                        Total = Total + Recebimento;
                        textBoxTotalRecebido.Text = Convert.ToString(Total);
                        // FAZER O INSERT NA TABELA COM OS CAMPOS DOS TEXTBOX
                        cmd = new SqlCommand("INSERT INTO Base_Parcelas_Recebidas(Cod_Base_Titulos_a_Recebidos, Cod_Entrada_Titulos_a_Receber, Cod_Numero_Parcelas_Receber, Cod_Cliente, Numero_Documento, Numero_Parcela, Valor_Titulo, Valor_Pago_a_Vista, Data_Documento, Data_Recebimento, Data_Venc_Parcela, Numero_Banco, Cod_Receita, Valor_Recebido, Acrescimos, Desconto, Saldo, Status_Titulo_a_Receber, Historico_Titulo, Historico_Parcela)"
                         + "VALUES(@Cod_Base_Titulos_a_Recebidos, @Cod_Entrada_Titulos_a_Receber, @Cod_Numero_Parcelas_Receber, @Cod_Cliente, @Numero_Documento, @Numero_Parcela, @Valor_Titulo, @Valor_Pago_a_Vista, @Data_Documento, @Data_Recebimento, @Data_Venc_Parcela, @Numero_Banco, @Cod_Receita, @Valor_Recebido, @Acrescimos, @Desconto, @Saldo, @Status_Titulo_a_Receber, @Historico_Titulo, @Historico_Parcela)", conn);
                        conn.Open();
                        Int32 UltimoID = Convert.ToInt32(Cod_Base_Tit_Recebidos.Text);
                        cmd.Parameters.AddWithValue("@Cod_Base_Titulos_a_Recebidos", UltimoID);
                        Int32 CodTitaReceber = Convert.ToInt32(Cod_Entr_Tit_a_Receber.Text);
                        cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Receber", CodTitaReceber);
                        Int32 CodNumeroParcelaReceber = Convert.ToInt32(Cod_numero_parcela.Text);
                        cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_Receber", CodNumeroParcelaReceber);
                        Int32 CodCliente = Convert.ToInt32(Codigo_Cliente.Text);
                        cmd.Parameters.AddWithValue("@Cod_Cliente", CodCliente);
                        string NumeroNF = Convert.ToString(Numero_NF.Text);
                        cmd.Parameters.AddWithValue("@Numero_Documento", NumeroNF);
                        Int32 NumeroParcela = Convert.ToInt32(Numero_Parcela.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcela", NumeroParcela);
                        decimal ValorTitulo = Convert.ToDecimal(Valor_NF_text_box.Text);
                        cmd.Parameters.AddWithValue("@Valor_Titulo", ValorTitulo);
                        decimal ValorPagoaVista = Convert.ToDecimal(Valor_Pago_a_Vista.Text);
                        cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", ValorPagoaVista);
                        DateTime DataDocumento = Convert.ToDateTime(Data_NF_textbox.Text);
                        cmd.Parameters.AddWithValue("@Data_Documento", DataDocumento);
                        DateTime DataRecebimento = Convert.ToDateTime(data_Recebimento_NF.Text);
                        cmd.Parameters.AddWithValue("@Data_Recebimento", DataRecebimento);
                        DateTime VencParcela = Convert.ToDateTime(Venc_Parcela.Text);
                        cmd.Parameters.AddWithValue("@Data_Venc_Parcela", VencParcela);
                        Int32 NumeroBanco = Convert.ToInt32(numero_banco.Text);
                        cmd.Parameters.AddWithValue("@Numero_Banco", NumeroBanco);
                        Int32 CodReceita = Convert.ToInt32(Cod_Receita.Text);
                        cmd.Parameters.AddWithValue("@Cod_Receita", CodReceita);
                        decimal ValorRecebido = Convert.ToDecimal(Valor_recebido.Text);
                        cmd.Parameters.AddWithValue("@Valor_Recebido", ValorRecebido);
                        decimal acrescimos = Convert.ToDecimal(AcrescimosTextbox.Text);
                        cmd.Parameters.AddWithValue("@Acrescimos", acrescimos);
                        decimal desconto = Convert.ToDecimal(Descontotextbox.Text);
                        cmd.Parameters.AddWithValue("@Desconto", desconto);
                        decimal saldo = Convert.ToDecimal(SaldoTextbox.Text);
                        cmd.Parameters.AddWithValue("@Saldo", saldo);
                        Int32 StatusTitulo = Convert.ToInt32(Status_Titulo.Text);
                        cmd.Parameters.AddWithValue("@Status_Titulo_a_Receber", StatusTitulo);
                        string historicoTitulo = Convert.ToString(historico_Titulo.Text);
                        cmd.Parameters.AddWithValue("@Historico_Titulo", historicoTitulo);
                        string historicoParcela = Convert.ToString(historico_parcela.Text);
                        cmd.Parameters.AddWithValue("@Historico_Parcela", historicoParcela);
                        Int32 result = cmd.ExecuteNonQuery();
               //       Total = Total + ValorRecebido;
              //        textBoxTotalRecebido.Text = Convert.ToString(Total);
              //        this.base_Parcelas_RecebidasTableAdapter.Fill(baseParcelasRecebidasDGV.Base_Parcelas_Recebidas);
                        MessageBox.Show("Dados do Título Inseridos com Sucesso na Base de Parcelas Recebidas! " + result.ToString() + " Registro Inserido!");
                        numero_Parcelas_a_ReceberBindingSource.MoveLast();
                        btn_recebido.Enabled = false;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! Falha ao Tentar Inserir o Registro! " + Ex.Message);
                    }
                    finally
                    {
                        //  DELETAR DA BASE DE PARCELAS A RECEBER 0 REGISTRO INSERIDO ACIMA - DELETAR O TÍTULO SE FOR A ÚLTIMA PARCELA A RECEBER
                        int IDParcela = Convert.ToInt32(Cod_numero_parcela.Text);
                        int IDTitulo = Convert.ToInt32(Cod_Entr_Tit_a_Receber.Text);
                        // VERIFICAR SE O NÚMERO DA PARCELA A RECEBER É IGUAL AO NÚMERO DE PARCELAS DO TÍTULO (SE FOR DIFERENTE - DELETAR APENAS A PARCELA)
                        if (numeroparcelaDGVInt != numeroparcelastituloaReceberInt)
                        {
                            try
                            {
                                cmd = new SqlCommand("DELETE Numero_Parcelas_a_Receber WHERE Cod_Numero_Parcelas_Receber = @Cod_Numero_Parcelas_Receber", conn);
                                cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_Receber", IDParcela);
                                int result0 = cmd.ExecuteNonQuery();
                                MessageBox.Show("Parcela Excluida com Sucesso!" + result0.ToString() + " Registro Excluído!");
                                numero_Parcelas_a_ReceberDataGridView.Rows.Remove(numero_Parcelas_a_ReceberDataGridView.CurrentRow);
                                this.numero_Parcelas_a_ReceberTableAdapter.Fill(this.numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);
                                this.numero_Parcelas_a_ReceberBindingSource.MoveFirst();
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
                                cmd = new SqlCommand("DELETE Numero_Parcelas_a_Receber WHERE Cod_Numero_Parcelas_Receber = @Cod_Numero_Parcelas_Receber", conn);
                                cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_Receber", IDParcela);
                                int result0 = cmd.ExecuteNonQuery();
                                MessageBox.Show("Parcela Excluida com Sucesso!" + result0.ToString() + " Registro Excluído!");
                                numero_Parcelas_a_ReceberDataGridView.Rows.Remove(numero_Parcelas_a_ReceberDataGridView.CurrentRow);
                                this.numero_Parcelas_a_ReceberTableAdapter.Fill(this.numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);
                                this.numero_Parcelas_a_ReceberBindingSource.MoveLast();
                                this.numero_Parcelas_a_ReceberDataGridView.DefaultCellStyle.ForeColor = Color.BlueViolet;
                                this.numero_Parcelas_a_ReceberDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
                                //       DELETAR TÍTULO
                                //       VERIFICAR SE O CÓDIGO DO TÍTULO É O MESMO DA PARCELA QUE ESTÁ SENDO EXCLUÍDA
                                if (IDTitulo == CodigoTituloaReceber)
                                {
                                    cmd = new SqlCommand("DELETE Entrada_Titulos_a_Receber WHERE Cod_Entrada_Titulos_a_Receber = @Cod_Entrada_Titulos_a_Receber", conn);
                                    cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Receber", IDTitulo);
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
                                btn_salvar.Focus();
                            }

                        }

                    }

                }
                else
                {

                    MessageBox.Show("Selecione uma Parcela para Recebimento! É necessário preencher as Informações do Título!");

                }  // LIMPAR OS CAMPOS PARA FAZE NOVA SELEÇÃO DE RECEBIMENTO DE PARCELAS
                numero_Parcelas_a_ReceberDataGridView.Enabled = true;
                //  Cod_Base_Tit_Recebidos.Text = string.Empty;
                Cod_Entr_Tit_a_Receber.Text = string.Empty;
                Cod_numero_parcela.Text = string.Empty;
                Codigo_Cliente.Text = string.Empty;
                Numero_NF.Text = string.Empty;
                Numero_Parcela.Text = string.Empty;
                Valor_NF_text_box.Text = string.Empty;
                Valor_Pago_a_Vista.Text = string.Empty;
                Data_NF_textbox.Text = string.Empty;
                data_Recebimento_NF.Text = string.Empty;
                Valor_Parcela.Text = string.Empty;
                SaldoTextbox.Text = string.Empty;
                Cod_Receita.Text = string.Empty;
                Valor_recebido.Text = string.Empty;
                AcrescimosTextbox.Text = string.Empty;
                Descontotextbox.Text = string.Empty;
                numero_banco.Text = string.Empty;
                Status_Titulo.Text = string.Empty;
                StatusDescricao.Text = string.Empty;
                historico_Titulo.Text = string.Empty;
                historico_parcela.Text = string.Empty;
                Venc_Parcela.Text = string.Empty;
                Cod_CV.Text = string.Empty;
                Acrescimos = 0;
                Desconto = 0;
                Saldo = 0;
                valorparcelaPublic = 0;
                valorrecebido = 0;
                this.base_Parcelas_RecebidasTableAdapter.Fill(baseParcelasRecebidasDGV.Base_Parcelas_Recebidas);
                this.numero_Parcelas_a_ReceberBindingSource.MoveFirst();
                this.base_Parcelas_RecebidasBindingSource.MoveLast();

            }
        }
    


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
            data_LoginTextBox.Text = Data_Agora.ToShortDateString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            total_RecebidoTextBox.Text = textBoxTotalRecebido.Text;
            ID = Convert.ToInt32(Cod_Base_Tit_Recebidos.Text);
            btn_novo.Enabled = true;
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
                if (cod_Base_Titulos_a_RecebidosTextBox.Text!=null && data_RecebimentoDateTimePicker.Text != null && banco_CreditadoTextBox.Text !=null)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Base_Titulos_Recebidos SET Data_Recebimento=@Data_Recebimento, Total_Recebido=@Total_Recebido, Banco_Creditado=@Banco_Creditado, Historico=@Historico, NumeroNF=@NumeroNF, Data_Login=@Data_Login,"
                                     + "Login_Name=@Login_Name WHERE Cod_Base_Titulos_a_Recebidos=@Cod_Base_Titulos_a_Recebidos", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Cod_Base_Titulos_a_Recebidos", ID);
                        DateTime datarecebimento = Convert.ToDateTime(data_RecebimentoDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@Data_Recebimento", datarecebimento);
                        decimal totalrecebido = Convert.ToDecimal(total_RecebidoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Total_Recebido", totalrecebido);
                        Int32 bancocreditado = Convert.ToInt32(banco_CreditadoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Banco_Creditado", bancocreditado);
                        string historico = historicoTextBox.Text;
                        cmd.Parameters.AddWithValue("@Historico", historico);
                        string NumeroNF = Public_NumeroNF;
                        cmd.Parameters.AddWithValue("@NumeroNF", NumeroNF);
                        DateTime datalogin = Convert.ToDateTime(data_LoginTextBox.Text);
                        cmd.Parameters.AddWithValue("@Data_Login", datalogin);
                        string login = login_NameTextBox.Text;
                        cmd.Parameters.AddWithValue("@Login_Name", login);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Recebimento de Título Salvo com Sucesso!" + result.ToString() + "Registro Atualizado!");
                        btn_salvar.Enabled = false;
                        btn_fechar.Enabled = true;
                        numero_Parcelas_a_ReceberDataGridView.Enabled = false;
                     
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! ao Salvar/Atualizar Recebimento do Título! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        cod_Base_Titulos_a_RecebidosTextBox.Text = string.Empty;
                        Public_NumeroNF = String.Empty;
                        data_RecebimentoDateTimePicker.CustomFormat = "   ";
                        Cod_Base_Tit_Recebidos.Text = string.Empty;
                        historicoTextBox.Text = string.Empty;
                        banco_CreditadoTextBox.Text = string.Empty;
                        total_RecebidoTextBox.Text = string.Empty;
                        Recebimento = 0;
                        Total = 0;
                        textBoxTotalRecebido.Text = string.Empty;
                        btn_Inserir_Recebimentos.Enabled = false;
                        login_NameTextBox.Text = string.Empty;
                        data_LoginTextBox.Text = string.Empty;
                        numero_Parcelas_a_ReceberDataGridView.Enabled = false;
                    }
                }
        }

        private void Valor_Parcela_TextChanged(object sender, EventArgs e)
        {
            decimal valorrecebido = 0;
            decimal valorparcela = 0;
            decimal Acrescimos = 0;
            decimal Desconto = 0;
            decimal Saldo = 0;
            Decimal.TryParse(Valor_Parcela.Text, out valorparcela);
            Decimal.TryParse(Valor_recebido.Text, out valorrecebido);
            Decimal.TryParse(Descontotextbox.Text, out Desconto);
            Decimal.TryParse(SaldoTextbox.Text, out Saldo);
         
  //        Acrescimos = Convert.ToDecimal(AcrescimosTextbox.Text);
   //       valorparcela = Convert.ToDecimal(Valor_Parcela.Text);
            valorrecebido = (valorparcela + Acrescimos);
 //         Desconto = Convert.ToDecimal(Descontotextbox.Text);
 //         Saldo = Convert.ToDecimal(SaldoTextbox.Text);
            valorrecebido = ((valorparcela + Acrescimos) - (Desconto));
            Valor_recebido.Text = Convert.ToString(valorrecebido);
            Saldo = ((valorrecebido) - (valorparcela - Desconto));
     //     SaldoTextbox.Text = Convert.ToString(Saldo);
        }

        private void SaldoTextbox_TextChanged(object sender, EventArgs e)
        {
            if (Saldo >= 0)
            {
                Status_Titulo.Text = "2".ToString();
                StatusDescricao.Text = "Quitado";
            }
            if (Saldo <0 )
            {
                Status_Titulo.Text = "3".ToString();
                StatusDescricao.Text = "Saldo Pendente";
            }
        }

        private void Valor_recebido_Leave(object sender, EventArgs e)
        {
            decimal valorrecebido = 0;
            decimal valorparcela = 0;
            decimal Acrescimos = 0;
            decimal Desconto = 0;
            decimal Saldo = 0;
            Decimal.TryParse(Valor_Parcela.Text, out valorparcela);
            Decimal.TryParse(Valor_recebido.Text, out valorrecebido);
            Decimal.TryParse(Descontotextbox.Text, out Desconto);
            Decimal.TryParse(SaldoTextbox.Text, out Saldo);
            valorrecebido = Convert.ToDecimal(Valor_recebido.Text);
            Acrescimos = Convert.ToDecimal(AcrescimosTextbox.Text);
            valorparcela = Convert.ToDecimal(Valor_Parcela.Text);
            Desconto = Convert.ToDecimal(Descontotextbox.Text);
            valorrecebido = ((valorparcela + Acrescimos)- (Desconto));
            Saldo = ((valorrecebido) - (valorparcela-Desconto));
            SaldoTextbox.Text = Convert.ToString(Saldo);
            Valor_recebido.Text = Convert.ToString(valorrecebido);
            if (Saldo >= 0)
            {
                Status_Titulo.Text = "2".ToString();
                StatusDescricao.Text = "Quitado";
            }
            if (Saldo < 0)
            {
                Status_Titulo.Text = "3".ToString();
                StatusDescricao.Text = "Saldo Pendente";
            }
        }

        private void AcrescimosTextbox_Leave(object sender, EventArgs e)
        {
            decimal valorrecebido = 0;
            decimal valorparcela = 0;
            decimal Acrescimos = 0;
            decimal Desconto = 0;
            decimal Saldo = 0;
            Decimal.TryParse(Valor_Parcela.Text, out valorparcela);
            Decimal.TryParse(Valor_recebido.Text, out valorrecebido);
            Decimal.TryParse(Descontotextbox.Text, out Desconto);
            Decimal.TryParse(SaldoTextbox.Text, out Saldo);
            valorrecebido = Convert.ToDecimal(Valor_recebido.Text);
            Acrescimos = Convert.ToDecimal(AcrescimosTextbox.Text);
            valorparcela = Convert.ToDecimal(Valor_Parcela.Text);
            Desconto = Convert.ToDecimal(Descontotextbox.Text);
            valorrecebido = ((valorparcela + Acrescimos)-(Desconto)); 
            Saldo = ((valorrecebido) - (valorparcela - Desconto));
            SaldoTextbox.Text = Convert.ToString(Saldo);
            Valor_recebido.Text = Convert.ToString(valorrecebido);

            if (Saldo >= 0)
            {
                Status_Titulo.Text = "2".ToString();
                StatusDescricao.Text = "Quitado";
            }
            if (Saldo < 0)
            {
                Status_Titulo.Text = "3".ToString();
                StatusDescricao.Text = "Saldo Pendente";
            }
        }

        private void data_Recebimento_NF_Leave(object sender, EventArgs e)
        {
            bool Validadata;

            try
            {
                Convert.ToDateTime(data_Recebimento_NF.Text);
                Validadata = true;
            }
            catch (Exception Ex)
            {
                Validadata = false;
            }

            if (Validadata)
            {
                Valor_recebido.Focus(); 
            }
            else
            {
                MessageBox.Show("Data de Recebimento da Nota Fiscal não é Válida!");
                data_Recebimento_NF.Text = "";
                data_Recebimento_NF.Focus();
            }
            decimal valorrecebido = 0;
            decimal valorparcela = 0;
            decimal Acrescimos = 0;
            decimal Desconto = 0;
            decimal Saldo = 0;
            Decimal.TryParse(Valor_Parcela.Text, out valorparcela);
            Decimal.TryParse(Valor_recebido.Text, out valorrecebido);
            Decimal.TryParse(Descontotextbox.Text, out Desconto);
            Decimal.TryParse(SaldoTextbox.Text, out Saldo);
            valorrecebido = Convert.ToDecimal(Valor_recebido.Text);
            Acrescimos = Convert.ToDecimal(AcrescimosTextbox.Text);
            valorparcela = Convert.ToDecimal(Valor_Parcela.Text);
            Desconto = Convert.ToDecimal(Descontotextbox.Text);
            valorrecebido = ((valorparcela + Acrescimos) - (Desconto));
            Saldo = ((valorrecebido) - (valorparcela - Desconto));
            SaldoTextbox.Text = Convert.ToString(Saldo);
            Valor_recebido.Text = Convert.ToString(valorrecebido);
            btn_recebido.Enabled = true;

        }


        private void Descontotextbox_Leave(object sender, EventArgs e)
        {
            decimal valorrecebido = 0;
            decimal valorparcela = 0;
            decimal Acrescimos = 0;
            decimal Desconto = 0;
            decimal Saldo = 0;
            Decimal.TryParse(Valor_Parcela.Text, out valorparcela);
            Decimal.TryParse(Valor_recebido.Text, out valorrecebido);
            Decimal.TryParse(Descontotextbox.Text, out Desconto);
            Decimal.TryParse(SaldoTextbox.Text, out Saldo);
            valorrecebido = Convert.ToDecimal(Valor_recebido.Text);
            Acrescimos = Convert.ToDecimal(AcrescimosTextbox.Text);
            valorparcela = Convert.ToDecimal(Valor_Parcela.Text);
            valorrecebido = (valorparcela + Acrescimos);
            Desconto = Convert.ToDecimal(Descontotextbox.Text);
            valorrecebido = ((valorparcela + Acrescimos) - (Desconto));
            Saldo = ((valorrecebido) - (valorparcela- Desconto));
            SaldoTextbox.Text = Convert.ToString(Saldo);
            Valor_recebido.Text = Convert.ToString(valorrecebido);
            if (Saldo >= 0)
            {
                Status_Titulo.Text = "2".ToString();
                StatusDescricao.Text = "Quitado";
            }
            if (Saldo < 0)
            {
                Status_Titulo.Text = "3".ToString();
                StatusDescricao.Text = "Saldo Pendente";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Status_Titulo_TextChanged(object sender, EventArgs e)
        {
            buscar_Descricao_Titulo();
        }
    }

}
