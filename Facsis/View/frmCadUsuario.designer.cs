namespace Facsis.View
{
    partial class frmCadUsuario
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
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurarTamanhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Diretor",
            "Vendedor",
            "Estoquista"});
            this.cbNivel.Location = new System.Drawing.Point(557, 45);
            this.cbNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(131, 28);
            this.cbNivel.TabIndex = 2;
            this.toolTip.SetToolTip(this.cbNivel, "Informe o nível operacional do usuário.");
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(553, 15);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(43, 20);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nível";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(105, 15);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 45);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(440, 27);
            this.txtNome.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtNome, "Informe o nome do usuário.");
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(237, 149);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(20, 149);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(237, 169);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(205, 27);
            this.txtSenha.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtSenha, "Informe a senha do usuário.");
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(24, 169);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(205, 27);
            this.txtLogin.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtLogin, "Informe o login do usuário.");
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(624, 1);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip.SetToolTip(this.btnCancelar, "Clique aqui para cancelar o cadastro.");
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
            this.btnExcluir.Location = new System.Drawing.Point(514, 1);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.toolTip.SetToolTip(this.btnExcluir, "Clique aqui para excluir o cadastro.");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(404, 1);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 38);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolTip.SetToolTip(this.btnCadastrar, "Clique aqui para cadastrar o usuário.");
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(164, 10);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(13, 5, 4, 15);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(444, 27);
            this.txtConsulta.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtConsulta, "Informe um nome para a consulta.");
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAnterior.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(311, 0);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(38, 38);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "<";
            this.toolTip.SetToolTip(this.btnAnterior, "Selecionar anterior.");
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
            this.btnProximo.Location = new System.Drawing.Point(357, 0);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(38, 38);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.Text = ">";
            this.toolTip.SetToolTip(this.btnProximo, "Selecionar próximo.");
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Location = new System.Drawing.Point(368, 112);
            this.txtTelefone.Mask = "(99) 99999 - 9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(126, 27);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip.SetToolTip(this.txtTelefone, "Informe o número de telefone do usuário.");
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(22, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(79, 27);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txtId, "Código do usuário.");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 27);
            this.txtEmail.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtEmail, "Informe o email do usuário.");
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nome,
            this.email,
            this.telefone,
            this.nivel,
            this.login_usuario,
            this.senha});
            this.dgvConsulta.Location = new System.Drawing.Point(9, 332);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(727, 142);
            this.dgvConsulta.TabIndex = 31;
            this.toolTip.SetToolTip(this.dgvConsulta, "Usuários cadastrados.");
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_Click);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Código";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Width = 83;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 75;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 71;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 92;
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nível";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            this.nivel.Width = 68;
            // 
            // login_usuario
            // 
            this.login_usuario.HeaderText = "Login";
            this.login_usuario.Name = "login_usuario";
            this.login_usuario.ReadOnly = true;
            this.login_usuario.Width = 71;
            // 
            // senha
            // 
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Width = 74;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.DimGray;
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesquisa.Controls.Add(this.btnConsultar);
            this.pnlPesquisa.Controls.Add(this.txtConsulta);
            this.pnlPesquisa.Controls.Add(this.lblConsultar);
            this.pnlPesquisa.Location = new System.Drawing.Point(12, 275);
            this.pnlPesquisa.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(724, 48);
            this.pnlPesquisa.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(615, 3);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(39, 38);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = ">";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.White;
            this.lblConsultar.Location = new System.Drawing.Point(14, 12);
            this.lblConsultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(144, 21);
            this.lblConsultar.TabIndex = 35;
            this.lblConsultar.Text = "Consultar usuário";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnAnterior);
            this.pnlBotoes.Controls.Add(this.btnProximo);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 226);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(724, 39);
            this.pnlBotoes.TabIndex = 4;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.White;
            this.pnlUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUsuario.Controls.Add(this.txtTelefone);
            this.pnlUsuario.Controls.Add(this.cbNivel);
            this.pnlUsuario.Controls.Add(this.lblNivel);
            this.pnlUsuario.Controls.Add(this.lblSenha);
            this.pnlUsuario.Controls.Add(this.lblId);
            this.pnlUsuario.Controls.Add(this.lblTelefone);
            this.pnlUsuario.Controls.Add(this.lblEmail);
            this.pnlUsuario.Controls.Add(this.lblNome);
            this.pnlUsuario.Controls.Add(this.txtSenha);
            this.pnlUsuario.Controls.Add(this.txtId);
            this.pnlUsuario.Controls.Add(this.txtEmail);
            this.pnlUsuario.Controls.Add(this.txtNome);
            this.pnlUsuario.Controls.Add(this.lblLogin);
            this.pnlUsuario.Controls.Add(this.txtLogin);
            this.pnlUsuario.Location = new System.Drawing.Point(12, 14);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Padding = new System.Windows.Forms.Padding(10);
            this.pnlUsuario.Size = new System.Drawing.Size(724, 208);
            this.pnlUsuario.TabIndex = 30;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 15);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Código";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(364, 84);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 20);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 82);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.restaurarTamanhoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 32);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // restaurarTamanhoToolStripMenuItem
            // 
            this.restaurarTamanhoToolStripMenuItem.Name = "restaurarTamanhoToolStripMenuItem";
            this.restaurarTamanhoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.restaurarTamanhoToolStripMenuItem.Text = "Restaurar tamanho";
            this.restaurarTamanhoToolStripMenuItem.Click += new System.EventHandler(this.restaurarTamanhoToolStripMenuItem_Click);
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(749, 482);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadUsuario";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de usuário";
            this.toolTip.SetToolTip(this, "Informe o código ou nome do usuário.");
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem restaurarTamanhoToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
    }
}