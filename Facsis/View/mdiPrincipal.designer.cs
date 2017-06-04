﻿namespace Facsis.View
{
    partial class mdiPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovoOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelarOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorioVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.efetuadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJanelaCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJanelaHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJanelaVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFecharJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmVendas,
            this.tsmCadastro,
            this.tsmConsultar,
            this.tsmRelatorios,
            this.tsmMostrar,
            this.tsmJanelas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.tsmJanelas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(896, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.tsmMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(58, 24);
            this.tsmMenu.Text = "&Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.exitToolStripMenuItem.Text = "&Trocar de usuário";
            this.exitToolStripMenuItem.ToolTipText = "Entrar com outra conta de usuário..";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.fecharToolStripMenuItem.Text = "&Fechar";
            this.fecharToolStripMenuItem.ToolTipText = "Fechar o sistema.";
            // 
            // tsmVendas
            // 
            this.tsmVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistro,
            this.tsmOrcamento});
            this.tsmVendas.Name = "tsmVendas";
            this.tsmVendas.Size = new System.Drawing.Size(69, 24);
            this.tsmVendas.Text = "&Vendas";
            // 
            // tsmRegistro
            // 
            this.tsmRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovaVenda,
            this.tsmCancelarVenda});
            this.tsmRegistro.Name = "tsmRegistro";
            this.tsmRegistro.Size = new System.Drawing.Size(204, 24);
            this.tsmRegistro.Text = "Registro de vendas";
            // 
            // tsmNovaVenda
            // 
            this.tsmNovaVenda.Name = "tsmNovaVenda";
            this.tsmNovaVenda.Size = new System.Drawing.Size(202, 24);
            this.tsmNovaVenda.Text = "&Nova venda";
            this.tsmNovaVenda.ToolTipText = "Registrar nova venda.";
            // 
            // tsmCancelarVenda
            // 
            this.tsmCancelarVenda.Name = "tsmCancelarVenda";
            this.tsmCancelarVenda.Size = new System.Drawing.Size(202, 24);
            this.tsmCancelarVenda.Text = "&Cancelar pendente";
            this.tsmCancelarVenda.ToolTipText = "Cancelar venda pendente.";
            // 
            // tsmOrcamento
            // 
            this.tsmOrcamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovoOrcamento,
            this.tsmCancelarOrcamento});
            this.tsmOrcamento.Name = "tsmOrcamento";
            this.tsmOrcamento.Size = new System.Drawing.Size(204, 24);
            this.tsmOrcamento.Text = "&Orçamento";
            this.tsmOrcamento.Click += new System.EventHandler(this.tsmOrcamento_Click);
            // 
            // tsmNovoOrcamento
            // 
            this.tsmNovoOrcamento.Name = "tsmNovoOrcamento";
            this.tsmNovoOrcamento.Size = new System.Drawing.Size(202, 24);
            this.tsmNovoOrcamento.Text = "&Novo orçamento";
            this.tsmNovoOrcamento.ToolTipText = "Registrar novo orçamento.";
            // 
            // tsmCancelarOrcamento
            // 
            this.tsmCancelarOrcamento.Name = "tsmCancelarOrcamento";
            this.tsmCancelarOrcamento.Size = new System.Drawing.Size(202, 24);
            this.tsmCancelarOrcamento.Text = "&Cancelar pendente";
            this.tsmCancelarOrcamento.ToolTipText = "Cancelar orçamento pendente.";
            // 
            // tsmCadastro
            // 
            this.tsmCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadCliente,
            this.tsmCadFornecedor,
            this.tsmCadProduto,
            this.tsmCadUsuario});
            this.tsmCadastro.Name = "tsmCadastro";
            this.tsmCadastro.Size = new System.Drawing.Size(86, 24);
            this.tsmCadastro.Text = "&Cadastros";
            // 
            // tsmCadCliente
            // 
            this.tsmCadCliente.Name = "tsmCadCliente";
            this.tsmCadCliente.Size = new System.Drawing.Size(153, 24);
            this.tsmCadCliente.Text = "&Cliente";
            this.tsmCadCliente.Click += new System.EventHandler(this.tsmCadCliente_Click);
            // 
            // tsmCadFornecedor
            // 
            this.tsmCadFornecedor.Name = "tsmCadFornecedor";
            this.tsmCadFornecedor.Size = new System.Drawing.Size(153, 24);
            this.tsmCadFornecedor.Text = "&Fornecedor";
            // 
            // tsmCadProduto
            // 
            this.tsmCadProduto.Name = "tsmCadProduto";
            this.tsmCadProduto.Size = new System.Drawing.Size(153, 24);
            this.tsmCadProduto.Text = "&Produto";
            this.tsmCadProduto.Click += new System.EventHandler(this.tsmCadProduto_Click);
            // 
            // tsmCadUsuario
            // 
            this.tsmCadUsuario.Name = "tsmCadUsuario";
            this.tsmCadUsuario.Size = new System.Drawing.Size(153, 24);
            this.tsmCadUsuario.Text = "&Usuário";
            this.tsmCadUsuario.Click += new System.EventHandler(this.tsmCadUsuario_Click);
            // 
            // tsmConsultar
            // 
            this.tsmConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConsCliente,
            this.tsmConsFornecedor,
            this.tsmConsProduto,
            this.tsmConsUsuario});
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(84, 24);
            this.tsmConsultar.Text = "C&onsultas";
            // 
            // tsmConsCliente
            // 
            this.tsmConsCliente.Name = "tsmConsCliente";
            this.tsmConsCliente.Size = new System.Drawing.Size(153, 24);
            this.tsmConsCliente.Text = "&Cliente";
            // 
            // tsmConsFornecedor
            // 
            this.tsmConsFornecedor.Name = "tsmConsFornecedor";
            this.tsmConsFornecedor.Size = new System.Drawing.Size(153, 24);
            this.tsmConsFornecedor.Text = "&Fornecedor";
            // 
            // tsmConsProduto
            // 
            this.tsmConsProduto.Name = "tsmConsProduto";
            this.tsmConsProduto.Size = new System.Drawing.Size(153, 24);
            this.tsmConsProduto.Text = "&Produto";
            // 
            // tsmConsUsuario
            // 
            this.tsmConsUsuario.Name = "tsmConsUsuario";
            this.tsmConsUsuario.Size = new System.Drawing.Size(153, 24);
            this.tsmConsUsuario.Text = "&Usuário";
            // 
            // tsmRelatorios
            // 
            this.tsmRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRelatorioVenda,
            this.tsmLogUsuario});
            this.tsmRelatorios.Name = "tsmRelatorios";
            this.tsmRelatorios.Size = new System.Drawing.Size(88, 24);
            this.tsmRelatorios.Text = "&Relatórios";
            // 
            // tsmRelatorioVenda
            // 
            this.tsmRelatorioVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuadasToolStripMenuItem,
            this.pendentesToolStripMenuItem,
            this.canceladasToolStripMenuItem});
            this.tsmRelatorioVenda.Name = "tsmRelatorioVenda";
            this.tsmRelatorioVenda.Size = new System.Drawing.Size(176, 24);
            this.tsmRelatorioVenda.Text = "&Vendas";
            // 
            // efetuadasToolStripMenuItem
            // 
            this.efetuadasToolStripMenuItem.Name = "efetuadasToolStripMenuItem";
            this.efetuadasToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.efetuadasToolStripMenuItem.Text = "&Efetuadas";
            this.efetuadasToolStripMenuItem.ToolTipText = "Emitir relatório de vendas efetuadas.";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.pendentesToolStripMenuItem.Text = "&Pendentes";
            this.pendentesToolStripMenuItem.ToolTipText = "Emitir relatório de vendas pendentes.";
            // 
            // canceladasToolStripMenuItem
            // 
            this.canceladasToolStripMenuItem.Name = "canceladasToolStripMenuItem";
            this.canceladasToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.canceladasToolStripMenuItem.Text = "&Canceladas";
            this.canceladasToolStripMenuItem.ToolTipText = "Emitir relatório de vendas canceladas.";
            // 
            // tsmLogUsuario
            // 
            this.tsmLogUsuario.Name = "tsmLogUsuario";
            this.tsmLogUsuario.Size = new System.Drawing.Size(176, 24);
            this.tsmLogUsuario.Text = "&Log de usuário";
            this.tsmLogUsuario.ToolTipText = "Emitir relatórios de log.";
            // 
            // tsmMostrar
            // 
            this.tsmMostrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBarraStatus});
            this.tsmMostrar.Name = "tsmMostrar";
            this.tsmMostrar.Size = new System.Drawing.Size(84, 24);
            this.tsmMostrar.Text = "&Visualizar";
            // 
            // tsmBarraStatus
            // 
            this.tsmBarraStatus.Checked = true;
            this.tsmBarraStatus.CheckOnClick = true;
            this.tsmBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmBarraStatus.Name = "tsmBarraStatus";
            this.tsmBarraStatus.Size = new System.Drawing.Size(176, 24);
            this.tsmBarraStatus.Text = "&Barra de status";
            this.tsmBarraStatus.ToolTipText = "Habilitar ou desabilitar a barra de status.";
            this.tsmBarraStatus.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // tsmJanelas
            // 
            this.tsmJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmJanelaCascata,
            this.tsmJanelaHorizontal,
            this.tsmJanelaVertical,
            this.toolStripSeparator1,
            this.arrangeIconsToolStripMenuItem,
            this.tsmFecharJanelas});
            this.tsmJanelas.Name = "tsmJanelas";
            this.tsmJanelas.Size = new System.Drawing.Size(68, 24);
            this.tsmJanelas.Text = "&Janelas";
            // 
            // tsmJanelaCascata
            // 
            this.tsmJanelaCascata.Name = "tsmJanelaCascata";
            this.tsmJanelaCascata.Size = new System.Drawing.Size(169, 24);
            this.tsmJanelaCascata.Text = "&Cascata";
            this.tsmJanelaCascata.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tsmJanelaHorizontal
            // 
            this.tsmJanelaHorizontal.Name = "tsmJanelaHorizontal";
            this.tsmJanelaHorizontal.Size = new System.Drawing.Size(169, 24);
            this.tsmJanelaHorizontal.Text = "&Horizontal";
            this.tsmJanelaHorizontal.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // tsmJanelaVertical
            // 
            this.tsmJanelaVertical.Name = "tsmJanelaVertical";
            this.tsmJanelaVertical.Size = new System.Drawing.Size(169, 24);
            this.tsmJanelaVertical.Text = "&Vertical";
            this.tsmJanelaVertical.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // tsmFecharJanelas
            // 
            this.tsmFecharJanelas.Name = "tsmFecharJanelas";
            this.tsmFecharJanelas.Size = new System.Drawing.Size(169, 24);
            this.tsmFecharJanelas.Text = "&Fechar todas";
            this.tsmFecharJanelas.ToolTipText = "Fecha todas as telas abertas.";
            this.tsmFecharJanelas.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 629);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(896, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslblStatus.Text = "Status";
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 651);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mdiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facsis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmJanelaHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMostrar;
        private System.Windows.Forms.ToolStripMenuItem tsmBarraStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmJanelas;
        private System.Windows.Forms.ToolStripMenuItem tsmJanelaCascata;
        private System.Windows.Forms.ToolStripMenuItem tsmJanelaVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmFecharJanelas;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmCadCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmCadFornecedor;
        private System.Windows.Forms.ToolStripMenuItem tsmCadProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmCadUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistro;
        private System.Windows.Forms.ToolStripMenuItem tsmNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelarVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tsmNovoOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelarOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorioVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmLogUsuario;
        private System.Windows.Forms.ToolStripMenuItem efetuadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmConsFornecedor;
        private System.Windows.Forms.ToolStripMenuItem tsmConsProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmConsUsuario;
    }
}


