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
using System.Diagnostics;
using System.Data.OleDb;
using System.Globalization;





namespace SGFRenaissance
{
    public partial class EntradaTitulosaPagar : Form
    {
        private DateTime Data_Agora;
        private int ultimoCodigoEntradaTP = 0;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public EntradaTitulosaPagar()
        {
            InitializeComponent();
            entrada_Titulos_a_PagarDataGridView.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            int currentIndex;
            int flag = -1;
            ExibirDados();


        }

        private void ExibirDados()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("Select * from Entrada_Titulos_a_Pagar", conn);
                adapt.Fill(dt);
                entrada_Titulos_a_PagarDataGridView.DataSource = dt;

            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void LimparDados()
        {
            numero_DocumentoTextBox1.Text = "";
            data_DocumentoDateTimePicker.Text = "";
            data_VencimentoDateTimePicker1.Text = "";
            valor_TituloTextBox.Text = "";
            valor_Pago_a_VistaTextBox1.Text = "";
            acrescimosTextBox1.Text = "";
            descontosTextBox1.Text = "";
            saldoTextBox1.Text = "";
            numero_ParcelasTextBox1.Text = "";
            TextBox_Cod_CentroCustos.Text = "";
            cod_Status_TituloTextBox1.Text = "";
            cod_DespesaTextBox.Text = "";
            historico_TituloTextBox1.Text = "";
            observacaoTextBox1.Text = "";
            data_logintxtbox.Text = "";
            login_NameTextBox.Text = "";
            textBox_Fornecedor.Text = "";
            TexBoxNome_CentroCustos.Text = "";
            TexBoxNome_CentroCustos.Text = "";
            Status_Titulo_Textbox.Text = "";
            Status_Titulo_Textbox.Text = "";
            descricao_Despesa_textBox.Text = "";
            descricao_Despesa_textBox.Text = "";
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        void TryRefreshData()
        {
            try
            {
                 String StrConn;
                 StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                 SqlConnection sqlConnection = new SqlConnection(StrConn);
                 sqlConnection.Open();
                 string sql = string.Format("select  Nome_Fornecedor from Fornecedor_Contas_a_Pagar where Cod_Fornecedor='{0}'", cod_FornecedorTextBox1.Text);
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
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
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
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
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
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
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

         int currentIndex;
         int flag = -1;
        private void Entrada_Titulos_a_Pagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entradaTitulosaPagarDataGrid.Entrada_Titulos_a_Pagar' table. You can move, or remove it, as needed.
            this.entrada_Titulos_a_PagarTableAdapter.Fill(this.entradaTitulosaPagarDataGrid.Entrada_Titulos_a_Pagar);
            
             string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
             using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Entrada_Titulos_a_Pagar", conn);
                DataSet Ds = new DataSet();
                sda.Fill(Ds, "T1");
                entrada_Titulos_a_PagarDataGridView.DataSource = Ds.Tables["T1"];
            }
            // Bind the "SelectionChanged" here
               entrada_Titulos_a_PagarDataGridView.SelectionChanged += entrada_Titulos_a_PagarDataGridView_SelectionChanged; 
               GetDetails();

          // this.entradaTitulosaPagarsBindingSource.DataSource = DataContextFactory.DataContext.Entrada_Titulos_a_Pagars;
             this.fornecedor_Contas_a_PagarBindingSource.DataSource = DataContextFactory.DataContext.Fornecedor_Contas_a_Pagars;
             this.centro_CustoBindingSource.DataSource = DataContextFactory.DataContext.Centro_Custos;
             this.contas_DespesaBindingSource.DataSource = DataContextFactory.DataContext.Contas_Despesas;
             this.status_TituloBindingSource.DataSource = DataContextFactory.DataContext.Status_Titulos;
             this.numero_Parcelas_a_PagarBindingSource.DataSource = DataContextFactory.DataContext.Numero_Parcelas_a_Pagars;
             TryRefreshData();
             textBox_Fornecedor.Refresh();
             TryRefreshCustos();
             TryRefreshDespesa();
             TryRefreshStatusTitulo();
             groupBox_Parcelas.Visible = false;
             btn_salvar_parcela.Enabled = false;
             btn_adicionar_parcela.Enabled = false;
             btn_status_titulo.Enabled = true;
        }

        private void _btnFechar_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Deseja Sair do Forumulário ?", "Cadastrar Títulos a Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Close();
                this.Close();
            }
            else
            {
                _btnFechar.Focus();
            }

            
        }

        private void _btnSalvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            Data_Agora = DateTime.Now;
            data_logintxtbox.Text = DateTime.Now.ToString();
            data_logintxtbox.Refresh();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            this.entrada_Titulos_a_PagarBindingSource.EndEdit();
            this.numero_Parcelas_a_PagarBindingSource.EndEdit();

            if (cod_FornecedorTextBox1.Text != "" && TextBox_Cod_CentroCustos.Text != "" && cod_Status_TituloTextBox1.Text != "" && cod_DespesaTextBox.Text != "" && valor_TituloTextBox.Text != "")
            {
                try
                {
                    cmd =new SqlCommand ("INSERT INTO Entrada_Titulos_a_Pagar (Cod_Fornecedor, Numero_Documento, Data_Documento, Data_Vencimento, Valor_Titulo, Valor_Pago_a_Vista, Acrescimos, Descontos, Saldo, Numero_Parcelas, Cod_Centro_Custos, Cod_Status_Titulo, Cod_Despesa, Historico_Titulo, Observacao, Data_Login, Login_Name)",conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Cod_Fornecedor", cod_FornecedorTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Numero_Documento", numero_DocumentoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Data_Documento", data_DocumentoDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@Data_Vencimento", data_VencimentoDateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Valor_Titulo", valor_TituloTextBox.Text);
                    cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", valor_Pago_a_VistaTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Acrescimos", acrescimosTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Descontos", descontosTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Saldo", saldoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Numero_Parcelas", numero_ParcelasTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Cod_Centro_Custos", TextBox_Cod_CentroCustos.Text);
                    cmd.Parameters.AddWithValue("@Cod_Status_Titulo", cod_Status_TituloTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Cod_Despesa", cod_DespesaTextBox.Text);
                    cmd.Parameters.AddWithValue("@Historico_Titulo", historico_TituloTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Observacao", observacaoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Data_Login", data_logintxtbox.Text);
                    cmd.Parameters.AddWithValue("@Login_Name", login_NameTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados do Título Contas a Pagar Inserido com Sucesso!");


                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Erro! " + Ex.Message);

                }
                finally
                {
                    conn.Close();
               //   ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Insira todos os Dados Requeridos!");
            }

       //   DataContextFactory.DataContext.SubmitChanges();
            this.entrada_Titulos_a_PagarDataGridView.DataSource = entrada_Titulos_a_PagarBindingSource;
            this.dataGridView2.DataSource = numero_Parcelas_a_PagarBindingSource;
            entrada_Titulos_a_PagarDataGridView.Refresh(); 
            btn_Novo.Enabled = true;
            btn_adicionar_parcela.Enabled = true;

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
         // Check the index, and move the focus
            int currentIndex;
            currentIndex = entrada_Titulos_a_PagarDataGridView.CurrentCell.RowIndex;
            if (currentIndex > 0)
            {
                entrada_Titulos_a_PagarDataGridView.CurrentCell = entrada_Titulos_a_PagarDataGridView.Rows[currentIndex - 1].Cells[0];
                entrada_Titulos_a_PagarDataGridView.CurrentCell.Selected = false;
                flag *= -1;
                entrada_Titulos_a_PagarDataGridView.Rows[currentIndex - 1].Cells[0].Selected = true;
     //         entrada_Titulos_a_PagarBindingSource.MovePrevious();
                TryRefreshData();
                textBox_Fornecedor.Refresh();
                TryRefreshCustos();
                TexBoxNome_CentroCustos.Refresh();
                TryRefreshDespesa();
                descricao_Despesa_textBox.Refresh();
                TryRefreshStatusTitulo();
                Status_Titulo_Textbox.Refresh();

            } 
        }

        private void Btn_Proximo_Click(object sender, EventArgs e)
        {
         // Check the index, and move the focus
            int currentIndex;
            currentIndex = entrada_Titulos_a_PagarDataGridView.CurrentRow.Index;
            if (currentIndex < entrada_Titulos_a_PagarDataGridView.Rows.Count - 1)
            {
                entrada_Titulos_a_PagarDataGridView.CurrentCell = entrada_Titulos_a_PagarDataGridView.Rows[currentIndex + 1].Cells[0];
                entrada_Titulos_a_PagarDataGridView.CurrentCell.Selected = false;
                flag *= -1;
                entrada_Titulos_a_PagarDataGridView.Rows[currentIndex + 1].Cells[0].Selected = true;
                entrada_Titulos_a_PagarBindingSource.MoveNext();
                entrada_Titulos_a_PagarBindingSource.MovePrevious();
                
            }
            TryRefreshData();
            textBox_Fornecedor.Refresh();
            TryRefreshCustos();
            TexBoxNome_CentroCustos.Refresh();
            TryRefreshDespesa();
            descricao_Despesa_textBox.Refresh();
            TryRefreshStatusTitulo();
            Status_Titulo_Textbox.Refresh();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            TexBoxNome_CentroCustos.Text = string.Empty;
            Status_Titulo_Textbox.Text = string.Empty;
            descricao_Despesa_textBox.Text = string.Empty;
            textBox_Fornecedor.Text = string.Empty;
            limparTextBoxes(this.Controls);
            NovoItem();
            btn_adicionar_parcela.Enabled = true;
            entrada_Titulos_a_PagarDataGridView.BeginEdit(true);
        }

            void GetDetails()
        {
            int currentId;
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            int index = entrada_Titulos_a_PagarDataGridView.CurrentCell.RowIndex;
            currentId = Convert.ToInt32(entrada_Titulos_a_PagarDataGridView.Rows[index].Cells["Cod_Id"].Value);
            using (SqlConnection conn = new SqlConnection(constr))
            {
                var select = "Select * From Numero_Parcelas_a_Pagar Where Cod_Entrada_Titulos_a_Pagar="+currentId;
            //  SqlDataAdapter sda = new SqlDataAdapter("Select * From Payments Where id={currentId}", conn);
                SqlDataAdapter sda = new SqlDataAdapter(select, conn);
                DataSet Ds = new DataSet();
                sda.Fill(Ds, "T2");
                dataGridView2.DataSource = Ds.Tables["T2"];
            }
        }


        private void NovoItem()
        {
           
            this.entrada_Titulos_a_PagarBindingSource.AddNew();
            this.entrada_Titulos_a_PagarDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;    
        }

        public int Numero_Parcela { get; set; }
  
       

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            this.entrada_Titulos_a_PagarBindingSource.MoveLast();
           
            GetDetails();
            TryRefreshData();
            textBox_Fornecedor.Refresh();
            TryRefreshCustos();
            TexBoxNome_CentroCustos.Refresh();
            TryRefreshDespesa();
            descricao_Despesa_textBox.Refresh();
            TryRefreshStatusTitulo();
            Status_Titulo_Textbox.Refresh();
        }

        private void cod_FornecedorTextBox_TextChanged(object sender, EventArgs e)
        {
      //    TryRefreshData();
     //     entrada_Titulos_a_PagarDataGridView.CurrentRow.Cells[1].Value = cod_FornecedorTextBox1.Text;
            this.entrada_Titulos_a_PagarDataGridView.DataSource = entrada_Titulos_a_PagarBindingSource;
        }

        private void btn_fornecedores_Click_1(object sender, EventArgs e)
        {
            TelaFornecedores frm = new TelaFornecedores();
            frm.ShowDialog(this);
        }

        private void btn_status_titulo_Click_1(object sender, EventArgs e)
        {
            TelaStatusTitulo frm = new TelaStatusTitulo();
            frm.ShowDialog(this);
        }

        private void btn_Centro_Custos_Click_1(object sender, EventArgs e)
        {
            TelaCentroCustos frm = new TelaCentroCustos();
            frm.ShowDialog(this);
        }

        private void btn_codigo_despesas_Click_1(object sender, EventArgs e)
        {
            TelaCodigoDespesa frm = new TelaCodigoDespesa();
            frm.ShowDialog(this);
        }

      

        private void entrada_Titulos_a_PagarDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                GetDetails();
            }
        }

        private void btn_adicionar_parcela_Click_1(object sender, EventArgs e)
        {
            this.numero_Parcelas_a_PagarBindingSource.EndEdit();
            dataGridView2.Visible = true;
            groupBox_Parcelas.Visible = true;
            dataGridView2.AllowUserToAddRows = true;
            this.numero_Parcelas_a_PagarBindingSource.AddNew();
           
            // Aqui busco o último ID - Cod_Entrada_Titulos_a_Pagar da tabela Entrada_Titulos_a_Pagar utilizando uma expressão lambda e guardo na váriavel ultimoId
            var ultimoId = DataContextFactory.DataContext.Entrada_Titulos_a_Pagars.Max(x => x.Cod_Entrada_Titulos_a_Pagar);
            // Aqui coloco o valor do proximo id no TextBox - cod_Entrada_Titulos_a_PagarTextBox1
            cod_Entrada_Titulos_a_PagarTextBox2.Text = (ultimoId + 1).ToString();
            // Aqui passo o valor do ultimoID para a variável ultimoCodigoEntradaTP para ser inserida no DataGridView2
            ultimoCodigoEntradaTP = (ultimoId + 1);
            // Aqui coloco o valor do proximo id na linha do grid.
           // dataGridView2.CurrentRow.Cells[0].Value = ultimoCodigoEntradaTP;
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = ultimoId +1;
            numero_ParcelasTextBox1.Focus();
            //  numero_Parcelas_a_PagarBindingSource.DataSource = DataContextFactory.DataContext.numero_Parcelas_a_Pagars.Where(p => p.Cod_Entrada_Titulos_a_Pagar == int.Parse(cod_Entrada_Titulos_a_PagarTextBox.Text));
            _btnSalvar.Enabled = false;
            btn_adicionar_parcela.Enabled = false;
            btn_salvar_parcela.Enabled = true;
        }

        private void btn_salvar_parcela_Click_1(object sender, EventArgs e)
        {
            // Aqui coloco o valor do proximo id na linha do grid e os demais valores das caixas de texto.
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = cod_Entrada_Titulos_a_PagarTextBox2.Text;
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[1].Value = cod_Numero_Parcelas_a_PagarTextBox.Text.ToString();
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[2].Value = numero_ParcelaTextBox1.Text.ToString();
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[3].Value = data_VencimentoTextBox.Text.ToString();
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[4].Value = valor_ParcelaTextBox1.Text.ToString();
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[5].Value = historicoTextBox1.Text;
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[6].Value = cod_Status_TituloTextBox2.Text.ToString();
            this.dataGridView2.DataSource = numero_Parcelas_a_PagarBindingSource;
            _btnSalvar.Enabled = true;
            btn_adicionar_parcela.Enabled = true;
            btn_salvar_parcela.Enabled = false;

        //  this.numero_Parcelas_a_PagarBindingSource.AddNew();

        }

       

        private void cod_Status_TituloTextBox1_TextChanged(object sender, EventArgs e)
        {
            Status_Titulo_Textbox.Text = "";
            TryRefreshStatusTitulo();
     //     entrada_Titulos_a_PagarDataGridView.CurrentRow.Cells[12].Value = cod_Status_TituloTextBox1.Text;
            this.entrada_Titulos_a_PagarDataGridView.DataSource = entrada_Titulos_a_PagarBindingSource;
        }

        private void cod_DespesaTextBox_TextChanged(object sender, EventArgs e)
        {
            descricao_Despesa_textBox.Text = "";
            TryRefreshDespesa();
   //       entrada_Titulos_a_PagarDataGridView.CurrentRow.Cells[13].Value = cod_DespesaTextBox.Text;
            this.entrada_Titulos_a_PagarDataGridView.DataSource = entrada_Titulos_a_PagarBindingSource;

        }

        private void TextBox_Cod_CentroCustos_TextChanged(object sender, EventArgs e)
        {
            TexBoxNome_CentroCustos.Text = "";
             TryRefreshCustos();
       //    entrada_Titulos_a_PagarDataGridView.CurrentRow.Cells[11].Value = TextBox_Cod_CentroCustos.Text;
             this.entrada_Titulos_a_PagarDataGridView.DataSource = entrada_Titulos_a_PagarBindingSource;
        }

        private void entrada_Titulos_a_PagarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                cod_Entr_Tit_a_Pagartextbox.Text = entrada_Titulos_a_PagarDataGridView.CurrentRow.Cells[0].Value.ToString();
                ID = Convert.ToInt32(entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                cod_FornecedorTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                numero_DocumentoTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                data_DocumentoDateTimePicker.Value = Convert.ToDateTime(entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[3].Value);
                data_VencimentoDateTimePicker1.Value = Convert.ToDateTime(entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[4].Value);
                valor_TituloTextBox.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                valor_Pago_a_VistaTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                acrescimosTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                descontosTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                saldoTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                numero_ParcelasTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                TextBox_Cod_CentroCustos.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                cod_Status_TituloTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
                cod_DespesaTextBox.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
                historico_TituloTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[14].Value.ToString();
                observacaoTextBox1.Text = entrada_Titulos_a_PagarDataGridView.Rows[e.RowIndex].Cells[15].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
            data_logintxtbox.Text = DateTime.Now.ToString();
            data_logintxtbox.Refresh();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
          //  this.entrada_Titulos_a_PagarBindingSource.EndEdit();
          //  this.numero_Parcelas_a_PagarBindingSource.EndEdit();

            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
             

            if (cod_FornecedorTextBox1.Text != "" && TextBox_Cod_CentroCustos.Text != "" && cod_Status_TituloTextBox1.Text != "" && cod_DespesaTextBox.Text != "" && valor_TituloTextBox.Text != "")
            {
                try
                {

                    cmd = new SqlCommand("UPDATE Entrada_Titulos_a_Pagar SET Cod_Fornecedor=@Cod_Fornecedor, Numero_Documento=@Numero_Documento, Data_Documento=@Data_Documento, Data_Vencimento=@Data_Vencimento, Valor_Titulo=@Valor_Titulo, Valor_Pago_a_Vista=@Valor_Pago_a_Vista, Acrescimos=@Acrescimos, Descontos=@Descontos, Saldo=@Saldo, Numero_Parcelas=@Numero_Parcelas, Cod_Centro_Custos=@Cod_Centro_Custos, Cod_Status_Titulo=@Cod_Status_Titulo, Cod_Despesa=@Cod_Despesa, Historico_Titulo=@Historico_Titulo, Observacao=@Observacao, Data_Login=@Data_Login, Login_Name=@Login_Name WHERE Cod_Entrada_Titulos_a_Pagar=@Cod_Entrada_Titulos_a_Pagar", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Pagar", ID);
                    Int32 Cod_Fornecedor = Int32.Parse(cod_FornecedorTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Cod_Fornecedor", Cod_Fornecedor);
                    cmd.Parameters.AddWithValue("@Numero_Documento", numero_DocumentoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Data_Documento", data_DocumentoDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@Data_Vencimento", data_VencimentoDateTimePicker1.Value);
                    decimal valor_Titulo = decimal.Parse(valor_TituloTextBox.Text);
                    cmd.Parameters.AddWithValue("@Valor_Titulo", valor_Titulo);
                    decimal valor_Pago_a_Vista = decimal.Parse(valor_Pago_a_VistaTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", valor_Pago_a_Vista);
                    decimal Acrescimos = decimal.Parse(acrescimosTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Acrescimos", Acrescimos);
                    decimal Descontos = decimal.Parse(descontosTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Descontos", Descontos);
                    decimal Saldo = decimal.Parse(saldoTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Saldo", Saldo);
                    Int32 Numero_Parcelas = Int32.Parse(numero_ParcelasTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Numero_Parcelas", Numero_Parcelas);
                    Int32 Cod_Centro_Custos = Int32.Parse(TextBox_Cod_CentroCustos.Text);
                    cmd.Parameters.AddWithValue("@Cod_Centro_Custos", Cod_Centro_Custos);
                    Int32 Cod_Status_Titulo = Int32.Parse(cod_Status_TituloTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Cod_Status_Titulo", Cod_Status_Titulo);
                    Int32 Cod_Despesa = Int32.Parse(cod_DespesaTextBox.Text);
                    cmd.Parameters.AddWithValue("@Cod_Despesa", Cod_Despesa);
                    cmd.Parameters.AddWithValue("@Historico_Titulo", historico_TituloTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Observacao", observacaoTextBox1.Text);
                    DateTime dataagora = Convert.ToDateTime(data_logintxtbox.Text);
                    cmd.Parameters.AddWithValue("@Data_Login", dataagora);
                    cmd.Parameters.AddWithValue("@Login_Name", login_NameTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados do Título Contas a Pagar Atualizados com Sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro! " + Ex.Message);

                }
                finally
                {
                    conn.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Insira todos os Dados Requeridos!");
            }

      //      DataContextFactory.DataContext.SubmitChanges();
      //      this.entrada_Titulos_a_PagarDataGridView.DataSource = entrada_Titulos_a_PagarBindingSource;
    //        this.dataGridView2.DataSource = numero_Parcelas_a_PagarBindingSource;
   //         entrada_Titulos_a_PagarDataGridView.Refresh(); 


        }
    }
}
