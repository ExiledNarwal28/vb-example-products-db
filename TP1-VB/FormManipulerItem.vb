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
        If Not Me.IDModif = Nothing Then
          Me.RemplirChampsRangee()
        End If
    End Select
  End Sub

  Public Sub SetIDModif(ByVal IDModif As Int32)
    Me.IDModif = IDModif
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

  ' Méthode pour insérer à l'inventaire complet
  Private Sub InsertInventaireComplet()
    DataTableTrav.InsertInventaireComplet(
      TextBoxItemAjoutCodeProduit.Text,
      TextBoxItemAjoutDesc.Text,
      TextBoxItemAjoutEmp.Text,
      TextBoxItemAjoutCat.Text,
      TextBoxItemAjoutDep.Text,
      TextBoxItemAjoutFournCode.Text,
      TextBoxItemAjoutFournNom.Text,
      CDbl(TextBoxItemAjoutPrixV.Text),
      CDbl(TextBoxItemAjoutPrixA.Text),
      CInt(TextBoxItemAjoutQt.Text))
  End Sub

  ' Méthode pour modifier dans l'inventaire complet
  Private Sub UpdateInventaireComplet()
    DataTableTrav.UpdateInventaireComplet(
      Me.IDModif,
      TextBoxItemAjoutCodeProduit.Text,
      TextBoxItemAjoutDesc.Text,
      TextBoxItemAjoutEmp.Text,
      TextBoxItemAjoutCat.Text,
      TextBoxItemAjoutDep.Text,
      TextBoxItemAjoutFournCode.Text,
      TextBoxItemAjoutFournNom.Text,
      CDbl(TextBoxItemAjoutPrixV.Text),
      CDbl(TextBoxItemAjoutPrixA.Text),
      CInt(TextBoxItemAjoutQt.Text))
  End Sub

  ' Méthode pour ajouter un nouveau Datarow
  Private Function ModifierRangee() As Boolean

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
    TextBoxItemAjoutCat.Text = ""
    TextBoxItemAjoutFournCode.Text = ""
    TextBoxItemAjoutDep.Text = ""
    TextBoxItemAjoutFournNom.Text = ""
    TextBoxItemAjoutPrixA.Text = ""
    TextBoxItemAjoutPrixV.Text = ""
    TextBoxItemAjoutQt.Text = ""
  End Sub

  ' Méthode pour remplir l'intégralité du formulaire avec une rangée
  Private Sub RemplirChampsRangee()
    Dim Donnees As TP1_VB.SelectInventaireCompletSingle_Result = Me.DataTableTrav.GetDataInventaireCompletSingle(IDModif)

    With Donnees
      TextBoxItemAjoutCodeProduit.Text = .Code_de_produit
      TextBoxItemAjoutDesc.Text = .Description
      TextBoxItemAjoutEmp.Text = .Emplacement
      TextBoxItemAjoutFournNom.Text = .Nom_de_fournisseur
      TextBoxItemAjoutFournCode.Text = .Code_de_fournisseur
      TextBoxItemAjoutCat.Text = .Catégorie
      TextBoxItemAjoutDep.Text = .Département
      TextBoxItemAjoutPrixA.Text = CStr(.Prix_d_achat)
      TextBoxItemAjoutPrixV.Text = CStr(.Prix_de_vente)
      TextBoxItemAjoutQt.Text = CStr(.Quantité)
    End With
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

    If TextBoxItemAjoutFournNom.Text = "" Then
      LabelItemAjoutFournNom.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxItemAjoutFournCode.Text = "" Then
      LabelItemAjoutFournCode.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxItemAjoutDep.Text = "" Then
      LabelItemAjoutDepNom.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxItemAjoutCat.Text = "" Then
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

  ' Méthode pour mettre les couleurs des labels à la couleur normale
  Private Sub LabelCouleurNormale()
    LabelItemAjoutCatNom.ForeColor = Color.Black
    LabelItemAjoutCodeProduit.ForeColor = Color.Black
    LabelItemAjoutDepNom.ForeColor = Color.Black
    LabelItemAjoutDesc.ForeColor = Color.Black
    LabelItemAjoutEmp.ForeColor = Color.Black
    LabelItemAjoutFournCode.ForeColor = Color.Black
    LabelItemAjoutFournNom.ForeColor = Color.Black
    LabelItemAjoutPrixA.ForeColor = Color.Black
    LabelItemAjoutPrixV.ForeColor = Color.Black
    LabelItemAjoutQt.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutCodeProduit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutCodeProduit.TextChanged
    LabelItemAjoutCodeProduit.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutDesc_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutDesc.TextChanged
    LabelItemAjoutDesc.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutEmp_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutEmp.TextChanged
    LabelItemAjoutEmp.ForeColor = Color.Black
  End Sub

  Private Sub ComboBoxItemAjoutFournNom_SelectedIndexChanged(sender As Object, e As EventArgs)
    LabelItemAjoutFournNom.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxItemAjoutFournCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItemAjoutFournCode.TextChanged
    LabelItemAjoutFournCode.ForeColor = Color.Black
  End Sub

  Private Sub ComboBoxItemAjoutDepNom_SelectedIndexChanged(sender As Object, e As EventArgs)
    LabelItemAjoutDepNom.ForeColor = Color.Black
  End Sub

  Private Sub ComboBoxItemAjoutCatNom_SelectedIndexChanged(sender As Object, e As EventArgs)
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
    Me.LabelCouleurNormale()
    Me.Hide()
    e.Cancel = True
  End Sub
End Class