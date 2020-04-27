using System;

namespace IPCours07_DemoFonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnPremierTest();

            UnDeuxiemeTest();
        }

        public static void UnDeuxiemeTest()
        {
            int min = Fonctions.CalculerValeurMaximum(13, 42);

            Console.Out.WriteLine(min);

            Console.Out.WriteLine(Fonctions.CalculerValeurMaximum(23, 56));
        }

        public static void UnPremierTest()
        {
            Fonctions.AfficherLigneMotifs(6, '@');
            Fonctions.AfficherLigneMotifs(12, '#');
            Fonctions.AfficherLigneMotifs(1, '?');


        }
    }
}
