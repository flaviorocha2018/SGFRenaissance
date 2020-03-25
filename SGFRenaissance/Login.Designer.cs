namespace SGFRenaissance
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_efetuarlogin = new System.Windows.Forms.Button();
            this.gbox_Login = new System.Windows.Forms.GroupBox();
            this.senha_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nome_LoginTextBox = new System.Windows.Forms.TextBox();
            this.senha_PGTO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_mensagem = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gbox_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(10, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 133);
            this.panel3.TabIndex = 11;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Location = new System.Drawing.Point(323, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(105, 30);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_efetuarlogin
            // 
            this.btn_efetuarlogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_efetuarlogin.Location = new System.Drawing.Point(144, 19);
            this.btn_efetuarlogin.Name = "btn_efetuarlogin";
            this.btn_efetuarlogin.Size = new System.Drawing.Size(110, 30);
            this.btn_efetuarlogin.TabIndex = 3;
            this.btn_efetuarlogin.Text = "Efetuar Login";
            this.btn_efetuarlogin.UseVisualStyleBackColor = false;
            this.btn_efetuarlogin.Click += new System.EventHandler(this.btn_efetuarlogin_Click);
            this.btn_efetuarlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_efetuarlogin_KeyDown);
            // 
            // gbox_Login
            // 
            this.gbox_Login.Controls.Add(this.senha_UsuarioTextBox);
            this.gbox_Login.Controls.Add(this.nome_LoginTextBox);
            this.gbox_Login.Controls.Add(this.senha_PGTO);
            this.gbox_Login.Controls.Add(this.label7);
            this.gbox_Login.Controls.Add(this.LabelUsuario);
            this.gbox_Login.Controls.Add(this.label4);
            this.gbox_Login.Location = new System.Drawing.Point(140, 86);
            this.gbox_Login.Name = "gbox_Login";
            this.gbox_Login.Size = new System.Drawing.Size(331, 133);
            this.gbox_Login.TabIndex = 0;
            this.gbox_Login.TabStop = false;
            this.gbox_Login.Text = "Login";
            // 
            // senha_UsuarioTextBox
            // 
            this.senha_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha_Usuario", true));
            this.senha_UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_UsuarioTextBox.Location = new System.Drawing.Point(155, 60);
            this.senha_UsuarioTextBox.Name = "senha_UsuarioTextBox";
            this.senha_UsuarioTextBox.PasswordChar = '*';
            this.senha_UsuarioTextBox.Size = new System.Drawing.Size(127, 24);
            this.senha_UsuarioTextBox.TabIndex = 1;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(sistema.DAL.Usuario);
            // 
            // nome_LoginTextBox
            // 
            this.nome_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome_Login", true));
            this.nome_LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_LoginTextBox.Location = new System.Drawing.Point(155, 24);
            this.nome_LoginTextBox.Name = "nome_LoginTextBox";
            this.nome_LoginTextBox.Size = new System.Drawing.Size(127, 24);
            this.nome_LoginTextBox.TabIndex = 0;
            // 
            // senha_PGTO
            // 
            this.senha_PGTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_PGTO.Location = new System.Drawing.Point(155, 97);
            this.senha_PGTO.Name = "senha_PGTO";
            this.senha_PGTO.Size = new System.Drawing.Size(127, 22);
            this.senha_PGTO.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Senha:";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(13, 27);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(48, 18);
            this.LabelUsuario.TabIndex = 6;
            this.LabelUsuario.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha Pagamento:";
            // 
            // pnl_mensagem
            // 
            this.pnl_mensagem.Location = new System.Drawing.Point(10, 300);
            this.pnl_mensagem.Name = "pnl_mensagem";
            this.pnl_mensagem.Size = new System.Drawing.Size(461, 45);
            this.pnl_mensagem.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.btn_efetuarlogin);
            this.panel4.Controls.Add(this.btn_cancelar);
            this.panel4.Location = new System.Drawing.Point(10, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 71);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(10, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(461, 77);
            this.panel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "EFETUAR O LOGIN PARA ACESSAR O SISTEMA";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(480, 353);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbox_Login);
            this.Controls.Add(this.pnl_mensagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login do Sistema";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbox_Login.ResumeLayout(false);
            this.gbox_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_efetuarlogin;
        private System.Windows.Forms.GroupBox gbox_Login;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_mensagem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox senha_PGTO;
        private System.Windows.Forms.TextBox senha_UsuarioTextBox;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nome_LoginTextBox;
    }
}