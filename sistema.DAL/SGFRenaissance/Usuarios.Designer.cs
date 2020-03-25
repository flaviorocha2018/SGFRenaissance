namespace SGFRenaissance
{
    partial class Usuarios
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
            System.Windows.Forms.Label data_LoginLabel;
            System.Windows.Forms.Label login_NameLabel;
            System.Windows.Forms.Label tipos_AcessoLabel;
            System.Windows.Forms.Label senha_UsuarioLabel;
            System.Windows.Forms.Label nome_UsuarioLabel;
            System.Windows.Forms.Label nome_LoginLabel;
            System.Windows.Forms.Label codigo_AcessoLabel;
            System.Windows.Forms.Label cod_UsuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this._lblLinha = new System.Windows.Forms.Label();
            this._lblTituloJanela = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_NameTextBox = new System.Windows.Forms.TextBox();
            this.txtdatalogin = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._lblMensagemUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_Tipos_Acesso = new System.Windows.Forms.ComboBox();
            this.tipos_AcessoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senha_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nome_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nome_LoginTextBox = new System.Windows.Forms.TextBox();
            this.codigo_AcessoTextBox = new System.Windows.Forms.TextBox();
            this.cod_UsuarioTextBox = new System.Windows.Forms.TextBox();
            data_LoginLabel = new System.Windows.Forms.Label();
            login_NameLabel = new System.Windows.Forms.Label();
            tipos_AcessoLabel = new System.Windows.Forms.Label();
            senha_UsuarioLabel = new System.Windows.Forms.Label();
            nome_UsuarioLabel = new System.Windows.Forms.Label();
            nome_LoginLabel = new System.Windows.Forms.Label();
            codigo_AcessoLabel = new System.Windows.Forms.Label();
            cod_UsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_AcessoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_LoginLabel
            // 
            data_LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            data_LoginLabel.AutoSize = true;
            data_LoginLabel.Location = new System.Drawing.Point(147, 12);
            data_LoginLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            data_LoginLabel.Name = "data_LoginLabel";
            data_LoginLabel.Size = new System.Drawing.Size(33, 13);
            data_LoginLabel.TabIndex = 134;
            data_LoginLabel.Text = "Data:";
            // 
            // login_NameLabel
            // 
            login_NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            login_NameLabel.AutoSize = true;
            login_NameLabel.Location = new System.Drawing.Point(3, 12);
            login_NameLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            login_NameLabel.Name = "login_NameLabel";
            login_NameLabel.Size = new System.Drawing.Size(36, 13);
            login_NameLabel.TabIndex = 135;
            login_NameLabel.Text = "Login:";
            // 
            // tipos_AcessoLabel
            // 
            tipos_AcessoLabel.AutoSize = true;
            tipos_AcessoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipos_AcessoLabel.Location = new System.Drawing.Point(245, 129);
            tipos_AcessoLabel.Name = "tipos_AcessoLabel";
            tipos_AcessoLabel.Size = new System.Drawing.Size(95, 16);
            tipos_AcessoLabel.TabIndex = 150;
            tipos_AcessoLabel.Text = "Tipos Acesso:";
            // 
            // senha_UsuarioLabel
            // 
            senha_UsuarioLabel.AutoSize = true;
            senha_UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senha_UsuarioLabel.Location = new System.Drawing.Point(242, 95);
            senha_UsuarioLabel.Name = "senha_UsuarioLabel";
            senha_UsuarioLabel.Size = new System.Drawing.Size(100, 16);
            senha_UsuarioLabel.TabIndex = 148;
            senha_UsuarioLabel.Text = "Senha Usuario:";
            // 
            // nome_UsuarioLabel
            // 
            nome_UsuarioLabel.AutoSize = true;
            nome_UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_UsuarioLabel.Location = new System.Drawing.Point(242, 57);
            nome_UsuarioLabel.Name = "nome_UsuarioLabel";
            nome_UsuarioLabel.Size = new System.Drawing.Size(98, 16);
            nome_UsuarioLabel.TabIndex = 146;
            nome_UsuarioLabel.Text = "Nome Usuario:";
            // 
            // nome_LoginLabel
            // 
            nome_LoginLabel.AutoSize = true;
            nome_LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_LoginLabel.Location = new System.Drawing.Point(242, 20);
            nome_LoginLabel.Name = "nome_LoginLabel";
            nome_LoginLabel.Size = new System.Drawing.Size(84, 16);
            nome_LoginLabel.TabIndex = 145;
            nome_LoginLabel.Text = "Nome Login:";
            // 
            // codigo_AcessoLabel
            // 
            codigo_AcessoLabel.AutoSize = true;
            codigo_AcessoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigo_AcessoLabel.Location = new System.Drawing.Point(21, 60);
            codigo_AcessoLabel.Name = "codigo_AcessoLabel";
            codigo_AcessoLabel.Size = new System.Drawing.Size(88, 16);
            codigo_AcessoLabel.TabIndex = 142;
            codigo_AcessoLabel.Text = "Cód. Acesso:";
            // 
            // cod_UsuarioLabel
            // 
            cod_UsuarioLabel.AutoSize = true;
            cod_UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_UsuarioLabel.Location = new System.Drawing.Point(21, 32);
            cod_UsuarioLabel.Name = "cod_UsuarioLabel";
            cod_UsuarioLabel.Size = new System.Drawing.Size(89, 16);
            cod_UsuarioLabel.TabIndex = 141;
            cod_UsuarioLabel.Text = "Cód. Usuario:";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-39, 39);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(672, 18);
            this._lblLinha.TabIndex = 116;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "__";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblTituloJanela
            // 
            this._lblTituloJanela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTituloJanela.AutoSize = true;
            this._lblTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloJanela.ForeColor = System.Drawing.Color.Maroon;
            this._lblTituloJanela.Location = new System.Drawing.Point(15, 19);
            this._lblTituloJanela.Name = "_lblTituloJanela";
            this._lblTituloJanela.Size = new System.Drawing.Size(236, 29);
            this._lblTituloJanela.TabIndex = 131;
            this._lblTituloJanela.Text = "Cadastrar Usuários";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(sistema.DAL.Usuario);
            // 
            // login_NameTextBox
            // 
            this.login_NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.login_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome_Login", true));
            this.login_NameTextBox.Enabled = false;
            this.login_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_NameTextBox.Location = new System.Drawing.Point(45, 12);
            this.login_NameTextBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.login_NameTextBox.Name = "login_NameTextBox";
            this.login_NameTextBox.ReadOnly = true;
            this.login_NameTextBox.Size = new System.Drawing.Size(96, 14);
            this.login_NameTextBox.TabIndex = 136;
            this.login_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdatalogin
            // 
            this.txtdatalogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdatalogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdatalogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Data_Login", true));
            this.txtdatalogin.Enabled = false;
            this.txtdatalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatalogin.Location = new System.Drawing.Point(186, 12);
            this.txtdatalogin.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtdatalogin.Name = "txtdatalogin";
            this.txtdatalogin.ReadOnly = true;
            this.txtdatalogin.Size = new System.Drawing.Size(139, 14);
            this.txtdatalogin.TabIndex = 141;
            this.txtdatalogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(login_NameLabel);
            this.flowLayoutPanel1.Controls.Add(this.login_NameTextBox);
            this.flowLayoutPanel1.Controls.Add(data_LoginLabel);
            this.flowLayoutPanel1.Controls.Add(this.txtdatalogin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 342);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 48);
            this.flowLayoutPanel1.TabIndex = 142;
            // 
            // _lblMensagemUsuario
            // 
            this._lblMensagemUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblMensagemUsuario.AutoSize = true;
            this._lblMensagemUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMensagemUsuario.Location = new System.Drawing.Point(5, 324);
            this._lblMensagemUsuario.Name = "_lblMensagemUsuario";
            this._lblMensagemUsuario.Size = new System.Drawing.Size(202, 15);
            this._lblMensagemUsuario.TabIndex = 143;
            this._lblMensagemUsuario.Text = "Responsável Pela Última Alteração:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_proximo);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Location = new System.Drawing.Point(2, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 70);
            this.panel1.TabIndex = 144;
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(139, 23);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(85, 30);
            this.btn_proximo.TabIndex = 4;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(472, 23);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(85, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(356, 23);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 30);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(252, 23);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(85, 30);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(24, 23);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(85, 30);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Tipos_Acesso);
            this.groupBox1.Controls.Add(tipos_AcessoLabel);
            this.groupBox1.Controls.Add(senha_UsuarioLabel);
            this.groupBox1.Controls.Add(this.senha_UsuarioTextBox);
            this.groupBox1.Controls.Add(nome_UsuarioLabel);
            this.groupBox1.Controls.Add(this.nome_UsuarioTextBox);
            this.groupBox1.Controls.Add(nome_LoginLabel);
            this.groupBox1.Controls.Add(this.nome_LoginTextBox);
            this.groupBox1.Controls.Add(codigo_AcessoLabel);
            this.groupBox1.Controls.Add(this.codigo_AcessoTextBox);
            this.groupBox1.Controls.Add(cod_UsuarioLabel);
            this.groupBox1.Controls.Add(this.cod_UsuarioTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 178);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Usuário";
            // 
            // CB_Tipos_Acesso
            // 
            this.CB_Tipos_Acesso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "Codigo_Acesso", true));
            this.CB_Tipos_Acesso.DataSource = this.tipos_AcessoBindingSource;
            this.CB_Tipos_Acesso.DisplayMember = "Descricao";
            this.CB_Tipos_Acesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Tipos_Acesso.FormattingEnabled = true;
            this.CB_Tipos_Acesso.Location = new System.Drawing.Point(356, 129);
            this.CB_Tipos_Acesso.Name = "CB_Tipos_Acesso";
            this.CB_Tipos_Acesso.Size = new System.Drawing.Size(167, 23);
            this.CB_Tipos_Acesso.TabIndex = 151;
            this.CB_Tipos_Acesso.ValueMember = "Cod_acesso";
            // 
            // tipos_AcessoBindingSource
            // 
            this.tipos_AcessoBindingSource.DataSource = typeof(sistema.DAL.Tipos_Acesso);
            // 
            // senha_UsuarioTextBox
            // 
            this.senha_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha_Usuario", true));
            this.senha_UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_UsuarioTextBox.Location = new System.Drawing.Point(356, 92);
            this.senha_UsuarioTextBox.Name = "senha_UsuarioTextBox";
            this.senha_UsuarioTextBox.PasswordChar = '*';
            this.senha_UsuarioTextBox.Size = new System.Drawing.Size(167, 22);
            this.senha_UsuarioTextBox.TabIndex = 151;
            // 
            // nome_UsuarioTextBox
            // 
            this.nome_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome_Usuario", true));
            this.nome_UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_UsuarioTextBox.Location = new System.Drawing.Point(356, 54);
            this.nome_UsuarioTextBox.Name = "nome_UsuarioTextBox";
            this.nome_UsuarioTextBox.Size = new System.Drawing.Size(167, 22);
            this.nome_UsuarioTextBox.TabIndex = 149;
            // 
            // nome_LoginTextBox
            // 
            this.nome_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Login_Name", true));
            this.nome_LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_LoginTextBox.Location = new System.Drawing.Point(356, 17);
            this.nome_LoginTextBox.Name = "nome_LoginTextBox";
            this.nome_LoginTextBox.Size = new System.Drawing.Size(167, 22);
            this.nome_LoginTextBox.TabIndex = 147;
            // 
            // codigo_AcessoTextBox
            // 
            this.codigo_AcessoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Codigo_Acesso", true));
            this.codigo_AcessoTextBox.Enabled = false;
            this.codigo_AcessoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_AcessoTextBox.Location = new System.Drawing.Point(123, 57);
            this.codigo_AcessoTextBox.Name = "codigo_AcessoTextBox";
            this.codigo_AcessoTextBox.Size = new System.Drawing.Size(43, 22);
            this.codigo_AcessoTextBox.TabIndex = 144;
            // 
            // cod_UsuarioTextBox
            // 
            this.cod_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cod_Usuario", true));
            this.cod_UsuarioTextBox.Enabled = false;
            this.cod_UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_UsuarioTextBox.Location = new System.Drawing.Point(123, 29);
            this.cod_UsuarioTextBox.Name = "cod_UsuarioTextBox";
            this.cod_UsuarioTextBox.ReadOnly = true;
            this.cod_UsuarioTextBox.Size = new System.Drawing.Size(43, 22);
            this.cod_UsuarioTextBox.TabIndex = 143;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lblMensagemUsuario);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this._lblTituloJanela);
            this.Controls.Add(this._lblLinha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_AcessoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label _lblTituloJanela;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox login_NameTextBox;
        private System.Windows.Forms.TextBox txtdatalogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label _lblMensagemUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox senha_UsuarioTextBox;
        private System.Windows.Forms.TextBox nome_UsuarioTextBox;
        private System.Windows.Forms.TextBox nome_LoginTextBox;
        private System.Windows.Forms.TextBox codigo_AcessoTextBox;
        private System.Windows.Forms.TextBox cod_UsuarioTextBox;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.ComboBox CB_Tipos_Acesso;
        private System.Windows.Forms.BindingSource tipos_AcessoBindingSource;
    }
}