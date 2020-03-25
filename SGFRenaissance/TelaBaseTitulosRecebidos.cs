﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SGFRenaissance
{
    public partial class TelaBaseTitulosRecebidos : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O98051;Initial Catalog=SGFRenaissance;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adapt2;
        Int32 ID = 0;
       
        private DateTime Data_Agora;

        public TelaBaseTitulosRecebidos()
        {
            InitializeComponent();
        }

        private void TelaBaseTitulosRecebidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGV_BaseTitulosRecebidosXNomeBanco.Base_Titulos_Recebidos' table. You can move, or remove it, as needed.
            this.base_Titulos_RecebidosTableAdapter.Fill(this.dGV_BaseTitulosRecebidosXNomeBanco.Base_Titulos_Recebidos);
            // TODO: This line of code loads data into the 'baseTitulosRecebidos.Base_Titulos_Recebidos' table. You can move, or remove it, as needed.
         
           
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void base_Titulos_RecebidosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                ((Lancamentos)Owner).cod_Titulos_recebidos.Text = base_Titulos_RecebidosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ((Lancamentos)Owner).Valor_Tit_Recebidos.Text = base_Titulos_RecebidosDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                ((Lancamentos)Owner).textBoxCod_banco.Text = base_Titulos_RecebidosDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                ((Lancamentos)Owner).Valor_Tit_Recebidos.Focus();
                 this.Close();
            }
        }
    }
}