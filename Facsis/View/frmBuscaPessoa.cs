using System;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;
using System.Data;

namespace Facsis.View
{
    public partial class frmBuscaPessoa : Form
    {

        PessoaBLL bll = new PessoaBLL();
        PessoaDTO dto = new PessoaDTO();
        DataTable dt = new DataTable();

        public frmBuscaPessoa()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPessoa.DataSource = null;

            if (txtCodigo.Text != "")
                dto.Id = int.Parse(txtCodigo.Text.Trim());
            else
                dto.Id = 0;            

            dto.Nome = txtNome.Text;
            dto.CPF_CNPJ = txtCpf_Cnpj.Text;

            dt = bll.selecionaPessoa(dto);

            if (dt == null)
                Mensagens.campoVazioCadastro();
            else
                dgvPessoa.DataSource = dt;
                   
        }
}
}
