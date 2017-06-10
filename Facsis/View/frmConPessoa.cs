﻿using System;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;
using System.Data;

namespace Facsis.View
{
    public partial class frmConPessoa : Form
    {
        PessoaBLL bll = new PessoaBLL();
        PessoaDTO dto = new PessoaDTO();
        string relacao = "CLIENTE";
        string[] pessoa = new string[10];
        DataTable dt;

        TextBox id;
        TextBox nome;

        int indice;

        // Inicializa o Form normalmente
        public frmConPessoa()
        {
            InitializeComponent();
        }

        // Inicializa o Form para consulta do Form Venda
        public frmConPessoa(TextBox id, TextBox nome)
        {
            InitializeComponent();
            btnInserir.Enabled = true;
            btnRemover.Enabled = true;

            this.id = id;
            this.nome = nome;

            this.Text = "Consulta de cliente";
            relacao = "CLIENTE";
        }

        // Insere pessoa no carrinho de compra
        private void btnInserir_Click(object sender, EventArgs e)
        {
            id.Text = txtId.Text;
            nome.Text = txtNome.Text;

            if (btnInserir.Text == "Inserir")
                btnInserir.Text = "Alterar";
            else
                btnInserir.Text = "Inserir";
        }

        private void inserirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = txtId;
            nome = txtNome;
        }

        // Seleciona linha do grid e preenche os campos para edição ou seleção
        private void dgvPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            txtId.Text = dgvPessoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvPessoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbPessoa.Text = dgvPessoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCpfCnpj.Text = dgvPessoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvPessoa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelefone.Text = dgvPessoa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtRua.Text = dgvPessoa.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNome.Text = dgvPessoa.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCidade.Text = dgvPessoa.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtUf.Text = dgvPessoa.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
        
        // Remove a pessoa do carrinho de compras
        private void btnRemover_Click(object sender, EventArgs e)
        {
            id.Text = "";
            nome.Text = "";
            btnInserir.Text = "Inserir";
        }

        // Cadastra um cliente no banco
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCon.Text.Trim().ToUpper();
            int aux;

            dto.Nome = nome;
            dto.Tipo = cbPessoa.Text.Trim();
            dto.Email = txtEmail.Text.Trim().ToLower();
            dto.Telefone = txtTelefone.Text.Trim();
            dto.Endereco = txtRua.Text.Trim();

            if (int.TryParse(txtNImovel.Text.Trim(), out aux))
                dto.NImovel = int.Parse(txtNImovel.Text.Trim());
            else
                txtNImovel.Text = "";

            dto.Cidade = txtCidade.Text.Trim();
            dto.UF = txtUf.Text;
            dto.CPF_CNPJ = txtCpfCnpj.Text;

            dto.Relacao = "CLIENTE";

            if (txtId.Text == "")
            {
                // Efetua um novo cadastro
                bll.Inserir(dto);
            }
            else
            {
                // Atualiza um cadastro
                bll.Atualizar(dto);               
                btnCadastrar.Text = "Cadastrar";
            }

            FuncoesControles.limpaCampos(this.pnlDadosUsuario);

        }

        // Consulta pessoa no banco
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id;

            if (Int32.TryParse(txtIdCon.Text, out id))
            {
                dto.Id = int.Parse(txtIdCon.Text);
            }

            dto.Nome = txtNomeCon.Text.ToUpper();
            dto.CPF_CNPJ = txtCpfCnpjCon.Text;

            CarregarGrid();
        }

        // Faz o SELECT dos clientes no banco
        private void CarregarGrid()
        {
            dgvPessoa.Rows?.Clear();

            DataTable dt = bll.selecionaPessoa(dto, relacao);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvPessoa.Rows.Add(
                    dt.Rows[i]["id_pessoa"].ToString(), 
                    dt.Rows[i]["nome"].ToString(), 
                    dt.Rows[i]["tipo_pessoa"].ToString(),
                    dt.Rows[i]["cpf_cnpj"].ToString(),
                    dt.Rows[i]["email"].ToString(), 
                    dt.Rows[i]["telefone"].ToString(), 
                    dt.Rows[i]["numero_imovel"].ToString(),
                    dt.Rows[i]["endereco"].ToString(),
                    dt.Rows[i]["cidade"].ToString(),
                    dt.Rows[i]["uf"].ToString());
            }

        }
    }
}
