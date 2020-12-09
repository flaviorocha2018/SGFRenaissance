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

namespace SGFRenaissance
{
    public partial class TelaFornedor_Relatorio_Tit_Aberto : Form
    {

        string connString = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
        SqlConnection objConnection = null;
        SqlCommand objCommand = null;
        string stringSQL;
       
        public TelaFornedor_Relatorio_Tit_Aberto()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void GetData()
        {
            stringSQL = "SELECT Cod_Fornecedor, Nome_Fornecedor FROM Fornecedor_Contas_a_Pagar";
            objConnection = new SqlConnection(connString);
            objCommand = new SqlCommand(stringSQL, objConnection);
            try
            {
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand); // passa para o SelectCommand e a string de conexão
                DataTable dtLista = new DataTable(); // um novo objeto datatable  
                dtLista.Locale = System.Globalization.CultureInfo.InvariantCulture;
                objAdapter.Fill(dtLista);   // preenche a tabela.
                dGView_Fornecedor.DataSource = dtLista;
               

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não foi possível preencher o Grid com os dados dos Fornecedores" + ex.Message); // mostrar uma mensagem ao usuário em caso de exceção.
            }
        }

        public void configuradGView_Fornecedor()
        {
            dGView_Fornecedor.Columns[0].HeaderText = "Código Fornec.";
            dGView_Fornecedor.Columns[1].HeaderText = "Nome Fornecedor";
            dGView_Fornecedor.Columns[0].Width = 80;
            dGView_Fornecedor.Columns[1].Width = 308;
            dGView_Fornecedor.Font = new Font("arial", 10);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            dGView_Fornecedor.Columns.Add(buttonColumn);
            buttonColumn.Text = "Selecionar";
            buttonColumn.Name = "Selecionar";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.HeaderText = "Selecionar";
            dGView_Fornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
       //     dGView_Fornecedor.AutoResizeColumns();
       //     dGView_Fornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void TelaFornedor_Relatorio_Tit_Aberto_Load(object sender, EventArgs e)
        {
            GetData();
            configuradGView_Fornecedor();
        }

        private void dGView_Fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ((Frm_Rel_Titulos_a_Pagar_em_Aberto)Owner).textbox_codFornecedor.Text = dGView_Fornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
