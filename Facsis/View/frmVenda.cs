using System;
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
        VendaBLL bll = new VendaBLL();
        
        int indiceCarrinho = 0;
        string tipo_op;

        public frmVenda()
        {
            InitializeComponent();
        }

        public frmVenda(string tipo_op)
        {
            InitializeComponent();
            this.tipo_op = tipo_op;
        }

        private void btnAdicinaCliente_Click(object sender, EventArgs e)
        {
            buscaPessoa?.Close();
            buscaPessoa = new frmCadPessoa(txtIdCli, txtNome);
            buscaPessoa.Show();                        
        }

        public void atualizaFormulario()
        {
            txtIdCli.Text = VendaDTO.IdCliente.ToString();
            txtNome.Text = VendaDTO.NomeCliente;

            MessageBox.Show(VendaDTO.IdCliente.ToString());
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            if (tipo_op == "Orçamento")
            {
                ckbOrcamento.Checked = true;
                ckbVenda.Enabled = false;
                this.Text = "Orçamento";
            }
            else
            {
                txtNumPedido.Text = (bll.ultimaVenda() + 1).ToString();
                txtIdVendedor.Text = LoginDTO.Id.ToString();
            }
                
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            iniciaBuscaProduto();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvCarrinho.Rows.Remove(dgvCarrinho.Rows[indiceCarrinho]);
        }

        private void txtVlrBruto_TextChanged(object sender, EventArgs e)
        {
            double porcentagem = 0;

            if (double.TryParse(txtPorcentagem.Text, out porcentagem))
                porcentagem = Convert.ToDouble(txtPorcentagem.Text) / 100;

            double vlrBruto = Convert.ToDouble(txtVlrBruto.Text);
            double totalLiquido = 0;

            totalLiquido = vlrBruto - (vlrBruto * porcentagem);
            txtVlrDesconto.Text = totalLiquido.ToString();
            txtValorTotal.Text = totalLiquido.ToString();
        }

        private void dvgCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCarrinho = dgvCarrinho.Rows[e.RowIndex].Index;
        }


        public void iniciaBuscaProduto()
        {
            buscaProduto?.Close();
            buscaProduto = new frmConProduto(dgvCarrinho, txtVlrBruto);
            buscaProduto.Show();
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

        public void limparDataGrid()
        {
            dgvCarrinho.Rows.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar o carrinho?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                limparDataGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (FuncoesControles.verificaVazio(panel3) == false)
            {
                dto = new VendaDTO();

                dto.CodCliente = int.Parse(txtIdCli.Text);
                dto.CodVendedor = int.Parse(txtIdVendedor.Text);
                dto.DataNota = Convert.ToDateTime(dtNota.Value.ToShortDateString());
                dto.DataPedido = Convert.ToDateTime(dtPedido.Value.ToShortDateString());
                dto.TipoOp = ckbVenda.Checked == true ? "Venda" : "Orçamento";
                dto.FormaPag = cbFormaPgto.Text;

                if (rdAtualizar.Checked == true)
                    dto.Status = "Atualizar";
                else if (rdPendente.Checked == true)
                    dto.Status = "Pendente";
                else if (rdCancelar.Checked == true)
                    dto.Status = "Cancelar";

                dto.ItensPedido = dgvCarrinho;

                if (rdCancelar.Checked != true)
                {
                    bll.registrar(dto);
                    //FuncoesControles.limpaCampos(panel3);
                    //dgvCarrinho.Rows.Clear();
                }
                    
                
            }
            else
                Mensagens.camposVazios(); 
        }
    }
}
