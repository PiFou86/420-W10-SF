using System;
using System.Collections.Generic;
using System.Text;

namespace IP_Module09_Listes_Structures
{
    public class Fonctions
    {
        public static void DemoListes()
        {
            List<decimal> notesEtudiants = new List<decimal>();
            decimal noteSaisie = 0.0m;

            do
            {
                noteSaisie = Console.In.ReadDecimal();

                if (noteSaisie >= 0)
                {
                    notesEtudiants.Add(noteSaisie);
                }
            } while (noteSaisie >= 0);


            for (int numeroNote = 0; numeroNote < notesEtudiants.Count; numeroNote++)
            {
                Console.Out.WriteLine("La note " + (numeroNote + 1).ToString() + " est : " + notesEtudiants[numeroNote].ToString());
            }

        } 

        public static void DemoStructure()
        {
            Point a = new Point();
            a.X = 42;
            a.Y = 23;

            //AfficherPoint(a);

            List<Point> polygone = new List<Point>();
            polygone.Add(a);
            polygone.Add(new Point() { X = 12, Y = 42 });
            polygone.Add(new Point() { X = 23, Y = 52 });


            for (int numeroPoint = 0; numeroPoint < polygone.Count; numeroPoint++)
            {
                AfficherPoint(polygone[numeroPoint]);
            }

            List<Point> carre = new List<Point>();
            carre.Add(new Point() { X = 2, Y = 2 });
            carre.Add(new Point() { X = 2, Y = 0 });
            carre.Add(new Point() { X = 0, Y = 0 });
            carre.Add(new Point() { X = 0, Y = 2 });

            Point barycentre = CalculerBarycentre(carre);

            AfficherPolygone(carre);
            AfficherPoint(barycentre);

        }

        public static Point CalculerBarycentre(List<Point> p_polygone)
        {
            if (p_polygone == null)
            {
                throw new ArgumentNullException(nameof(p_polygone));
            }
            if (p_polygone.Count < 3)
            {
                throw new ArgumentException("Le polygone doit avoir au moins 3 points", nameof(p_polygone));
            }

            Point barycentre = new Point();

            for (int numeroPoint = 0; numeroPoint < p_polygone.Count; numeroPoint++)
            {
                barycentre.X += p_polygone[numeroPoint].X;
                barycentre.Y += p_polygone[numeroPoint].Y;
            }

            barycentre.X /= p_polygone.Count;
            barycentre.Y /= p_polygone.Count;

            return barycentre;
        }

        public static void AfficherPolygone(List<Point> p_polygone)
        {
            if (p_polygone == null)
            {
                throw new ArgumentNullException(nameof(p_polygone));
            }
            if (p_polygone.Count < 3)
            {
                throw new ArgumentException("Le polygone doit avoir au moins 3 points", nameof(p_polygone));
            }

            Console.Out.WriteLine("Polygone :");
            for (int numeroPoint = 0; numeroPoint < p_polygone.Count; numeroPoint++)
            {
                AfficherPoint(p_polygone[numeroPoint]);
            }
            Console.Out.WriteLine();
        }

        public static void AfficherPoint(Point p_point)
        {
            Console.Out.WriteLine("Point(" + p_point.X + ", " + p_point.Y + ")");
        } 
    }
}
