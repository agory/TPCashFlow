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
        public FAccueil()
        {
            InitializeComponent();
            projet = new Projet();
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSaisie fs = new FSaisie(projet);
            fs.ShowDialog();
        }
    }
}
