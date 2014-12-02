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
        private List<Donnees> listDonnees;
        
        private int annees;
        public FSDonnees(Donnees d, List<Donnees> l)
        {
            InitializeComponent();
            donnees = d;
            listDonnees = l;
            annees = 1;
            initialiseTb();
            
        }

        private void initialiseTb()
        {
            lab_title.Text = "Saisie informations année : " + annees;
            if (donnees.Ca > 0) { 
                tb_ca.Text = donnees.Ca.ToString("0.00");
                tb_ca.Enabled = false;
            }
            else {
                tb_ca.Text = "";
                tb_ca.Enabled = true;
            }

            if (donnees.Cf > 0)
            {
                tb_cf.Text = donnees.Cf.ToString("0.00");
                tb_cf.Enabled = false;
            }
            else
            {
                tb_cf.Text = "";
                tb_cf.Enabled = true;
            }

            if (donnees.Tx > 0)
            {
                tb_tx.Text = donnees.Tx.ToString("0.00");
                tb_tx.Enabled = false;
            }
            else
            {
                tb_tx.Text = "";
                tb_tx.Enabled = true;
            } 
            
            if (donnees.Cv > 0)
            {
                tb_cv.Text = donnees.Cv.ToString("0.00");
                tb_cv.Enabled = false;
            }
            else
            {
                tb_cv.Text = "";
                tb_cv.Enabled = true;
            }
        }
        private void bt_valider_Click(object sender, EventArgs e)
        {
            Donnees uneDonnees = new Donnees(annees);
            if (tb_ca.Text != "" && tb_tx.Text != "" && tb_cv.Text != "" && tb_cf.Text != "")
            {
                try
                {
                    double ca = Convert.ToDouble(virgule(tb_ca.Text));
                    double tx = Convert.ToDouble(virgule(tb_tx.Text))/100.0;
                    double cv = Convert.ToDouble(virgule(tb_cv.Text));
                    double cf = Convert.ToDouble(virgule(tb_cf.Text));
                    uneDonnees.InitData(ca, tx, cv, cf);
                    annees++;
                    listDonnees.Add(uneDonnees);
                    if (annees <= donnees.Annee)
                    {
                        initialiseTb();
                    }
                    else
                        Close();
                }
                catch (Exception)
                {
                    lab_err.Text = "Erreur de saisie";
                }

            }
            else
            {
                lab_err.Text = "Des éléments n'ont pas été saisie";
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

        private void tb_ca_Validated(object sender, EventArgs e)
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

        private void tb_cv_Validated(object sender, EventArgs e)
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

        private void tb_cf_Validated(object sender, EventArgs e)
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

        private void tb_tx_Validated(object sender, EventArgs e)
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


    }
}
