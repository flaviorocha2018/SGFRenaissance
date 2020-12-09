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
using sistema.DAL;


namespace SGFRenaissance
{
    public partial class EntradaTitulosaReceber : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adapt2;
        Int32 ID = 0;
        Int32 IDparcela = 0;
        private DateTime Data_Agora;
        
        public EntradaTitulosaReceber()
        {
            InitializeComponent();
            ExibirDadosTitulo();
            ExibirDadosParcela();
            entrada_Titulos_a_ReceberDataGridView.AllowUserToAddRows = false;
            numero_Parcelas_a_ReceberDataGridView.AllowUserToAddRows = false;
            int currentIndex;
            int flag = -1;
        }

        private void load()
        {
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            this.entrada_Titulos_a_ReceberDataGridView.DataSource = null;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Entrada_Titulos_a_Receber", conn);
                DataSet Ds = new DataSet();
                sda.Fill(Ds, "T1");
                entrada_Titulos_a_ReceberDataGridView.DataSource = Ds.Tables["T1"];

            }
        }
        
   
  

        void TryRefreshCliente()
        {
            try
            {
               
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Nome_Cliente from Clientes_Contas_a_Receber where Cod_Cliente_Contas_a_Receber='{0}'", cod_ClienteTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {

                    nome_ClienteTextBox.Refresh();
                    nome_ClienteTextBox.Text = reader["Nome_Cliente"].ToString();
                    nome_ClienteTextBox.Refresh();

                }

                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
               MessageBox.Show("Erro! " + Ex);
            }
        }

        void TryRefreshTipoReceita()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select  Descricao_Receita from Tipos_Receita where Codigo_Tipo_Receita ='{0}'", Cod_ReceitaTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    DescricaoReceita.Text = reader["Descricao_Receita"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro! "+Ex);
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
                string sql = string.Format("select  Descricao_Status from Status_Titulos_a_Receber where Codigo_Status_Tit_a_Receber ='{0}'", Cod_StatusTextBox.Text);
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    descricaoStatusTitulo.Text = reader["Descricao_Status"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro! " + Ex);
            }
        }

        private void ExibirDadosTitulo()
        {
            try
            {
                conn.Open();
                DataTable Dt = new DataTable();
                adapt = new SqlDataAdapter("Select * from Entrada_Titulos_a_Receber", conn);
                adapt.Fill(Dt);
                entrada_Titulos_a_ReceberDataGridView.DataSource = Dt;
                entrada_Titulos_a_ReceberDataGridView.DataSource = entrada_Titulos_a_ReceberBindingSource;
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
                adapt = new SqlDataAdapter("Select * from Numero_Parcelas_a_Receber", conn);
                adapt.Fill(Dt);
                numero_Parcelas_a_ReceberDataGridView.DataSource = Dt;
                numero_Parcelas_a_ReceberDataGridView.DataSource = numero_Parcelas_a_ReceberBindingSource;
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

        private void btn_Fornecedor_Click(object sender, EventArgs e)
        {
            TelaClientes frm = new TelaClientes();
            frm.ShowDialog();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.entrada_Titulos_a_ReceberBindingSource.EndEdit();
            this.numero_Parcelas_a_ReceberBindingSource.EndEdit();
            this.Close();
        }
        int currentIndex;
        int flag = -1;
        private void Entrada_Titulos_a_Receber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entrada_Titulos_a_Receber._Entrada_Titulos_a_Receber' table. You can move, or remove it, as needed.
            this.entrada_Titulos_a_ReceberTableAdapter1.Fill(this.entrada_Titulos_a_Receber._Entrada_Titulos_a_Receber);
            //   Desabilitar os botões no Form_Load
            btn_excluir.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Inserir_Titulo.Enabled = false;
            btn_gravarParcela.Enabled = false;
            btn_salvarParcela.Enabled = false;
            btn_InserirParcela.Enabled = false;
            btn_Pesquisar.Enabled = true;
            btn_novo.Enabled = true;
            btn_Fechar.Enabled = true;
            btn_proximo.Enabled = true;
            btn_Voltar.Enabled = true;

            // TODO: This line of code loads data into the 'entradaTitulosaReceberDGV.Entrada_Titulos_a_Receber' table. You can move, or remove it, as needed.
           //  this.entrada_Titulos_a_ReceberTableAdapter.Fill(this.entradaTitulosaReceberDGV.Entrada_Titulos_a_Receber);  
            // TODO: This line of code loads data into the 'numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber' table. You can move, or remove it, as needed.
            // this.numero_Parcelas_a_ReceberTableAdapter.Fill(this.numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber); 
           // this.entrada_Titulos_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Entrada_Titulos_a_Recebers;
              this.clientes_Contas_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Clientes_Contas_a_Recebers;
          //  this.numero_Parcelas_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Numero_Parcelas_a_Recebers;
              this.status_Titulos_a_ReceberBindingSource.DataSource = DataContextFactory.DataContext.Status_Titulos_a_Recebers;
              this.tipos_ReceitaBindingSource.DataSource = DataContextFactory.DataContext.Tipos_Receitas;
              TryRefreshCliente();
              TryRefreshTipoReceita();
              TryRefreshStatusTitulo();
              inabilitardados_Titulo();
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Entrada_Titulos_a_Receber", conn);
                DataSet Ds = new DataSet();
                sda.Fill(Ds, "T1");
                entrada_Titulos_a_ReceberDataGridView.DataSource = Ds.Tables["T1"];
             
            }
            // Bind the "SelectionChanged" here
            entrada_Titulos_a_ReceberDataGridView.SelectionChanged += entrada_Titulos_a_ReceberDataGridView_SelectionChanged;
            GetDetails();


        }

        void GetDetails()
        {
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            int currentId;
            int index = entrada_Titulos_a_ReceberDataGridView.CurrentCell.RowIndex;
            currentId = Convert.ToInt32(entrada_Titulos_a_ReceberDataGridView.Rows[index].Cells["Cod_Id"].Value);
            using (SqlConnection conn = new SqlConnection(constr))
            {
                if(cod_Entrada_Titulos_a_ReceberTextBox.Text != null)
                {
                    var select = "Select * From Numero_Parcelas_a_Receber Where Cod_Entrada_Titulos_a_Receber =" + currentId;
                    SqlDataAdapter sda = new SqlDataAdapter(select, conn);
                    DataSet Ds = new DataSet();
                    sda.Fill(Ds, "T2");
                    numero_Parcelas_a_ReceberDataGridView.DataSource = Ds.Tables["T2"];
                }
                else
                {
                    MessageBox.Show("Não é Possível navegar sem Parcelas! Exclua o Título!");
                }
                
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
         // Fazer nova Tela e pesquisar título para atualizar - Igual ao Atualizar Parcela do Títulos a pagar.
                Data_Agora = DateTime.Now;
                Data_Agora.Date.ToString("ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
                data_logintxtbox.Text = DateTime.Now.ToString();
                data_logintxtbox.Refresh();
                login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
                data_logintxtbox.Text = Data_Agora.ToShortDateString();
         //     this.entrada_Titulos_a_ReceberTableAdapter.Update(this.entradaTitulosaReceberDGV.Entrada_Titulos_a_Receber);
         //     MessageBox.Show("Dados do Título Atualizados com Sucesso!");
            
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                ID = Convert.ToInt32(cod_Entrada_Titulos_a_ReceberTextBox.Text);
                var Select = "SELECT Cod_Entrada_Titulos_a_Receber, Cod_Cliente, Numero_NF, Data_NF, Valor_NF, Cod_Receita, Data_Vencimento, Numero_Parcelas, Valor_Pago_a_Vista, Cod_Status_Titulo, Codigo_CV, Historico, Data_Login, Login_Name FROM Entrada_Titulos_a_Receber";
                SqlDataAdapter SDA = new SqlDataAdapter(Select,conn);
                DataSet DS1 = new DataSet();
                SDA.Fill(DS1, "Entrada_Titulos_a_Receber");
                SqlCommandBuilder Builder = new SqlCommandBuilder();
                Builder.DataAdapter = SDA;

                if (cod_Entrada_Titulos_a_ReceberTextBox.Text != "" && cod_ClienteTextBox.Text != "" && Cod_ReceitaTextBox.Text != "" && Cod_StatusTextBox.Text != "" && numero_ParcelasTextBox.Text != "" && data_VencimentoDateTimePicker.Text != "" && dateTimePicker_NF.Text != "" && numero_NFTextBox.Text != "" && valor_Pago_a_VistaTextBox.Text != "" && valor_NFTextBox.Text != "" && textBox_CV.Text != "")
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Entrada_Titulos_a_Receber SET Cod_Cliente=@Cod_Cliente, Numero_NF=@Numero_NF, Data_NF=@Data_NF, Valor_NF=@Valor_NF, Cod_Receita=@Cod_Receita, Data_Vencimento=@Data_Vencimento, Numero_Parcelas=@Numero_Parcelas, Valor_Pago_a_Vista=@Valor_Pago_a_Vista, Cod_Status_Titulo=@Cod_Status_Titulo, Codigo_CV=@Codigo_CV, Historico=@Historico, Data_Login=@Data_Login, Login_Name=@Login_Name  WHERE Cod_Entrada_Titulos_a_Receber=@Cod_Entrada_Titulos_a_Receber", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Receber", ID);
                        Int32 Cod_Cliente = Int32.Parse(cod_ClienteTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);
                        cmd.Parameters.AddWithValue("@Numero_NF", numero_NFTextBox.Text);
                        cmd.Parameters.AddWithValue("@Data_NF", dateTimePicker_NF.Value);
                        decimal valor_NF = decimal.Parse(valor_NFTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_NF", valor_NF);
                        Int32 Cod_Receita = Int32.Parse(Cod_ReceitaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Receita", Cod_Receita);
                        cmd.Parameters.AddWithValue("@Data_Vencimento", data_VencimentoDateTimePicker.Value);
                        Int32 Numero_Parcelas = Int32.Parse(numero_ParcelasTextBox.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcelas", Numero_Parcelas);
                        decimal valor_Pago_a_Vista = decimal.Parse(valor_Pago_a_VistaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", valor_Pago_a_Vista);
                        Int32 Cod_StatusTitulo = Int32.Parse(Cod_StatusTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Status_Titulo", Cod_StatusTitulo);
                        Int32 Cod_CV = Int32.Parse(textBox_CV.Text);
                        cmd.Parameters.AddWithValue("@Codigo_CV", Cod_CV);
                        cmd.Parameters.AddWithValue("@Historico", historicoTextBox.Text);
                        Data_Agora = Convert.ToDateTime(data_logintxtbox.Text);
                        cmd.Parameters.AddWithValue("@Data_Login", Data_Agora);
                        cmd.Parameters.AddWithValue("@Login_Name", login_NameTextBox.Text);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Show! Dados do Título Atualizados com Sucesso! " + result.ToString()+ " Registro Atualizado!");
                       
                        SDA.Fill(this.entrada_Titulos_a_Receber._Entrada_Titulos_a_Receber);
                   //   entrada_Titulos_a_ReceberTableAdapter1.Fill(this.entrada_Titulos_a_Receber._Entrada_Titulos_a_Receber);
                        entrada_Titulos_a_ReceberDataGridView.DataSource = this.entrada_Titulos_a_ReceberBindingSource;
                        this.entrada_Titulos_a_ReceberBindingSource.MoveLast();
                     //   Selecionar a última linha do DataGridView

                //        this.entrada_Titulos_a_ReceberDataGridView.Rows[this.entrada_Titulos_a_ReceberDataGridView.Rows.Count - 1].DataGridView.ForeColor = Color.Red;
                   
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! Falha ao Tentar salvar o Registro! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ExibirDadosTitulo();
                        ExibirDadosParcela();
                        btn_Salvar.Enabled = false;
                //      LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("Informe todos os Dados Necessários para Atualizar o Título!");
                }
              
            }

                 int currentIndex;
                 int flag = -1;
        }

       private void btn_proximo_Click(object sender, EventArgs e)
        {
            btn_excluir.Enabled = true;
            // Check the index, and move the focus
            int currentIndex;
            currentIndex = entrada_Titulos_a_ReceberDataGridView.CurrentRow.Index;
            if (currentIndex < entrada_Titulos_a_ReceberDataGridView.Rows.Count - 1)
            {
                entrada_Titulos_a_ReceberDataGridView.CurrentCell = entrada_Titulos_a_ReceberDataGridView.Rows[currentIndex + 1].Cells[0];
                entrada_Titulos_a_ReceberDataGridView.CurrentCell.Selected = false;
                flag *= -1;
                entrada_Titulos_a_ReceberDataGridView.Rows[currentIndex + 1].Cells[0].Selected = true;
                this.entrada_Titulos_a_ReceberDataGridView.DataSource = this.entrada_Titulos_a_ReceberBindingSource;
                // Passar os valores do DataGridView para os Textboxes
                if (cod_Entrada_Titulos_a_ReceberTextBox1 != null)
                {
                    try
                    {
                        cod_Entrada_Titulos_a_ReceberTextBox1.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[2].Value.ToString();
                        cod_Numero_Parcelas_ReceberTextBox.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[0].Value.ToString();
                        numero_ParcelaTextBox.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[1].Value.ToString();
                        data_VencimentoDateTimePicker1.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[3].Value.ToString();
                        ValorParcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[4].Value.ToString();
                        historicoTextBox1.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[5].Value.ToString();
                        cod_Status_TituloParcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[6].Value.ToString();
                        // Atualizar nomes nos TextBoxes 
                        TryRefreshCliente();
                        TryRefreshTipoReceita();
                        TryRefreshStatusTitulo();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro! Não é Possível Navegar nos Registros sem as Parcelas, Exclua o Título!");
                    }

                }
                else
                {
                    if (cod_Entrada_Titulos_a_ReceberTextBox.Text != cod_Entrada_Titulos_a_ReceberTextBox1.Text)
                        MessageBox.Show("Erro!, não é possivel navegar nos Registros sem as Parcelas, Exclua o Título!");
                    btn_proximo.Enabled = false;

                }
            }
           
        }

       private void btn_novo_Click(object sender, EventArgs e)
       {
            habilitardados_Titulo();
            cod_Entrada_Titulos_a_ReceberTextBox.Text = string.Empty;
            nome_ClienteTextBox.Text = string.Empty;
            cod_ClienteTextBox.Text = string.Empty;
            Cod_ReceitaTextBox.Text = string.Empty;
            Cod_StatusTextBox.Text = string.Empty;
            numero_NFTextBox.Text = string.Empty;
            numero_ParcelasTextBox.Text = string.Empty;
            data_VencimentoDateTimePicker.CustomFormat = "   ";
            data_VencimentoDateTimePicker.Enabled = true;
            numero_NFTextBox.Text = string.Empty;
            valor_NFTextBox.Text = string.Empty;
            DescricaoReceita.Text = string.Empty;
            descricaoStatusTitulo.Text = string.Empty;
            valor_Pago_a_VistaTextBox.Text = string.Empty;
            dateTimePicker_NF.CustomFormat = "   ";
            dateTimePicker_NF.Enabled = true;
            historicoTextBox.Text = string.Empty;
            textBox_CV.Text = string.Empty;
            login_NameTextBox.Text = string.Empty;
            data_logintxtbox.Text = string.Empty;
            //   Limpara Textboxes de Inserir Parcelas
            cod_Entrada_Titulos_a_ReceberTextBox1.Text = string.Empty;
            cod_Numero_Parcelas_ReceberTextBox.Text = string.Empty;
            numero_ParcelaTextBox.Text = string.Empty;
            data_VencimentoDateTimePicker1.Text = string.Empty;
            data_VencimentoDateTimePicker1.CustomFormat = "   ";
            ValorParcela.Text = string.Empty;
            cod_Status_TituloParcela.Text = string.Empty;
            historicoTextBox1.Text = string.Empty;
            // Desabilitar campos da Parcela
            cod_Entrada_Titulos_a_ReceberTextBox1.Enabled = false;
            cod_Numero_Parcelas_ReceberTextBox.Enabled = false;
            numero_ParcelaTextBox.Enabled = false;
            data_VencimentoDateTimePicker1.Enabled = false;
            ValorParcela.Enabled = false;
            cod_Status_TituloParcela.Enabled = false;
            historicoTextBox1.Enabled = false;

            // Ativar e desativar botões
            btn_Salvar.Enabled = false;
            btn_proximo.Enabled = false;
            btn_Voltar.Enabled = false;
            btn_novo.Enabled = false;
            btn_excluir.Enabled = false;
            btn_Pesquisar.Enabled = false;
            btn_Inserir_Titulo.Enabled = true;
            btn_Inserir_Titulo.BackColor = Color.Orange;
            btn_Inserir_Titulo.ForeColor = Color.DarkBlue;
            btn_Fechar.Enabled = true;
            btn_salvarParcela.Enabled = false;
           
       }

       private void btn_Voltar_Click(object sender, EventArgs e)
       {
            // Check the index, and move the focus
            int currentIndex;
            currentIndex = entrada_Titulos_a_ReceberDataGridView.CurrentCell.RowIndex;
            if (currentIndex > 0)
            {
                entrada_Titulos_a_ReceberDataGridView.CurrentCell = entrada_Titulos_a_ReceberDataGridView.Rows[currentIndex - 1].Cells[0];
                entrada_Titulos_a_ReceberDataGridView.CurrentCell.Selected = false;
                flag *= -1;
                entrada_Titulos_a_ReceberDataGridView.Rows[currentIndex - 1].Cells[0].Selected = true;
                this.entrada_Titulos_a_ReceberDataGridView.DataSource = this.entrada_Titulos_a_ReceberBindingSource;
                // Passar os valores do DataGridView Parcela para os Textboxes
                cod_Entrada_Titulos_a_ReceberTextBox1.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[2].Value.ToString();
                cod_Numero_Parcelas_ReceberTextBox.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[0].Value.ToString();

                numero_ParcelaTextBox.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[1].Value.ToString();
                data_VencimentoDateTimePicker1.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[3].Value.ToString();
                ValorParcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[4].Value.ToString();
                historicoTextBox1.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[5].Value.ToString();
                cod_Status_TituloParcela.Text = numero_Parcelas_a_ReceberDataGridView.CurrentRow.Cells[6].Value.ToString();
                TryRefreshCliente();
                TryRefreshTipoReceita();
                TryRefreshStatusTitulo();
            }

            TryRefreshCliente();


            
       }

       private void btn_InserirParcela_Click(object sender, EventArgs e)
       {
       
            this.numero_Parcelas_a_ReceberBindingSource.EndEdit();
            cod_Entrada_Titulos_a_ReceberTextBox1.Text = string.Empty;
            cod_Numero_Parcelas_ReceberTextBox.Text = string.Empty;
            numero_ParcelaTextBox.Text = string.Empty;
            data_VencimentoDateTimePicker1.CustomFormat = "   ";
            ValorParcela.Text = string.Empty;
            cod_Status_TituloParcela.Text = string.Empty;
            historicoTextBox1.Text = string.Empty;
            // Habilitar os campos textboxes
            cod_Entrada_Titulos_a_ReceberTextBox1.Enabled = true;
            cod_Numero_Parcelas_ReceberTextBox.Enabled = true;
            numero_ParcelaTextBox.Enabled = true;
            data_VencimentoDateTimePicker1.Enabled = true;
            ValorParcela.Enabled = true;
            cod_Status_TituloParcela.Enabled = true;
            historicoTextBox1.Enabled = true;
        
            // Aqui busco o último ID - Cod_Entrada_Titulos_a_Receber da tabela Entrada_Titulos_a_Receber utilizando uma expressão lambda e guardo na váriavel ultimoId
            int ultimoId = DataContextFactory.DataContext.Entrada_Titulos_a_Recebers.Max(x => x.Cod_Entrada_Titulos_a_Receber);

            cod_Entrada_Titulos_a_ReceberTextBox1.Text = Convert.ToString(ultimoId);

            cod_Entrada_Titulos_a_ReceberTextBox.Text = Convert.ToString(ultimoId);
            
            numero_ParcelaTextBox.Focus();
            btn_Salvar.Enabled = false;
            btn_InserirParcela.Enabled = false;
            btn_salvarParcela.Enabled = true;
            btn_gravarParcela.Enabled = false;
            btn_Fechar.Enabled = false;
            btn_proximo.Enabled = false;
            btn_Voltar.Enabled = false;
            btn_Pesquisar.Enabled = false;
            btn_Inserir_Titulo.Enabled = false;

       }

       private void btn_Clientes_Click_1(object sender, EventArgs e)
       {
           TelaClientes frm = new TelaClientes() { Owner = this };
            frm.ShowDialog(this);
       }

      

       private void btnReceita_Click(object sender, EventArgs e)
       {
           TelaTipoReceita frm = new TelaTipoReceita() { Owner = this };
            frm.ShowDialog(this);
       }

       private void btn_StatusTitulo_Click(object sender, EventArgs e)
       {
           TelaStatusTituloReceber frm = new TelaStatusTituloReceber() { Owner = this };
            frm.ShowDialog(this);

       }

       private void btn_Status_Parcela_Click(object sender, EventArgs e)
       {
           TelaStatusTituloReceber frm = new TelaStatusTituloReceber() { Owner = this };
            frm.ShowDialog(this);

       }

        private void entrada_Titulos_a_ReceberDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                GetDetails();
            }
        }

      

        private void entrada_Titulos_a_ReceberDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cod_Entrada_Titulos_a_ReceberTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                cod_ClienteTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                numero_NFTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker_NF.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                valor_NFTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Cod_ReceitaTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                data_VencimentoDateTimePicker.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                numero_ParcelasTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                valor_Pago_a_VistaTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                Cod_StatusTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBox_CV.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                historicoTextBox.Text = entrada_Titulos_a_ReceberDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                btn_Salvar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Não foi possível transferir os dados do DataGridView!" + ex.Message);
            }

        }

        private void btn_Inserir_Titulo_Click(object sender, EventArgs e)
        {
            Data_Agora = DateTime.Now;
            Data_Agora.Date.ToString("ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
            data_logintxtbox.Text = DateTime.Now.ToString();
          
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            data_logintxtbox.Text = Data_Agora.ToShortDateString();
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))

                if (cod_ClienteTextBox.Text !="" && Cod_ReceitaTextBox.Text != "" && Cod_StatusTextBox.Text != "" && numero_ParcelasTextBox.Text != "" && data_VencimentoDateTimePicker.Text != "" && dateTimePicker_NF.Text != "" && numero_NFTextBox.Text != "" && valor_Pago_a_VistaTextBox.Text != "" && valor_NFTextBox.Text != ""  && textBox_CV.Text != "")
                {
                    try
                    {
                        cmd = new SqlCommand(string.Concat(
                 "INSERT INTO Entrada_Titulos_a_Receber(Cod_Cliente, Numero_NF, Data_NF, Valor_NF, Cod_Receita, Data_Vencimento, Numero_Parcelas, ",
                 "Valor_Pago_a_Vista, Cod_Status_Titulo, Codigo_CV, Historico, Data_Login, Login_Name) ",
                 "VALUES(@Cod_Cliente, @Numero_NF, @Data_NF, @Valor_NF, @Cod_Receita, @Data_Vencimento, @Numero_Parcelas, ",
                 "@Valor_Pago_a_Vista, @Cod_Status_Titulo, @Codigo_CV, @Historico, @Data_Login, @Login_Name)"), conn);

                        conn.Open();
                        Int32 Cod_Cliente = Int32.Parse(cod_ClienteTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Cliente", Cod_Cliente);
                        cmd.Parameters.AddWithValue("@Numero_NF", numero_NFTextBox.Text);
                        DateTime DataNF = Convert.ToDateTime(dateTimePicker_NF.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@Data_NF", DataNF);
                        decimal valor_NF = decimal.Parse(valor_NFTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_NF", valor_NF);
                        Int32 Cod_Receita = Int32.Parse(Cod_ReceitaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Receita", Cod_Receita);
                        cmd.Parameters.AddWithValue("@Data_Vencimento", data_VencimentoDateTimePicker.Value);
                        Int32 Numero_Parcelas = Int32.Parse(numero_ParcelasTextBox.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcelas", Numero_Parcelas);
                        decimal valor_Pago_a_Vista = decimal.Parse(valor_Pago_a_VistaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_Pago_a_Vista", valor_Pago_a_Vista);
                        Int32 Cod_StatusTitulo = Int32.Parse(Cod_StatusTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Status_Titulo", Cod_StatusTitulo);
                        Int32 Cod_CV = Int32.Parse(textBox_CV.Text);
                        cmd.Parameters.AddWithValue("@Codigo_CV", Cod_CV);
                        cmd.Parameters.AddWithValue("@Historico", historicoTextBox.Text);
                        Data_Agora = Convert.ToDateTime(data_logintxtbox.Text);
                        cmd.Parameters.AddWithValue("@Data_Login", Data_Agora);
                        cmd.Parameters.AddWithValue("@Login_Name", login_NameTextBox.Text);
                        Int32 result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Show! Dados do Título Inseridos com Sucesso!" +result.ToString() +" Registro Inserido!");
                        // entrada_Titulos_a_ReceberTableAdapter.Fill(entradaTitulosaReceberDGV.Entrada_Titulos_a_Receber);
                        // entrada_Titulos_a_ReceberDataGridView.DataSource = entrada_Titulos_a_ReceberBindingSource;
                        // entrada_Titulos_a_ReceberBindingSource.MoveLast();
                        // pegar o último valor inserido na tabela do código Título a receber e passar para a parcela a receber.
                        int ultimoId = DataContextFactory.DataContext.Entrada_Titulos_a_Recebers.Max(x => x.Cod_Entrada_Titulos_a_Receber);
                        cod_Entrada_Titulos_a_ReceberTextBox.Text = Convert.ToString(ultimoId);
                        cod_Entrada_Titulos_a_ReceberTextBox.Refresh();
                        // Selecionar a última linha do DataGridView


                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! Falha ao Tentar Inserir o Registro! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        load();
                        ExibirDadosParcela();
                        btn_InserirParcela.Enabled = true;
                        btn_Inserir_Titulo.Enabled = false;
                //      LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("Informe todos os Dados Necessários para Inserir o Título!");
                }
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cod_Entrada_Titulos_a_ReceberTextBox.Text);
            if (cod_Entrada_Titulos_a_ReceberTextBox.Text != null)
            {
                if (numero_Parcelas_a_ReceberDataGridView.RowCount == 0)
                {
                    if (MessageBox.Show("Deseja deletar este Título ?", "Cadastro de Títulos a Receber", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            cmd = new SqlCommand("DELETE Entrada_Titulos_a_Receber WHERE Cod_Entrada_Titulos_a_Receber= @Cod_Entrada_Titulos_a_Receber", conn);
                            conn.Open();
                            cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Receber", ID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Título Excluído com Sucesso...!");
                            this.entrada_Titulos_a_ReceberBindingSource.MoveFirst();
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
                            //     LimparDados();
                        }


                    }

                }
                else
                {
                    MessageBox.Show("É necessário Excluir todas as Parcelas antes de Deletar o Título!");
                }

            }

        }

        private void numero_Parcelas_a_ReceberDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Deseja Excluir esta Parcela?", "Número de Parcelas do Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int IDParcela = Convert.ToInt32(cod_Numero_Parcelas_ReceberTextBox.Text);
                            cmd = new SqlCommand("DELETE Numero_Parcelas_a_Receber WHERE Cod_Numero_Parcelas_Receber = @Cod_Numero_Parcelas_Receber", conn);
                            conn.Open();
                            cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_Receber", IDParcela);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parcela do Título Excluída com Sucesso!");
                            numero_Parcelas_a_ReceberDataGridView.Rows.Remove(numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex]);
                            //  Atualizar o DataGridView Parcelas
                            this.numero_Parcelas_a_ReceberTableAdapter.Fill(numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);
                            this.numero_Parcelas_a_ReceberBindingSource.MoveFirst();
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

        private void data_VencimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            data_VencimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker_NF_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_NF.CustomFormat = "dd/MM/yyyy";
        }

        private void data_VencimentoDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data_VencimentoDateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void data_VencimentoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                data_VencimentoDateTimePicker.CustomFormat = "   ";
            }
        }

        private void dateTimePicker_NF_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePicker_NF.CustomFormat = "   ";
            }
        }

        private void data_VencimentoDateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                data_VencimentoDateTimePicker1.CustomFormat = "   ";
            }
        }

        private void btn_salvarParcela_Click_1(object sender, EventArgs e)
        {
            if (cod_Entrada_Titulos_a_ReceberTextBox1.Text != "" && numero_ParcelaTextBox.Text != "" && data_VencimentoDateTimePicker1.Text != "" && ValorParcela.Text != "")
            {
                // Aqui busca o valor da Textbox da Entrada do Titulo a receber
                int CodIDEntrTitReceber = 0;
        
                CodIDEntrTitReceber = Convert.ToInt32(cod_Entrada_Titulos_a_ReceberTextBox1.Text);
               

                try
                {
                    cmd = new SqlCommand(string.Concat("INSERT INTO Numero_Parcelas_a_Receber (Cod_Entrada_Titulos_a_Receber, Numero_Parcela, Data_Vencimento, Valor_Parcela, Historico, Cod_Status_Titulo)",
                         " VALUES(@Cod_Entrada_Titulos_a_Receber, @Numero_Parcela, @Data_Vencimento, @Valor_Parcela, @Historico, @Cod_Status_Titulo)"), conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Receber", CodIDEntrTitReceber);
                    Int32 NumeroParcela = Convert.ToInt32(numero_ParcelaTextBox.Text);
                    cmd.Parameters.AddWithValue("@Numero_Parcela", NumeroParcela);
                    DateTime DataVencimento = Convert.ToDateTime(data_VencimentoDateTimePicker1.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Data_Vencimento", DataVencimento);
                    decimal Valor_Parcela = Convert.ToDecimal(ValorParcela.Text);
                    cmd.Parameters.AddWithValue("@Valor_Parcela", Valor_Parcela);
                    string Historico = historicoTextBox1.Text;
                    cmd.Parameters.AddWithValue("@Historico", Historico);
                    Int32 CodStatusParcela = Convert.ToInt32(cod_Status_TituloParcela.Text);
                    cmd.Parameters.AddWithValue("@Cod_Status_Titulo", CodStatusParcela);
                    Int32 result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados da Parcela Inseridos com Sucesso! " + result.ToString() + " Registro Inserido!");
                    this.numero_Parcelas_a_ReceberTableAdapter.Fill(numeroParcelasaReceberDGV.Numero_Parcelas_a_Receber);
                    this.numero_Parcelas_a_ReceberBindingSource.MoveLast();
                    btn_InserirParcela.Enabled = true;
                    btn_Fechar.Enabled = true;
                    btn_novo.Enabled = true;
                    btn_proximo.Enabled = false;
                    btn_Voltar.Enabled = false;
                    btn_Pesquisar.Enabled = false;
                    btn_excluir.Enabled = false;
                    btn_Salvar.Enabled = false;
                    btn_Inserir_Titulo.Enabled = false;
                    btn_salvarParcela.Enabled = false;
                    // Limpar Dados Parcela
                    cod_Entrada_Titulos_a_ReceberTextBox1.Text = string.Empty;
                    cod_Numero_Parcelas_ReceberTextBox.Text = string.Empty;
                    numero_ParcelaTextBox.Text = string.Empty;
                    data_VencimentoDateTimePicker1.CustomFormat = "   ";
                    ValorParcela.Text = string.Empty;
                    cod_Status_TituloParcela.Text = string.Empty;
                    descricaostatusparcela.Text = string.Empty;
                    historicoTextBox1.Text = string.Empty;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro! ao Inserir Parcela! " + Ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
               MessageBox.Show("Informe Todos os Dados Para Inserir a Parcela!");
            }
            
        }

        private void btn_gravarParcela_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                ID = Convert.ToInt32(cod_Numero_Parcelas_ReceberTextBox.Text);
            // Parei aqui Agora
                var Select = "SELECT Cod_Entrada_Titulos_a_Receber, Cod_Numero_Parcelas_Receber, Numero_Parcela, Data_Vencimento, Valor_Parcela, Historico, Cod_Status_Titulo  FROM Numero_Parcelas_a_Receber";
                SqlDataAdapter SDA = new SqlDataAdapter(Select, conn);
                DataSet DS1 = new DataSet();
                SDA.Fill(DS1, "Numero_Parcelas_a_Receber");
                SqlCommandBuilder Builder = new SqlCommandBuilder();
                Builder.DataAdapter = SDA;

                if (cod_Entrada_Titulos_a_ReceberTextBox1.Text != "" && cod_Numero_Parcelas_ReceberTextBox.Text != "" && numero_ParcelaTextBox.Text != "" && data_VencimentoDateTimePicker1.Text != "" && numero_ParcelasTextBox.Text != "" && data_VencimentoDateTimePicker.Text != "" && ValorParcela.Text != "" )
                {
                    try
                    {
                        
                        cmd = new SqlCommand("UPDATE Numero_Parcelas_a_Receber SET Cod_Entrada_Titulos_a_Receber=@Cod_Entrada_Titulos_a_Receber, Numero_Parcela=@Numero_Parcela, Data_Vencimento=@Data_Vencimento, Valor_Parcela=@Valor_Parcela, Historico=@Historico, Cod_Status_Titulo=@Cod_Status_Titulo  WHERE Cod_Numero_Parcelas_Receber=@Cod_Numero_Parcelas_Receber", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_Receber", ID);
                        Int32 CodEntradaTitReceber = Int32.Parse(cod_Entrada_Titulos_a_ReceberTextBox1.Text);
                        cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Receber", CodEntradaTitReceber);
                        Int32 NumeroParcela = Int32.Parse(numero_ParcelaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcela", NumeroParcela);
                        DateTime datavencimento = Convert.ToDateTime(data_VencimentoDateTimePicker1.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@Data_Vencimento", datavencimento);
                        decimal valorParcela = decimal.Parse(ValorParcela.Text);
                        cmd.Parameters.AddWithValue("@Valor_Parcela", valorParcela);
                        cmd.Parameters.AddWithValue("@Historico", historicoTextBox1.Text);
                        Int32 CodStatusParcela = Int32.Parse(cod_Status_TituloParcela.Text);
                        cmd.Parameters.AddWithValue("@Cod_Status_Titulo", CodStatusParcela);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Show! Dados da Parcela Atualizados com Sucesso! " + result.ToString() + " Registro Atualizado!");
                        // Limpar Dados Parcela
                        cod_Entrada_Titulos_a_ReceberTextBox1.Text = string.Empty;
                        cod_Numero_Parcelas_ReceberTextBox.Text = string.Empty;
                        numero_ParcelaTextBox.Text = string.Empty;
                        data_VencimentoDateTimePicker1.CustomFormat = "   ";
                        ValorParcela.Text = string.Empty;
                        cod_Status_TituloParcela.Text = string.Empty;
                        historicoTextBox1.Text = string.Empty;

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erro! Falha ao Tentar atualizar o Registro! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ExibirDadosTitulo();
                        ExibirDadosParcela();
                        btn_gravarParcela.Enabled = false;
                        btn_InserirParcela.Enabled = true;
                        //      LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("Informe todos os Dados Necessários para Atualizar o Título!");
                }
            }
        }
        private void numero_Parcelas_a_ReceberDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cod_Entrada_Titulos_a_ReceberTextBox1.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                cod_Numero_Parcelas_ReceberTextBox.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                numero_ParcelaTextBox.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                data_VencimentoDateTimePicker1.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                ValorParcela.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                historicoTextBox1.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                cod_Status_TituloParcela.Text = numero_Parcelas_a_ReceberDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                btn_InserirParcela.Enabled = true;
                btn_gravarParcela.Enabled = true;
                btn_salvarParcela.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Não foi possível transferir os dados do DataGridView!" + ex.Message);
            }
        }

        private void inabilitardados_Titulo()
        {
            try
            {
                cod_Entrada_Titulos_a_ReceberTextBox.Enabled = false;
                cod_ClienteTextBox.Enabled = false;
                nome_ClienteTextBox.Enabled = false;
                Cod_ReceitaTextBox.Enabled = false;
                DescricaoReceita.Enabled = false;
                Cod_StatusTextBox.Enabled = false;
                descricaoStatusTitulo.Enabled = false;
                numero_ParcelasTextBox.Enabled = false;
                data_VencimentoDateTimePicker.Enabled = false;
                numero_NFTextBox.Enabled = false;
                valor_NFTextBox.Enabled = false;
                valor_Pago_a_VistaTextBox.Enabled = false;
                dateTimePicker_NF.Enabled = false;
                historicoTextBox.Enabled = false;
                textBox_CV.Enabled = false;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro! Não foi possível Inabilitar Dados do Formulário! " + Ex.Message);
            }


        }

        private void habilitardados_Titulo()
        {
            try
            {
                cod_Entrada_Titulos_a_ReceberTextBox.Enabled = true;
                cod_ClienteTextBox.Enabled = true;
                nome_ClienteTextBox.Enabled = true;
                Cod_ReceitaTextBox.Enabled = true;
                DescricaoReceita.Enabled = true;
                Cod_StatusTextBox.Enabled = true;
                descricaoStatusTitulo.Enabled = true;
                numero_ParcelasTextBox.Enabled = true;
                data_VencimentoDateTimePicker.Enabled = true;
                numero_NFTextBox.Enabled = true;
                valor_NFTextBox.Enabled = true;
                valor_Pago_a_VistaTextBox.Enabled = true;
                dateTimePicker_NF.Enabled = true;
                historicoTextBox.Enabled = true;
                textBox_CV.Enabled = true;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro! Não foi possível Habilitar Dados do Formulário! " + Ex.Message);
            }

        }

    }
    
}
