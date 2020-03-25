using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFRenaissance
{
    public partial class PesquisarFornecedor : Form
    {
        public PesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGFRenaissanceDataSet1.Fornecedor_Contas_a_Pagar' table. You can move, or remove it, as needed.
            this.fornecedor_Contas_a_PagarTableAdapter.Fill(this.sGFRenaissanceDataSet1.Fornecedor_Contas_a_Pagar);
            textBox1.Focus();
            cod_FornecedorTextBox.Text = string.Empty;
            nome_FornecedorTextBox.Text = string.Empty;
            bairroTextBox.Text = string.Empty;
            cidadeTextBox.Text = string.Empty;
            enderecoTextBox.Text = string.Empty;
            cEPTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            cNPJTextBox.Text = string.Empty;
            inscricao_EstadualTextBox.Text = string.Empty;
            data_CadastroTextBox.Text = string.Empty;
            identificacaoTextBox.Text = string.Empty;
            telefone_1TextBox.Text = string.Empty;
            telefone_2TextBox.Text = string.Empty;
            cod_FornecedorTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            celularTextBox.Text = string.Empty;
            cod_Status_FornecedorComboBox.Text = string.Empty;


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarTableAdapter.Fill(this.sGFRenaissanceDataSet1.Fornecedor_Contas_a_Pagar);
            this.fornecedor_Contas_a_PagarTableAdapter.FillByNome_Fornecedor(this.sGFRenaissanceDataSet1.Fornecedor_Contas_a_Pagar, "%" + textBox1.Text + "%");
        }

        private void fornecedor_Contas_a_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         //   this.Validate();
         //   this.fornecedor_Contas_a_PagarBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.sGFRenaissanceDataSet1);

        }

        private void btn_LimparConsulta_Click(object sender, EventArgs e)
        {
            this.fornecedor_Contas_a_PagarTableAdapter.Fill(this.sGFRenaissanceDataSet1.Fornecedor_Contas_a_Pagar);
            textBox1.Text = string.Empty;
            cod_FornecedorTextBox.Text = string.Empty;
            nome_FornecedorTextBox.Text = string.Empty;
            bairroTextBox.Text = string.Empty;
            cidadeTextBox.Text = string.Empty;
            enderecoTextBox.Text = string.Empty;
            cEPTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            cNPJTextBox.Text = string.Empty;
            inscricao_EstadualTextBox.Text = string.Empty;
            data_CadastroTextBox.Text = string.Empty;
            identificacaoTextBox.Text = string.Empty;
            telefone_1TextBox.Text = string.Empty;
            telefone_2TextBox.Text = string.Empty;
            cod_FornecedorTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            celularTextBox.Text = string.Empty;
            cod_Status_FornecedorComboBox.Text = string.Empty;
            textBox1.Focus();

        }

       
    }
}
