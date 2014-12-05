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
        public FSaisie(Projet projet)
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
            if (tb_investissementM.Text != "" && tb_investissementP.Text != ""
                && tb_annees.Text != "" && tb_valeurResiduelle.Text != "")
            {

                try
                {
                    double investissementM = Convert.ToDouble(virgule(tb_investissementM.Text));
                    double investissementP = Convert.ToDouble(virgule(tb_investissementP.Text));
                    int annees = Convert.ToInt16(virgule(tb_annees.Text));
                    double valeurResiduel = Convert.ToDouble(virgule(tb_valeurResiduelle.Text));
   
                    List<Donnees> listDonnees = new List<Donnees>();
                    Donnees donnees = new Donnees();


                    bool testSaisie = true;
                    if (tb_ca.Text != "" && chkB_ca.Checked == true)
                    {
                        donnees.Ca = Convert.ToDouble(virgule(tb_ca.Text));
                    }
                    else
                        testSaisie = false;
                    if (tb_cf.Text != "" && chkB_cf.Checked == true)
                    {
                        donnees.Cf = Convert.ToDouble(virgule(tb_cf.Text));
                    }
                    else
                        testSaisie = false;
                    if (tb_tx.Text != "" && chkB_tx.Checked == true)
                    {
                        donnees.Tx = Convert.ToDouble(virgule(tb_tx.Text));
                    }
                    else
                        testSaisie = false;
                    if (tb_cv.Text != "" && chkB_cv.Checked == true)
                    {
                        donnees.Cv = Convert.ToDouble(virgule(tb_cv.Text));
                    }
                    else
                        testSaisie = false;

                    if (testSaisie)
                    {
                        for (int i = 1; i <= annees; i++)
                        {
                            donnees.Annee = i;
                            listDonnees.Add(donnees);
                        }
                        
                    }
                    else
                    {
                        donnees.Annee = annees;
                        FSDonnees Fsd = new FSDonnees(donnees, listDonnees);
                        Fsd.Show();
                    }
                    projet.Init(investissementP, investissementM, valeurResiduel, listDonnees);
                    Close();


                }
                catch (Exception err)
                {
                    lab_err.Text = err.Message;
                }

            }
            else
                lab_err.Text = "Des information n'ont pas été saisie";
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

        private void checkAll(object sender, EventArgs e)
        {
            if (chkB_cv.Checked == true && chkB_ca.Checked == true && chkB_cf.Checked == true && chkB_tx.Checked == true)
            {
                bt_valider.Text = "Valider";
            }
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

        private void tb_investissementP_Validated(object sender, EventArgs e)
        {
            double temp;
            try
            {
                temp = Convert.ToDouble(virgule(tb_investissementP.Text));
                tb_investissementP.Text = temp.ToString("0.00");
                tb_investissementP.ForeColor = Color.Black;

            }
            catch (Exception)
            {
                tb_investissementP.ForeColor = Color.Red;
            }
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

        private void tb_investissementM_Validated(object sender, EventArgs e)
        {
            if (tb_investissementM.Text != "")
            {
                double temp;
                try
                {
                    temp = Convert.ToDouble(virgule(tb_investissementM.Text));
                    tb_investissementM.Text = temp.ToString("0.00");
                    tb_investissementM.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_investissementM.ForeColor = Color.Red;
                }
            }
        }

        private void tb_annees_Validated(object sender, EventArgs e)
        {
            if (tb_annees.Text != "")
            {
                int temp;
                try
                {
                    temp = Convert.ToInt16(virgule(tb_annees.Text));
                    tb_annees.Text = temp.ToString();
                    tb_annees.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_annees.ForeColor = Color.Red;
                }
            }
        }

        private void tb_valeurResiduelle_Validated(object sender, EventArgs e)
        {
            if (tb_valeurResiduelle.Text != "")
            {
                double temp;
                try
                {
                    temp = Convert.ToDouble(virgule(tb_valeurResiduelle.Text));
                    tb_valeurResiduelle.Text = temp.ToString("0.00");
                    tb_valeurResiduelle.ForeColor = Color.Black;

                }
                catch (Exception)
                {
                    tb_valeurResiduelle.ForeColor = Color.Red;
                }
            }
        }
    }
}
