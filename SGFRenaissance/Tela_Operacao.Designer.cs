namespace SGFRenaissance
{
    partial class Tela_Operacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Operacao));
            this.label1 = new System.Windows.Forms.Label();
            this._lblLinha = new System.Windows.Forms.Label();
            this.operacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.operacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelecionarOperacao = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Operação desejada";
            // 
            // _lblLinha
            // 
            this._lblLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblLinha.AutoSize = true;
            this._lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLinha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this._lblLinha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblLinha.Location = new System.Drawing.Point(-132, 34);
            this._lblLinha.Name = "_lblLinha";
            this._lblLinha.Size = new System.Drawing.Size(792, 18);
            this._lblLinha.TabIndex = 117;
            this._lblLinha.Text = "_________________________________________________________________________________" +
    "_________________";
            this._lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // operacaoDataGridView
            // 
            this.operacaoDataGridView.AllowUserToAddRows = false;
            this.operacaoDataGridView.AllowUserToDeleteRows = false;
            this.operacaoDataGridView.AutoGenerateColumns = false;
            this.operacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.SelecionarOperacao});
            this.operacaoDataGridView.DataSource = this.operacaoBindingSource;
            this.operacaoDataGridView.Location = new System.Drawing.Point(2, 55);
            this.operacaoDataGridView.Name = "operacaoDataGridView";
            this.operacaoDataGridView.ReadOnly = true;
            this.operacaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operacaoDataGridView.Size = new System.Drawing.Size(563, 254);
            this.operacaoDataGridView.TabIndex = 118;
            this.operacaoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.operacaoDataGridView_CellContentClick);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(430, 328);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(97, 34);
            this.btn_fechar.TabIndex = 119;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // operacaoBindingSource
            // 
            this.operacaoBindingSource.DataSource = typeof(sistema.DAL.Operacao);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Operacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Operacao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao_Op";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição  Operação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // SelecionarOperacao
            // 
            this.SelecionarOperacao.HeaderText = "Selecionar Operação";
            this.SelecionarOperacao.Name = "SelecionarOperacao";
            this.SelecionarOperacao.ReadOnly = true;
            this.SelecionarOperacao.Text = "Selecionar Operação";
            this.SelecionarOperacao.ToolTipText = "Escolha a operação desejada";
            this.SelecionarOperacao.UseColumnTextForButtonValue = true;
            this.SelecionarOperacao.Width = 130;
            // 
            // Tela_Operacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 386);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.operacaoDataGridView);
            this.Controls.Add(this._lblLinha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Operacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione a Operação";
            this.Load += new System.EventHandler(this.Tela_Operacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblLinha;
        private System.Windows.Forms.BindingSource operacaoBindingSource;
        private System.Windows.Forms.DataGridView operacaoDataGridView;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn SelecionarOperacao;
    }
}