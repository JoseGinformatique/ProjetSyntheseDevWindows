using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSynthese.Forms
{
    public partial class NouveauClient : Form
    {
        public NouveauClient()
        {
            InitializeComponent();
        }

        private void NouveauClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Client cl = new Client();
            VerifierTous(cl);

            Reservation formulaire = new Reservation(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            this.Close();
        }
        public int VerifierTous(Client cl)
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_motdepasse, b_nom, b_prenom, b_date;
            // instantiation d'un objet client pour chercher la méthode de calcul d'age

            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_nom = Static_Autentification.VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", textBoxNom, labelErrNom,
                "Première lettre en majuscules suivie de 1 à 20 lettres");
            b_prenom = Static_Autentification.VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", textBoxPrenom, labelErrPrenom,
                "Première lettre en majuscules suivie de 1 à 20 lettres");
            b_motdepasse = Static_Autentification.VerifierRegex("^(?=.*[0-9])(?=.*[a-zA-Z]).{8,10}$", textBoxmdp, labelErrMdp,
                "Le mot de passe doit comporter au moins un chiffre, une lettre et doit avoir entre 8 à 10 caractères");
            b_date = Static_Autentification.VerifierAge(cl.CalcAge(dateTimePicker1.Value), labelErrDate,
                "Il faut être agé d'au moins 18 ans pour faire une réservation");
            cl.Nom = textBoxNom.Text;
            cl.Prenom = textBoxPrenom.Text;
            cl.Mot_de_passe = textBoxmdp.Text;
            if (b_nom && b_prenom && b_motdepasse && b_date)
                return 1;
            else return 2; //Sinon retourner 2
        }
    }
}
