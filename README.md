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

Une personne peut créer une sortie pour un club dans lequel elle est administrateur (organisateur).

Lors de la création d'une sortie, la personne entrera la date et le lieux de départ de la sortie.

Elle ajoutera ensuite des cabanes à la sortie, en indiquant pour chaque cabane la date et l'heure d'arrivée et de départ.

## Une personne peut s'inscrire

Une personne peut s'inscrire dans le système en entrant ses informations personnelles ainsi qu'un nom d'utilisateur/mot de passe. Si le nopm d'utilisateur est déjà pris, l'utilisateur ne peut pas s'inscrire (message d'erreur).

## Une personne peut s'inscrire à un club

Une fois inscrite dans le système, une personne peut s'inscrire à un club.

Une fois envoyée, son inscription est ensuite placée dans le système en mode "en attente".

Un organisateur doit ensuite venir la valider afin qu'elle soit effective et que la personne ait accès aux sorties du club.

## Un membre d'un club peut lister les sorties

Un membre dont l'inscription a été validée peut lister les sorties des clubs auxquel il est inscrit.

Pour chaque sortie, on vérifie si les cabanes de la sortie ne sont pas pleines et on calcul le prix final avant de les afficher.

## Un membre d'un club peut s'inscrire à une sortie
