namespace SGFRenaissance
{
    partial class TelaUpdateParcelaTitPagar
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
            System.Windows.Forms.Label cod_Entrada_Titulos_a_PagarLabel;
            System.Windows.Forms.Label cod_Numero_Parcelas_a_PagarLabel;
            System.Windows.Forms.Label numero_ParcelaLabel;
            System.Windows.Forms.Label data_VencimentoLabel;
            System.Windows.Forms.Label valor_ParcelaLabel;
            System.Windows.Forms.Label historicoLabel;
            System.Windows.Forms.Label cod_Status_TituloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUpdateParcelaTitPagar));
            this.label1 = new System.Windows.Forms.Label();
            this._lblLinha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_Entrada_Titulos_a_PagarTextBox = new System.Windows.Forms.TextBox();
            this.cod_Numero_Parcelas_a_PagarTextBox = new System.Windows.Forms.TextBox();
            this.numero_ParcelaTextBox = new System.Windows.Forms.TextBox();
            this.data_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valor_ParcelaTextBox = new System.Windows.Forms.TextBox();
            this.historicoTextBox = new System.Windows.Forms.TextBox();
            this.cod_Status_TituloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.numero_Parcelas_a_PagarDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_limparconsulta = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.numero_Parcelas_a_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroParcelasaPagarUpdate = new SGFRenaissance.NumeroParcelasaPagarUpdate();
            this.numero_Parcelas_a_PagarTableAdapter = new SGFRenaissance.NumeroParcelasaPagarUpdateTableAdapters.Numero_Parcelas_a_PagarTableAdapter();
            this.tableAdapterManager = new SGFRenaissance.NumeroParcelasaPagarUpdateTableAdapters.TableAdapterManager();
            this.numeroParcelasaPagarDGV = new SGFRenaissance.NumeroParcelasaPagarDGV();
            this.numero_Parcelas_a_PagarTableAdapter1 = new SGFRenaissance.NumeroParcelasaPagarDGVTableAdapters.Numero_Parcelas_a_PagarTableAdapter();
            this.tableAdapterManager1 = new SGFRenaissance.NumeroParcelasaPagarDGVTableAdapters.TableAdapterManager();
            this.ID_Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_Entrada_Titulos_a_PagarLabel = new System.Windows.Forms.Label();
            cod_Numero_Parcelas_a_PagarLabel = new System.Windows.Forms.Label();
            numero_ParcelaLabel = new System.Windows.Forms.Label();
            data_VencimentoLabel = new System.Windows.Forms.Label();
            valor_ParcelaLabel = new System.Windows.Forms.Label();
            historicoLabel = new System.Windows.Forms.Label();
            cod_Status_TituloLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_PagarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaPagarUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaPagarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_Entrada_Titulos_a_PagarLabel
            // 
            cod_Entrada_Titulos_a_PagarLabel.AutoSize = true;
            cod_Entrada_Titulos_a_PagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_Entrada_Titulos_a_PagarLabel.Location = new System.Drawing.Point(8, 30);
            cod_Entrada_Titulos_a_PagarLabel.Name = "cod_Entrada_Titulos_a_PagarLabel";
            cod_Entrada_Titulos_a_PagarLabel.Size = new System.Drawing.Size(128, 15);
            cod_Entrada_Titulos_a_PagarLabel.TabIndex = 0;
            cod_Entrada_Titulos_a_PagarLabel.Text = "Cód. Entr. Tit. a Pagar:";
            // 
            // cod_Numero_Parcelas_a_PagarLabel
            // 
            cod_Numero_Parcelas_a_PagarLabel.AutoSize = true;
            cod_Numero_Parcelas_a_PagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_Numero_Parcelas_a_PagarLabel.Location = new System.Drawing.Point(198, 30);
            cod_Numero_Parcelas_a_PagarLabel.Name = "cod_Numero_Parcelas_a_PagarLabel";
            cod_Numero_Parcelas_a_PagarLabel.Size = new System.Drawing.Size(131, 15);
            cod_Numero_Parcelas_a_PagarLabel.TabIndex = 2;
            cod_Numero_Parcelas_a_PagarLabel.Text = "Cód. Nº  Parc. a Pagar:";
            // 
            // numero_ParcelaLabel
            // 
            numero_ParcelaLabel.AutoSize = true;
            numero_ParcelaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_ParcelaLabel.Location = new System.Drawing.Point(523, 38);
            numero_ParcelaLabel.Name = "numero_ParcelaLabel";
            numero_ParcelaLabel.Size = new System.Drawing.Size(68, 15);
            numero_ParcelaLabel.TabIndex = 4;
            numero_ParcelaLabel.Text = "Nº Parcela:";
            // 
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_VencimentoLabel.Location = new System.Drawing.Point(638, 38);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(104, 15);
            data_VencimentoLabel.TabIndex = 6;
            data_VencimentoLabel.Text = "Data Vencimento:";
            // 
            // valor_ParcelaLabel
            // 
            valor_ParcelaLabel.AutoSize = true;
            valor_ParcelaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_ParcelaLabel.Location = new System.Drawing.Point(8, 60);
            valor_ParcelaLabel.Name = "valor_ParcelaLabel";
            valor_ParcelaLabel.Size = new System.Drawing.Size(83, 15);
            valor_ParcelaLabel.TabIndex = 8;
            valor_ParcelaLabel.Text = "Valor Parcela:";
            // 
            // historicoLabel
            // 
            historicoLabel.AutoSize = true;
            historicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            historicoLabel.Location = new System.Drawing.Point(198, 63);
            historicoLabel.Name = "historicoLabel";
            historicoLabel.Size = new System.Drawing.Size(58, 15);
            historicoLabel.TabIndex = 10;
            historicoLabel.Text = "Historico:";
            // 
            // cod_Status_TituloLabel
            // 
            cod_Status_TituloLabel.AutoSize = true;
            cod_Status_TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_Status_TituloLabel.Location = new System.Drawing.Point(665, 63);
            cod_Status_TituloLabel.Name = "cod_Status_TituloLabel";
            cod_Status_TituloLabel.Size = new System.Drawing.Size(77, 15);
            cod_Status_TituloLabel.TabIndex = 12;
            cod_Status_TituloLabel.Text = "Status Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Atualiza Parcela Títulos a Pagar";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-82, 42);
            this._lblLinha.Margin = new System.Windows.Forms.Padding(0);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(1048, 18);
            this._lblLinha.TabIndex = 126;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "_________________________________________________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cod_Entrada_Titulos_a_PagarLabel);
            this.groupBox1.Controls.Add(this.cod_Entrada_Titulos_a_PagarTextBox);
            this.groupBox1.Controls.Add(cod_Numero_Parcelas_a_PagarLabel);
            this.groupBox1.Controls.Add(this.cod_Numero_Parcelas_a_PagarTextBox);
            this.groupBox1.Controls.Add(numero_ParcelaLabel);
            this.groupBox1.Controls.Add(this.numero_ParcelaTextBox);
            this.groupBox1.Controls.Add(data_VencimentoLabel);
            this.groupBox1.Controls.Add(this.data_VencimentoDateTimePicker);
            this.groupBox1.Controls.Add(valor_ParcelaLabel);
            this.groupBox1.Controls.Add(this.valor_ParcelaTextBox);
            this.groupBox1.Controls.Add(historicoLabel);
            this.groupBox1.Controls.Add(this.historicoTextBox);
            this.groupBox1.Controls.Add(cod_Status_TituloLabel);
            this.groupBox1.Controls.Add(this.cod_Status_TituloTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 96);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Parcela ";
            // 
            // cod_Entrada_Titulos_a_PagarTextBox
            // 
            this.cod_Entrada_Titulos_a_PagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Cod_Entrada_Titulos_a_Pagar", true));
            this.cod_Entrada_Titulos_a_PagarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_Entrada_Titulos_a_PagarTextBox.Location = new System.Drawing.Point(161, 30);
            this.cod_Entrada_Titulos_a_PagarTextBox.Name = "cod_Entrada_Titulos_a_PagarTextBox";
            this.cod_Entrada_Titulos_a_PagarTextBox.ReadOnly = true;
            this.cod_Entrada_Titulos_a_PagarTextBox.Size = new System.Drawing.Size(31, 21);
            this.cod_Entrada_Titulos_a_PagarTextBox.TabIndex = 3;
            // 
            // cod_Numero_Parcelas_a_PagarTextBox
            // 
            this.cod_Numero_Parcelas_a_PagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Cod_Numero_Parcelas_a_Pagar", true));
            this.cod_Numero_Parcelas_a_PagarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_Numero_Parcelas_a_PagarTextBox.Location = new System.Drawing.Point(335, 30);
            this.cod_Numero_Parcelas_a_PagarTextBox.Name = "cod_Numero_Parcelas_a_PagarTextBox";
            this.cod_Numero_Parcelas_a_PagarTextBox.ReadOnly = true;
            this.cod_Numero_Parcelas_a_PagarTextBox.Size = new System.Drawing.Size(39, 21);
            this.cod_Numero_Parcelas_a_PagarTextBox.TabIndex = 4;
            // 
            // numero_ParcelaTextBox
            // 
            this.numero_ParcelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Numero_Parcela", true));
            this.numero_ParcelaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_ParcelaTextBox.Location = new System.Drawing.Point(597, 35);
            this.numero_ParcelaTextBox.MaxLength = 3;
            this.numero_ParcelaTextBox.Name = "numero_ParcelaTextBox";
            this.numero_ParcelaTextBox.Size = new System.Drawing.Size(35, 21);
            this.numero_ParcelaTextBox.TabIndex = 5;
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.CustomFormat = "   ";
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(748, 33);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(117, 21);
            this.data_VencimentoDateTimePicker.TabIndex = 6;
            // 
            // valor_ParcelaTextBox
            // 
            this.valor_ParcelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Valor_Parcela", true));
            this.valor_ParcelaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_ParcelaTextBox.Location = new System.Drawing.Point(97, 60);
            this.valor_ParcelaTextBox.MaxLength = 18;
            this.valor_ParcelaTextBox.Name = "valor_ParcelaTextBox";
            this.valor_ParcelaTextBox.Size = new System.Drawing.Size(95, 21);
            this.valor_ParcelaTextBox.TabIndex = 7;
            // 
            // historicoTextBox
            // 
            this.historicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Historico", true));
            this.historicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicoTextBox.Location = new System.Drawing.Point(262, 63);
            this.historicoTextBox.MaxLength = 100;
            this.historicoTextBox.Name = "historicoTextBox";
            this.historicoTextBox.Size = new System.Drawing.Size(372, 21);
            this.historicoTextBox.TabIndex = 8;
            // 
            // cod_Status_TituloTextBox
            // 
            this.cod_Status_TituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numero_Parcelas_a_PagarBindingSource, "Cod_Status_Titulo", true));
            this.cod_Status_TituloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_Status_TituloTextBox.Location = new System.Drawing.Point(748, 60);
            this.cod_Status_TituloTextBox.MaxLength = 50;
            this.cod_Status_TituloTextBox.Name = "cod_Status_TituloTextBox";
            this.cod_Status_TituloTextBox.Size = new System.Drawing.Size(119, 21);
            this.cod_Status_TituloTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(461, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "Digite o Código da Parcela:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(667, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(597, 406);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(118, 32);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Atualizar Parcela";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(761, 407);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(118, 32);
            this.btn_Sair.TabIndex = 11;
            this.btn_Sair.Text = "Fechar";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // numero_Parcelas_a_PagarDataGridView
            // 
            this.numero_Parcelas_a_PagarDataGridView.AllowUserToAddRows = false;
            this.numero_Parcelas_a_PagarDataGridView.AllowUserToDeleteRows = false;
            this.numero_Parcelas_a_PagarDataGridView.AutoGenerateColumns = false;
            this.numero_Parcelas_a_PagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numero_Parcelas_a_PagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Parcela,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.numero_Parcelas_a_PagarDataGridView.DataSource = this.numero_Parcelas_a_PagarBindingSource;
            this.numero_Parcelas_a_PagarDataGridView.Location = new System.Drawing.Point(7, 176);
            this.numero_Parcelas_a_PagarDataGridView.Name = "numero_Parcelas_a_PagarDataGridView";
            this.numero_Parcelas_a_PagarDataGridView.ReadOnly = true;
            this.numero_Parcelas_a_PagarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.numero_Parcelas_a_PagarDataGridView.Size = new System.Drawing.Size(881, 216);
            this.numero_Parcelas_a_PagarDataGridView.TabIndex = 134;
            // 
            // btn_limparconsulta
            // 
            this.btn_limparconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparconsulta.Location = new System.Drawing.Point(438, 407);
            this.btn_limparconsulta.Name = "btn_limparconsulta";
            this.btn_limparconsulta.Size = new System.Drawing.Size(118, 32);
            this.btn_limparconsulta.TabIndex = 12;
            this.btn_limparconsulta.Text = "Limpar Consulta";
            this.btn_limparconsulta.UseVisualStyleBackColor = true;
            this.btn_limparconsulta.Click += new System.EventHandler(this.btn_limparconsulta_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.Location = new System.Drawing.Point(727, 19);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(81, 23);
            this.btn_filtrar.TabIndex = 2;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // numero_Parcelas_a_PagarBindingSource
            // 
            this.numero_Parcelas_a_PagarBindingSource.DataMember = "Numero_Parcelas_a_Pagar";
            this.numero_Parcelas_a_PagarBindingSource.DataSource = this.numeroParcelasaPagarUpdate;
            // 
            // numeroParcelasaPagarUpdate
            // 
            this.numeroParcelasaPagarUpdate.DataSetName = "NumeroParcelasaPagarUpdate";
            this.numeroParcelasaPagarUpdate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numero_Parcelas_a_PagarTableAdapter
            // 
            this.numero_Parcelas_a_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Numero_Parcelas_a_PagarTableAdapter = this.numero_Parcelas_a_PagarTableAdapter;
            this.tableAdapterManager.UpdateOrder = SGFRenaissance.NumeroParcelasaPagarUpdateTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numeroParcelasaPagarDGV
            // 
            this.numeroParcelasaPagarDGV.DataSetName = "NumeroParcelasaPagarDGV";
            this.numeroParcelasaPagarDGV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numero_Parcelas_a_PagarTableAdapter1
            // 
            this.numero_Parcelas_a_PagarTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Numero_Parcelas_a_PagarTableAdapter = this.numero_Parcelas_a_PagarTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = SGFRenaissance.NumeroParcelasaPagarDGVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ID_Parcela
            // 
            this.ID_Parcela.DataPropertyName = "Cod_Numero_Parcelas_a_Pagar";
            this.ID_Parcela.HeaderText = "Cód. Nº  Parc. a Pagar";
            this.ID_Parcela.Name = "ID_Parcela";
            this.ID_Parcela.ReadOnly = true;
            this.ID_Parcela.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_Entrada_Titulos_a_Pagar";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cód. Entr. Titulos a Pagar";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Numero_Parcela";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nº Parcela";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_Vencimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor_Parcela";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor Parcela";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 98;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Historico";
            this.dataGridViewTextBoxColumn6.HeaderText = "Histórico";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 280;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cod_Status_Titulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status Titulo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // TelaUpdateParcelaTitPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 447);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.btn_limparconsulta);
            this.Controls.Add(this.numero_Parcelas_a_PagarDataGridView);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaUpdateParcelaTitPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Parcela Títulos a Pagar";
            this.Load += new System.EventHandler(this.TelaUpdateParcelaTitPagar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_PagarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_Parcelas_a_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaPagarUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroParcelasaPagarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cod_Entrada_Titulos_a_PagarTextBox;
        private System.Windows.Forms.TextBox cod_Numero_Parcelas_a_PagarTextBox;
        private System.Windows.Forms.TextBox numero_ParcelaTextBox;
        private System.Windows.Forms.DateTimePicker data_VencimentoDateTimePicker;
        private System.Windows.Forms.TextBox valor_ParcelaTextBox;
        private System.Windows.Forms.TextBox historicoTextBox;
        private System.Windows.Forms.TextBox cod_Status_TituloTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Sair;
        private NumeroParcelasaPagarUpdate numeroParcelasaPagarUpdate;
        private System.Windows.Forms.BindingSource numero_Parcelas_a_PagarBindingSource;
        private NumeroParcelasaPagarUpdateTableAdapters.Numero_Parcelas_a_PagarTableAdapter numero_Parcelas_a_PagarTableAdapter;
        private NumeroParcelasaPagarUpdateTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView numero_Parcelas_a_PagarDataGridView;
        private System.Windows.Forms.Button btn_limparconsulta;
        private System.Windows.Forms.Button btn_filtrar;
        private NumeroParcelasaPagarDGV numeroParcelasaPagarDGV;
        private NumeroParcelasaPagarDGVTableAdapters.Numero_Parcelas_a_PagarTableAdapter numero_Parcelas_a_PagarTableAdapter1;
        private NumeroParcelasaPagarDGVTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}