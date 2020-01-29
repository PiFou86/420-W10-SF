using System;
using System.Collections.Generic;
using System.Text;

namespace _09_ListesStructures
{
    public class FonctionsListesEntiers
    {
        public static void SaisirValeursEntieresEtAfficherStatistiques()
        {
            List<int> listeEntiers = null;
            int minimum = 0;
            int maximum = 0;
            decimal moyenne = 0.0m;

            Console.Out.WriteLine("Veuillez entrer des entiers positifs (un négatif pour arrêter la saisie) : ");
            listeEntiers = SaisirListeEntiersPositifs();
            minimum = RechercherMinimum(listeEntiers);
            maximum = RechercherMaximum(listeEntiers);
            moyenne = CalculerMoyenne(listeEntiers);

            Console.Out.WriteLine("Minimum : " + minimum.ToString());
            Console.Out.WriteLine("Maximum : " + maximum.ToString());
            Console.Out.WriteLine("Moyenne : " + moyenne.ToString());
        }

        public static void AfficherListe(List<int> p_listeValeurs)
        {
            if (p_listeValeurs == null)
            {
                throw new ArgumentNullException("Le paramètre ne doit pas être nul.", "p_listeValeurs");
            }

            Console.Out.Write(p_listeValeurs[0]);
            for (int i = 1; i < p_listeValeurs.Count; i++)
            {
                Console.Out.Write(", " + p_listeValeurs[i]);
            }
        }

        public static List<int> SaisirListeEntiersPositifs()
        {
            List<int> listeEntiers = new List<int>();
            int valeurSaisie = Console.In.ReadInt();

            while (valeurSaisie >= 0)
            {
                listeEntiers.Add(valeurSaisie);
            }

            return listeEntiers;
        }

        public static int RechercherMinimum(List<int> p_listeValeurs)
        {
            if (p_listeValeurs == null)
            {
                throw new ArgumentNullException("p_listeValeurs");
            }
            if (p_listeValeurs.Count == 0)
            {
                throw new ArgumentException("La liste ne doit pas être vide !", "p_listeValeurs");
            }

            int minimum = p_listeValeurs[0];

            for (int indiceValeur = 1; indiceValeur < p_listeValeurs.Count; indiceValeur++)
            {
                if (minimum > p_listeValeurs[indiceValeur])
                {
                    minimum = p_listeValeurs[indiceValeur];
                }
            }

            return minimum;
        }

        public static int RechercherMaximum(List<int> p_listeValeurs)
        {
            if (p_listeValeurs == null)
            {
                throw new ArgumentNullException("p_listeValeurs");
            }
            if (p_listeValeurs.Count == 0)
            {
                throw new ArgumentException("La liste ne doit pas être vide !", "p_listeValeurs");
            }

            int maximum = p_listeValeurs[0];

            for (int indiceValeur = 1; indiceValeur < p_listeValeurs.Count; indiceValeur++)
            {
                if (maximum < p_listeValeurs[indiceValeur])
                {
                    maximum = p_listeValeurs[indiceValeur];
                }
            }

            return maximum;
        }

        public static decimal CalculerMoyenne(List<int> p_listeValeurs)
        {
            if (p_listeValeurs == null)
            {
                throw new ArgumentNullException("p_listeValeurs");
            }

            if (p_listeValeurs.Count == 0)
            {
                throw new ArgumentException("La liste ne doit pas être vide !", "p_listeValeurs");
            }

            decimal somme = 0.0m;

            for (int indiceValeur = 0; indiceValeur < p_listeValeurs.Count; indiceValeur++)
            {
                somme += p_listeValeurs[indiceValeur];
            }

            return somme / p_listeValeurs.Count;
        }
    }
}
