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
    public class Salle: Reservation
    {
        // Champs privés
        private string nom;
        private bool status;

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
        /// Status bool
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Constructeur de la classe Salle avec des instances par défaut
        /// </summary>
        /// <param name="p_num_reservation">string numero reservation</param>
        /// <param name="p_prix">int prix</param>
        /// <param name="p_nom">string nom de la salle</param>
        /// <param name="p_status">bool True= disponible // False= occupé</param>
        public Salle(string p_num_reservation = "xx", int p_prix = 0, string p_nom = "xx", bool p_status = false)
            : base(p_num_reservation, p_prix)
        {
            this.Nom = p_nom;
            this.Status = p_status;
            
        }
    }
}
