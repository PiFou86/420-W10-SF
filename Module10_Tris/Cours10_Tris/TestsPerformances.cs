using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Cours10_Tris
{
    public class TestsPerformances
    {
        public static void EffectuerTests(int p_facteurMax)
        {
            int nbTests = 4;
            using (System.IO.TextWriter csvtw = new System.IO.StreamWriter("temps.csv"))
            {
                using (System.IO.TextWriter tw = new System.IO.StreamWriter("temps.txt"))
                {
                    csvtw.WriteLine($"nbDonnees,Tri a bulles,Tri rapide");
                    tw.WriteLine($"#nbDonnees\tTri a bulles\tTri rapide");
                    for (int j = 1; j <= p_facteurMax; j++)
                    {
                        List<long> mesureTicksTriRapide = new List<long>();
                        List<long> mesureTicksTriBulles = new List<long>();
                        int nbDonnees = (int)Math.Pow(2, j) * 100;
                        for (int i = 1; i <= nbTests; i++)
                        {
                            int[] tableauATrier = CreerTableauAleatoire(nbDonnees);

                            Stopwatch sw = Stopwatch.StartNew();
                            int[] tableauTrie = Fonctions.TriRapide(tableauATrier);
                            sw.Stop();
                            long ticksTriRapide = sw.ElapsedTicks;
                            mesureTicksTriRapide.Add(ticksTriRapide);
                            //if (!Fonctions.EstTableauTrie(tableauTrie))
                            //{
                            //    throw new Exception();
                            //}

                            sw = Stopwatch.StartNew();
                            tableauTrie = Fonctions.TriBulles(tableauATrier);
                            sw.Stop();
                            long ticksTriBulles = sw.ElapsedTicks;
                            mesureTicksTriBulles.Add(ticksTriBulles);
                            //if (!Fonctions.EstTableauTrie(tableauTrie))
                            //{
                            //    throw new Exception();
                            //}
                            mesureTicksTriBulles.Add(0);
                        }

                        mesureTicksTriBulles.Sort();
                        mesureTicksTriRapide.Sort();

                        tw.WriteLine($"{nbDonnees}\t{mesureTicksTriBulles[mesureTicksTriBulles.Count / 2]}\t{mesureTicksTriRapide[mesureTicksTriRapide.Count / 2]}");
                        csvtw.WriteLine($"{nbDonnees},{mesureTicksTriBulles[mesureTicksTriBulles.Count / 2]},{mesureTicksTriRapide[mesureTicksTriRapide.Count / 2]}");
                    }
                }
            }
        }

        private static int[] CreerTableauAleatoire(int p_capacite)
        {
            Random genererNombre = new Random(DateTime.Now.Millisecond);
            int[] valeursAleatoires = new int[p_capacite];

            for (int indiceValeur = 0; indiceValeur < valeursAleatoires.Length; indiceValeur++)
            {
                valeursAleatoires[indiceValeur] = genererNombre.Next();
            }

            return valeursAleatoires;
        }

        private static int[] CreerTableauAleatoire()
        {
            Random genererNombre = new Random(DateTime.Now.Millisecond);
            int capaciteTableau = genererNombre.Next(10, 201);

            return CreerTableauAleatoire(capaciteTableau);
        }
    }
}
