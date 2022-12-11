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
    public partial class ModifClient : Form
    {
        public ModifClient()
        {
            InitializeComponent();
        }

        private void ModifClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NouveauClient formulaire = new NouveauClient(); // Création d'une instance 
            formulaire.MdiParent = this.MdiParent; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            
        }
    }
}
