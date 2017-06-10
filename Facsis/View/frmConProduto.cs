﻿using System;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
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
                if (dto.Quantidade >= quantidade)
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

        private void CarregarGrid()
        {
            int id;
            dgvConsulta.Rows.Clear();

            if (txtId.Text != "")
                btnInserir.Text = "Atualizar";

            if (Int32.TryParse(txtConsulta.Text, out id))
            {
                dgvConsulta.DataSource = bll.selecionaProduto(Convert.ToInt32(txtConsulta.Text));
            }
            else
            {
                string nome = txtConsulta.Text;
                DataTable dt = bll.selecionaProduto(nome.ToUpper().Trim());

                barraProgresso.Visible = true;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvConsulta.Rows.Add(dt.Rows[i]["id_produto"].ToString(), dt.Rows[i]["nome"].ToString(),
                                         dt.Rows[i]["medida"].ToString(), dt.Rows[i]["preco"].ToString(), dt.Rows[i]["quantidade"].ToString());

                    barraProgresso.Value = i;
                }

                barraProgresso.Visible = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            //dgvConsulta.Columns[0].HeaderText = "Código";
            //dgvConsulta.Columns[1].HeaderText = "Nome";
            //dgvConsulta.Columns[2].HeaderText = "Fornecedor";
            //dgvConsulta.Columns[3].HeaderText = "Medida";
            //dgvConsulta.Columns[4].HeaderText = "Status";
            //dgvConsulta.Columns[5].HeaderText = "Última compra";
            //dgvConsulta.Columns[6].HeaderText = "Descrição";
            //dgvConsulta.Columns[7].HeaderText = "Preço";
            //dgvConsulta.Columns[8].HeaderText = "Qtde";
            //dgvConsulta.Columns[9].HeaderText = "Locação";
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dto.Id = Convert.ToInt32(dgvConsulta.Rows[e.RowIndex].Cells[0].Value);
            dto.Nome = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[1].Value);
            dto.Medida = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[2].Value);
            dto.Preco = Convert.ToDouble(dgvConsulta.Rows[e.RowIndex].Cells[3].Value);
            dto.Quantidade = Convert.ToInt32(dgvConsulta.Rows[e.RowIndex].Cells[4].Value);

            txtId.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[0].Value);
            txtNome.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[1].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
