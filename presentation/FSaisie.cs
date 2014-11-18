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
            //YOLo
        }


    }
}
