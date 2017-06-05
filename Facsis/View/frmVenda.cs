using System;
using System.Windows.Forms;
using Facsis.Model.DTO;

namespace Facsis.View
{
    public partial class frmVenda : Form
    {
        Form buscaPessoa = new frmBuscaPessoa();
        VendaDTO dto = new VendaDTO(); 

        public frmVenda()
        {
            InitializeComponent();
        }

        private void rdBtnCancelar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicinaCliente_Click(object sender, EventArgs e)
        {
            buscaPessoa?.Close();
            buscaPessoa = new frmBuscaPessoa(txtCodCli, txtNome);
            buscaPessoa.Show();                        
        }

        public void atualizaFormulario()
        {
            txtCodCli.Text = VendaDTO.IdCliente.ToString();
            txtNome.Text = VendaDTO.NomeCliente;

            MessageBox.Show(VendaDTO.IdCliente.ToString());
        }
    }
}
