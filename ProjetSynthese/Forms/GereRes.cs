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
    public partial class GereRes : Form
    {
        public GereRes()
        {
            InitializeComponent();
        }

        private void GereRes_Load(object sender, EventArgs e)
        {
            //Ouvre une connection avec la base de donné avec une commande
            SqlDataReader resultat = Static_Autentification.OuvrirConnectionBase("SELECT * from Chambres");

            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table

            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {

                    //On ajouter les trois colonnes de la ligne lue
                    dataGridViewChambres.Rows.Add(resultat[0], resultat[1] + " $", resultat[2], resultat[3]);
                }
            }
            else
                MessageBox.Show("La table Chambres est vide.");
            resultat.Close();


            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table
            SqlDataReader resultat2 = Static_Autentification.OuvrirConnectionBase("SELECT * from Salles");

            if (resultat2.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat2.Read()) // Tant qu'il y a des lignes à lire
                {

                    //On ajouter les trois colonnes de la ligne lue
                    dataGridViewSalles.Rows.Add(resultat2[0], resultat2[1] + " $", resultat2[2], resultat2[3]);
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
            this.Close();
        }

        private void dataGridViewChambres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = dataGridViewChambres.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewChambres.Rows[index];
            string num_ch = row.Cells[0].Value.ToString();
            MessageBox.Show(num_ch);

            foreach (Chambre ch in Static_GererReservations.LsChambre)
            {
                if (num_ch == ch.Num_Reservation)
                {

                }
            }
            
        }
    }
}
