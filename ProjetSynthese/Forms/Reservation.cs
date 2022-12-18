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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxRes.Text != "Cliquez pour derrouler les options")
            {
                if (comboBoxRes.Text == "Chambre: Suite" || comboBoxRes.Text ==  "Chambre: Régulière")
                {
                    Chambre ch;
                    
                }
            }
            MessageBox.Show("Voici votre facture \n" + c.ToString() + "\n\nMerci d'avoir fait affaire avec Hotel Jose!");
            this.Close(); 
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
    }
}
