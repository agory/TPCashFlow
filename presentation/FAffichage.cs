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
        private Projet projet;

        public FAffichage(Projet projet)
        {
            InitializeComponent();
            this.projet = projet;
            Load();
            LoadActualise();
        }

        public void LoadActualise()
        {
            List<String> nomsHeaderCell = new List<String>();
            dgv_actualise.RowCount =projet.Donnees.Count;

            for(int i=0;i<dgv_actualise.RowCount;i++)
            {
                nomsHeaderCell.Add("Année "+i);
            }

            List<String> columnsHeaderCell = new List<String>();
            columnsHeaderCell.Add("Origine");
            columnsHeaderCell.Add("Taux d'actualisation");
            columnsHeaderCell.Add("Actualisé");
            columnsHeaderCell.Add("");
            columnsHeaderCell.Add("VAN");
            CreerDgv(nomsHeaderCell, columnsHeaderCell);
        }

        public void Load()
        {
            List<String> nomsHeaderCell = new List<String>();
            
            dgv_actualise.RowCount =projet.Donnees.Count;

            for(int i=0;i<dgv_actualise.RowCount;i++)
            {
                nomsHeaderCell.Add("Année "+i);
            }
           
            List<String> columnsHeaderCell = new List<String>();
            columnsHeaderCell.Add("C.A");
            columnsHeaderCell.Add("C.V");
            columnsHeaderCell.Add("C.F");
            columnsHeaderCell.Add("Ammortissement");
            columnsHeaderCell.Add("Charges annuelles");
            columnsHeaderCell.Add("Chiffres d'affaires avant IS");
            columnsHeaderCell.Add("Montant IS");
            columnsHeaderCell.Add("");
            columnsHeaderCell.Add("Valeur résiduelle");
            columnsHeaderCell.Add("Cash Flow");

            CreerDgv(nomsHeaderCell, columnsHeaderCell);
        }

        /// <summary>
        /// Procédure permettant de créer un DataGridView
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="name"></param>
        /// <param name="nom"></param>
        /// <param name="text"></param>
        public void CreerDgv(List<String> name, List<String>column)
        {
            //Commenter le code, ajouter les try/catch
            try
            {
                if (name.Count == 5)
                {
                    dgv_actualise.RowHeadersWidth += 160;
                    dgv_actualise.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    dgv_actualise.RowCount = name.Count; ;
                    dgv_actualise.ColumnCount = projet.Donnees.Count;

                    for (int i = 0; i < dgv_actualise.RowCount; i++)
                    {
                        dgv_actualise.Rows[i].HeaderCell.Value = name[i];
                    }

                    for (int i = 0; i < dgv_actualise.ColumnCount; i++)
                    {
                        dgv_actualise.Columns[i].HeaderCell.Value =column [i];
                    }
                    RemplirDgvActualise(dgv_actualise);
                }
                else
                {
                    dgv.RowHeadersWidth += 160;
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    dgv.RowCount = name.Count; ;
                    dgv.ColumnCount = projet.Donnees.Count;

                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        dgv.Rows[i].HeaderCell.Value = name[i];
                    }

                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        dgv.Columns[i].HeaderCell.Value = column[i];
                    }
                    RemplirDgv(dgv);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void RemplirDgv(DataGridView dgv)
        {
            List<Donnees> donnees = new List<Donnees>();
            foreach(Donnees donnee in projet.Donnees){
                donnees.Add(donnee);
            }

            //Boucle permettant de parcourir les lignes du tableau
            for (int i = 0; i < dgv.RowCount; i++)
            {
                //Mettre en place un dictionnnaire à fin d'éviter les répétitions de variables et/ou de calculs etc...
                //Boucle permettant de remplir les cellule d'une ligne du tableau
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    switch (j)
                    {
                        //Cellule correspondant au ca
                        case 0:
                            dgv.Rows[i].Cells[j].Value = donnees[i].Ca.ToString("00.00");
                            break;
                        //Cellule correspondant au cv
                        case 1:
                            dgv.Rows[i].Cells[j].Value = donnees[i].Cv.ToString("00.00");
                            break;
                        //Cellule correspondant au cf
                        case 2:
                            dgv.Rows[i].Cells[j].Value = donnees[i].Cf.ToString("00.00");
                            break;
                        ////Cellule correspondant à l'amortissement
                        //case 3:
                        //    dgv.Rows[i].Cells[j].Value = donnees[i].Cf.ToString("00.00");
                            break;
                        //Cellule correspondant au charges annuelles
                        case 4:
                            Double chargesAnnuelles = donnees[i].Cf + donnees[i].Cv;
                            dgv.Rows[i].Cells[j].Value = chargesAnnuelles.ToString("00.00");
                            break;

                        //Cellule correspondant au chiffre d'affaires avant IS
                        case 5:
                            Double CAavtIS = donnees[i].Ca - (donnees[i].Cv + donnees[i].Cf);
                            dgv.Rows[i].Cells[j].Value = CAavtIS.ToString("00.00");
                            break;
                        //Cellule correspondant au montant IS
                        case 6:
                            Double mtIS = donnees[i].Ca - (donnees[i].Cv + donnees[i].Cf) * (1 / 3);
                            dgv.Rows[i].Cells[j].Value = donnees[i].Cf.ToString("00.00");
                            break;
                        //Cellule vide
                        case 7:
                            break;
                        //Cellule correspondant à la valeur résiduelle
                        case 8:
                            if (i == projet.Donnees.Count)
                            {
                                dgv.Rows[i].Cells[j].Value = projet.ValeurResiduelle;
                            }
                            break;
                        case 9:
                            Double CAavtIS2 = donnees[i].Ca - (donnees[i].Cv + donnees[i].Cf);
                            dgv.Rows[i].Cells[j].Value = 9000 + CAavtIS2;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void RemplirDgvActualise(DataGridView dgv)
        {
            List<Donnees> donnees = new List<Donnees>();
            foreach(Donnees donnee in projet.Donnees){
                donnees.Add(donnee);
            }

            //Boucle permettant de parcourir les lignes du tableau
            for (int i = 0; i < dgv.RowCount; i++)
            {
                //Boucle permettant de remplir les cellule d'une ligne du tableau
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    switch (j)
                    {
                        //Cellule correspondant à l'origine
                        case 0:
                            dgv.Rows[i].Cells[j].Value = donnees[i].Ca - (donnees[i].Cv + donnees[i].Cf); ;
                            break;
                        //Cellule correspondant au taux d'actualisation
                        case 1:
                            dgv.Rows[i].Cells[j].Value = donnees[i].Tx;
                            break;
                        //Cellule correspondant à la valeur actualisé
                        case 2:
                            dgv.Rows[i].Cells[j].Value = (donnees[i].Ca - (donnees[i].Cv + donnees[i].Cf)) * donnees[i].Tx;
                            break;
                        default:
                            break;
                    }
                    
                }
            }
        }

    }
}
