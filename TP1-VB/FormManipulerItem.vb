Option Strict On
Option Explicit On
Public Class FormManipulerItem
  Private DataTableTrav As DataTableTravailleur

  Private FormulaireMode As String ' Ajout ou modifications
  Private IDModif As Int32

  Public Sub New(ByRef DataTableTrav As DataTableTravailleur)
    InitializeComponent()
    Me.DataTableTrav = DataTableTrav
    Me.FormulaireMode = ""
    Me.IDModif = -1

    PopulerCombobox()
  End Sub

  Public Sub SetFormulaireMode(ByVal Mode As String)
    ' Méthode pour appliquer un mode du formulaire

    Me.FormulaireMode = Mode

    ' On change l'apparence du formulaire en fonction du mode du formulaire
    Select Case Me.FormulaireMode
      Case "Ajout"
        Me.Text = "Ajout d'un item"
        Me.ButtonItemsAjoutAction.Text = "Ajouter"
        Me.ButtonItemsAjoutAction.BackColor = Color.SeaGreen
      Case "Modification"
        Me.Text = "Modification d'un item"
        Me.ButtonItemsAjoutAction.Text = "Modifier"
        Me.ButtonItemsAjoutAction.BackColor = Color.DarkOrange
        If Not Me.IDModif = -1 Then
          Me.RemplirChampsRangee()
        End If
    End Select
  End Sub

  Public Sub SetIDModif(ByVal IDModif As Int32)
    Me.IDModif = IDModif
  End Sub

  Private Sub PopulerCombobox()
    ' Source: http://stackoverflow.com/questions/22682075/how-to-populate-a-combobox-with-a-string-array

    For Each colonne As String In VariablesGlobales.CAT_NOM
      ComboBoxItemAjoutCatNom.Items.Add(colonne)
    Next

    For Each colonne As String In VariablesGlobales.DEP_NOM
      ComboBoxItemAjoutDepNom.Items.Add(colonne)
    Next

    ComboBoxItemAjoutFournNom.MaxDropDownItems = 10
    For Each colonne As String In VariablesGlobales.FOURN_NOM
      ComboBoxItemAjoutFournNom.Items.Add(colonne)
    Next
  End Sub

  Private Sub ButtonItemsAjoutAction_Click(sender As Object, e As EventArgs) Handles ButtonItemsAjoutAction.Click
    ' Lorsque l'utilisateur clique sur ce bouton, on vérifie le contenu des champs et, si tout est ok, on construit un nouveau DataRow avec

    If VerifierChamp() Then
      ' On vérifie quel est le mode du formulaire
      Select Case Me.FormulaireMode
        Case "Ajout"
          Me.InsertInventaireComplet()
          Me.Hide()
          Me.ViderFormulaire()
        Case "Modification"
          If Me.ModifierRangee() Then
            Me.Hide()
            Me.ViderFormulaire()
          End If
      End Select
    End If
  End Sub

  Private Sub ButtonItemsAjoutAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonItemsAjoutAnnuler.Click
    Me.ViderFormulaire()
    Me.Hide()
  End Sub

  Private Function GetDernierItemId() As Integer
    ' Source : http://stackoverflow.com/questions/11116445/find-the-maximum-value-of-a-vb-net-datatable

    Dim dt As DataTable = DataTableTrav.ObtenirDataTable("Items")
    Dim dv As DataView = dt.DefaultView

    dv.Sort = dt.Columns(0).ColumnName + " DESC"

    Return CInt(dv(0).Item(0)) + 1
  End Function

  ' Méthode pour insérer à l'inventaire complet
  Private Sub InsertInventaireComplet()
    DataTableTrav.InsertInventaireComplet(
      TextBoxItemAjoutCodeProduit.Text,
      TextBoxItemAjoutDesc.Text,
      TextBoxItemAjoutEmp.Text,
      CStr(ComboBoxItemAjoutCatNom.SelectedItem),
      CStr(ComboBoxItemAjoutDepNom.SelectedItem),
      TextBoxItemAjoutFournCode.Text,
      CStr(ComboBoxItemAjoutFournNom.SelectedItem),
      CDbl(TextBoxItemAjoutPrixV.Text),
      CInt(TextBoxItemAjoutPrixV.Text))
  End Sub

  ' Méthode pour modifier dans l'inventaire complet
  Private Sub UpdateInventaireComplet()
    DataTableTrav.UpdateInventaireComplet(
      Me.IDModif,
      TextBoxItemAjoutCodeProduit.Text,
      TextBoxItemAjoutDesc.Text,
      TextBoxItemAjoutEmp.Text,
      CStr(ComboBoxItemAjoutCatNom.SelectedItem),
      CStr(ComboBoxItemAjoutDepNom.SelectedItem),
      TextBoxItemAjoutFournCode.Text,
      CStr(ComboBoxItemAjoutFournNom.SelectedItem),
      CDbl(TextBoxItemAjoutPrixV.Text),
      CInt(TextBoxItemAjoutPrixV.Text))
  End Sub

  Private Function ModifierRangee() As Boolean
    ' Méthode pour ajouter un nouveau Datarow
    Dim dt As DataTable = DataTableTrav.ObtenirDataTable("Items")

    ' On s'assure que les modifications sont correctes
    If MsgBox(
          "Êtes-vous certain de vos modifications?",
          MsgBoxStyle.YesNo,
          "Attention!") = DialogResult.Yes Then

      Me.UpdateInventaireComplet()

      ' On retourne vrai, pour cacher le formulaire
      Return True
    End If

    ' Si l'utilisateur n'est pas content de ses modifications, on retourne faux pour rester le formulaire ouvert
    Return False
  End Function

  Private Sub ViderFormulaire()
    ' Méthode pour vider l'intégralité du formulaire

    TextBoxItemAjoutCodeProduit.Text = ""
    TextBoxItemAjoutDesc.Text = ""
    TextBoxItemAjoutEmp.Text = ""
    ComboBoxItemAjoutFournNom.SelectedIndex = -1
    TextBoxItemAjoutFournCode.Text = ""
    ComboBoxItemAjoutDepNom.SelectedIndex = -1
    ComboBoxItemAjoutCatNom.SelectedIndex = -1
    TextBoxItemAjoutPrixA.Text = ""
    TextBoxItemAjoutPrixV.Text = ""
    TextBoxItemAjoutQt.Text = ""
  End Sub

  Private Sub RemplirChampsRangee()
    ' Méthode pour remplir l'intégralité du formulaire avec une rangée

    ' TODO

    'TextBoxItemAjoutCodeProduit.Text = RangeeModif("item_code_produit").ToString()
    'TextBoxItemAjoutDesc.Text = RangeeModif("item_desc").ToString()
    'TextBoxItemAjoutEmp.Text = RangeeModif("item_emp").ToString()
    'TextBoxItemAjoutFournCode.Text = RangeeModif("item_fourn_code").ToString()
    'TextBoxItemAjoutPrixA.Text = RangeeModif("item_prix_achat").ToString()
    'TextBoxItemAjoutPrixV.Text = RangeeModif("item_prix_vente").ToString()
    'TextBoxItemAjoutQt.Text = RangeeModif("item_qt").ToString()

    '' Si le nom n'est pas dans les VariablesGlobales, alors l'index est -1. Pas d'erreur.
    'ComboBoxItemAjoutFournNom.SelectedIndex = Array.IndexOf(VariablesGlobales.FOURN_NOM, RangeeModif("item_fourn_nom").ToString())
    'ComboBoxItemAjoutCatNom.SelectedIndex = Array.IndexOf(VariablesGlobales.CAT_NOM, RangeeModif("item_cat_nom").ToString())
    'ComboBoxItemAjoutDepNom.SelectedIndex = Array.IndexOf(VariablesGlobales.DEP_NOM, RangeeModif("item_dep_nom").ToString())
  End Sub

  Private Function VerifierChamp() As Boolean
    ' Fonction qui vérifie si tous les champs sont ok

    Dim Resultat As Boolean = True

    If TextBoxItemAjoutCodeProduit.Text = "" Then
      LabelItemAjoutCodeProduit.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxItemAjoutDesc.Text = "" Then
      LabelItemAjoutDesc.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxItemAjoutEmp.Text = "" Then
      LabelItemAjoutEmp.ForeColor = Color.Red
      Resultat = False
    End If

    If ComboBoxItemAjoutFournNom.SelectedIndex = -1 Then
      LabelItemAjoutFournNom.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxItemAjoutFournCode.Text = "" Then
      LabelItemAjoutFournCode.ForeColor = Color.Red
      Resultat = False
    End If

    If ComboBoxItemAjoutDepNom.SelectedIndex = -1 Then
      LabelItemAjoutDepNom.ForeColor = Color.Red
      Resultat = False
    End If

    If ComboBoxItemAjoutCatNom.SelectedIndex = -1 Then
      LabelItemAjoutCatNom.ForeColor = Color.Red
      Resultat = False
    End If

    If Not IsNumeric(TextBoxItemAjoutPrixA.Text) Then
      LabelItemAjoutPrixA.ForeColor = Color.Red
      Resultat = False
    End If

    If Not IsNumeric(TextBoxItemAjoutPrixV.Text) Then
      LabelItemAjoutPrixV.ForeColor = Color.Red
      Resultat = False
    End If

    ' La valeur suivante est inutile, mais il est nécéssaire d'envoyer une valeur integer ByRef à Int32.TryParse()
    Dim ItemAjoutQt As Integer
    If TextBoxItemAjoutQt.Text = "" Or Not Int32.TryParse(TextBoxItemAjoutQt.Text, ItemAjoutQt) Then
      LabelItemAjoutQt.ForeColor = Color.Red
      Resultat = False
    End If

    Return Resultat
  End Function

  Private Sub TextBoxItemAjoutCodeProduit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutCodeProduit.TextChanged
    LabelItemAjoutCodeProduit.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutDesc_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutDesc.TextChanged
    LabelItemAjoutDesc.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutEmp_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutEmp.TextChanged
    LabelItemAjoutEmp.ForeColor = Color.Black
  End Sub

  Private Sub ComboBoxItemAjoutFournNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItemAjoutFournNom.SelectedIndexChanged
    LabelItemAjoutFournNom.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutFournCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutFournCode.TextChanged
    LabelItemAjoutFournCode.ForeColor = Color.Black
  End Sub

  Private Sub ComboBoxItemAjoutDepNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItemAjoutDepNom.SelectedIndexChanged
    LabelItemAjoutDepNom.ForeColor = Color.Black
  End Sub

  Private Sub ComboBoxItemAjoutCatNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItemAjoutCatNom.SelectedIndexChanged
    LabelItemAjoutCatNom.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutPrixA_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutPrixA.TextChanged
    LabelItemAjoutPrixA.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutPrixV_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutPrixV.TextChanged
    LabelItemAjoutPrixV.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutQt_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutQt.TextChanged
    LabelItemAjoutQt.ForeColor = Color.Black
  End Sub

  Private Sub FormAjoutItem_Closing(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) _
    Handles MyBase.Closing
    ' Source : https://bytes.com/topic/visual-basic-net/answers/371062-hide-main-form-instead-closing
    ' Fonction pour cacher le formulaire au lieu de le fermer
    Me.Hide()
    e.Cancel = True
  End Sub
End Class