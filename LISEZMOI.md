Ceci est mon travail TP1 en VB.net.

C'est une gestion d'inventaire de coop par fichiers textes.

Cela comprends :
	- L'affichage des items
	- L'ajout d'items
	- La modification d'items
	- La suppression d'items
	- Le calcul de donn�es administratives (totaux)
	- La connexion administrateur
	- L'interface administrateur
	- La facturation (avec v�rification et suppression de quantit�s)
	- L'impression de facture
	- La sauvegarde de la table "Items" dans un fichier.
	- S�lection des items par checkbox.
	- Un filtre pour voir seulement les items s�lectionn�s.

Ce que je n'ai pas eu le temps d'ajouter (features) : 
	- Enregistrement en binaire, compression et encryption. L'enregistrement de base est fonctionnel.
	- Le formulaire FormAjoutItem construit lui-m�me un datarow et l'envoie dans le DataTable Items. Il faudrait que ce soit g�rer enti�rement par DataTableTravailleur.
	- Faire marcher le filtre des items s�lectionn�s et la recherche en m�me temps

Ce que je n'ai pas eu le temps de r�gler (bugs) : 
	- S'il y a trop d'items dans la facture et que le formulaire d'affichage de facture d�passe l'�cran, l'impression ne comportera pas la page au complet (parce que je me sers d'une capture d'�cran pour l'impression)
	- Dans la m�thode LireDataTable de DataTableTravailleur, la fa�on de lire la table n'est pas valide. Je crois que j'ai un probl�me de r�f�rence.

Dans mon code, on peut parfois voir des commentaires sp�cifiques
	TODO : petit m�mo � moi-m�me
	TOFIX : bugs � r�gler
	TOADD : ajout � faire (feature)

Je pr�f�re laisser ces commentaires dans mon codes, puisque certains aident � cerner les erreurs dont je parle ici et puisque cela va m'�tre utile dans le TP2.