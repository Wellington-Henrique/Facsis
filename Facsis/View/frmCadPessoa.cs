using System;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;
using System.Data;

namespace Facsis.View
{
    public partial class frmCadPessoa : Form
    {
        PessoaBLL bll = new PessoaBLL();
        PessoaDTO dto;
        string relacao = "CLIENTE";
        string[] pessoa = new string[10];
        DataTable dt;

        TextBox id;
        TextBox nome;

        int indice;

        // Inicializa o Form normalmente
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        // Inicializa o Form para consulta do Form Venda
        public frmCadPessoa(TextBox id, TextBox nome)
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
            txtNImovel.Text = dgvPessoa.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCidade.Text = dgvPessoa.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtUf.Text = dgvPessoa.Rows[e.RowIndex].Cells[9].Value.ToString();

            btnCadastrar.Text = "Atualizar";
            btnExcluir.Enabled = true;
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
            int aux;

            // Verifica se o número do imóvel é inteiro
            if (int.TryParse(txtNImovel.Text.Trim(), out aux))
                dto.NImovel = Convert.ToInt32(txtNImovel.Text.Trim());
            else
                txtNImovel.Text = "";

            // Caso todos os campos sejam preenchidos efetua o cadastro ou atualização
            if (FuncoesControles.verificaVazio(pnlDadosUsuario) == false)
            {
                dto = new PessoaDTO();

                string nome = txtNomeCon.Text.Trim().ToUpper();

                dto.Nome = nome;
                dto.Tipo = cbPessoa.Text.Trim();
                dto.Email = txtEmail.Text.Trim().ToLower();
                dto.Telefone = txtTelefone.Text.Trim();
                dto.Endereco = txtRua.Text.Trim();

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
                    dto.Id = int.Parse(txtId.Text);
                    bll.Atualizar(dto);
                    btnCadastrar.Text = "Cadastrar";
                }

                FuncoesControles.limpaCampos(this.pnlDadosUsuario);
                dto = null;
            }
            else
                Mensagens.camposVarizos();            

        }

        // Consulta pessoa no banco
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dto = new PessoaDTO();

            int id;

            if (Int32.TryParse(txtIdCon.Text, out id))
            {
                dto.Id = int.Parse(txtIdCon.Text);
            }

            dto.Nome = txtNomeCon.Text.ToUpper();
            dto.CPF_CNPJ = txtCpfCnpjCon.Text;

            CarregarGrid();

            dto = null;
        }

        // Faz o SELECT dos clientes no banco
        private void CarregarGrid()
        {
            dgvPessoa.Rows?.Clear();

            DataTable dt = new DataTable();
            
            if (dto.Id != 0 && dto.Nome != "" && dto.CPF_CNPJ != "")
                dt = bll.selecionaPessoa(dto, relacao);
            else if (dto.Nome != "")
                dt = bll.selecionaPessoa(dto.Nome, relacao);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvPessoa.Rows.Add(
                    dt.Rows[i]["id_pessoa"].ToString(), 
                    dt.Rows[i]["nome"].ToString(), 
                    dt.Rows[i]["tipo_pessoa"].ToString(),
                    dt.Rows[i]["cpf_cnpj"].ToString(),
                    dt.Rows[i]["email"].ToString(), 
                    dt.Rows[i]["telefone"].ToString(),                     
                    dt.Rows[i]["endereco"].ToString(),
                    dt.Rows[i]["numero_imovel"].ToString(),
                    dt.Rows[i]["cidade"].ToString(),
                    dt.Rows[i]["uf"].ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bll.Excluir(txtId.Text);
            btnExcluir.Enabled = false;
            FuncoesControles.limpaCampos(this.pnlDadosUsuario);
            dgvPessoa.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FuncoesControles.limpaCampos(this.pnlDadosUsuario);
            dgvPessoa.Rows.Clear();
        }
    }
}
