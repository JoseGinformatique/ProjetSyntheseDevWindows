using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public class Administrateur
    {
        private int num_admin;
        private string mot_de_passe;
        private string nom;
        private string prenom;


        public int Num_admin
        {
            get { return num_admin; }
            set { num_admin = value; }
        }
        public string Mot_de_passe
        {
            get { return mot_de_passe; }
            set { mot_de_passe = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public Administrateur(int p_num_admin, string p_mot_de_passe, string p_nom, string p_prenom)
        {
            this.Num_admin = p_num_admin;
            this.Mot_de_passe = p_mot_de_passe;
            this.Nom = p_nom;
            this.Prenom = p_prenom;

        }
    }
}
