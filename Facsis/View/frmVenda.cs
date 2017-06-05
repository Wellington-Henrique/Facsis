using System;

using System.Windows.Forms;

namespace Facsis.View
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void rdBtnCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCancelar.Checked == true)
            {
                if (MessageBox.Show("Deseja realmente cancelar este pedido?", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void lblLegNomeCli_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
