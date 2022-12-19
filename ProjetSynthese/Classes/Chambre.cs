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
    public class Chambre: Reservation
    {
        //Champs privés
        private string type;
        private bool status;

        /// <summary>
        /// Champ public pour la propriété privée
        /// Type string
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
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
        /// Constructeur de la classe Chambre avec des instances par défaut
        /// et deux parametres herités de la classe Reservation (num reservation et prix)
        /// </summary>
        /// <param name="p_num_reservation">string num de reservation (2 caracteres selon base de donnéés)</param>
        /// <param name="p_prix">int prix</param>
        /// <param name="p_type">string type soit suite ou reguliere</param>
        /// <param name="p_status">bool True= disponible // False= occupé</param>
        public Chambre(string p_num_reservation = "xx", int p_prix = 0, string p_type = "type", bool p_status = false)
            :base(p_num_reservation, p_prix)
        {
            this.Type = p_type;
            this.Status = p_status;
        }

    }
}
