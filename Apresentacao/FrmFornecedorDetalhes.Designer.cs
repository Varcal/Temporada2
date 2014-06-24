namespace Apresentacao
{
    partial class FrmFornecedorDetalhes
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
            this.panelFornecedorDetallhes = new System.Windows.Forms.Panel();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.panelFornecedorMenu = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFornecedorDetalhe = new System.Windows.Forms.TextBox();
            this.cbFornecedorDetalhe = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFornecedorDetallhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.panelFornecedorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFornecedorDetallhes
            // 
            this.panelFornecedorDetallhes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFornecedorDetallhes.Controls.Add(this.dgvFornecedor);
            this.panelFornecedorDetallhes.Controls.Add(this.panelFornecedorMenu);
            this.panelFornecedorDetallhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFornecedorDetallhes.Location = new System.Drawing.Point(0, 0);
            this.panelFornecedorDetallhes.Name = "panelFornecedorDetallhes";
            this.panelFornecedorDetallhes.Size = new System.Drawing.Size(977, 512);
            this.panelFornecedorDetallhes.TabIndex = 2;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCliente,
            this.colNome});
            this.dgvFornecedor.Location = new System.Drawing.Point(13, 179);
            this.dgvFornecedor.MultiSelect = false;
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(948, 315);
            this.dgvFornecedor.TabIndex = 1;
            // 
            // panelFornecedorMenu
            // 
            this.panelFornecedorMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFornecedorMenu.Controls.Add(this.btnBuscar);
            this.panelFornecedorMenu.Controls.Add(this.txtFornecedorDetalhe);
            this.panelFornecedorMenu.Controls.Add(this.cbFornecedorDetalhe);
            this.panelFornecedorMenu.Controls.Add(this.btnSair);
            this.panelFornecedorMenu.Controls.Add(this.btnConsultar);
            this.panelFornecedorMenu.Controls.Add(this.btnAlterar);
            this.panelFornecedorMenu.Controls.Add(this.btnExcluir);
            this.panelFornecedorMenu.Controls.Add(this.btnNovo);
            this.panelFornecedorMenu.Location = new System.Drawing.Point(13, 12);
            this.panelFornecedorMenu.Name = "panelFornecedorMenu";
            this.panelFornecedorMenu.Size = new System.Drawing.Size(948, 152);
            this.panelFornecedorMenu.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(564, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFornecedorDetalhe
            // 
            this.txtFornecedorDetalhe.Location = new System.Drawing.Point(206, 110);
            this.txtFornecedorDetalhe.Name = "txtFornecedorDetalhe";
            this.txtFornecedorDetalhe.Size = new System.Drawing.Size(350, 20);
            this.txtFornecedorDetalhe.TabIndex = 7;
            // 
            // cbFornecedorDetalhe
            // 
            this.cbFornecedorDetalhe.FormattingEnabled = true;
            this.cbFornecedorDetalhe.Items.AddRange(new object[] {
            "Selecione",
            "Código",
            "Nome"});
            this.cbFornecedorDetalhe.Location = new System.Drawing.Point(36, 110);
            this.cbFornecedorDetalhe.Name = "cbFornecedorDetalhe";
            this.cbFornecedorDetalhe.Size = new System.Drawing.Size(146, 21);
            this.cbFornecedorDetalhe.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(623, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 48);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(471, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 48);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(319, 25);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 48);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(167, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 48);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(15, 25);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(136, 48);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // colIdCliente
            // 
            this.colIdCliente.DataPropertyName = "IdFornecedor";
            this.colIdCliente.HeaderText = "Código";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;
            this.colIdCliente.Width = 150;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Fornecedor";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 755;
            // 
            // FrmFornecedorDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 512);
            this.Controls.Add(this.panelFornecedorDetallhes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FrmFornecedorDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes de Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedorDetalhes_Load);
            this.panelFornecedorDetallhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.panelFornecedorMenu.ResumeLayout(false);
            this.panelFornecedorMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFornecedorDetallhes;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Panel panelFornecedorMenu;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFornecedorDetalhe;
        private System.Windows.Forms.ComboBox cbFornecedorDetalhe;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
    }
}