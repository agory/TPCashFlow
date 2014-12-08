using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class Donnees
    {
        #region Propriété privées

        private int annee;
        private Double ca;
        private Double cv;
        private Double cf;
        private Double tx;

        
        #endregion

        #region Accesseur/Mutateur

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }


        public Double Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        public Double Cv
        {
            get { return cv; }
            set { cv = value; }
        }
        public Double Cf
        {
            get { return cf; }
            set { cf = value; }
        }

        public Double Tx
        {
            get { return tx; }
            set { tx = value; }
        }
       
        #endregion

        #region Constructeur init

        public Donnees() { }

        public Donnees(int annee, Double ca, Double cv, Double cf, Double tx)
        {
            this.annee = annee;
            this.ca = ca;
            this.cv = cv;
            this.cf = cf;
            this.tx = tx;
        }
        public Donnees(int annee) 
        {
            this.annee = annee;
        }

        public void InitData(Double ca, Double cv, Double cf, Double tx) {
            this.ca = ca;
            this.cv = cv;
            this.cf = cf;
            this.tx = tx;
        }
        #endregion

        #region  Méthodes

        public Double chargesAnnuelles()
        {
            return Cf + Cv;
        }

        public Double caAvtIS()
        {
            return Ca - (Cv + Cf);
        }

        public Double mtIS()
        {
            return (Ca - (Cv + Cf))/3;
        }
        #endregion
    }
}
