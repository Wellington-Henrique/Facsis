using System;
using System.Windows.Forms;
using Facsis.Model.DTO;

namespace Facsis.View
{
    public partial class frmVenda : Form
    {
        Form buscaPessoa = new frmConPessoa();
        Form buscaProduto = new frmConProduto();
        VendaDTO dto = new VendaDTO();
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
        private void rdBtnCancelar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicinaCliente_Click(object sender, EventArgs e)
        {
            buscaPessoa?.Close();
            buscaPessoa = new frmConPessoa(txtCodCli, txtNome);
            buscaPessoa.Show();                        
        }

        public void atualizaFormulario()
        {
            txtCodCli.Text = VendaDTO.IdCliente.ToString();
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
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            iniciaBuscaProduto();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dvgCarrinho.Rows.Remove(dvgCarrinho.Rows[indiceCarrinho]);
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
            indiceCarrinho = dvgCarrinho.Rows[e.RowIndex].Index;
        }


        public void iniciaBuscaProduto()
        {
            buscaProduto?.Close();
            buscaProduto = new frmConProduto(dvgCarrinho, txtVlrBruto);
            buscaProduto.Show();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaBuscaProduto();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dvgCarrinho.Rows.Remove(dvgCarrinho.Rows[indiceCarrinho]);
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDataGrid();
        }

        public void limparDataGrid()
        {
            dvgCarrinho.Rows.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparDataGrid();
        }
    }
}
