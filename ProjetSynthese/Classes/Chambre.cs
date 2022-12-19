using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Chambre(string p_num_reservation = "xx", int p_prix = 0, string p_type = "type", bool p_status = false)
            :base(p_num_reservation, p_prix)
        {
            this.Type = p_type;
            this.Status = p_status;
        }

    }
}
