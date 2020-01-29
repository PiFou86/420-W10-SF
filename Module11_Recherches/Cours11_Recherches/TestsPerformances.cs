using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Cours11_Recherches
{
    public class TestsPerformances
    {
        public static void EffectuerTests(int p_facteurMax)
        {
            int nbTests = 7;

            using (System.IO.TextWriter csvtw = new System.IO.StreamWriter("temps.csv"))
            {
                using (System.IO.TextWriter tw = new System.IO.StreamWriter("temps.txt"))
                {
                    csvtw.WriteLine($"nbDonnees,Recherche standard,Recherche dichotomique");
                    tw.WriteLine($"#nbDonnees\tRecherche standard\tRecherche dichotomique");
                    for (int j = 1; j <= p_facteurMax; j++)
                    {
                        List<long> mesureTicksRechercheStandard = new List<long>();
                        List<long> mesureTicksRechercheDichotomique = new List<long>();
                        int nbDonnees = (int)Math.Pow(2, j) * 10_000;
                        for (int i = 1; i <= nbTests; i++)
                        {
                            int[] tableauOuChercher = CreerTableauAleatoire(nbDonnees);
                            int valeurAChercher = tableauOuChercher[tableauOuChercher.Length - 1];
                            Array.Sort(tableauOuChercher);

                            Stopwatch sw = Stopwatch.StartNew();
                            bool trouvee = Fonctions.RechercherValeurOptimisee(tableauOuChercher, valeurAChercher);
                            sw.Stop();
                            long ticksRechercheStandard = sw.ElapsedTicks;
                            mesureTicksRechercheStandard.Add(ticksRechercheStandard);

                            sw = Stopwatch.StartNew();
                            trouvee = Fonctions.RechercherValeurDichotomie(tableauOuChercher, valeurAChercher);
                            sw.Stop();
                            long ticksRechercheDichotomique = sw.ElapsedTicks;
                            mesureTicksRechercheDichotomique.Add(ticksRechercheDichotomique);
                        }

                        mesureTicksRechercheStandard.Sort();
                        mesureTicksRechercheStandard = mesureTicksRechercheStandard.Skip(2).Take(3).ToList();
                        mesureTicksRechercheDichotomique.Sort();
                        mesureTicksRechercheDichotomique = mesureTicksRechercheDichotomique.Skip(2).Take(3).ToList();

                        tw.WriteLine($"{nbDonnees}\t{(int)mesureTicksRechercheStandard.Average()}\t{(int)mesureTicksRechercheDichotomique.Average()}");
                        csvtw.WriteLine($"{nbDonnees},{(int)mesureTicksRechercheStandard.Average()},{(int)mesureTicksRechercheDichotomique.Average()}");
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
