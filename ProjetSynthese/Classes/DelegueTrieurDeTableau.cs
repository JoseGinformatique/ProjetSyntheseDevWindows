using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*/
 * Titre: Projet Synthese
 * Fait par: Jose Luis Gutierrez
 * # etd: 2146130
 * 
 * CE CODE CONTIENS DES PARTIES DE CODE INSPIRÉES PAR
 * 
 *****  Hasna Hocini  ***** (SOLUTIONNAIRE "GestElection")
 *
 ***** www.w3schools.blog *******
 *
 */

namespace ProjetSynthese
{
    public class DelegueTrieurDeTableau
    {
        /// <summary>
        /// delegué de tri de tableaux
        /// </summary>
        /// <param name="tableau"></param>
        private delegate void DelegateTri(int[] tableau);

        /// <summary>
        /// Tri ascendant
        /// </summary>
        /// <param name="tableau">array</param>
        private void TriAscendant(int[] tableau)
        {
            Array.Sort(tableau);
        }
        /// <summary>
        /// Tri descendant
        /// </summary>
        /// <param name="tableau">array</param>
        private void TriDescendant(int[] tableau)
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }
    }
}
