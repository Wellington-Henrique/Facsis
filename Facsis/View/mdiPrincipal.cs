using System;
using System.Windows.Forms;

namespace Facsis.View
{
    public partial class mdiPrincipal : Form
    {
        Form janelas;        

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
            janelas?.Close();
            janelas = new frmCadUsuario();

            janelas.MdiParent = this;
            janelas.Show();
        }

        private void tsmCadCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(DateTime.Now.ToShortDateString()));
        }

        private void tsmCadProduto_Click(object sender, EventArgs e)
        {
            //cadProduto?.Close();
            //cadProduto = new frmCadProduto();
            //cadProduto.MdiParent = this;
            //cadProduto.Show();
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
