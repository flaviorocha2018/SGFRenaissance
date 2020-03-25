namespace SGFRenaissance
{
    partial class PesquisarCliente
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
            System.Windows.Forms.Label endereço_ClienteLabel1;
            System.Windows.Forms.Label nome_ClienteLabel1;
            System.Windows.Forms.Label cod_Cliente_Contas_a_ReceberLabel1;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label identificacaoLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label municipio_ClienteLabel;
            System.Windows.Forms.Label bairro_ClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarCliente));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limparconsulta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sGFRenaissanceDataSet = new SGFRenaissance.SGFRenaissanceDataSet();
            this.clientes_Contas_a_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientes_Contas_a_ReceberTableAdapter = new SGFRenaissance.SGFRenaissanceDataSetTableAdapters.Clientes_Contas_a_ReceberTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.SGFRenaissanceDataSetTableAdapters.TableAdapterManager();
            this.Gb_PesquisaCliente = new System.Windows.Forms.GroupBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.identificacaoTextBox = new System.Windows.Forms.TextBox();
            this.cNPJTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.bairro_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.municipio_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.endereço_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.nome_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.cod_Cliente_Contas_a_ReceberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Clientes = new System.Windows.Forms.DataGridView();
            this.codClienteContasaReceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            endereço_ClienteLabel1 = new System.Windows.Forms.Label();
            nome_ClienteLabel1 = new System.Windows.Forms.Label();
            cod_Cliente_Contas_a_ReceberLabel1 = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            identificacaoLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            municipio_ClienteLabel = new System.Windows.Forms.Label();
            bairro_ClienteLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGFRenaissanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_Contas_a_ReceberBindingSource)).BeginInit();
            this.Gb_PesquisaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // endereço_ClienteLabel1
            // 
            endereço_ClienteLabel1.AutoSize = true;
            endereço_ClienteLabel1.Location = new System.Drawing.Point(16, 58);
            endereço_ClienteLabel1.Name = "endereço_ClienteLabel1";
            endereço_ClienteLabel1.Size = new System.Drawing.Size(104, 15);
            endereço_ClienteLabel1.TabIndex = 52;
            endereço_ClienteLabel1.Text = "Endereço Cliente:";
            // 
            // nome_ClienteLabel1
            // 
            nome_ClienteLabel1.AutoSize = true;
            nome_ClienteLabel1.Location = new System.Drawing.Point(217, 29);
            nome_ClienteLabel1.Name = "nome_ClienteLabel1";
            nome_ClienteLabel1.Size = new System.Drawing.Size(85, 15);
            nome_ClienteLabel1.TabIndex = 50;
            nome_ClienteLabel1.Text = "Nome Cliente:";
            // 
            // cod_Cliente_Contas_a_ReceberLabel1
            // 
            cod_Cliente_Contas_a_ReceberLabel1.AutoSize = true;
            cod_Cliente_Contas_a_ReceberLabel1.Location = new System.Drawing.Point(16, 29);
            cod_Cliente_Contas_a_ReceberLabel1.Name = "cod_Cliente_Contas_a_ReceberLabel1";
            cod_Cliente_Contas_a_ReceberLabel1.Size = new System.Drawing.Size(79, 15);
            cod_Cliente_Contas_a_ReceberLabel1.TabIndex = 48;
            cod_Cliente_Contas_a_ReceberLabel1.Text = "Cód.  Cliente:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(655, 28);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(44, 15);
            statusLabel.TabIndex = 47;
            statusLabel.Text = "Status:";
            // 
            // identificacaoLabel
            // 
            identificacaoLabel.AutoSize = true;
            identificacaoLabel.Location = new System.Drawing.Point(557, 112);
            identificacaoLabel.Name = "identificacaoLabel";
            identificacaoLabel.Size = new System.Drawing.Size(79, 15);
            identificacaoLabel.TabIndex = 46;
            identificacaoLabel.Text = "Identificacao:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(17, 113);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(41, 15);
            cNPJLabel.TabIndex = 45;
            cNPJLabel.Text = "CNPJ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(296, 113);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 15);
            emailLabel.TabIndex = 44;
            emailLabel.Text = "Email:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(372, 85);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(49, 15);
            celularLabel.TabIndex = 43;
            celularLabel.Text = "Celular:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(578, 85);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(58, 15);
            telefoneLabel.TabIndex = 42;
            telefoneLabel.Text = "Telefone:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(748, 85);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(26, 15);
            estadoLabel.TabIndex = 41;
            estadoLabel.Text = "UF:";
            // 
            // municipio_ClienteLabel
            // 
            municipio_ClienteLabel.AutoSize = true;
            municipio_ClienteLabel.Location = new System.Drawing.Point(16, 85);
            municipio_ClienteLabel.Name = "municipio_ClienteLabel";
            municipio_ClienteLabel.Size = new System.Drawing.Size(105, 15);
            municipio_ClienteLabel.TabIndex = 40;
            municipio_ClienteLabel.Text = "Municipio Cliente:";
            // 
            // bairro_ClienteLabel
            // 
            bairro_ClienteLabel.AutoSize = true;
            bairro_ClienteLabel.Location = new System.Drawing.Point(552, 55);
            bairro_ClienteLabel.Name = "bairro_ClienteLabel";
            bairro_ClienteLabel.Size = new System.Drawing.Size(84, 15);
            bairro_ClienteLabel.TabIndex = 39;
            bairro_ClienteLabel.Text = "Bairro Cliente:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(722, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_limparconsulta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 61);
            this.panel1.TabIndex = 2;
            // 
            // btn_limparconsulta
            // 
            this.btn_limparconsulta.BackColor = System.Drawing.Color.Silver;
            this.btn_limparconsulta.Location = new System.Drawing.Point(530, 17);
            this.btn_limparconsulta.Name = "btn_limparconsulta";
            this.btn_limparconsulta.Size = new System.Drawing.Size(105, 30);
            this.btn_limparconsulta.TabIndex = 1;
            this.btn_limparconsulta.Text = "Limpar Consulta";
            this.btn_limparconsulta.UseVisualStyleBackColor = false;
            this.btn_limparconsulta.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sGFRenaissanceDataSet
            // 
            this.sGFRenaissanceDataSet.DataSetName = "SGFRenaissanceDataSet";
            this.sGFRenaissanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientes_Contas_a_ReceberBindingSource
            // 
            this.clientes_Contas_a_ReceberBindingSource.DataMember = "Clientes_Contas_a_Receber";
            this.clientes_Contas_a_ReceberBindingSource.DataSource = this.sGFRenaissanceDataSet;
            // 
            // clientes_Contas_a_ReceberTableAdapter
            // 
            this.clientes_Contas_a_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Clientes_Contas_a_ReceberTableAdapter = this.clientes_Contas_a_ReceberTableAdapter;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.SGFRenaissanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Gb_PesquisaCliente
            // 
            this.Gb_PesquisaCliente.Controls.Add(this.statusTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.identificacaoTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.cNPJTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.emailTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.estadoTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.celularTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.telefoneTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.bairro_ClienteTextBox);
            this.Gb_PesquisaCliente.Controls.Add(this.municipio_ClienteTextBox);
            this.Gb_PesquisaCliente.Controls.Add(endereço_ClienteLabel1);
            this.Gb_PesquisaCliente.Controls.Add(this.endereço_ClienteTextBox);
            this.Gb_PesquisaCliente.Controls.Add(nome_ClienteLabel1);
            this.Gb_PesquisaCliente.Controls.Add(this.nome_ClienteTextBox);
            this.Gb_PesquisaCliente.Controls.Add(cod_Cliente_Contas_a_ReceberLabel1);
            this.Gb_PesquisaCliente.Controls.Add(this.cod_Cliente_Contas_a_ReceberTextBox);
            this.Gb_PesquisaCliente.Controls.Add(statusLabel);
            this.Gb_PesquisaCliente.Controls.Add(identificacaoLabel);
            this.Gb_PesquisaCliente.Controls.Add(cNPJLabel);
            this.Gb_PesquisaCliente.Controls.Add(emailLabel);
            this.Gb_PesquisaCliente.Controls.Add(celularLabel);
            this.Gb_PesquisaCliente.Controls.Add(telefoneLabel);
            this.Gb_PesquisaCliente.Controls.Add(estadoLabel);
            this.Gb_PesquisaCliente.Controls.Add(municipio_ClienteLabel);
            this.Gb_PesquisaCliente.Controls.Add(bairro_ClienteLabel);
            this.Gb_PesquisaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_PesquisaCliente.Location = new System.Drawing.Point(2, 65);
            this.Gb_PesquisaCliente.Name = "Gb_PesquisaCliente";
            this.Gb_PesquisaCliente.Size = new System.Drawing.Size(875, 148);
            this.Gb_PesquisaCliente.TabIndex = 27;
            this.Gb_PesquisaCliente.TabStop = false;
            this.Gb_PesquisaCliente.Text = "Dados do Cliente";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(705, 26);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(122, 21);
            this.statusTextBox.TabIndex = 62;
            // 
            // identificacaoTextBox
            // 
            this.identificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Identificacao", true));
            this.identificacaoTextBox.Location = new System.Drawing.Point(646, 110);
            this.identificacaoTextBox.Name = "identificacaoTextBox";
            this.identificacaoTextBox.Size = new System.Drawing.Size(181, 21);
            this.identificacaoTextBox.TabIndex = 61;
            // 
            // cNPJTextBox
            // 
            this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "CNPJ", true));
            this.cNPJTextBox.Location = new System.Drawing.Point(126, 109);
            this.cNPJTextBox.Name = "cNPJTextBox";
            this.cNPJTextBox.Size = new System.Drawing.Size(145, 21);
            this.cNPJTextBox.TabIndex = 60;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(344, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 21);
            this.emailTextBox.TabIndex = 59;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(780, 82);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(47, 21);
            this.estadoTextBox.TabIndex = 58;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(427, 82);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(122, 21);
            this.celularTextBox.TabIndex = 57;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(646, 82);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(98, 21);
            this.telefoneTextBox.TabIndex = 56;
            // 
            // bairro_ClienteTextBox
            // 
            this.bairro_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Bairro_Cliente", true));
            this.bairro_ClienteTextBox.Location = new System.Drawing.Point(646, 55);
            this.bairro_ClienteTextBox.Name = "bairro_ClienteTextBox";
            this.bairro_ClienteTextBox.Size = new System.Drawing.Size(181, 21);
            this.bairro_ClienteTextBox.TabIndex = 55;
            // 
            // municipio_ClienteTextBox
            // 
            this.municipio_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Municipio_Cliente", true));
            this.municipio_ClienteTextBox.Location = new System.Drawing.Point(126, 82);
            this.municipio_ClienteTextBox.Name = "municipio_ClienteTextBox";
            this.municipio_ClienteTextBox.Size = new System.Drawing.Size(227, 21);
            this.municipio_ClienteTextBox.TabIndex = 54;
            // 
            // endereço_ClienteTextBox
            // 
            this.endereço_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Endereço_Cliente", true));
            this.endereço_ClienteTextBox.Location = new System.Drawing.Point(126, 55);
            this.endereço_ClienteTextBox.Name = "endereço_ClienteTextBox";
            this.endereço_ClienteTextBox.Size = new System.Drawing.Size(326, 21);
            this.endereço_ClienteTextBox.TabIndex = 53;
            // 
            // nome_ClienteTextBox
            // 
            this.nome_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Nome_Cliente", true));
            this.nome_ClienteTextBox.Location = new System.Drawing.Point(316, 26);
            this.nome_ClienteTextBox.Name = "nome_ClienteTextBox";
            this.nome_ClienteTextBox.Size = new System.Drawing.Size(320, 21);
            this.nome_ClienteTextBox.TabIndex = 51;
            // 
            // cod_Cliente_Contas_a_ReceberTextBox
            // 
            this.cod_Cliente_Contas_a_ReceberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientes_Contas_a_ReceberBindingSource, "Cod_Cliente_Contas_a_Receber", true));
            this.cod_Cliente_Contas_a_ReceberTextBox.Location = new System.Drawing.Point(126, 26);
            this.cod_Cliente_Contas_a_ReceberTextBox.Name = "cod_Cliente_Contas_a_ReceberTextBox";
            this.cod_Cliente_Contas_a_ReceberTextBox.Size = new System.Drawing.Size(52, 21);
            this.cod_Cliente_Contas_a_ReceberTextBox.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Pesquisar Cliente:";
            // 
            // DG_Clientes
            // 
            this.DG_Clientes.AllowUserToAddRows = false;
            this.DG_Clientes.AllowUserToDeleteRows = false;
            this.DG_Clientes.AutoGenerateColumns = false;
            this.DG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClienteContasaReceberDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.endereçoClienteDataGridViewTextBoxColumn,
            this.bairroClienteDataGridViewTextBoxColumn,
            this.municipioClienteDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DG_Clientes.DataSource = this.clientes_Contas_a_ReceberBindingSource;
            this.DG_Clientes.Location = new System.Drawing.Point(2, 286);
            this.DG_Clientes.Name = "DG_Clientes";
            this.DG_Clientes.ReadOnly = true;
            this.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Clientes.Size = new System.Drawing.Size(875, 191);
            this.DG_Clientes.TabIndex = 29;
            // 
            // codClienteContasaReceberDataGridViewTextBoxColumn
            // 
            this.codClienteContasaReceberDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cliente_Contas_a_Receber";
            this.codClienteContasaReceberDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codClienteContasaReceberDataGridViewTextBoxColumn.Name = "codClienteContasaReceberDataGridViewTextBoxColumn";
            this.codClienteContasaReceberDataGridViewTextBoxColumn.ReadOnly = true;
            this.codClienteContasaReceberDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeClienteDataGridViewTextBoxColumn.Width = 170;
            // 
            // endereçoClienteDataGridViewTextBoxColumn
            // 
            this.endereçoClienteDataGridViewTextBoxColumn.DataPropertyName = "Endereço_Cliente";
            this.endereçoClienteDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoClienteDataGridViewTextBoxColumn.Name = "endereçoClienteDataGridViewTextBoxColumn";
            this.endereçoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.endereçoClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // bairroClienteDataGridViewTextBoxColumn
            // 
            this.bairroClienteDataGridViewTextBoxColumn.DataPropertyName = "Bairro_Cliente";
            this.bairroClienteDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroClienteDataGridViewTextBoxColumn.Name = "bairroClienteDataGridViewTextBoxColumn";
            this.bairroClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroClienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // municipioClienteDataGridViewTextBoxColumn
            // 
            this.municipioClienteDataGridViewTextBoxColumn.DataPropertyName = "Municipio_Cliente";
            this.municipioClienteDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioClienteDataGridViewTextBoxColumn.Name = "municipioClienteDataGridViewTextBoxColumn";
            this.municipioClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "UF";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 30;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 90;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 120;
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 480);
            this.Controls.Add(this.DG_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gb_PesquisaCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            this.Load += new System.EventHandler(this.PesquisarCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sGFRenaissanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_Contas_a_ReceberBindingSource)).EndInit();
            this.Gb_PesquisaCliente.ResumeLayout(false);
            this.Gb_PesquisaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private SGFRenaissanceDataSet sGFRenaissanceDataSet;
        private System.Windows.Forms.BindingSource clientes_Contas_a_ReceberBindingSource;
        private SGFRenaissanceDataSetTableAdapters.Clientes_Contas_a_ReceberTableAdapter clientes_Contas_a_ReceberTableAdapter;
        private SGFRenaissanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_limparconsulta;
        private System.Windows.Forms.GroupBox Gb_PesquisaCliente;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox identificacaoTextBox;
        private System.Windows.Forms.TextBox cNPJTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox bairro_ClienteTextBox;
        private System.Windows.Forms.TextBox municipio_ClienteTextBox;
        private System.Windows.Forms.TextBox endereço_ClienteTextBox;
        private System.Windows.Forms.TextBox nome_ClienteTextBox;
        private System.Windows.Forms.TextBox cod_Cliente_Contas_a_ReceberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteContasaReceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}