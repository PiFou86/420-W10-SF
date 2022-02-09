# Module 05 - Alternatives et répétitions

## Alternatives

### Exercice 1 - Calculatrice

Écrire l’algorithme en pseudo code qui demande deux nombres et une chaine de caractères. Si la chaine est « s », le programme doit afficher la somme des nombres. Si c’est « p », ce sera le produit. Si la chaine n’est ni « s » ni « p », alors affichez un message d’erreur.

<details>
    <summary>Proposition solution</summary>

``` csharp
réel operande1 = 0.0;
réel operande2 = 0.0;
chaine operateur = "";
réel resultatOperation = 0.0;

écrire("Veuillez entrer la valeur du premier opérande : ");
operande1 = lire();

écrire("Veuillez entrer la valeur du second opérande : ");
operande2 = lire();

écrire("Veuillez entrer l'opérateur à appliquer (p pour produit ou s pour somme) : ");
operateur = lire();

selon (operateur) {
  cas "s":
    resultatOperation = operande1 + operande2;
    écrire("La somme de " + operande1.VersChaine() + " et de " + operande2.VersChaine() + " est " + resultatOperateur.VersChaine());

  cas "p":
    resultatOperation = operande1 * operande2;
    écrire("Le produit de " + operande1.VersChaine() + " et de " + operande2.VersChaine() + " est " + resultatOperateur.VersChaine());

  sinon :
    écrire("L'opérateur saisi n'est pas reconnu.");
}

```

</details>

### Exercice 2 - Coût livraison

Écrire l’algorithme en pseudo code qui calcule le coût de livraison d’une commande à partir de son total, d’après le tableau suivant :
|Total de la facture|Coût de livraison|
|---|--:|
|Moins de 10 \$|2 $|
|De 10 \$ à 49.99 \$|10 % du total|
|50 \$ et plus|Gratuit|

Vous devez demander à l’utilisateur le total de la commande et lui afficher ensuite le coût de la livraison.
Si jamais il vous donne une valeur négative ou même zéro, affichez-lui un message d’erreur et terminez le programme.

<details>
    <summary>Proposition solution</summary>

``` csharp
réel totalFacture = 0.0;
réel coutLivraison = 0.0;

écrire("Veuillez entrer le total de la facture svp : ");
totalFacture = lire();

si (totalFacture > 0) {
  si (totalFacture > 0 et totalFacture < 10) {
    coutLivraison = 2.0;
  } sinon si (totalFacture <= 49.99) {
    coutLivraison = totalFacture * 0.1;
  }
}

si (totalFacture <= 0) {
  écrire("Erreur dans le montant de la facture.");
} sinon {
  écrire("Le coût de la livraison est " + coutLivraison.VersChaine());
}
```

</details>

### Exercice 3 - Jour de la semaine

Écrire l’algorithme qui lit un nombre compris entre 1 et 7 et affiche le nom du jour correspondant. La semaine débute le lundi (1).

<details>
    <summary>Proposition solution</summary>

``` csharp
entier jourDeLaSemaine = 0;
chaine texteJourDeLaSemaine = "";

faire {
  écrire("Entrez un nombre entre 1 et 7 svp : ");
  jourDeLaSemaine = lire();
} tant que (jourDeLaSemaine < 1 ou jourDeLaSemaine > 7);

selon (jourDeLaSemaine) {
  cas 1:
    texteJourDeLaSemaine = "lundi";
  cas 2:
    texteJourDeLaSemaine = "mardi";
  cas 3:
    texteJourDeLaSemaine = "mercredi";
  cas 4:
    texteJourDeLaSemaine = "jeudi";
  cas 5:
    texteJourDeLaSemaine = "vendredi";
  cas 6:
    texteJourDeLaSemaine = "samedi";
  cas 7:
    texteJourDeLaSemaine = "dimanche";
}

écrire("Le jour " + jourDeLaSemaine.VersChaine() + " de la semaine est le " + texteJourDeLaSemaine);
```

</details>

### Exercice 4 - Calcul de paie

Écrire l’algorithme du calcul de la paie d’un employé respectant les règles suivantes :

- Les informations lues sont le numéro de l’employé, son taux horaire, le nombre d’heures travaillées, le pourcentage de retenues diverses et le code syndical (0 ou 1).
- Calculs :
  - Salaire brut = taux horaire * nombre d’heures travaillées
  - Retenues diverses = salaire brut * pourcentage retenues diverses
  - Les impôts sont calculés comme suit :
    - **si** salaire brut > 500,00$
**alors** Impôt fédéral = 15% du salaire brut et Impôt provincial = 12% du salaire brut
    - **Sinon** Impôt fédéral = 10% du salaire brut et Impôt provincial = 8% du salaire brut
  - Cotisation syndicale :
    - **Si** le code de syndicat = 1  **alors**
      - l’employé est syndiqué
      - on lui retient 2 % de son salaire brut à titre de cotisation syndicale.

Vous devez afficher le numéro d’employé, le salaire brut, l’impôt fédéral, l’impôt provincial, les retenues diverses, la cotisation syndicale et enfin le salaire net.

<details>
    <summary>Proposition solution</summary>

``` csharp
chaine numeroEmploye = "";
réel tauxHoraire = 0.0;
réel quantiteHeuresTravaillees = 0.0;
réel pourcentageRetenuesDiverses = 0.0;
entier codeSyndical = 0;

réel salaireBrut = 0.0;
réel montantRetenuesDiverses = 0.0;
réel montantCotisationSyndicales = 0.0;
réel montantImpotFederal = 0.0;
réel montantImpotProvincial = 0.0;
réel salaireNet = 0.0;

faire {
  écrire("Veuillez entrer un numéro d'employer svp : ");
  numeroEmploye = lire();
} tant que (numeroEmploye == "");

faire {
  écrire("Veuillez entrer le taux horaire de l'employé svp : ");
  tauxHoraire = lire();
} tant que (tauxHoraire < 0);

faire {
  écrire("Veuillez entrer la quantité d'heures travaillées svp : ");
  quantiteHeuresTravaillees = lire();
} tant que (quantiteHeuresTravaillees <= 0);

faire {
  écrire("Veuillez entrer le pourcentage des retenues diverses svp : ");
  pourcentageRetenuesDiverses = lire();
} tant que (pourcentageRetenuesDiverses < 0 ou pourcentageRetenuesDiverses > 1) ;

faire {
  écrire("Veuillez entrer le code syndical (0 ou 1) svp : ");
  codeSyndical = lire();
} tant que (codeSyndical != 1 et codeSyndical != 0);

salaireBrut = tauxHoraire * quantiteHeuresTravaillees;
montantRetenuesDiverses = salaireBrut * pourcentageRetenuesDiverses;

si (salaireBrut > 500) {
  montantImpotFederal = salaireBrut * .15;
  montantImpotProvincial = salaireBrut * .12;
} sinon {
  montantImpotFederal = salaireBrut * .10;
  montantImpotProvincial = salaireBrut * .08;
}

si (codeSyndical == 1) {
  montantCotisationSyndicales = salaireBrut * .02;
}

salaireNet = salaireBrut - montantRetenuesDiverses - montantImpotFederal - montantImpotProvincial - montantCotisationSyndicales;

Vous devez afficher le numéro d’employé, le salaire brut, l’impôt fédéral, l’impôt provincial, les retenues diverses, la cotisation syndicale et enfin le salaire net.

écrireNL("Numéro employé : " + numeroEmploye);
écrireNL("Salaire brut : " + salaireBrut.VersChaine());
écrireNL("Montant impôt fédéral : " + montantImpotFederal.VersChaine());
écrireNL("Montant impôt provincial : " + montantImpotProvincial.VersChaine());
écrireNL("Montant des retenues diverses : " + montantRetenuesDiverses.VersChaine());
écrireNL("Montant de la cotisation sociale : " + montantCotisationSyndicales.VersChaine());
écrireNL("---");
écrireNL("Salaire net : " + salaireNet.VersChaine());
```

</details>

## Des répétitions un peu plus complexes

### Exercice 1 - Notes d’examens V2

Concevoir l’algorithme pseudo code qui lit la note finale de chaque étudiant d’une classe et affiche le pourcentage de réussite et le pourcentage d’échec. Trois cas sont possibles :

1. le nombre d’étudiants dans la classe est de 35.
2. le nombre d’étudiants est variable, mais connu de l’utilisateur.
3. le nombre d’étudiants est variable et inconnu de l’utilisateur. L'utlisateur tape une valeur négative pour arrêter la saisie

<details>
    <summary>Proposition solution 1.</summary>

``` csharp
entier quantiteReussites = 0;
entier quantiteEchecs = 0;
réel noteFinale = 0.0;

réel pourcentageReussites = 0.0;
réel pourcentageEchecs = 0.0;

pour entier numeroEtudiant de 1 à 35 {
  faire {
    écrire("Veuillez entrer la note finale de l'étudiant " + numeroEtudiant.VersChaine() + " : ");
    noteFinale = lire();
  } tant que (noteFinale < 0 ou noteFinale > 100);

  si (noteFinale >= 60.0) {
    quantiteReussites = quantiteReussites + 1;
  } sinon {
    quantiteEchecs = quantiteEchecs + 1;
  }
}

pourcentageReussites = quantiteReussites * 100.0 / 35;
pourcentageEchecs = quantiteEchecs * 100.0 / 35;

écrireNL("Le pourcentage de réussites est : " + pourcentageReussites.VersChaine());
écrireNL("Le pourcentage d'échecs est : " + pourcentageEchecs.VersChaine());
```

</details>

<details>
    <summary>Proposition solution 2.</summary>

``` csharp
entier quantiteReussites = 0;
entier quantiteEchecs = 0;
entier quantiteEtudiants = 0;
réel noteFinale = 0.0;

réel pourcentageReussites = 0.0;
réel pourcentageEchecs = 0.0;

écrire("Veuillez entrer la quantité d'étudiants à analyser svp : ");
quantiteEtudiants = lire();

pour entier numeroEtudiant de 1 à quantiteEtudiants {
  faire {
    écrire("Veuillez entrer la note finale de l'étudiant " + numeroEtudiant.VersChaine() + " : ");
    noteFinale = lire();
  } tant que (noteFinale < 0 ou noteFinale > 100);

  si (noteFinale >= 60.0) {
    quantiteReussites = quantiteReussites + 1;
  } sinon {
    quantiteEchecs = quantiteEchecs + 1;
  }
}

pourcentageReussites = quantiteReussites * 100.0 / quantiteEtudiants;
pourcentageEchecs = quantiteEchecs * 100.0 / quantiteEtudiants;

écrireNL("Le pourcentage de réussites est : " + pourcentageReussites.VersChaine());
écrireNL("Le pourcentage d'échecs est : " + pourcentageEchecs.VersChaine());
```

</details>

<details>
    <summary>Proposition solution 3.</summary>

``` csharp
entier quantiteReussites = 0;
entier quantiteEchecs = 0;
entier quantiteEtudiants = 0;
réel noteFinale = 0.0;

réel pourcentageReussites = 0.0;
réel pourcentageEchecs = 0.0;

faire {
  écrire("Veuillez entrer la note finale de l'étudiant " + numeroEtudiant.VersChaine() + " : ");
  noteFinale = lire();
} tant que (noteFinale > 100);

tant que (noteFinale >= 0 et noteFinale <=> 100) {
  quantiteEtudiants = quantiteEtudiants + 1;
  si (noteFinale >= 60.0) {
    quantiteReussites = quantiteReussites + 1;
  } sinon {
    quantiteEchecs = quantiteEchecs + 1;
  }

  faire {
    écrire("Veuillez entrer la note finale de l'étudiant " + numeroEtudiant.VersChaine() + " : ");
    noteFinale = lire();
  } tant que (noteFinale > 100);
}

pourcentageReussites = quantiteReussites * 100.0 / quantiteEtudiants;
pourcentageEchecs = quantiteEchecs * 100.0 / quantiteEtudiants;

écrireNL("Le pourcentage de réussites est : " + pourcentageReussites.VersChaine());
écrireNL("Le pourcentage d'échecs est : " + pourcentageEchecs.VersChaine());
```

</details>

### Exercice 2 - Notes d’examens

Écrivez un algorithme qui lit au clavier le nombre d'élèves d'une classe (>0) et ensuite le nombre d'examens (>0).
Pour chaque étudiant, l'algorithme demande tous les résultats d'examen (note de 0 à 100) et affiche la moyenne de l'étudiant (chaque examen a le même poids).
Finalement l'algorithme affiche la moyenne générale de la classe (la moyenne des moyennes). Chacune des moyennes calculées est affichée sur une ligne différente.

<details>
    <summary>Proposition solution</summary>

``` csharp
entier quantiteEtudiants = 0;
entier quantiteNotesParEtudiant = 0;
réel noteFinale = 0.0;
réel sommeNotesEtudiant = 0.0;
réel moyenneEtudiant = 0.0;
réel sommeMoyennesEtudiants = 0.0;
réel moyenneEtudiants = 0.0;

faire {
    écrire("Veuillez entrer la quantité d'étudiants svp : ");
    
    chaine quantiteEtudiantsChaine = "";
    quantiteEtudiantsChaine = lire();
    
    Conversion de quantiteEtudiantsChaine vers quantiteEtudiants;
    si conversion est mauvaise{
        quantiteEtudiants = 0;
    }
} tant que (quantiteEtudiants < 1);
                                   
faire {
    écrire("Veuillez entrer le nombre d'examens par étudiant : ");
                                   
    chaine quantiteNotesParEtudiantChaine = "";
    quantiteNotesParEtudiantChaine = lire();
                                   
    conversion de quantiteNotesParEtudiantChaine vers quantiteNotesParEtudiant;
    si conversion est mauvaise {
        quantiteNotesParEtudiant = 0;
    }
} tant que (quantiteNotesParEtudiant < 1);
                                   
pour entier numeroEtudiant de 1 à quantiteEtudiants {
    sommeNotesEtudiant = 0.0;

    écrire("Nous allons traiter l'étudiant " + numeroEtudiant);
    pour entier numeroExamen de 1 à quantiteNotesParEtudiant {
        faire {
            écrire("Veuillez entrer la note finale de l'examen " + numeroExamen + " de l'étudiant " + numeroEtudiant + " : ");
    
            chaine noteFinaleChaine = "";
            noteFinaleChaine = lire();
    
            conversion de noteFinaleChaine vers noteFinale;
            si conversion est mauvaise {
                noteFinale = 0;
            }
        } tant que (noteFinale < 0 ou noteFinale > 100);

        sommeNotesEtudiant = sommeNotesEtudiant + noteFinale;
    }

    moyenneEtudiant = sommeNotesEtudiant / quantiteNotesParEtudiant;

    sommeMoyennesEtudiants = sommeMoyennesEtudiants + moyenneEtudiant;

    écrire("L'étudiant " + numeroEtudiant + " a une moyenne de : " + moyenneEtudiant)
}

moyenneEtudiants = sommeMoyennesEtudiants / quantiteEtudiants;
écrire("La moyenne des étudiants est : " + moyenneEtudiants);
```

</details>

### Exercice 3 - Ligne d’étoiles

Écrire un algorithme qui lit un entier positif et qui affiche une ligne d’étoiles contenant le nombre d’étoiles demandé.

```console
*****↵
```

<details>
    <summary>Proposition solution</summary>

``` csharp
entier largeurLigne = 0;

écrire("Veuillez entrer une largeur de ligne svp : ");
largeurLigne = lire();

pour entier numeroEtoile de 1 à largeurLigne {
  écrire("*");
}
écrireNL("");
```

</details>

### Exercice 4 - Rectangle plein d’étoiles

Écrire un algorithme qui lit deux entiers positifs : la hauteur et la largeur et qui dessine un rectangle plein rempli d’étoiles.
Exemple : pour hauteur = 3 et largeur = 5, nous devons obtenir :

```console
*****↵
*****↵
*****↵
```

<details>
    <summary>Proposition solution</summary>

``` csharp
entier largeurRectangle = 0;
entier hauteurRectangle = 0;

écrire("Veuillez entrer une largeur de rectangle svp : ");
largeurRectangle = lire();
écrire("Veuillez entrer une hauteur de rectangle svp : ");
hauteurRectangle = lire();

pour entier numeroLigne de 1 à hauteurRectangle {
  pour entier numeroEtoile de 1 à largeurRectangle {
    écrire("*");
  }
  écrireNL("");
}
```

</details>

### Exercice 5 - Carré de chiffres

Écrivez un algorithme qui lit un nombre d’un chiffre au clavier (de 1 à 9) et qui affiche un carré composé uniquement de chiffres. La largeur du carré est le nombre lu. Les exemples suivants expliquent comment remplir le carré de chiffres:

Avec 1 :

```console
1↵
```

Avec 2 :

```console
21↵
01↵
```

Avec 3 :

```console
321↵
021↵
001↵
```

Avec 4 :

```console
4321↵
0321↵
0021↵
0001↵
```

Avec 5 :

```console
54321↵
04321↵
00321↵
00021↵
00001↵
```

<details>
    <summary>Proposition solution</summary>

``` csharp
entier valeurDepart = 0;
entier nombreLignes = 0;
entier nombreZeros = 0;

faire {
  écrire("Veuillez entrer une valeur de départ entre 1 et 9 svp : ");
  nombreLignes = lire();
} tant que (nombreLignes < 1 ou nombreLignes > 9);

valeurDepart = nombreLignes;

pour entier numeroLigne de 1 à nombreLignes {
  pour entier numeroZero de 1 à nombreZeros {
    écrire('0');
  }
  
  pour entier numeroChiffreAAfficher de valeurDepart à 1 évolution -1 {
    écrire(numeroChiffreAAfficher);
  }
  écrireNL();

  nombreZeros = nombreZeros + 1;
  valeurDepart = valeurDepart - 1;
}
```

</details>

### Exercice 6 - Rectangle vide d’étoiles

Écrire un algorithme qui lit deux entiers positifs : une hauteur et une largeur et qui dessine un rectangle vide bordé d’étoiles.
Exemple : pour hauteur = 3 et largeur = 5, nous devons obtenir :

```console
*****↵
*˽˽˽*↵
*****↵
```

<details>
    <summary>Proposition solution</summary>

``` csharp
entier hauteurRectangleVide = 0;
entier largeurRectangleVide = 0;

faire {
  écrire("Veuillez entrer une hauteur supérieure à 2 svp : ");
  hauteurRectangleVide = lire();
} tant que (hauteurRectangleVide < 2);

faire {
  écrire("Veuillez entrer une largeur supérieure à 2 svp : ");
  largeurRectangleVide = lire();
} tant que (largeurRectangleVide < 2);

pour entier numeroEtoile de 1 à largeurRectangleVide {
  écrire("*");
}

pour entier numeroLigne de 2 à hauteurRectangleVide - 1 {
  écrire('*');
  
  pour entier numeroEspace de 2 à largeurRectangleVide - 1 {
    écrire(' ');
  }

  écrire('*');
  écrireNL();
}

pour entier numeroEtoile de 1 à largeurRectangleVide {
  écrire("*");
}
```

</details>

### Exercice 7 - Avez-vous bien fait cela ?

Si vous avez utilisé des alternatives dans les 3 exercices précédents, les refaire sans alternative.
