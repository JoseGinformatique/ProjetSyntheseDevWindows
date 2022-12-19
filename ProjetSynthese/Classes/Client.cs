using ProjetSynthese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public class Client : Imessage
    {
        //Champs privés
        private int num_client;
        private string mot_de_passe;
        private string nom;
        private string prenom;
        private int age;

        /// <summary>
        /// Champ public pour la propriété privée
        /// Num_client int
        /// </summary>
        public int Num_client
        {
            get { return num_client; }
            set { num_client = value; }
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
        /// Champ public pour la propriété privée
        /// Age int
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Constructeur de la classe Client avec des instances par défaut
        /// </summary>
        /// <param name="p_num_client">int numero du client </param>
        /// <param name="p_mot_de_passe">string mot de passe</param>
        /// <param name="p_nom">string nom</param>
        /// <param name="p_prenom">string prenom</param>
        /// <param name="p_age">int age du client</param>
        public Client(int p_num_client = 123456, string p_mot_de_passe = "mdp", string p_nom = "nom", string p_prenom = "prenom", int p_age = 18)
        {
            this.Num_client = p_num_client;
            this.Mot_de_passe = p_mot_de_passe;
            this.Nom = p_nom;
            this.Prenom = p_prenom;
            this.Age = p_age;
        }
        
        /// <summary>
        /// Mehtode override de ToString pour afficher les paramètres dans une chaine de string (le mot de passe n'est pas affiché pour mesures
        /// de sécurité)
        /// </summary>
        /// <returns>string params client</returns>
        public override string ToString()
        {
            return "Numéro client: " + this.Num_client + " Nom: " + this.Nom + " Prénom: " + this.Prenom;
        }

        /// <summary>
        /// Methode qui calcule l'age du client selon la date specifié dans le picker
        /// </summary>
        /// <param name="date">date format DateTime</param>
        /// <returns>int de l'age calculé</returns>
        public int CalcAge(DateTime date)
        {
            int age = (int)((DateTime.Now - date).TotalDays / 365.24199);
            return age;
        }


        /// <summary>
        /// Methode Interface qui affiche une phrase au client
        /// </summary>
        public void Phrase()
        {
            MessageBox.Show("vos désirs sont des ordres!");
        }
    }
}
