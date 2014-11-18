using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using metier;

namespace presentation
{
    public partial class FSaisie : Form
    {
        private Projet projet;
        public FSaisie(Projet projet, Donnees donnees)
        {
            InitializeComponent();
            this.projet = projet;
            tb_cv.Hide();
            tb_cf.Hide();
            tb_ca.Hide();
            tb_tx.Hide();
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {

        }


        //Methode permettant de contrôler la saisie de l'utilisateur
        private void generalKeyPress(object sender, KeyPressEventArgs e)
        {
            // si ce n'est pas une touche numérique qui est appuyée, on annule
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46) || (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void check_ca(object sender, EventArgs e)
        {
            if (chkB_ca.Checked == true)
            {
                tb_ca.Show();
            }
            else
            {
                tb_ca.Hide();
            }
        }

        private void check_cv(object sender, EventArgs e)
        {
            if (chkB_cv.Checked == true)
            {
                tb_cv.Show();
            }
            else
            {
                tb_cv.Hide();
            }
        }

        private void check_cf(object sender, EventArgs e)
        {
            if (chkB_cf.Checked == true)
            {
                tb_cf.Show();
            }
            else
            {
                tb_cf.Hide();
            }
        }

        private void check_tx(object sender, EventArgs e)
        {
            if (chkB_tx.Checked == true)
            {
                tb_tx.Show();
            }
            else
            {
                tb_tx.Hide();
            }
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            tb_annees.Text = "";
            tb_ca.Text = "";
            tb_cf.Text = "";
            tb_cv.Text = "";
            tb_investissementM.Text = "";
            tb_investissementP.Text = "";
            tb_tx.Text = "";
            tb_valeurResiduelle.Text = "";
            chkB_cv.Checked = false;
            chkB_ca.Checked = false;
            chkB_cf.Checked = false;
            chkB_tx.Checked = false;
        }
    }
}
