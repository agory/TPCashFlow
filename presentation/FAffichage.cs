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
    public partial class FAffichage : Form
    {
        private Donnees donnees;

        public FAffichage(Donnees donnees)
        {
            InitializeComponent();
            this.donnees = donnees;
            Load();
        }

        public void Load()
        {
            List<String> nomsHeaderCell = new List<String>();
            nomsHeaderCell.Add("C.A");
            nomsHeaderCell.Add("C.V");
            nomsHeaderCell.Add("C.F");
            nomsHeaderCell.Add("Ammortissement");
            nomsHeaderCell.Add("Charges annuelles");
            nomsHeaderCell.Add("Chiffres d'affaires avant IS");
            nomsHeaderCell.Add("Montant IS");
            nomsHeaderCell.Add("");
            nomsHeaderCell.Add("Valeur résiduelle");
            nomsHeaderCell.Add("Cash Flow");
            CreerDgv(nomsHeaderCell);
        }

        /// <summary>
        /// Procédure permettant de créer un DataGridView
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="name"></param>
        /// <param name="nom"></param>
        /// <param name="text"></param>
        public void CreerDgv(List<String> name)
        {
            //Commenter le code, ajouter les try/catch
            try
            {
                donnees.Annee = 6;
                dgv.RowHeadersWidth += 160;
                dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgv.RowCount = name.Count; ;
                dgv.ColumnCount = donnees.Annee;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    dgv.Rows[i].HeaderCell.Value = name[i];
                }

                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].HeaderCell.Value = "Année " + (i+1);
                }
                RemplirDgv();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void RemplirDgv()
        {
            Double mtRembourse = 0;

            //Boucle permettant de parcourir les lignes du tableau
            for (int i = 0; i < dgv.RowCount; i++)
            {
                //Boucle permettant de remplir les cellule d'une ligne du tableau
                for (int j = 0; j < dgv.ColumnCount; j++){
                    //switch(j)
                    //{
                    //    //Cellule correspondant à l'amortissement
                    //    case 0:
                    //        dgv.Rows[i].Cells[j].Value = this.donnees.amortissement(nom, j, mtRembourse).ToString("00.00");
                    //        break;
                    //    //Cellule correspondant à l'intérêt
                    //    case 1:
                    //        dgv.Rows[i].Cells[j].Value = this.unEmprunt.interet(j, nom, mtRembourse).ToString("00.00");
                    //        break;
                    //    //Cellule correspondant à l'annuité
                    //    case 2:
                    //        dgv.Rows[i].Cells[j].Value = this.unEmprunt.montantEcheance(nom).ToString("00.00");
                    //        break;
                    //    //Cellule correspondant au capital restant à payer
                    //    case 3:
                    //        Double value = this.unEmprunt.Capital - mtRembourse;
                    //        dgv.Rows[i].Cells[j].Value = value.ToString("00.00");
                    //        mtRembourse += this.unEmprunt.amortissement(nom, j, mtRembourse);
                    //        break;
                    //    default:
                    //        break;
                    //
                    }
            }
        }

    }
}
