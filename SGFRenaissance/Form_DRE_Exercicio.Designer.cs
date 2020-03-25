namespace SGFRenaissance
{
    partial class Form_DRE_Exercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DRE_Exercicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.button_execute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxRent = new System.Windows.Forms.TextBox();
            this.textboxCMV = new System.Windows.Forms.TextBox();
            this.txtBox_Impostos = new System.Windows.Forms.TextBox();
            this.txtbox_Receita_Vendas = new System.Windows.Forms.TextBox();
            this.txtBox_Receita_Liquida = new System.Windows.Forms.TextBox();
            this.txtBox_Lucro_Bruto = new System.Windows.Forms.TextBox();
            this.txtBox_Internet_Light = new System.Windows.Forms.TextBox();
            this.txtbox_Manut_Equipamentos = new System.Windows.Forms.TextBox();
            this.txtboxTaxasAdm = new System.Windows.Forms.TextBox();
            this.txtBox_Combustivel = new System.Windows.Forms.TextBox();
            this.txtBoxManut_veiculo = new System.Windows.Forms.TextBox();
            this.txtBoxEventos_Vendas = new System.Windows.Forms.TextBox();
            this.txtBox_Comissions = new System.Windows.Forms.TextBox();
            this.txtBox_Juros_Multas = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtBoxResultadoExercicio = new System.Windows.Forms.TextBox();
            this.txtboxReceita_1 = new System.Windows.Forms.TextBox();
            this.txtboxReceita_2 = new System.Windows.Forms.TextBox();
            this.txtboxReceita_3 = new System.Windows.Forms.TextBox();
            this.txtBoxEquipam_Producao = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.labelLucroBruto = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBoxFolhaPagamento = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFinal);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.button_execute);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 49);
            this.panel1.TabIndex = 0;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "    ";
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(737, 13);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(91, 20);
            this.dtpFinal.TabIndex = 7;
            this.dtpFinal.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "    ";
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(614, 13);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(88, 20);
            this.dtpInicio.TabIndex = 6;
            this.dtpInicio.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // button_execute
            // 
            this.button_execute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_execute.Location = new System.Drawing.Point(834, 13);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(86, 23);
            this.button_execute.TabIndex = 5;
            this.button_execute.Text = "Executar";
            this.button_execute.UseVisualStyleBackColor = true;
            this.button_execute.Click += new System.EventHandler(this.button_execute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(708, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(549, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEMONSTRATIVO DO RESULTADO NO EXERCÍCIO  -  DRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Receita de Vendas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "- Impostos (DAS)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Receita Líquida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = " -  CMV (baseado na compra)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lucro Bruto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Despesas Administrativas ou Fixas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Despesas de Aluguel + Condomínio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Despesas Internet/Telefonia + Luz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Despesas Manut. Equip./Papelaria";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(100, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Despesas com Vendas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Despesas Comissões de Venda\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(100, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Despesas Financeiras";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Juros e multa / Empréstimos / Despesas C.C.\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(100, 470);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Resultado antes do IRPJ e CSLL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(106, 490);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "IRPJ - imposto sobre o faturamento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(106, 508);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(217, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "CSLL - imposto cobrado sobre o faturamento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(100, 527);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(242, 18);
            this.label20.TabIndex = 17;
            this.label20.Text = "Resultado Líquido do Exercício";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(106, 261);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Despesas Taxas Administr. / Consult.";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.Location = new System.Drawing.Point(688, 527);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(109, 40);
            this.btn_imprimir.TabIndex = 19;
            this.btn_imprimir.Text = "       Imprimir ";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_fechar.Location = new System.Drawing.Point(830, 527);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(97, 40);
            this.btn_fechar.TabIndex = 20;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(100, 299);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(208, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Despesas Operacionais / Produção";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(106, 317);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(167, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Despesas Combustível/Produção";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(106, 334);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(181, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Despesas Manut. Veículo/Produção";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(106, 350);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(198, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Despesas Eventos / Vendas /Marketing";
            // 
            // textBoxRent
            // 
            this.textBoxRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRent.Enabled = false;
            this.textBoxRent.Location = new System.Drawing.Point(422, 200);
            this.textBoxRent.MaxLength = 18;
            this.textBoxRent.Name = "textBoxRent";
            this.textBoxRent.ReadOnly = true;
            this.textBoxRent.Size = new System.Drawing.Size(111, 13);
            this.textBoxRent.TabIndex = 25;
            this.textBoxRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxCMV
            // 
            this.textboxCMV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxCMV.Enabled = false;
            this.textboxCMV.Location = new System.Drawing.Point(422, 137);
            this.textboxCMV.Name = "textboxCMV";
            this.textboxCMV.ReadOnly = true;
            this.textboxCMV.Size = new System.Drawing.Size(111, 13);
            this.textboxCMV.TabIndex = 27;
            this.textboxCMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Impostos
            // 
            this.txtBox_Impostos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Impostos.Enabled = false;
            this.txtBox_Impostos.Location = new System.Drawing.Point(422, 85);
            this.txtBox_Impostos.Name = "txtBox_Impostos";
            this.txtBox_Impostos.ReadOnly = true;
            this.txtBox_Impostos.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Impostos.TabIndex = 28;
            this.txtBox_Impostos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Receita_Vendas
            // 
            this.txtbox_Receita_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Receita_Vendas.Enabled = false;
            this.txtbox_Receita_Vendas.Location = new System.Drawing.Point(422, 63);
            this.txtbox_Receita_Vendas.Name = "txtbox_Receita_Vendas";
            this.txtbox_Receita_Vendas.ReadOnly = true;
            this.txtbox_Receita_Vendas.Size = new System.Drawing.Size(111, 13);
            this.txtbox_Receita_Vendas.TabIndex = 29;
            this.txtbox_Receita_Vendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Receita_Liquida
            // 
            this.txtBox_Receita_Liquida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Receita_Liquida.Enabled = false;
            this.txtBox_Receita_Liquida.Location = new System.Drawing.Point(422, 112);
            this.txtBox_Receita_Liquida.Name = "txtBox_Receita_Liquida";
            this.txtBox_Receita_Liquida.ReadOnly = true;
            this.txtBox_Receita_Liquida.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Receita_Liquida.TabIndex = 30;
            this.txtBox_Receita_Liquida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Lucro_Bruto
            // 
            this.txtBox_Lucro_Bruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Lucro_Bruto.Enabled = false;
            this.txtBox_Lucro_Bruto.Location = new System.Drawing.Point(422, 165);
            this.txtBox_Lucro_Bruto.Name = "txtBox_Lucro_Bruto";
            this.txtBox_Lucro_Bruto.ReadOnly = true;
            this.txtBox_Lucro_Bruto.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Lucro_Bruto.TabIndex = 31;
            this.txtBox_Lucro_Bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Internet_Light
            // 
            this.txtBox_Internet_Light.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Internet_Light.Enabled = false;
            this.txtBox_Internet_Light.Location = new System.Drawing.Point(422, 223);
            this.txtBox_Internet_Light.Name = "txtBox_Internet_Light";
            this.txtBox_Internet_Light.ReadOnly = true;
            this.txtBox_Internet_Light.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Internet_Light.TabIndex = 32;
            this.txtBox_Internet_Light.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Manut_Equipamentos
            // 
            this.txtbox_Manut_Equipamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Manut_Equipamentos.Enabled = false;
            this.txtbox_Manut_Equipamentos.Location = new System.Drawing.Point(422, 240);
            this.txtbox_Manut_Equipamentos.Name = "txtbox_Manut_Equipamentos";
            this.txtbox_Manut_Equipamentos.ReadOnly = true;
            this.txtbox_Manut_Equipamentos.Size = new System.Drawing.Size(111, 13);
            this.txtbox_Manut_Equipamentos.TabIndex = 33;
            this.txtbox_Manut_Equipamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxTaxasAdm
            // 
            this.txtboxTaxasAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxTaxasAdm.Enabled = false;
            this.txtboxTaxasAdm.Location = new System.Drawing.Point(422, 259);
            this.txtboxTaxasAdm.Name = "txtboxTaxasAdm";
            this.txtboxTaxasAdm.ReadOnly = true;
            this.txtboxTaxasAdm.Size = new System.Drawing.Size(111, 13);
            this.txtboxTaxasAdm.TabIndex = 34;
            this.txtboxTaxasAdm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Combustivel
            // 
            this.txtBox_Combustivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Combustivel.Enabled = false;
            this.txtBox_Combustivel.Location = new System.Drawing.Point(422, 312);
            this.txtBox_Combustivel.Name = "txtBox_Combustivel";
            this.txtBox_Combustivel.ReadOnly = true;
            this.txtBox_Combustivel.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Combustivel.TabIndex = 35;
            this.txtBox_Combustivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxManut_veiculo
            // 
            this.txtBoxManut_veiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxManut_veiculo.Enabled = false;
            this.txtBoxManut_veiculo.Location = new System.Drawing.Point(422, 332);
            this.txtBoxManut_veiculo.Name = "txtBoxManut_veiculo";
            this.txtBoxManut_veiculo.ReadOnly = true;
            this.txtBoxManut_veiculo.Size = new System.Drawing.Size(111, 13);
            this.txtBoxManut_veiculo.TabIndex = 36;
            this.txtBoxManut_veiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxEventos_Vendas
            // 
            this.txtBoxEventos_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEventos_Vendas.Enabled = false;
            this.txtBoxEventos_Vendas.Location = new System.Drawing.Point(422, 349);
            this.txtBoxEventos_Vendas.Name = "txtBoxEventos_Vendas";
            this.txtBoxEventos_Vendas.ReadOnly = true;
            this.txtBoxEventos_Vendas.Size = new System.Drawing.Size(111, 13);
            this.txtBoxEventos_Vendas.TabIndex = 37;
            this.txtBoxEventos_Vendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Comissions
            // 
            this.txtBox_Comissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Comissions.Enabled = false;
            this.txtBox_Comissions.Location = new System.Drawing.Point(422, 396);
            this.txtBox_Comissions.Name = "txtBox_Comissions";
            this.txtBox_Comissions.ReadOnly = true;
            this.txtBox_Comissions.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Comissions.TabIndex = 38;
            this.txtBox_Comissions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Juros_Multas
            // 
            this.txtBox_Juros_Multas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Juros_Multas.Enabled = false;
            this.txtBox_Juros_Multas.Location = new System.Drawing.Point(422, 444);
            this.txtBox_Juros_Multas.Name = "txtBox_Juros_Multas";
            this.txtBox_Juros_Multas.ReadOnly = true;
            this.txtBox_Juros_Multas.Size = new System.Drawing.Size(111, 13);
            this.txtBox_Juros_Multas.TabIndex = 39;
            this.txtBox_Juros_Multas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(422, 484);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(111, 13);
            this.textBox9.TabIndex = 40;
            this.textBox9.Text = "0,00";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(422, 505);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(111, 13);
            this.textBox10.TabIndex = 41;
            this.textBox10.Text = "0,00";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxResultadoExercicio
            // 
            this.txtBoxResultadoExercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxResultadoExercicio.Enabled = false;
            this.txtBoxResultadoExercicio.Location = new System.Drawing.Point(422, 530);
            this.txtBoxResultadoExercicio.Name = "txtBoxResultadoExercicio";
            this.txtBoxResultadoExercicio.ReadOnly = true;
            this.txtBoxResultadoExercicio.Size = new System.Drawing.Size(111, 13);
            this.txtBoxResultadoExercicio.TabIndex = 42;
            this.txtBoxResultadoExercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxReceita_1
            // 
            this.txtboxReceita_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxReceita_1.Enabled = false;
            this.txtboxReceita_1.Location = new System.Drawing.Point(539, 60);
            this.txtboxReceita_1.Name = "txtboxReceita_1";
            this.txtboxReceita_1.ReadOnly = true;
            this.txtboxReceita_1.Size = new System.Drawing.Size(100, 13);
            this.txtboxReceita_1.TabIndex = 43;
            // 
            // txtboxReceita_2
            // 
            this.txtboxReceita_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxReceita_2.Enabled = false;
            this.txtboxReceita_2.Location = new System.Drawing.Point(645, 59);
            this.txtboxReceita_2.Name = "txtboxReceita_2";
            this.txtboxReceita_2.ReadOnly = true;
            this.txtboxReceita_2.Size = new System.Drawing.Size(97, 13);
            this.txtboxReceita_2.TabIndex = 44;
            // 
            // txtboxReceita_3
            // 
            this.txtboxReceita_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxReceita_3.Enabled = false;
            this.txtboxReceita_3.Location = new System.Drawing.Point(748, 60);
            this.txtboxReceita_3.Name = "txtboxReceita_3";
            this.txtboxReceita_3.ReadOnly = true;
            this.txtboxReceita_3.Size = new System.Drawing.Size(100, 13);
            this.txtboxReceita_3.TabIndex = 45;
            // 
            // txtBoxEquipam_Producao
            // 
            this.txtBoxEquipam_Producao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEquipam_Producao.Enabled = false;
            this.txtBoxEquipam_Producao.Location = new System.Drawing.Point(422, 367);
            this.txtBoxEquipam_Producao.Name = "txtBoxEquipam_Producao";
            this.txtBoxEquipam_Producao.ReadOnly = true;
            this.txtBoxEquipam_Producao.Size = new System.Drawing.Size(111, 13);
            this.txtBoxEquipam_Producao.TabIndex = 46;
            this.txtBoxEquipam_Producao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(106, 367);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(188, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Despesas Manut. Equipam./Produção";
            // 
            // labelLucroBruto
            // 
            this.labelLucroBruto.AutoSize = true;
            this.labelLucroBruto.Location = new System.Drawing.Point(561, 164);
            this.labelLucroBruto.Name = "labelLucroBruto";
            this.labelLucroBruto.Size = new System.Drawing.Size(28, 13);
            this.labelLucroBruto.TabIndex = 48;
            this.labelLucroBruto.Text = "       \r\n";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(106, 278);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(218, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "Despesas de Folha de Pagamento / Pessoal";
            // 
            // txtBoxFolhaPagamento
            // 
            this.txtBoxFolhaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFolhaPagamento.Enabled = false;
            this.txtBoxFolhaPagamento.Location = new System.Drawing.Point(422, 278);
            this.txtBoxFolhaPagamento.Name = "txtBoxFolhaPagamento";
            this.txtBoxFolhaPagamento.ReadOnly = true;
            this.txtBoxFolhaPagamento.Size = new System.Drawing.Size(111, 13);
            this.txtBoxFolhaPagamento.TabIndex = 50;
            this.txtBoxFolhaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_DRE_Exercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 579);
            this.Controls.Add(this.txtBoxFolhaPagamento);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.labelLucroBruto);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBoxEquipam_Producao);
            this.Controls.Add(this.txtboxReceita_3);
            this.Controls.Add(this.txtboxReceita_2);
            this.Controls.Add(this.txtboxReceita_1);
            this.Controls.Add(this.txtBoxResultadoExercicio);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtBox_Juros_Multas);
            this.Controls.Add(this.txtBox_Comissions);
            this.Controls.Add(this.txtBoxEventos_Vendas);
            this.Controls.Add(this.txtBoxManut_veiculo);
            this.Controls.Add(this.txtBox_Combustivel);
            this.Controls.Add(this.txtboxTaxasAdm);
            this.Controls.Add(this.txtbox_Manut_Equipamentos);
            this.Controls.Add(this.txtBox_Internet_Light);
            this.Controls.Add(this.txtBox_Lucro_Bruto);
            this.Controls.Add(this.txtBox_Receita_Liquida);
            this.Controls.Add(this.txtbox_Receita_Vendas);
            this.Controls.Add(this.txtBox_Impostos);
            this.Controls.Add(this.textboxCMV);
            this.Controls.Add(this.textBoxRent);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DRE_Exercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstrativo do Resultado do Exercício";
            this.Load += new System.EventHandler(this.Form_DRE_Exercicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button button_execute;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxRent;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox textboxCMV;
        private System.Windows.Forms.TextBox txtBox_Impostos;
        private System.Windows.Forms.TextBox txtbox_Receita_Vendas;
        private System.Windows.Forms.TextBox txtBox_Receita_Liquida;
        private System.Windows.Forms.TextBox txtBox_Lucro_Bruto;
        private System.Windows.Forms.TextBox txtBox_Internet_Light;
        private System.Windows.Forms.TextBox txtbox_Manut_Equipamentos;
        private System.Windows.Forms.TextBox txtboxTaxasAdm;
        private System.Windows.Forms.TextBox txtBox_Combustivel;
        private System.Windows.Forms.TextBox txtBoxManut_veiculo;
        private System.Windows.Forms.TextBox txtBoxEventos_Vendas;
        private System.Windows.Forms.TextBox txtBox_Comissions;
        private System.Windows.Forms.TextBox txtBox_Juros_Multas;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtBoxResultadoExercicio;
        private System.Windows.Forms.TextBox txtboxReceita_1;
        private System.Windows.Forms.TextBox txtboxReceita_2;
        private System.Windows.Forms.TextBox txtboxReceita_3;
        private System.Windows.Forms.TextBox txtBoxEquipam_Producao;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelLucroBruto;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBoxFolhaPagamento;
    }
}