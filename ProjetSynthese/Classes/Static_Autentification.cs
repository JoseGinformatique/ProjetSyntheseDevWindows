using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;

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

        /// <summary>
        /// Methode qui verifie une chaine de regex
        /// </summary>
        /// <param name="modele">modele regex format string</param>
        /// <param name="tb">text box qu'on compare</param>
        /// <param name="lb">label pour afficher le message d'erreur</param>
        /// <param name="messageErreur">modele du message d'erreur</param>
        /// <returns></returns>
        public static bool VerifierRegex(string modele, TextBox tb, Label lb, string messageErreur)
        {
            //Créer du Regex regex
            Regex reg = new Regex(modele);
            //Vérifier la correspondance entre le champ entré dans la textBox et le modèle
            if (!reg.IsMatch(tb.Text))
            {
                //Afficher le message d'erreur et retourne false
                lb.ForeColor = Color.Red;
                lb.Text = messageErreur;
                return false;
            }
            else
            {
                lb.Text = ""; //Effacer le label si le champ entré est valide et retourne true
                return true;
            }
        }

        /// <summary>
        /// Methode pour verifier si le client à l'age requis pour faire une réservation (18)
        /// </summary>
        /// <param name="age">int</param>
        /// <param name="lb">label pour afficher un message d'erreur</param>
        /// <param name="messageErreur">string message personalisé d'erreur</param>
        /// <returns></returns>
        public static bool VerifierAge(int age, Label lb, string messageErreur)
            {
                if (age >= 18)
                {
                    lb.Text = "";
                    return true; //Si l'age est supperieur ou egal à 18, il retourne true et sort
                }

                //Afficher le message d'erreur
                lb.ForeColor = Color.Red;
                lb.Text = messageErreur;
                return false; //Si l'age n'est pas valide retourne false et sort
            }
        
        /// <summary>
        /// Function statique qui prends une commande en parametre en ouvre une conection
        /// Returne une comande format SqlDataReader
        /// </summary>
        /// <param name="comande">string</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader OuvrirConnectionBase(string comande) {
            //Configurer la connection avec la base de données
            String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            string Query = comande;
            SqlCommand command = new SqlCommand(Query, cnx);
            cnx.Open();
            return command.ExecuteReader();

        }
    }
}
