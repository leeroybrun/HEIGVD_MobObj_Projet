# Cahier des charges

Ce système permet de gérer les sorties des clubs de montagne (type CAS).

Un club peut s'enregistrer sur le système.

Les membres peuvent s'enregistrer ensuite à un club et obtiennent un utilisateur/mot de passe.

Chaque club peut avoir plusieurs cabanes qui seront des escales dans les sorties.
Chaque cabane a un nombre maximum de personnes et un prix de nuitée.

Les sorties sont créées par un organisateur (administrateur), elles relient différentes cabanes (chaque cabane correspond à une étape).
Pour chaque étape (cabane), il y aura la date et heure prévue d'arrivée et de départ.
Le prix de la sortie sera calculé d'après le prix de base de la sortie + le prix de toutes les nuitées dans les cabanes.

Les membres peuvent ensuite s'inscrire aux différentes sorties.
Dès qu'une cabane dans une sortie est pleine (nb inscrits sortie == nb max personnes cabane), la sortie est complète.

# Cas d'utilisation

## Un organisateur peut créer une sortie

Un membre peut créer une sortie pour un club dans lequel elle est responsable (organisateur).

Lors de la création d'une sortie, le membre entrera la date et le lieux de départ de la sortie.

Elle ajoutera ensuite des cabanes à la sortie, en indiquant pour chaque cabane la date et l'heure d'arrivée et de départ.

Un organisateur valide l'inscription d'un membre.

## Une personne peut s'inscrire à un club

Un membre peut intégrer un ou plusieurs clubs.


## Un membre d'un club peut lister les sorties

Un membre peut lister les sorties des clubs auxquel il est inscrit.

Un membre peut vérifier le nombre de places disponibles pour une sortie donnée.

Pour chaque sortie, on vérifie si les cabanes de la sortie ne sont pas pleines et on calcul le prix final avant de les afficher.

## Un membre d'un club peut s'inscrire à une sortie

Un membre peut s'inscrire à une sortie