# PixelBot

> Un jeu de plateforme 2D futuriste développé avec **Unity** et **C#**, alliant mécaniques classiques, esthétique PixelArt et progression narrative à travers des niveaux périlleux peuplés de robots.

## ⚠Statut du projet

> Ce projet a été réalisé **dans le cadre d’un laboratoire informatique** pour **tester et découvrir Unity**.  
> **Il est encore en développement** et **n’est pas une version finale** du jeu.  
> De nombreuses fonctionnalités sont prévues ou en cours de création.

## Présentation

Dans un futur post-apocalyptique, vous incarnez un personnage déterminé à fuir une planète dévastée. Son but : atteindre un site de lancement pour rejoindre l’humanité sur une colonie interstellaire. Mais pour cela, il faudra survivre à de multiples dangers, résoudre des obstacles et affronter des ennemis mécaniques redoutables…

## Fonctionnalités principales

- Déplacement fluide en 2D (mouvements, sauts)
- Échelles et exploration verticale
- Ennemis animés avec IA basique (patrouille, attaque)
- Système de santé, checkpoints et objets de soin
- Collecte de pièces et gestion d'argent
- PixelArt original pour un style rétro immersif
- Système de changement de niveaux et portes verrouillées
- Zones mortelles (deadzone) et gestion de la mort
- UI : barre de vie, écran de Game Over, menus (principal, pause)
- Contrôles clavier (support manette prévu)

## Technologies & apprentissages

- **Langage** : C# (POO, classes, héritage, encapsulation, polymorphisme)
- **Moteur** : Unity (2D, physics2D, coroutines, UI)
- **Graphisme** : PixelArt personnalisé via PixelR et Unity
- **Gestion de projet** : Git + GitLab, méthode Agile, développement incrémental

## Organisation du projet

- Structure des fichiers : `Scripts/`, `Scenes/`, `Prefabs/`, `Sprites/`
- Utilisation de **prefabs** pour faciliter la réutilisation
- Mise en place d’un `.gitignore` adapté à Unity
- Documentation du code avec commentaires clairs

## Problèmes rencontrés

- Réglage de la gravité et du saut pour une sensation fluide
- Problèmes de collision murale résolus avec Raycast
- Animation de mort déclenchée au mauvais moment (corrigée)
   Bug de caméra lors du changement de niveau (résolu via fusion)
- Conflits Git causés par fichiers Unity → `.gitignore` spécifique ajouté

## Améliorations futures

 Cinématiques d’introduction et de transition
- Musiques et effets sonores personnalisés
- Système d’inventaire
- PNJ interactifs avec dialogues
- Boss et combats dynamiques
- Arbre de compétences
- Choix impactant la narration
- Fins multiples
- Personnage personnalisable
- Développement plus approfondi du lore

> Le dépôt contient les **fichiers sources et documents**, mais **pas le setup complet Unity**. Assurez-vous d’avoir Unity installé avec les bons packages pour lancer le projet.
