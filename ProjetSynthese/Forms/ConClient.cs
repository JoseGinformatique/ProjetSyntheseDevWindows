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
            NouveauClient formulaire = new NouveauClient(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            this.Close();
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            labelErrMdp.Text = string.Empty;
            bool b_num, b_ver;
            b_ver = false;
            b_num = Static_Autentification.VerifierRegex("^[0-9]{6}$", Numero_client, labelErrNum, "Votre numero doit être un chiffre à 6 caractères");

            if (b_num)
            {
                foreach (Client cl in Static_Autentification.LsClients)
                {
                    if (b_num && Int32.Parse(Numero_client.Text) == cl.Num_client && MotDePasse.Text == cl.Mot_de_passe)
                    {

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
            if (!b_ver && b_num) 
            {
                labelErrMdp.ForeColor= Color.Red;
                labelErrMdp.Text = "Aucun utilisateur n'a été trouvé avec ce numéro ou le mot de passe ne correspond pas";
            }
        }
    }
}
