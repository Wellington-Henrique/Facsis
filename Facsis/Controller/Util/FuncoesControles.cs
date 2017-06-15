using System;
using System.Windows.Forms;

namespace Facsis.Controller.Util
{
    class FuncoesControles
    {
        public static bool verificaVazio(Control x)
        {
            foreach (Control item in x.Controls)
            {
                if (item is TextBox && item.Text == String.Empty && item.Enabled == true || item is ComboBox && item.Text == String.Empty && item.Enabled == true)
                {
                    return true;
                }
            }
            return false;
        }

        public static void limpaCampos(Control x)
        {
            foreach (Control item in x.Controls)
            {
                if (item is TextBox || item is ComboBox || item is MaskedTextBox && item.Enabled == true)
                {
                    item.Text = "";
                }
            }
        }
    }
}
