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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Methode pour changer le statut d'occupé dans la chambre
        /// </summary>
        /// <param name="ch"></param>
        public void ChangerStatutChambre(Chambre ch)
        {
            // on change le status de la chambre à true pour dire qu'elle est prise
            ch.Status = true;
            //On change les valeur dans la base de données pour que la chambre apparaise comme occupée
            //On instacie aussi cet evenement dans la "troisième" table qui suit la trace du numero de reservation et du numero du client
            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("UPDATE Chambres SET [Status] = 1 WHERE NumeroReservation = '"
                + ch.Num_Reservation + "'" + "\nINSERT INTO Reservations\nVALUES\t('" + ch.Num_Reservation + "', " + c.Num_client + ")");

            resultat.Close();
            
            //Afficher la facture du client avec ses informations et le numero de sa chambre
            MessageBox.Show("Voici votre facture \n" + c.ToString() + "\nChambre: " + ch.Num_Reservation +
                "\n\nMerci d'avoir fait affaire avec Hotel Jose!");
            this.Close();
        }

        /// <summary>
        /// Methode pour changer le statut d'occupé dans la salle
        /// </summary>
        /// <param name="sl"></param>
        public void ChangerStatutSalle(Salle sl)
        {
            // on change le status de la salle à true pour dire qu'elle est prise
            sl.Status = true;
            //On change les valeur dans la base de données pour que la salle apparaise comme occupée
            //On instacie aussi cet evenement dans la "troisième" table qui suit la trace du numero de reservation et du numero du client
            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("UPDATE Salles SET [Status] = 1 WHERE NumeroReservation = '"
                + sl.Num_Reservation + "'" + "\nINSERT INTO Reservations\nVALUES\t('" + sl.Num_Reservation + "', " + c.Num_client + ")");

            resultat.Close();
            //Afficher la facture du client avec ses informations et le numero de sa salle
            MessageBox.Show("Voici votre facture \n" + c.ToString() + "\nSalle: " + sl.Num_Reservation +
                "\n\nMerci d'avoir fait affaire avec Hotel Jose!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelErr.Text = string.Empty;
            bool bl_mess = true;
            if (comboBoxRes.Text != "Cliquez pour derrouler les options")
            {
                
                
                if (comboBoxRes.Text == "Chambre: Suite" || comboBoxRes.Text ==  "Chambre: Régulière")
                {
                    //Si c'est une suite ou une reguliere on passe à travers la liste des chambres
                   foreach (Chambre ch in Static_GererReservations.LsChambre)
                    {
                        //Si on trouve une chambre de type Suite libre
                        if (comboBoxRes.Text == "Chambre: Suite" && ch.Type == "Suite" && ch.Status == false)
                        {
                            ChangerStatutChambre(ch);
                            bl_mess = false;
                            break;
                        }
                        //Si on trouve une chambre de type Suite Régulière
                        else if (comboBoxRes.Text == "Chambre: Régulière" && ch.Type == "Régulière" && ch.Status == false)
                        {
                            ChangerStatutChambre(ch);
                            bl_mess = false;
                            break;
                        }
                    }
                   //Afficher un message d'erreur si toutes les chambres sont prises ou (toutes ont un statut true)
                    if (bl_mess == true)
                    {
                        labelErr.ForeColor = Color.Red;
                        labelErr.Text = "Aucune chambre de ce type n'est disponible pour réserver";
                    }
                }
                else if (comboBoxRes.Text == "Salle: Piscine" || comboBoxRes.Text == "Salle: Cinema" || comboBoxRes.Text == "Salle: Salle de reunions")
                {
                    foreach (Salle sl in Static_GererReservations.LsSalle)
                    {
                        //Si on trouve une salle du nom Piscine libre
                        if (comboBoxRes.Text == "Salle: Piscine" && sl.Nom == "Piscine" && sl.Status == false)
                        {
                            ChangerStatutSalle(sl);
                            bl_mess = false;
                            break;
                        }
                        //Si on trouve une salle du nom Cinema libre (il faut specifier A ou B, car il va chercher le nom exact de salle)
                        //Tandis qu'avec les chambres il allais chercher la premiere instance.
                        else if (comboBoxRes.Text == "Salle: Cinema" && sl.Nom == "Cinema A" && sl.Status == false)
                        {
                            ChangerStatutSalle(sl);
                            bl_mess = false;
                            break;
                        }
                        else if (comboBoxRes.Text == "Salle: Cinema" && sl.Nom == "Cinema B" && sl.Status == false)
                        {
                            ChangerStatutSalle(sl);
                            bl_mess = false;
                            break;
                        }
                        //Si on trouve une salle du nom Salle de reunions libre
                        //même procedure qu'avec cinema
                        else if (comboBoxRes.Text == "Salle: Salle de reunions" && sl.Nom == "Salle de reunions A" && sl.Status == false)
                        {
                            ChangerStatutSalle(sl);
                            bl_mess = false;
                            break;
                        }
                        else if (comboBoxRes.Text == "Salle: Salle de reunions" && sl.Nom == "Salle de reunions B" && sl.Status == false)
                        {
                            ChangerStatutSalle(sl);
                            bl_mess = false;
                            break;
                        }
                    }
                    //Afficher un message d'erreur si toutes les salles sont prises ou (toutes ont un statut true)
                    if (bl_mess == true)
                    {
                        labelErr.ForeColor = Color.Red;
                        labelErr.Text = "Aucune Salle de avec cette description n'est disponible pour réserver";
                    }
                }
            }
            
        }

        //Instanciation d'un objet client pour l'amener dans ce formulaire avec la methode au dessus
        Client c;
        /// <summary>
        /// Methode qui envoie le client qui fait la reservation
        /// </summary>
        /// <param name="cl">Client qui reserve</param>
        public void Resclient(Client cl) {
            c = cl;
        }

        private void comboBoxRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
