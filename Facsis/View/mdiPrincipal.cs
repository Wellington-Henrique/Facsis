using System;
using System.Data;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Controller.Util;

namespace Facsis.View
{
    public partial class mdiPrincipal : Form
    {
        frmCadProduto cadProduto;
        frmCadUsuario cadUsuario;
        frmCalculadora calculadora;
        frmVenda venda;
        frmCadPessoa cadCliente;
        frmCadPessoa cadFornecedor;
        frmLogin login;
        frmConProduto conProduto;
        frmConVenda conVenda;     

        string[] vetVenda;

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

        // ==========================================================================================
        // UserForms de cadastro/registro
        // ==========================================================================================
        private void tsmNovaVenda_Click(object sender, EventArgs e)
        {
            venda?.Close();
            venda = new frmVenda();
            venda.MdiParent = this;
            venda.Show();
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
            cadCliente?.Close();
            cadCliente = new frmCadPessoa("Cliente");
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void tsmCadFornecedor_Click(object sender, EventArgs e)
        {
            cadFornecedor?.Close();
            cadFornecedor = new frmCadPessoa("Fornecedor");
            cadFornecedor.MdiParent = this;
            cadFornecedor.Show();
        }

        private void tsmCadProduto_Click(object sender, EventArgs e)
        {
            cadProduto?.Close();
            cadProduto = new frmCadProduto();
            cadProduto.MdiParent = this;
            cadProduto.Show();
        }

        // ==========================================================================================
        // UserForms de consulta
        // ==========================================================================================
        private void tsmConsCliente_Click(object sender, EventArgs e)
        {
            cadCliente?.Close();
            cadCliente = new frmCadPessoa("Cliente");
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void tsmConsFornecedor_Click(object sender, EventArgs e)
        {
            cadFornecedor?.Close();
            cadFornecedor = new frmCadPessoa("Fornecedor");
            cadFornecedor.MdiParent = this;
            cadFornecedor.Show();
        }

        private void tsmConsProduto_Click(object sender, EventArgs e)
        {
            conProduto?.Close();
            conProduto = new frmConProduto();
            conProduto.MdiParent = this;
            conProduto.Show();
        }

        // ==========================================================================================
        // Inicialização do UserForm
        // ==========================================================================================
        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            carregaDadosUsuario();
            habilitaCampos();
        }

        public void carregaDadosUsuario()
        {
            this.Text = "Facsis - " + LoginDTO.Nome;
            tsslblStatus.Text = LoginDTO.Nivel + " - " + DateTime.Today.ToShortDateString();
        }

        // ==========================================================================================
        // Ferramentas
        // ==========================================================================================
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaCalculadora();
        }

        public void iniciaCalculadora()
        {
            calculadora?.Close();
            calculadora = new frmCalculadora();
            calculadora.MdiParent = this;
            calculadora.Show();
        }

        // ==========================================================================================
        // Botões de fechar
        // ==========================================================================================
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login?.Close();
            //this.Hide();
            this.Enabled = false;
            login = new frmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                //this.Show();
                this.Enabled = true;
                carregaDadosUsuario();
                habilitaCampos();
            }

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensagens.fechaAplicao();
        }

        private void mdiPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "Você tem certeza que deseja sair?",
                    "Facsis", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    Application.Exit(); //Encerra o sistema
                else
                    e.Cancel = true; //Permanece no sistema
            }
        }

        // ==========================================================================================
        // Ferramentas de logoff
        // ==========================================================================================
        public void habilitaCampos()
        {
            tsmCadCliente.Enabled = true;
            tsmCadProduto.Enabled = true;
            tsmCadFornecedor.Enabled = true;
            tsmVendas.Enabled = true;
            tsmConsultar.Enabled = true;
            tsmCadUsuario.Enabled = true;
            tsmRelatorios.Enabled = true;

            if (LoginDTO.Nivel == "Vendedor")
            {
                tsmCadProduto.Enabled = false;
                tsmCadFornecedor.Enabled = false;
                tsmConsFornecedor.Enabled = false;
                tsmCadUsuario.Enabled = false;
                tsmRelatorios.Enabled = false;
            }

            else if (LoginDTO.Nivel == "Estoquista")
            {
                tsmVendas.Enabled = false;
                tsmConsultar.Enabled = false;
                tsmCadUsuario.Enabled = false;
                tsmCadCliente.Enabled = false;
                tsmRelatorios.Enabled = false;
            }
        }

        private void tsmVendaPendente_Click(object sender, EventArgs e)
        {
            DataTable dtCarrinho = new DataTable();
            vetVenda = new string[8];

            //dvgCarrinho.Columns.Add("id_produto", "Cód");
            //dvgCarrinho.Columns.Add("nome", "Nome");
            //dvgCarrinho.Columns.Add("descricao", "Descricao");
            //dvgCarrinho.Columns.Add("medida", "UN");
            //dvgCarrinho.Columns.Add("quantidade", "Qtde");
            //dvgCarrinho.Columns.Add("vlr_unitario", "Vlr UN");            
                        
            conVenda?.Close();
            conVenda = new frmConVenda(vetVenda);

            if (conVenda.ShowDialog() == DialogResult.OK)
            {
                venda?.Close();
                venda = new frmVenda(vetVenda);
                venda.MdiParent = this;
                venda.Show();
            }
        }
    }
}
