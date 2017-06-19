using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facsis.Model.BLL;
using Facsis.Model.DTO;

namespace Facsis.View
{
    public partial class frmConVenda : Form
    {
        VendaBLL bll = new VendaBLL();
        string[] vtVenda = new string[8];
        PessoaBLL bllCli = new PessoaBLL();
        ProdutoBLL bllProd = new ProdutoBLL();
        DataTable dt;
        DataTable dtCarrinho = new DataTable();

        int indice = 0;

        public frmConVenda()
        {
            InitializeComponent();
        }

        public frmConVenda(string[] vtVenda)
        {
            InitializeComponent();

            this.vtVenda = vtVenda;
        }

        private void frmConVenda_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = bll.selecionaVenda("Pendente");
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string cliente = bllCli.selecionaPessoaNome(dt.Rows[i]["id_pessoa"].ToString(), "CLIENTE");
                dgvConsulta.Rows.Add(dt.Rows[i]["id_venda"].ToString(),
                                     dt.Rows[i]["id_pessoa"].ToString(), cliente,
                                     Convert.ToDateTime(dt.Rows[i]["data_pedido"].ToString()).ToShortDateString(),
                                     dt.Rows[i]["valor_total"].ToString());
            }
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCarrinho.Rows.Clear();

            dtCarrinho = bll.selecionaItensVendaPendente(dgvConsulta.Rows[e.RowIndex].Cells[0].Value.ToString());

            for (int i = 0; i < dtCarrinho.Rows.Count; i++)
            {
                dgvCarrinho.Rows.Add(dtCarrinho.Rows[i][9].ToString(),
                                     dtCarrinho.Rows[i][10].ToString(),
                                     dtCarrinho.Rows[i][11].ToString(),
                                     dtCarrinho.Rows[i][12].ToString(),
                                     dtCarrinho.Rows[i][13].ToString(),
                                     dtCarrinho.Rows[i][14].ToString());

            }

            btnAbrir.Enabled = true;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            vtVenda[0] = dtCarrinho.Rows[indice][0].ToString(); // Código venda
            vtVenda[1] = dtCarrinho.Rows[indice][1].ToString(); // Código usuário
            vtVenda[2] = dtCarrinho.Rows[indice][2].ToString(); // Código cliente
            vtVenda[3] = dtCarrinho.Rows[indice][3].ToString(); // Nome cliente
            vtVenda[4] = dtCarrinho.Rows[indice][4].ToString(); // Data nota
            vtVenda[5] = dtCarrinho.Rows[indice][5].ToString(); // Data pedido
            vtVenda[6] = dtCarrinho.Rows[indice][6].ToString(); // Status
            vtVenda[7] = dtCarrinho.Rows[indice][7].ToString(); // Forma pgto

            VendaDTO.Dt = dtCarrinho;

            //btnAbrir.Enabled = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
