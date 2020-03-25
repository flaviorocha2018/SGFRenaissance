using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFRenaissance
{
    public partial class RelatorioTitulosaReceberemAberto : Form
    {
        public RelatorioTitulosaReceberemAberto()
        {
            InitializeComponent();
        }

        private void RelatorioTitulosaReceberemAberto_Load(object sender, EventArgs e)
        {
          //  this.reportViewer1.RefreshReport();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch
            {

            }
        }
        private void RelatorioTitulosaReceberemAberto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }

}
