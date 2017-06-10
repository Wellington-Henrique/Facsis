using System;
using System.Windows.Forms;

using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;

namespace Facsis.View
{
    public partial class frmCadPessoa : Form
    {
        PessoaBLL bll = new PessoaBLL();
        PessoaDTO dto = new PessoaDTO();
        frmConPessoa conPessoa = new frmConPessoa();

        public frmCadPessoa()
        {
            InitializeComponent();
        }

        public frmCadPessoa(string tipo)
        {
            InitializeComponent();

            if (tipo == "Fornecedor")
                this.Text = "Cadastro fornecedor";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FuncoesControles.limpaCampos(panel2);
            FuncoesControles.limpaCampos(panel1);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            string nome = txtNome.Text.Trim().ToUpper();
            dto.Nome = nome;
            dto.Tipo = cbPessoa.Text.Trim();
            dto.Email = txtEmail.Text.Trim().ToLower();
            dto.Telefone = txtTelefone.Text.Trim();
            dto.Endereco = txtRua.Text.Trim();
            dto.NImovel = int.Parse(txtNImovel.Text.Trim());
            dto.Cidade = txtCidade.Text.Trim();
            dto.UF = txtUf.Text;
            dto.CPF_CNPJ = txtCpf_Cnpj.Text;

            if (txtId.Text == "")
            {
                bll.Inserir(dto);
            }
            else
            {
                //bll.Atualizar(dto.Id);
                FuncoesControles.limpaCampos(this.panel2);
                FuncoesControles.limpaCampos(this.panel1);
                btnCadastrar.Text = "Cadastrar";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            conPessoa?.Close();
            conPessoa = new frmConPessoa();
            conPessoa.Show();
        }
    }
}
