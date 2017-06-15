using System;
using System.Windows.Forms;
using Facsis.Controller.Util;
using Facsis.Model.DTO;
using Facsis.Model.BLL;
using System.Data;

namespace Facsis.View
{
    public partial class frmCadUsuario : Form
    {
        UsuarioBLL bll = new UsuarioBLL();        
        UsuarioDTO dto = new UsuarioDTO();
        int indice = 0;

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            dto.Nome = txtNome.Text.Trim().ToUpper();
            dto.Email = txtEmail.Text.Trim();
            dto.Telefone = txtTelefone.Text.Trim();
            dto.Nivel = cbNivel.Text.Trim();
            dto.Login = txtLogin.Text.Trim();
            dto.Senha = txtSenha.Text.Trim();

            if (txtId.Text == "")
            {
                bll.Inserir(dto);
                //CarregarGrid();
            }
            else
            {
                dgvConsulta.Refresh();
                dto.Id = int.Parse(txtId.Text);
                bll.Atualizar(dto);
                btnCadastrar.Text = "Cadastrar";
            }

            FuncoesControles.limpaCampos(pnlUsuario);
            dgvConsulta.Rows.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dgvConsulta.Refresh();
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
            btnCadastrar.Text = "Cadastrar";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {            
            CarregarGrid();
        }

        private void dgvConsulta_Click(object sender, DataGridViewCellEventArgs e)
        {         
            visualizarDadosUsuario(e.RowIndex);
        }

        private void CarregarGrid()
        {
            int id;
            dgvConsulta.Rows.Clear();
            
            if(txtId.Text != "")
                btnCadastrar.Text = "Atualizar";

            if (Int32.TryParse(txtConsulta.Text, out id))
            {
                dgvConsulta.DataSource = bll.selecionaUsuario(Convert.ToInt32(txtConsulta.Text));
            }
            else
            {
                string nome = txtConsulta.Text;
                DataTable dt = bll.selecionaUsuario(nome.ToUpper());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvConsulta.Rows.Add(dt.Rows[i]["id_usuario"].ToString(), dt.Rows[i]["nome"].ToString(), dt.Rows[i]["email"].ToString(),
                                         dt.Rows[i]["telefone"].ToString(), dt.Rows[i]["nivel"].ToString(), dt.Rows[i]["login_usuario"].ToString(),
                                         dt.Rows[i]["senha"].ToString());
                }
            }            
        }      

        private void restaurarTamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Height = 520;
            this.Width = 805;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0 && dgvConsulta.Rows.Count > 0)
            {
                indice--;
                visualizarDadosUsuario(indice);
            }
        }

        private void visualizarDadosUsuario(int indice)
        {
            txtId.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[0].Value);
            txtNome.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[1].Value);
            txtEmail.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[2].Value);
            txtTelefone.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[3].Value);
            cbNivel.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[4].Value);
            txtLogin.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[5].Value);
            txtSenha.Text = Convert.ToString(dgvConsulta.Rows[indice].Cells[6].Value);
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Atualizar";
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (indice < dgvConsulta.Rows.Count - 2 && dgvConsulta.Rows.Count > 0)
            {
                indice++;
                visualizarDadosUsuario(indice);
            }
        }
    }
}
