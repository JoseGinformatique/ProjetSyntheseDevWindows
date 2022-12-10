using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public static class Static_Autentification
    {
        

        /// la liste des Clients
        /// Liste dérivée des objets de la classe Client
        private static List<Client> listClients = new List<Client>();

        public static List<Client> LsClients
        {
            get { return listClients; }
            set { listClients = value; }
        }

        /// la liste des Administrateurs
        /// Liste orivée des objets de la classe Administrateur
        private static List<Administrateur> listAdmin = new List<Administrateur>();

        public static List<Administrateur> LsAdmin
        {
            get { return listAdmin; }
            set { listAdmin = value; }
        }


        /// <summary>
        /// Constructeur classe statique Static_Autentification
        /// </summary>
        static Static_Autentification()
        {
            LsClients = listClients;
            LsAdmin = listAdmin;
        }
    }
}
