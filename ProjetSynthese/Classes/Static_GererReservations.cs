using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese.Classes
{
    internal class Static_GererReservations
    {
        // la liste des Chambres
        /// Liste dérivée des objets de la classe Chambre
        private static List<Chambre> listChambre = new List<Chambre>();

        public static List<Chambre> LsChambre
        {
            get { return listChambre; }
            set { listChambre = value; }
        }

        /// la liste des Salles
        /// Liste orivée des objets de la classe Salle
        private static List<Salle> listSalle = new List<Salle>();

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
