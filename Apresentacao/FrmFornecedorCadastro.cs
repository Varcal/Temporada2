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
using Negocios.Interfaces;

namespace Apresentacao
{
    public partial class FrmFornecedorCadastro : Form
    {
        private readonly AcaoNaTela _acaoNaTela;
        private readonly IPessoaFisicaNegocios _pfNegocios = new PessoaFisicaNegocios();
        private readonly IPessoaJuridicaNegocios _pjNegocios = new PessoaJuridicaNegocios();
       

        public FrmFornecedorCadastro(AcaoNaTela acaoNaTela, Fornecedor fornecedor)
        {
            InitializeComponent();
            _acaoNaTela = acaoNaTela;

            if (acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                this.Text = @"Cadastro de Fornecedor";
                txtCodigo.ReadOnly = true;
                txtCodigo.TabStop = false;
            }

            if (acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                this.Text = @"Alteração de Fornecedor";
                txtCodigo.Text = fornecedor.IdFornecedor.ToString();
                txtCodigo.ReadOnly = true;
                txtCodigo.TabStop = false;
                txtNome_RazaoSocial.Text = fornecedor.Nome;
                txtNome_RazaoSocial.Focus();
                txtCpf_Cnpj.Text = fornecedor.Cpf_Cnpj;
                txtRg_InscEst.Text = fornecedor.Rg_InscEst;
                txtDtNasc_DtAbertura.Text = fornecedor.DtNasc_DtAbertura.ToShortDateString();
            }

            if (acaoNaTela.Equals(AcaoNaTela.Consultar))
            {

                this.Text = @"Detalhes Fornecedor";
                if (fornecedor.IdPessoaTipo.Equals(1))
                {
                    rbPessaoFisica.Checked = true;
                    rbPessoaJuridica.Checked = false;
                }

                if (fornecedor.IdPessoaTipo.Equals(2))
                {
                    rbPessoaJuridica.Checked = true;
                    rbPessaoFisica.Checked = false;
                }
                rbPessaoFisica.Enabled = false;
                rbPessoaJuridica.Enabled = false;
                txtCodigo.Text = fornecedor.IdFornecedor.ToString();
                txtCodigo.ReadOnly = true;
                txtCodigo.TabStop = false;
                txtNome_RazaoSocial.Text = fornecedor.Nome;
                txtNome_RazaoSocial.ReadOnly = true;
                txtCpf_Cnpj.Text = fornecedor.Cpf_Cnpj;
                txtCpf_Cnpj.ReadOnly = true;
                txtRg_InscEst.Text = fornecedor.Rg_InscEst;
                txtRg_InscEst.ReadOnly = true;
                txtDtNasc_DtAbertura.Text = fornecedor.DtNasc_DtAbertura.ToShortDateString();
                txtDtNasc_DtAbertura.ReadOnly = true;
                btnConfimar.Enabled = false;
                btnSalvar.Visible = false;
                btnSair.Visible = false;
                btnCancelar.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                try
                {
                    var forn = new Fornecedor();
                    forn.Nome = txtNome_RazaoSocial.Text;
                    forn.Cpf_Cnpj = txtCpf_Cnpj.Text;
                    forn.Rg_InscEst = txtRg_InscEst.Text;
                    forn.DtNasc_DtAbertura = Convert.ToDateTime(txtDtNasc_DtAbertura.Text);

                    var id = SalvarPfPj(forn);

                    int retorno = Convert.ToInt32(id);

                    MessageBox.Show(@"Fornecedor " + id + @" inserido com sucesso!", @"AVISO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.Yes;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(@"Erro ao inserir Fornecedor!", @"ERRO", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private string SalvarPfPj(Fornecedor fornecedor)
        {
            var pf = new PessoaFisica();
            var pj = new PessoaJuridica();

            if (_acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                try
                {
                    var id = "";
                    if (rbPessaoFisica.Checked.Equals(true))
                    {
                        rbPessoaJuridica.Checked = false;
                        pf.Nome = fornecedor.Nome;
                        pf.Cpf = fornecedor.Cpf_Cnpj;
                        pf.Rg = fornecedor.Rg_InscEst;
                        pf.DtNascimento = fornecedor.DtNasc_DtAbertura;
                        id = _pfNegocios.Salvar(pf);
                    }
                    if (rbPessoaJuridica.Checked.Equals(true))
                    {
                        rbPessaoFisica.Checked = false;
                        pj.RazaoSocial = fornecedor.Nome;
                        pj.Cnpj = fornecedor.Cpf_Cnpj;
                        pj.InscEst = fornecedor.Rg_InscEst;
                        pj.DtAbertura = Convert.ToDateTime(fornecedor.DtNasc_DtAbertura);
                        id = _pjNegocios.Salvar(pj);
                    }

                    fornecedor.IdFornecedor = Convert.ToInt32(id);
                    
                    return id;

                }
                catch (Exception ex)
                {


                    return ex.Message;
                }
            }

            if (_acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                try
                {
                    var id = "";
                    if (fornecedor.IdPessoaTipo.Equals(1))
                    {
                        rbPessaoFisica.Checked = true;
                        rbPessoaJuridica.Checked = false;
                        pf.IdPessoaFisica = fornecedor.IdFornecedor;
                        pf.Nome = fornecedor.Nome;
                        pf.Cpf = fornecedor.Cpf_Cnpj;
                        pf.Rg = fornecedor.Rg_InscEst;
                        pf.DtNascimento = fornecedor.DtNasc_DtAbertura;
                        id = _pfNegocios.Salvar(pf);


                    }
                    if (fornecedor.IdPessoaTipo.Equals(2))
                    {
                        rbPessoaJuridica.Checked = true;
                        rbPessaoFisica.Checked = false;
                        pj.IdPessoaJuridica = fornecedor.IdFornecedor;
                        pj.RazaoSocial = fornecedor.Nome;
                        pj.Cnpj = fornecedor.Cpf_Cnpj;
                        pj.InscEst = fornecedor.Rg_InscEst;
                        pj.DtAbertura = Convert.ToDateTime(fornecedor.DtNasc_DtAbertura);
                        id = _pjNegocios.Salvar(pj);
                    }
                    return id;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            }


            return null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            btnSalvar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSair_Click(sender,e);
        }   
    }
}
