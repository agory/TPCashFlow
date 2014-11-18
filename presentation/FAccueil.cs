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
    public partial class FAccueil : Form
    {
        private Projet projet;
        private Donnees donnees;

        public FAccueil()
        {
            InitializeComponent();
            projet = new Projet();
            donnees = new Donnees();
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSaisie fs = new FSaisie(projet, donnees);
            fs.ShowDialog();
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAffichage affichage = new FAffichage(donnees);
            affichage.ShowDialog();
        }
    }
}
