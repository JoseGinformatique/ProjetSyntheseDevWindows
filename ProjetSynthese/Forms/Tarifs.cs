﻿using System;
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

namespace ProjetSynthese.Forms
{
    public partial class Tarifs : Form
    {
        public Tarifs()
        {
            InitializeComponent();
        }

        private void Tarifs_Load(object sender, EventArgs e)
        {
            //Configurer la connection avec la base de données
            String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            string Query = "SELECT * from TarifsChambres";
            SqlCommand command = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader resultat = command.ExecuteReader();
            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table

            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {

                    //On ajouter les trois colonnes de la ligne lue
                    dataGridView1.Rows.Add(resultat[0], resultat[1] + " $", resultat[2]);
                }
            }
            else
                MessageBox.Show("La table Chambres est vide.");
            resultat.Close();

            string Query2 = "SELECT * from TarifsSalles";
            SqlCommand command2 = new SqlCommand(Query2, cnx);
            SqlDataReader resultat2 = command2.ExecuteReader();
            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table

            if (resultat2.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat2.Read()) // Tant qu'il y a des lignes à lire
                {

                    //On ajouter les trois colonnes de la ligne lue
                    dataGridView2.Rows.Add(resultat2[0], resultat2[1] + " $", resultat2[2]);
                }
            }
            else
                MessageBox.Show("La table TarifsSalles est vide.");
            resultat2.Close();



        }

        private void Tarif_Click(object sender, EventArgs e)
        {

        }
    }
}
