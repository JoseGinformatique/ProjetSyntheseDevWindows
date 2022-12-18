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
        }

        private void ModifClient_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
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
                        break;
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
        Chambre ch_res;
        /// <summary>
        /// Methode qui envoie le client qui fait la reservation
        /// </summary>
        /// <param name="cha">Client qui reserve</param>
        public void ChambreAreserver(Chambre cha)
        {
            ch_res = cha;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
