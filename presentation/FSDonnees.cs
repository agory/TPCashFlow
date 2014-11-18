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
    public partial class FSDonnees : Form
    {
        private Donnees donnees;
        public FSDonnees(Donnees d)
        {
            InitializeComponent();
            donnees = d;
            lab_title.Text += donnees.Annee;
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            if (tb_ca.Text != "" && tb_tx.Text != "" && tb_cv.Text != "" && tb_cf.Text != "") 
            {
                try
                {
                    double ca = Convert.ToDouble(virgule(tb_ca.Text));
                    double tx = Convert.ToDouble(virgule(tb_tx.Text));
                    double cv = Convert.ToDouble(virgule(tb_cv.Text));
                    double cf = Convert.ToDouble(virgule(tb_cf.Text));
                    donnees.InitData(ca, tx, cv, cf);
                }
                catch (Exception)
                {
                    lab_err.Text = "Erreur de saisie";
                }
                
            }
        }

        private void tb_interdictionSaisie(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
                   (e.KeyChar == (char)46) || (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private string virgule(string nombre)
        {
            string modif = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] == '.')
                {
                    modif += ',';
                }
                else
                {
                    modif += nombre[i];
                }
            }
            return modif;
        }

        private void tb_ca_TextChanged(object sender, EventArgs e)
        {
            if (tb_ca.Text != "")
            {
                double temp;
                try
                {
                    temp = Convert.ToDouble(virgule(tb_ca.Text));
                    tb_ca.Text = temp.ToString("0.00");
                    tb_ca.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_ca.ForeColor = Color.Red;
                }
            }
        }

        private void tb_tx_TextChanged(object sender, EventArgs e)
        {
            if (tb_tx.Text != "")
            {
                double temp;
                try
                {
                    temp = Convert.ToDouble(virgule(tb_tx.Text));
                    tb_tx.Text = temp.ToString("0.00");
                    tb_tx.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_tx.ForeColor = Color.Red;
                }
            }
        }

        private void tb_cf_TextChanged(object sender, EventArgs e)
        {
            if (tb_cf.Text != "")
            {
                double temp;
                try
                {
                    temp = Convert.ToDouble(virgule(tb_cf.Text));
                    tb_cf.Text = temp.ToString("0.00");
                    tb_cf.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_cf.ForeColor = Color.Red;
                }
            }
        }

        private void tb_cv_TextChanged(object sender, EventArgs e)
        {
            if (tb_cv.Text != "")
            {
                double temp;
                try
                {
                    temp = Convert.ToDouble(virgule(tb_cv.Text));
                    tb_cv.Text = temp.ToString("0.00");
                    tb_cv.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_cv.ForeColor = Color.Red;
                }
            }
        }
    }
}
