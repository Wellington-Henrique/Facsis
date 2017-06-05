using System.Windows.Forms;
using System.Data;
using System;

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

        //public static DataGridView carregaDV(DataTable dt , ToolStripProgressBar barraProgresso )
        //{
        //    barraProgresso.Visible = true;
        //    int qtdColuna = dt.Columns.Count;
        //    int qtdLinha = dt.Rows.Count;

        //    DataGridView x = new DataGridView();            

        //    for (int i = 0; i <= qtdLinha; i++)
        //    {
        //        //for (int k = 0; k < qtdColuna; k++)
        //        //{
        //            x.Rows.Add(1, 2, 3, 4, 5, 6, 7);

        //            //dt.Rows[i][k].ToString();
        //        //}

        //        barraProgresso.Value = i + 1 / qtdColuna * 100;
        //    }

        //    barraProgresso.Visible = false;
        //    return x;
        //}
    }
}
