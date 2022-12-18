using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetSynthese.Forms
{
    public partial class ConClient : Form
    {
        public ConClient()
        {
            InitializeComponent();
        }

        private void ConClient_Load(object sender, EventArgs e)
        {
            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("SELECT * FROM Clients");
            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {

                    //creation de chaque client comme objet et l'instancier dans la liste statique
                    Client cl = new Client();
                    //Les INT faut les transformer en string et de nouveau en Int avec cette methode
                    //pour assurer qu'ils soient en format Int
                    cl.Num_client = Int32.Parse(resultat[0].ToString());
                    cl.Mot_de_passe = resultat[1].ToString();
                    cl.Nom = resultat[2].ToString();
                    cl.Prenom = resultat[3].ToString();
                    cl.Age = Int32.Parse(resultat[4].ToString());
                    Static_Autentification.LsClients.Add(cl);                }
            }
            else
                MessageBox.Show("La table Clients est vide.");
            resultat.Close();
        }

        private void Nouveau_client_Click(object sender, EventArgs e)
        {
            NouveauClient formulaire = new NouveauClient(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            this.Close();
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            bool b_num, b_ver;
            b_ver = false;
            b_num = Static_Autentification.VerifierRegex("^[0-9]{6}$", Numero_client, labelErrNum, "Votre numero doit être un chiffre à 6 caractères");

            if (b_num)
            {
                
                //foreach (Client cl in Static_Autentification.LsClients)
                //{
                //    if (b_num && Int32.Parse(Numero_client.Text) == cl.Num_client && MotDePasse.ToString() == cl.Mot_de_passe)
                //    {
                //        Reservation formulaire = new Reservation(); // Création d'une instance 
                //        formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
                //        formulaire.Show(); // affichage du formulaire enfant
                //        this.Close();
                //        b_ver= true;
                //    }
                //}
            }
            if (!b_ver) 
            {
                labelErrMdp.Text = "Aucun utilisateur n'a été trouvé avec ce nom ou le mot de passe ne correspond pas";
            }
        }
    }
}
