namespace Apresentacao
{
    partial class FrmClienteCadastro
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
            this.panelClienteCadastro = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelClienteForm = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfimar = new System.Windows.Forms.Button();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessaoFisica = new System.Windows.Forms.RadioButton();
            this.txtDtNasc_DtAbertura = new System.Windows.Forms.TextBox();
            this.txtCpf_Cnpj = new System.Windows.Forms.TextBox();
            this.txtRg_InscEst = new System.Windows.Forms.TextBox();
            this.txtNome_RazaoSocial = new System.Windows.Forms.TextBox();
            this.lbDtNasc_DtAbertura = new System.Windows.Forms.Label();
            this.lbRg_InscEst = new System.Windows.Forms.Label();
            this.lbCpf_Cnpj = new System.Windows.Forms.Label();
            this.lbNome_RazaoSocial = new System.Windows.Forms.Label();
            this.panelClienteCadastro.SuspendLayout();
            this.panelClienteForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClienteCadastro
            // 
            this.panelClienteCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelClienteCadastro.Controls.Add(this.btnSair);
            this.panelClienteCadastro.Controls.Add(this.btnSalvar);
            this.panelClienteCadastro.Location = new System.Drawing.Point(12, 12);
            this.panelClienteCadastro.Name = "panelClienteCadastro";
            this.panelClienteCadastro.Size = new System.Drawing.Size(953, 106);
            this.panelClienteCadastro.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(194, 28);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 48);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(42, 28);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(136, 48);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelClienteForm
            // 
            this.panelClienteForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelClienteForm.Controls.Add(this.txtCodigo);
            this.panelClienteForm.Controls.Add(this.lbCodigo);
            this.panelClienteForm.Controls.Add(this.btnCancelar);
            this.panelClienteForm.Controls.Add(this.btnConfimar);
            this.panelClienteForm.Controls.Add(this.rbPessoaJuridica);
            this.panelClienteForm.Controls.Add(this.rbPessaoFisica);
            this.panelClienteForm.Controls.Add(this.txtDtNasc_DtAbertura);
            this.panelClienteForm.Controls.Add(this.txtCpf_Cnpj);
            this.panelClienteForm.Controls.Add(this.txtRg_InscEst);
            this.panelClienteForm.Controls.Add(this.txtNome_RazaoSocial);
            this.panelClienteForm.Controls.Add(this.lbDtNasc_DtAbertura);
            this.panelClienteForm.Controls.Add(this.lbRg_InscEst);
            this.panelClienteForm.Controls.Add(this.lbCpf_Cnpj);
            this.panelClienteForm.Controls.Add(this.lbNome_RazaoSocial);
            this.panelClienteForm.Location = new System.Drawing.Point(12, 132);
            this.panelClienteForm.Name = "panelClienteForm";
            this.panelClienteForm.Size = new System.Drawing.Size(953, 368);
            this.panelClienteForm.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(42, 81);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(42, 68);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "Código";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfimar
            // 
            this.btnConfimar.Location = new System.Drawing.Point(45, 283);
            this.btnConfimar.Name = "btnConfimar";
            this.btnConfimar.Size = new System.Drawing.Size(115, 23);
            this.btnConfimar.TabIndex = 12;
            this.btnConfimar.Text = "Confirmar";
            this.btnConfimar.UseVisualStyleBackColor = true;
            this.btnConfimar.Click += new System.EventHandler(this.btnConfimar_Click);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(153, 44);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(99, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.Text = "Pessoa Juridica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // rbPessaoFisica
            // 
            this.rbPessaoFisica.AutoSize = true;
            this.rbPessaoFisica.Checked = true;
            this.rbPessaoFisica.Location = new System.Drawing.Point(45, 44);
            this.rbPessaoFisica.Name = "rbPessaoFisica";
            this.rbPessaoFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessaoFisica.TabIndex = 0;
            this.rbPessaoFisica.TabStop = true;
            this.rbPessaoFisica.Text = "Pessoa Física";
            this.rbPessaoFisica.UseVisualStyleBackColor = true;
            // 
            // txtDtNasc_DtAbertura
            // 
            this.txtDtNasc_DtAbertura.Location = new System.Drawing.Point(42, 224);
            this.txtDtNasc_DtAbertura.Name = "txtDtNasc_DtAbertura";
            this.txtDtNasc_DtAbertura.Size = new System.Drawing.Size(157, 20);
            this.txtDtNasc_DtAbertura.TabIndex = 11;
            // 
            // txtCpf_Cnpj
            // 
            this.txtCpf_Cnpj.Location = new System.Drawing.Point(42, 175);
            this.txtCpf_Cnpj.Name = "txtCpf_Cnpj";
            this.txtCpf_Cnpj.Size = new System.Drawing.Size(193, 20);
            this.txtCpf_Cnpj.TabIndex = 7;
            // 
            // txtRg_InscEst
            // 
            this.txtRg_InscEst.Location = new System.Drawing.Point(259, 175);
            this.txtRg_InscEst.Name = "txtRg_InscEst";
            this.txtRg_InscEst.Size = new System.Drawing.Size(193, 20);
            this.txtRg_InscEst.TabIndex = 9;
            // 
            // txtNome_RazaoSocial
            // 
            this.txtNome_RazaoSocial.Location = new System.Drawing.Point(42, 126);
            this.txtNome_RazaoSocial.Name = "txtNome_RazaoSocial";
            this.txtNome_RazaoSocial.Size = new System.Drawing.Size(410, 20);
            this.txtNome_RazaoSocial.TabIndex = 5;
            // 
            // lbDtNasc_DtAbertura
            // 
            this.lbDtNasc_DtAbertura.AutoSize = true;
            this.lbDtNasc_DtAbertura.Location = new System.Drawing.Point(42, 211);
            this.lbDtNasc_DtAbertura.Name = "lbDtNasc_DtAbertura";
            this.lbDtNasc_DtAbertura.Size = new System.Drawing.Size(160, 13);
            this.lbDtNasc_DtAbertura.TabIndex = 10;
            this.lbDtNasc_DtAbertura.Text = "Data Nascimento/Data Abertura";
            // 
            // lbRg_InscEst
            // 
            this.lbRg_InscEst.AutoSize = true;
            this.lbRg_InscEst.Location = new System.Drawing.Point(259, 162);
            this.lbRg_InscEst.Name = "lbRg_InscEst";
            this.lbRg_InscEst.Size = new System.Drawing.Size(95, 13);
            this.lbRg_InscEst.TabIndex = 8;
            this.lbRg_InscEst.Text = "RG/Insc. Estadual";
            // 
            // lbCpf_Cnpj
            // 
            this.lbCpf_Cnpj.AutoSize = true;
            this.lbCpf_Cnpj.Location = new System.Drawing.Point(42, 162);
            this.lbCpf_Cnpj.Name = "lbCpf_Cnpj";
            this.lbCpf_Cnpj.Size = new System.Drawing.Size(59, 13);
            this.lbCpf_Cnpj.TabIndex = 6;
            this.lbCpf_Cnpj.Text = "CPF/CNPJ";
            // 
            // lbNome_RazaoSocial
            // 
            this.lbNome_RazaoSocial.AutoSize = true;
            this.lbNome_RazaoSocial.Location = new System.Drawing.Point(42, 113);
            this.lbNome_RazaoSocial.Name = "lbNome_RazaoSocial";
            this.lbNome_RazaoSocial.Size = new System.Drawing.Size(103, 13);
            this.lbNome_RazaoSocial.TabIndex = 4;
            this.lbNome_RazaoSocial.Text = "Nome/Razão Social";
            // 
            // FrmClienteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 512);
            this.Controls.Add(this.panelClienteForm);
            this.Controls.Add(this.panelClienteCadastro);
            this.Name = "FrmClienteCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.panelClienteCadastro.ResumeLayout(false);
            this.panelClienteForm.ResumeLayout(false);
            this.panelClienteForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClienteCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelClienteForm;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDtNasc_DtAbertura;
        private System.Windows.Forms.TextBox txtCpf_Cnpj;
        private System.Windows.Forms.TextBox txtRg_InscEst;
        private System.Windows.Forms.TextBox txtNome_RazaoSocial;
        private System.Windows.Forms.Label lbDtNasc_DtAbertura;
        private System.Windows.Forms.Label lbRg_InscEst;
        private System.Windows.Forms.Label lbCpf_Cnpj;
        private System.Windows.Forms.Label lbNome_RazaoSocial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfimar;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessaoFisica;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}