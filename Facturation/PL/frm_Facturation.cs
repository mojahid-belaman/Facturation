using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Facturation.PL
{
    public partial class frm_Facturation : Form
    {
        SqlConnection ocon = new SqlConnection("Server = ADMINRG-20JDAQU; Database = Facturation; Integrated Security = true");

        double sold, montant;

        BL.CLS_FACTURE fac = new BL.CLS_FACTURE();
        DataTable dt = new DataTable();

        void CreateDataTable()
        {
            dt.Columns.Add("Numéro Article");
            dt.Columns.Add("Désignation");
            dt.Columns.Add("Prix Unitaire");
            dt.Columns.Add("Quantité Vendu");
            dt.Columns.Add("Montant");

            dgv.DataSource = dt;
        }

        void CalculMontant()
        {
            if (txtPrix.Text != string.Empty && txtQV.Text != string.Empty)
            {
                double montant = Convert.ToDouble(txtPrix.Text) * Convert.ToInt32(txtQV.Text);
                
            }

        }
        void ClearData()
        {
            txtNumArt.Clear();
            txtDesign.Clear();
            txtPrix.Clear();
            txtQS.Clear();
            txtQV.Clear();
        }

        void ClearTout()
        {
            txtVendu.Clear();
            dtp.ResetText();
            txtNumArt.Clear();
            txtDesign.Clear();
            txtPrix.Clear();
            txtQS.Clear();
            txtQV.Clear();
            txtNumCl.Clear();
            txtNom.Clear();
            txtSolde.Clear();
            txtTotal.Clear();
            txtMontantRest.Clear();
            dt.Clear();
            dgv.DataSource = null;
        }
        public frm_Facturation()
        {
            InitializeComponent();
            CreateDataTable();
            txtVendu.Text = fac.LAST_FACTURE().Rows[0][0].ToString();
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            Add_Client frm = new Add_Client();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                All_Client frm = new All_Client();
                frm.ShowDialog();
                txtNumCl.Text = frm.dgvAllClient.CurrentRow.Cells[0].Value.ToString();
                txtNom.Text = frm.dgvAllClient.CurrentRow.Cells[1].Value.ToString();
                txtSolde.Text = frm.dgvAllClient.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                All_Article frm = new All_Article();
                frm.ShowDialog();
                txtNumArt.Text = frm.dgvArticle.CurrentRow.Cells[0].Value.ToString();
                txtDesign.Text = frm.dgvArticle.CurrentRow.Cells[1].Value.ToString();
                txtPrix.Text = frm.dgvArticle.CurrentRow.Cells[2].Value.ToString();
                txtQS.Text = frm.dgvArticle.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAtc_Click(object sender, EventArgs e)
        {
            Add_Article frm = new Add_Article();
            frm.ShowDialog();
        }

        private void txtQV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
            

            try
            {

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() == txtNumArt.Text)
                    {
                        MessageBox.Show("Cet Produit Existe Déjà", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearData();
                        return;
                    }
                }
                if (fac.VERIFY_QUTESTOCK(txtNumArt.Text, Convert.ToInt32(txtQV.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("Quantité entré pour ce produit ne sont pas disponibles", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQV.Focus();
                    return;

                }

                DataRow r = dt.NewRow();

                r[0] = txtNumArt.Text;
                r[1] = txtDesign.Text;
                r[2] = txtPrix.Text;
                r[3] = txtQV.Text;
                r[4] = Convert.ToDouble(txtPrix.Text) * Convert.ToInt32(txtQV.Text);

                dt.Rows.Add(r);
                dgv.DataSource = dt;
                ClearData();

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
                }
                txtTotal.Text = sum.ToString();


                sold = double.Parse(txtSolde.Text);
                montant = double.Parse(txtTotal.Text);

                if (sold >= montant)
                {
                    double calcu = sold - montant;
                    txtMontantRest.Text = calcu.ToString();
                }
                else
                {
                    MessageBox.Show("Solde Insuffisant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                sold = double.Parse(txtSolde.Text);
                montant = double.Parse(txtTotal.Text);

                if (sold >= montant)
                {
                    double calcu = sold - montant;
                    txtMontantRest.Text = calcu.ToString();
                }
                else
                {
                    MessageBox.Show("Solde Insuffisant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double sum = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
            }
            txtTotal.Text = sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocon.Open();
            SqlCommand cmd = new SqlCommand("LAST_FACTURE_PRINT", ocon);
            cmd.CommandType = CommandType.StoredProcedure;
            int num_fac = Convert.ToInt32(cmd.ExecuteScalar());
            ocon.Close();
            RPT.rpt_facture myreport = new RPT.rpt_facture();
            RPT.Print frm = new RPT.Print();
            myreport.SetParameterValue("@NO_FACTURE", num_fac);
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtNumArt.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtDesign.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtPrix.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtQV.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            dgv.Rows.RemoveAt(dgv.CurrentRow.Index);

            sold = double.Parse(txtSolde.Text);
            montant = double.Parse(txtTotal.Text);

            if (sold >= montant)
            {
                double calcu = sold - montant;
                txtMontantRest.Text = calcu.ToString();
            }
            else
            {
                MessageBox.Show("Solde Insuffisant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
            }
            txtVendu.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumArt.Text == string.Empty && txtNumCl.Text == string.Empty && dgv.Rows.Count < 1)
                {
                    MessageBox.Show("Saisir Tous les données SVP !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fac.ADD_FACTURE(Convert.ToInt32(txtVendu.Text), dtp.Value, Convert.ToDecimal(txtTotal.Text), Convert.ToDecimal(txtMontantRest.Text), Convert.ToInt32(txtNumCl.Text));

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    fac.ADD_CONTIENT(dgv.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(txtVendu.Text), Convert.ToInt32(dgv.Rows[i].Cells[3].Value));
                }
                MessageBox.Show("Added Successfuly !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTout();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
