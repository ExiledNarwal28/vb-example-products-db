Option Explicit On
Option Strict On

Imports System.IO
Imports System.IO.Compression
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Text
Imports System.Xml.Serialization

Public Class FormInventaire
  Private DataTableTrav As DataTableTravailleur

  Private FormManipulerItem As FormManipulerItem
  Private FormNouvelleFacture As FormNouvelleFacture
  Private FormConnexionAdmin As FormConnexionAdmin

  Private ListeSelection As List(Of Integer)

  Private Sub FormInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    DataTableTrav = New DataTableTravailleur

    FormManipulerItem = New FormManipulerItem(DataTableTrav)
    FormNouvelleFacture = New FormNouvelleFacture(DataTableTrav)
    FormConnexionAdmin = New FormConnexionAdmin

    ListeSelection = New List(Of Integer)

    DataGridViewItems.DataSource = DataTableTrav.GetDataInventaireComplet()
    DataGridViewItems.Refresh()
    AffichageInventaireCompletColonnes()

    MettreAJourNbItems()

    AffichageAdmin()
  End Sub

  Private Sub ButtonItemFacture_Click(sender As Object, e As EventArgs) Handles ButtonItemFacture.Click
    FormNouvelleFacture.SetRangees(DataTableTrav.ObtenirRangees("Items", ListeSelection))
    FormNouvelleFacture.Show()
  End Sub

  Private Sub ButtonAjoutItems_Click(sender As Object, e As EventArgs) Handles ButtonAjoutItems.Click
    FormManipulerItem.SetFormulaireMode("Ajout")
    FormManipulerItem.ShowDialog()
  End Sub

  Private Sub ButtonModifierItems_Click(sender As Object, e As EventArgs) Handles ButtonModifierItems.Click
    ' Méthode pour modifier une rangée de la table

    ' On vérifie si l'utilisateur a bien sélectionné une seule rangée
    If ListeSelection.Count = 1 Then
      FormManipulerItem.SetIDModif(ListeSelection.First)
      FormManipulerItem.SetFormulaireMode("Modification")
      FormManipulerItem.ShowDialog()
    Else
      If ListeSelection.Count < 1 Then
        MsgBox("Veuillez sélectionner une cellule de la table.")
      Else
        MsgBox("Veuillez sélectionner une seule cellule de la table.")
      End If
    End If
  End Sub

  Private Sub ButtonSupprimerItems_Click(sender As Object, e As EventArgs) Handles ButtonSupprimerItems.Click
    ' Méthode pour supprimer une rangée de la table

    ' On vérifie si l'utilisateur a bien sélectionné une rangée
    If DataGridViewItems.SelectedRows.Count >= 1 Then
      Try
        ' Source : http://stackoverflow.com/questions/9181363/yes-no-function-in-a-messagebox

        Dim stringRangeesSelectionnees As String = ""

        For Each Rangee As DataRow In DataTableTrav.ObtenirRangees("Items", ListeSelection)
          stringRangeesSelectionnees &=
            Rangee(2).ToString() &
            "(" & Rangee(3).ToString() & ")" & Environment.NewLine
        Next

        If MsgBox(
          "Voulez vous vraiment supprimer : " _
          & vbNewLine _
          & stringRangeesSelectionnees _
          & "?",
          MsgBoxStyle.YesNo,
          "Attention!") = DialogResult.Yes Then

          ' Si l'utilisateur répond positivement, on supprime.
          For Each Id As Integer In ListeSelection
            DataTableTrav.DeleteInventaireComplet(Id)
          Next

          ' Il faut ensuite tout enlever de la liste d'ids et mettre à jour l'interface
          ListeSelection.Clear()

          ' TODO : vérifier ça
          MettreAJourNbItems()
          MettreAJourCheckBox()
        End If
      Catch ex As Exception
        MsgBox(ex.Message)
      End Try
    Else
      MsgBox("Veuillez sélectionner au moins une rangée de la table.")
    End If
  End Sub

  Private Sub TextBoxRechItems_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRechItemsCode.TextChanged,
    TextBoxRechItemsDesc.TextChanged, TextBoxRechItemsEmp.TextChanged, TextBoxRechItemsCat.TextChanged,
    TextBoxRechItemsDep.TextChanged, TextBoxRechItemsFourn.TextChanged
    ' Cette fonction filtre le DataGridView en fonction de ce qui est écrit dans les TextBox de recherche
    ' Il faut d'abord vérifier si les textboxs ont du texte

    ' TOADD : Recherche et filtrage de sélection en même temps;
    CheckBoxItemsNb.Checked = False

    Dim NombreCaracteres = TextBoxRechItemsCode.Text.Trim.Length + TextBoxRechItemsDesc.Text.Trim.Length +
      TextBoxRechItemsEmp.Text.Trim.Length + TextBoxRechItemsCat.Text.Trim.Length +
      TextBoxRechItemsDep.Text.Trim.Length + TextBoxRechItemsFourn.Text.Trim.Length

    If NombreCaracteres > 0 Then
      ' On construit une tableau de String de la recherche
      Dim Recherche() As String = {
        TextBoxRechItemsCode.Text,
        TextBoxRechItemsDesc.Text,
        TextBoxRechItemsEmp.Text,
        TextBoxRechItemsCat.Text,
        TextBoxRechItemsDep.Text,
        TextBoxRechItemsFourn.Text
      }

      DataGridViewItems.DataSource = DataTableTrav.ObtenirDataViewRech(Recherche, "Items")
      DataGridViewItems.Refresh()
    Else
      ' Si l'utilisateur enlève sa recherche, alors la source est la table entière
      DataGridViewItems.DataSource = DataTableTrav.ObtenirDataTable("Items")
      DataGridViewItems.Refresh()
    End If

    EcrireTotalItems()
    MettreAJourCheckbox()
  End Sub

  Private Sub CheckBoxItemsNb_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxItemsNb.CheckedChanged
    ' Méthode pour filtrer le datagridview lorsqu'on appuie sur le checkbox

    ' TOADD : Recherche et filtrage de sélection en même temps;
    ViderItemsRecherche()

    If CheckBoxItemsNb.Checked Then
      For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
        ' Un autre technique est de faire If ListeSelection.Contains(CInt(Rangee.Cells("item_id").Value)) Then
        If CBool(Rangee.Cells("item_chk").Value) = True Then
          Rangee.Visible = True
        Else
          Try
            Rangee.Visible = False
          Catch ex As Exception
            ' TOFIX : Si on déselectionne un item dans la liste filtrée, cela bug lorsqu'on refiltre
          End Try
        End If
      Next
    Else
      For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
        Rangee.Visible = True
      Next
    End If
  End Sub

  Private Sub ViderItemsRecherche()
    ' Méthode pour vider les champs de recherche

    TextBoxRechItemsCode.Text = String.Empty
    TextBoxRechItemsDesc.Text = String.Empty
    TextBoxRechItemsEmp.Text = String.Empty
    TextBoxRechItemsCat.Text = String.Empty
    TextBoxRechItemsDep.Text = String.Empty
    TextBoxRechItemsFourn.Text = String.Empty
  End Sub

  Private Sub AffichageInventaireCompletColonnes()
    ' Méthode pour configurer l'affichage des colonnes

    ' Source : http://vb.net-informations.com/datagridview/vb.net_datagridview_checkbox.htm
    ' Source : http://stackoverflow.com/questions/13338837/check-uncheck-a-checkbox-on-datagridview
    Dim chk As New DataGridViewCheckBoxColumn()
    DataGridViewItems.Columns.Add(chk)
    chk.TrueValue = True
    chk.FalseValue = False
    chk.Name = "item_chk"

    ' Source : https://msdn.microsoft.com/en-us/library/wkfe535h(v=vs.110).aspx
    With DataGridViewItems
      .Columns(10).DisplayIndex = 0 ' Les checkboxs

      .Columns(0).Visible = False ' ID
      .Columns(1).HeaderText = "Code du produit"
      .Columns(2).HeaderText = "Description"
      .Columns(3).HeaderText = "Emplacement"
      .Columns(4).HeaderText = "Catégorie"
      .Columns(5).HeaderText = "Département"
      .Columns(6).HeaderText = "Code fourn."
      .Columns(7).HeaderText = "Fournisseur"
      .Columns(8).HeaderText = "Prix vente"
      .Columns(9).HeaderText = "Quantité"
      .Columns(10).HeaderText = "" ' Les checkboxs
    End With

    ' Il faut mettre à jour de total des items
    EcrireTotalItems()
  End Sub

  Private Sub ButtonSauvegarder_Click(sender As Object, e As EventArgs) Handles ButtonSauvegarder.Click
    ' TODO pour TP2 : il va falloir un bouton sauvegarder individuel pour chaque DataTable
    DataTableTrav.EnregistrerDataTables()

    MsgBox("Sauvegarde effectuée!")
  End Sub

  Private Sub FormInventaire_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    ' Méthode lorsque le programme ferme
    ' Source : https://msdn.microsoft.com/en-us/library/system.windows.forms.form.closing(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-2

    ' On sauvegarde la base de données lorsqu'on quitte le programme, juste pour être certain
    DataTableTrav.EnregistrerDataTables()
  End Sub

  Private Sub EcrireTotalItems()
    Dim Total As Double = 0

    For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
      ' Puisque Option Strict est à on, je n'ai pas le choix de convertir mes valeurs
      Total += Convert.ToDouble(Rangee.Cells("item_prix_achat").Value) * Convert.ToInt32(Rangee.Cells("item_qt").Value)
    Next

    TextBoxItemsTotal.Text = CStr(Total) & " $"
  End Sub

  Private Sub AffichageAdmin()
    ' On affiche les informations d'administrateur en fonction de s'il est connecté

    Dim ConnectionAdmin As Boolean = VariablesGlobales.ADMIN_CONNECTION

    ButtonAjoutItems.Visible = ConnectionAdmin
    ButtonModifierItems.Visible = ConnectionAdmin
    ButtonSupprimerItems.Visible = ConnectionAdmin
    LabelItemsTotal.Visible = ConnectionAdmin
    TextBoxItemsTotal.Visible = ConnectionAdmin

    ' On change l'affichage du bouton de connexion en fonction de si l'utilisateur est connecté

    If ConnectionAdmin Then
      ' Si l'utilisateur est déjà connecté
      ButtonConnexionAdmin.Text = "Déconnexion (admin)"
      ButtonConnexionAdmin.BackColor = Color.Black
    Else
      ' Si l'utilisateur n'est pas connecté
      ButtonConnexionAdmin.Text = "Connexion (admin)"
      ButtonConnexionAdmin.BackColor = Color.Coral
    End If

  End Sub

  Private Sub ButtonConnexionAdmin_Click(sender As Object, e As EventArgs) Handles ButtonConnexionAdmin.Click
    If VariablesGlobales.ADMIN_CONNECTION Then
      ' Si l'utilisateur est déjà connecté
      If MsgBox(
          "Voulez-vous vraiment vous déconnecter de l'interface d'administrateur?",
          MsgBoxStyle.YesNo,
          "Attention!") = DialogResult.Yes Then

        ' Si l'utilisateur répond positivement, on le déconnecte.
        VariablesGlobales.ADMIN_CONNECTION = False
      End If
    Else
      ' Si l'utilisateur n'est pas connecté
      FormConnexionAdmin.ShowDialog()
    End If

    AffichageAdmin()
  End Sub

  Private Sub DataGridViewItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItems.CellContentClick
    ' Méthode pour sélectionner des items
    ' Source : http://stackoverflow.com/questions/1237829/datagridview-checkbox-column-value-and-functionality

    Dim dgv As DataGridView = DirectCast(sender, DataGridView)
    Dim chk As DataGridViewCheckBoxCell = New DataGridViewCheckBoxCell()

    chk = CType(dgv.Rows(dgv.CurrentRow.Index).Cells("item_chk"), DataGridViewCheckBoxCell)

    If chk.Value Is Nothing Then
      chk.Value = False
    End If

    If CBool(chk.Value) Then
      chk.Value = False
      ListeSelection.Remove(CInt(dgv.CurrentRow.Cells(0).Value))
    Else
      chk.Value = True
      ListeSelection.Add(CInt(dgv.CurrentRow.Cells(0).Value))
    End If

    MettreAJourNbItems()
  End Sub

  Private Sub MettreAJourNbItems()
    LabelItemsNb.Text = "Nombre d'items sélectionnés : " & ListeSelection.Count().ToString()
  End Sub

  Private Sub MettreAJourCheckBox()
    ' Méthode qui s'assure que les checkbox sont cochés

    For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
      Rangee.Cells("item_chk").Value = ListeSelection.Contains(CInt(Rangee.Cells("item_id").Value))
    Next
  End Sub
End Class