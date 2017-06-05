using System;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;

namespace Facsis.View
{
    public partial class mdiPrincipal : Form
    {
        Form cadPessoa;
        Form cadProduto;
        Form cadUsuario;
        Form calculadora;
        Form venda;
        Form conPessoa;

        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = tsmBarraStatus.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tsmOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void tsmCadUsuario_Click(object sender, EventArgs e)
        {
            cadUsuario?.Close();
            cadUsuario = new frmCadUsuario();
            cadUsuario.MdiParent = this;
            cadUsuario.Show();
        }

        private void tsmCadCliente_Click(object sender, EventArgs e)
        {
            iniciaFomCadPessoa();
        }

        private void tsmCadProduto_Click(object sender, EventArgs e)
        {
            cadProduto?.Close();
            cadProduto = new frmCadProduto();
            cadProduto.MdiParent = this;
            cadProduto.Show();
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Facsis - " + LoginDTO.Nome;
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaCalculadora();
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            iniciaCalculadora();
        }

        
        private void tsmNovaVenda_Click(object sender, EventArgs e)
        {
            venda?.Close();
            venda = new frmVenda();
            venda.MdiParent = this;
            venda.Show();
        }

        private void tsmConsCliente_Click(object sender, EventArgs e)
        {
            iniciaFomConPessoa();
        }

        private void tsmCadFornecedor_Click(object sender, EventArgs e)
        {
            iniciaFomCadPessoa();
        }

        public void iniciaFomConPessoa()
        {
            conPessoa?.Close();
            conPessoa = new frmBuscaPessoa();
            conPessoa.MdiParent = this;
            conPessoa.Show();
        }

        public void iniciaFomCadPessoa()
        {
            cadPessoa?.Close();
            cadPessoa = new frmCadPessoa();
            cadPessoa.MdiParent = this;
            cadPessoa.Show();
        }

        public void iniciaCalculadora()
        {
            calculadora?.Close();
            calculadora = new frmCalculadora();
            calculadora.MdiParent = this;
            calculadora.Show();
        }
    }
}
