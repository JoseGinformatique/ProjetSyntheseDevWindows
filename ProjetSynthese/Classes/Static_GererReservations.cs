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
    public static class Static_GererReservations
    {

        /// la liste des Chambres
        /// Liste dérivée des objets de la classe Chambre
        private static List<Chambre> listChambre = new List<Chambre>();

        /// <summary>
        /// Champ public pour la propriété privée
        /// LsChambre liste des chambres
        /// </summary>
        public static List<Chambre> LsChambre
        {
            get { return listChambre; }
            set { listChambre = value; }
        }

        /// la liste des Salles
        /// Liste orivée des objets de la classe Salle
        private static List<Salle> listSalle = new List<Salle>();

        /// <summary>
        /// Champ public pour la propriété privée
        /// LsSalle liste des salles
        /// </summary>
        public static List<Salle> LsSalle
        {
            get { return listSalle; }
            set { listSalle = value; }
        }


        /// <summary>
        /// Constructeur classe statique Static_GererReservations
        /// </summary>
        static Static_GererReservations()
        {
            LsChambre = listChambre;
            LsSalle = listSalle;
        }


    }
}
