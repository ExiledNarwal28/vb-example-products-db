Option Strict On
Option Explicit On

Public Class FormConnection
  Private DataTableTrav As DataTableTravailleur
  Public Sub New(ByRef DataTableTrav As DataTableTravailleur)
    InitializeComponent()

    Me.DataTableTrav = DataTableTrav
  End Sub

  Private Sub ButtonConnOK_Click(sender As Object, e As EventArgs) Handles ButtonConnOK.Click
    ' Bouton pour se connecter

    If Connection() Then
      Me.ViderChamps()
      Me.Hide()
    Else
      MsgBox("Informations incorrectes!")
    End If
  End Sub

  Private Sub ButtonConnAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonConnAnnuler.Click
    ' Bouton pour annuler

    Me.ViderChamps()
    Me.Hide()
  End Sub

  Private Function Connection() As Boolean
    ' Fonction pour vérifier si les champs sont corrects

      ' Connecter l'utilisateur
      ' Si ok -> true
      ' Si pas ok -> false
    Return DataTableTrav.Connection(TextBoxConnUtilisateur.Text,
                                    TextBoxConnMDP.Text,
                                    TextBoxConnAdresse.Text)

      ' If TextBoxAdminUtilisateur.Text = VariablesGlobales.ADMIN_UTILISATEUR And TextBoxAdminMDP.Text = VariablesGlobales.ADMIN_MDP Then
      '   Return True
      ' End If
  End Function

  Private Sub ViderChamps()
    TextBoxConnUtilisateur.Text = ""
    TextBoxConnMDP.Text = ""
    TextBoxConnAdresse.Text = ""
  End Sub

  Private Sub FormConnection_Closing(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) _
    Handles MyBase.Closing
    ' Source : https://social.msdn.microsoft.com/Forums/en-US/2cc6c40b-63fe-48bc-a5a7-d86ab7aa779b/how-to-exit-application-in-visual-basic?forum=vbide
    ' Si l'utilisateur ferme le formulaire, on ferme l'application

    Application.Exit()
  End Sub
End Class