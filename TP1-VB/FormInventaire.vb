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
  Private FormManipulerUtilisateur As FormManipulerUtilisateur
  Private FormNouvelleFacture As FormNouvelleFacture
  Private FormConnection As FormConnection

  Private ListeSelection As List(Of Integer)
  Private TabPagesCachees As List(Of TabPage) ' Pour la gestion de droits, voir AffichageDroits()

  Private Sub FormInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    DataTableTrav = New DataTableTravailleur

    FormManipulerItem = New FormManipulerItem(DataTableTrav)
    FormManipulerUtilisateur = New FormManipulerUtilisateur(DataTableTrav)
    FormNouvelleFacture = New FormNouvelleFacture(DataTableTrav)
    FormConnection = New FormConnection(DataTableTrav)

    ListeSelection = New List(Of Integer)
    TabPagesCachees = New List(Of TabPage)

    Me.Hide()
    FormConnection.ShowDialog()

    DataGridViewItems.DataSource = DataTableTrav.GetDataInventaireComplet()
    DataGridViewItems.Refresh()
    AffichageInventaireCompletColonnes()

    DataGridViewUtilisateurs.DataSource = DataTableTrav.GetDataUtilisateur()
    DataGridViewUtilisateurs.Refresh()
    AffichageUtilisateurColonnes()

    MettreAJourNbItems()

    MettreAJourUtilisateurDGVDroits()

    AffichageDroits()
  End Sub

  ' ---> DataGridViews : Affichage

  ' Méthode pour configurer l'affichage des colonnes d'inventaire
  Private Sub AffichageInventaireCompletColonnes()

    ' Source : https://msdn.microsoft.com/en-us/library/wkfe535h(v=vs.110).aspx
    With DataGridViewItems
      .Columns(0).Visible = False ' ID
      .Columns(1).HeaderText = "Code du produit"
      .Columns(2).HeaderText = "Description"
      .Columns(3).HeaderText = "Emplacement"
      .Columns(4).HeaderText = "Catégorie"
      .Columns(5).HeaderText = "Département"
      .Columns(6).HeaderText = "Code fourn."
      .Columns(7).HeaderText = "Fournisseur"
      .Columns(8).HeaderText = "Prix vente"
      .Columns(9).HeaderText = "Prix d'achat"
      .Columns(10).HeaderText = "Quantité"
    End With

    ' Il faut mettre à jour de total des items
    EcrireTotalItems()
  End Sub

  ' Méthode pour configurer l'affichage des colonnes d'utilisateur
  Private Sub AffichageUtilisateurColonnes()
    ' TODO
  End Sub

  ' ---> DataGridViews : Sélection

  ' Méthode pour mettre à jour l'affichage des items sélectionnés
  Private Sub MettreAJourItemSelection()
    For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
      If ListeSelection.Contains(CInt(Rangee.Cells(0).Value)) Then
        Rangee.DefaultCellStyle.BackColor = SystemColors.Highlight
        Rangee.DefaultCellStyle.ForeColor = SystemColors.HighlightText
      Else
        Rangee.DefaultCellStyle.BackColor = SystemColors.Window
        Rangee.DefaultCellStyle.ForeColor = SystemColors.ControlText
      End If
    Next
  End Sub

  ' Méthode pour écrire le nombre d'items dans la sélection
  Private Sub MettreAJourNbItems()
    LabelItemsNb.Text = "Nombre d'items d'inventaire sélectionnés : " & ListeSelection.Count().ToString()
  End Sub

  ' ---> DataGridViews : Rafraichissement et mise à jour

  ' Méthode pour remettre à zéro la liste de sélection et tout ce qui vient avec
  Private Sub RafraichirDGVItems()
    DataGridViewItems.DataSource = DataTableTrav.GetDataInventaireComplet()

    ListeSelection.Clear()

    MettreAJourNbItems()
  End Sub

  Private Sub MettreAJourUtilisateurDGVDroits()
    ' TODO
  End Sub

  ' ---> Évênements : Général

  ' Évênement pour sauvegarder
  Private Sub ButtonSauvegarder_Click(sender As Object, e As EventArgs) Handles ButtonSauvegarder.Click
    DataTableTrav.Sauvegarder()
    MsgBox("Sauvegarde effectuée!")
  End Sub

  ' Évênement lorsque le programme ferme
  Private Sub FormInventaire_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    ' Source : https://msdn.microsoft.com/en-us/library/system.windows.forms.form.closing(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-2

    ' On sauvegarde la base de données lorsqu'on quitte le programme, juste pour être certain
    DataTableTrav.Sauvegarder()
  End Sub

  ' Évênement pour se déconnecter
  Private Sub ButtonDeconnection_Click(sender As Object, e As EventArgs) Handles ButtonDeconnection.Click
    DataTableTrav.Deconnection()
    ConnexionObligatoire()
  End Sub

  ' ---> Évênements : DataGridViews

  ' Évênement pour sélectionner des items
  Private Sub DataGridViewItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItems.CellContentClick
    Dim dgv As DataGridView = DirectCast(sender, DataGridView)

    If ListeSelection.Contains(CInt(dgv.CurrentRow.Cells(0).Value)) Then
      ListeSelection.Remove(CInt(dgv.CurrentRow.Cells(0).Value))
    Else
      ListeSelection.Add(CInt(dgv.CurrentRow.Cells(0).Value))
    End If

    MettreAJourItemSelection()
    MettreAJourNbItems()
  End Sub

  ' ---> Évênements : Boutons d'inventaire

  ' Évênement pour ajouter un item à l'inventaire
  Private Sub ButtonAjoutItems_Click(sender As Object, e As EventArgs) Handles ButtonAjoutItems.Click
    FormManipulerItem.SetFormulaireMode("Ajout")
    FormManipulerItem.ShowDialog()
    Me.RafraichirDGVItems()
  End Sub

  ' Évênement pour modifier un item à l'inventaire
  Private Sub ButtonModifierItems_Click(sender As Object, e As EventArgs) Handles ButtonModifierItems.Click

    ' On vérifie si l'utilisateur a bien sélectionné une seule rangée
    If ListeSelection.Count = 1 Then
      FormManipulerItem.SetIDModif(ListeSelection.First)
      FormManipulerItem.SetFormulaireMode("Modification")
      FormManipulerItem.ShowDialog()
      Me.RafraichirDGVItems()
    Else
      If ListeSelection.Count < 1 Then
        MsgBox("Veuillez sélectionner une cellule de la table.")
      Else
        MsgBox("Veuillez sélectionner une seule cellule de la table.")
      End If
    End If
  End Sub

  ' Évênement pour supprimer un item à l'inventaire
  Private Sub ButtonSupprimerItems_Click(sender As Object, e As EventArgs) Handles ButtonSupprimerItems.Click
    ' On vérifie si l'utilisateur a bien sélectionné une rangée
    If DataGridViewItems.SelectedRows.Count >= 1 Then
      Try
        ' Source : http://stackoverflow.com/questions/9181363/yes-no-function-in-a-messagebox

        If MsgBox(
          "Voulez vous vraiment supprimer cette/ces rangée(s)?",
          MsgBoxStyle.YesNo,
          "Attention!") = DialogResult.Yes Then

          ' Si l'utilisateur répond positivement, on supprime.
          For Each Id As Integer In ListeSelection
            DataTableTrav.DeleteInventaireComplet(Id)
          Next

          ' Il faut ensuite tout enlever de la liste d'ids et mettre à jour l'interface
          Me.RafraichirDGVItems()
        End If
      Catch ex As Exception
        MsgBox(ex.Message)
      End Try
    Else
      MsgBox("Veuillez sélectionner au moins une rangée de la table.")
    End If
  End Sub

  ' ---> Évênements : Boutons de factures

  ' Évênement pour ajouter une facture
  Private Sub ButtonFacture_Click(sender As Object, e As EventArgs) Handles ButtonItemFacture.Click
    FormNouvelleFacture.SetProduitID(ListeSelection)
    FormNouvelleFacture.ShowDialog()
  End Sub

  ' ---> Évênements : Boutons d'utilisateurs

  ' Évênement pour ajouter un utilisateur
  Private Sub ButtonAjoutUtilisateur_Click(sender As Object, e As EventArgs) Handles ButtonAjoutUtilisateur.Click
    FormManipulerUtilisateur.SetFormulaireMode("Ajout")
    FormManipulerUtilisateur.ShowDialog()
  End Sub

  ' Évênement pour modifier un utilisateur
  Private Sub ButtonModifierUtilisateur_Click(sender As Object, e As EventArgs) Handles ButtonModifierUtilisateur.Click
    FormManipulerUtilisateur.SetFormulaireMode("Modification")
    FormManipulerUtilisateur.ShowDialog()
  End Sub

  ' Aide pour l'utilisateur
  Private Sub ButtonUtilisateurAide_Click(sender As Object, e As EventArgs) Handles ButtonUtilisateurAide.Click
    MsgBox("I-V : Inventaire - Voir" & vbNewLine & _
           "I-I : Inventaire - Insérer (ajouter)" & vbNewLine & _
           "I-M : Inventaire - Modifier" & vbNewLine & _
           "I-S : Inventaire - Supprimer" & vbNewLine & _
           "I-A : Inventaire - Administrateur (estimations, prix d'achat)" & vbNewLine & _
           "F-V : Facture - Voir" & vbNewLine & _
           "F-I : Facture - Insérer (ajouter)" & vbNewLine & _
           "U-V : Utilisateur - Voir" & vbNewLine & _
           "U-I : Utilisateur - Insérer (ajouter)" & vbNewLine & _
           "U-M : Utilisateur - Modifier (informations)" & vbNewLine & _
           "U-S : Utilisateur - Supprimer" & vbNewLine & _
           "U-A : Utilisateur - Administrateur (droits)")
  End Sub

  ' ---> Évênements : Recherche/Filtre

  ' Évênement qui filtre le DataGridView en fonction de ce qui est écrit dans les TextBox de recherche
  Private Sub TextBoxRechItems_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRechItemsCode.TextChanged,
    TextBoxRechItemsDesc.TextChanged, TextBoxRechItemsEmp.TextChanged, TextBoxRechItemsCat.TextChanged,
    TextBoxRechItemsDep.TextChanged, TextBoxRechItemsFourn.TextChanged
    ' Il faut d'abord vérifier si les textboxs ont du texte

    CheckBoxFiltreSelection.Checked = False

    Dim NombreCaracteres = TextBoxRechItemsCode.Text.Trim.Length + TextBoxRechItemsDesc.Text.Trim.Length +
      TextBoxRechItemsEmp.Text.Trim.Length + TextBoxRechItemsCat.Text.Trim.Length +
      TextBoxRechItemsDep.Text.Trim.Length + TextBoxRechItemsFourn.Text.Trim.Length

    If NombreCaracteres > 0 Then
      ' On construit une tableau de String de la recherche

      DataGridViewItems.DataSource = DataTableTrav.GetDataInventaireCompletFiltre(
        TextBoxRechItemsCode.Text,
        TextBoxRechItemsDesc.Text,
        TextBoxRechItemsEmp.Text,
        TextBoxRechItemsCat.Text,
        TextBoxRechItemsDep.Text,
        TextBoxRechItemsFourn.Text
      )
    Else
      ' Si l'utilisateur enlève sa recherche, alors la source est la table entière
      DataGridViewItems.DataSource = DataTableTrav.GetDataInventaireComplet()
    End If

    MettreAJourItemSelection()
    EcrireTotalItems()
  End Sub

  ' Évênement pour filtrer le datagridview lorsqu'on appuie sur le checkbox
  Private Sub CheckBoxFiltreSelection_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFiltreSelection.CheckedChanged
    ViderItemsRecherche()

    If CheckBoxFiltreSelection.Checked Then
      For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
        If ListeSelection.Contains(CInt(Rangee.Cells(0).Value)) Then
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

    EcrireTotalItems()
    MettreAJourItemSelection()
  End Sub

  ' ---> Affichage général

  ' Méthode pour écrire le total du montant des items affichés
  Private Sub EcrireTotalItems()
    Dim Total As Double = 0

    For Each Rangee As DataGridViewRow In DataGridViewItems.Rows
      ' Puisque Option Strict est à on, je n'ai pas le choix de convertir mes valeurs
      Total += Convert.ToDouble(Rangee.Cells(8).Value) * Convert.ToInt32(Rangee.Cells(10).Value)
    Next

    TextBoxItemsTotal.Text = CStr(Total) & " $"
  End Sub

  ' On affiche les informations en fonction des droits de l'utilisateur connecté
  Private Sub AffichageDroits()
    Dim droits As Short = DataTableTrav.GetDroits()

    ' Les boutons de l'inventaire
    ButtonModifierItems.Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_UPDATE) <> 0
    ButtonAjoutItems.Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_INSERT) <> 0
    ButtonSupprimerItems.Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_DELETE) <> 0

    ' Le bouton de factures
    ButtonItemFacture.Visible = (droits And VariablesGlobales.DROIT_FACTURE_INSERT) <> 0

    ' Les boutons d'utilisateurs
    ' Un utilisateur peut voir le bouton de modification s'il peut modifier les informations (UPDATE) ou les droits (ADMIN)
    ' Idem pour l'ajout (INSERT)
    ButtonModifierUtilisateur.Visible = (droits And VariablesGlobales.DROIT_UTILISATEUR_UPDATE) <> 0 _
                                        Or (droits And VariablesGlobales.DROIT_UTILISATEUR_ADMIN) <> 0
    ButtonAjoutUtilisateur.Visible = (droits And VariablesGlobales.DROIT_UTILISATEUR_INSERT) <> 0 _
                                        Or (droits And VariablesGlobales.DROIT_UTILISATEUR_ADMIN) <> 0
    ButtonSupprimerUtilisateur.Visible = (droits And VariablesGlobales.DROIT_UTILISATEUR_DELETE) <> 0

    ' Les panneaux pour l'ajout/la modification d'utilisateurs
    ' Un utilisateur peut modifier les informations s'il peut UPDATE ou INSERT
    ' Un utilisateur peut changer des droits s'il est ADMIN
    FormManipulerUtilisateur.PanelUtilisateurAjoutInformation.Visible = (droits And VariablesGlobales.DROIT_UTILISATEUR_UPDATE) <> 0 _
                                                                        Or (droits And VariablesGlobales.DROIT_UTILISATEUR_INSERT) <> 0
    FormManipulerUtilisateur.PanelUtilisateurAjoutDroit.Visible = (droits And VariablesGlobales.DROIT_UTILISATEUR_ADMIN) <> 0
    FormManipulerUtilisateur.PanelUtilisateurAjoutDroit.Visible = False

    ' Les controles d'administrateur d'inventaire
    LabelItemsTotal.Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_ADMIN) <> 0
    TextBoxItemsTotal.Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_ADMIN) <> 0
    DataGridViewItems.Columns(9).Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_ADMIN) <> 0 ' Le prix d'achat

    ' Les datagridviews
    DataGridViewItems.Visible = (droits And VariablesGlobales.DROIT_INVENTAIRE_SELECT) <> 0
    DataGridViewFactures.Visible = (droits And VariablesGlobales.DROIT_FACTURE_SELECT) <> 0
    DataGridViewUtilisateurs.Visible = (droits And VariablesGlobales.DROIT_UTILISATEUR_SELECT) <> 0

    ' Les tabs (TabPages)
    ' Source : http://stackoverflow.com/questions/552579/how-to-hide-tabpage-from-tabcontrol#552588
    If (droits And VariablesGlobales.DROIT_INVENTAIRE_SELECT) <> 0 Then
      If Not PageInventaire.TabPages.Contains(TabPageItems) Then
        PageInventaire.TabPages.Add(TabPageItems)
      End If
    Else
      If PageInventaire.TabPages.Contains(TabPageItems) Then
        PageInventaire.TabPages.Remove(TabPageItems)
      End If
    End If

    If (droits And VariablesGlobales.DROIT_FACTURE_SELECT) <> 0 Then
      If Not PageInventaire.TabPages.Contains(TabPageFactures) Then
        PageInventaire.TabPages.Add(TabPageFactures)
      End If
    Else
      If PageInventaire.TabPages.Contains(TabPageFactures) Then
        PageInventaire.TabPages.Remove(TabPageFactures)
      End If
    End If

    If (droits And VariablesGlobales.DROIT_UTILISATEUR_SELECT) <> 0 Then
      If Not PageInventaire.TabPages.Contains(TabPageUtilisateurs) Then
        PageInventaire.TabPages.Add(TabPageUtilisateurs)
      End If
    Else
      If PageInventaire.TabPages.Contains(TabPageUtilisateurs) Then
        PageInventaire.TabPages.Remove(TabPageUtilisateurs)
      End If
    End If
  End Sub

  ' ---> Autre

  ' Méthode pour vider les champs de recherche
  Private Sub ViderItemsRecherche()
    TextBoxRechItemsCode.Text = String.Empty
    TextBoxRechItemsDesc.Text = String.Empty
    TextBoxRechItemsEmp.Text = String.Empty
    TextBoxRechItemsCat.Text = String.Empty
    TextBoxRechItemsDep.Text = String.Empty
    TextBoxRechItemsFourn.Text = String.Empty
  End Sub

  ' Méthode pour forcer la connection
  Private Sub ConnexionObligatoire()
    Me.Hide()
    FormConnection.ShowDialog()
    AffichageDroits()
    Me.Show()
  End Sub
End Class