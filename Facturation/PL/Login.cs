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

namespace Facturation.PL
{
    public partial class Login : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();

        int nbTentative = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            int i = log.SP_LOGING(txtID.Text, txtPSW.Text);

            if (nbTentative > 3)
            {
                this.Close();
            }
            else if (i == 0)
            {
                this.Hide();
                frm_Facturation frm = new frm_Facturation();
                frm.ShowDialog();
                nbTentative = 0;

            }
            else if (i == 1)
            {
                MessageBox.Show("le compte utilisateur n'existe pas", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nbTentative++;
                lblError.Text =  "Compte de Utilisateur au delà de " + (4 - nbTentative) + " essais !!";                
            }
            else if (i == 2)
            {
                MessageBox.Show("le compte est bloqué (statut = 0)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nbTentative++;
                lblError.Text = "Compte de Utilisateur au delà de " + (4 - nbTentative) + " essais !!";
            }
            else if (i == 3)
            {
                MessageBox.Show("le mot de passe fourni n'est pas correcte", " Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nbTentative++;
                lblError.Text = "Compte de Utilisateur au delà de " + (4 - nbTentative) + " essais !!";
            }
            else
            {
                MessageBox.Show("mot de passe et utilisateur incorrect !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nbTentative++;
                lblError.Text = "Compte de Utilisateur au delà de " + (4 - nbTentative) + " essais !!";
            }

            //if (txtID.Text == string.Empty && txtPSW.Text == string.Empty)
            //{
            //    MessageBox.Show("Saisir Nom d'utilisateur et Mot de Passe", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else if (txtID.Text != string.Empty && txtPSW.Text == string.Empty)
            //{
            //    MessageBox.Show("Saisir Mot de Passe", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else if (txtID.Text == string.Empty && txtPSW.Text != string.Empty)
            //{
            //    MessageBox.Show("Saisir Nom d'utilisateur", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else
            //{
            //    MessageBox.Show("Nom Utilisateur et Mot de Passe Incorrecte !!");
            //}

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPSW.UseSystemPasswordChar = true;
                labelpwd.Text = "Cacher Password";
            }
            else
            {
                txtPSW.UseSystemPasswordChar = false;
                labelpwd.Text = "Afficher Password";
            }
        }
    }
}
