# Module 10 - Tris

Posez-vous toujours les questions suivantes :

- Ai-je besoin d’autres fonctions que celles demandées ?
- Quels sont les tests que je peux faire ?
- Y a-t-il des préconditions ?

## Exercice 1 - Mise en place du projet

1. Ouvrez la solution « Cours10_Tris »
2. Codez la fonction « CopierTableau » qui copie un tableau passé en paramètres
3. Codez la fonction « EstTableauTrie » qui valide qu’un tableau passé en paramètres est trié en ordre croissant. Elle renvoie vrai si c’est la cas, faux sinon.
4. Écrivez les tests unitaires pour les fonctions « CopierTableau » et « EstTableauTrie »

## Exercice 2 - Tri à bulles

1. Codez la fonction « TriBulles » en traduisant l’algorithme donné en cours.
2. Ajoutez les préconditions si nécessaire
3. Écrivez les tests unitaires pour cette fonction

## Exercice 3 - Tri rapide

1. Codez les fonctions « TriRapide », « TriRapide_rec », « Partition » et « ChoixPivot) en traduisant les algorithmes donnés en cours.
2. Ajoutez les préconditions si nécessaire
3. Écrivez les tests unitaires pour la fonction « TriRapide »

## Exercice 4 - Comparer les algorithmes – Excel

1. Lancez le programme principal si cela n’avait pas été déjà fait
2. Récupérez le fichier « temps.csv » qui se trouve dans le répertoire de l’application compilée (sous-répertoire bin suivi de la plateforme cible)
3. Ouvrez le fichier avec Excel
4. Si les données s’affichent sur une colonne
    1. Utilisez l’onglet « Données » et le menu « Convertir »
    2. Choisissez le type de données « Délimité »
    3. Cochez « Virgule » et « Terminer »
5. Faites un graphique de type « XY » ou « nuage de points » avec les trois colonnes :
    1. Sélectionnez une des courbes et faites « format de la courbe » et choisissez « Axe secondaire »
    2. Ajoutez une courbe de tendance de type puissance sur la courbe « Tri à bulles »
    3. Ajoutez une courbe de tendance de type puissance sur la courbe « Tri rapide »
    4. Pour ces trois derniers points, utilisez les documentations :
        1. [Gestion axe secondaire](https://support.office.com/fr-fr/article/ajouter-ou-supprimer-un-axe-secondaire-dans-un-graphique-à-partir-d-excel-91da1e2f-5db1-41e9-8908-e1a2e14dd5a9#OfficeVersion=Windows)
        2. [Ajout courbe de tendance](http://www.bernardcordier.com/excel_tendance.htm)
