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

        public Salle(string p_num_reservation = "xx", int p_prix = 100, string p_nom = "xx", bool p_status = false)
            : base(p_num_reservation, p_prix)
        {
            this.Nom = p_nom;
            this.Status = p_status;
            
        }
    }
}
