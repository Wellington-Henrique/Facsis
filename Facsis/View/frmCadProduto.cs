using System;
using System.Data;
using System.Windows.Forms;

using Facsis.Model.BLL;
using Facsis.Model.DTO;
using Facsis.Controller.Util;

namespace Facsis.View
{
    public partial class frmCadProduto : Form
    {
        ProdutoBLL bll = new ProdutoBLL();
        ProdutoDTO dto = new ProdutoDTO();
        int indice = 0;

        public frmCadProduto()
        {
            InitializeComponent();
        }

        // ==========================================================================================
        // SELECT, INSERT, UPDATE, DELETE
        // ==========================================================================================
        private void btnCadastrarAtualizar_Click(object sender, EventArgs e)
        {
            bool invalido = false;

            try
            {
                dto.Preco = double.Parse(txtPreco.Text);
            }
            catch (Exception)
            {
                if (txtPreco.Text != "")
                    MessageBox.Show("O preço informado é inválido!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                invalido = true;
            }

            try
            {
                dto.Quantidade = txtQtdeCompra.Text == "" ? 0 : int.Parse(txtQtdeCompra.Text);
            }
            catch (Exception)
            {
                if (txtQtdeCompra.Text != "")
                    MessageBox.Show("A quantidade informada é inválida!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                invalido = true;
            }

            if (FuncoesControles.verificaVazio(this.pnlCadProduto) == false && invalido != true)
            {
                dto.Nome = txtNome.Text.ToUpper().Trim();
                dto.Fornecedor = cbFornecedor.Text;
                dto.Medida = cbUnidade.Text;
                dto.Status = cbStatus.Text;
                dto.CompraAtual = Convert.ToDateTime((txtDataCompraAtual.Value).ToShortDateString());
                dto.Descricao = txtDescricao.Text.Trim().ToUpper();
                dto.Locacao = cbLocacao.Text;

                if (txtId.Text == "")
                {
                    bll.Inserir(dto);
                }
                else
                {
                    dto.Id = int.Parse(txtId.Text);
                    bll.Atualizar(dto);
                    btnCadastrarAtualizar.Text = "Cadastrar";
                }

                dgvConsulta.Rows.Clear();
                FuncoesControles.limpaCampos(this.pnlCadProduto);
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos foram informados ou se os dados são válidos!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bll.Excluir(txtId.Text);
            FuncoesControles.limpaCampos(this.pnlCadProduto);
            btnExcluir.Enabled = false;
            btnCadastrarAtualizar.Text = "Cadastrar";
        }

        // ==========================================================================================
        // Botões de navegação
        // ==========================================================================================
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0 && dgvConsulta.Rows.Count > 0)
            {
                indice--;
                visualizarDadosProduto(indice);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (indice < dgvConsulta.Rows.Count - 2 && dgvConsulta.Rows.Count > 0)
            {
                indice++;
                visualizarDadosProduto(indice);
            }
        }

        // ==========================================================================================
        // DataGridView
        // ==========================================================================================
        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                visualizarDadosProduto(indice);
            }
        }

        private void CarregarGrid()
        {
            int id;
            DataTable dt = new DataTable();

            dgvConsulta.Refresh();

            if (txtId.Text != "")
                btnCadastrarAtualizar.Text = "Atualizar";                 

            if (int.TryParse(txtIdCon.Text, out id))
            {
                dt = bll.selecionaProduto(id, "");
                auxCarregarGrid(dt);
            }
            else
            {
                dt = bll.selecionaProduto(txtNomeCon.Text.ToUpper().Trim(), "");
                auxCarregarGrid(dt);
            }
        }

        public void auxCarregarGrid(DataTable dt)
        {
            dgvConsulta.Rows.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string aux = Convert.ToDateTime(dt.Rows[i]["ultima_compra"].ToString()).ToShortDateString();

                dgvConsulta.Rows.Add(dt.Rows[i]["id_produto"].ToString(), dt.Rows[i]["nome"].ToString(), dt.Rows[i]["fornecedor"].ToString(),
                                     dt.Rows[i]["medida"].ToString(), dt.Rows[i]["status"].ToString(), aux, dt.Rows[i]["descricao"].ToString(),
                                     dt.Rows[i]["preco"].ToString(), dt.Rows[i]["quantidade"].ToString(), dt.Rows[i]["locacao"].ToString());
            }
        }

        public void visualizarDadosProduto(int indice)
        {
            txtId.Text =dgvConsulta.Rows[indice].Cells[0].Value.ToString();
            txtNome.Text = dgvConsulta.Rows[indice].Cells[1].Value.ToString();
            cbFornecedor.Text = dgvConsulta.Rows[indice].Cells[2].Value.ToString();
            cbUnidade.Text = dgvConsulta.Rows[indice].Cells[3].Value.ToString();
            cbStatus.Text = dgvConsulta.Rows[indice].Cells[4].Value.ToString();
            txtUltimaCompra.Text = dgvConsulta.Rows[indice].Cells[5].Value.ToString();
            txtDescricao.Text = dgvConsulta.Rows[indice].Cells[6].Value.ToString();
            txtPreco.Text = dgvConsulta.Rows[indice].Cells[7].Value.ToString();
            txtQtdeDisponivel.Text = dgvConsulta.Rows[indice].Cells[8].Value.ToString();
            cbLocacao.Text = dgvConsulta.Rows[indice].Cells[9].Value.ToString();
           
            btnCadastrarAtualizar.Text = "Atualizar";
            btnExcluir.Enabled = true;
        }

        // ==========================================================================================
        // Inicialização do UserForm
        // ==========================================================================================
        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            PessoaBLL bll = new PessoaBLL();
            DataTable dt = bll.selecionaFornecedor();

            // Carrega fornecedores na combobox
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbFornecedor.Items.Add(dt.Rows[i]["nome"].ToString());
            }
        }
    }
}

