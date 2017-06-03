using System.Windows.Forms;

namespace Facsis.Controller.Util
{
    class DataGridFuncoes
    {
        public static void cabecalhoTabUsuario(DataGridView x)
        {
            x.Columns[0].HeaderText = "Código";
            x.Columns[1].HeaderText = "Nome";
            x.Columns[2].HeaderText = "Nível";
        }
    }
}
