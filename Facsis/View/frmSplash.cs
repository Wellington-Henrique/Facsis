using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facsis.View
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (barraProgresso.Value < 100)
                barraProgresso.Value += 10;
            else
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
