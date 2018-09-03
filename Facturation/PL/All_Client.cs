using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation.PL
{
    public partial class All_Client : Form
    {
        BL.CLS_FACTURE fac = new BL.CLS_FACTURE();
        public All_Client()
        {
            InitializeComponent();
            dgvAllClient.DataSource = fac.ALL_CLIENT();
        }

        private void dgvAllClient_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
