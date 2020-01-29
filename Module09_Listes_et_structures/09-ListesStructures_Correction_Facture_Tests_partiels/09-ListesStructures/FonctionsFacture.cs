using System;
using System.Collections.Generic;
using System.Text;

namespace _09_ListesStructures
{
    public class FonctionsFacture
    {
        public static void ProgrammePrincipalFacture()
        {
            Facture factureCourante = null;
            AfficherMenuFacture();
            int choixMenu = SaisirOptionMenuFacture();

            while (choixMenu != 5)
            {
                switch (choixMenu)
                {
                    case 1:
                        factureCourante = CreerFacture();
                        break;
                    case 2:
                        if (factureCourante != null)
                        {
                            SaisirAjouterArticleFacture(factureCourante);
                        }
                        else
                        {
                            Console.Error.WriteLine("Impossible d'ajouter un article, il n'y a pas de facture !");
                        }
                        break;
                    case 3:
                        if (factureCourante != null)
                        {
                            CalculerTotalFacture(factureCourante);
                        }
                        else
                        {
                            Console.Error.WriteLine("Impossible de calculer la facture, il n'y a pas de facture !");
                        }
                        break;
                    case 4:
                        if (factureCourante != null)
                        {
                            if (!factureCourante.EstCalculee)
                            {
                                CalculerTotalFacture(factureCourante);
                            }
                            AfficherFacture(factureCourante);
                        }
                        else
                        {
                            Console.Error.WriteLine("Impossible d'afficher la facture, il n'y a pas de facture !");
                        }
                        break;
                    default:
                        break;
                }

                AfficherMenuFacture();
                choixMenu = SaisirOptionMenuFacture();
            }

        }

        public static void AfficherFacture(Facture p_factureCourante)
        {
            if (p_factureCourante == null)
            {
                throw new ArgumentNullException("Le paramètre ne doit pas être nul.", "p_factureCourante");
            }

            Console.Out.WriteLine("Facture :");
            Console.Out.WriteLine("---------");
            Console.Out.WriteLine("Description".PadRight(15) + "Quantité".PadLeft(10) + "PU".PadLeft(17));
            LigneFacture ligneFacture = null;
            for (int i = 0; i < p_factureCourante.LignesFacture.Count; i++)
            {
                ligneFacture = p_factureCourante.LignesFacture[i];
                Console.Out.WriteLine(
                      ligneFacture.Description.PadRight(15) 
                    + ligneFacture.Quantite.ToString().PadLeft(10)
                    + "  "
                    + ligneFacture.PrixUnitaire.ToString("C").PadLeft(15)
                    );
            }

            Console.Out.WriteLine("---------");
            Console.Out.WriteLine("Sous-Total : " + p_factureCourante.SousTotal.ToString("C"));
            Console.Out.WriteLine("Taxes :      " + p_factureCourante.Taxes.ToString("C"));
            Console.Out.WriteLine("Total :      " + p_factureCourante.Total.ToString("C"));
            Console.Out.WriteLine();

        }

        public static void CalculerTotalFacture(Facture p_factureCourante)
        {
            if (p_factureCourante == null)
            {
                throw new ArgumentNullException("Le paramètre ne doit pas être nul.", "p_factureCourante");
            }

            decimal sousTotal = 0.0m;
            LigneFacture ligneFacture = null;
            for (int i = 0; i < p_factureCourante.LignesFacture.Count; i++)
            {
                ligneFacture = p_factureCourante.LignesFacture[i];
                sousTotal = sousTotal + ligneFacture.Quantite * ligneFacture.PrixUnitaire;
            }

            p_factureCourante.SousTotal = sousTotal;
            p_factureCourante.Taxes = p_factureCourante.SousTotal * .15m;
            p_factureCourante.Total = p_factureCourante.SousTotal + p_factureCourante.Taxes;

            p_factureCourante.EstCalculee = true;
        }

        public static void SaisirAjouterArticleFacture(Facture p_factureCourante)
        {
            if (p_factureCourante == null)
            {
                throw new ArgumentNullException("Le paramètre ne doit pas être nul.", "factureCourante");
            }

            LigneFacture ligneFacture = SaisirLigneFacture();
            AjouterLigneFacture(p_factureCourante, ligneFacture);
        }

        public static void AjouterLigneFacture(Facture p_factureCourante, LigneFacture p_ligneFacture)
        {
            if (p_factureCourante == null)
            {
                throw new ArgumentNullException("Le paramètre ne doit pas être nul.", "p_factureCourante");
            }
            if (p_ligneFacture == null)
            {
                throw new ArgumentNullException("Le paramètre ne doit pas être nul.", "p_ligneFacture");
            }

            p_factureCourante.EstCalculee = false;
            p_factureCourante.LignesFacture.Add(p_ligneFacture);
        }

        public static LigneFacture SaisirLigneFacture()
        {
            LigneFacture ligneFacture = new LigneFacture();

            Console.Out.Write("Entrez le description : ");
            do
            {
                Console.Out.Write("? ");
                ligneFacture.Description = Console.In.ReadLine();
            } while (string.IsNullOrEmpty(ligneFacture.Description));

            Console.Out.Write("Entrez la quantité : ");
            do
            {
                Console.Out.Write("? ");
                ligneFacture.Quantite = Console.In.ReadInt();
            } while (ligneFacture.Quantite <= 0);

            Console.Out.Write("Entrez le prix unitaire : ");
            do
            {
                Console.Out.Write("? ");
                ligneFacture.PrixUnitaire = Console.In.ReadDecimal();
            } while (ligneFacture.PrixUnitaire < 0);

            return ligneFacture;
        }

        public static Facture CreerFacture()
        {
            Facture facture = new Facture();

            facture.LignesFacture = new List<LigneFacture>();
            facture.SousTotal = 0;
            facture.Taxes = 0;
            facture.Total = 0;
            facture.EstCalculee = true;

            return facture;
        }

        public static int SaisirOptionMenuFacture()
        {
            int choix = 0;
            do
            {
                Console.Write("? ");
                choix = Console.In.ReadInt();

            } while (choix < 1 || choix > 5);

            return choix;
        }

        public static void AfficherMenuFacture()
        {
            Console.Out.WriteLine("1. Créer une facture");
            Console.Out.WriteLine("2. Ajouter un article");
            Console.Out.WriteLine("3. Calculer total facture");
            Console.Out.WriteLine("4. Afficher la facture");
            Console.Out.WriteLine("5. Quitter");
        }
    }
}
