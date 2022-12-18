using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public class Salle: Reservation
    {
        private string nom;
        private bool status;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Salle(int p_num_reservation, int p_prix, string p_nom, bool p_status)
            : base(p_num_reservation, p_prix)
        {
            this.Nom = p_nom;
            this.Status = p_status;
            
        }
    }
}
