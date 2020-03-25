namespace SGFRenaissance
{
    partial class Centro_de_Custos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Centro_de_Custos));
            this.label1 = new System.Windows.Forms.Label();
            this._lblTituloJanela = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_Centro_CustosTextBox = new System.Windows.Forms.TextBox();
            this.centro_CustoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricao_Centro_CustosTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this._btnSalvar = new System.Windows.Forms.Button();
            this._lblLinha = new System.Windows.Forms.Label();
            this._lblMensagemUsuario = new System.Windows.Forms.Label();
            this.login_NameTextBox = new System.Windows.Forms.TextBox();
            this.txt_datetime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centro_CustoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Centro de Custos:";
            // 
            // _lblTituloJanela
            // 
            this._lblTituloJanela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTituloJanela.AutoSize = true;
            this._lblTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloJanela.ForeColor = System.Drawing.Color.Maroon;
            this._lblTituloJanela.Location = new System.Drawing.Point(6, 9);
            this._lblTituloJanela.Name = "_lblTituloJanela";
            this._lblTituloJanela.Size = new System.Drawing.Size(335, 29);
            this._lblTituloJanela.TabIndex = 113;
            this._lblTituloJanela.Text = "Cadastrar Centro de Custos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cod_Centro_CustosTextBox);
            this.groupBox1.Controls.Add(this.descricao_Centro_CustosTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 130);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Centro de Custos";
            // 
            // cod_Centro_CustosTextBox
            // 
            this.cod_Centro_CustosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centro_CustoBindingSource, "Cod_Centro_Custos", true));
            this.cod_Centro_CustosTextBox.Enabled = false;
            this.cod_Centro_CustosTextBox.Location = new System.Drawing.Point(171, 35);
            this.cod_Centro_CustosTextBox.Name = "cod_Centro_CustosTextBox";
            this.cod_Centro_CustosTextBox.Size = new System.Drawing.Size(50, 21);
            this.cod_Centro_CustosTextBox.TabIndex = 5;
            // 
            // centro_CustoBindingSource
            // 
            this.centro_CustoBindingSource.DataSource = typeof(sistema.DAL.Centro_Custo);
            // 
            // descricao_Centro_CustosTextBox
            // 
            this.descricao_Centro_CustosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centro_CustoBindingSource, "Descricao_Centro_Custos", true));
            this.descricao_Centro_CustosTextBox.Location = new System.Drawing.Point(171, 71);
            this.descricao_Centro_CustosTextBox.Name = "descricao_Centro_CustosTextBox";
            this.descricao_Centro_CustosTextBox.Size = new System.Drawing.Size(320, 21);
            this.descricao_Centro_CustosTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição Centro de Custos:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.btn_Proximo);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this._btnSalvar);
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 58);
            this.panel1.TabIndex = 119;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(211, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(85, 30);
            this.btn_voltar.TabIndex = 23;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(420, 12);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(85, 30);
            this.btn_Editar.TabIndex = 23;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proximo.Location = new System.Drawing.Point(316, 12);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(85, 30);
            this.btn_Proximo.TabIndex = 22;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            this.btn_Proximo.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(6, 12);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(85, 30);
            this.btn_Novo.TabIndex = 22;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(525, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(85, 30);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // _btnSalvar
            // 
            this._btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSalvar.Location = new System.Drawing.Point(111, 12);
            this._btnSalvar.Name = "_btnSalvar";
            this._btnSalvar.Size = new System.Drawing.Size(85, 30);
            this._btnSalvar.TabIndex = 21;
            this._btnSalvar.Text = "Salvar";
            this._btnSalvar.UseVisualStyleBackColor = true;
            this._btnSalvar.Click += new System.EventHandler(this._btnSalvar_Click);
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-10, 38);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(656, 18);
            this._lblLinha.TabIndex = 122;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblMensagemUsuario
            // 
            this._lblMensagemUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblMensagemUsuario.AutoSize = true;
            this._lblMensagemUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMensagemUsuario.Location = new System.Drawing.Point(3, 281);
            this._lblMensagemUsuario.Name = "_lblMensagemUsuario";
            this._lblMensagemUsuario.Size = new System.Drawing.Size(202, 15);
            this._lblMensagemUsuario.TabIndex = 124;
            this._lblMensagemUsuario.Text = "Responsável Pela Última Alteração:";
            // 
            // login_NameTextBox
            // 
            this.login_NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_NameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.login_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centro_CustoBindingSource, "Login_Name", true));
            this.login_NameTextBox.Location = new System.Drawing.Point(45, 11);
            this.login_NameTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.login_NameTextBox.Name = "login_NameTextBox";
            this.login_NameTextBox.Size = new System.Drawing.Size(95, 13);
            this.login_NameTextBox.TabIndex = 11;
            // 
            // txt_datetime
            // 
            this.txt_datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_datetime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_datetime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datetime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centro_CustoBindingSource, "Data_Login", true));
            this.txt_datetime.Location = new System.Drawing.Point(207, 11);
            this.txt_datetime.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(141, 13);
            this.txt_datetime.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.login_NameTextBox);
            this.panel2.Controls.Add(this.txt_datetime);
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 54);
            this.panel2.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data:";
            // 
            // Centro_de_Custos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 357);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._lblMensagemUsuario);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lblTituloJanela);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Centro_de_Custos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Custos";
            this.Load += new System.EventHandler(this.Centro_de_Custos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centro_CustoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblTituloJanela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button _btnSalvar;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cod_Centro_CustosTextBox;
        private System.Windows.Forms.BindingSource centro_CustoBindingSource;
        private System.Windows.Forms.TextBox descricao_Centro_CustosTextBox;
        private System.Windows.Forms.Label _lblMensagemUsuario;
        private System.Windows.Forms.TextBox login_NameTextBox;
        private System.Windows.Forms.Button btn_Editar;
        
        private System.Windows.Forms.Button btn_Proximo;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_datetime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}