using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*/
 * Titre: Projet Synthese
 * Fait par: Jose Luis Gutierrez
 * # etd: 2146130
 * 
 * CE CODE CONTIENS DES PARTIES DE CODE INSPIRÉES PAR
 * 
 *****  Hasna Hocini  ***** (SOLUTIONNAIRE "GestElection")
 *
 ***** www.w3schools.blog *******
 *
 */

namespace ProjetSynthese
{
    public class Administrateur
    {
        // champs privés 
        private int num_admin;
        private string mot_de_passe;
        private string nom;
        private string prenom;

        /// <summary>
        /// Champ public pour la propriété privée
        /// Num_admin int
        /// </summary>
        public int Num_admin
        {
            get { return num_admin; }
            set { num_admin = value; }
        }
        /// <summary>
        /// Champ public pour la propriété privée
        /// Mot_de_passe string
        /// </summary>
        public string Mot_de_passe
        {
            get { return mot_de_passe; }
            set { mot_de_passe = value; }
        }
        /// <summary>
        /// Champ public pour la propriété privée
        /// Nom string
        /// </summary>
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        /// <summary>
        /// Champ public pour la propriété privée
        /// Prenom string
        /// </summary>
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        /// <summary>
        /// Constructeur de la classe Administrateur avec des instances par défaut
        /// </summary>
        /// <param name="p_num_admin">int du num admin</param>
        /// <param name="p_mot_de_passe">string mot de passe admin</param>
        /// <param name="p_nom">sting nom admin</param>
        /// <param name="p_prenom">strin prenom admin</param>
        public Administrateur(int p_num_admin = 123456, string p_mot_de_passe = "mdp", string p_nom = "nom", string p_prenom = "prenom")
        {
            this.Num_admin = p_num_admin;
            this.Mot_de_passe = p_mot_de_passe;
            this.Nom = p_nom;
            this.Prenom = p_prenom;

        }
    }
}
