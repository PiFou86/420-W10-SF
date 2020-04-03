# Module 07 - Fonctions

## Premiers exercices

Pour chacun des exercices, débutez par l’écriture en pseudocode et écrivez ensuite la fonction C# associée.
Pour chaque fonction, donnez des exemples d’utilisation dans un sous-programme dédié à chaque question.
Si vous avez besoin d’ajouter de nouvelles fonctions, créez-les !
N'oubliez pas d'ajouter les préconditions !

### Exercice 1 - Salutations

Écrivez la fonction "Saluer" qui affiche un message de salutation. La fonction doit prendre le nom de la personne à saluer en paramètres.

<details>
    <summary>Proposition solution</summary>

``` csharp
aucun saluer(chaine p_nom) {
    écrireNL("Bonjour " + p_nom);
}
```

</details>

### Exercice 2 - Maximun de valeurs

1. Écrivez la fonction "CalculerMaximum" qui calcule et renvoie le maximum de deux entiers passés en paramètres.
2. Écrivez la fonction "CalculerMaximum" qui calcule et renvoie le maximum de trois entiers passés en paramètres en utilisant la précédente fonction (les deux fonctions sont considérées comme différentes car elles n'ont pas les mêmes paramètres).

<details>
    <summary>Proposition solution 2.1</summary>

``` csharp
entier calculerMaximum(entier p_valeur1, entier p_valeur2) {
    entier valeurMaximum = p_valeur1;

    si (p_valeur2 > valeurMaximum) {
        valeurMaximum = p_valeur2;
    }

    renvoyer valeurMaximum;
}
```

</details>

<details>
    <summary>Proposition solution 2.2</summary>

``` csharp
entier calculerMaximum(entier p_valeur1, entier p_valeur2, entier p_valeur3) {
    renvoyer calculerMaximum(calculerMaximum(p_valeur1, p_valeur2), p_valeur3);
}
```

</details>


### Exercice 3 - Lectures de valeurs

1. Écrivez une fonction qui lit une note réel comprise entre 0 et 100 inclus et la renvoie.
2. Écrivez une fonction qui lit une collection de notes et la renvoie. La fonction reçoit la quantité de notes à saisir en paramètres.

<details>
    <summary>Proposition solution 3.1</summary>

``` csharp
réel saisirNote() {
    réel note = 0.0;
    
    faire {
        écrire("Veuillez entrer la note " + numeroNote.VersChaine() + " du second examen : ");
        note = lire();
    } tant que (note < 0 ou note > 100);

    renvoyer note;
}
```

</details>

<details>
    <summary>Proposition solution 3.2</summary>

``` csharp
réel[] saisirNotes(entier p_quantiteNotes) {
    // Préconditions
    // 1. p_quantiteNotes doit être >= 0
    réel[] notes = créer réel[p_quantiteNotes];

    pour entier numeroNote de 0 à notes.Capacité - 1 {
        notes[numeroNote] = saisirNote();
    }

    renvoyer notes;
}
```

</details>

### Exercice 4 - Calculs sur des collections

1. Écrivez une fonction qui calcule la somme d’un tableau de réels passé en paramètres.
2. Écrivez une fonction qui calcule la moyenne d’un tableau de réels passé en paramètres.

<details>
    <summary>Proposition solution 4.1</summary>

``` csharp
réel calculerSomme(réel[] p_valeurs) {
    // Préconditions
    // 1. p_valeurs ne doit pas être null
    réel somme = 0.0;

    pour entier indiceValeur de 0 à p_valeurs.Capacité - 1 {
        somme = somme + p_valeurs[indiceValeur];
    }

    renvoyer somme;
}
```

</details>

<details>
    <summary>Proposition solution 4.2</summary>

``` csharp
réel calculerMoyenne(réel[] p_valeurs) {
    // Préconditions
    // 1. p_valeurs ne doit pas être null
    // 2. p_valeurs doit avoir au moins une valeur
    renvoyer calculerSomme(p_valeurs) / p_valeurs.Capacité;
}
```

</details>

### Exercice 5 - On orchestre le tout

Écrivez un sous-programme qui :

1. Lit l’ensemble des notes et les places dans un tableau
2. Calcule la moyenne des notes
3. Affiche cette moyenne

## Revisitons la paie

> Écrire l’algorithme du calcul de la paie d’un employé respectant les règles suivantes :
>
>- Les informations lues sont le numéro de l’employé, son taux horaire, le nombre d’heures travaillées, le pourcentage de retenues diverses et le code syndical (0 ou 1).
> - Calculs :
>   - Salaire brut = taux horaire * nombre d’heures travaillées
>   - Retenues diverses = salaire brut * pourcentage retenues diverses
>   - Les impôts sont calculés comme suit :
>     - **si** salaire brut > 500,00$
> **alors** Impôt fédéral = 15 % du salaire brut > et Impôt provincial = 12 % du salaire brut
>     - **Sinon** Impôt fédéral = 10 % du salaire brut et Impôt provincial = 8 % du salaire brut
>   - Cotisation syndicale :
>     - **Si** le code de syndicat = 1  **alors**
>       - l’employé est syndiqué
>       - on lui retient 2 % de son salaire brut à titre de cotisation syndicale.
>
> Vous devez afficher le numéro d’employé, le salaire brut, l’impôt fédéral, l’impôt provincial, les retenues diverses, la cotisation syndicale et enfin le salaire net.

Fonctions à écrire :

### Fonctions de saisies

1. Écrivez une fonction qui permet de saisir une valeur réelle comprise entre deux valeurs réelles passées en paramètres

2. Écrivez une fonction qui permet de saisir une valeur réelle positive ou nulle et qui la renvoie

3. Écrivez une fonction qui permet de saisir une valeur entière comprise entre deux valeurs entières passées en paramètres.

4. Écrivez une fonction qui permet de saisir le numéro d’employé et qui le renvoie.

5. Écrivez une fonction qui permet de saisir le taux horaire d’un employé et qui le renvoie

6. Écrivez une fonction qui permet de saisir le nombre d’heures travaillées et qui le renvoie

7. Écrivez une fonction qui permet de saisir le pourcentage de retenues diverses et qui le renvoie

8. Écrivez une fonction qui permet de saisir le code syndical et qui le renvoie

### Fonctions de calcul

1. Écrivez une fonction qui permet de calculer le montant du salaire brut à partir du taux horaire et du nombre d’heures travaillées et qui le renvoie

2. Écrivez une fonction qui permet de calculer le montant des retenues diverses à partir du salaire brut et du pourcentage de retenues diverses et qui le renvoie.

3. Écrivez une fonction qui permet de calculer le montant de l’impôt fédéral à partir du salaire brut et qui le renvoie.

4. Écrivez une fonction qui permet de calculer le montant de l’impôt provincial à partir du salaire brut et qui le renvoie.

5. Écrivez une fonction qui permet de calculer le montant de la cotisation syndicale à partir du salaire brut et qui le renvoie.

### Sous-programme principal

Réécrivez l’algorithme principal du calcul de paie en utilisant les fonctions précédentes.

**Qu’observez-vous en lisant votre algorithme principal ?**
