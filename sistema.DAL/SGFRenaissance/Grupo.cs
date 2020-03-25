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
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            this.grupoBindingSource.DataSource = DataContextFactory.DataContext.Grupos;
            cod_GrupoTextBox.Enabled = false;
            grupo_DescricaoTextBox.Enabled = false;
            _btnSalvar.Enabled = false;
            btn_novo.Focus();

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.grupoBindingSource.AddNew();
            //Adicionar +1 ao Contador (Cod_Grupo)
        }

        private void _btnSalvar_Click(object sender, EventArgs e)
        {
            txt_datetime.Text = DateTime.Now.ToString();
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
            this.grupoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Dados do Grupo Inseridos / Alteradas com Sucesso!");
            cod_GrupoTextBox.Enabled = false;
            grupo_DescricaoTextBox.Enabled = false;
            _btnSalvar.Enabled = false;
            _btnFechar.Focus();

        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            this.grupoBindingSource.MoveNext();

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.grupoBindingSource.MovePrevious();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            grupo_DescricaoTextBox.Enabled = true;
            _btnSalvar.Enabled = true;

        }

        private void _btnFechar_Click(object sender, EventArgs e)
        {
            this.grupoBindingSource.EndEdit();
            this.Close();
        }
    }
}