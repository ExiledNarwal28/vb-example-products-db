'------------------------------------------------------------------------------
' <auto-generated>
'    Ce code a été généré à partir d'un modèle.
'
'    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
'    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Tb_Utilisateur
    Public Property ID As Integer
    Public Property NiveauAccessID As Nullable(Of Integer)
    Public Property Nom As String
    Public Property Prenom As String
    Public Property Username As String
    Public Property Courriel As String
    Public Property Password As String
    Public Property Droits As Nullable(Of Short)
    Public Property R2 As String

    Public Overridable Property Tb_Commande As ICollection(Of Tb_Commande) = New HashSet(Of Tb_Commande)
    Public Overridable Property Tb_Facture As ICollection(Of Tb_Facture) = New HashSet(Of Tb_Facture)
    Public Overridable Property Tb_NiveauAcces As Tb_NiveauAcces

End Class
