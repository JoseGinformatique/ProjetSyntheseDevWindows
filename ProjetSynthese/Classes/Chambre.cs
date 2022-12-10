using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    internal class Chambre: Reservation
    {
        private string type;
        private int duree;
        private bool status;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Duree
        {
            get { return duree; }
            set { duree = value; }  
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Chambre(int p_num_reservation, int p_prix, string p_type, int p_duree, bool p_status)
            :base(p_num_reservation, p_prix)
        {
            this.Type = p_type;
            this.Duree = p_duree;
            this.Status = p_status;
        }
    }
}
