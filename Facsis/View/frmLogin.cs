using System;
using System.Data;
using System.Windows.Forms;
using Facsis.Controller.Util;
using Facsis.Model.DTO;
using Facsis.Model.DAL;

namespace Facsis.View
{
    public partial class frmLogin : Form
    {
        LoginBLL bll = new LoginBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Mensagens.fechaAplicao();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //usuario.DataSource = bll.selecionaUsuarioId(Convert.ToInt32(txtConsulta.Text));
            string login = txtLogin.Text.Trim();

            DataTable dt = bll.selecionaDadosUsuario(login.ToLower(), txtSenha.Text);

            if (dt != null && dt.Rows.Count > 0)
            {
                LoginDTO.Id = int.Parse(dt.Rows[0]["id_usuario"].ToString());
                LoginDTO.Nome = dt.Rows[0]["nome"].ToString();
                LoginDTO.Nivel = dt.Rows[0]["nivel"].ToString();
                LoginDTO.Login = dt.Rows[0]["login_usuario"].ToString();

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                this.lblMsg.Visible = true;
        }
    }
}
