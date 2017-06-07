using System;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;
using System.Data;

namespace Facsis.View
{
    public partial class frmConPessoa : Form
    {
        PessoaBLL bll = new PessoaBLL();
        PessoaDTO dto = new PessoaDTO();
        DataTable dt;

        TextBox id;
        TextBox nome;

        string idCliente;
        string nomeCliente;

        int indice;

        public frmConPessoa()
        {
            InitializeComponent();
        }

        public frmConPessoa(TextBox id, TextBox nome)
        {
            InitializeComponent();

            this.id = id;
            this.nome = nome;
        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dt = new DataTable();

            dgvPessoa.DataSource = null;

            if (txtCodigo.Text != "")
                dto.Id = int.Parse(txtCodigo.Text.Trim());
            else
                dto.Id = 0;

            dto.Nome = (txtNome.Text).ToUpper();
            dto.CPF_CNPJ = txtCpf_Cnpj.Text;

            dt = bll.selecionaPessoa(dto);

            //if (dt == null)
            //    Mensagens.campoVazioCadastrar();
            //else
                dgvPessoa.DataSource = dt;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            selecionaLinhaGrid(indice);

            if (btnInserir.Text == "Inserir")
                btnInserir.Text = "Alterar";
            else
                btnInserir.Text = "Inserir";

            id.Text = this.idCliente;
            nome.Text = this.nomeCliente;
        }

        private void dgvPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        public void selecionaLinhaGrid(int indice)
        {
            if (dgvPessoa.DataSource != null)
            {
                idCliente = Convert.ToString(dgvPessoa.Rows[indice].Cells[0].Value);
                nomeCliente = Convert.ToString(dgvPessoa.Rows[indice].Cells[1].Value);
            }
        }

        private void inserirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selecionaLinhaGrid(indice);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            id.Text = "";
            nome.Text = "";
            btnInserir.Text = "Inserir";
        }

        private void frmBuscaPessoa_Load(object sender, EventArgs e)
        {   
               
        }
    }
}
