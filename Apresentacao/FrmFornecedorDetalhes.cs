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
    public partial class FrmFornecedorDetalhes : Form
    {
        private readonly FornecedorNegocios _fornecedorNegocios = new FornecedorNegocios();
        private FornecedorCollection _fornecedorCollection = new FornecedorCollection();
        public FrmFornecedorDetalhes()
        {
            InitializeComponent();
            dgvFornecedor.AutoGenerateColumns = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmFornecedorCadastro(AcaoNaTela.Inserir,null);
            var result = frm.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show(@"Nenhum Fornecedor selecionado!",@"AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var fornSelecionado = dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;
            var frm = new FrmFornecedorCadastro(AcaoNaTela.Consultar, fornSelecionado);
            frm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show(@"Nenhum Fornecedor selecionado!", @"AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var fornSelecionado = dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;
            var frm = new FrmFornecedorCadastro(AcaoNaTela.Alterar, fornSelecionado);
            var result = frm.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        private void AtualizarGrid()
        {
            
            if (!_fornecedorCollection.Any())
            {
                MessageBox.Show(@"Nenhum fornecedor encontrado", @"AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvFornecedor.DataSource = null;
            dgvFornecedor.DataSource = _fornecedorCollection;
        }

       

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show(@"Nenhum fornecedor selecionado!", @"AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var fornSelecionado = dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;

            var result = MessageBox.Show(@"Deseja mesmo excluir esse registro?", @"PERGUNTA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result.Equals(DialogResult.No))
            {
                return;
            }
            if (result.Equals(DialogResult.Yes))
            {
               
                MessageBox.Show(@"Registro excluido com sucesso!", "AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmFornecedorDetalhes_Load(object sender, EventArgs e)
        {          
            
            dgvFornecedor.DataSource = null;
            dgvFornecedor.DataSource = _fornecedorCollection;
            cbFornecedorDetalhe.SelectedIndex = 0;
        }
    }
}