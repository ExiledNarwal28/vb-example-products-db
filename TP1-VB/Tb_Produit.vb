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

Partial Public Class Tb_Produit
    Public Property ID As Integer
    Public Property Devaluation As Nullable(Of Boolean)
    Public Property Suppression As Nullable(Of Boolean)
    Public Property CodeBarre As String
    Public Property CodeProduit As String
    Public Property Description As String
    Public Property Taxe1 As Nullable(Of Boolean)
    Public Property Taxe2 As Nullable(Of Boolean)
    Public Property R1 As String
    Public Property R2 As String

    Public Overridable Property Tb_CommandeItem As ICollection(Of Tb_CommandeItem) = New HashSet(Of Tb_CommandeItem)
    Public Overridable Property Tb_FactureItem As ICollection(Of Tb_FactureItem) = New HashSet(Of Tb_FactureItem)
    Public Overridable Property Tb_Inventaire As ICollection(Of Tb_Inventaire) = New HashSet(Of Tb_Inventaire)

End Class