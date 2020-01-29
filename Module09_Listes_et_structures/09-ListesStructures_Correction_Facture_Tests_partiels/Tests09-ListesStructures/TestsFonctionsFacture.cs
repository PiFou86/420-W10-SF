using _09_ListesStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests09_ListesStructures
{
    public class TestsFonctionsFacture
    {
         // Exemple des tests sur la facture (non complets)

        [Fact]
        public void CreerFacture_Creation_FactureVide() // seul cas de tests possible pour le créer
        {
            // Arranger
            decimal sousTotalAttendu = 0.0m;
            decimal taxesAttendues = 0.0m;
            decimal totalAttendu = 0.0m;
            int nombreLignesFactureAttendues = 0;

            // Agir 
            Facture facture = FonctionsFacture.CreerFacture();

            // Auditer
            Assert.Equal(sousTotalAttendu, facture.SousTotal);
            Assert.Equal(taxesAttendues, facture.Taxes);
            Assert.Equal(totalAttendu, facture.Total);
            Assert.True(facture.EstCalculee);
            Assert.NotNull(facture.LignesFacture);
            Assert.Equal(nombreLignesFactureAttendues, facture.LignesFacture.Count);
        }

        [Fact]
        public void CalculerTotalFacture_FactureVide_MontantsAZero()
        {
            // Arranger
            decimal sousTotalAttendu = 0.0m;
            decimal taxesAttendues = 0.0m;
            decimal totalAttendu = 0.0m;
            int nombreLignesFactureAttendues = 0;
            Facture facture = FonctionsFacture.CreerFacture();

            // Agir 
            FonctionsFacture.CalculerTotalFacture(facture);

            // Auditer
            Assert.Equal(sousTotalAttendu, facture.SousTotal);
            Assert.Equal(taxesAttendues, facture.Taxes);
            Assert.Equal(totalAttendu, facture.Total);
            Assert.True(facture.EstCalculee);
            Assert.NotNull(facture.LignesFacture);
            Assert.Equal(nombreLignesFactureAttendues, facture.LignesFacture.Count);
        }

        [Fact]
        public void CalculerTotalFacture_FactureDeuxElements_MontantsBiensCalcules()
        {
            // Arranger
            decimal sousTotalAttendu = 15.5m;
            decimal taxesAttendues = 2.32m;
            decimal totalAttendu = 17.82m;
            int nombreLignesFactureAttendues = 1;
            Facture facture = FonctionsFacture.CreerFacture();
            LigneFacture ligneFacture1 = new LigneFacture();
            ligneFacture1.Description = "foo";
            ligneFacture1.PrixUnitaire = 1.55m;
            ligneFacture1.Quantite = 10;
            FonctionsFacture.AjouterLigneFacture(facture, ligneFacture1);

            // Agir 
            FonctionsFacture.CalculerTotalFacture(facture);

            // Auditer
            Assert.Equal(sousTotalAttendu, facture.SousTotal);
            Assert.Equal(taxesAttendues, facture.Taxes, 2);
            Assert.Equal(totalAttendu, facture.Total, 2);
            Assert.True(facture.EstCalculee);
            Assert.NotNull(facture.LignesFacture);
            Assert.Equal(nombreLignesFactureAttendues, facture.LignesFacture.Count);
        }
    }
}
