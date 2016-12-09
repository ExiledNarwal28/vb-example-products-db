Option Explicit On
Option Strict On

Imports System.IO
Imports System.Xml.Serialization

Public Class DataTableTravailleur
  Private ItemsTable As DataTable
  ' Private DBContexte As COOPInventaireEntities
  Private DBContexte As COOPInventaire_TP3_testsEntities2

  Public Sub New()
    ItemsTable = New DataTable("Items")

    Try
      DBContexte = New COOPInventaire_TP3_testsEntities2()
    Catch ex As Exception
      ' TODO
    End Try
  End Sub

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

  Public Sub GetDataUtilisateur()

  End Sub

  Public Sub InsertUtilisateur(ByVal Prenom As String,
                        ByVal Nom As String,
                        ByVal Username As String,
                        ByVal Courriel As String,
                        ByVal Password As String,
                        ByVal Droits As Int16)
  End Sub

  Public Sub UpdateUtilisateur(ByVal iD As Int32,
                        ByVal Prenom As String,
                        ByVal Nom As String,
                        ByVal Username As String,
                        ByVal Courriel As String,
                        ByVal Password As String,
                        ByVal Droits As Int16)
  End Sub

  Public Sub DeleteUtilisateur()

  End Sub

  Public Sub Sauvegarder()
    Try
      DBContexte.SaveChanges()
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  ' Méthode qui recoit un dictionnaire d'item_id et d'item_qt pour enlever des items de l'inventaire
  Public Sub EnleverQuantite(ByVal DictQuantites As Dictionary(Of Integer, Integer))
    ' Source : http://stackoverflow.com/questions/18628917/how-can-iterate-in-dictionary-in-vb-net
    For Each Paire As KeyValuePair(Of Integer, Integer) In DictQuantites
      DBContexte.ReduireQtInventaireComplet(Paire.Key, Paire.Value)
    Next
  End Sub

  Public Function ObtenirDataViewRech(ByVal Recherche() As String, ByVal NomTable As String) As DataView
    ' Cette fonction retourne un DataView filtré en fonction de la table (chaque table est filtrée différement)

    ' Dim Table As DataTable = ObtenirDataTable(NomTable)
    ' Dim dv As DataView = New DataView(Table)

    If True Then ' Not Table Is Nothing Then
      ' Source : http://vb.net-informations.com/datagridview/vb.net_datagridview_sort.htm
      ' Source : http://stackoverflow.com/questions/1137020/filtering-dataview-with-multiple-columns
      ' Source : http://www.codeproject.com/Questions/350692/How-to-use-Row-Filter-with-Like

      Dim Filtre As String = ""

      Select Case NomTable
        Case "Items"
          ' La recherche dans la table "Items" se fait par code de produit, par description, par emplacement, par nom de catégorie
          ' Par nom de département ou par nom de fournisseur

          For Index As Integer = 0 To 5
            If Recherche(Index).Trim.Length > 0 Then
              ' TOADD : un dictionnaire ou wtv serait mieux

              ' Ceci est nécéssaire, car SQL haït le caractère : '
              Recherche(Index) = Recherche(Index).Replace("'", "''")

              Select Case Index
                Case 0
                  ' Code de produit
                  ' Filtre &= Table.Columns(1).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 1
                  ' Description
                  ' Filtre &= Table.Columns(9).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 2
                  ' Emplacement
                  ' Filtre &= Table.Columns(10).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 3
                  ' Nom de catégorie
                  ' Filtre &= Table.Columns(3).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 4
                  ' Nom de département
                  ' Le département doit être écrit entièrement, pour des raisons de practicité
                  ' Filtre &= Table.Columns(2).ColumnName & " = '" & Recherche(Index) & "' AND "
                Case 5
                  ' Nom de fournisseur
                  ' Filtre &= Table.Columns(4).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
              End Select
            End If
          Next
          ' On a pas à vérifier si le filtre est "", puisque c'est certain qu'il ne l'est pas.
          Filtre = Filtre.Substring(0, Filtre.Length - 5)

          ' dv.RowFilter = Filtre
        Case Else
          ' Le nom de la table est invalide
          ' On ne veut donc rien retourner
          ' dv = Nothing
      End Select

      ' On retourne le résultat
      Return Nothing ' dv
    End If

    ' Si la Table n'est pas spécifiée, alors on ne retourne rien.
    Return Nothing
  End Function

End Class