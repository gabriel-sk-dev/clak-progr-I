using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgComTelas
{
    public partial class frmRpg : Form
    {
        public frmRpg()
        {
            InitializeComponent();
        }        

        private void frmRpg_Load(object sender, EventArgs e)
        {
            frmPrincipal janela = new frmPrincipal();
            janela.Show();
        }
    }
}
