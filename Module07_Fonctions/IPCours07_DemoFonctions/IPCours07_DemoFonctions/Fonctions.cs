using System;
using System.Collections.Generic;
using System.Text;

namespace IPCours07_DemoFonctions
{
    public class Fonctions
    {
        public static void AfficherLigneMotifs(int p_largeur, char p_motif)
        {
            if (p_largeur < 1)
            {
                throw new ArgumentException("La largeur n'est pas correcte.", nameof(p_largeur));
            }

            for (int colonne = 1; colonne <= p_largeur; colonne++)
            {
                Console.Out.Write(p_motif);
            }
            Console.Out.WriteLine();
        }

        public static int CalculerValeurMaximum(int p_valeur1, int p_valeur2)
        {
            int resultat = p_valeur1;

            if (p_valeur2 > resultat)
            {
                resultat = p_valeur2;
            }

            return resultat;
        }
    }
}
