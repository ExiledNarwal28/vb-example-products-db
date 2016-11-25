Option Explicit On
Option Strict On

Imports System.IO
Imports System.Xml.Serialization

Public Class DataTableTravailleur
  Private ItemsTable As DataTable
  Private DBContexte As COOPInventaireEntities

  Public Sub New()
    ItemsTable = New DataTable("Items")

    Try
      DBContexte = New COOPInventaireEntities()
    Catch ex As Exception
      ' TODO
    End Try
  End Sub

  Public Function GetDataInventaireComplet() As List(Of TP1_VB.SelectInventaireComplet_Result)
    Return DBContexte.SelectInventaireComplet.ToList
  End Function

  Public Sub LireDataTable(ByVal NomFichier As String, ByVal NomTable As String)
    ' Méthode pour lire une base de données à partir d'un fichier
    ' TOADD : Désencryption, décompression, lecture du binaire et conversion du binaire

    Dim Table As DataTable = ObtenirDataTable(NomTable)

    If Not Table Is Nothing And My.Computer.FileSystem.FileExists(NomFichier) Then
      ' DecrypterFichier(NomFichier)
      ' DecompresserFichier(NomFichier)
      ' TOFIX : ceci n'est pas valide. Problème de référence?
      ItemsTable = DeserialiserDataTable(NomFichier)
    End If
  End Sub

  Public Sub EnregistrerDataTable(ByVal NomFichier As String, ByVal NomTable As String)
    ' Méthode pour écrire les données d'une table dans un fichier.
    ' TOADD : Conversion en binaire, enregistrement du binaire, compression et encryption

    Dim Table As DataTable = ObtenirDataTable(NomTable)

    If Not Table Is Nothing Then
      SerialiserDataTable(Table, NomFichier)
      ' CompresserFichier(NomFichier)
      ' EncrypterFichier(NomFichier)
    End If
  End Sub
  Public Sub EnregistrerDataTables()
    Me.EnregistrerDataTable("items_db", "Items")
    ' S'il y a d'autres DataTable à enregistrer, c'est ici
    ' Ceci sera d'avantage utile dans le futur
  End Sub
  Public Function DeserialiserDataTable(ByVal NomFichier As String) As DataTable
    ' Source : http://www.vb-helper.com/howto_net_serialize.html

    ' Lire un fichier 
    Dim xml_serializer As New XmlSerializer(GetType(DataTable))
    Dim objStreamReader As StreamReader = New StreamReader(NomFichier)
    Dim tempTable As DataTable = DirectCast(xml_serializer.Deserialize(objStreamReader), DataTable)

    objStreamReader.Close()

    Return tempTable
  End Function

  Public Sub SerialiserDataTable(ByVal Table As DataTable, ByVal NomFichier As String)
    ' Source : https://support.microsoft.com/en-us/kb/316730

    ' Sérialise un DataTable en un fichier texte
    Dim objStreamWriter As New StreamWriter(NomFichier)
    Dim x As New XmlSerializer(Table.GetType)
    x.Serialize(objStreamWriter, Table)
    objStreamWriter.Close()
  End Sub

  Public Function ObtenirDataTable(ByVal NomTable As String) As DataTable
    ' Fonction pour obtenir une table en fonction d'un string envoyer. Utile pour le futur du programme
    Select Case NomTable
      Case "Items"
        Return Me.ItemsTable
      Case Else
        Return Nothing
    End Select
  End Function

  Public Function ObtenirRangees(ByVal NomTable As String, ByVal ListeId As List(Of Integer)) As List(Of DataRow)
    ' Fonction pour obtenir une table en fonction d'un string envoyer. Utile pour le futur du programme

    Dim Table As DataTable = ObtenirDataTable(NomTable)
    Dim RangeesSelection As List(Of DataRow) = New List(Of DataRow)

    For Each Id In ListeId
      RangeesSelection.Add(Table.Select("item_id = " & Id)(0))
    Next

    Return RangeesSelection
  End Function

  Public Sub EnleverQuantite(ByVal DictQuantites As Dictionary(Of Integer, Integer))
    ' Méthode qui recoit un dictionnaire d'item_id et d'item_qt pour enlever des items de l'inventaire
    ' TOADD : Pour le future du programme, lorsqu'un item tombe à 0 de qt, obsolete = True

    ' La seule table dont on enlève des quantités est Items
    Dim Table As DataTable = ObtenirDataTable("Items")

    ' Source : http://stackoverflow.com/questions/18628917/how-can-iterate-in-dictionary-in-vb-net
    For Each Paire As KeyValuePair(Of Integer, Integer) In DictQuantites
      Dim dr As DataRow = Table.Select("item_id = " & Paire.Key)(0)
      dr("item_qt") = CInt(dr("item_qt")) - Paire.Value
    Next
  End Sub

  Public Function ObtenirDataViewRech(ByVal Recherche() As String, ByVal NomTable As String) As DataView
    ' Cette fonction retourne un DataView filtré en fonction de la table (chaque table est filtrée différement)

    Dim Table As DataTable = ObtenirDataTable(NomTable)
    Dim dv As DataView = New DataView(Table)

    If Not Table Is Nothing Then
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
                  Filtre &= Table.Columns(1).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 1
                  ' Description
                  Filtre &= Table.Columns(9).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 2
                  ' Emplacement
                  Filtre &= Table.Columns(10).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 3
                  ' Nom de catégorie
                  Filtre &= Table.Columns(3).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
                Case 4
                  ' Nom de département
                  ' Le département doit être écrit entièrement, pour des raisons de practicité
                  Filtre &= Table.Columns(2).ColumnName & " = '" & Recherche(Index) & "' AND "
                Case 5
                  ' Nom de fournisseur
                  Filtre &= Table.Columns(4).ColumnName & " LIKE '%" & Recherche(Index) & "%' AND "
              End Select
            End If
          Next
          ' On a pas à vérifier si le filtre est "", puisque c'est certain qu'il ne l'est pas.
          Filtre = Filtre.Substring(0, Filtre.Length - 5)

          dv.RowFilter = Filtre
        Case Else
            ' Le nom de la table est invalide
            ' On ne veut donc rien retourner
            dv = Nothing
      End Select

      ' On retourne le résultat
      Return dv
    End If

    ' Si la Table n'est pas spécifiée, alors on ne retourne rien.
    Return Nothing
  End Function

  ' ALLO ALLO ALLO LIRE CECI MERCI
  ' Les méthodes/fonctions suivantes ne sont pas utilisées.
  ' Je les ai laissé ici commentées pour montrer que j'ai réussi à convertir un fichier en binaire.
  ' Je n'ai pas eu le temps d'implémenter ceci dans mon programme.
  ' Je reste ceci ici surtout parce que je vais m'en servir plus tard.
  ' La dernière méthode commentée est un exemple de compression de fichier.

  'Private Sub EcrireStringABinaire(ByVal Chaine As String, ByVal NomFichier As String)
  '   Méthode qui recoit un String et l'écrit dans un fichier en binaire
  '   Exemple : EcrireStringABinaire("lol", "lol")
  '   Source : http://stackoverflow.com/questions/15867568/writing-bits-into-binary-file-in-vb-net

  '  Dim writer As BinaryWriter = New BinaryWriter(File.Open(NomFichier, FileMode.Append)) ' TODO : Append ?
  '  Using writer
  '    writer.Write(Chaine)
  '  End Using
  '  writer.Close()
  'End Sub

  'Private Function LireBinaireAString(ByVal NomFichier As String) As String
  '   Méthode qui recoit un nom de fichier binaire et retourne son contenu en String
  '   Exemple : MsgBox(LireBinaireAString("lol"))
  '   Source : http://stackoverflow.com/questions/15867568/writing-bits-into-binary-file-in-vb-net

  '  Dim Chaine As String

  '  If (File.Exists(NomFichier)) Then
  '    Dim reader As BinaryReader = New BinaryReader(File.Open(NomFichier, FileMode.Open))
  '    Using reader
  '      Chaine = reader.ReadString()
  '    End Using
  '    reader.Close()

  '    Return Chaine
  '  End If
  '  Return "" ' Retourne un String vide si le fichier n'est pas trouvé
  'End Function

  'Private Sub CompresserFichier(ByVal NomFichier As String)
  '  ' TODO : C'est de la merde, ça
  '  ' Source : http://stackoverflow.com/questions/6463280/how-do-i-discover-the-users-desktop-folder
  '  Dim DirTempo As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & NomFichier

  '  ' Source : https://msdn.microsoft.com/en-us/library/9wzc03ze.aspx
  '  ' On crée un dossier "temporaire"
  '  My.Computer.FileSystem.CreateDirectory(DirTempo)

  '  ' Source : https://msdn.microsoft.com/en-us/library/2t00swhw.aspx
  '  ' On déplace le fichier dans le dossier temporaire
  '  My.Computer.FileSystem.MoveFile(NomFichier, DirTempo & "\" & NomFichier)

  '  ' Source : https://msdn.microsoft.com/en-us/library/ms404280(v=vs.110).aspx
  '  ' On compresse le dossier temporaire
  '  ZipFile.CreateFromDirectory(DirTempo, DirTempo & ".zip")

  '  ' TODO : la suppression ne marche pas
  '  ' On supprime le contenu du dossier temporaire
  '  My.Computer.FileSystem.DeleteFile(DirTempo & "\" & NomFichier)

  '  ' Source : https://msdn.microsoft.com/en-us/library/24t911bf(v=vs.100).aspx
  '  ' On supprime le dossier temporaire
  '  My.Computer.FileSystem.DeleteDirectory(DirTempo, FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)
  'End Sub
End Class