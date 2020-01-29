# Module 09 - Listes et structures

## Exercice 1 - Listes

1. Écrivez la fonction « SaisirValeursEntieres » qui permet de saisir une liste d’entiers et qui la renvoie. L’utilisateur arrête la saisie dès qu’il rentre un nombre négatif
2. Écrivez la fonction « RechercherMinimum » qui prend une liste d’entiers en paramètres et qui renvoie le minimum
3. Écrivez la fonction « RechercherMaximum » qui prend une liste d’entiers en paramètres et qui renvoie le maximum
4. Écrivez la fonction « CalculerMoyenne » qui prend une liste d’entiers en paramètres et qui renvoie la moyenne
5. Écrivez le sous-programme « SaisirValeursEntieresEtAfficherStatistiques » qui saisit une liste d’entiers, calcule le minimum, le maximum et la moyenne et les affiche.

## Exercice 2 - Étudiants

1. Un étudiant contient les champs suivants :
a. Nom
b. Prénom
c. Numéro de matricule
2. Écrivez la structure « Etudiant » qui permet de représenter un étudiant :
3. Écrivez la fonction « SaisirEtudiant » qui saisit un étudiant au clavier et le renvoie.
4. Écrivez la fonction « AfficherEtudiant » qui affiche un étudiant sur l’écran.
5. À partir des fonctions écrites précédemment, écrivez le sous-programme « SaisirEtAfficherUnEtudiant » qui saisit et affiche un étudiant.

## Exercice 3 - Facture

Le but de l’exercice est de réaliser un système de saisies de factures.
L’utilisateur doit débuter par la création d’une facture. Il doit ensuite pouvoir ajouter un nombre d’articles arbitraire. Il peut à tout moment demander au programme de calculer les totaux et les taxes. Il peut aussi afficher la facture.
Afin de vous aider, suivez les étapes suivantes :

1. Écrivez les structures permettant de représenter une facture :
    1. Une facture contient :
        1. Une liste de lignes de facture
        2. Un sous-total
        3. Un montant de taxes
        4. Un total avec taxes
    2. Une ligne de facture contient :
        1. Une description d’article
        2. Une quantité
        3. Un prix unitaire
2. Écrivez une fonction qui permet de créer une facture vide (sommes à zéro, liste de lignes de facture vide)
3. Écrivez une fonction qui permet de saisir un article avec sa quantité, sa description et son prix unitaire
4. Écrivez une fonction qui permet d’ajouter des articles à une facture
5. Écrivez une fonction qui permet de calculer le sous-total, les taxes et le total de la facture
6. Écrivez une fonction qui permet d’afficher une facture avec la liste des articles, le sous-total, le total.
7. En utilisant les fonctions précédentes, écrivez une fonction qui permet d’afficher un menu permettant de choisir les options suivantes:
    1. De créer une nouvelle facture
    2. D’ajouter un article à la facture (N’oubliez pas de mettre à jour les calculs)
    3. De calculer le total de la facture
    4. D’afficher une facture
    5. Quitter le programme
