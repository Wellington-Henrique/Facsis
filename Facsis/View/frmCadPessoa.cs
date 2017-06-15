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

        TextBox id;
        TextBox nome;

        int indice = 0;

        // Inicializa o Form normalmente
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        // Inicializa o Form para consulta do Form Venda
        public frmCadPessoa(TextBox id, TextBox nome)
        {
            InitializeComponent();
            btnSelecionar.Enabled = true;

            this.id = id;
            this.nome = nome;

            this.Text = "Consulta de cliente";
            relacao = "CLIENTE";
        }

        // Insere pessoa no carrinho de compra
        private void btnInserir_Click(object sender, EventArgs e)
        {
            selecionaCliente();
        }

        private void inserirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selecionaCliente();
        }

        // Adiciona o cliente a tela de venda
        public void selecionaCliente()
        {
            if (txtId.Text != "")
            {
                btnSelecionar.Text = btnSelecionar.Text == "Selecionar" ? "Alterar" : "Selecionar";

                id.Text = txtId.Text;
                nome.Text = txtNome.Text;
            }
            else
                Mensagens.camposVazios();
        }

        // Seleciona linha do grid e preenche os campos para edição ou seleção
        private void dgvPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            visualizarDadosPessoa(indice);
        }      

        // Cadastra um cliente no banco
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int aux;

            dto = new PessoaDTO();            

            // Verifica se o número do imóvel é inteiro
            if (int.TryParse(txtNImovel.Text.Trim(), out aux))
                dto.NImovel = Convert.ToInt32(txtNImovel.Text.Trim());
            else
                txtNImovel.Text = "";

            // Caso todos os campos sejam preenchidos efetua o cadastro ou atualização
            if (FuncoesControles.verificaVazio(pnlDadosUsuario) == false)
            {
                dto.Nome = txtNome.Text.Trim().ToUpper();
                dto.Tipo = cbPessoa.Text.Trim();
                dto.Email = txtEmail.Text.Trim().ToLower();
                dto.Telefone = txtTelefone.Text;
                dto.Endereco = txtRua.Text.Trim().ToUpper();

                dto.Cidade = txtCidade.Text.Trim().ToUpper();
                dto.UF = txtUf.Text.Trim().ToUpper();
                dto.CPF_CNPJ = txtCpfCnpj.Text;

                dto.Relacao = relacao;

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
                dgvPessoa.Rows.Clear();
            }
            else
                Mensagens.camposVazios();

            dto = null;    
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
            if (Mensagens.perguntaExcluir() == DialogResult.Yes)
            {
                bll.Excluir(txtId.Text);
                btnExcluir.Enabled = false;
                FuncoesControles.limpaCampos(this.pnlDadosUsuario);
                dgvPessoa.Rows.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FuncoesControles.limpaCampos(this.pnlDadosUsuario);
            dgvPessoa.Rows.Clear();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (indice < dgvPessoa.Rows.Count - 2 && dgvPessoa.Rows.Count > 0)
            {
                indice++;
                visualizarDadosPessoa(indice);
            }               
        }

        public void visualizarDadosPessoa(int indice)
        {
            txtId.Text = dgvPessoa.Rows[indice].Cells[0].Value.ToString();
            txtNome.Text = dgvPessoa.Rows[indice].Cells[1].Value.ToString();
            cbPessoa.Text = dgvPessoa.Rows[indice].Cells[2].Value.ToString();
            txtCpfCnpj.Text = dgvPessoa.Rows[indice].Cells[3].Value.ToString();
            txtEmail.Text = dgvPessoa.Rows[indice].Cells[4].Value.ToString();
            txtTelefone.Text = dgvPessoa.Rows[indice].Cells[5].Value.ToString();
            txtRua.Text = dgvPessoa.Rows[indice].Cells[6].Value.ToString();
            txtNImovel.Text = dgvPessoa.Rows[indice].Cells[7].Value.ToString();
            txtCidade.Text = dgvPessoa.Rows[indice].Cells[8].Value.ToString();
            txtUf.Text = dgvPessoa.Rows[indice].Cells[9].Value.ToString();

            btnCadastrar.Text = "Atualizar";
            btnExcluir.Enabled = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0 && dgvPessoa.Rows.Count > 0)
            {
                indice--;
                visualizarDadosPessoa(indice);
            }
        }

        private void txtCpfCnpj_DragOver(object sender, DragEventArgs e)
        {

        }

        private void cbPessoa_TextChanged(object sender, EventArgs e)
        {
            if (cbPessoa.Text == "Jurídica")
            {
                txtCpfCnpj.Mask = "99,999,999 / 9999 - 99";
                lblCpfCnpj.Text = "CNPJ";
            }                
            else if (cbPessoa.Text == "Física")
            {
                txtCpfCnpj.Mask = "099,999,999 - 99";
                lblCpfCnpj.Text = "CPF";
            }
        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            cbPessoa.Text = "Física";
        }
    }
}
