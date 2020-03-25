namespace SGFRenaissance
{
    partial class Grupo
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
            System.Windows.Forms.Label LoginLabel;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label cod_GrupoLabel;
            System.Windows.Forms.Label grupo_DescricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupo));
            this._lblTituloJanela = new System.Windows.Forms.Label();
            this._lblLinha = new System.Windows.Forms.Label();
            this._lblMensagemUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this._btnFechar = new System.Windows.Forms.Button();
            this._btnSalvar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.login_NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_GrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupo_DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_datetime = new System.Windows.Forms.TextBox();
            LoginLabel = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            cod_GrupoLabel = new System.Windows.Forms.Label();
            grupo_DescricaoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoginLabel.Location = new System.Drawing.Point(3, 6);
            LoginLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(41, 15);
            LoginLabel.TabIndex = 90;
            LoginLabel.Text = "Login:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(160, 6);
            label19.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(36, 15);
            label19.TabIndex = 92;
            label19.Text = "Data:";
            // 
            // cod_GrupoLabel
            // 
            cod_GrupoLabel.AutoSize = true;
            cod_GrupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_GrupoLabel.Location = new System.Drawing.Point(31, 36);
            cod_GrupoLabel.Name = "cod_GrupoLabel";
            cod_GrupoLabel.Size = new System.Drawing.Size(114, 16);
            cod_GrupoLabel.TabIndex = 0;
            cod_GrupoLabel.Text = "Código do Grupo:";
            // 
            // grupo_DescricaoLabel
            // 
            grupo_DescricaoLabel.AutoSize = true;
            grupo_DescricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupo_DescricaoLabel.Location = new System.Drawing.Point(31, 67);
            grupo_DescricaoLabel.Name = "grupo_DescricaoLabel";
            grupo_DescricaoLabel.Size = new System.Drawing.Size(113, 16);
            grupo_DescricaoLabel.TabIndex = 4;
            grupo_DescricaoLabel.Text = "Grupo Descricao:";
            // 
            // _lblTituloJanela
            // 
            this._lblTituloJanela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTituloJanela.AutoSize = true;
            this._lblTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloJanela.ForeColor = System.Drawing.Color.Maroon;
            this._lblTituloJanela.Location = new System.Drawing.Point(12, 9);
            this._lblTituloJanela.Name = "_lblTituloJanela";
            this._lblTituloJanela.Size = new System.Drawing.Size(218, 29);
            this._lblTituloJanela.TabIndex = 112;
            this._lblTituloJanela.Text = "Cadastrar Grupos";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-5, 38);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(712, 18);
            this._lblLinha.TabIndex = 113;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "_______";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblMensagemUsuario
            // 
            this._lblMensagemUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblMensagemUsuario.AutoSize = true;
            this._lblMensagemUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMensagemUsuario.Location = new System.Drawing.Point(15, 283);
            this._lblMensagemUsuario.Name = "_lblMensagemUsuario";
            this._lblMensagemUsuario.Size = new System.Drawing.Size(202, 15);
            this._lblMensagemUsuario.TabIndex = 118;
            this._lblMensagemUsuario.Text = "Responsável Pela Última Alteração:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.btn_Voltar);
            this.panel1.Controls.Add(this.btn_Proximo);
            this.panel1.Controls.Add(this._btnFechar);
            this.panel1.Controls.Add(this._btnSalvar);
            this.panel1.Location = new System.Drawing.Point(14, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 49);
            this.panel1.TabIndex = 116;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(24, 12);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(81, 26);
            this.btn_novo.TabIndex = 22;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(458, 12);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(88, 26);
            this.btn_Editar.TabIndex = 23;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(352, 12);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(81, 26);
            this.btn_Voltar.TabIndex = 23;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proximo.Location = new System.Drawing.Point(244, 12);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(81, 26);
            this.btn_Proximo.TabIndex = 22;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            this.btn_Proximo.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // _btnFechar
            // 
            this._btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFechar.Location = new System.Drawing.Point(564, 12);
            this._btnFechar.Name = "_btnFechar";
            this._btnFechar.Size = new System.Drawing.Size(88, 26);
            this._btnFechar.TabIndex = 22;
            this._btnFechar.Text = "Fechar";
            this._btnFechar.UseVisualStyleBackColor = true;
            this._btnFechar.Click += new System.EventHandler(this._btnFechar_Click);
            // 
            // _btnSalvar
            // 
            this._btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSalvar.Location = new System.Drawing.Point(135, 12);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(81, 26);
            this._btnSalvar.TabIndex = 21;
            this._btnSalvar.Text = "Salvar";
            this._btnSalvar.UseVisualStyleBackColor = true;
            this._btnSalvar.Click += new System.EventHandler(this._btnSalvar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(LoginLabel);
            this.flowLayoutPanel1.Controls.Add(this.login_NameTextBox);
            this.flowLayoutPanel1.Controls.Add(label19);
            this.flowLayoutPanel1.Controls.Add(this.txt_datetime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 308);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(671, 50);
            this.flowLayoutPanel1.TabIndex = 117;
            // 
            // login_NameTextBox
            // 
            this.login_NameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.login_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Login_Name", true));
            this.login_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_NameTextBox.Location = new System.Drawing.Point(50, 7);
            this.login_NameTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.login_NameTextBox.Name = "login_NameTextBox";
            this.login_NameTextBox.Size = new System.Drawing.Size(104, 14);
            this.login_NameTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cod_GrupoLabel);
            this.groupBox1.Controls.Add(this.cod_GrupoTextBox);
            this.groupBox1.Controls.Add(grupo_DescricaoLabel);
            this.groupBox1.Controls.Add(this.grupo_DescricaoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 125);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Grupo";
            // 
            // cod_GrupoTextBox
            // 
            this.cod_GrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Cod_Grupo", true));
            this.cod_GrupoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_GrupoTextBox.Location = new System.Drawing.Point(153, 33);
            this.cod_GrupoTextBox.Name = "cod_GrupoTextBox";
            this.cod_GrupoTextBox.ReadOnly = true;
            this.cod_GrupoTextBox.Size = new System.Drawing.Size(42, 22);
            this.cod_GrupoTextBox.TabIndex = 1;
            // 
            // grupo_DescricaoTextBox
            // 
            this.grupo_DescricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Grupo_Descricao", true));
            this.grupo_DescricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_DescricaoTextBox.Location = new System.Drawing.Point(153, 67);
            this.grupo_DescricaoTextBox.MaxLength = 20;
            this.grupo_DescricaoTextBox.Name = "grupo_DescricaoTextBox";
            this.grupo_DescricaoTextBox.Size = new System.Drawing.Size(264, 22);
            this.grupo_DescricaoTextBox.TabIndex = 5;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataSource = typeof(sistema.DAL.Grupo);
            // 
            // txt_datetime
            // 
            this.txt_datetime.BackColor = System.Drawing.SystemColors.Control;
            this.txt_datetime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datetime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Data_Login", true));
            this.txt_datetime.Location = new System.Drawing.Point(202, 7);
            this.txt_datetime.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(132, 13);
            this.txt_datetime.TabIndex = 93;
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lblMensagemUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this._lblTituloJanela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupos";
            this.Load += new System.EventHandler(this.Grupo_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloJanela;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label _lblMensagemUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnFechar;
        private System.Windows.Forms.Button _btnSalvar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private System.Windows.Forms.TextBox login_NameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cod_GrupoTextBox;
        private System.Windows.Forms.TextBox grupo_DescricaoTextBox;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Proximo;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txt_datetime;
    }
}