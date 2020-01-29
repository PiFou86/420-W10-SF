using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTestsUnitaires
{
    public class Fonctions
    {
        // Fonctions boggées
        public static int CalculerMinimum(int[] p_valeurs)
        {
            if (p_valeurs == null)
            {
                throw new ArgumentException("Le paramètre ne doit pas être nul.", "p_valeurs");
            }

            if (p_valeurs.Length == 0)
            {
                throw new ArgumentException("Le paramètre doit être un tableau non vide.", "p_valeurs");
            }

            int minimum = p_valeurs[0];

            // ..

            return minimum;
        }

        // Fonctions boggées
        public static int[] CopierTableau(int[] p_valeurs)
        {
            return p_valeurs;
        }
    }
}
