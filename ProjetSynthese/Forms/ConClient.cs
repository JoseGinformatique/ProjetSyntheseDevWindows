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

        }

        private void Nouveau_client_Click(object sender, EventArgs e)
        {
            // Ouvrir le fomulaire pour créer un nouveau client
            NouveauClient formulaire = new NouveauClient(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            this.Close();
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            // verification du numero de client par un regex
            labelErrMdp.Text = string.Empty;
            bool b_num, b_ver;
            b_ver = false;
            b_num = Static_Autentification.VerifierRegex("^[0-9]{6}$", Numero_client, labelErrNum, "Votre numero doit être un chiffre à 6 caractères");

            if (b_num) // si le numero respecte le regex
            {
                // passer à travers la liste des clients pour trouver le bon compte
                foreach (Client cl in Static_Autentification.LsClients)
                {
                    if (b_num && Int32.Parse(Numero_client.Text) == cl.Num_client && MotDePasse.Text == cl.Mot_de_passe)
                    {
                        // ouvrir le formulaire pour reserver
                        b_ver = true;
                        Reservation formulaire = new Reservation(); // Création d'une instance 
                        formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
                        formulaire.Resclient(cl);
                        formulaire.Show(); // affichage du formulaire enfantà
                        
                        this.Close();
                        break;
                    }
                }
            }
            // si la boucle n'a pas trouvé le compte et que le regex est bon
            if (!b_ver && b_num) 
            {
                labelErrMdp.ForeColor= Color.Red;
                labelErrMdp.Text = "Aucun utilisateur n'a été trouvé avec ce numéro ou le mot de passe ne correspond pas";
            }
        }
    }
}
