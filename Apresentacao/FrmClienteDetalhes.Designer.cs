namespace Apresentacao
{
    partial class FrmClienteDetalhes
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
            this.panelClienteDetallhes = new System.Windows.Forms.Panel();
            this.panelClienteMenu = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClienteDetalhe = new System.Windows.Forms.TextBox();
            this.cbClienteDetalhe = new System.Windows.Forms.ComboBox();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelClienteDetallhes.SuspendLayout();
            this.panelClienteMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClienteDetallhes
            // 
            this.panelClienteDetallhes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelClienteDetallhes.Controls.Add(this.dgvCliente);
            this.panelClienteDetallhes.Controls.Add(this.panelClienteMenu);
            this.panelClienteDetallhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClienteDetallhes.Location = new System.Drawing.Point(0, 0);
            this.panelClienteDetallhes.Name = "panelClienteDetallhes";
            this.panelClienteDetallhes.Size = new System.Drawing.Size(973, 508);
            this.panelClienteDetallhes.TabIndex = 1;
            // 
            // panelClienteMenu
            // 
            this.panelClienteMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelClienteMenu.Controls.Add(this.btnBuscar);
            this.panelClienteMenu.Controls.Add(this.txtClienteDetalhe);
            this.panelClienteMenu.Controls.Add(this.cbClienteDetalhe);
            this.panelClienteMenu.Controls.Add(this.btnSair);
            this.panelClienteMenu.Controls.Add(this.btnConsultar);
            this.panelClienteMenu.Controls.Add(this.btnAlterar);
            this.panelClienteMenu.Controls.Add(this.btnExcluir);
            this.panelClienteMenu.Controls.Add(this.btnNovo);
            this.panelClienteMenu.Location = new System.Drawing.Point(13, 12);
            this.panelClienteMenu.Name = "panelClienteMenu";
            this.panelClienteMenu.Size = new System.Drawing.Size(948, 152);
            this.panelClienteMenu.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(15, 25);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(136, 48);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(167, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 48);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(319, 25);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 48);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(471, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 48);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
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
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCliente,
            this.colNome});
            this.dgvCliente.Location = new System.Drawing.Point(13, 179);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(948, 315);
            this.dgvCliente.TabIndex = 1;
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
            // txtClienteDetalhe
            // 
            this.txtClienteDetalhe.Location = new System.Drawing.Point(206, 110);
            this.txtClienteDetalhe.Name = "txtClienteDetalhe";
            this.txtClienteDetalhe.Size = new System.Drawing.Size(350, 20);
            this.txtClienteDetalhe.TabIndex = 7;
            // 
            // cbClienteDetalhe
            // 
            this.cbClienteDetalhe.FormattingEnabled = true;
            this.cbClienteDetalhe.Items.AddRange(new object[] {
            "Selecione",
            "Código",
            "Nome"});
            this.cbClienteDetalhe.Location = new System.Drawing.Point(36, 110);
            this.cbClienteDetalhe.Name = "cbClienteDetalhe";
            this.cbClienteDetalhe.Size = new System.Drawing.Size(146, 21);
            this.cbClienteDetalhe.TabIndex = 6;
            // 
            // colIdCliente
            // 
            this.colIdCliente.DataPropertyName = "IdPessoa";
            this.colIdCliente.HeaderText = "Código";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;
            this.colIdCliente.Width = 150;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Cliente";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 755;
            // 
            // FrmClienteDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 508);
            this.Controls.Add(this.panelClienteDetallhes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FrmClienteDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Detalhes";
            this.panelClienteDetallhes.ResumeLayout(false);
            this.panelClienteMenu.ResumeLayout(false);
            this.panelClienteMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClienteDetallhes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panelClienteMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtClienteDetalhe;
        private System.Windows.Forms.ComboBox cbClienteDetalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
    }
}