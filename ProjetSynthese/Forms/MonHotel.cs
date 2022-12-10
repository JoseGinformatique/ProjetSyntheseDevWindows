using ProjetSynthese.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSynthese
{
    public partial class MonHotel : Form
    {
        public MonHotel()
        {
            InitializeComponent();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConClient formulaire = new ConClient(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
        }

        private void TarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarifs formulaire = new Tarifs(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant

        }

        private void MonHotel_Load(object sender, EventArgs e)
        {

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConAdmin formulaire = new ConAdmin(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
        }
    }
}
