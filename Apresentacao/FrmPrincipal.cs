using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmClienteDetalhes();
            frm.ShowDialog();
        }

        private void forncedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmFornecedorDetalhes();
            frm.ShowDialog();
        }
    }
}
