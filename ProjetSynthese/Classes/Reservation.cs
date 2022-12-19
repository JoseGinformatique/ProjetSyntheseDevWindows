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
    public class Reservation
    {
        //Champs privés
        private string num_reservation;
        private int prix;

        /// <summary>
        /// Champ public pour la propriété privée
        /// Prix int
        /// </summary>
        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        /// <summary>
        /// Champ public pour la propriété privée
        /// Num_Reservation string
        /// </summary>
        public string Num_Reservation
        {
            get { return num_reservation; }
            set { num_reservation = value; }
        }

        /// <summary>
        /// Constructeur de la classe Reservation
        /// </summary>
        /// <param name="p_num_reservation">string num reservation</param>
        /// <param name="p_prix"> int prix reservation</param>
        public Reservation(string p_num_reservation, int p_prix)
        {
            this.Num_Reservation = p_num_reservation;
            this.Prix = p_prix;
        }

        
    }
}
