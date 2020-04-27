using IP_Module09_Listes_Structures;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestsIP_Module09_Listes_Structures
{
    public class TestsFonctions
    {
        [Fact]
        public void CalculerBarycentre_CasCarreOrigine_CentreCarre()
        {
            // Arranger
            List<Point> carre = new List<Point>();
            carre.Add(new Point() { X = 2, Y = 2 });
            carre.Add(new Point() { X = 2, Y = 0 });
            carre.Add(new Point() { X = 0, Y = 0 });
            carre.Add(new Point() { X = 0, Y = 2 });
            Point barycentreAttendu = new Point() { X = 1, Y = 1 };

            // Agir
            Point barycentreCalcule = Fonctions.CalculerBarycentre(carre);

            // Assertion
            Assert.Equal(barycentreAttendu.X, barycentreCalcule.X);
            Assert.Equal(barycentreAttendu.Y, barycentreCalcule.Y);
        }
    }
}
