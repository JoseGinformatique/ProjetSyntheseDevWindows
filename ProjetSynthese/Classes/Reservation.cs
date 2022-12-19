using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public class Reservation
    {
        private string num_reservation;
        private int prix;

        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public string Num_Reservation
        {
            get { return num_reservation; }
            set { num_reservation = value; }
        }

        public Reservation(string p_num_reservation, int p_prix)
        {
            this.Num_Reservation = p_num_reservation;
            this.Prix = p_prix;
        }

        
    }
}
