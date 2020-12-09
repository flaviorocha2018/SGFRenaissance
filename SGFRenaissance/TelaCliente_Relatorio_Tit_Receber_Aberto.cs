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
    
    public partial class TelaCliente_Relatorio_Tit_Receber_Aberto : Form
    {
        string connString = @"Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True";
        SqlConnection objConnection = null;
        SqlCommand objCommand = null;
        string stringSQL;


        public TelaCliente_Relatorio_Tit_Receber_Aberto()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void GetData()
        {
            stringSQL = "SELECT Cod_Cliente_Contas_a_Receber, Nome_Cliente FROM Clientes_Contas_a_Receber";
            objConnection = new SqlConnection(connString);
            objCommand = new SqlCommand(stringSQL, objConnection);
            try
            {
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand); // passa para o SelectCommand e a string de conexão
                DataTable dtLista = new DataTable(); // um novo objeto datatable  
                dtLista.Locale = System.Globalization.CultureInfo.InvariantCulture;
                objAdapter.Fill(dtLista);   // preenche a tabela.
                dGView_Clientes.DataSource = dtLista;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não foi possível preencher o Grid com os dados dos Fornecedores" + ex.Message); // mostrar uma mensagem ao usuário em caso de exceção.
            }
        }

        public void ConfiguradGView_Clientes()
        {
            dGView_Clientes.Columns[0].HeaderText = "Código Cliente.";
            dGView_Clientes.Columns[1].HeaderText = "Nome Cliente";
            dGView_Clientes.Columns[0].Width = 80;
            dGView_Clientes.Columns[1].Width = 308;
            dGView_Clientes.Font = new Font("arial", 10);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            dGView_Clientes.Columns.Add(buttonColumn);
            buttonColumn.Text = "Selecionar";
            buttonColumn.Name = "Selecionar";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.HeaderText = "Selecionar";
            dGView_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

         // dGView_Fornecedor.AutoResizeColumns();
         // dGView_Fornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dGView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ((Report_TitulosaReceberemAberto)Owner).textBoxCodCliente.Text = dGView_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                Close();
            }
        }

        private void TelaCliente_Relatorio_Tit_Receber_Aberto_Load(object sender, EventArgs e)
        {
            GetData();
            ConfiguradGView_Clientes();
        }
    }
}
