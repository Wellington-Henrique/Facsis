namespace Facsis.View
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdCancelar = new System.Windows.Forms.RadioButton();
            this.rdPendente = new System.Windows.Forms.RadioButton();
            this.rdFaturar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.txtVlrDesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVlrBruto = new System.Windows.Forms.TextBox();
            this.lblVlrBruto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.cbFormaPgto = new System.Windows.Forms.ComboBox();
            this.dtNota = new System.Windows.Forms.DateTimePicker();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.btnAdicinaCliente = new System.Windows.Forms.Button();
            this.lblNVendedor = new System.Windows.Forms.Label();
            this.lblLegDataNota = new System.Windows.Forms.Label();
            this.lblLegNomeCli = new System.Windows.Forms.Label();
            this.lblLegNPedido = new System.Windows.Forms.Label();
            this.lblLegDataPed = new System.Windows.Forms.Label();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlr_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.dgvMenu.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdCancelar);
            this.groupBox2.Controls.Add(this.rdPendente);
            this.groupBox2.Controls.Add(this.rdFaturar);
            this.groupBox2.Location = new System.Drawing.Point(508, 369);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(112, 162);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // rdCancelar
            // 
            this.rdCancelar.AutoSize = true;
            this.rdCancelar.Location = new System.Drawing.Point(13, 105);
            this.rdCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdCancelar.Name = "rdCancelar";
            this.rdCancelar.Size = new System.Drawing.Size(84, 24);
            this.rdCancelar.TabIndex = 33;
            this.rdCancelar.Text = "Cancelar";
            this.rdCancelar.UseVisualStyleBackColor = true;
            // 
            // rdPendente
            // 
            this.rdPendente.AutoSize = true;
            this.rdPendente.Location = new System.Drawing.Point(13, 69);
            this.rdPendente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdPendente.Name = "rdPendente";
            this.rdPendente.Size = new System.Drawing.Size(88, 24);
            this.rdPendente.TabIndex = 33;
            this.rdPendente.Text = "Pendente";
            this.rdPendente.UseVisualStyleBackColor = true;
            // 
            // rdFaturar
            // 
            this.rdFaturar.AutoSize = true;
            this.rdFaturar.Checked = true;
            this.rdFaturar.Location = new System.Drawing.Point(13, 34);
            this.rdFaturar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdFaturar.Name = "rdFaturar";
            this.rdFaturar.Size = new System.Drawing.Size(72, 24);
            this.rdFaturar.TabIndex = 33;
            this.rdFaturar.TabStop = true;
            this.rdFaturar.Text = "Faturar";
            this.rdFaturar.UseMnemonic = false;
            this.rdFaturar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtPorcentagem);
            this.groupBox1.Controls.Add(this.txtVlrDesconto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVlrBruto);
            this.groupBox1.Controls.Add(this.lblVlrBruto);
            this.groupBox1.Location = new System.Drawing.Point(647, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(361, 162);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(240, 109);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorTotal.MaxLength = 3;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(105, 27);
            this.txtValorTotal.TabIndex = 0;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(99, 69);
            this.txtPorcentagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPorcentagem.MaxLength = 3;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(105, 27);
            this.txtPorcentagem.TabIndex = 0;
            this.txtPorcentagem.TextChanged += new System.EventHandler(this.txtVlrBruto_TextChanged);
            // 
            // txtVlrDesconto
            // 
            this.txtVlrDesconto.Enabled = false;
            this.txtVlrDesconto.Location = new System.Drawing.Point(240, 69);
            this.txtVlrDesconto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVlrDesconto.MaxLength = 3;
            this.txtVlrDesconto.Name = "txtVlrDesconto";
            this.txtVlrDesconto.Size = new System.Drawing.Size(105, 27);
            this.txtVlrDesconto.TabIndex = 0;
            this.txtVlrDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Valor total";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(20, 74);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(72, 20);
            this.lblDesconto.TabIndex = 18;
            this.lblDesconto.Text = "Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "%";
            // 
            // txtVlrBruto
            // 
            this.txtVlrBruto.Enabled = false;
            this.txtVlrBruto.Location = new System.Drawing.Point(240, 29);
            this.txtVlrBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVlrBruto.MaxLength = 3;
            this.txtVlrBruto.Name = "txtVlrBruto";
            this.txtVlrBruto.Size = new System.Drawing.Size(105, 27);
            this.txtVlrBruto.TabIndex = 0;
            this.txtVlrBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrBruto.TextChanged += new System.EventHandler(this.txtVlrBruto_TextChanged);
            // 
            // lblVlrBruto
            // 
            this.lblVlrBruto.AutoSize = true;
            this.lblVlrBruto.Location = new System.Drawing.Point(153, 34);
            this.lblVlrBruto.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblVlrBruto.Name = "lblVlrBruto";
            this.lblVlrBruto.Size = new System.Drawing.Size(83, 20);
            this.lblVlrBruto.TabIndex = 18;
            this.lblVlrBruto.Text = "Valor Bruto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblFormaPgto);
            this.panel3.Controls.Add(this.cbFormaPgto);
            this.panel3.Controls.Add(this.dtNota);
            this.panel3.Controls.Add(this.dtPedido);
            this.panel3.Controls.Add(this.txtIdVendedor);
            this.panel3.Controls.Add(this.btnAdicinaCliente);
            this.panel3.Controls.Add(this.lblNVendedor);
            this.panel3.Controls.Add(this.lblLegDataNota);
            this.panel3.Controls.Add(this.lblLegNomeCli);
            this.panel3.Controls.Add(this.lblLegNPedido);
            this.panel3.Controls.Add(this.lblLegDataPed);
            this.panel3.Controls.Add(this.txtNumPedido);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.txtIdCli);
            this.panel3.Controls.Add(this.lblCodCli);
            this.panel3.Location = new System.Drawing.Point(18, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 123);
            this.panel3.TabIndex = 41;
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(14, 78);
            this.lblFormaPgto.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(153, 20);
            this.lblFormaPgto.TabIndex = 48;
            this.lblFormaPgto.Text = "Forma de pagamento";
            // 
            // cbFormaPgto
            // 
            this.cbFormaPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPgto.FormattingEnabled = true;
            this.cbFormaPgto.Items.AddRange(new object[] {
            "À vista",
            "Crédito",
            "Cheque",
            "Débito"});
            this.cbFormaPgto.Location = new System.Drawing.Point(175, 78);
            this.cbFormaPgto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFormaPgto.Name = "cbFormaPgto";
            this.cbFormaPgto.Size = new System.Drawing.Size(160, 28);
            this.cbFormaPgto.TabIndex = 49;
            // 
            // dtNota
            // 
            this.dtNota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNota.Location = new System.Drawing.Point(747, 33);
            this.dtNota.Name = "dtNota";
            this.dtNota.Size = new System.Drawing.Size(123, 27);
            this.dtNota.TabIndex = 42;
            // 
            // dtPedido
            // 
            this.dtPedido.Enabled = false;
            this.dtPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPedido.Location = new System.Drawing.Point(623, 33);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(118, 27);
            this.dtPedido.TabIndex = 43;
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Enabled = false;
            this.txtIdVendedor.Location = new System.Drawing.Point(877, 33);
            this.txtIdVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdVendedor.MaxLength = 3;
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(99, 27);
            this.txtIdVendedor.TabIndex = 35;
            this.txtIdVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicinaCliente
            // 
            this.btnAdicinaCliente.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdicinaCliente.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdicinaCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnAdicinaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdicinaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdicinaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicinaCliente.Location = new System.Drawing.Point(489, 30);
            this.btnAdicinaCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAdicinaCliente.Name = "btnAdicinaCliente";
            this.btnAdicinaCliente.Size = new System.Drawing.Size(34, 33);
            this.btnAdicinaCliente.TabIndex = 0;
            this.btnAdicinaCliente.Text = ">";
            this.btnAdicinaCliente.UseVisualStyleBackColor = false;
            this.btnAdicinaCliente.Click += new System.EventHandler(this.btnAdicinaCliente_Click);
            // 
            // lblNVendedor
            // 
            this.lblNVendedor.AutoSize = true;
            this.lblNVendedor.Location = new System.Drawing.Point(873, 8);
            this.lblNVendedor.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblNVendedor.Name = "lblNVendedor";
            this.lblNVendedor.Size = new System.Drawing.Size(107, 20);
            this.lblNVendedor.TabIndex = 40;
            this.lblNVendedor.Text = "Cód. Vendedor";
            // 
            // lblLegDataNota
            // 
            this.lblLegDataNota.AutoSize = true;
            this.lblLegDataNota.Location = new System.Drawing.Point(743, 10);
            this.lblLegDataNota.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblLegDataNota.Name = "lblLegDataNota";
            this.lblLegDataNota.Size = new System.Drawing.Size(65, 20);
            this.lblLegDataNota.TabIndex = 36;
            this.lblLegDataNota.Text = "Dt. Nota";
            // 
            // lblLegNomeCli
            // 
            this.lblLegNomeCli.AutoSize = true;
            this.lblLegNomeCli.Location = new System.Drawing.Point(124, 8);
            this.lblLegNomeCli.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblLegNomeCli.Name = "lblLegNomeCli";
            this.lblLegNomeCli.Size = new System.Drawing.Size(50, 20);
            this.lblLegNomeCli.TabIndex = 37;
            this.lblLegNomeCli.Text = "Nome";
            // 
            // lblLegNPedido
            // 
            this.lblLegNPedido.AutoSize = true;
            this.lblLegNPedido.Location = new System.Drawing.Point(528, 8);
            this.lblLegNPedido.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblLegNPedido.Name = "lblLegNPedido";
            this.lblLegNPedido.Size = new System.Drawing.Size(76, 20);
            this.lblLegNPedido.TabIndex = 38;
            this.lblLegNPedido.Text = "Nº Pedido";
            // 
            // lblLegDataPed
            // 
            this.lblLegDataPed.AutoSize = true;
            this.lblLegDataPed.Location = new System.Drawing.Point(619, 8);
            this.lblLegDataPed.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblLegDataPed.Name = "lblLegDataPed";
            this.lblLegDataPed.Size = new System.Drawing.Size(78, 20);
            this.lblLegDataPed.TabIndex = 39;
            this.lblLegDataPed.Text = "Dt. Pedido";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Enabled = false;
            this.txtNumPedido.Location = new System.Drawing.Point(532, 33);
            this.txtNumPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumPedido.MaxLength = 3;
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(84, 27);
            this.txtNumPedido.TabIndex = 32;
            this.txtNumPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(128, 33);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 3;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(352, 27);
            this.txtNome.TabIndex = 33;
            // 
            // txtIdCli
            // 
            this.txtIdCli.Enabled = false;
            this.txtIdCli.Location = new System.Drawing.Point(18, 33);
            this.txtIdCli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCli.MaxLength = 3;
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(99, 27);
            this.txtIdCli.TabIndex = 34;
            this.txtIdCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(14, 8);
            this.lblCodCli.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(87, 20);
            this.lblCodCli.TabIndex = 41;
            this.lblCodCli.Text = "Cód. cliente";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.dgvCarrinho);
            this.gbPedido.Controls.Add(this.pnlBotoes);
            this.gbPedido.Location = new System.Drawing.Point(18, 136);
            this.gbPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(0);
            this.gbPedido.Size = new System.Drawing.Size(990, 233);
            this.gbPedido.TabIndex = 40;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Itens do pedido";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCarrinho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.descricao,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.vlr_total});
            this.dgvCarrinho.ContextMenuStrip = this.dgvMenu;
            this.dgvCarrinho.Location = new System.Drawing.Point(5, 64);
            this.dgvCarrinho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.RowHeadersVisible = false;
            this.dgvCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrinho.Size = new System.Drawing.Size(980, 164);
            this.dgvCarrinho.TabIndex = 31;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCarrinho_CellContentClick);
            // 
            // dgvMenu
            // 
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.limparToolStripMenuItem});
            this.dgvMenu.Name = "dvgMenu";
            this.dgvMenu.Size = new System.Drawing.Size(122, 70);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnRemover);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Location = new System.Drawing.Point(5, 19);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(980, 39);
            this.pnlBotoes.TabIndex = 45;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(880, 0);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemover.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(770, 0);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 38);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkGray;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnInserir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(660, 0);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 38);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnCancelarVenda);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Location = new System.Drawing.Point(1, 540);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 51);
            this.panel1.TabIndex = 44;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelarVenda.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarVenda.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelarVenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCancelarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Location = new System.Drawing.Point(909, 6);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(100, 38);
            this.btnCancelarVenda.TabIndex = 3;
            this.btnCancelarVenda.Text = "Cancelar";
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(799, 6);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 38);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // descricao
            // 
            this.descricao.Frozen = true;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 270;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Qtde";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Vlr UN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // vlr_total
            // 
            this.vlr_total.Frozen = true;
            this.vlr_total.HeaderText = "Total";
            this.vlr_total.Name = "vlr_total";
            this.vlr_total.ReadOnly = true;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1024, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbPedido);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdCancelar;
        private System.Windows.Forms.RadioButton rdPendente;
        private System.Windows.Forms.RadioButton rdFaturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.TextBox txtVlrDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVlrBruto;
        private System.Windows.Forms.Label lblVlrBruto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtNota;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.Label lblLegDataNota;
        private System.Windows.Forms.Label lblLegNomeCli;
        private System.Windows.Forms.Label lblLegNPedido;
        private System.Windows.Forms.Label lblLegDataPed;
        private System.Windows.Forms.Label lblNVendedor;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAdicinaCliente;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFormaPgto;
        private System.Windows.Forms.ComboBox cbFormaPgto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlr_total;
    }
}