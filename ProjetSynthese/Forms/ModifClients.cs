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

namespace ProjetSynthese.Forms
{
    public partial class ModifClient : Form
    {
        public ModifClient()
        {
            InitializeComponent();
        }

        public void ChangerformReserver()
        {
            button1.Text = "Reserver!";
            button2.Visible = false;
            label1.Text = "Veuillez choisir un client existant ou revenez sur l'onglet \"Gerer les reservations\" pour ajouter un nouveau";
        }

        private void ModifClient_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //Ouvre une connection avec la base de donné avec une commande
            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("SELECT * from Clients");

            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table

            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {

                    //On ajouter les trois colonnes de la ligne lue
                    dataGridView1.Rows.Add(resultat[0], resultat[2] , resultat[3], resultat[4]);
                }
            }
            else
                MessageBox.Show("La table Clients est vide.");
            resultat.Close();
        }

        private void button_ajouter_reserver_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Reserver!")
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                string num_cl = row.Cells[0].Value.ToString();
                Client cli = new Client();
                foreach (Client cl in Static_Autentification.LsClients)
                {
                    if (num_cl == cl.Num_client.ToString())
                    {
                        cli = cl;
                        break;
                    }
                }



                if (ch_res.Prix > 0)
                {
                    foreach (Chambre c in Static_GererReservations.LsChambre)
                    {
                        if (ch_res.Num_Reservation == c.Num_Reservation)
                        {
                            // on change le status de la chambre à true pour dire qu'elle est prise
                            c.Status = true;
                            //Afficher la facture du client avec ses informations et le numero de sa chambre
                            MessageBox.Show("Voici votre facture \n" + cli.ToString() + "\nChambre: " + c.Num_Reservation +
                                "\n\nMerci d'avoir fait affaire avec Hotel Jose!");
                            //On instacie aussi cet evenement dans la "troisième" table qui suit la trace du numero de reservation et du numero du client
                            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("UPDATE Chambres SET [Status] = 1 WHERE NumeroReservation = '"
                                + c.Num_Reservation + "'" + "\nINSERT INTO Reservations\nVALUES\t('" + c.Num_Reservation + "', " + num_cl + ")");

                            resultat.Close();
                            this.Close();
                            MessageBox.Show("veuillez raffraichir la page pour voir les changements");
                            break;
                        }
                    }
                }
                else if (sal_res.Prix > 0)
                {
                    foreach (Salle sa in Static_GererReservations.LsSalle)
                    {
                        if (sal_res.Num_Reservation == sa.Num_Reservation)
                        {
                            // on change le status de la chambre à true pour dire qu'elle est prise
                            sa.Status = true;
                            //Afficher la facture du client avec ses informations et le numero de sa chambre
                            MessageBox.Show("Voici votre facture \n" + cli.ToString() + "\nChambre: " + sa.Num_Reservation +
                                "\n\nMerci d'avoir fait affaire avec Hotel Jose!");
                            //On instacie aussi cet evenement dans la "troisième" table qui suit la trace du numero de reservation et du numero du client
                            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("UPDATE Salles SET [Status] = 1 WHERE NumeroReservation = '"
                                + sa.Num_Reservation + "'" + "\nINSERT INTO Reservations\nVALUES\t('" + sa.Num_Reservation + "', " + num_cl + ")");

                            resultat.Close();
                            this.Close();
                            MessageBox.Show("veuillez raffraichir la page pour voir les changements");
                            break;
                        }
                    }
                }
                

            }
            else
            {
                NouveauClient formulaire = new NouveauClient(); // Création d'une instance 
                formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
                formulaire.Show(); // affichage du formulaire enfant
            }
        }

        //Instanciation d'un objet chambre pour l'amener dans ce formulaire avec la methode au dessus
        Chambre ch_res = new Chambre();
        /// <summary>
        /// Methode qui envoie la chambre qu'on fait la reservation
        /// </summary>
        /// <param name="cha">Chambre qu'on reserve</param>
        public void ChambreAreserver(Chambre cha)
        {
            ch_res = cha;
        }

        //Instanciation d'un objet chambre pour l'amener dans ce formulaire avec la methode au dessus
        Salle sal_res = new Salle();
        /// <summary>
        /// Methode qui envoie la salle qu'on fait la reservation
        /// </summary>
        /// <param name="sal">salle qu'on reserve</param>
        public void SalleAreserver(Salle sal)
        {
            sal_res = sal;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bool ver = true;
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            string num_cl = row.Cells[0].Value.ToString();

            foreach (Client cl in Static_Autentification.LsClients)
            {
                //MessageBox.Show(ch.Status.ToString())
                if (num_cl == cl.Num_client.ToString())
                {
                    
                    //verifier que le client n'a presentement pas reservé de chambre ou salle
                    SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase(
                        "SELECT * FROM Reservations\r\nWHERE client = '" + cl.Num_client + "'");

                    if (resultat.HasRows) //On vérifie si la table n'est pas vide
                    {
                        MessageBox.Show("Le client choisi ne peut pas être supprimé, car il a presentement reservé une chambre ou une salle, \n" +
                            "Veuillez marquer comme libre les chambres ou salles reservés par le client et recomencez");
                        
                    }
                    else
                    {
                        //On change les valeur dans la base de données pour que le client soit aussi supprimé
                        SqlDataReader resultat2 = Static_Autentification.OuvrirConnectionBase("DELETE FROM Clients\r\nWHERE num_client = " + cl.Num_client);
                        MessageBox.Show("Le client à bien été supprimé veuillez raffraichir pour voir le changement");
                        //ver = false; // Client trouvé et supprimé, alors pas besoin du message d'erreur
                        //On supprime le client dans la liste des clients
                        Static_Autentification.LsClients.Remove(cl);
                        resultat2.Close();
                    }
                    resultat.Close();
                    break;
                }
            }
            //if (ver) { MessageBox.Show("Aucun clien avec ce numero n'a été trouvé"); }
        }
    }
}
