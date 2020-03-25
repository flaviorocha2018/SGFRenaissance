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
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }

        public static class dados_Clientes
        {
        //    public static string nome_cliente;
        //    public static int cod_cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clientes_Contas_a_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         //   this.Validate();
         //   this.clientes_Contas_a_ReceberBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.sGFRenaissanceDataSet);

        }

        private void PesquisarCliente_Load(object sender, EventArgs e)
        {
           
            this.clientes_Contas_a_ReceberTableAdapter.Fill(this.sGFRenaissanceDataSet.Clientes_Contas_a_Receber);
            cod_Cliente_Contas_a_ReceberTextBox.Text = "";
            nome_ClienteTextBox.Text = "";
            endereço_ClienteTextBox.Text = "";
            bairro_ClienteTextBox.Text = "";
            municipio_ClienteTextBox.Text = "";
            estadoTextBox.Text = "";
            telefoneTextBox.Text = "";
            celularTextBox.Text = "";
            emailTextBox.Text = "";
            statusTextBox.Text = "";
            identificacaoTextBox.Text = "";
            cNPJTextBox.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.clientes_Contas_a_ReceberTableAdapter.Fill(this.sGFRenaissanceDataSet.Clientes_Contas_a_Receber);
          this.clientes_Contas_a_ReceberTableAdapter.FillByNome_Cliente(this.sGFRenaissanceDataSet.Clientes_Contas_a_Receber, "%" + textBox1.Text + "%");
        //    dados_Clientes.nome_cliente = nome_ClienteTextBox.Text;
          //  Convert.ToString(this.cod_Cliente_Contas_a_ReceberTextBox);
         //   int Cod_Cliente = int.Parse(cod_Cliente_Contas_a_ReceberTextBox.Text);
         //   dados_Clientes.cod_cliente = Cod_Cliente;
        //    dados_Clientes.cod_cliente =(int)(this.cod_Cliente_Contas_a_ReceberTextBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         // this.clientes_Contas_a_ReceberTableAdapter.FillByNome_Cliente(this.sGFRenaissanceDataSet.Clientes_Contas_a_Receber, "%" + textBox1.Text + "%");
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //   DG_Clientes.Refresh();
            this.clientes_Contas_a_ReceberTableAdapter.Fill(this.sGFRenaissanceDataSet.Clientes_Contas_a_Receber);
            textBox1.Text = "";
            cod_Cliente_Contas_a_ReceberTextBox.Text = "";
            nome_ClienteTextBox.Text = "";
            endereço_ClienteTextBox.Text = "";
            bairro_ClienteTextBox.Text = "";
            municipio_ClienteTextBox.Text = "";
            estadoTextBox.Text = "";
            telefoneTextBox.Text = "";
            celularTextBox.Text = "";
            emailTextBox.Text = "";
            statusTextBox.Text = "";
            identificacaoTextBox.Text = "";
            cNPJTextBox.Text = "";
            textBox1.Focus();
    
        }
    
      
    }
}
