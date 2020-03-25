namespace SGFRenaissance
{
    partial class Lancamentos
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
            System.Windows.Forms.Label cod_LancamentoLabel;
            System.Windows.Forms.Label cod_BancoLabel;
            System.Windows.Forms.Label data_LancamentoLabel;
            System.Windows.Forms.Label descricao_OperacaoLabel;
            System.Windows.Forms.Label numero_ContaLabel;
            System.Windows.Forms.Label numero_DocumentoLabel;
            System.Windows.Forms.Label operacaoLabel;
            System.Windows.Forms.Label valor_MovimentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lancamentos));
            this._lblLinha = new System.Windows.Forms.Label();
            this._lblTituloJanela = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_Operacao = new System.Windows.Forms.ComboBox();
            this.lancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operacaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cod_BancoComboBox = new System.Windows.Forms.ComboBox();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valor_MovimentoTextBox = new System.Windows.Forms.TextBox();
            this.numero_DocumentoTextBox = new System.Windows.Forms.TextBox();
            this.numero_ContaTextBox = new System.Windows.Forms.TextBox();
            this.descricao_OperacaoTextBox = new System.Windows.Forms.TextBox();
            this.data_LancamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cod_LancamentoTextBox = new System.Windows.Forms.TextBox();
            this._lblMensagemUsuario = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.login_NameTextBox = new System.Windows.Forms.TextBox();
            this.txt_datalogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            LoginLabel = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            cod_LancamentoLabel = new System.Windows.Forms.Label();
            cod_BancoLabel = new System.Windows.Forms.Label();
            data_LancamentoLabel = new System.Windows.Forms.Label();
            descricao_OperacaoLabel = new System.Windows.Forms.Label();
            numero_ContaLabel = new System.Windows.Forms.Label();
            numero_DocumentoLabel = new System.Windows.Forms.Label();
            operacaoLabel = new System.Windows.Forms.Label();
            valor_MovimentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoginLabel.Location = new System.Drawing.Point(3, 7);
            LoginLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(41, 15);
            LoginLabel.TabIndex = 90;
            LoginLabel.Text = "Login:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(170, 7);
            label19.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(36, 15);
            label19.TabIndex = 92;
            label19.Text = "Data:";
            // 
            // cod_LancamentoLabel
            // 
            cod_LancamentoLabel.AutoSize = true;
            cod_LancamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_LancamentoLabel.Location = new System.Drawing.Point(9, 32);
            cod_LancamentoLabel.Name = "cod_LancamentoLabel";
            cod_LancamentoLabel.Size = new System.Drawing.Size(116, 16);
            cod_LancamentoLabel.TabIndex = 0;
            cod_LancamentoLabel.Text = "Cód. Lancamento:";
            // 
            // cod_BancoLabel
            // 
            cod_BancoLabel.AutoSize = true;
            cod_BancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_BancoLabel.Location = new System.Drawing.Point(251, 32);
            cod_BancoLabel.Name = "cod_BancoLabel";
            cod_BancoLabel.Size = new System.Drawing.Size(125, 16);
            cod_BancoLabel.TabIndex = 2;
            cod_BancoLabel.Text = "Selecione o Banco:";
            // 
            // data_LancamentoLabel
            // 
            data_LancamentoLabel.AutoSize = true;
            data_LancamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_LancamentoLabel.Location = new System.Drawing.Point(7, 110);
            data_LancamentoLabel.Name = "data_LancamentoLabel";
            data_LancamentoLabel.Size = new System.Drawing.Size(117, 16);
            data_LancamentoLabel.TabIndex = 4;
            data_LancamentoLabel.Text = "Data Lancamento:";
            // 
            // descricao_OperacaoLabel
            // 
            descricao_OperacaoLabel.AutoSize = true;
            descricao_OperacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricao_OperacaoLabel.Location = new System.Drawing.Point(6, 180);
            descricao_OperacaoLabel.Name = "descricao_OperacaoLabel";
            descricao_OperacaoLabel.Size = new System.Drawing.Size(137, 16);
            descricao_OperacaoLabel.TabIndex = 6;
            descricao_OperacaoLabel.Text = "Descricao Operacao:";
            // 
            // numero_ContaLabel
            // 
            numero_ContaLabel.AutoSize = true;
            numero_ContaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_ContaLabel.Location = new System.Drawing.Point(279, 73);
            numero_ContaLabel.Name = "numero_ContaLabel";
            numero_ContaLabel.Size = new System.Drawing.Size(97, 16);
            numero_ContaLabel.TabIndex = 8;
            numero_ContaLabel.Text = "Numero Conta:";
            // 
            // numero_DocumentoLabel
            // 
            numero_DocumentoLabel.AutoSize = true;
            numero_DocumentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_DocumentoLabel.Location = new System.Drawing.Point(6, 146);
            numero_DocumentoLabel.Name = "numero_DocumentoLabel";
            numero_DocumentoLabel.Size = new System.Drawing.Size(101, 16);
            numero_DocumentoLabel.TabIndex = 10;
            numero_DocumentoLabel.Text = "Nº  Documento:";
            // 
            // operacaoLabel
            // 
            operacaoLabel.AutoSize = true;
            operacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            operacaoLabel.Location = new System.Drawing.Point(9, 68);
            operacaoLabel.Name = "operacaoLabel";
            operacaoLabel.Size = new System.Drawing.Size(72, 16);
            operacaoLabel.TabIndex = 12;
            operacaoLabel.Text = "Operacao:";
            // 
            // valor_MovimentoLabel
            // 
            valor_MovimentoLabel.AutoSize = true;
            valor_MovimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_MovimentoLabel.Location = new System.Drawing.Point(9, 220);
            valor_MovimentoLabel.Name = "valor_MovimentoLabel";
            valor_MovimentoLabel.Size = new System.Drawing.Size(112, 16);
            valor_MovimentoLabel.TabIndex = 14;
            valor_MovimentoLabel.Text = "Valor Movimento:";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-156, 48);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(872, 18);
            this._lblLinha.TabIndex = 116;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "___________________________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblTituloJanela
            // 
            this._lblTituloJanela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTituloJanela.AutoSize = true;
            this._lblTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloJanela.ForeColor = System.Drawing.Color.Maroon;
            this._lblTituloJanela.Location = new System.Drawing.Point(7, 19);
            this._lblTituloJanela.Name = "_lblTituloJanela";
            this._lblTituloJanela.Size = new System.Drawing.Size(290, 29);
            this._lblTituloJanela.TabIndex = 0;
            this._lblTituloJanela.Text = "Lançamentos Bancários";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Operacao);
            this.groupBox1.Controls.Add(this.cod_BancoComboBox);
            this.groupBox1.Controls.Add(valor_MovimentoLabel);
            this.groupBox1.Controls.Add(this.valor_MovimentoTextBox);
            this.groupBox1.Controls.Add(operacaoLabel);
            this.groupBox1.Controls.Add(numero_DocumentoLabel);
            this.groupBox1.Controls.Add(this.numero_DocumentoTextBox);
            this.groupBox1.Controls.Add(numero_ContaLabel);
            this.groupBox1.Controls.Add(this.numero_ContaTextBox);
            this.groupBox1.Controls.Add(descricao_OperacaoLabel);
            this.groupBox1.Controls.Add(this.descricao_OperacaoTextBox);
            this.groupBox1.Controls.Add(data_LancamentoLabel);
            this.groupBox1.Controls.Add(this.data_LancamentoDateTimePicker);
            this.groupBox1.Controls.Add(cod_BancoLabel);
            this.groupBox1.Controls.Add(cod_LancamentoLabel);
            this.groupBox1.Controls.Add(this.cod_LancamentoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Lançamento";
            // 
            // CB_Operacao
            // 
            this.CB_Operacao.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.CB_Operacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lancamentoBindingSource, "Cod_Operacao", true));
            this.CB_Operacao.DataSource = this.operacaoBindingSource1;
            this.CB_Operacao.DisplayMember = "Descricao_Op";
            this.CB_Operacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Operacao.FormattingEnabled = true;
            this.CB_Operacao.Location = new System.Drawing.Point(146, 65);
            this.CB_Operacao.Name = "CB_Operacao";
            this.CB_Operacao.Size = new System.Drawing.Size(115, 24);
            this.CB_Operacao.TabIndex = 2;
            this.CB_Operacao.ValueMember = "Cod_Operacao";
            this.CB_Operacao.SelectedIndexChanged += new System.EventHandler(this.Lancamentos_Load);
            // 
            // lancamentoBindingSource
            // 
            this.lancamentoBindingSource.DataSource = typeof(sistema.DAL.Lancamento);
            // 
            // operacaoBindingSource1
            // 
            this.operacaoBindingSource1.DataSource = typeof(sistema.DAL.Operacao);
            // 
            // cod_BancoComboBox
            // 
            this.cod_BancoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lancamentoBindingSource, "Cod_Banco", true));
            this.cod_BancoComboBox.DataSource = this.bancoBindingSource;
            this.cod_BancoComboBox.DisplayMember = "Nome_Banco";
            this.cod_BancoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cod_BancoComboBox.FormattingEnabled = true;
            this.cod_BancoComboBox.Location = new System.Drawing.Point(382, 29);
            this.cod_BancoComboBox.Name = "cod_BancoComboBox";
            this.cod_BancoComboBox.Size = new System.Drawing.Size(271, 24);
            this.cod_BancoComboBox.TabIndex = 1;
            this.cod_BancoComboBox.ValueMember = "Cod_Banco";
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(sistema.DAL.Banco);
            // 
            // valor_MovimentoTextBox
            // 
            this.valor_MovimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Valor_Movimento", true));
            this.valor_MovimentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_MovimentoTextBox.Location = new System.Drawing.Point(146, 217);
            this.valor_MovimentoTextBox.MaxLength = 18;
            this.valor_MovimentoTextBox.Name = "valor_MovimentoTextBox";
            this.valor_MovimentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.valor_MovimentoTextBox.TabIndex = 7;
            this.valor_MovimentoTextBox.Text = "0,00\r\n\r\n";
            this.valor_MovimentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numero_DocumentoTextBox
            // 
            this.numero_DocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Numero_Documento", true));
            this.numero_DocumentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_DocumentoTextBox.Location = new System.Drawing.Point(146, 143);
            this.numero_DocumentoTextBox.MaxLength = 20;
            this.numero_DocumentoTextBox.Name = "numero_DocumentoTextBox";
            this.numero_DocumentoTextBox.Size = new System.Drawing.Size(115, 22);
            this.numero_DocumentoTextBox.TabIndex = 5;
            // 
            // numero_ContaTextBox
            // 
            this.numero_ContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Numero_Conta", true));
            this.numero_ContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_ContaTextBox.Location = new System.Drawing.Point(382, 70);
            this.numero_ContaTextBox.MaxLength = 15;
            this.numero_ContaTextBox.Name = "numero_ContaTextBox";
            this.numero_ContaTextBox.Size = new System.Drawing.Size(132, 22);
            this.numero_ContaTextBox.TabIndex = 3;
            // 
            // descricao_OperacaoTextBox
            // 
            this.descricao_OperacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Descricao_Operacao", true));
            this.descricao_OperacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_OperacaoTextBox.Location = new System.Drawing.Point(146, 177);
            this.descricao_OperacaoTextBox.MaxLength = 50;
            this.descricao_OperacaoTextBox.Name = "descricao_OperacaoTextBox";
            this.descricao_OperacaoTextBox.Size = new System.Drawing.Size(303, 22);
            this.descricao_OperacaoTextBox.TabIndex = 6;
            // 
            // data_LancamentoDateTimePicker
            // 
            this.data_LancamentoDateTimePicker.AllowDrop = true;
            this.data_LancamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lancamentoBindingSource, "Data_Lancamento", true));
            this.data_LancamentoDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.data_LancamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_LancamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_LancamentoDateTimePicker.Location = new System.Drawing.Point(146, 105);
            this.data_LancamentoDateTimePicker.Name = "data_LancamentoDateTimePicker";
            this.data_LancamentoDateTimePicker.Size = new System.Drawing.Size(115, 21);
            this.data_LancamentoDateTimePicker.TabIndex = 4;
            this.data_LancamentoDateTimePicker.Value = new System.DateTime(2018, 11, 2, 10, 24, 0, 0);
            // 
            // cod_LancamentoTextBox
            // 
            this.cod_LancamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Cod_Lancamento", true));
            this.cod_LancamentoTextBox.Enabled = false;
            this.cod_LancamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_LancamentoTextBox.Location = new System.Drawing.Point(146, 29);
            this.cod_LancamentoTextBox.Name = "cod_LancamentoTextBox";
            this.cod_LancamentoTextBox.ReadOnly = true;
            this.cod_LancamentoTextBox.Size = new System.Drawing.Size(62, 22);
            this.cod_LancamentoTextBox.TabIndex = 1;
            // 
            // _lblMensagemUsuario
            // 
            this._lblMensagemUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblMensagemUsuario.AutoSize = true;
            this._lblMensagemUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMensagemUsuario.Location = new System.Drawing.Point(6, 417);
            this._lblMensagemUsuario.Name = "_lblMensagemUsuario";
            this._lblMensagemUsuario.Size = new System.Drawing.Size(202, 15);
            this._lblMensagemUsuario.TabIndex = 134;
            this._lblMensagemUsuario.Text = "Responsável Pela Última Alteração:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(LoginLabel);
            this.flowLayoutPanel1.Controls.Add(this.login_NameTextBox);
            this.flowLayoutPanel1.Controls.Add(label19);
            this.flowLayoutPanel1.Controls.Add(this.txt_datalogin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 435);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(707, 54);
            this.flowLayoutPanel1.TabIndex = 133;
            // 
            // login_NameTextBox
            // 
            this.login_NameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.login_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Login_Name", true));
            this.login_NameTextBox.Enabled = false;
            this.login_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_NameTextBox.Location = new System.Drawing.Point(50, 10);
            this.login_NameTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.login_NameTextBox.Name = "login_NameTextBox";
            this.login_NameTextBox.Size = new System.Drawing.Size(114, 14);
            this.login_NameTextBox.TabIndex = 15;
            // 
            // txt_datalogin
            // 
            this.txt_datalogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_datalogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datalogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lancamentoBindingSource, "Data_Login", true));
            this.txt_datalogin.Location = new System.Drawing.Point(212, 10);
            this.txt_datalogin.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_datalogin.Name = "txt_datalogin";
            this.txt_datalogin.Size = new System.Drawing.Size(155, 13);
            this.txt_datalogin.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_Anterior);
            this.panel1.Controls.Add(this.btn_proximo);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Location = new System.Drawing.Point(3, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 73);
            this.panel1.TabIndex = 2;
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(146, 23);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(85, 30);
            this.btn_Anterior.TabIndex = 4;
            this.btn_Anterior.Text = "Voltar";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(258, 23);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(85, 30);
            this.btn_proximo.TabIndex = 3;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(598, 23);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(85, 30);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(486, 23);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 30);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(372, 23);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(85, 30);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(22, 23);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(85, 30);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lblMensagemUsuario);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lblTituloJanela);
            this.Controls.Add(this._lblLinha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamentos Bancários";
            this.Load += new System.EventHandler(this.Lancamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.Label _lblTituloJanela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _lblMensagemUsuario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox login_NameTextBox;
        private System.Windows.Forms.TextBox txt_datalogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox valor_MovimentoTextBox;
        private System.Windows.Forms.BindingSource lancamentoBindingSource;
        private System.Windows.Forms.TextBox numero_DocumentoTextBox;
        private System.Windows.Forms.TextBox numero_ContaTextBox;
        private System.Windows.Forms.TextBox descricao_OperacaoTextBox;
        private System.Windows.Forms.DateTimePicker data_LancamentoDateTimePicker;
        private System.Windows.Forms.TextBox cod_LancamentoTextBox;
        private System.Windows.Forms.ComboBox cod_BancoComboBox;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.ComboBox CB_Operacao;
        private System.Windows.Forms.BindingSource operacaoBindingSource1;
    }
}