using System;
using System.Windows.Forms;
using Facsis.Controller.Util;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using Facsis.Controller.Util;

namespace Facsis.View
{
    public partial class frmCadUsuario : Form
    {
        UsuarioBLL bll = new UsuarioBLL();
        UsuarioDTO dto = new UsuarioDTO();

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            dto.Nome = txtNome.Text.Trim().ToUpper();
            dto.Email = txtEmail.Text.Trim().ToLower();
            dto.Telefone = txtTelefone.Text.Trim();
            dto.Nivel = cbNivel.Text.Trim();
            dto.Login = txtLogin.Text.Trim();
            dto.Senha = txtSenha.Text.Trim();

            if (txtId.Text == "")
            {
                bll.Inserir(dto);
                CarregarGrid();
            }
            else
            {
                dto.Id = int.Parse(txtId.Text);
                bll.Atualizar(dto);
                btnCadastrar.Text = "Cadastrar";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bll.Excluir(txtId.Text);
            FuncoesControles.limpaCampos(this.pnlUsuario);
            btnCadastrar.Text = "Cadastrar";
            txtConsulta.Text = "";
            txtTelefone.Text = "";
            dgvConsulta.DataSource = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FuncoesControles.limpaCampos(this.pnlUsuario);
            txtTelefone.Text = "";
            btnExcluir.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {            
            CarregarGrid();
        }

        private void dgvConsulta_Click(object sender, DataGridViewCellEventArgs e)
        {
            CarregarGrid();

            txtId.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[0].Value);
            txtNome.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[1].Value);
            txtEmail.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[2].Value);
            txtTelefone.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[3].Value);
            cbNivel.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[4].Value);
            //txtLogin.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[5].Value);
            //txtSenha.Text = Convert.ToString(dgvConsulta.Rows[e.RowIndex].Cells[6].Value);
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Atualizar";
        }

        private void CarregarGrid()
        {
            int id;
            dgvConsulta.Refresh();
            
            if(txtId.Text != "")
                btnCadastrar.Text = "Atualizar";

            if (Int32.TryParse(txtConsulta.Text, out id))
            {
                dgvConsulta.DataSource = bll.selecionaUsuarioId(Convert.ToInt32(txtConsulta.Text));
            }
            else
            {
                dgvConsulta.DataSource = bll.selecionaUsuarioNome(txtConsulta.Text);
            }

            DataGridFuncoes.cabecalhoTabUsuario(dgvConsulta);
        }      

        private void restaurarTamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Height = 520;
            this.Width = 805;
        }
    }
}
