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
using System.Globalization;

namespace SGFRenaissance
{
    public partial class Form_DRE_Exercicio : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        decimal TotalRevenues = 0;
        decimal TotalRevenues_Cod1 = 0;
        decimal TotalRevenues_Cod2 = 0;
        decimal TotalRevenues_Cod3 = 0;
        decimal totalCMV = 0;
        decimal ReceitaLiquida= 0;
        decimal totalTaxes = 0;
        decimal LucroBruto = 0;
        decimal TotalInternetTelefonia = 0;
        decimal TotalLight = 0;
        decimal TotalInternet_Light = 0;
        decimal TotalManutencaoAdm = 0;
        decimal TotalPapelaria = 0;
        decimal TotalManutencao_Papelaria = 0;
        decimal TotalTaxasAdm = 0;
        decimal TotalCombustivelProducao = 0;
        decimal TotalManutencaoVeiculoProducao = 0;
        decimal TotalEventosVendasMarketing = 0;
        decimal TotalManutencaoEquipProd = 0;
        decimal PercentualLB = 0;
        decimal TotalcomissionsPaid = 0;
        decimal TotalJurosMultasEmprestimos = 0;
        decimal TotalFolhaPagamentoPessoal = 0;
        decimal RentTotal = 0;
        decimal ResultadoTotalExercicio = 0;
      
        public Form_DRE_Exercicio()
        {
            InitializeComponent();
        }
        // Alterar strConn com novo servidor
        // Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True

        void SelectRentFromTable()
        {
            try
            {
               
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 9 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalValorPago = sqlComm.ExecuteScalar();
                if (TotalValorPago != DBNull.Value)
                {
                    RentTotal = Convert.ToDecimal(TotalValorPago);
                    textBoxRent.Text = Convert.ToString(TotalValorPago);
                    textBoxRent.Text = Convert.ToDouble(textBoxRent.Text).ToString("N2");
                }
                else
                {
                    textBoxRent.Text = "0,00";
                }
                sqlConnection.Close();


            }
            catch  (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);

            }
        }

        void SelectCMV()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 12 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalValorCMV = sqlComm.ExecuteScalar();
                if (TotalValorCMV != DBNull.Value)
                {
                    totalCMV = Convert.ToDecimal(TotalValorCMV);
                    textboxCMV.Text = Convert.ToString(TotalValorCMV);
                    textboxCMV.Text = Convert.ToDouble(textboxCMV.Text).ToString("N2");
                }
                else
                {
                    textboxCMV.Text = "0,00";
                }
                
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalInvoices_Cod_1()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Recebido) from Base_Parcelas_Recebidas where (Cod_Receita = 1) and Data_Recebimento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalRevenues = sqlComm.ExecuteScalar();
                if (TotalRevenues != DBNull.Value)
                {
                    TotalRevenues = Convert.ToDecimal(TotalRevenues);
                    TotalRevenues_Cod1 = Convert.ToDecimal(TotalRevenues);
                    txtboxReceita_1.Text = Convert.ToString(TotalRevenues);
                    txtboxReceita_1.Text = Convert.ToDouble(txtboxReceita_1.Text).ToString("N2");
                    txtboxReceita_1.Visible = false;
                }
                else
                {
                    txtboxReceita_1.Text = "0,00";
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalInvoices_Cod_2()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Recebido) from Base_Parcelas_Recebidas where (Cod_Receita = 2) and Data_Recebimento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalRevenues_Cod_2 = sqlComm.ExecuteScalar();
                if (TotalRevenues_Cod_2 != DBNull.Value)
                {
                    TotalRevenues_Cod_2 = Convert.ToDecimal(TotalRevenues_Cod_2);
                    TotalRevenues_Cod2 = Convert.ToDecimal(TotalRevenues_Cod_2);
                    txtboxReceita_2.Text = Convert.ToString(TotalRevenues_Cod_2);
                    txtboxReceita_2.Text = Convert.ToDouble(txtboxReceita_2.Text).ToString("N2");
                    txtboxReceita_2.Visible = false;
                }
                else
                {
                    txtboxReceita_2.Text = "0,00";
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }


        void SelectTotalInvoices_Cod_3()
        {

            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Recebido) from Base_Parcelas_Recebidas where (Cod_Receita = 3) and Data_Recebimento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalRevenues_Cod_3 = sqlComm.ExecuteScalar();
                if (TotalRevenues_Cod_3 != DBNull.Value)
                {
                    TotalRevenues_Cod_3 = Convert.ToDecimal(TotalRevenues_Cod_3);
                    TotalRevenues_Cod3 = Convert.ToDecimal(TotalRevenues_Cod_3);
                    txtboxReceita_3.Text = Convert.ToString(TotalRevenues_Cod_3);
                    txtboxReceita_3.Text = Convert.ToDouble(txtboxReceita_3.Text).ToString("N2");
                    txtboxReceita_3.Visible = false;

                }
                else
                {
                    txtboxReceita_3.Text = "0,00";
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }


        }

        void SelectTotalImpostos()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 8 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalImpostos = sqlComm.ExecuteScalar();
                if (TotalImpostos != DBNull.Value)
                {
                    TotalImpostos = Convert.ToDecimal(TotalImpostos);
                    totalTaxes = Convert.ToDecimal(TotalImpostos);
                    txtBox_Impostos.Text = Convert.ToString(TotalImpostos);
                    txtBox_Impostos.Text = Convert.ToDouble(txtBox_Impostos.Text).ToString("N2");
                }
                else
                {
                    txtBox_Impostos.Text = "0,00";
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalInternet_Telefonia()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 2 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var TotalInternet = sqlComm.ExecuteScalar();
                if (TotalInternet != DBNull.Value)
                {
                    TotalInternet = Convert.ToDecimal(TotalInternet);
                    TotalInternetTelefonia = Convert.ToDecimal(TotalInternet);
                }
                else
                {
                    TotalInternetTelefonia = 0;
                }

                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalLight()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 5 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totallight = sqlComm.ExecuteScalar();
                if (totallight != DBNull.Value)
                {
                    totallight = Convert.ToDecimal(totallight);
                    TotalLight = Convert.ToDecimal(totallight);
                }
                else
                {
                    TotalLight = 0;
                }
                TotalInternet_Light = TotalInternetTelefonia + TotalLight;
                txtBox_Internet_Light.Text = Convert.ToString(TotalInternet_Light);
                txtBox_Internet_Light.Text = Convert.ToDouble(txtBox_Internet_Light.Text).ToString("N2");
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }

        }

        void SelectTotalManutencaoEquipAdm()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 9 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totalmanutencao = sqlComm.ExecuteScalar();
                if (totalmanutencao != DBNull.Value)
                {
                    totalmanutencao = Convert.ToDecimal(totalmanutencao);
                    TotalManutencaoAdm = Convert.ToDecimal(totalmanutencao);
                }
                else
                {
                    TotalManutencaoAdm = 0;
                }
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalPapelaria()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 4 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var somapapelaria = sqlComm.ExecuteScalar();
                if (somapapelaria != DBNull.Value)
                {
                    somapapelaria = Convert.ToDecimal(somapapelaria);
                    TotalPapelaria = Convert.ToDecimal(somapapelaria);
                }
                else
                {
                    TotalPapelaria = 0;
                }
                TotalManutencao_Papelaria = TotalManutencaoAdm + TotalPapelaria;
                txtbox_Manut_Equipamentos.Text = Convert.ToString(TotalManutencao_Papelaria);
                txtbox_Manut_Equipamentos.Text = Convert.ToDouble(txtbox_Manut_Equipamentos.Text).ToString("N2");
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalTaxasAdm()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 11 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totaltaxasadmconsultoria = sqlComm.ExecuteScalar();
                if (totaltaxasadmconsultoria != DBNull.Value)
                {
                    totaltaxasadmconsultoria = Convert.ToDecimal(totaltaxasadmconsultoria);
                    TotalTaxasAdm = Convert.ToDecimal(totaltaxasadmconsultoria);
                }
                else
                {
                    TotalTaxasAdm = 0;
                }
                txtboxTaxasAdm.Text = Convert.ToString(TotalTaxasAdm);
                txtboxTaxasAdm.Text = Convert.ToDouble(txtboxTaxasAdm.Text).ToString("N2");
                sqlConnection.Close();
                }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalCombustívelProducao()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 3 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totalcombustProducao = sqlComm.ExecuteScalar();
                if (totalcombustProducao != DBNull.Value)
                {
                    totalcombustProducao = Convert.ToDecimal(totalcombustProducao);
                    TotalCombustivelProducao = Convert.ToDecimal(totalcombustProducao);
                }
                else
                {
                    TotalCombustivelProducao = 0;
                }
                txtBox_Combustivel.Text = Convert.ToString(TotalCombustivelProducao);
                txtBox_Combustivel.Text = Convert.ToDouble(txtBox_Combustivel.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalManutencaoVeiculoProducao()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 6 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var manutencaoTotalveiculoProd = sqlComm.ExecuteScalar();
                if (manutencaoTotalveiculoProd != DBNull.Value)
                {
                    manutencaoTotalveiculoProd = Convert.ToDecimal(manutencaoTotalveiculoProd);
                    TotalManutencaoVeiculoProducao = Convert.ToDecimal(manutencaoTotalveiculoProd);
                }
                else
                {
                    TotalManutencaoVeiculoProducao = 0;
                }
                txtBoxManut_veiculo.Text = Convert.ToString(TotalManutencaoVeiculoProducao);
                txtBoxManut_veiculo.Text = Convert.ToDouble(txtBoxManut_veiculo.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalEventosVendasMarketing()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 7 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totaleventosvendas = sqlComm.ExecuteScalar();
                if (totaleventosvendas != DBNull.Value)
                {
                    totaleventosvendas = Convert.ToDecimal(totaleventosvendas);
                    TotalEventosVendasMarketing = Convert.ToDecimal(totaleventosvendas);
                }
                else
                {
                    TotalEventosVendasMarketing = 0;
                }
                txtBoxEventos_Vendas.Text = Convert.ToString(TotalEventosVendasMarketing);
                txtBoxEventos_Vendas.Text = Convert.ToDouble(txtBoxEventos_Vendas.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalManutEquipProducao()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("select SUM(Valor_Pago) from Base_Parcelas_Pagas where Cod_Despesa = 10 and Data_Pagamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totalmanutequipproducao = sqlComm.ExecuteScalar();
                if (totalmanutequipproducao != DBNull.Value)
                {
                    totalmanutequipproducao = Convert.ToDecimal(totalmanutequipproducao);
                    TotalManutencaoEquipProd = Convert.ToDecimal(totalmanutequipproducao);
                }
                else
                {
                    TotalManutencaoEquipProd = 0;
                }
                txtBoxEquipam_Producao.Text = Convert.ToString(TotalManutencaoEquipProd);
                txtBoxEquipam_Producao.Text = Convert.ToDouble(txtBoxEquipam_Producao.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalComissoesVenda()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("Select SUM(Valor_Movimento) from Lancamentos Where (Cod_Operacao = 8) and Data_Lancamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var totalcomissoespagas = sqlComm.ExecuteScalar();
                if (totalcomissoespagas != DBNull.Value)
                {
                    totalcomissoespagas = Convert.ToDecimal(totalcomissoespagas);
                    TotalcomissionsPaid = Convert.ToDecimal(totalcomissoespagas);
                }
                else
                {
                    TotalcomissionsPaid = 0;
                }
                txtBox_Comissions.Text = Convert.ToString(TotalcomissionsPaid);
                txtBox_Comissions.Text = Convert.ToDouble(txtBox_Comissions.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalJurosMultasEmprestimos()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("Select SUM(Valor_Movimento) from Lancamentos Where (Cod_Operacao = 5) and Data_Lancamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var jurosmultasemprestimos = sqlComm.ExecuteScalar();
                if (jurosmultasemprestimos != DBNull.Value)
                {
                    jurosmultasemprestimos = Convert.ToDecimal(jurosmultasemprestimos);
                    TotalJurosMultasEmprestimos = Convert.ToDecimal(jurosmultasemprestimos);
                }
                else
                {
                    TotalJurosMultasEmprestimos = 0;
                }
                txtBox_Juros_Multas.Text = Convert.ToString(TotalJurosMultasEmprestimos);
                txtBox_Juros_Multas.Text = Convert.ToDouble(txtBox_Juros_Multas.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }

        void SelectTotalFolhaPagamentoPessoal()
        {
            try
            {
                String StrConn;
                StrConn = @"Data Source=DESKTOP-CHNLG1O;Initial Catalog=SGFRenaissance;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                string sql = string.Format("Select SUM(Valor_Movimento) from Lancamentos Where (Cod_Operacao = 7) and Data_Lancamento Between @inicialdate and @finaldate");
                SqlCommand sqlComm = new SqlCommand(sql, sqlConnection);

                DateTime dateinicial = Convert.ToDateTime(dtpInicio.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@inicialdate", dateinicial);

                DateTime datefinal = Convert.ToDateTime(dtpFinal.Value.ToShortDateString());
                sqlComm.Parameters.AddWithValue("@finaldate", datefinal);

                var FolhapagamentoPessoal = sqlComm.ExecuteScalar();
                if (FolhapagamentoPessoal != DBNull.Value)
                {
                    FolhapagamentoPessoal = Convert.ToDecimal(FolhapagamentoPessoal);
                    TotalFolhaPagamentoPessoal = Convert.ToDecimal(FolhapagamentoPessoal);
                }
                else
                {
                    TotalFolhaPagamentoPessoal = 0;
                }
                txtBoxFolhaPagamento.Text = Convert.ToString(TotalFolhaPagamentoPessoal);
                txtBoxFolhaPagamento.Text = Convert.ToDouble(txtBoxFolhaPagamento.Text).ToString("N2");
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!" + Ex.Message);
            }
        }


        private void button_execute_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            SelectRentFromTable();
            SelectCMV();
            SelectTotalInvoices_Cod_1();
            SelectTotalInvoices_Cod_2();
            SelectTotalInvoices_Cod_3();
            TotalRevenues = TotalRevenues_Cod1 + TotalRevenues_Cod2 + TotalRevenues_Cod3;
            txtbox_Receita_Vendas.Text = Convert.ToString(TotalRevenues);
            txtbox_Receita_Vendas.Text = Convert.ToDouble(txtbox_Receita_Vendas.Text).ToString("N2");
            SelectTotalImpostos();
            ReceitaLiquida = TotalRevenues - totalTaxes;
            txtBox_Receita_Liquida.Text = Convert.ToString(ReceitaLiquida);
            txtBox_Receita_Liquida.Text = Convert.ToDouble(txtBox_Receita_Liquida.Text).ToString("N2");
            LucroBruto = ReceitaLiquida - totalCMV;
            txtBox_Lucro_Bruto.Text = Convert.ToString(LucroBruto);
            txtBox_Lucro_Bruto.Text = Convert.ToDouble(txtBox_Lucro_Bruto.Text).ToString("N2");
         // Converter para percentual - Label LucroBruto.
            PercentualLB = (LucroBruto / TotalRevenues);
            labelLucroBruto.Text = Convert.ToString(PercentualLB);
            labelLucroBruto.Text = Convert.ToDouble(labelLucroBruto.Text).ToString("P", CultureInfo.InvariantCulture);
         // Fim da Conversão
            SelectTotalInternet_Telefonia();
            SelectTotalLight();
            SelectTotalManutencaoEquipAdm();
            SelectTotalPapelaria();
            SelectTotalTaxasAdm();
            SelectTotalCombustívelProducao();
            SelectTotalManutencaoVeiculoProducao();
            SelectTotalEventosVendasMarketing();
            SelectTotalManutEquipProducao();
            SelectTotalComissoesVenda();
            SelectTotalJurosMultasEmprestimos();
            SelectTotalFolhaPagamentoPessoal();
            ResultadoTotalExercicio = (LucroBruto) - (RentTotal + TotalInternet_Light + TotalManutencao_Papelaria + TotalTaxasAdm + TotalFolhaPagamentoPessoal + TotalCombustivelProducao + TotalManutencaoVeiculoProducao + TotalEventosVendasMarketing + TotalManutencaoEquipProd + TotalcomissionsPaid + TotalJurosMultasEmprestimos);
            txtBoxResultadoExercicio.Text = Convert.ToString(ResultadoTotalExercicio);
            txtBoxResultadoExercicio.Text = Convert.ToDouble(txtBoxResultadoExercicio.Text).ToString("N2");

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpInicio.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.CustomFormat = "dd/MM/yyyy";
        }

        private void Form_DRE_Exercicio_Load(object sender, EventArgs e)
        {
            dtpInicio.CustomFormat = null;
            dtpFinal.CustomFormat = null;
            dtpInicio.CustomFormat = "   ";
            dtpFinal.CustomFormat = "   ";
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btn_Execute_Test_Click(object sender, EventArgs e)
        {
            /*
            var sumtotal = (from a in context.Base_Parcelas_Pagas
                            where a.Cod_Despesa == 9
                            && a.Data_Pagamento >= dtpInicio.Value
                            && a.Data_Pagamento <= dtpFinal.Value
                            select a).Sum(a.Valor_Pago);
           */
        }
    }
}
