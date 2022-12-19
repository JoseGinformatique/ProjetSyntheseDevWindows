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

namespace ProjetSynthese.Forms
{
    public partial class GereRes : Form
    {
        public GereRes()
        {
            InitializeComponent();
        }

        public void GereRes_Load(object sender, EventArgs e)
        {
            label3.Text = "Vous êtes sur le compte de: " + admin.Prenom + " " +  admin.Nom + " - Gerer les Reservations";

            dataGridViewChambres.Rows.Clear();
            dataGridViewSalles.Rows.Clear();

            //Ouvre une connection avec la base de donné avec une commande
            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("SELECT * from V_CHAMBRES");

            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table

            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {
                    // Selon le bool du statut de la chambre on change le texte pour occupé ou libre
                    string stat;
                    if (resultat[3].ToString() == "True") { stat = "occupé"; }
                    else { stat = "libre"; }
                    //On ajouter les quatre colonnes de la ligne lue
                    //MessageBox.Show(resultat[3].ToString());

                    dataGridViewChambres.Rows.Add(resultat[0], resultat[1] + " $", resultat[2], stat, resultat[4]);
                }
            }
            else
                MessageBox.Show("La table Chambres est vide.");
            resultat.Close();


            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table
            SqlDataReader resultat2 = Static_Autentification.OuvrirConnectionBase("SELECT * from V_SALLES");

            if (resultat2.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat2.Read()) // Tant qu'il y a des lignes à lire
                {
                    // Selon le bool du statut de la salle on change le texte pour occupé ou libre
                    string stat;
                    if (resultat2[3].ToString() == "True") { stat = "occupé"; }
                    else { stat = "libre"; }
                    //On ajouter les quatre colonnes de la ligne lue
                    dataGridViewSalles.Rows.Add(resultat2[0], resultat2[1] + " $", resultat2[2], stat, resultat2[4]);
                }
            }
            else
                MessageBox.Show("La table Salles est vide.");
            resultat2.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModifClient formulaire = new ModifClient(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
        }

        private void dataGridViewChambres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ver=true;
            int index = dataGridViewChambres.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewChambres.Rows[index];
            string num_ch = row.Cells[0].Value.ToString();
            

            foreach (Chambre ch in Static_GererReservations.LsChambre)
            {
                //MessageBox.Show(ch.Status.ToString())
                if (num_ch == ch.Num_Reservation && !ch.Status)
                {
                    ModifClient formulaire = new ModifClient(); // Création d'une instance 
                    formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
                    formulaire.ChambreAreserver(ch);
                    formulaire.ChangerformReserver();
                    formulaire.Show(); // affichage du formulaire enfant
                    ver = false;
                    break;
                }
            }
            if (ver) {MessageBox.Show("Veuillez choisir une chambre qui n'est pas occupée"); }

            
        }


        //Instanciation d'un objet Administrateur pour l'amener dans ce formulaire avec la methode au dessus
        Administrateur admin;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="adm"></param>
        public void AdminSurPage(Administrateur adm)
        {
            admin = adm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ver = true;
            int index = dataGridViewChambres.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewChambres.Rows[index];
            string num_ch = row.Cells[0].Value.ToString();

            foreach (Chambre ch in Static_GererReservations.LsChambre)
            {
                //MessageBox.Show(ch.Status.ToString())
                if (num_ch == ch.Num_Reservation && ch.Status)
                {

                    ch.Status = false;

                    //On change les valeur dans la base de données pour que la chambre apparaise comme occupée
                    //On instacie aussi cet evenement dans la "troisième" table qui suit la trace du numero de reservation et du numero du client
                    SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("UPDATE Chambres SET [Status] = 0 WHERE NumeroReservation = '"
                        + ch.Num_Reservation + "'" + "\nDELETE FROM Reservations\r\nWHERE num_reservation = '" + ch.Num_Reservation + "'");

                    resultat.Close();
                    MessageBox.Show("La chambre à bien été marquée comme libre veuillez raffraichir pour voir le changement");

                    ver = false;
                    break;
                }
            }
            if (ver) { MessageBox.Show("Veuillez choisir une chambre qui est occupée"); }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            bool ver = true;
            int index = dataGridViewSalles.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewSalles.Rows[index];
            string num_sa = row.Cells[0].Value.ToString();


            foreach (Salle sal in Static_GererReservations.LsSalle)
            {
                //MessageBox.Show(ch.Status.ToString())
                if (num_sa == sal.Num_Reservation && !sal.Status)
                {
                    ModifClient formulaire = new ModifClient(); // Création d'une instance 
                    formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
                    formulaire.SalleAreserver(sal);
                    formulaire.ChangerformReserver();
                    formulaire.Show(); // affichage du formulaire enfant
                    ver = false;
                    break;
                }
            }
            if (ver) { MessageBox.Show("Veuillez choisir une salle qui n'est pas occupée"); }

        }

        private void dataGridViewSalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool ver = true;
            int index = dataGridViewSalles.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewSalles.Rows[index];
            string num_sa = row.Cells[0].Value.ToString();

            foreach (Salle sa in Static_GererReservations.LsSalle)
            {
                //MessageBox.Show(ch.Status.ToString())
                if (num_sa == sa.Num_Reservation && sa.Status)
                {

                    sa.Status = false;

                    //On change les valeur dans la base de données pour que la chambre apparaise comme occupée
                    //On instacie aussi cet evenement dans la "troisième" table qui suit la trace du numero de reservation et du numero du client
                    SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("UPDATE Salles SET [Status] = 0 WHERE NumeroReservation = '"
                        + sa.Num_Reservation + "'" + "\nDELETE FROM Reservations\r\nWHERE num_reservation = '" + sa.Num_Reservation + "'");

                    resultat.Close();
                    MessageBox.Show("La salle à bien été marquée comme libre veuillez raffraichir pour voir le changement");

                    ver = false;
                    break;
                }
            }
            if (ver) { MessageBox.Show("Veuillez choisir une salle qui est occupée"); }
        }
    }
}
