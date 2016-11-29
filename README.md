# AUT2016 - VB.NET - TP3 #

Ceci est le travail TP3 en VB.NET, fait par moi (Fabien Roy).

C'est une gestion d'inventaire de COOP de c�gep qui utilise SQL Server 2014 et LinQ.

## Liste de bugs/features ## 

Ce que je n'ai pas eu le temps d'ajouter (features) : 
	- L'inventaire ne devrait pas avoir � aller chercher les donn�es quand on annule l'ajout/la modification

Ce que je n'ai pas eu le temps de r�gler (bugs) : 

Ce que je n'ai pas eu � regler (vieux bugs/features du TP1 qui ne n�c�ssitent pas de correction) : 
	- Le formulaire FormAjoutItem construit lui-m�me un datarow et l'envoie dans le DataTable Items. Il faudrait que ce soit g�rer enti�rement par DataTableTravailleur.
	- Faire marcher le filtre des items s�lectionn�s et la recherche en m�me temps
	- S'il y a trop d'items dans la facture et que le formulaire d'affichage de facture d�passe l'�cran, l'impression ne comportera pas la page au complet (parce que je me sers d'une capture d'�cran pour l'impression)

## Choses � faire ##

### LinQ + inventaire ###

	1 [x] Adapter le DGV � LinQ
	1 [x] Adapter Insert � LinQ
	1 [x] Adapter Update � LinQ
	1 [x] Adapter Delete � LinQ
	1 [ ] V�rifier pour les prix d'achats
	3 [ ] Adapter filtres � LinQ
	3 [ ] Faire fonctionner le total d'inventaire

### LinQ + factures ###

	1 [ ] Adapter le DGV de factures � LinQ
	1 [ ] Adapter l'ajout d'�l�ments � la facture � LinQ
	1 [ ] Faire fonctionner la facture comme au TP1 avec LinQ
	2 [ ] Baisser l'inventaire des factures avec LinQ
	2 [ ] Ajouter les factures � la base de donn�es lors de la cr�ation
	3 [ ] Faire fonctionner l'impression comme au TP1 avec LinQ

### Tab des factures ###
	
	2 [ ] Faire les procedures stock�es de select
	2 [ ] Faire les procedures stock�es d'insert
	2 [ ] Faire les procedures stock�es d'update
	2 [ ] Faire les procedures stock�es de delete
	2 [ ] Faire le DGV des factures
	2 [ ] Faire l'ajout de factures
	2 [ ] Faire la modification de factures
	2 [ ] Faire la suppresion de factures

### Gestion de droits ###

	1 [ ] Demander une connexion au d�part du programme
	2 [ ] Faire les procedures stock�es de select d'utilisateur
	2 [ ] Faire les procedures stock�es de select d'utilisateur + des droits (au besoin)
	2 [ ] Faire les procedures stock�es d'insert d'utilisateur
	2 [ ] Faire les procedures stock�es d'update d'utilisateur
	2 [ ] Faire les procedures stock�es d'update d'utilisateur + des droits (au besoin)
	2 [ ] Faire les procedures stock�es de suppresion d'utilisateur
	3 [ ] Pouvoir se d�connnecter

### Application des droits ###

	2 [ ] Mettre les droits dans les variables globales
	3 [ ] Faire le bit 1 - Utilisateur Select (Permet le DGV + le Tab)
	3 [ ] Faire le bit 2 - Utilisateur Insert (Permet le bouton)
	3 [ ] Faire le bit 4 - Utilisateur Update infos (Permet le bouton)
	3 [ ] Faire le bit 8 - Utilisateur Delete (Permet le bouton)
	3 [ ] Faire le bit 16 - Utilisateur Update droits (Change le DGV)
	3 [ ] Faire le bit 32 - Inventaire Select (Permet le DGV +  le Tab) <- L'utilisateur ne pourra pas produire de factures
	3 [ ] Faire le bit 64 - Inventaire Insert (Permet le bouton)
	3 [ ] Faire le bit 128 - Inventaire Update (Permet le bouton)
	3 [ ] Faire le bit 256 - Inventaire Delete (Permet le bouton)
	3 [ ] Faire le bit 512 - Inventaire Estimations (Permet le Textbox)
	3 [ ] Faire le bit 1024 - Factures Select (Permet le DGV + le Tab)
	3 [ ] Faire le bit 2048 - Factures Insert (Permet le bouton)
	3 [ ] Faire le bit 4096 - Factures Update (Permet le bouton)

### ConnexionString ###

	1 [ ] Pouvoir choisir l'addresse du ConnectionString en se connectant

## Historiques des versions de LISEZMOI.md ##

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