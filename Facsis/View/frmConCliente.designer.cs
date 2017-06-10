namespace Facsis.View
{
    partial class frmConPessoa
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
            this.R4 = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlDadosUsuario = new System.Windows.Forms.Panel();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNImovel = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCpfCnpjCon = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCon = new System.Windows.Forms.TextBox();
            this.txtIdCon = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inserirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.id_pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_imovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R4.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlDadosUsuario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // R4
            // 
            this.R4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.R4.Controls.Add(this.pnlBotoes);
            this.R4.Controls.Add(this.pnlDadosUsuario);
            this.R4.Controls.Add(this.panel2);
            this.R4.Controls.Add(this.dgvPessoa);
            this.R4.Controls.Add(this.panel1);
            this.R4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R4.Location = new System.Drawing.Point(0, 0);
            this.R4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(825, 572);
            this.R4.TabIndex = 9;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Location = new System.Drawing.Point(216, 218);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(600, 39);
            this.pnlBotoes.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(500, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
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
            this.btnExcluir.Location = new System.Drawing.Point(390, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(280, 1);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 38);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlDadosUsuario
            // 
            this.pnlDadosUsuario.BackColor = System.Drawing.Color.White;
            this.pnlDadosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosUsuario.Controls.Add(this.lblUf);
            this.pnlDadosUsuario.Controls.Add(this.txtUf);
            this.pnlDadosUsuario.Controls.Add(this.lblCidade);
            this.pnlDadosUsuario.Controls.Add(this.lblNumero);
            this.pnlDadosUsuario.Controls.Add(this.txtTelefone);
            this.pnlDadosUsuario.Controls.Add(this.txtCpfCnpj);
            this.pnlDadosUsuario.Controls.Add(this.txtNImovel);
            this.pnlDadosUsuario.Controls.Add(this.txtId);
            this.pnlDadosUsuario.Controls.Add(this.txtCidade);
            this.pnlDadosUsuario.Controls.Add(this.lblRua);
            this.pnlDadosUsuario.Controls.Add(this.label1);
            this.pnlDadosUsuario.Controls.Add(this.cbPessoa);
            this.pnlDadosUsuario.Controls.Add(this.label2);
            this.pnlDadosUsuario.Controls.Add(this.lblPessoa);
            this.pnlDadosUsuario.Controls.Add(this.txtRua);
            this.pnlDadosUsuario.Controls.Add(this.label3);
            this.pnlDadosUsuario.Controls.Add(this.txtEmail);
            this.pnlDadosUsuario.Controls.Add(this.txtNome);
            this.pnlDadosUsuario.Controls.Add(this.lblEmail);
            this.pnlDadosUsuario.Controls.Add(this.lblTelefone1);
            this.pnlDadosUsuario.Location = new System.Drawing.Point(117, 9);
            this.pnlDadosUsuario.Name = "pnlDadosUsuario";
            this.pnlDadosUsuario.Size = new System.Drawing.Size(699, 205);
            this.pnlDadosUsuario.TabIndex = 13;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(627, 128);
            this.lblUf.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(26, 20);
            this.lblUf.TabIndex = 12;
            this.lblUf.Text = "UF";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(631, 153);
            this.txtUf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(52, 27);
            this.txtUf.TabIndex = 16;
            this.txtUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(346, 130);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 20);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(286, 130);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(26, 20);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Nº";
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Location = new System.Drawing.Point(19, 98);
            this.txtTelefone.Mask = "(99) 09999 - 9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(126, 27);
            this.txtTelefone.TabIndex = 19;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpfCnpj.Location = new System.Drawing.Point(545, 41);
            this.txtCpfCnpj.Mask = "009,999,999,90";
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(138, 27);
            this.txtCpfCnpj.TabIndex = 19;
            this.txtCpfCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpfCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNImovel
            // 
            this.txtNImovel.Location = new System.Drawing.Point(290, 153);
            this.txtNImovel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNImovel.MaxLength = 5;
            this.txtNImovel.Name = "txtNImovel";
            this.txtNImovel.Size = new System.Drawing.Size(52, 27);
            this.txtNImovel.TabIndex = 17;
            this.txtNImovel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(17, 42);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.MaxLength = 3;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 27);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(350, 153);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(273, 27);
            this.txtCidade.TabIndex = 18;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(16, 128);
            this.lblRua.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(34, 20);
            this.lblRua.TabIndex = 14;
            this.lblRua.Text = "Rua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            // 
            // cbPessoa
            // 
            this.cbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbPessoa.Location = new System.Drawing.Point(545, 97);
            this.cbPessoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(138, 28);
            this.cbPessoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF / CNPJ";
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(541, 72);
            this.lblPessoa.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(110, 20);
            this.lblPessoa.TabIndex = 6;
            this.lblPessoa.Text = "Tipo de pessoa";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(19, 153);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(263, 27);
            this.txtRua.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 98);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(374, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "a";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 42);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(428, 27);
            this.txtNome.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(159, 74);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(13, 75);
            this.lblTelefone1.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(67, 20);
            this.lblTelefone1.TabIndex = 18;
            this.lblTelefone1.Text = "Telefone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCpfCnpjCon);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.lblCpfCnpj);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.txtNomeCon);
            this.panel2.Controls.Add(this.txtIdCon);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Location = new System.Drawing.Point(117, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 88);
            this.panel2.TabIndex = 10;
            // 
            // txtCpfCnpjCon
            // 
            this.txtCpfCnpjCon.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpfCnpjCon.Location = new System.Drawing.Point(437, 38);
            this.txtCpfCnpjCon.Mask = "009,999,999,90";
            this.txtCpfCnpjCon.Name = "txtCpfCnpjCon";
            this.txtCpfCnpjCon.Size = new System.Drawing.Size(126, 27);
            this.txtCpfCnpjCon.TabIndex = 26;
            this.txtCpfCnpjCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpfCnpjCon.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(571, 32);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 38);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCpfCnpj.Location = new System.Drawing.Point(437, 14);
            this.lblCpfCnpj.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(80, 20);
            this.lblCpfCnpj.TabIndex = 23;
            this.lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(124, 14);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeCon
            // 
            this.txtNomeCon.Location = new System.Drawing.Point(127, 38);
            this.txtNomeCon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCon.MaxLength = 50;
            this.txtNomeCon.Name = "txtNomeCon";
            this.txtNomeCon.Size = new System.Drawing.Size(305, 27);
            this.txtNomeCon.TabIndex = 21;
            // 
            // txtIdCon
            // 
            this.txtIdCon.Location = new System.Drawing.Point(17, 38);
            this.txtIdCon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCon.MaxLength = 3;
            this.txtIdCon.Name = "txtIdCon";
            this.txtIdCon.Size = new System.Drawing.Size(97, 27);
            this.txtIdCon.TabIndex = 19;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(13, 14);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pessoa,
            this.nome_pessoa,
            this.tipo_pessoa,
            this.cpf_cnpj,
            this.email,
            this.telefone,
            this.endereco,
            this.numero_imovel,
            this.cidade,
            this.uf});
            this.dgvPessoa.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPessoa.Location = new System.Drawing.Point(117, 356);
            this.dgvPessoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.Size = new System.Drawing.Size(699, 211);
            this.dgvPessoa.TabIndex = 3;
            this.dgvPessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoa_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirClienteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // inserirClienteToolStripMenuItem
            // 
            this.inserirClienteToolStripMenuItem.Name = "inserirClienteToolStripMenuItem";
            this.inserirClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.inserirClienteToolStripMenuItem.Text = "Inserir cliente";
            this.inserirClienteToolStripMenuItem.Click += new System.EventHandler(this.inserirClienteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 572);
            this.panel1.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemover.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(8, 57);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 38);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkGray;
            this.btnInserir.Enabled = false;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnInserir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(8, 9);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 38);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // id_pessoa
            // 
            this.id_pessoa.HeaderText = "Código";
            this.id_pessoa.Name = "id_pessoa";
            this.id_pessoa.Width = 60;
            // 
            // nome_pessoa
            // 
            this.nome_pessoa.HeaderText = "Nome";
            this.nome_pessoa.Name = "nome_pessoa";
            // 
            // tipo_pessoa
            // 
            this.tipo_pessoa.HeaderText = "Tipo pessoa";
            this.tipo_pessoa.Name = "tipo_pessoa";
            // 
            // cpf_cnpj
            // 
            this.cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cpf_cnpj.Name = "cpf_cnpj";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            // 
            // numero_imovel
            // 
            this.numero_imovel.HeaderText = "Nº";
            this.numero_imovel.Name = "numero_imovel";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.Width = 60;
            // 
            // frmConPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(825, 582);
            this.Controls.Add(this.R4);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmConPessoa";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de pessoa";
            this.R4.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDadosUsuario.ResumeLayout(false);
            this.pnlDadosUsuario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel R4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCon;
        private System.Windows.Forms.TextBox txtIdCon;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpjCon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirClienteToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDadosUsuario;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtNImovel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_imovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
    }
}