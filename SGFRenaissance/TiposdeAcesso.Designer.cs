namespace SGFRenaissance
{
    partial class TiposdeAcesso
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
            System.Windows.Forms.Label cod_acessoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label data_LoginLabel;
            System.Windows.Forms.Label nome_LoginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposdeAcesso));
            this._lblLinha = new System.Windows.Forms.Label();
            this._lblTituloJanela = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lblMensagemUsuario = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.cod_acessoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.nome_LoginTextBox = new System.Windows.Forms.TextBox();
            this.txtdatalogin = new System.Windows.Forms.TextBox();
            this.tipos_AcessoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cod_acessoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            data_LoginLabel = new System.Windows.Forms.Label();
            nome_LoginLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipos_AcessoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-6, 51);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(592, 18);
            this._lblLinha.TabIndex = 117;
            this._lblLinha.Text = "_________________________________________________________________________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblTituloJanela
            // 
            this._lblTituloJanela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTituloJanela.AutoSize = true;
            this._lblTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloJanela.ForeColor = System.Drawing.Color.Maroon;
            this._lblTituloJanela.Location = new System.Drawing.Point(4, 22);
            this._lblTituloJanela.Name = "_lblTituloJanela";
            this._lblTituloJanela.Size = new System.Drawing.Size(329, 29);
            this._lblTituloJanela.TabIndex = 132;
            this._lblTituloJanela.Text = "Cadastrar Tipos de Acesso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Controls.Add(cod_acessoLabel);
            this.groupBox1.Controls.Add(this.cod_acessoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 100);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Acesso";
            // 
            // _lblMensagemUsuario
            // 
            this._lblMensagemUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblMensagemUsuario.AutoSize = true;
            this._lblMensagemUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMensagemUsuario.Location = new System.Drawing.Point(5, 285);
            this._lblMensagemUsuario.Name = "_lblMensagemUsuario";
            this._lblMensagemUsuario.Size = new System.Drawing.Size(202, 15);
            this._lblMensagemUsuario.TabIndex = 144;
            this._lblMensagemUsuario.Text = "Responsável Pela Última Alteração:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(nome_LoginLabel);
            this.flowLayoutPanel1.Controls.Add(this.nome_LoginTextBox);
            this.flowLayoutPanel1.Controls.Add(data_LoginLabel);
            this.flowLayoutPanel1.Controls.Add(this.txtdatalogin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 306);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 51);
            this.flowLayoutPanel1.TabIndex = 145;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_proximo);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Location = new System.Drawing.Point(4, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 70);
            this.panel1.TabIndex = 146;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(468, 23);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(85, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(358, 23);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 30);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(246, 23);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(85, 30);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 23);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(85, 30);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(121, 23);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(85, 30);
            this.btn_proximo.TabIndex = 4;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cod_acessoLabel
            // 
            cod_acessoLabel.AutoSize = true;
            cod_acessoLabel.Location = new System.Drawing.Point(27, 29);
            cod_acessoLabel.Name = "cod_acessoLabel";
            cod_acessoLabel.Size = new System.Drawing.Size(84, 16);
            cod_acessoLabel.TabIndex = 0;
            cod_acessoLabel.Text = "Cod acesso:";
            // 
            // cod_acessoTextBox
            // 
            this.cod_acessoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipos_AcessoBindingSource, "Cod_acesso", true));
            this.cod_acessoTextBox.Location = new System.Drawing.Point(117, 26);
            this.cod_acessoTextBox.Name = "cod_acessoTextBox";
            this.cod_acessoTextBox.ReadOnly = true;
            this.cod_acessoTextBox.Size = new System.Drawing.Size(54, 22);
            this.cod_acessoTextBox.TabIndex = 1;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(218, 29);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(73, 16);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descrição:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipos_AcessoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(297, 26);
            this.descricaoTextBox.MaxLength = 25;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(242, 22);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // data_LoginLabel
            // 
            data_LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            data_LoginLabel.AutoSize = true;
            data_LoginLabel.Location = new System.Drawing.Point(152, 9);
            data_LoginLabel.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
            data_LoginLabel.Name = "data_LoginLabel";
            data_LoginLabel.Size = new System.Drawing.Size(36, 13);
            data_LoginLabel.TabIndex = 0;
            data_LoginLabel.Text = "Data :";
            // 
            // nome_LoginLabel
            // 
            nome_LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nome_LoginLabel.AutoSize = true;
            nome_LoginLabel.Location = new System.Drawing.Point(5, 9);
            nome_LoginLabel.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
            nome_LoginLabel.Name = "nome_LoginLabel";
            nome_LoginLabel.Size = new System.Drawing.Size(39, 13);
            nome_LoginLabel.TabIndex = 2;
            nome_LoginLabel.Text = " Login:";
            // 
            // nome_LoginTextBox
            // 
            this.nome_LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome_LoginTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nome_LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipos_AcessoBindingSource, "Nome_Login", true));
            this.nome_LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_LoginTextBox.Location = new System.Drawing.Point(52, 12);
            this.nome_LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 12, 8, 8);
            this.nome_LoginTextBox.Name = "nome_LoginTextBox";
            this.nome_LoginTextBox.ReadOnly = true;
            this.nome_LoginTextBox.Size = new System.Drawing.Size(87, 14);
            this.nome_LoginTextBox.TabIndex = 3;
            this.nome_LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdatalogin
            // 
            this.txtdatalogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtdatalogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdatalogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipos_AcessoBindingSource, "Data_Login", true));
            this.txtdatalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatalogin.Location = new System.Drawing.Point(195, 12);
            this.txtdatalogin.Margin = new System.Windows.Forms.Padding(2, 12, 8, 5);
            this.txtdatalogin.Name = "txtdatalogin";
            this.txtdatalogin.ReadOnly = true;
            this.txtdatalogin.Size = new System.Drawing.Size(138, 14);
            this.txtdatalogin.TabIndex = 4;
            this.txtdatalogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipos_AcessoBindingSource
            // 
            this.tipos_AcessoBindingSource.DataSource = typeof(sistema.DAL.Tipos_Acesso);
            // 
            // TiposdeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this._lblMensagemUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lblTituloJanela);
            this.Controls.Add(this._lblLinha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiposdeAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Acesso";
            this.Load += new System.EventHandler(this.TiposdeAcesso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipos_AcessoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label _lblTituloJanela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _lblMensagemUsuario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource tipos_AcessoBindingSource;
        private System.Windows.Forms.TextBox cod_acessoTextBox;
        private System.Windows.Forms.TextBox nome_LoginTextBox;
        private System.Windows.Forms.TextBox txtdatalogin;
    }
}