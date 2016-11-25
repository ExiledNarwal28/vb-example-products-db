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