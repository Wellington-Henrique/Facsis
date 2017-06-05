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
            this.cbDataCompra = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblQtdCompra = new System.Windows.Forms.Label();
            this.txtQtdeCompra = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbLocacao = new System.Windows.Forms.ComboBox();
            this.txtUltimaCompra = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtQtdeDisponivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlCadProduto.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadProduto
            // 
            this.pnlCadProduto.Controls.Add(this.gbEstoque);
            this.pnlCadProduto.Controls.Add(this.dateTimePicker1);
            this.pnlCadProduto.Controls.Add(this.cbLocacao);
            this.pnlCadProduto.Controls.Add(this.txtUltimaCompra);
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
            this.pnlCadProduto.Controls.Add(this.textBox1);
            this.pnlCadProduto.Controls.Add(this.txtQtdeDisponivel);
            this.pnlCadProduto.Controls.Add(this.label4);
            this.pnlCadProduto.Controls.Add(this.lblNome);
            this.pnlCadProduto.Controls.Add(this.txtCodigo);
            this.pnlCadProduto.Controls.Add(this.txtNome);
            this.pnlCadProduto.Controls.Add(this.txtDescricao);
            this.pnlCadProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadProduto.Location = new System.Drawing.Point(0, 0);
            this.pnlCadProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCadProduto.Name = "pnlCadProduto";
            this.pnlCadProduto.Size = new System.Drawing.Size(654, 300);
            this.pnlCadProduto.TabIndex = 0;
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.cbDataCompra);
            this.gbEstoque.Controls.Add(this.lblDataCompra);
            this.gbEstoque.Controls.Add(this.lblQtdCompra);
            this.gbEstoque.Controls.Add(this.txtQtdeCompra);
            this.gbEstoque.Enabled = false;
            this.gbEstoque.Location = new System.Drawing.Point(477, 143);
            this.gbEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEstoque.Size = new System.Drawing.Size(164, 146);
            this.gbEstoque.TabIndex = 38;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // cbDataCompra
            // 
            this.cbDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDataCompra.Location = new System.Drawing.Point(16, 98);
            this.cbDataCompra.Margin = new System.Windows.Forms.Padding(13, 5, 4, 5);
            this.cbDataCompra.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cbDataCompra.Name = "cbDataCompra";
            this.cbDataCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDataCompra.Size = new System.Drawing.Size(128, 27);
            this.cbDataCompra.TabIndex = 32;
            this.toolTip1.SetToolTip(this.cbDataCompra, "Data da compra atual.");
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
            this.lblQtdCompra.TabIndex = 30;
            this.lblQtdCompra.Text = "Qtde";
            // 
            // txtQtdeCompra
            // 
            this.txtQtdeCompra.Location = new System.Drawing.Point(61, 34);
            this.txtQtdeCompra.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtQtdeCompra.Name = "txtQtdeCompra";
            this.txtQtdeCompra.Size = new System.Drawing.Size(56, 27);
            this.txtQtdeCompra.TabIndex = 31;
            this.txtQtdeCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQtdeCompra, "Quantidade a ser adicionada ao estoque.");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 101);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Data da última compra.");
            // 
            // cbLocacao
            // 
            this.cbLocacao.FormattingEnabled = true;
            this.cbLocacao.Items.AddRange(new object[] {
            "Prateleira 01",
            "Prateleira 02",
            "Prateleira 03",
            "Prateleira 04",
            "Prateleira 05",
            "Prateleira 06",
            "Prateleira 07",
            "Prateleira 08",
            "Prateleira 09",
            "Prateleira 10"});
            this.cbLocacao.Location = new System.Drawing.Point(125, 100);
            this.cbLocacao.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbLocacao.Name = "cbLocacao";
            this.cbLocacao.Size = new System.Drawing.Size(268, 28);
            this.cbLocacao.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbLocacao, "Local de armazenamento.");
            // 
            // txtUltimaCompra
            // 
            this.txtUltimaCompra.AutoSize = true;
            this.txtUltimaCompra.Location = new System.Drawing.Point(6, 76);
            this.txtUltimaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUltimaCompra.Name = "txtUltimaCompra";
            this.txtUltimaCompra.Size = new System.Drawing.Size(108, 20);
            this.txtUltimaCompra.TabIndex = 29;
            this.txtUltimaCompra.Text = "Última compra";
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
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(574, 34);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(67, 28);
            this.cbStatus.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbStatus, "Disponibilidade em estoque.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Status";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "KG",
            "UN",
            "M",
            "CM",
            "MM"});
            this.cbFornecedor.Location = new System.Drawing.Point(10, 235);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(446, 28);
            this.cbFornecedor.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cbFornecedor, "Fornecedor do produto.");
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(570, 76);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 20);
            this.lblPreco.TabIndex = 31;
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
            "KG",
            "UN",
            "M",
            "CM",
            "MM"});
            this.cbUnidade.Location = new System.Drawing.Point(483, 101);
            this.cbUnidade.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(77, 28);
            this.cbUnidade.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(67, 27);
            this.textBox1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBox1, "Preço do produto.");
            // 
            // txtQtdeDisponivel
            // 
            this.txtQtdeDisponivel.Location = new System.Drawing.Point(410, 101);
            this.txtQtdeDisponivel.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtQtdeDisponivel.Name = "txtQtdeDisponivel";
            this.txtQtdeDisponivel.Size = new System.Drawing.Size(56, 27);
            this.txtQtdeDisponivel.TabIndex = 2;
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
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(56, 27);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCodigo, "Código do produto.");
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(477, 27);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do produto.");
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 168);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(446, 27);
            this.txtDescricao.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtDescricao, "Descrição do produto.");
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(10, 411);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(631, 159);
            this.dgvConsulta.TabIndex = 29;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 25);
            this.toolStripProgressBar1.Visible = false;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.DimGray;
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesquisa.Controls.Add(this.btnConsultar);
            this.pnlPesquisa.Controls.Add(this.txtConsulta);
            this.pnlPesquisa.Controls.Add(this.lblConsultar);
            this.pnlPesquisa.Location = new System.Drawing.Point(10, 353);
            this.pnlPesquisa.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(631, 48);
            this.pnlPesquisa.TabIndex = 32;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(586, 3);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(39, 38);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = ">";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(164, 10);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(410, 27);
            this.txtConsulta.TabIndex = 0;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblConsultar.ForeColor = System.Drawing.Color.White;
            this.lblConsultar.Location = new System.Drawing.Point(14, 12);
            this.lblConsultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(137, 21);
            this.lblConsultar.TabIndex = 35;
            this.lblConsultar.Text = "Consultar produto";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Location = new System.Drawing.Point(10, 304);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(665, 39);
            this.pnlBotoes.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(531, 1);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(421, 1);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(311, 1);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 38);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(201, 1);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 38);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(654, 594);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.pnlCadProduto);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.pnlCadProduto.ResumeLayout(false);
            this.pnlCadProduto.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtQtdeDisponivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtUltimaCompra;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.DateTimePicker cbDataCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblQtdCompra;
        private System.Windows.Forms.TextBox txtQtdeCompra;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}