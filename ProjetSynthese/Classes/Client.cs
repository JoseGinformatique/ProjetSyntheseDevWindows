using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public class Client
    {
        private int num_client;
        private string mot_de_passe;
        private string nom;
        private string prenom;
        private int age;

        public int Num_client
        {
            get { return num_client; }
            set { num_client = value; }
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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Constructeur de la classe Client avec des instances par défaut
        /// </summary>
        /// <param name="p_num_client"></param>
        /// <param name="p_mot_de_passe"></param>
        /// <param name="p_nom"></param>
        /// <param name="p_prenom"></param>
        /// <param name="p_age"></param>
        public Client(int p_num_client = 123456, string p_mot_de_passe = "mdp", string p_nom = "nom", string p_prenom = "prenom", int p_age = 18)
        {
            this.Num_client = p_num_client;
            this.Mot_de_passe = p_mot_de_passe;
            this.Nom = p_nom;
            this.Prenom = p_prenom;
            this.Age = p_age;
        }

        public override string ToString()
        {
            return "Numéro client: " + this.Num_client + "Nom: " + this.Nom + "Prénom: " + this.Prenom;
        }
    }
}
