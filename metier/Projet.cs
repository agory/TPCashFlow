using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class Projet
    {
        #region Propriété privées

        private Double investissementP;
        private Double investissementM;
        private Double valeurResiduelle;
        private List<Donnees> donnees;

        public List<Donnees> Donnees
        {
            get { return donnees; }
            set { donnees = value; }
        }
        
        #endregion

        #region Accesseu/Mutateur


        public Double InvestissementP{
            get { return investissementP; }
            set { investissementP = value; }
        }

        public Double InvestissementM{
            get { return investissementM; }
            set { investissementM = value; }
        }

        public Double ValeurResiduelle{
            get { return valeurResiduelle; }
            set { valeurResiduelle = value; }
        }

       
        #endregion

        #region Constructeur init

        public Projet() { }

        public Projet(Double investissementP, Double investissementM, Double valeurResiduelle) {
            Init(investissementP, investissementM, valeurResiduelle);


        }

        public void Init(Double investissementP, Double investissementM, Double valeurResiduelle)
        {
            this.investissementP = investissementP;
            this.investissementM = investissementM;
            this.valeurResiduelle = valeurResiduelle;
            this.donnees = new List<Donnees>();
        }
        public void Init(Double investissementP, Double investissementM, Double valeurResiduelle, List<Donnees> lDonnees)
        {
            this.investissementP = investissementP;
            this.investissementM = investissementM;
            this.valeurResiduelle = valeurResiduelle;
            this.donnees = lDonnees;
        }

        #endregion

        #region  Méthodes

        public void AddDonnees(int annee, Double ca, Double cv, Double cf, Double tx)
        {
            Donnees donnee = new Donnees(annee, ca, cv, cf, tx);
            this.donnees.Add(donnee);
        }

        public Double amortissement()
        {
            return (investissementM + investissementP - valeurResiduelle) / donnees.Count;
        }

        public Double cashFlow(int i)
        {
            return amortissement() + donnees[i].caAvtIS() - donnees[i].mtIS();
        }

        public Double cashFlowActu(int i)
        {
            return Math.Pow((1 + (donnees[i].Tx/100)), (-i)) * cashFlow(i);
        }
        #endregion
    }
}