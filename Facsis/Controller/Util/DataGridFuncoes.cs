using System.Windows.Forms;

namespace Facsis.Controller.Util
{
    class DataGridFuncoes
    {
        public static void cabecalhoTabUsuario(DataGridView x)
        {
            if (x.DataSource != null)
            {
                x.Columns[0].HeaderText = "Código";
                x.Columns[1].HeaderText = "Nome";
                x.Columns[2].HeaderText = "Email";
                x.Columns[3].HeaderText = "Telefone";
                x.Columns[4].HeaderText = "Nível";
                //x.Columns[5].HeaderText = "Login";
                //x.Columns[6].HeaderText = "Senha";
            }
        }
    }
}
