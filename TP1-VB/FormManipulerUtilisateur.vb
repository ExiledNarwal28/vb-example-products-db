Option Strict On
Option Explicit On
Public Class FormManipulerUtilisateur
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
        Me.Text = "Ajout d'un utilisateur"
        Me.ButtonUtilisateurAjoutAction.Text = "Ajouter"
        Me.ButtonUtilisateurAjoutAction.BackColor = Color.SeaGreen
      Case "Modification"
        Me.Text = "Modification d'un utilisateur"
        Me.ButtonUtilisateurAjoutAction.Text = "Modifier"
        Me.ButtonUtilisateurAjoutAction.BackColor = Color.DarkOrange
        If Not Me.IDModif = Nothing Then
          Me.RemplirChampsRangee()
        End If
    End Select
  End Sub

  Public Sub SetIDModif(ByVal IDModif As Int32)
    Me.IDModif = IDModif
  End Sub

  Private Sub ButtonItemsAjoutAction_Click(sender As Object, e As EventArgs) Handles ButtonUtilisateurAjoutAction.Click
    ' Lorsque l'utilisateur clique sur ce bouton, on vérifie le contenu des champs et, si tout est ok, on construit un nouveau DataRow avec

    If VerifierChamp() Then
      ' On vérifie quel est le mode du formulaire
      Select Case Me.FormulaireMode
        Case "Ajout"
          Me.InsertUtilisateur()
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

  Private Sub ButtonItemsAjoutAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonUtilisateurAjoutAnnuler.Click
    Me.ViderFormulaire()
    Me.Hide()
  End Sub

  ' Méthode pour insérer l'utilisateur
  Private Sub InsertUtilisateur()
    DataTableTrav.InsertUtilisateur(
      TextBoxUtilisateurAjoutNom.Text,
      TextBoxUtilisateurAjoutPrenom.Text,
      TextBoxUtilisateurAjoutUsername.Text,
      TextBoxUtilisateurAjoutCourriel.Text,
      TextBoxUtilisateurAjoutPassword.Text,
      Me.GetDroits)
  End Sub

  ' Méthode pour modifier l'utilisateur
  Private Sub UpdateUtilisateur()
    DataTableTrav.UpdateUtilisateur(
      Me.IDModif,
      TextBoxUtilisateurAjoutNom.Text,
      TextBoxUtilisateurAjoutPrenom.Text,
      TextBoxUtilisateurAjoutUsername.Text,
      TextBoxUtilisateurAjoutCourriel.Text,
      TextBoxUtilisateurAjoutPassword.Text,
      Me.GetDroits)
  End Sub

  Private Function GetDroits() As Int16
    Dim Droits As Int16 = 0

    If CheckBoxUtilisateurAjoutDroitVoirInventaire.Checked Then
      Droits += VariablesGlobales.DROIT_INVENTAIRE_SELECT
    End If

    If CheckBoxUtilisateurAjoutDroitAjoutInventaire.Checked Then
      Droits += VariablesGlobales.DROIT_INVENTAIRE_INSERT
    End If

    If CheckBoxUtilisateurAjoutDroitModifierInventaire.Checked Then
      Droits += VariablesGlobales.DROIT_INVENTAIRE_UPDATE
    End If

    If CheckBoxUtilisateurAjoutDroitSupprimerInventaire.Checked Then
      Droits += VariablesGlobales.DROIT_INVENTAIRE_DELETE
    End If

    If CheckBoxUtilisateurAjoutDroitAdminInventaire.Checked Then
      Droits += VariablesGlobales.DROIT_INVENTAIRE_ADMIN
    End If

    If CheckBoxUtilisateurAjoutDroitVoirFacture.Checked Then
      Droits += VariablesGlobales.DROIT_FACTURE_SELECT
    End If

    If CheckBoxUtilisateurAjoutDroitAjoutFacture.Checked Then
      Droits += VariablesGlobales.DROIT_FACTURE_INSERT
    End If

    If CheckBoxUtilisateurAjoutDroitVoirUtilisateur.Checked Then
      Droits += VariablesGlobales.DROIT_UTILISATEUR_SELECT
    End If

    If CheckBoxUtilisateurAjoutDroitAjoutUtilisateur.Checked Then
      Droits += VariablesGlobales.DROIT_UTILISATEUR_INSERT
    End If

    If CheckBoxUtilisateurAjoutDroitModifierUtilisateur.Checked Then
      Droits += VariablesGlobales.DROIT_UTILISATEUR_UPDATE
    End If

    If CheckBoxUtilisateurAjoutDroitSupprimerUtilisateur.Checked Then
      Droits += VariablesGlobales.DROIT_UTILISATEUR_DELETE
    End If

    If CheckBoxUtilisateurAjoutDroitAdminUtilisateur.Checked Then
      Droits += VariablesGlobales.DROIT_UTILISATEUR_ADMIN
    End If

    Return Droits
  End Function

  ' Méthode pour ajouter un nouveau Datarow
  Private Function ModifierRangee() As Boolean

    ' On s'assure que les modifications sont correctes
    If MsgBox(
          "Êtes-vous certain de vos modifications?",
          MsgBoxStyle.YesNo,
          "Attention!") = DialogResult.Yes Then

      Me.UpdateUtilisateur()

      ' On retourne vrai, pour cacher le formulaire
      Return True
    End If

    ' Si l'utilisateur n'est pas content de ses modifications, on retourne faux pour rester le formulaire ouvert
    Return False
  End Function

  Private Sub ViderFormulaire()
    ' Méthode pour vider l'intégralité du formulaire

    TextBoxUtilisateurAjoutNom.Text = ""
    TextBoxUtilisateurAjoutPrenom.Text = ""
    TextBoxUtilisateurAjoutUsername.Text = ""
    TextBoxUtilisateurAjoutCourriel.Text = ""
    TextBoxUtilisateurAjoutPassword.Text = ""
    CheckBoxUtilisateurAjoutDroitVoirInventaire.Checked = True
    CheckBoxUtilisateurAjoutDroitAjoutInventaire.Checked = False
    CheckBoxUtilisateurAjoutDroitModifierInventaire.Checked = False
    CheckBoxUtilisateurAjoutDroitSupprimerInventaire.Checked = False
    CheckBoxUtilisateurAjoutDroitAdminInventaire.Checked = False
    CheckBoxUtilisateurAjoutDroitVoirFacture.Checked = False
    CheckBoxUtilisateurAjoutDroitAjoutFacture.Checked = True
    CheckBoxUtilisateurAjoutDroitVoirUtilisateur.Checked = False
    CheckBoxUtilisateurAjoutDroitAjoutUtilisateur.Checked = False
    CheckBoxUtilisateurAjoutDroitModifierUtilisateur.Checked = False
    CheckBoxUtilisateurAjoutDroitSupprimerUtilisateur.Checked = False
    CheckBoxUtilisateurAjoutDroitAdminUtilisateur.Checked = False
  End Sub

  ' Méthode pour remplir l'intégralité du formulaire avec une rangée
  Private Sub RemplirChampsRangee()
    Dim Donnees As TP1_VB.SelectUtilisateurSingle_Result = Me.DataTableTrav.GetDataUtilisateurSingle(IDModif)

    With Donnees
      TextBoxUtilisateurAjoutNom.Text = .Nom.Trim()
      TextBoxUtilisateurAjoutPrenom.Text = .Prenom.Trim()
      TextBoxUtilisateurAjoutCourriel.Text = .Courriel.Trim()
      TextBoxUtilisateurAjoutPassword.Text = .Password.Trim()
      TextBoxUtilisateurAjoutUsername.Text = .Username.Trim()

      CheckBoxUtilisateurAjoutDroitVoirInventaire.Checked = CBool((.Droits And VariablesGlobales.DROIT_INVENTAIRE_SELECT) <> 0)
      CheckBoxUtilisateurAjoutDroitAjoutInventaire.Checked = CBool((.Droits And VariablesGlobales.DROIT_INVENTAIRE_INSERT) <> 0)
      CheckBoxUtilisateurAjoutDroitModifierInventaire.Checked = CBool((.Droits And VariablesGlobales.DROIT_INVENTAIRE_UPDATE) <> 0)
      CheckBoxUtilisateurAjoutDroitSupprimerInventaire.Checked = CBool((.Droits And VariablesGlobales.DROIT_INVENTAIRE_DELETE) <> 0)
      CheckBoxUtilisateurAjoutDroitAdminInventaire.Checked = CBool((.Droits And VariablesGlobales.DROIT_INVENTAIRE_ADMIN) <> 0)
      CheckBoxUtilisateurAjoutDroitVoirFacture.Checked = CBool((.Droits And VariablesGlobales.DROIT_FACTURE_SELECT) <> 0)
      CheckBoxUtilisateurAjoutDroitAjoutFacture.Checked = CBool((.Droits And VariablesGlobales.DROIT_FACTURE_INSERT) <> 0)
      CheckBoxUtilisateurAjoutDroitVoirUtilisateur.Checked = CBool((.Droits And VariablesGlobales.DROIT_UTILISATEUR_SELECT) <> 0)
      CheckBoxUtilisateurAjoutDroitAjoutUtilisateur.Checked = CBool((.Droits And VariablesGlobales.DROIT_UTILISATEUR_INSERT) <> 0)
      CheckBoxUtilisateurAjoutDroitModifierUtilisateur.Checked = CBool((.Droits And VariablesGlobales.DROIT_UTILISATEUR_UPDATE) <> 0)
      CheckBoxUtilisateurAjoutDroitSupprimerUtilisateur.Checked = CBool((.Droits And VariablesGlobales.DROIT_UTILISATEUR_DELETE) <> 0)
      CheckBoxUtilisateurAjoutDroitAdminUtilisateur.Checked = CBool((.Droits And VariablesGlobales.DROIT_UTILISATEUR_ADMIN) <> 0)
    End With
  End Sub

  Private Function VerifierChamp() As Boolean
    ' Fonction qui vérifie si tous les champs sont ok

    Dim Resultat As Boolean = True

    If TextBoxUtilisateurAjoutNom.Text = "" Then
      LabelUtilisateurAjoutNom.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxUtilisateurAjoutCourriel.Text = "" Then
      LabelUtilisateurAjoutCourriel.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxUtilisateurAjoutPrenom.Text = "" Then
      LabelUtilisateurAjoutPrenom.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxUtilisateurAjoutUsername.Text = "" Then
      LabelUtilisateurAjoutUsername.ForeColor = Color.Red
      Resultat = False
    End If

    If TextBoxUtilisateurAjoutPassword.Text = "" Then
      LabelUtilisateurAjoutPassword.ForeColor = Color.Red
      Resultat = False
    End If

    Return Resultat
  End Function

  ' Méthode pour mettre les couleurs des labels à la couleur normale
  Private Sub LabelCouleurNormale()
    LabelUtilisateurAjoutNom.ForeColor = Color.Black
    LabelUtilisateurAjoutPrenom.ForeColor = Color.Black
    LabelUtilisateurAjoutUsername.ForeColor = Color.Black
    LabelUtilisateurAjoutCourriel.ForeColor = Color.Black
    LabelUtilisateurAjoutPassword.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxUtilisateurAjoutNom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUtilisateurAjoutNom.TextChanged
    LabelUtilisateurAjoutNom.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxUtilisateurAjoutPrenom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUtilisateurAjoutPrenom.TextChanged
    LabelUtilisateurAjoutPrenom.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxUtilisateurAjoutUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUtilisateurAjoutUsername.TextChanged
    LabelUtilisateurAjoutUsername.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxUtilisateurAjoutCourriel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUtilisateurAjoutCourriel.TextChanged
    LabelUtilisateurAjoutCourriel.ForeColor = Color.Black
  End Sub

  Private Sub TextBoxUtilisateurAjoutPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUtilisateurAjoutPassword.TextChanged
    LabelUtilisateurAjoutPassword.ForeColor = Color.Black
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