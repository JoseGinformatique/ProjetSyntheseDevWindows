using ProjetSynthese.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
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
    public partial class MonHotel : Form
    {
        public MonHotel()
        {
            InitializeComponent();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConClient formulaire = new ConClient(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
        }

        private void TarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarifs formulaire = new Tarifs(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant

        }

        private void MonHotel_Load(object sender, EventArgs e)
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
                    Static_Autentification.LsClients.Add(cl);
                }
            }
            else
                MessageBox.Show("La table Clients est vide.");
            resultat.Close();

            
            SqlDataReader resultat2 = Static_Autentification.OuvrirConnectionBase("SELECT * FROM Administrateur");
            if (resultat2.HasRows) //On vérifie si la table n'est pas vide
            {

                while (resultat2.Read()) // Tant qu'il y a des lignes à lire
                {

                    //creation de chaque Administrateur comme objet et l'instancier dans la liste statique
                    Administrateur ad = new Administrateur();
                    //Les INT faut les transformer en string et de nouveau en Int avec cette methode
                    //pour assurer qu'ils soient en format Int
                    ad.Num_admin = Int32.Parse(resultat2[0].ToString());
                    ad.Mot_de_passe = resultat2[1].ToString();
                    ad.Nom = resultat2[2].ToString();
                    ad.Prenom = resultat2[3].ToString();
                    Static_Autentification.LsAdmin.Add(ad);
                }
            }
            else
                MessageBox.Show("La table Administrateur est vide.");
            resultat2.Close();

            SqlDataReader resultat3 = Static_Autentification.OuvrirConnectionBase("SELECT * FROM Chambres");
            if (resultat3.HasRows) //On vérifie si la table n'est pas vide
            {

                while (resultat3.Read()) // Tant qu'il y a des lignes à lire
                {

                    //creation de chaque Chambre comme objet et l'instancier dans la liste statique
                    Chambre ch = new Chambre();
                    //Les INT faut les transformer en string et de nouveau en Int avec cette methode
                    //pour assurer qu'ils soient en format Int
                    ch.Num_Reservation = resultat3[0].ToString();
                    ch.Prix = Int32.Parse(resultat3[1].ToString());
                    ch.Type = resultat3[2].ToString();
                    //Vu qu'on utilise le type BIT dans la base de donné pour le status de la chambre
                    //on se doit de le transfomer en string pour voir si celui-ci est True ou False
                    //Vu qu'en c# les bool sont ecrits en minuscule on se doit de faire un if pour 
                    //specifier le bon état du bool
                    if (resultat3[3].ToString() == "True") { ch.Status = true; } 
                    else { ch.Status = false; }
                    Static_GererReservations.LsChambre.Add(ch);
                }
            }
            else
                MessageBox.Show("La table Chambres est vide.");
            resultat3.Close();

            SqlDataReader resultat4 = Static_Autentification.OuvrirConnectionBase("SELECT * FROM Salles");
            if (resultat4.HasRows) //On vérifie si la table n'est pas vide
            {

                while (resultat4.Read()) // Tant qu'il y a des lignes à lire
                {

                    //creation de chaque Salle comme objet et l'instancier dans la liste statique
                    Salle sal = new Salle();
                    //Les INT faut les transformer en string et de nouveau en Int avec cette methode
                    //pour assurer qu'ils soient en format Int
                    sal.Num_Reservation = resultat4[0].ToString();
                    sal.Prix = Int32.Parse(resultat4[1].ToString());
                    sal.Nom = resultat4[2].ToString();
                    //Vu qu'on utilise le type BIT dans la base de donné pour le status de la salle
                    //on se doit de le transfomer en string pour voir si celui-ci est True ou False
                    //Vu qu'en c# les bool sont ecrits en minuscule on se doit de faire un if pour 
                    //specifier le bon état du bool
                    if (resultat4[3].ToString() == "True") { sal.Status = true; }
                    else { sal.Status = false; }
                    Static_GererReservations.LsSalle.Add(sal);
                }
            }
            else
                MessageBox.Show("La table Salles est vide.");
            resultat4.Close();

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConAdmin formulaire = new ConAdmin(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
        }
    }
}
