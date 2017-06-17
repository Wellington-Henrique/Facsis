using System;
using System.Data;
using System.Windows.Forms;

using Facsis.Model.BLL;
using Facsis.Model.DTO;
using Facsis.Controller.Util;

namespace Facsis.View
{
    public partial class frmConProduto : Form
    {
        ProdutoBLL bll = new ProdutoBLL();
        ProdutoDTO dto = new ProdutoDTO();
        DataGridView dgvCarrinho = new DataGridView();
        double total = 0;
        TextBox txtTotal = new TextBox();
        int indice = 0;

        public frmConProduto()
        {
            InitializeComponent();
        }

        public frmConProduto(DataGridView dgv, TextBox vlrBruto)
        {
            InitializeComponent();

            dgvCarrinho = dgv;
            txtTotal = vlrBruto;
        }

        // ==========================================================================================
        // SELECT
        // ==========================================================================================
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(); // Carrega os dados na dgvConsulta
        }

        // ==========================================================================================
        // Botões do carrinho de compras
        // ==========================================================================================
        private void btnInserir_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            int auxQuantidade = 0;
            int indiceCarrinho = 0;
            bool noCarrinho = false;
            total = 0;

            // Verifica se a quantidade é um valor inteiro
            if (int.TryParse(txtQuantidade.Text, out quantidade) && txtId.Text != "")
            {
                quantidade = int.Parse(txtQuantidade.Text);
                string consultaCarrinho = "";

                // Verifica se o produto já está no carrinho
                for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                {
                    consultaCarrinho = Convert.ToString(dgvCarrinho.Rows[i].Cells[0].Value);

                    if (txtId.Text == consultaCarrinho)
                    {
                        indiceCarrinho = i;
                        auxQuantidade = Convert.ToInt32(dgvCarrinho.Rows[indiceCarrinho].Cells[3].Value);
                        noCarrinho = true;
                        break;
                    }
                }

                quantidade += auxQuantidade;
                // verifica se existe a quantidade necessária no estoque
                if (dto.Quantidade >= quantidade && quantidade > 0)
                {
                    // Adiciona ao carrinho caso tenha sido adicionado
                    if (noCarrinho == false)
                        dgvCarrinho.Rows.Add(dto.Id, dto.Nome, dto.Medida, quantidade, dto.Preco, quantidade * dto.Preco);

                    else
                    {
                        dgvCarrinho.Rows[indiceCarrinho].Cells[3].Value = quantidade.ToString();
                        dgvCarrinho.Rows[indiceCarrinho].Cells[5].Value = quantidade * dto.Preco;
                    }

                    // Calcula o total do carrinho
                    for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                    {
                        total += Convert.ToDouble(dgvCarrinho.Rows[i].Cells[5].Value);
                    }

                    txtTotal.Text = total.ToString();
                }
                else
                    MessageBox.Show("Quantidade insuficiente no estoque.", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Informe uma quantidade válida maior que zero!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o UserForm
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
            dto.Id = Convert.ToInt32(dgvConsulta.Rows[e.RowIndex].Cells[0].Value);
            dto.Nome = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[1].Value);
            dto.Medida = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[2].Value);
            dto.Descricao = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
            dto.Preco = Convert.ToDouble(dgvConsulta.Rows[e.RowIndex].Cells[4].Value);
            dto.Quantidade = Convert.ToInt32(dgvConsulta.Rows[e.RowIndex].Cells[5].Value);

            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                visualizarDadosProduto(indice);
            }
        }

        private void carregarGrid()
        {
            int id;

            DataTable dt = new DataTable();
            dgvConsulta.Rows.Clear();
            
            if (Int32.TryParse(txtIdCon.Text, out id))
            {
                dt = bll.selecionaProduto(Convert.ToInt32(txtIdCon.Text), "Venda");
                auxCarregarGrid(dt);
            }
            else
            {
                dt = bll.selecionaProduto(txtNomeCon.Text.ToUpper().Trim(), "Venda");
                auxCarregarGrid(dt);
            }
        }

        public void auxCarregarGrid(DataTable dt)
        {
            dgvConsulta.Rows.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string aux = Convert.ToDateTime(dt.Rows[i]["ultima_compra"].ToString()).ToShortDateString();

                dgvConsulta.Rows.Add(dt.Rows[i]["id_produto"].ToString(), dt.Rows[i]["nome"].ToString(), dt.Rows[i]["descricao"].ToString(),
                                         dt.Rows[i]["medida"].ToString(), dt.Rows[i]["preco"].ToString(), dt.Rows[i]["quantidade"].ToString());
            }
        }

        private void visualizarDadosProduto(int indice)
        {
            txtId.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[0].Value);
            txtNome.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[1].Value);
            txtQuantidade.Focus();
        }
    }
}

