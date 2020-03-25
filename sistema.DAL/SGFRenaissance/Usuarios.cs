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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            login_NameTextBox.Text = Login.DadosGerais.Loginusuario;
            login_NameTextBox.Refresh();
            txtdatalogin.Text = DateTime.Now.ToString();
            this.usuarioBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            nome_LoginTextBox.Enabled = false;
            nome_UsuarioTextBox.Enabled = false;
            senha_UsuarioTextBox.Enabled = false;
            CB_Tipos_Acesso.Enabled = false;
            codigo_AcessoTextBox.Refresh();
            MessageBox.Show("Dados do Usuário Inseridos / Alterados com Sucesso!");
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            nome_LoginTextBox.Enabled = true;
            nome_UsuarioTextBox.Enabled = true;
            senha_UsuarioTextBox.Enabled = true;
            CB_Tipos_Acesso.Enabled = true;

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.MoveNext();

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.AddNew();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.tipos_AcessoBindingSource.DataSource = DataContextFactory.DataContext.Tipos_Acessos;
            this.usuarioBindingSource.DataSource = DataContextFactory.DataContext.Usuarios;
            nome_LoginTextBox.Enabled = false;
            nome_UsuarioTextBox.Enabled = false;
            senha_UsuarioTextBox.Enabled = false;
            CB_Tipos_Acesso.Enabled = false;

        }
    }
}