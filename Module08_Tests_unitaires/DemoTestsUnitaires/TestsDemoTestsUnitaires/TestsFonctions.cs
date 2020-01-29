using DemoTestsUnitaires;
using System;
using Xunit;

namespace TestsDemoTestsUnitaires
{
    public class TestsFonctions
    {
        [Fact]
        public void CalculerMinimum_TableauUnElement0_Zero()
        {
            // Arranger
            int[] tableau = new int[] { 0 };
            int valeurAttendue = 0;

            // Agir
            int valeurCalculee = Fonctions.CalculerMinimum(tableau);

            // Auditer
            Assert.Equal(valeurAttendue, valeurCalculee);
        }

        [Fact]
        public void CalculerMinimum_TableauUnElement42_42()
        {
            // Arranger
            int[] tableau = new int[] { 42 };
            int valeurAttendue = 42;

            // Agir
            int valeurCalculee = Fonctions.CalculerMinimum(tableau);

            // Auditer
            Assert.Equal(valeurAttendue, valeurCalculee);
        }

        [Fact]
        public void CalculerMinimum_TableauNull_Exception()
        {
            // Arranger
            int[] tableau = null;

            // Agir & auditer
            Assert.Throws<ArgumentException>(() =>
            {
                int valeurCalculee = Fonctions.CalculerMinimum(tableau);
            });
        }

        // Autres cas à écrire ...


        [Fact]
        public void CopierTableau_Tableau3Elements_TableauCopie()
        {
            // Arranger
            int[] tableauACopier = new int[] { 23, 42, -42 };
            int[] tableauAttendu = new int[] { 23, 42, -42 };

            // Agir
            int[] tableauCopie = Fonctions.CopierTableau(tableauACopier);

            // Auditer
            Assert.Equal(tableauAttendu, tableauCopie);   // Valider que les données sont les bonnes
            Assert.Equal(tableauAttendu, tableauACopier); // Valider qu'il n'a pas été modifié
            Assert.NotSame(tableauACopier, tableauCopie); // Valider que ce n'est pas la même référence donc une copie
        }

        // Autres cas à écrire ...

    }
}
