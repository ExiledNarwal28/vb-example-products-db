#AUT2016 - VB.NET - TP3#

Ceci est le travail TP3 en VB.NET, fait par moi (Fabien Roy).

C'est une gestion d'inventaire de COOP de cégep qui utilise SQL Server 2014 et LinQ.

##Liste de bugs/features##

###Ce que je n'ai pas eu le temps d'ajouter (features)###
	L'inventaire ne devrait pas avoir à aller chercher les données quand on annule l'ajout/la modification
	Les utilisateurs ne sont pas liés à un utilisateur SQL Server 2014. Les droits et l'identification sont parfaitement fonctionnel

###Ce que je n'ai pas eu le temps de règler (bugs)###
	(Rien)

###Ce que je n'ai pas eu à regler (vieux bugs/features du TP1 qui ne nécéssitent pas de correction)###
	Faire marcher le filtre des items sélectionnés et la recherche en même temps
	S'il y a trop d'items dans la facture et que le formulaire d'affichage de facture dépasse l'écran, l'impression ne comportera pas la page au complet (parce que je me sers d'une capture d'écran pour l'impression)

## Choses à faire ##

### LinQ + inventaire ###

	1 [x] Adapter le DGV à LinQ
	1 [x] Adapter Insert à LinQ
	1 [x] Adapter Update à LinQ
	1 [x] Adapter Delete à LinQ
	1 [x] Vérifier pour les prix d'achats
	3 [x] Adapter filtres à LinQ
	3 [x] Faire fonctionner le total d'inventaire
	4 [ ] Bug de total d'inventaire quand on filtre seulement la sélection

### LinQ + factures ###

	1 [x] Vérifier pourquoi ce n'est pas les bons inventaires qui sont affichés
	1 [x] Réparer le DGV et les quantités
	1 [x] Vérifier qu'il y a une sélection avant d'envoyer vers la facture
	1 [x] Adapter le DGV de factures à LinQ
	1 [x] Adapter l'ajout d'éléments à la facture à LinQ
	1 [x] Faire fonctionner la facture comme au TP1 avec LinQ
	2 [x] Baisser l'inventaire des factures avec LinQ
	3 [x] Faire fonctionner l'impression comme au TP1 avec LinQ
	3 [x] Bug de total de facture

### Tab des factures ###
	
	2 [ ] Faire les procedures stockées de select
	2 [ ] Faire les procedures stockées d'insert
	2 [x] Faire le tab des factures
	2 [ ] Faire le DGV des factures
	2 [ ] Faire l'ajout de factures
	5 [ ] Filtrage par ? (TODO)

### Utilisateurs de la base de données ###

	2 [D] Faire en sorte que le login est pour un utilisateur de la base de données
	2 [x] Demander une connexion au départ du programme
	2 [D] Pouvoir choisir l'addresse du ConnectionString en se connectant
	2 [x] Lier la table Utilisateur avec les logins sur la base de données
	2 [x] Aller chercher les droits des utilisateurs
	3 [x] Construire le tab des utilisateurs
	3 [x] Faire le DGV des utilisateurs
	3 [x] Faire le formulaire de manipulation d'utilisateur
	3 [x] Faire les procedures stockées de select d'utilisateur
	3 [x] Avoir une procédure stockée pour l'insert d'utilisateurs de la base de données
	3 [x] Avoir une procédure stockée pour l'update d'utilisateurs de la base de données
	3 [x] Avoir une procédure stockée pour le delete d'utilisateurs de la base de données
	5 [x] Filtrage par Nom
	5 [x] Filtrage par Prenom
	5 [x] Filtrage par Username
	5 [x] Filtrage par Courriel

### Gestion de droits ###

	3 [x] Pouvoir se déconnnecter

### Application des droits ###

	2 [x] Mettre les droits dans les variables globales
	3 [x] Faire le bit - Utilisateur Select (Permet le DGV + le Tab)
	3 [x] Faire le bit - Utilisateur Insert (Permet le bouton)
	3 [x] Faire le bit - Utilisateur Update (Permet le bouton)
	3 [x] Faire le bit - Utilisateur Delete (Permet le bouton)
	3 [x] Faire le bit - Inventaire Select (Permet le DGV +  le Tab)
	3 [x] Faire le bit - Inventaire Insert (Permet le bouton)
	3 [x] Faire le bit - Inventaire Update (Permet le bouton)
	3 [x] Faire le bit - Inventaire Delete (Permet le bouton)
	3 [x] Faire le bit - Inventaire Admin (Permet le Textbox d'estimations + prix achat)
	3 [x] Faire le bit - Factures Select (Permet le DGV + le Tab)
	3 [x] Faire le bit - Factures Insert (Permet le bouton)
	3 [x] Faire le bit - Factures Update (Permet le bouton)
	3 [x] Faire le bit - Factures Delete (Permet le bouton)

### Autre ###
	
	1 [ ] Supprimer les fichiers du TP1
	1 [ ] Renommer README.md en LISEZMOI.md
	1 [ ] Vérifier les TODO dans le programme
	5 [ ] Règler les anchors

## Historiques des versions de LISEZMOI.md ##

Ceci est mon travail TP1 en VB.net.

C'est une gestion d'inventaire de coop par fichiers textes.

Cela comprends :
	- L'affichage des items
	- L'ajout d'items
	- La modification d'items
	- La suppression d'items
	- Le calcul de données administratives (totaux)
	- La connexion administrateur
	- L'interface administrateur
	- La facturation (avec vérification et suppression de quantités)
	- L'impression de facture
	- La sauvegarde de la table "Items" dans un fichier.
	- Sélection des items par checkbox.
	- Un filtre pour voir seulement les items sélectionnés.

Ce que je n'ai pas eu le temps d'ajouter (features) : 
	- Enregistrement en binaire, compression et encryption. L'enregistrement de base est fonctionnel.
	- Le formulaire FormAjoutItem construit lui-même un datarow et l'envoie dans le DataTable Items. Il faudrait que ce soit gèrer entièrement par DataTableTravailleur.
	- Faire marcher le filtre des items sélectionnés et la recherche en même temps

Ce que je n'ai pas eu le temps de règler (bugs) : 
	- S'il y a trop d'items dans la facture et que le formulaire d'affichage de facture dépasse l'écran, l'impression ne comportera pas la page au complet (parce que je me sers d'une capture d'écran pour l'impression)
	- Dans la méthode LireDataTable de DataTableTravailleur, la façon de lire la table n'est pas valide. Je crois que j'ai un problème de référence.

Dans mon code, on peut parfois voir des commentaires spécifiques
	TODO : petit mémo à moi-même
	TOFIX : bugs à règler
	TOADD : ajout à faire (feature)

Je préfère laisser ces commentaires dans mon codes, puisque certains aident à cerner les erreurs dont je parle ici et puisque cela va m'être utile dans le TP2.