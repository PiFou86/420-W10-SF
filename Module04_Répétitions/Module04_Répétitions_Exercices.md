# Module 04 - Répétitions

Ces exercices ont pour objectifs :

- de choisir le bon type de répétitions
- de renforcer les notions de types de variables, de l'importance des noms

## Exercice 1 - Carrés des nombres

Donnez l’algorithme puis le code qui lit un nombre et qui l’affiche au carré.
Cet algorithm doit se répéter tant que l’utilisateur vous donne une valeur strictement positive.
Dès qu’il donnera zéro ou un négatif, le programme doit s’arrêter.

<details>
    <summary>Indice #1</summary>

Connait-on ou peut-on déduire la quantité d'entiers à lire ?
</details>

<details>
    <summary>Indice #2</summary>

Comment répéter une action ? Quelle est/sont les actions à répéter ? Quand arrête-t-on ?
</details>

<details>
    <summary>Indice #3</summary>

Que représente le carré d'un nombre ?
</details>

<!--
<details>
    <summary>Proposition solution</summary>

``` csharp
entier nombre = 0;
entier nombreAuCarre = 0;

écrire("Veuillez saisir un nombre à élever au carré : ");
nombre = lire();
tant que (nombre > 0) faire {
    nombreAuCarre = nombre * nombre;
    écrire(nombre.VersChaine() + " au carré est : " + nombreAuCarre.VersChaine());

    nombre = lire();
}
```

</details>
-->

## Exercice 2 - $n$ carrés des nombres

Demandez à l’utilisateur la quantité de nombres qu’il a à saisir. Ensuite, vous lui demanderez de saisir chacun de ces nombres et vous l’afficherez au carré.

1. Faites ce programme avec un POUR ... DE ... À
2. Faites ce programme avec un TANT QUE ... FAIRE
3. Lequel des deux algorithmes semble le plus adapté ?
4. Que se passe-t-il si l'utilisateur saisit un nombre négatif comme quantité ?

<details>
    <summary>Indice #1</summary>

    Débutez par la boucle "pour". Cherchez à convertir le pour en tant que.
</details>

<!--
<details>
    <summary>Proposition solution 1.</summary>

``` csharp
entier quantiteNombresATraiter = 0;
entier nombre = 0;
entier nombreAuCarre = 0;

écrire("Veuillez entrer la quantité de nombres à traiter svp : ");
quantiteNombresATraiter = lire();

pour entier numeroNombre de 1 à quantiteNombresATraiter {
    écrire("Veuillez saisir le nombre " + numeroNombre.VersChaine() + " à élever au carré : ");
    nombre = lire();

    nombreAuCarre = nombre * nombre;
    écrire(nombre.VersChaine() + " au carré est : " + nombreAuCarre.VersChaine());
}
```

</details>

<details>
    <summary>Proposition solution 2.</summary>

``` csharp
entier quantiteNombresATraiter = 0;
entier nombre = 0;
entier nombreAuCarre = 0;
entier numeroNombre = 1;

écrire("Veuillez entrer la quantité de nombres à traiter svp : ");
quantiteNombresATraiter = lire();

tant que (numeroNombre <= quantiteNombresATraiter) {
    écrire("Veuillez saisir le nombre " + numeroNombre.VersChaine() + " à élever au carré : ");
    nombre = lire();

    nombreAuCarre = nombre * nombre;
    écrire(nombre.VersChaine() + " au carré est : " + nombreAuCarre.VersChaine());

    numeroNombre = numeroNombre + 1;
}
```

</details>
-->

## Exercice 3 - Total porte-monnaie

Vous devez faire l’algorithme et le code pour un programme servant à calculer la monnaie qu’une personne a dans son porte-monnaie.

Vous devez demander à l’utilisateur de vous fournir la valeur de chaque pièce qu’il a. Le programme se terminera lorsque l’utilisateur fournira la valeur zéro. Voici un exemple :

```console
### Calcul de la monnaie ###
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0.25
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0.25
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0.25
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0.25
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0.10
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0.05
Entrez la valeur d’une pièce en dollar (0 pour arrêter) : 0

La valeur totale est : 1.15 $.
```

<!--
<details>
    <summary>Proposition solution</summary>

``` csharp
réel valeurPiece = 0.0;
réel valeurTotale = 0.0;

écrireNL("### Calcul de la monnaie ###");

écrire("Entrez la valeur d’une pièce en dollar (0 pour arrêter) : ");
valeurPiece = lire();

tant que (valeurPiece > 0) {
    valeurTotale = valeurTotale + valeurPiece;

    écrire("Entrez la valeur d’une pièce en dollar (0 pour arrêter) : ");
    valeurPiece = lire();
};

écrireNL("");
écrireNL("La valeur totale est : " + valeurTotale.VersChaine() + " $.");
```

</details>
-->

## Exercice 4 - Table des carrés et cubes

Écrire un algorithme et le code qui calcule et affiche la table des carrés et des cubes pour les nombres de 1 à 20.

<!--
<details>
    <summary>Proposition solution</summary>

``` csharp
entier carreNombre = 0;
entier cubeNombre = 0;

pour entier nombre de 1 à 20 {
    carreNombre = nombre * nombre;
    cubeNombre = carreNombre * nombre;

    écrireNL("Avec le nombre " + nombre.VersChaine() + ", le carré est " + carreNombre.VersChaine() + " et le cube est " + cubeNombre.VersChaine());
}
```

</details>
-->

## Exercice 5 - Somme d'une suite d'entiers

Écrire un algorithme et le code pour calculer et afficher la somme de la suite de nombres de 1 à 100.

<!--
<details>
    <summary>Proposition solution</summary>

``` csharp
entier sommeEntiers = 0;

pour entier nombre de 1 à 100 {
    sommeEntiers = sommeEntiers + nombre;
}

écrire("La somme de 1 à 100 est " + sommeEntiers.VersChaine());
```

</details>
-->

## Exercice 6 - Somme d'une suite de nombres pairs

Écrire un algorithme et le code pour calculer et afficher la somme de la suite de nombres des nombres pairs de 0 à 12.

<!--
<details>
    <summary>Proposition solution</summary>

``` csharp
entier sommeNombresPairs = 0;

pour entier nombrePair de 2 à 12 évolution +2 {
    sommeNombresPairs = sommeNombresPairs + nombrePair;
}

écrire("La somme des nombres pairs de 0 à 12 est " + sommeNombresPairs.VersChaine());
```

</details>
-->

## Exercice 7 - Somme d'une suite de nombres

Écrire un algorithme et le code pour calculer et afficher la somme de la suite dont les valeurs de départ et d’arrêt sont fixées par l’utilisateur (en lecture).

<!--
<details>
    <summary>Proposition solution</summary>

``` csharp
entier sommeEntiers = 0;
entier valeurDepart = 0;
entier valeurArret = 0;

écrire("Veuillez entrer une valeur de départ pour la suite : ");
valeurDepart = lire();

écrire("Veuillez entrer une valeur de arrêt pour la suite : ");
valeurArret = lire();

pour entier nombre de valeurDepart à valeurArret {
    sommeEntiers = sommeEntiers + nombre;
}

écrire("La somme de " + valeurDepart.VersChaine() + " à " + valeurArret.VersChaine() + "est " + sommeEntiers.VersChaine());
```

</details>
-->
