using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Negocios;

namespace Apresentacao
{
    public partial class FrmClienteDetalhes : Form
    {

        private readonly ClienteNegocios _clienteNegocios = new ClienteNegocios();
        private  ClienteCollection _clienteCollection = new ClienteCollection();

        public FrmClienteDetalhes()
        {
            InitializeComponent();
            dgvCliente.AutoGenerateColumns = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _clienteCollection = (ClienteCollection) _clienteNegocios.BuscarTodos();
            if (!_clienteCollection.Any())
            {
                MessageBox.Show(@"Nenhum cliente encontrado", @"AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = _clienteCollection;
        }
    }
}
