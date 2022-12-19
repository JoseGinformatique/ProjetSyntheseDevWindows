using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class ConAdmin : Form
    {
        public ConAdmin()
        {
            InitializeComponent();
        }

        private void ConAdmin_Load(object sender, EventArgs e)
        {

        }
        
        private void Connection_Click(object sender, EventArgs e)
        {
            //Verification du numero de l'adminstrateur avec un regex
            labelErrMdp.Text = string.Empty;
            bool b_num, b_ver;
            b_ver = false;
            b_num = Static_Autentification.VerifierRegex("^[0-9]{6}$", Numero_admin, labelErrNum, "Votre numero doit être un chiffre à 6 caractères");

            if (b_num)// si le regex est respecté
            {
                //passer à travers tous les admin pour trouver le bon compte
                foreach (Administrateur ad in Static_Autentification.LsAdmin)
                {
                    if (b_num && Int32.Parse(Numero_admin.Text) == ad.Num_admin && MotDePasse.Text == ad.Mot_de_passe)
                    {
                        // ouvrir le fomulaire pour faire la gestion des reservations
                        GereRes formulaire = new GereRes(); // Création d'une instance 
                        formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
                        formulaire.AdminSurPage(ad);
                        formulaire.Show(); // affichage du formulaire enfant

                        this.Close();

                        break;
                    }
                }
            }
            // si la boucle n'a pas trouvé le compte et que le regex est bon
            if (!b_ver && b_num)
            {
                labelErrMdp.ForeColor = Color.Red;
                labelErrMdp.Text = "Aucun Administrateur n'a été trouvé avec ce numero ou le mot de passe ne correspond pas";
            }
            
        }

        private void Numero_admin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
