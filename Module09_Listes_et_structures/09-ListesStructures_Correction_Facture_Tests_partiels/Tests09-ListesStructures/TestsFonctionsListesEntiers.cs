using _09_ListesStructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Tests09_ListesStructures
{
    public class TestsFonctionsListesEntiers
    {
        [Fact]
        public void RechercherMinimum_ListeNull_Exception()
        {
            // Arranger
            List<int> listeValeurs = null;

            // Agir & Auditer
            Assert.Throws<ArgumentNullException>(() => {
                FonctionsListesEntiers.RechercherMinimum(listeValeurs); 
            });
        }

        [Fact]
        public void RechercherMinimum_ListeVide_Exception()
        {
            // Arranger
            List<int> listeValeurs = new List<int>();

            // Agir & Auditer
            Assert.Throws<ArgumentException>(() => {
                FonctionsListesEntiers.RechercherMinimum(listeValeurs);
            });
        }

        [Fact]
        public void RechercherMinimum_ListeUnElement_Exception()
        {
            // Arranger
            List<int> listeValeurs = new List<int>() { 42 };
            int valeurAttendue = 42;

            // Agir
            int valeurCalculee = FonctionsListesEntiers.RechercherMinimum(listeValeurs);

            // Auditer
            Assert.Equal(valeurAttendue, valeurCalculee);
        }

        [Fact]
        public void RechercherMinimum_ListeDeuxElements_PremiereValeur()
        {
            // Arranger
            List<int> listeValeurs = new List<int>() { 24, 42 };
            int valeurAttendue = 24;

            // Agir
            int valeurCalculee = FonctionsListesEntiers.RechercherMinimum(listeValeurs);

            // Auditer
            Assert.Equal(valeurAttendue, valeurCalculee);
        }

        [Fact]
        public void RechercherMinimum_ListeDeuxElements_DerniereValeur()
        {
            // Arranger
            List<int> listeValeurs = new List<int>() { 42, 24 };
            int valeurAttendue = 24;

            // Agir
            int valeurCalculee = FonctionsListesEntiers.RechercherMinimum(listeValeurs);

            // Auditer
            Assert.Equal(valeurAttendue, valeurCalculee);
        }

        [Fact]
        public void RechercherMinimum_ListeTroisElementsDontUneNegative_ValeurNegative()
        {
            // Arranger
            List<int> listeValeurs = new List<int>() { 42, -42, 24 };
            int valeurAttendue = -42;

            // Agir
            int valeurCalculee = FonctionsListesEntiers.RechercherMinimum(listeValeurs);

            // Auditer
            Assert.Equal(valeurAttendue, valeurCalculee);
        }

        [Fact]
        public void AfficherListe_DeuxElements_AffichageOk()
        {
            StringBuilder sb = new StringBuilder();
            List<int> listeAAfficher = new List<int>() { 13, 42 };
            string affichageAttendu = "13, 42";

            using (StringWriter sw = new StringWriter(sb))
            {
                // Arranger
                Console.SetOut(sw);
                TextWriter ancienOut = Console.Out;

                // Agir
                FonctionsListesEntiers.AfficherListe(listeAAfficher);

                Console.SetOut(ancienOut);

                // Auditer
                Assert.Equal(affichageAttendu, sb.ToString());
            }
        }
    }
}
