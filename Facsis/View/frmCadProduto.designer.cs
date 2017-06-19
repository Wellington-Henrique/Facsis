namespace Facsis.View
{
    partial class frmCadProduto
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
            this.pnlCadProduto = new System.Windows.Forms.Panel();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.txtDataCompraAtual = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblQtdCompra = new System.Windows.Forms.Label();
            this.txtQtdeCompra = new System.Windows.Forms.TextBox();
            this.txtUltimaCompra = new System.Windows.Forms.DateTimePicker();
            this.cbLocacao = new System.Windows.Forms.ComboBox();
            this.lblUltimaCompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblQtdDisponivel = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtdeDisponivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultima_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtIdCon = new System.Windows.Forms.TextBox();
            this.txtNomeCon = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrarAtualizar = new System.Windows.Forms.Button();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlCadProduto.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadProduto
            // 
            this.pnlCadProduto.BackColor = System.Drawing.Color.White;
            this.pnlCadProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadProduto.Controls.Add(this.gbEstoque);
            this.pnlCadProduto.Controls.Add(this.txtUltimaCompra);
            this.pnlCadProduto.Controls.Add(this.cbLocacao);
            this.pnlCadProduto.Controls.Add(this.lblUltimaCompra);
            this.pnlCadProduto.Controls.Add(this.label3);
            this.pnlCadProduto.Controls.Add(this.cbStatus);
            this.pnlCadProduto.Controls.Add(this.label2);
            this.pnlCadProduto.Controls.Add(this.cbFornecedor);
            this.pnlCadProduto.Controls.Add(this.lblPreco);
            this.pnlCadProduto.Controls.Add(this.lblFornecedor);
            this.pnlCadProduto.Controls.Add(this.cbUnidade);
            this.pnlCadProduto.Controls.Add(this.lblNivel);
            this.pnlCadProduto.Controls.Add(this.lblQtdDisponivel);
            this.pnlCadProduto.Controls.Add(this.lblCodigo);
            this.pnlCadProduto.Controls.Add(this.txtPreco);
            this.pnlCadProduto.Controls.Add(this.txtQtdeDisponivel);
            this.pnlCadProduto.Controls.Add(this.label4);
            this.pnlCadProduto.Controls.Add(this.lblNome);
            this.pnlCadProduto.Controls.Add(this.txtId);
            this.pnlCadProduto.Controls.Add(this.txtNome);
            this.pnlCadProduto.Controls.Add(this.txtDescricao);
            this.pnlCadProduto.Location = new System.Drawing.Point(10, 10);
            this.pnlCadProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCadProduto.Name = "pnlCadProduto";
            this.pnlCadProduto.Size = new System.Drawing.Size(650, 300);
            this.pnlCadProduto.TabIndex = 0;
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.txtDataCompraAtual);
            this.gbEstoque.Controls.Add(this.lblDataCompra);
            this.gbEstoque.Controls.Add(this.lblQtdCompra);
            this.gbEstoque.Controls.Add(this.txtQtdeCompra);
            this.gbEstoque.Location = new System.Drawing.Point(477, 143);
            this.gbEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEstoque.Size = new System.Drawing.Size(164, 146);
            this.gbEstoque.TabIndex = 38;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // txtDataCompraAtual
            // 
            this.txtDataCompraAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCompraAtual.Location = new System.Drawing.Point(16, 98);
            this.txtDataCompraAtual.Margin = new System.Windows.Forms.Padding(13, 5, 4, 5);
            this.txtDataCompraAtual.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtDataCompraAtual.Name = "txtDataCompraAtual";
            this.txtDataCompraAtual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataCompraAtual.Size = new System.Drawing.Size(128, 27);
            this.txtDataCompraAtual.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDataCompraAtual, "Data da compra atual.");
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(12, 75);
            this.lblDataCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(96, 20);
            this.lblDataCompra.TabIndex = 33;
            this.lblDataCompra.Text = "Data compra";
            // 
            // lblQtdCompra
            // 
            this.lblQtdCompra.AutoSize = true;
            this.lblQtdCompra.Location = new System.Drawing.Point(12, 37);
            this.lblQtdCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdCompra.Name = "lblQtdCompra";
            this.lblQtdCompra.Size = new System.Drawing.Size(42, 20);
            this.lblQtdCompra.TabIndex = 0;
            this.lblQtdCompra.Text = "Qtde";
            // 
            // txtQtdeCompra
            // 
            this.txtQtdeCompra.Location = new System.Drawing.Point(61, 34);
            this.txtQtdeCompra.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtQtdeCompra.Name = "txtQtdeCompra";
            this.txtQtdeCompra.Size = new System.Drawing.Size(56, 27);
            this.txtQtdeCompra.TabIndex = 0;
            this.txtQtdeCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQtdeCompra, "Quantidade a ser adicionada ao estoque.");
            // 
            // txtUltimaCompra
            // 
            this.txtUltimaCompra.Enabled = false;
            this.txtUltimaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtUltimaCompra.Location = new System.Drawing.Point(10, 101);
            this.txtUltimaCompra.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtUltimaCompra.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtUltimaCompra.Name = "txtUltimaCompra";
            this.txtUltimaCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUltimaCompra.Size = new System.Drawing.Size(98, 27);
            this.txtUltimaCompra.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUltimaCompra, "Data da última compra.");
            // 
            // cbLocacao
            // 
            this.cbLocacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocacao.FormattingEnabled = true;
            this.cbLocacao.Items.AddRange(new object[] {
            "Prateleira 1",
            "Prateleira 2",
            "Prateleira 3",
            "Prateleira 4",
            "Prateleira 5",
            "Prateleira 6",
            "Prateleira 7",
            "Prateleira 8",
            "Prateleira 9",
            "Prateleira 10"});
            this.cbLocacao.Location = new System.Drawing.Point(125, 100);
            this.cbLocacao.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbLocacao.Name = "cbLocacao";
            this.cbLocacao.Size = new System.Drawing.Size(268, 28);
            this.cbLocacao.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbLocacao, "Local de armazenamento.");
            // 
            // lblUltimaCompra
            // 
            this.lblUltimaCompra.AutoSize = true;
            this.lblUltimaCompra.Location = new System.Drawing.Point(6, 76);
            this.lblUltimaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimaCompra.Name = "lblUltimaCompra";
            this.lblUltimaCompra.Size = new System.Drawing.Size(108, 20);
            this.lblUltimaCompra.TabIndex = 29;
            this.lblUltimaCompra.Text = "Última compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Localização";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbStatus.Location = new System.Drawing.Point(538, 34);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(103, 28);
            this.cbStatus.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbStatus, "Disponibilidade em estoque.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Status";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(10, 235);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(446, 28);
            this.cbFornecedor.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cbFornecedor, "Fornecedor do produto.");
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(570, 76);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 20);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(9, 210);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(84, 20);
            this.lblFornecedor.TabIndex = 32;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "CM",
            "KG",
            "M",
            "UN",
            ""});
            this.cbUnidade.Location = new System.Drawing.Point(483, 101);
            this.cbUnidade.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(77, 28);
            this.cbUnidade.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cbUnidade, "Unidade de medida.");
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(479, 76);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(65, 20);
            this.lblNivel.TabIndex = 28;
            this.lblNivel.Text = "Unidade";
            // 
            // lblQtdDisponivel
            // 
            this.lblQtdDisponivel.AutoSize = true;
            this.lblQtdDisponivel.Location = new System.Drawing.Point(406, 76);
            this.lblQtdDisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdDisponivel.Name = "lblQtdDisponivel";
            this.lblQtdDisponivel.Size = new System.Drawing.Size(62, 20);
            this.lblQtdDisponivel.TabIndex = 34;
            this.lblQtdDisponivel.Text = "Qtd Dis.";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 9);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(574, 101);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(67, 27);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPreco, "Preço do produto.");
            // 
            // txtQtdeDisponivel
            // 
            this.txtQtdeDisponivel.Enabled = false;
            this.txtQtdeDisponivel.Location = new System.Drawing.Point(410, 101);
            this.txtQtdeDisponivel.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtQtdeDisponivel.Name = "txtQtdeDisponivel";
            this.txtQtdeDisponivel.Size = new System.Drawing.Size(56, 27);
            this.txtQtdeDisponivel.TabIndex = 5;
            this.txtQtdeDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQtdeDisponivel, "Quantidade disponível em estoque.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(70, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(10, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 27);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtId, "Código do produto.");
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(448, 27);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do produto.");
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 168);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(446, 27);
            this.txtDescricao.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtDescricao, "Descrição do produto.");
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.nome,
            this.fornecedor,
            this.medida,
            this.status,
            this.ultima_compra,
            this.descricao,
            this.preco,
            this.quantidade,
            this.locacao});
            this.dgvConsulta.Location = new System.Drawing.Point(10, 426);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(650, 159);
            this.dgvConsulta.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dgvConsulta, "Produtos  cadastrados.");
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "Código";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 83;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 75;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 109;
            // 
            // medida
            // 
            this.medida.HeaderText = "Medida";
            this.medida.Name = "medida";
            this.medida.ReadOnly = true;
            this.medida.Width = 85;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 74;
            // 
            // ultima_compra
            // 
            this.ultima_compra.HeaderText = "Última compra";
            this.ultima_compra.Name = "ultima_compra";
            this.ultima_compra.ReadOnly = true;
            this.ultima_compra.Width = 133;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descricão";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 99;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 71;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 112;
            // 
            // locacao
            // 
            this.locacao.HeaderText = "Locação";
            this.locacao.Name = "locacao";
            this.locacao.ReadOnly = true;
            this.locacao.Width = 89;
            // 
            // txtIdCon
            // 
            this.txtIdCon.Location = new System.Drawing.Point(13, 24);
            this.txtIdCon.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtIdCon.Name = "txtIdCon";
            this.txtIdCon.Size = new System.Drawing.Size(80, 27);
            this.txtIdCon.TabIndex = 0;
            this.txtIdCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtIdCon, "Informe o código para consulta.");
            // 
            // txtNomeCon
            // 
            this.txtNomeCon.Location = new System.Drawing.Point(100, 24);
            this.txtNomeCon.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtNomeCon.Name = "txtNomeCon";
            this.txtNomeCon.Size = new System.Drawing.Size(478, 27);
            this.txtNomeCon.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNomeCon, "Informe o nome para consulta.");
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAnterior.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(234, 0);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(38, 38);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "<";
            this.toolTip1.SetToolTip(this.btnAnterior, "Selecionar anterior");
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.DarkGray;
            this.btnProximo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProximo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(282, 0);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(38, 38);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.Text = ">";
            this.toolTip1.SetToolTip(this.btnProximo, "Selecionar próximo.");
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(550, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Clieque aqui para cancelar o cadastro.");
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(440, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btnExcluir, "Clique aqui para excluir o cadastro.");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarAtualizar
            // 
            this.btnCadastrarAtualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrarAtualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCadastrarAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrarAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrarAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAtualizar.Location = new System.Drawing.Point(330, 0);
            this.btnCadastrarAtualizar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCadastrarAtualizar.Name = "btnCadastrarAtualizar";
            this.btnCadastrarAtualizar.Size = new System.Drawing.Size(100, 38);
            this.btnCadastrarAtualizar.TabIndex = 0;
            this.btnCadastrarAtualizar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrarAtualizar, "Clique aqui para efetuar o cadastro.");
            this.btnCadastrarAtualizar.UseVisualStyleBackColor = false;
            this.btnCadastrarAtualizar.Click += new System.EventHandler(this.btnCadastrarAtualizar_Click);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.DimGray;
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesquisa.Controls.Add(this.btnConsultar);
            this.pnlPesquisa.Controls.Add(this.txtIdCon);
            this.pnlPesquisa.Controls.Add(this.label1);
            this.pnlPesquisa.Controls.Add(this.txtNomeCon);
            this.pnlPesquisa.Controls.Add(this.lblConsultar);
            this.pnlPesquisa.Location = new System.Drawing.Point(10, 363);
            this.pnlPesquisa.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(650, 62);
            this.pnlPesquisa.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(586, 18);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(39, 38);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = ">";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Código";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.White;
            this.lblConsultar.Location = new System.Drawing.Point(96, 0);
            this.lblConsultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(135, 20);
            this.lblConsultar.TabIndex = 35;
            this.lblConsultar.Text = "Nome do produto";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnAnterior);
            this.pnlBotoes.Controls.Add(this.btnProximo);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnCadastrarAtualizar);
            this.pnlBotoes.Location = new System.Drawing.Point(10, 315);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(650, 39);
            this.pnlBotoes.TabIndex = 1;
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(670, 600);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.pnlCadProduto);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadProduto";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.pnlCadProduto.ResumeLayout(false);
            this.pnlCadProduto.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCadProduto;
        private System.Windows.Forms.ComboBox cbLocacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblQtdDisponivel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtQtdeDisponivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker txtUltimaCompra;
        private System.Windows.Forms.Label lblUltimaCompra;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.DateTimePicker txtDataCompraAtual;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblQtdCompra;
        private System.Windows.Forms.TextBox txtQtdeCompra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtNomeCon;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrarAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultima_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn locacao;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtIdCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
    }
}