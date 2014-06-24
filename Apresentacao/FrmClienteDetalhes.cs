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

        } 

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmClienteCadastro(AcaoNaTela.Inserir,null);
            var result =  frm.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show(@"Nenhum cleinte selecionado", @"AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var clienteSelecionado = dgvCliente.SelectedRows[0].DataBoundItem as Cliente;
            var frm = new FrmClienteCadastro(AcaoNaTela.Alterar, clienteSelecionado);
            var result = frm.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show(@"Nenhum cleinte selecionado", @"AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var clienteSelecionado = dgvCliente.SelectedRows[0].DataBoundItem as Cliente;
            var frm = new FrmClienteCadastro(AcaoNaTela.Consultar, clienteSelecionado);
            frm.ShowDialog();          
        }

        private void AtualizarGrid()
        {
            var clienteCollection =  _clienteNegocios.BuscarTodosAtivos().ToList();
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clienteCollection;
        }

        private void FrmClienteDetalhes_Load(object sender, EventArgs e)
        {          
            AtualizarGrid();
            cbClienteDetalhe.SelectedIndex = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show(@"Nenhum cliente selecionado!", "AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var clienteSelecionado = dgvCliente.SelectedRows[0].DataBoundItem as Cliente;
            var result = MessageBox.Show(@"Deseja mesmo excluir esse registo?", @"PERGUNTA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                
                MessageBox.Show(@"Cliente  excluido com sucesso!", @"AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                AtualizarGrid();
            }
            if (result.Equals(DialogResult.No))
            {
                return;
            }
         }
    }
}
