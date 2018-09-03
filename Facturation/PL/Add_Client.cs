using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Facturation.PL
{
    public partial class Add_Client : Form
    {
        BL.CLS_FACTURE fac = new BL.CLS_FACTURE();
        public Add_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text == string.Empty && txtadresse.Text == string.Empty && txtville.Text == string.Empty && txtsolde.Text == string.Empty && txtCodeCl.Text == string.Empty)
                {
                    MessageBox.Show("Saisir Tout Les Champs de Client SVP !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                fac.ADD_CLIENT(Convert.ToInt32(txtCodeCl.Text), txtnom.Text, txtadresse.Text, txtville.Text, Convert.ToDecimal(txtsolde.Text));
                MessageBox.Show("Added Successfuly !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Add_Client_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodeCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtsolde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtCodeCl_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = fac.VERIFIER_ID_CLIENT(Convert.ToInt32(txtCodeCl.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Cet identifiant existe déjà", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodeCl.Focus();
                txtCodeCl.SelectionStart = 0;
                txtCodeCl.SelectionLength = txtCodeCl.TextLength;

            }
        }
    }
}
