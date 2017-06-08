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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            buscaProduto?.Close();
            buscaProduto = new frmConProduto(dvgCarrinho, txtVlrBruto);
            buscaProduto.Show();
        }
    }
}
