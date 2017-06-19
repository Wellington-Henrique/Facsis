using System;
using System.Data;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;

namespace Facsis.View
{
    public partial class frmVenda : Form
    {
        Form buscaPessoa = new frmCadPessoa();
        Form buscaProduto = new frmConProduto();
        VendaDTO dto = new VendaDTO();
        ProdutoDTO dtoProd = new ProdutoDTO();
        VendaBLL bll = new VendaBLL();
        string statusVenda = "Faturada";

        int indiceCarrinho = 0;
        int nVendaAtual = 0;

        public frmVenda()
        {
            InitializeComponent();
        }

        public frmVenda(string[] dgvVenda)
        {
            InitializeComponent();

            txtNumPedido.Text = dgvVenda[0]; // Código venda
            txtIdVendedor.Text = dgvVenda[1]; // Código usuário
            txtIdCli.Text = dgvVenda[2]; // Código cliente
            txtNome.Text = dgvVenda[3]; // Nome cliente
            dtNota.Text = dgvVenda[4]; // Data nota
            dtPedido.Text = dgvVenda[5]; // Data pedido            
            rdPendente.Checked = true;
            cbFormaPgto.Text = dgvVenda[7].ToString(); // Forma pgto
            statusVenda = "Pendente";
            btnInserir.Enabled = false;

            //dgvCarrinho = VendaDTO.DvgConsulta;
        }

        // ==========================================================================================
        // INSERT, UPDATE, DELETE registro
        // ==========================================================================================
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (FuncoesControles.verificaVazio(panel3) == false && txtIdCli.Text != "")
            {
                dto = new VendaDTO();

                dto.CodCliente = int.Parse(txtIdCli.Text);
                dto.CodVendedor = int.Parse(txtIdVendedor.Text);
                dto.DataNota = Convert.ToDateTime(dtNota.Value.ToShortDateString());
                dto.DataPedido = Convert.ToDateTime(dtPedido.Value.ToShortDateString());
                dto.TipoOp = "Venda";
                dto.FormaPag = cbFormaPgto.Text;
                dto.ItensPedido = dgvCarrinho;

                if (rdFaturar.Checked == true)
                    dto.Status = "Faturada";
                else if (rdPendente.Checked == true)
                    dto.Status = "Pendente";
                else if (rdCancelar.Checked == true)
                {
                    if (MessageBox.Show("Você deseja realmente cancelar esta venda?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        dto.Status = "Cancelada";
                    else
                        return;
                }

                double aux;

                if (double.TryParse(txtValorTotal.Text , out aux))
                {
                    dto.Total = Convert.ToDouble(txtValorTotal.Text);
                    if (statusVenda == "Faturada")
                        bll.registrar(dto);
                    else
                        bll.Atualizar(dto);
                }

                //FuncoesControles.limpaCampos(panel3);
                //FuncoesControles.limpaCampos(groupBox1);
                //txtIdVendedor.Text = LoginDTO.Id.ToString();
                nVendaAtual++;
                //txtNumPedido.Text = nVendaAtual.ToString();
                //dgvCarrinho.Rows.Clear();
            }
            else
                Mensagens.camposVazios();
        }

        // ==========================================================================================
        // Informa dados de cliente e vendedor
        // ==========================================================================================
        private void btnAdicinaCliente_Click(object sender, EventArgs e)
        {
            buscaPessoa?.Close();
            buscaPessoa = new frmCadPessoa(txtIdCli, txtNome);
            buscaPessoa.Show();
        }

        // ==========================================================================================
        // Inicio do UserForm
        // ==========================================================================================
        private void frmVenda_Load(object sender, EventArgs e)
        {
            if (statusVenda == "Faturada")
            {
                nVendaAtual = bll.ultimaVenda() + 1;
                txtNumPedido.Text = nVendaAtual.ToString();
                txtIdVendedor.Text = LoginDTO.Id.ToString();
            }
            else
            {
                DataTable aux = VendaDTO.Dt;
                double total = 0;

                for (int i =0; i < aux.Rows.Count; i++)
                {
                    dtoProd.Id = int.Parse(aux.Rows[i][9].ToString());
                    dtoProd.Nome = aux.Rows[i][10].ToString();
                    dtoProd.Descricao = aux.Rows[i][11].ToString();
                    dtoProd.Medida = aux.Rows[i][12].ToString();
                    dtoProd.Quantidade = int.Parse(aux.Rows[i][13].ToString());
                    dtoProd.Preco = double.Parse(aux.Rows[i][14].ToString());

                    dgvCarrinho.Rows.Add(dtoProd.Id, dtoProd.Nome, dtoProd.Descricao, dtoProd.Medida, dtoProd.Quantidade, dtoProd.Preco, dtoProd.Quantidade * dtoProd.Preco);
                    total += dtoProd.Quantidade * dtoProd.Preco;
                }

                txtVlrBruto.Text = total.ToString();
                VendaDTO.Dt = null;
                aux = null;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            iniciaBuscaProduto();
        }

        public void iniciaBuscaProduto()
        {
            buscaProduto?.Close();
            buscaProduto = new frmConProduto(dgvCarrinho, txtVlrBruto);
            buscaProduto.Show();
        }

        // ==========================================================================================
        // Itens do carrinho
        // ==========================================================================================
        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvCarrinho.Rows.Remove(dgvCarrinho.Rows[indiceCarrinho]);
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaBuscaProduto();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvCarrinho.Rows.Remove(dgvCarrinho.Rows[indiceCarrinho]);
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDataGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar o carrinho?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                limparDataGrid();
        }

        // ==========================================================================================
        // DataGridView
        // ==========================================================================================
        private void dvgCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarrinho.Rows[e.RowIndex].Index >= 0)
                indiceCarrinho = dgvCarrinho.Rows[e.RowIndex].Index ;
        }

        public void limparDataGrid()
        {
            dgvCarrinho.Rows.Clear();
        }

        private void txtVlrBruto_TextChanged(object sender, EventArgs e)
        {
            double porcentagem;

            if (double.TryParse(txtPorcentagem.Text, out porcentagem))
                porcentagem = Convert.ToDouble(txtPorcentagem.Text) / 100;
            else
                porcentagem = 0;

            double vlrBruto = Convert.ToDouble(txtVlrBruto.Text);
            double totalLiquido = 0;

            totalLiquido = vlrBruto - (vlrBruto * porcentagem);
            txtVlrDesconto.Text = totalLiquido.ToString();
            txtValorTotal.Text = totalLiquido.ToString();
        }
    }
}
