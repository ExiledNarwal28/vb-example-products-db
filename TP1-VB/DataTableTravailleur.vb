Option Explicit On
Option Strict On

Imports System.IO
Imports System.Xml.Serialization

Public Class DataTableTravailleur
  Private UtilisateurID As Int32

  ' Private DBContexte As COOPInventaireEntities
  Private DBContexte As COOPInventaire_TP3_testsEntities1

  Public Sub New()
    UtilisateurID = Nothing ' = Aucun utilisateur

    Try
      DBContexte = New COOPInventaire_TP3_testsEntities1()
    Catch ex As Exception
      MsgBox("Erreur de connection au serveur")
    End Try
  End Sub

  ' ---> Connection et utilisateur actuel

  ' Méthode pour connecter l'utilisateur à la base de données
  Public Function Connection(ByVal Username As String,
                             ByVal Password As String) As Boolean

    ' TODO : Ce try catch est actuellement ma seule solution à une erreur étrange...
    Try
      UtilisateurID = CInt(DBContexte.SelectUtilisateurIDSingle(Username, Password).Single())
    Catch ex As Exception
      ' MsgBox(ex.Message)
    End Try

    If UtilisateurID = Nothing Then
      Return False
    End If

    Return True
  End Function

  Public Sub Deconnection()
    UtilisateurID = Nothing
  End Sub

  Public Function GetUtilisateurID() As Int32
    Return UtilisateurID
  End Function

  Public Function GetDroits() As Int16
    Return CShort(DBContexte.SelectUtilisateurDroitsSingle(UtilisateurID).Single())
  End Function

  ' ---> Inventaire

  ' Méthode qui retourne une liste de DataRows pour remplir un DataGridView
  Public Function GetDataInventaireComplet() As List(Of TP1_VB.SelectInventaireComplet_Result)
    Return DBContexte.SelectInventaireComplet.ToList
  End Function

  ' Méthode qui retourne un seul DataRow avec son Id
  Public Function GetDataInventaireCompletSingle(ByVal iD As Int32) As TP1_VB.SelectInventaireCompletSingle_Result
    ' Try catch au cas où la base de données serait corrompue et que 2 inventaires auraient le même ID
    Try
      Return DBContexte.SelectInventaireCompletSingle(iD).Single()
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Nothing
    End Try
  End Function

  ' Fonction pour avoir l'inventaire avec une liste d'id
  Function GetDataInventaireCompletParID(ListeID As List(Of Integer)) As IEnumerable(Of Object)
    ' Je sais que c'est une énorme requête. En gros, je recherche les données nécéssaire à l'inventaire pour les inventaires qui sont dans une liste
    Return (From Tb_Inventaire In DBContexte.Tb_Inventaire _
            Join Tb_Produit In DBContexte.Tb_Produit On Tb_Produit.ID Equals Tb_Inventaire.ProduitID _
            Join Tb_Emplacement In DBContexte.Tb_Emplacement On Tb_Inventaire.R1 Equals Tb_Emplacement.ID _
            Join Tb_Categorie In DBContexte.Tb_Categorie On Tb_Inventaire.CategorieID Equals Tb_Categorie.ID _
            Join Tb_Departement In DBContexte.Tb_Departement On Tb_Inventaire.DepartementID Equals Tb_Departement.ID _
            Join Tb_Fournisseur In DBContexte.Tb_Fournisseur On Tb_Inventaire.FournisseurID Equals Tb_Fournisseur.ID _
            Let Emplacement = Tb_Emplacement.Description
            Let CategorieNom = Tb_Categorie.Nom
            Let DepartementCode = Tb_Departement.Code
            Let FournisseurCode = Tb_Fournisseur.Code
            Let FournisseurNom = Tb_Fournisseur.Nom
            Where ListeID.Contains(Tb_Inventaire.ID) _
            Select New With {
            Tb_Inventaire.ID, _
            Tb_Produit.CodeProduit, _
            Tb_Produit.Description, _
            Emplacement, _
            CategorieNom, _
            DepartementCode, _
            FournisseurCode, _
            FournisseurNom,
            Tb_Inventaire.PrixVente,
            Tb_Inventaire.PrixAchat,
            Tb_Inventaire.Qt}).ToList()
  End Function
  Function GetDataInventaireFactureParID(ListeID As List(Of Integer)) As IEnumerable(Of Object)
    ' J'amène les champs réservés puisque j'ai besoin de colonnes de plus. Ils ne seront pas modifiés.
    Return (From Tb_Inventaire In DBContexte.Tb_Inventaire _
                      Join Tb_Produit In DBContexte.Tb_Produit On Tb_Produit.ID Equals Tb_Inventaire.ProduitID _
                      Where ListeID.Contains(Tb_Inventaire.ID) _
                      Select New With {Tb_Inventaire.ID, _
                      Tb_Produit.CodeProduit, _
                      Tb_Produit.Description, _
                      Tb_Inventaire.R1, _
                      Tb_Inventaire.PrixVente, _
                      Tb_Inventaire.R2, _
                      Tb_Inventaire.Qt, _
                      Tb_Inventaire.R3}).ToList()
  End Function

  ' Méthode pour insérer dans l'inventaire complet
  Public Sub InsertInventaireComplet(ByVal codeProduit As String, ByVal description As String, ByVal emplacement As String, ByVal categorie As String, ByVal departement As String, ByVal fournisseurCode As String, ByVal fournisseurNom As String, ByVal prixVente As Double, ByVal prixAchat As Double, ByVal qt As Int32)
    DBContexte.InsertInventaireComplet(codeProduit, description, emplacement, categorie, departement, fournisseurCode, fournisseurNom, prixVente, prixAchat, qt)
    Me.Sauvegarder()
  End Sub

  Public Sub UpdateInventaireComplet(ByVal iD As Int32, ByVal codeProduit As String, ByVal description As String, ByVal emplacement As String, ByVal categorie As String, ByVal departement As String, ByVal fournisseurCode As String, ByVal fournisseurNom As String, ByVal prixVente As Double, ByVal prixAchat As Double, ByVal qt As Int32)
    DBContexte.UpdateInventaireComplet(iD, codeProduit, description, emplacement, categorie, departement, fournisseurCode, fournisseurNom, prixVente, prixAchat, qt)
    Me.Sauvegarder()
  End Sub

  Public Sub DeleteInventaireComplet(ByVal iD As Int32)
    DBContexte.DeleteInventaireComplet(iD)
    Me.Sauvegarder()
  End Sub

  ' Méthode qui recoit un dictionnaire d'item_id et d'item_qt pour enlever des items de l'inventaire
  Public Sub EnleverQuantite(ByVal DictQuantites As Dictionary(Of Integer, Integer))
    ' Source : http://stackoverflow.com/questions/18628917/how-can-iterate-in-dictionary-in-vb-net
    For Each Paire As KeyValuePair(Of Integer, Integer) In DictQuantites
      DBContexte.ReduireQtInventaireComplet(Paire.Key, Paire.Value)
    Next
  End Sub

  ' Cette fonction retourne des données d'inventaire filtré
  Public Function GetDataInventaireCompletFiltre(ByVal codeProduit As String,
                                      ByVal description As String,
                                      ByVal emplacement As String,
                                      ByVal categorie As String,
                                      ByVal departement As String,
                                      ByVal fournisseur As String) As List(Of TP1_VB.SelectInventaireCompletFiltre_Result)
    Return DBContexte.SelectInventaireCompletFiltre(codeProduit,
                                                    description,
                                                    emplacement,
                                                    categorie,
                                                    departement,
                                                    fournisseur).ToList
  End Function

  ' ---> Utilisateur

  Public Function GetDataUtilisateur() As List(Of TP1_VB.SelectUtilisateur_Result)
    Return DBContexte.SelectUtilisateur().ToList()
  End Function

  ' Méthode qui retourne un seul DataRow avec son Id
  Public Function GetDataUtilisateurSingle(ByVal iD As Int32) As TP1_VB.SelectUtilisateurSingle_Result
    ' Try catch au cas où la base de données serait corrompue et que 2 utilisateurs auraient le même ID
    Try
      Return DBContexte.SelectUtilisateurSingle(iD).Single()
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Nothing
    End Try
  End Function

  Public Sub InsertUtilisateur(ByVal Prenom As String,
                               ByVal Nom As String,
                               ByVal Username As String,
                               ByVal Courriel As String,
                               ByVal Password As String,
                               ByVal Droits As Int16)

    DBContexte.InsertUtilisateur(Username,
                                 Password,
                                 Courriel,
                                 Nom,
                                 Prenom,
                                 Droits)

    Me.Sauvegarder()
  End Sub

  Public Sub UpdateUtilisateur(ByVal iD As Int32,
                               ByVal Prenom As String,
                               ByVal Nom As String,
                               ByVal Username As String,
                               ByVal Courriel As String,
                               ByVal Password As String,
                               ByVal Droits As Int16)

    DBContexte.UpdateUtilisateur(iD,
                                 Username,
                                 Password,
                                 Courriel,
                                 Nom,
                                 Prenom,
                                 Droits)

    Me.Sauvegarder()
  End Sub

  Public Sub DeleteUtilisateur(ByVal iD As Int32)
    DBContexte.DeleteUtilisateur(iD)
    Me.Sauvegarder()
  End Sub

  ' Cette fonction retourne des données d'inventaire filtré
  Public Function GetDataUtilisateurFiltre(ByVal Nom As String,
                                           ByVal Prenom As String,
                                           ByVal Courriel As String,
                                           ByVal Username As String) As List(Of TP1_VB.SelectUtilisateurFiltre_Result)
    Return DBContexte.SelectUtilisateurFiltre(Username,
                                              Courriel,
                                              Nom,
                                              Prenom).ToList
  End Function

  ' ---> Factures

  ' Méthode pour afficher les factures
  Public Function GetDataFacture() As List(Of TP1_VB.SelectFacture_Result)
    Return DBContexte.SelectFacture().ToList()
  End Function

  Public Function GetDataFactureFiltre(ByVal ID As String,
                                       ByVal Utilisateur As String,
                                       ByVal FactureDate As String,
                                       ByVal NoEtu As String) As List(Of TP1_VB.SelectFactureFiltre_Result)
    Return DBContexte.SelectFactureFiltre(ID,
                                          Utilisateur,
                                          FactureDate,
                                          NoEtu).ToList()
  End Function

  ' Fonction pour trouver les FactureItems associés à une facture
  Public Function GetDataFactureDetails(ByVal ID As Int32) As List(Of TP1_VB.SelectFactureItemByFactureID_Result)
    Return DBContexte.SelectFactureItemByFactureID(ID).ToList()
  End Function

  ' Fonction pour trouver une code d'étudiant avec un ID de facture
  Public Function GetFactureCodeEtu(ByVal ID As Int32) As String
    ' Try catch, au cas ou les ID sont doublés
    Try
      Return CStr((From Tb_Facture In DBContexte.Tb_Facture _
                        Where Tb_Facture.ID = ID _
                        Select Tb_Facture.R1).Single())
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Nothing
    End Try
  End Function

  ' Function pour trouver le nombre d'items d'une facture
  Public Function GetFactureNbItems(ByVal ID As Int32) As Int32
    ' Try catch, au cas ou les ID sont doublés
    Try
      Return CInt(Aggregate Tb_FactureItem In DBContexte.Tb_FactureItem _
                  Where Tb_FactureItem.FactureID = ID _
                  Into Sum(Tb_FactureItem.Qt))
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Nothing
    End Try
  End Function

  ' Function pour trouver le total d'une facture
  Public Function GetFactureTotal(ByVal ID As Int32) As Double
    ' Try catch, au cas ou les ID sont doublés
    Try
      Return CDbl(Aggregate Tb_FactureItem In DBContexte.Tb_FactureItem _
                  Where Tb_FactureItem.FactureID = ID _
                  Into Sum(Tb_FactureItem.Qt * Tb_FactureItem.PrixVente))
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Nothing
    End Try
  End Function

  ' Function pour trouver le grand total d'une facture
  Public Function GetFactureGrandTotal(ByVal ID As Int32) As Double
    ' Try catch, au cas ou les ID sont doublés
    Try
      Dim total As Double = CDbl(Aggregate Tb_FactureItem In DBContexte.Tb_FactureItem _
                                 Where Tb_FactureItem.FactureID = ID _
                                 Into Sum(Tb_FactureItem.Qt * Tb_FactureItem.PrixVente))
      total = CDec(total + (total * VariablesGlobales.TPS_VALEUR))
      total = CDec(total + (total * VariablesGlobales.TVQ_VALEUR))

      Return total
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Nothing
    End Try
  End Function


  ' Méthode pour insérer une facture
  Public Sub InsertFacture(ByVal NoEtu As String,
                           ByVal DictQuantites As Dictionary(Of Integer, Integer))
    Dim FactureID As Int32

    ' D'abord, on crée la facture
    FactureID = CInt(DBContexte.InsertFacture(UtilisateurID,
                                         Date.Now,
                                         NoEtu).Single()) ' Ceci retourne le ID de la facture qu'on vient de créer

    ' Ensuite, on crée un FactureItem pour chaque item de la facture
    ' Key = InventaireId, Value = Qt
    For Each Paire As KeyValuePair(Of Integer, Integer) In DictQuantites
      DBContexte.InsertFactureItem(FactureID,
                                   Paire.Key,
                                   Paire.Value)
    Next
  End Sub

  ' ---> Autre

  Public Sub Sauvegarder()
    Try
      DBContexte.SaveChanges()
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
End Class