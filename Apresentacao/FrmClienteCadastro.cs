using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Microsoft.SqlServer.Server;
using Negocios;
using Negocios.Interfaces;

namespace Apresentacao
{
    public partial class FrmClienteCadastro : Form
    {
        private readonly AcaoNaTela _acaoNaTela;
        private readonly IPessoaFisicaNegocios _pfNegocios = new PessoaFisicaNegocios();
        private readonly IPessoaJuridicaNegocios _pjNegocios = new PessoaJuridicaNegocios();
        private readonly IClienteNegocios _clienteNegocios = new ClienteNegocios();
       
        public FrmClienteCadastro(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            _acaoNaTela = acaoNaTela;
            InitializeComponent();

            if (acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                this.Text = @"Cadastro de Cliente";
                txtCodigo.ReadOnly = true;
                txtCodigo.TabStop = false;
            }

            if (acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                //this.Text = @"Alteração de Cliente";
                //txtCodigo.Text = cliente.IdPessoa.ToString();
                //txtCodigo.ReadOnly = true;
                //txtCodigo.TabStop = false;
                //txtNome_RazaoSocial.Text = cliente.Nome;
                //txtCpf_Cnpj.Text = cliente.Cpf_Cnpj;
                //txtRg_InscEst.Text = cliente.Rg_InscEst;
                //txtDtNasc_DtAbertura.Text = cliente.DtNasc_DtAbert.ToShortDateString();

            }

            if (acaoNaTela.Equals(AcaoNaTela.Consultar))
            {

                //this.Text = @"Detalhes de Cliente";
                //txtCodigo.Text = cliente.IdPessoa.ToString();
                //txtCodigo.ReadOnly = true;
                //txtCodigo.TabStop = false;
                //txtNome_RazaoSocial.Text = cliente.Nome;
                //txtNome_RazaoSocial.ReadOnly = true;
                //txtNome_RazaoSocial.TabStop = false;
                //txtCpf_Cnpj.Text = cliente.Cpf_Cnpj;
                //txtCpf_Cnpj.ReadOnly = true;
                //txtCpf_Cnpj.TabStop = false;
                //txtRg_InscEst.Text = cliente.Rg_InscEst;
                //txtRg_InscEst.ReadOnly = true;
                //txtRg_InscEst.TabStop = false;
                //txtDtNasc_DtAbertura.Text = cliente.DtNasc_DtAbert.ToShortDateString();
                //txtDtNasc_DtAbertura.ReadOnly = true;
                //txtDtNasc_DtAbertura.TabStop = false;
                //btnConfimar.Enabled = false;
                //btnSalvar.Visible = false;
                //btnSair.Visible = false;
                //btnCancelar.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSair_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          

            if (_acaoNaTela.Equals(AcaoNaTela.Inserir))
            {

              
                try
                {
                   
                    MessageBox.Show(@"Cliente inserido com sucesso!", @"AVISO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Não foi possível cadastrar Cliente", @"ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            if (_acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                
                try
                {
                    var retorno = SalvarPfPj();
                    int id = Convert.ToInt32(retorno);
                    MessageBox.Show(@"Cliente " + id + @" alterado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Não foi possível cadastrar Cliente", @"ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            btnSalvar_Click(sender, e);

        }

        private string SalvarPfPj()
        {

           
            if (_acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                if (rbPessaoFisica.Checked)
                {
                   
                }
                if (rbPessoaJuridica.Checked)
                {
                   
                }

            }

            if (_acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                if (rbPessaoFisica.Checked)
                {
                    var pf = new PessoaFisica();
                   
                    var id = _pfNegocios.Salvar(pf);
                    return id;
                }
                if (rbPessoaJuridica.Checked)
                {
                    var pj = new PessoaJuridica();
                   
                    var id = _pjNegocios.Salvar(pj);
                    return id;
                }

            }

            return null;
        }
    }
}

