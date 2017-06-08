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

        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool invalido = false;

            try
            {
                dto.Preco = double.Parse(txtPreco.Text.Trim());
            }
            catch (Exception)
            {
                if (txtPreco.Text != "")
                    MessageBox.Show("O preço informado é inválido!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                invalido = true;
            }


            try
            {
                dto.Quantidade = int.Parse(txtQtdeCompra.Text);
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
                dto.Descricao = txtDescricao.Text.Trim();

                if (txtId.Text == "")
                {
                    bll.Inserir(dto);
                    //CarregarGrid();
                }
                else
                {
                    dgvConsulta.Refresh();
                    dto.Id = int.Parse(txtId.Text);
                    bll.Atualizar(dto);
                    btnCadastrar.Text = "Cadastrar";
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos foram informados ou se os dados são válidos!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void CarregarGrid()
        {
            int id;
            dgvConsulta.Rows.Clear();

            if (txtId.Text != "")
                btnCadastrar.Text = "Atualizar";

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
                    dgvConsulta.Rows.Add(dt.Rows[i]["id_produto"].ToString(), dt.Rows[i]["nome"].ToString(), dt.Rows[i]["fornecedor"].ToString(),
                                         dt.Rows[i]["medida"].ToString(), dt.Rows[i]["status"].ToString(), dt.Rows[i]["ultima_compra"].ToString(),
                                         dt.Rows[i]["descricao"].ToString(), dt.Rows[i]["preco"].ToString());

                    barraProgresso.Value = i;
                }

                barraProgresso.Visible = false;

                //dgvConsulta = DataGridFuncoes.carregaDV(dt, barraProgresso);

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
            //txtId.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[0].Value);
            //txtNome.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[1].Value);
            //txtEmail.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[2].Value);
            //txtTelefone.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[3].Value);
            //cbNivel.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[4].Value);
            //txtLogin.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[5].Value);
            //txtSenha.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[6].Value);
        }
    }
}

