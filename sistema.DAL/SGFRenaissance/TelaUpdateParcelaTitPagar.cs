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

namespace SGFRenaissance
{
    public partial class TelaUpdateParcelaTitPagar : Form
    {
       private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
       private SqlCommand cmd;
       private SqlDataAdapter objAdapter;
       Int32 IDParcela = 0;

        public TelaUpdateParcelaTitPagar()
        {
            InitializeComponent();
        }

        private void ExibirDadosParcela()
        {
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Numero_Parcelas_a_Pagar", conn);
                DataSet Ds = new DataSet();
                DataTable DT = new DataTable();
                Ds.Tables.Add(DT);
                sda.Fill(DT);
                //(Ds, "T1");
                numero_Parcelas_a_PagarDataGridView.DataSource = DT;
                // Ds.Tables["T1"];
                data_VencimentoDateTimePicker.CustomFormat = null;
                data_VencimentoDateTimePicker.Value.ToShortDateString();
                textBox1.Focus();
            }
        }
        private void LimparDados()
        {
            cod_Entrada_Titulos_a_PagarTextBox.Text = string.Empty;
            cod_Numero_Parcelas_a_PagarTextBox.Text = string.Empty;
            numero_ParcelaTextBox.Text = string.Empty;
            data_VencimentoDateTimePicker.CustomFormat = "   ";
            valor_ParcelaTextBox.Text = string.Empty;
            historicoTextBox.Text = string.Empty;
            cod_Status_TituloTextBox.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
      

        private void TelaUpdateParcelaTitPagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGFRenaissanceDataSet2.Numero_Parcelas_a_Pagar' table. You can move, or remove it, as needed.
       //   this.numero_Parcelas_a_PagarTableAdapter1.FillByTabelaCompleta(this.numeroParcelasaPagarDGV.Numero_Parcelas_a_Pagar);
               
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Numero_Parcelas_a_Pagar", conn);
                DataSet Ds = new DataSet();
                DataTable DT = new DataTable();
                Ds.Tables.Add(DT);
                sda.Fill(DT);
               //(Ds, "T1");
                numero_Parcelas_a_PagarDataGridView.DataSource = DT;
                // Ds.Tables["T1"];   
                data_VencimentoDateTimePicker.Value.ToShortDateString();
                textBox1.Focus();
            }
            //  Carregar formulários com os campos inabilitados
            cod_Entrada_Titulos_a_PagarTextBox.Enabled = false;
            cod_Numero_Parcelas_a_PagarTextBox.Enabled = false;
            numero_ParcelaTextBox.Enabled = false;
            data_VencimentoDateTimePicker.Enabled = false;
            valor_ParcelaTextBox.Enabled = false;
            historicoTextBox.Enabled = false;
            cod_Status_TituloTextBox.Enabled = false;

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
        //  Código UPDATE NÃO ESTÁ FUNCIONANDO.
        /*
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))

                if (cod_Entrada_Titulos_a_PagarTextBox.Text != "" && cod_Numero_Parcelas_a_PagarTextBox.Text != "" && cod_Status_TituloTextBox.Text != "" && numero_ParcelaTextBox.Text != "" && data_VencimentoDateTimePicker.Text != "" && valor_ParcelaTextBox.Text != "")
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE numero_Parcelas_a_Pagar SET Cod_Entrada_Titulos_a_Pagar=@Cod_Entrada_Titulos_a_Pagar, Numero_Parcela=@Numero_Parcela, Data_Vencimento=@Data_Vencimento, Valor_Parcela=@Valor_Parcela, Historico=@Historico, Cod_Status_Titulo=@Cod_Status_Titulo WHERE Cod_Numero_Parcelas_a_Pagar=@Cod_Numero_Parcelas_a_Pagar", conn);
                        conn.Open();
                   //   Passando os parâmetros para o UPDATE
                        cmd.Parameters.AddWithValue("@Cod_Numero_Parcelas_a_Pagar", IDParcela);
                        Int32 Cod_EntradaTitaPagar = Int32.Parse(cod_Entrada_Titulos_a_PagarTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Entrada_Titulos_a_Pagar", Cod_EntradaTitaPagar);
                        Int32 NumeroParcela = Int32.Parse(numero_ParcelaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Numero_Parcela",NumeroParcela);
                        cmd.Parameters.AddWithValue("@Data_Vencimento", data_VencimentoDateTimePicker.Value);
                        decimal valorParcela = decimal.Parse(valor_ParcelaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Valor_Parcela", valorParcela);
                        Int32 CodStatusTitulo = Int32.Parse(cod_Status_TituloTextBox.Text);
                        cmd.Parameters.AddWithValue("@Cod_Status_Titulo", CodStatusTitulo);
                        cmd.Parameters.AddWithValue("@Historico", historicoTextBox.Text);
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Show! Dados da Parcela Atualizados com Sucesso!" + result.ToString() + "linha atualizada!" );
                    }
                    catch (System.Exception Ex)
                    {
                        MessageBox.Show("Erro! Falha ao Atualizar! " + Ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ExibirDadosParcela();
                        LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("Informe todos os Dados Necessários para Atualizar a Parcela!");
                }
        */
        //  Código UPDATE anterior 
        
            try
            {
                this.numero_Parcelas_a_PagarBindingSource.EndEdit();
                this.numero_Parcelas_a_PagarTableAdapter.Update(this.numeroParcelasaPagarUpdate.Numero_Parcelas_a_Pagar);

                MessageBox.Show("Dados da Parcela Atualizados com Sucesso!"); 
            }
            catch (System.Exception Ex)
            {
                MessageBox.Show("Erro! Falha ao Atualizar! " + Ex.Message);
            }
            finally
            {
                ExibirDadosParcela();
                LimparDados();
                cod_Entrada_Titulos_a_PagarTextBox.Enabled = false;
                cod_Numero_Parcelas_a_PagarTextBox.Enabled = false;
                numero_ParcelaTextBox.Enabled = false;
                data_VencimentoDateTimePicker.Enabled = false;
                valor_ParcelaTextBox.Enabled = false;
                historicoTextBox.Enabled = false;
                cod_Status_TituloTextBox.Enabled = false;
            }
         
        }

        private void numero_Parcelas_a_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.numero_Parcelas_a_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.numeroParcelasaPagarUpdate);

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            int numeroparcela = Convert.ToInt32(textBox1.Text); 
            this.numero_Parcelas_a_PagarTableAdapter.FillFiltroParcela(numeroParcelasaPagarUpdate.Numero_Parcelas_a_Pagar, numeroparcela);
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
            data_VencimentoDateTimePicker.CustomFormat = null;
            data_VencimentoDateTimePicker.Value.ToShortDateString();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = String.Format("SELECT Cod_Numero_Parcelas_a_Pagar, Cod_Entrada_Titulos_a_Pagar, Numero_Parcela, Data_Vencimento, Valor_Parcela, Historico, Cod_Status_Titulo"
                                + " FROM Numero_Parcelas_a_Pagar"
                                + " WHERE(Cod_Numero_Parcelas_a_Pagar LIKE '{0}')", numeroparcela);
                DataTable DT = new DataTable();
               
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataAdapter objAdapter = new SqlDataAdapter(sql, conn);
                        objAdapter.Fill(DT);
                        numero_Parcelas_a_PagarDataGridView.DataSource = DT;
                        // Ativar os campos Textboxes
                        if (numero_Parcelas_a_PagarDataGridView.RowCount == 0)
                        { 
                            MessageBox.Show("Não foi encontrado nenhuma parcela!");
                            numero_ParcelaTextBox.Enabled = false;
                            data_VencimentoDateTimePicker.Enabled = false;
                            valor_ParcelaTextBox.Enabled = false;
                            historicoTextBox.Enabled = false;
                            cod_Status_TituloTextBox.Enabled = false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Falha na Abertura da Conexão ao Banco de Dados!", "Erro!");
                    }
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Falha na Leitura dos Dados na Tabela! " + Ex.Message);
                }
               
                finally
                {
                    conn.Close();
                }
                numero_ParcelaTextBox.Enabled = true;
                data_VencimentoDateTimePicker.Enabled = true;
                valor_ParcelaTextBox.Enabled = true;
                historicoTextBox.Enabled = true;
                cod_Status_TituloTextBox.Enabled = true;
            }
        }

        private void btn_limparconsulta_Click(object sender, EventArgs e)
        {
            LimparDados();
            ExibirDadosParcela();
        }

      
    }
}
