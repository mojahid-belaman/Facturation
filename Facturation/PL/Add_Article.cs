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
    public partial class Add_Article : Form
    {
        BL.CLS_FACTURE fac = new BL.CLS_FACTURE();
        public Add_Article()
        {
            InitializeComponent();
        }

        private void txtPu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator); 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtQs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAjou_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesign.Text != string.Empty && txtPu.Text != string.Empty && txtQs.Text != string.Empty)
                {
                    fac.ADD_ARTICLE(txtRef.Text, txtDesign.Text, Convert.ToDecimal(txtPu.Text), Convert.ToInt32(txtQs.Text));
                    MessageBox.Show("Added Successfuly !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = fac.VERIFIER_ID(txtRef.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Cet identifiant existe déjà", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRef.Focus();
                txtRef.SelectionStart = 0;
                txtRef.SelectionLength = txtRef.TextLength;

            }
        }
    }
}
