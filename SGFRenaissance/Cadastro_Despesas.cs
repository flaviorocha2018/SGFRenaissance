using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace SGFRenaissance
{
    public partial class Cadastro_Despesas : Form
    {
        
        public Cadastro_Despesas()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            this.contas_DespesaBindingSource.MoveNext();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.contas_DespesaBindingSource.AddNew();
        }

        private void Cadastro_Despesas_Load(object sender, EventArgs e)
        {
            this.contas_DespesaBindingSource.DataSource = DataContextFactory.DataContext.Contas_Despesas;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.contas_DespesaBindingSource.MovePrevious();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            data_LoginTextBox.Text = DateTime.Now.ToString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
            this.contas_DespesaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Dados da Despesa Inseridos / Alterados com Sucesso!");
            cod_DespesaTextBox.Text = string.Empty;
            descricao_DespesaTextBox.Text = string.Empty;
            codigo_Despesa_ContabTextBox.Text = string.Empty;
            tipo_DespesaTextBox.Text = string.Empty;
            listBoxdespesa.Text = string.Empty;

        }

        private void listBoxdespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo_DespesaTextBox.Text = listBoxdespesa.Text;
        }
    }
}
