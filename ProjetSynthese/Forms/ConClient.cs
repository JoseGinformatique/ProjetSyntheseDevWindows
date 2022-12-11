﻿using System;
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
            Reservation formulaire = new Reservation(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            this.Close();
        }
    }
}
