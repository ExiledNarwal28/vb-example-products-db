﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Ce code a été généré à partir d'un modèle.
'
'    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
'    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq

Partial Public Class COOPInventaire_TP3_testsEntities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=COOPInventaire_TP3_testsEntities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Property Tb_Categorie() As DbSet(Of Tb_Categorie)
    Public Property Tb_Commande() As DbSet(Of Tb_Commande)
    Public Property Tb_CommandeItem() As DbSet(Of Tb_CommandeItem)
    Public Property Tb_Departement() As DbSet(Of Tb_Departement)
    Public Property Tb_Emplacement() As DbSet(Of Tb_Emplacement)
    Public Property Tb_Facture() As DbSet(Of Tb_Facture)
    Public Property Tb_FactureItem() As DbSet(Of Tb_FactureItem)
    Public Property Tb_Fournisseur() As DbSet(Of Tb_Fournisseur)
    Public Property Tb_Inventaire() As DbSet(Of Tb_Inventaire)
    Public Property Tb_Membre() As DbSet(Of Tb_Membre)
    Public Property Tb_NiveauAcces() As DbSet(Of Tb_NiveauAcces)
    Public Property Tb_Produit() As DbSet(Of Tb_Produit)
    Public Property Tb_Taxe() As DbSet(Of Tb_Taxe)
    Public Property Tb_Utilisateur() As DbSet(Of Tb_Utilisateur)
    Public Property Tb_Localisation() As DbSet(Of Tb_Localisation)

    Public Overridable Function DeleteInventaireComplet(iD As Nullable(Of Integer)) As Integer
        Dim iDParameter As ObjectParameter = If(iD.HasValue, New ObjectParameter("ID", iD), New ObjectParameter("ID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("DeleteInventaireComplet", iDParameter)
    End Function

    Public Overridable Function InsertInventaireComplet(codeProduit As String, description As String, emplacement As String, categorie As String, departement As String, fournisseurCode As String, fournisseurNom As String, prixVente As Nullable(Of Double), prixAchat As Nullable(Of Double), qt As Nullable(Of Integer)) As Integer
        Dim codeProduitParameter As ObjectParameter = If(codeProduit IsNot Nothing, New ObjectParameter("CodeProduit", codeProduit), New ObjectParameter("CodeProduit", GetType(String)))

        Dim descriptionParameter As ObjectParameter = If(description IsNot Nothing, New ObjectParameter("Description", description), New ObjectParameter("Description", GetType(String)))

        Dim emplacementParameter As ObjectParameter = If(emplacement IsNot Nothing, New ObjectParameter("Emplacement", emplacement), New ObjectParameter("Emplacement", GetType(String)))

        Dim categorieParameter As ObjectParameter = If(categorie IsNot Nothing, New ObjectParameter("Categorie", categorie), New ObjectParameter("Categorie", GetType(String)))

        Dim departementParameter As ObjectParameter = If(departement IsNot Nothing, New ObjectParameter("Departement", departement), New ObjectParameter("Departement", GetType(String)))

        Dim fournisseurCodeParameter As ObjectParameter = If(fournisseurCode IsNot Nothing, New ObjectParameter("FournisseurCode", fournisseurCode), New ObjectParameter("FournisseurCode", GetType(String)))

        Dim fournisseurNomParameter As ObjectParameter = If(fournisseurNom IsNot Nothing, New ObjectParameter("FournisseurNom", fournisseurNom), New ObjectParameter("FournisseurNom", GetType(String)))

        Dim prixVenteParameter As ObjectParameter = If(prixVente.HasValue, New ObjectParameter("PrixVente", prixVente), New ObjectParameter("PrixVente", GetType(Double)))

        Dim prixAchatParameter As ObjectParameter = If(prixAchat.HasValue, New ObjectParameter("PrixAchat", prixAchat), New ObjectParameter("PrixAchat", GetType(Double)))

        Dim qtParameter As ObjectParameter = If(qt.HasValue, New ObjectParameter("Qt", qt), New ObjectParameter("Qt", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("InsertInventaireComplet", codeProduitParameter, descriptionParameter, emplacementParameter, categorieParameter, departementParameter, fournisseurCodeParameter, fournisseurNomParameter, prixVenteParameter, prixAchatParameter, qtParameter)
    End Function

    Public Overridable Function InsertUtilisateur(username As String, password As String, courriel As String, nom As String, prenom As String, droits As Nullable(Of Short)) As Integer
        Dim usernameParameter As ObjectParameter = If(username IsNot Nothing, New ObjectParameter("Username", username), New ObjectParameter("Username", GetType(String)))

        Dim passwordParameter As ObjectParameter = If(password IsNot Nothing, New ObjectParameter("Password", password), New ObjectParameter("Password", GetType(String)))

        Dim courrielParameter As ObjectParameter = If(courriel IsNot Nothing, New ObjectParameter("Courriel", courriel), New ObjectParameter("Courriel", GetType(String)))

        Dim nomParameter As ObjectParameter = If(nom IsNot Nothing, New ObjectParameter("Nom", nom), New ObjectParameter("Nom", GetType(String)))

        Dim prenomParameter As ObjectParameter = If(prenom IsNot Nothing, New ObjectParameter("Prenom", prenom), New ObjectParameter("Prenom", GetType(String)))

        Dim droitsParameter As ObjectParameter = If(droits.HasValue, New ObjectParameter("Droits", droits), New ObjectParameter("Droits", GetType(Short)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("InsertUtilisateur", usernameParameter, passwordParameter, courrielParameter, nomParameter, prenomParameter, droitsParameter)
    End Function

    Public Overridable Function ReduireQtInventaireComplet(iD As Nullable(Of Integer), amount As Nullable(Of Integer)) As Integer
        Dim iDParameter As ObjectParameter = If(iD.HasValue, New ObjectParameter("ID", iD), New ObjectParameter("ID", GetType(Integer)))

        Dim amountParameter As ObjectParameter = If(amount.HasValue, New ObjectParameter("Amount", amount), New ObjectParameter("Amount", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("ReduireQtInventaireComplet", iDParameter, amountParameter)
    End Function

    Public Overridable Function SelectInventaireComplet() As ObjectResult(Of SelectInventaireComplet_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelectInventaireComplet_Result)("SelectInventaireComplet")
    End Function

    Public Overridable Function SelectInventaireCompletFiltre(codeProduit As String, description As String, emplacement As String, categorie As String, departement As String, fournisseur As String) As ObjectResult(Of SelectInventaireCompletFiltre_Result)
        Dim codeProduitParameter As ObjectParameter = If(codeProduit IsNot Nothing, New ObjectParameter("CodeProduit", codeProduit), New ObjectParameter("CodeProduit", GetType(String)))

        Dim descriptionParameter As ObjectParameter = If(description IsNot Nothing, New ObjectParameter("Description", description), New ObjectParameter("Description", GetType(String)))

        Dim emplacementParameter As ObjectParameter = If(emplacement IsNot Nothing, New ObjectParameter("Emplacement", emplacement), New ObjectParameter("Emplacement", GetType(String)))

        Dim categorieParameter As ObjectParameter = If(categorie IsNot Nothing, New ObjectParameter("Categorie", categorie), New ObjectParameter("Categorie", GetType(String)))

        Dim departementParameter As ObjectParameter = If(departement IsNot Nothing, New ObjectParameter("Departement", departement), New ObjectParameter("Departement", GetType(String)))

        Dim fournisseurParameter As ObjectParameter = If(fournisseur IsNot Nothing, New ObjectParameter("Fournisseur", fournisseur), New ObjectParameter("Fournisseur", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelectInventaireCompletFiltre_Result)("SelectInventaireCompletFiltre", codeProduitParameter, descriptionParameter, emplacementParameter, categorieParameter, departementParameter, fournisseurParameter)
    End Function

    Public Overridable Function SelectInventaireCompletSingle(iD As Nullable(Of Integer)) As ObjectResult(Of SelectInventaireCompletSingle_Result)
        Dim iDParameter As ObjectParameter = If(iD.HasValue, New ObjectParameter("ID", iD), New ObjectParameter("ID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelectInventaireCompletSingle_Result)("SelectInventaireCompletSingle", iDParameter)
    End Function

    Public Overridable Function SelectUtilisateur() As ObjectResult(Of SelectUtilisateur_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelectUtilisateur_Result)("SelectUtilisateur")
    End Function

    Public Overridable Function SelectUtilisateurDroitsSingle(iD As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Short))
        Dim iDParameter As ObjectParameter = If(iD.HasValue, New ObjectParameter("ID", iD), New ObjectParameter("ID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Short))("SelectUtilisateurDroitsSingle", iDParameter)
    End Function

    Public Overridable Function SelectUtilisateurIDSingle(username As String, password As String) As ObjectResult(Of Nullable(Of Integer))
        Dim usernameParameter As ObjectParameter = If(username IsNot Nothing, New ObjectParameter("Username", username), New ObjectParameter("Username", GetType(String)))

        Dim passwordParameter As ObjectParameter = If(password IsNot Nothing, New ObjectParameter("Password", password), New ObjectParameter("Password", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("SelectUtilisateurIDSingle", usernameParameter, passwordParameter)
    End Function

    Public Overridable Function sp_alterdiagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_creatediagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_dropdiagram(diagramname As String, owner_id As Nullable(Of Integer)) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagramdefinition(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagramdefinition_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagramdefinition_Result)("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagrams(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagrams_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagrams_Result)("sp_helpdiagrams", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_renamediagram(diagramname As String, owner_id As Nullable(Of Integer), new_diagramname As String) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim new_diagramnameParameter As ObjectParameter = If(new_diagramname IsNot Nothing, New ObjectParameter("new_diagramname", new_diagramname), New ObjectParameter("new_diagramname", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter)
    End Function

    Public Overridable Function sp_upgraddiagrams() As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_upgraddiagrams")
    End Function

    Public Overridable Function UpdateInventaireComplet(iD As Nullable(Of Integer), codeProduit As String, description As String, emplacement As String, categorie As String, departement As String, fournisseurCode As String, fournisseurNom As String, prixVente As Nullable(Of Double), prixAchat As Nullable(Of Double), qt As Nullable(Of Integer)) As Integer
        Dim iDParameter As ObjectParameter = If(iD.HasValue, New ObjectParameter("ID", iD), New ObjectParameter("ID", GetType(Integer)))

        Dim codeProduitParameter As ObjectParameter = If(codeProduit IsNot Nothing, New ObjectParameter("CodeProduit", codeProduit), New ObjectParameter("CodeProduit", GetType(String)))

        Dim descriptionParameter As ObjectParameter = If(description IsNot Nothing, New ObjectParameter("Description", description), New ObjectParameter("Description", GetType(String)))

        Dim emplacementParameter As ObjectParameter = If(emplacement IsNot Nothing, New ObjectParameter("Emplacement", emplacement), New ObjectParameter("Emplacement", GetType(String)))

        Dim categorieParameter As ObjectParameter = If(categorie IsNot Nothing, New ObjectParameter("Categorie", categorie), New ObjectParameter("Categorie", GetType(String)))

        Dim departementParameter As ObjectParameter = If(departement IsNot Nothing, New ObjectParameter("Departement", departement), New ObjectParameter("Departement", GetType(String)))

        Dim fournisseurCodeParameter As ObjectParameter = If(fournisseurCode IsNot Nothing, New ObjectParameter("FournisseurCode", fournisseurCode), New ObjectParameter("FournisseurCode", GetType(String)))

        Dim fournisseurNomParameter As ObjectParameter = If(fournisseurNom IsNot Nothing, New ObjectParameter("FournisseurNom", fournisseurNom), New ObjectParameter("FournisseurNom", GetType(String)))

        Dim prixVenteParameter As ObjectParameter = If(prixVente.HasValue, New ObjectParameter("PrixVente", prixVente), New ObjectParameter("PrixVente", GetType(Double)))

        Dim prixAchatParameter As ObjectParameter = If(prixAchat.HasValue, New ObjectParameter("PrixAchat", prixAchat), New ObjectParameter("PrixAchat", GetType(Double)))

        Dim qtParameter As ObjectParameter = If(qt.HasValue, New ObjectParameter("Qt", qt), New ObjectParameter("Qt", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("UpdateInventaireComplet", iDParameter, codeProduitParameter, descriptionParameter, emplacementParameter, categorieParameter, departementParameter, fournisseurCodeParameter, fournisseurNomParameter, prixVenteParameter, prixAchatParameter, qtParameter)
    End Function

End Class
