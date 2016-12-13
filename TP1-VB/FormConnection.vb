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
    If DataTableTrav.Connection(TextBoxConnUtilisateur.Text, TextBoxConnMDP.Text) Then
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

  Private Sub ViderChamps()
    TextBoxConnUtilisateur.Text = ""
    TextBoxConnMDP.Text = ""
  End Sub

  Private Sub FormConnection_Closing(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) _
    Handles MyBase.Closing
    ' Source : https://social.msdn.microsoft.com/Forums/en-US/2cc6c40b-63fe-48bc-a5a7-d86ab7aa779b/how-to-exit-application-in-visual-basic?forum=vbide
    ' Si l'utilisateur ferme le formulaire, on ferme l'application

    If DataTableTrav.GetUtilisateurID() = Nothing Then
      Application.Exit()
    End If
  End Sub
End Class