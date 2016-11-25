Option Strict On
Option Explicit On

Public Class FormConnexionAdmin
  Private Sub ButtonItemsAdminOK_Click(sender As Object, e As EventArgs) Handles ButtonItemsAdminOK.Click
    ' Bouton pour se connecter

    If VerifierChamps() Then
      VariablesGlobales.ADMIN_CONNECTION = True

      Me.ViderChamps()
      Me.Hide()
    Else
      MsgBox("Nom d'utilisateur/Mot de passe incorrect!")
    End If
  End Sub

  Private Sub ButtonItemsAdminAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonItemsAdminAnnuler.Click
    ' Bouton pour annuler

    Me.ViderChamps()
    Me.Hide()
  End Sub

  Private Function VerifierChamps() As Boolean
    ' Fonction pour vérifier si les champs sont corrects

    If TextBoxAdminUtilisateur.Text = VariablesGlobales.ADMIN_UTILISATEUR And TextBoxAdminMDP.Text = VariablesGlobales.ADMIN_MDP Then
      Return True
    End If

    Return False
  End Function

  Private Sub ViderChamps()
    TextBoxAdminUtilisateur.Text = ""
    TextBoxAdminMDP.Text = ""
  End Sub

  Private Sub FormAjoutItem_Closing(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) _
    Handles MyBase.Closing
    ' Source : https://bytes.com/topic/visual-basic-net/answers/371062-hide-main-form-instead-closing
    ' Fonction pour cacher le formulaire au lieu de le fermer

    ViderChamps()
    Me.Hide()
    e.Cancel = True
  End Sub
End Class