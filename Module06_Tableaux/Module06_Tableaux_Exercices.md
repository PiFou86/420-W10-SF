# Module 06 - Tableaux

## Exercice 1 - Un premier tableau

Écrivez un algorithme qui :

- remplit un tableau de treize entiers avec les valeurs suivantes : 0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121 et 144
- affiche les treize valeurs sur la même ligne séparées par des espaces

<details>
    <summary>Proposition solution</summary>

``` csharp
entier[] valeurs = créer entier[13];

pour entier n de 0 à valeurs.Capacité - 1 {
    valeurs[n] = n * n;
}

écrire(valeurs[0]);
pour entier indiceValeur de 1 à valeurs.Capacité - 1 {
    écrire(" " + valeurs[indiceValeur].VersChaine());
}
```

</details>

## Exercice 2 - Moyenne d'un examen

Écrivez un algorithme qui :

- lit au clavier 10 résultats d'examen dans un tableau
- affiche la moyenne de ces 10 résultats

<details>
    <summary>Proposition solution</summary>

``` csharp
réel[] notes = créer réel[10];
réel note = 0.0;
réel sommeNotes = 0.0;
réel moyenneNotes = 0.0;

pour entier numeroNote de 0 à notes.Capacité - 1 {
    faire {
        écrire("Veuillez entrer la note " + numeroNote.VersChaine() + " : ");
        note = lire();
    } tant que (note < 0 ou note > 100);
    notes[numeroNote] = note;
}

pour entier numeroNote de 0 à notes.Capacité - 1 {
    sommeNotes = sommeNotes + notes[numeroNote];
}
moyenneNotes = sommeNotes / notes.Capacité;

écrire("La moyenne de ces " + notes.Capacité.VersChaine() + " notes est : " + moyenneNotes.VersChaine());
```

</details>

## Exercice 3 - Minimum et maximum d'un examen

Écrivez un algorithme qui :

- lit au clavier 10 résultats d'examen dans un tableau
- affiche le pire résultat et le meilleur résultat sur deux lignes séparées.

<details>
    <summary>Proposition solution</summary>

``` csharp
réel[] notes = créer réel[10];
réel note = 0.0;
réel plusPetiteNote = 0.0;
réel plusGrandeNote = 0.0;

pour entier numeroNote de 0 à notes.Capacité - 1 {
    faire {
        écrire("Veuillez entrer la note " + numeroNote.VersChaine() + " : ");
        note = lire();
    } tant que (note < 0 ou note > 100);
    notes[numeroNote] = note;
}

plusPetiteNote = notes[0];
plusGrandeNote = notes[0];
pour entier numeroNote de 1 à notes.Capacité - 1 {
    si (notes[numeroNote] < plusPetiteNote) {
        plusPetiteNote = notes[numeroNote]
    }
    si (notes[numeroNote] > plusGrandeNote) {
        plusGrandeNote = notes[numeroNote]
    }
}

écrireNL("Le pire résultat est " + plusPetiteNote.VersChaine() + " .");
écrireNL("Le meilleur résultat est " + plusGrandeNote.VersChaine() + " .");
```

</details>

## Exercice 4 - Moyennes de deux examens

Écrivez un algorithme qui :

- lit au clavier 5 résultats d'examen dans un tableau
- lit au clavier 5 résultats d'un autre examen dans un deuxième tableau
- calcule la moyenne de chaque étudiant dans un troisième tableau
- affiche les 5 moyennes sur des lignes différentes
- affiche la moyenne générale sur une autre ligne

<details>
    <summary>Proposition solution</summary>

``` csharp
réel[] notesPremierExamen = créer réel[5];
réel[] notesSecondExamen = créer réel[5];
réel[] moyennesEtudiants = créer réel[5];
réel sommeMoyennesEtudiants = 0.0;
réel moyenneGeneraleEtudiants = 0.0;
réel note = 0;

pour entier numeroNote de 0 à notesPremierExamen.Capacité - 1 {
    faire {
        écrire("Veuillez entrer la note " + numeroNote.VersChaine() + " du premier examen : ");
        note = lire();
    } tant que (note < 0 ou note > 100);
    notesPremierExamen[numeroNote] = note;
}

pour entier numeroNote de 0 à notesSecondExamen.Capacité - 1 {
    faire {
        écrire("Veuillez entrer la note " + numeroNote.VersChaine() + " du second examen : ");
        note = lire();
    } tant que (note < 0 ou note > 100);
    notesSecondExamen[numeroNote] = note;
}

pour entier numeroNote de 0 à notesPremierExamen.Capacité - 1 {
    moyennesEtudiants[numeroNote] = (notesPremierExamen[numeroNote] + notesSecondExamen[numeroNote]) / 2.0;
    sommeMoyennesEtudiants = sommeMoyennesEtudiants + moyennesEtudiants[numeroNote];
}

pour entier numeroNote de 0 à moyennesEtudiants.Capacité - 1 {
    écrireNL("Moyenne de l'examen " + numeroNote.VersChaine() + " : " + moyennesEtudiants[numeroNote].VersChaine());
}

moyenneGeneraleEtudiants = sommeMoyennesEtudiants / moyennesEtudiants.Capacité;
écrireNL("Moyenne générale : " + moyenneGeneraleEtudiants.VersChaine());
```

</details>

## Exercice 5 - Suite de Fibonnaci

Écrivez un algorithme qui :

- calcule la suite de Fibonnaci dans un tableau de 20 entiers (utilisez une structure répétition).
- affiche la suite de Fibonnaci sur une même ligne (les entiers sont séparés par des '-').
0-1-1-2-3-5-8-13-21...

<details>
    <summary>Proposition solution</summary>

``` csharp
entier[] suiteFibonnaci = créer entier[20];

suiteFibonnaci[0] = 0;
suiteFibonnaci[1] = 1;
pour entier numeroValeurSuiteFibonaci de 2 à suiteFibonnaci.Capacité - 1 {
    suiteFibonnaci[numeroValeurSuiteFibonaci] = suiteFibonnaci[numeroValeurSuiteFibonaci - 2] + suiteFibonnaci[numeroValeurSuiteFibonaci - 1];
}

écrire(suiteFibonnaci[0]);
pour entier numeroValeurSuiteFibonaci de 1 à suiteFibonnaci.Capacité - 1 {
    écrire("-" + suiteFibonnaci[numeroValeurSuiteFibonaci].VersChaine());
}
```

</details>

## Exercice 6 - Saisie de prénoms

Écrivez un algorithme qui :

- lit au clavier cinq prénoms dans un tableau
- affiche les cinq prénoms sur des lignes séparées
- lit au clavier un nombre `n` de 1 à 5
- lit au clavier un nouveau prénom
- remplace le prénom qui se trouve au rang `n` (1er, 2e...) dans le tableau par le nouveau prénom.
- affiche les cinq prénoms du tableau sur des lignes séparées
- redemande un nouveau nombre et un nouveau prénom dans un processus de répétition. Pour arrêter la répétition l'utilisateur doit entrer un nombre invalide.

<details>
    <summary>Proposition solution</summary>

``` csharp
chaine[] prenoms = créer chaine[5];
entier n = 0;
chaine prenom = "";

pour entier numeroPrenom de 0 à prenoms.Capacité - 1 {
    écrire("Veuillez saisir le prénom " + numeroPrenom.VersChaine() + " : ");
    prenoms[numeroPrenom] = lire();
}

faire {
    écrire("Veuillez saisir un entier compris entre 1 et 5");
    n = lire();

    si (n >= 1 et n <= 5) {
        écrire("Veuillez saisir un nouveau prénom : ");
        prenom = lire();

        prenoms[n - 1] = prenom;

        pour entier numeroPrenom de 0 à prenoms.Capacité - 1 {
            écrireNL("Prénom " + numeroPrenom.VersChaine() + " : " +  prenoms[numeroPrenom] + " : ");
        }
    }
} tant que (n >= 1 et n <= 5);
```

</details>

## Exercice 7 - Décalage de valeurs

Écrivez un algorithme qui :

- remplit un tableau de quinze entiers avec les valeurs suivantes : 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 et 15
- lit un entier `n` entre 0 et 5 inclusivement. Si `n` est plus petit que zéro alors N devient 0 et si `n` est plus grand que 5 alors `n` devient 5.
- modifie toutes les valeurs de la façon suivante: la nouvelle valeur se trouvant a une position donnée est remplacée par la valeur se trouvant à la position donnée plus `n`. Si la position plus `n` n'est pas valide (plus grande que 14 par exemple) alors il faut utiliser la valeur zéro.
- affiche les 15 nouveaux entiers sur une même ligne séparés par des virgules

*Exemple*:
**Initialement** : 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 et 15
Pour `N = 3`
**Affichage** : 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 0, 0

<details>
    <summary>Proposition solution</summary>

``` csharp
entier[] valeurs = créer entier[15];
entier n = 0;

écrire("Veuillez entrer un nombre compris entre 0 et 5 : ");
n = lire();

si (n < 0) alors {
    n = 0;
}

si (n > 5) alors {
    n = 5;
}

pour entier indiceValeur de 0 à valeurs.Capacité - 1 {
    valeurs[indiceValeur] = indiceValeur + 1;
}

pour entier indiceValeur de 0 à valeurs.Capacité - 1 - n {
    valeurs[indiceValeur] = valeurs[indiceValeur + n];
}

pour entier indiceValeur de valeurs.Capacité - n à valeurs.Capacité - 1 {
    valeurs[indiceValeur] = 0;
}
```

</details>
