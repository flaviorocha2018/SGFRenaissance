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
    public partial class TelaBancoRel_Lancamentos : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        
      

        public TelaBancoRel_Lancamentos()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void Data_Grid_Configuration()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
           
            DataGridViewHeaderCell novo_titulo = new DataGridViewHeaderCell();

            //  Alterar a fonte no DataGridView
            dGV_Bancos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dGV_Bancos.DefaultCellStyle.ForeColor = Color.Navy;
            dGV_Bancos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        

            //Renomeia os cabeçalhos das Colunas do DGV
            dGV_Bancos.Columns[0].HeaderText = "Código Banco";
            dGV_Bancos.Columns[1].HeaderText = "Nome Banco";
            dGV_Bancos.Columns.Add(buttonColumn);
            dGV_Bancos.Columns[2].HeaderText = "Selecionar";
            dGV_Bancos.Columns[0].Name = "Cod_banco";
            
        //  Adicionando o título no botão Selecionar
            dGV_Bancos.Rows[0].Cells[2].Value = "Selecionar";
            dGV_Bancos.Rows[1].Cells[2].Value = "Selecionar";
            // Configura o tamanho das colunas
            dGV_Bancos.Columns[0].Width = 90;
            dGV_Bancos.Columns[1].Width = 298;
            dGV_Bancos.Columns[2].Width = 120;
            dGV_Bancos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_Bancos.GridColor = SystemColors.ControlDark;
            dGV_Bancos.BackgroundColor = Color.DimGray;

                 
        }

        private void TelaBancoRel_Lancamentos_Load(object sender, EventArgs e)
        {
            
            string constr = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
           
            String Select_Bancos = @"Select Cod_Banco, Nome_Banco From Bancos";
            cmd = new SqlCommand(Select_Bancos, conn);
       
            using (SqlConnection conn = new SqlConnection(constr))
            {
            
                try
                {
                    conn.Open();

                    if ( conn.State == ConnectionState.Open)
                    {
                        SqlDataAdapter Adapter_Bancos = new SqlDataAdapter(cmd);
                        DataTable DT_Bancos = new DataTable();
                        Adapter_Bancos.Fill(DT_Bancos);
                        dGV_Bancos.DataSource = DT_Bancos;
                        Data_Grid_Configuration();

                    }
                    else
                    {
                        MessageBox.Show("Fallha na Conexão ao Banco!", "Erro!");
                    }
                }
                catch
                {
                    MessageBox.Show("Falha na Leitura de Dados no Banco!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
       
            }
        }

        private void dGV_Bancos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Passar o código do Banco para a Caixa de Texto no Formulário do Relatório
            ((Form_Relatorio_Lancamentos)Owner).textBox1.Text = dGV_Bancos.Rows[e.RowIndex].Cells["Cod_banco"].Value.ToString();
            this.Close();
        }
    }
}
