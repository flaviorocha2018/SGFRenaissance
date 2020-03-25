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
using sistema.DAL;




namespace SGFRenaissance
{
    public partial class Login : Form
    {
        String usuario, pwd;
        public bool logado = false;
       
       
        public Login()
        {
            InitializeComponent();
        }
       
        public static class DadosGerais
        {
            public static string Loginusuario;
        }

        public void EfetuarLogin()
        {
              usuario = nome_LoginTextBox.Text;
              pwd = senha_UsuarioTextBox.Text;
              DadosGerais.Loginusuario = usuario; 
              // pgto = txt_pgto.Text;
       
              var user = DataContextFactory.DataContext.Usuarios.Count(x => x.Login_Name == nome_LoginTextBox.Text && x.Senha_Usuario == senha_UsuarioTextBox.Text);
              
              if (user > 0)
              {
                  this.logado = true;
                  this.Dispose();
              }
              else
              {
                   MessageBox.Show("Usuário ou Senha incorretos!");
              }
                 
         }

         private void btn_efetuarlogin_Click(object sender, EventArgs e)
         { 
             EfetuarLogin();
         }
      

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_efetuarlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EfetuarLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {
#if DEBUG
          nome_LoginTextBox.Text = "Flavio";
          senha_UsuarioTextBox.Text = "123";
#endif
        }

    }
}

