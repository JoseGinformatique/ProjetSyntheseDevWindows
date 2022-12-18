using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public class Chambre: Reservation
    {
        private string type;
        private bool status;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Chambre(int p_num_reservation, int p_prix, string p_type, bool p_status)
            :base(p_num_reservation, p_prix)
        {
            this.Type = p_type;
            this.Status = p_status;
        }
    }
}
