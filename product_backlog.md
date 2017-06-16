| ID          | 0_0                                                      |
|:----------- |----------------------------------------------------------|
| Titre       | **Schématiser la BDD**                                   |
| Priorite    | ___100___                                                |
| Estimation  | ___1___                                                  |
| En tant que | PO                                                       |
| Je veux     | que les dev réalisent un MPD                             |
| Afin de     | disposer d'une BDD commune pour le développement         |

### DoD :

1 - Schéma sur support numérique modélisant :

[x] les tables
[x] les relations entre les tables
[x] les cardinalités

----------





| ID          | 0_1                                                      |
|:----------- |----------------------------------------------------------|
| Titre       | **Définir l'architecture logicielle**                    |
| Priorite    | ___100___                                                |
| Estimation  | ___3___                                                  |
| En tant que | PO                                                       |
| Je veux     | que les dev fassent un schéma de l'archi logicielle      |
| Afin de     | savoir les modules à implémenter dans l'application      |

### DoD :

1 - Schéma sur support numérique modélisant :

[x] les données source de l'application
[x] les traitements effectués
[x] les données exploitables en sortie de l'application
[x] les technologies externes utilisées

----------





| ID          | 0_2                                                      |
|:----------- |----------------------------------------------------------|
| Titre       | **Réaliser une maquette de l'interface graphique**       |
| Priorite    | ___100___                                                |
| Estimation  | ___3___                                                  |
| En tant que | PO                                                       |
| Je veux     |  que les dev fassent une maquette de l'application       |
| Afin de     | montrer au client le rendu visuel attendu			     |

### DoD :

1 - Réalisation de la maquette de la fenêtre d'accueil intégrant :

[x] les boutons permettant l'accès aux diverses fonctionnalités

2 - Réalisation de la maquette des fenêtres propres aux fonctionnalités :

[x] Import des données
[] Affichage des données
[x] Export des données
[x] Génération de rapport

----------





| ID          | 1_0                                                         |
|:----------- |-------------------------------------------------------------|
| Titre       | **Récupérer les données des capteurs**                      |
| Priorite    | ___???___                                                   |
| Estimation  | ___?___                                                     |
| En tant que | Utilisateur                                                 |
| Je veux     | cliquer sur un bouton "Importer des données "               |
| Afin de     | enregistrer les données texte issues des capteurs ds l'appli|

### DoD :

1 - Disposer d'une fonctionnalité permettant l'ajout de données .txt  :
[] bouton "Importer des données" permettant l'import d'un fichier préalablement enregistré sur le poste de travail
[] afficher un message de confirmation que l'import des données a bien réussi (nb lignes traitées)

----------





| ID          | 1_1                                                      |
|:----------- |----------------------------------------------------------|
| Titre       | **Attribuer l'id de capteur à l'import**      			 |
| Priorite    | ___???___                                                |
| Estimation  | ___?___                                                  |
| En tant que | Utilisateur                                              |
| Je veux     | lier l'import de données à un ID de capteur              |
| Afin de     | savoir quelles données correspondent à quel capteur	     |

### DoD :

1 - Afficher un tableau récapitulatif de tous les enregistrements liés à l'import effectué :
[]   

----------





| ID          | 1_2                                                                       |
|:----------- |---------------------------------------------------------------------------|
| Titre       | **Stocker les données importées dans une BDD**			                  |
| Priorite    | ___???___                                                                 |
| Estimation  | ___?___                                                                   |
| En tant que | Utilisateur                                                               |
| Je veux     | cliquer sur "Exporter le relevé vers la BDD" et choisir date ID du relevé |
| Afin de     | pouvoir consulter les enregistrements du relevé en BDD                    |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'export de données 
[] bouton "Export vers la BDD" permettant l'export vers la BDD des données importées dans l'appli 
[] afficher un message de confirmation que l'export des données vers la BDD a bien réussi

2 - Disposer des champs suivants dans la BDD :
[] ID Capteur
[] Date des enregistrements du relevé
[] Heure des enregistrements du relevé
[] Température relevée dans chaque enregistrement
[] Hygrométrie relevée dans chaque enregistrement

----------





| ID          | 2_0                                                                           |
|:----------- |-------------------------------------------------------------------------------|
| Titre       | **Afficher des données de synthèse**          			                      |
| Priorite    | ___???___                                                                     |
| Estimation  | ___?___                                                                       |
| En tant que | Utilisateur                                                                   |
| Je veux     | cliquer sur "Afficher synthèse relevé"  et choisir date ID du relevé          |
| Afin de     | obtenir ID capteur, nb données importées, date-h 1er et dernier enregistrement|

### DoD :

1 - Disposer d'une fonctionnalité permettant la récupération des enregistrements du relevé utiles à la synthèse
[] bouton "Afficher synthèse relevé"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Afficher les données suivantes :
[] ID du capteur
[] nombre de données importées totales
[] date - heure du 1er enregistrement
[] date - heure du dernier enregistrement

----------





| ID          | 2_1                                                                                     |
|:----------- |-----------------------------------------------------------------------------------------|
| Titre       | **Afficher des données de synthèse**          			                                |
| Priorite    | ___???___                                                                               |
| Estimation  | ___?___                                                                                 |
| En tant que | Utilisateur                                                                             |
| Je veux     | cliquer sur "Afficher synthèse relevé"  et choisir date & ID du relevé                  |
| Afin de     | faire des calculs sur le nb d'enregistrements, le temps, la température et l'hygrométrie|

### DoD :

1 - Disposer d'une fonctionnalité permettant la récupération des enregistrements du relevé utiles à la synthèse
[] bouton "Afficher synthèse relevé"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Afficher les données suivantes :
[] ID du capteur
[] nombre de données importées totales
[] date - heure du 1er enregistrement
[] date - heure du dernier enregistrement
[] nombre d'enregistrements
[] amplitude de temps de relevé en heure et minutes
[] température max/min/moyenne
[] hygrométrie max/min/moyenne

----------





| ID          | 3_0                                                                |
|:----------- |--------------------------------------------------------------------|
| Titre       | **Afficher les données de chaque relevé sous forme de tableau**    |
| Priorite    | ___???___                                                          |
| Estimation  | ___?___                                                            |
| En tant que | Utilisateur                                                        |
| Je veux     | cliquer sur "Afficher tableau relevé" et choisir ID & date relevé  |
| Afin de     | visualiser un relevé sous forme de tableau                         |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'affichage d'un tableau :
[] bouton "Afficher tableau relevé"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Afficher pour chaque enregistrement les données suivantes :
[] n° de l'enregistrement
[] ID du capteur
[] date - heure de l'enregistrement
[] température relevée
[] hygrométrie relevée

----------





| ID          | 3_1                                                                |
|:----------- |--------------------------------------------------------------------|
| Titre       | **Afficher les données de chaque relevé sous forme de tableau**    |
| Priorite    | ___???___                                                          |
| Estimation  | ___?___                                                            |
| En tant que | Utilisateur                                                        |
| Je veux     | cliquer sur "Afficher tableau relevé" et choisir ID & date relevé  |
| Afin de     | pouvoir trier sur les champs du tableau                            |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'affichage d'un tableau :
[] bouton "Afficher tableau relevé"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Pouvoir trier les enregistrement du tableau selon les critères suivants :
[] n° de l'enregistrement
[] date - heure de l'enregistrement
[] température relevée
[] hygrométrie relevée

----------





| ID          | 4_0                                                                |
|:----------- |--------------------------------------------------------------------|
| Titre       | **Afficher les données de chaque relevé sous forme de graphique**  |
| Priorite    | ___???___                                                          |
| Estimation  | ___?___                                                            |
| En tant que | Utilisateur                                                        |
| Je veux     | cliquer sur "Afficher graphique relevé" et choisir ID & date relevé|
| Afin de     | pouvoir visualiser les courbes de température et hygrométrie       |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'affichage d'un graphique :
[] bouton "Afficher graphique relevé"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Obtenir l'affichage d'un graphique avec :
[] axe des abscisses = temps
[] axe des ordonnées = gradations
[] courbe évolution températures relevées
[] courbe évolutions hygrométries relevées

----------





| ID          | 5_0                                                                    |
|:----------- |------------------------------------------------------------------------|
| Titre       | **Exporter les données**                                               |
| Priorite    | ___???___                                                              |
| Estimation  | ___?___                                                                |
| En tant que | Utilisateur                                                            |
| Je veux     | cliquer sur "Exporter relevé au format CSV" et choisir ID & date relevé|
| Afin de     | pouvoir exporter un relevé au format CSV                               |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'export :
[] bouton "Exporter relevé au format CSV"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Obtenir l'affichage d'un message indiquant le succès de l'export du relevé au format CSV

----------





| ID          | 6_0                                                                                                         |
|:----------- |-------------------------------------------------------------------------------------------------------------|
| Titre       | **Afficher un rapport au format PDF**                                                                       |
| Priorite    | ___???___                                                                                                   |
| Estimation  | ___?___                                                                                                     |
| En tant que | Utilisateur                                                                                                 |
| Je veux     | cliquer sur "Afficher au format PDF" et choisir ID & date relevé                                            |
| Afin de     | afficher un rapport pdf comprenant les données de synthèse, le tableau et le graphique du relevé selectionné|

### DoD :

1 - Disposer d'une fonctionnalité permettant l'export :
[] bouton "Afficher au format PDF"
[] avoir la possibilité de sélectionner le numéro de capteur et la date du relevé à afficher

2 - Obtenir un rapport PDF affichant pour le relevé :
[] les données de synthèse
[] le tableau
[] le graphique

----------





| ID          | 6_1                                    |
|:----------- |----------------------------------------|
| Titre       | **Imprimer un rapport au format PDF**  |
| Priorite    | ___???___                              |
| Estimation  | ___?___                                |
| En tant que | Utilisateur                            |
| Je veux     | cliquer sur "Imprimer le rapport"      |
| Afin de     | imprimer un rapport                    |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'export :
[] bouton "Imprimer le rapport"

2 - Obtenir un aperçu avant impression du rapport 

----------





| ID          | 6_2                                            |
|:----------- |------------------------------------------------|
| Titre       | **Envoyer par mail un rapport au format PDF**  |
| Priorite    | ___???___                                      |
| Estimation  | ___?___                                        |
| En tant que | Utilisateur                                    |
| Je veux     | cliquer sur "Envoyer le rapport"               |
| Afin de     | envoyer le rapport par mail                    |

### DoD :

1 - Disposer d'une fonctionnalité permettant l'envoi par mail :
[] bouton "Envoi par mail" qui ouvre une fenêtre de création de mail

2 - Dans la fenêtre de création de mail générée, avoir :
[] champ de saisie du destinataire
[] champ de saisie de l'objet pré-rempli avec l'ID du capteur et la date du relevé
[] corps du message pré-rempli avec des informations pertinentes
[] bouton "envoyer" qui envoie le mail au destinataire saisi

3 - Vérifier que l'adresse mail du destinataire saisie est correcte

----------
