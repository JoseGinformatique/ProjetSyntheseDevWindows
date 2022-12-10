using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese
{
    public class DelegueTrieurDeTableau
    {
        private delegate void DelegateTri(int[] tableau);

        private void TriAscendant(int[] tableau)
        {
            Array.Sort(tableau);
        }
        private void TriDescendant(int[] tableau)
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }
    }
}
