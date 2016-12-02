Option Strict On
Option Explicit On

Public Class FormNouvelleFacture
  Private ListeID As List(Of Integer)
  Private DataTableTrav As DataTableTravailleur

  Private VerificateurQuantite As Boolean

  Private FormAffichageFacture As FormAffichageFacture

  Public Sub New(ByRef DataTableTrav As DataTableTravailleur)
    InitializeComponent()

    Me.DataTableTrav = DataTableTrav

    ' D'abord, on organise la table associée au gridview
    OrganiserColonnes()

    ' Petit règlage dans l'affichage
    AffichageColonnes()
  End Sub

  Public Sub SetProduitID(ByVal ListeID As List(Of Integer))
    ' Méthode pour remplir les rangées qui seront dans le DataTable avec ce qui était sélectionné dans l'inventaire
    Me.ListeID = ListeID

    ' On applique les RangeesSelectionnees au DataTable
    AffichageRangees()

    ' On calcule les totaux
    ' CalculerTotaux()
  End Sub

  Private Sub OrganiserColonnes()
  End Sub

  Private Sub AffichageColonnes()
    ' Méthode qui construit les colonnes du DataGridViewFacture
    ' Source : https://msdn.microsoft.com/en-us/library/wkfe535h(v=vs.110).aspx

    ' On met toutes les colonnes en read only sauf la quantité
    ' Sources : http://stackoverflow.com/questions/2597268/how-do-i-allow-edit-only-a-particular-column-in-datagridview-in-windows-applicat

    'With DataGridViewFacture
    '  .Columns("item_id").Visible = False

    '  .Columns("item_code_produit").DisplayIndex = 0
    '  .Columns("item_desc").DisplayIndex = 1
    '  .Columns("item_qt").DisplayIndex = 2
    '  .Columns("item_prix_vente").DisplayIndex = 3
    '  .Columns("item_ext").DisplayIndex = 4
    '  .Columns("item_inv_qt").DisplayIndex = 5
    '  .Columns("item_nouv_qt").DisplayIndex = 6

    '  .Columns("item_code_produit").HeaderText = "Code produit"
    '  .Columns("item_desc").HeaderText = "Description"
    '  .Columns("item_qt").HeaderText = "Quantité"
    '  .Columns("item_prix_vente").HeaderText = "Prix de vente"
    '  .Columns("item_ext").HeaderText = "Extension"
    '  .Columns("item_inv_qt").HeaderText = "Quantité Inventaire"
    '  .Columns("item_nouv_qt").HeaderText = "Nouvelle quantité"

    '  .Columns("item_code_produit").ReadOnly = True
    '  .Columns("item_desc").ReadOnly = True
    '  .Columns("item_qt").ReadOnly = False
    '  .Columns("item_prix_vente").ReadOnly = True
    '  .Columns("item_ext").ReadOnly = True
    '  .Columns("item_inv_qt").ReadOnly = True
    '  .Columns("item_nouv_qt").ReadOnly = True

    '  .Columns("item_qt").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)

    '  .AutoResizeColumns()
    'End With
  End Sub

  Private Sub AffichageRangees()
    ' Méthode qui utilise les rangées sélectionnées pour fabriquer les rangées du DataGridViewFacture

    DataGridViewFacture.DataSource = DataTableTrav.GetDataInventaireFactureParID(ListeID)

    ' CalculerExtensions()

    ' VerifierQuantite()
  End Sub

  Private Sub CalculerExtensions()
    For Each Rangee As DataGridViewRow In DataGridViewFacture.Rows
      Rangee.Cells("item_ext").Value = CDbl(Rangee.Cells("item_prix_vente").Value) * CDbl(Rangee.Cells("item_qt").Value)
      Rangee.Cells("item_nouv_qt").Value = CInt(Rangee.Cells("item_inv_qt").Value) - CInt(Rangee.Cells("item_qt").Value)
    Next
  End Sub

  Private Sub CalculerTotaux()
    ' Méthode pour calculer et afficher le sous-total, TPS, TVQ et total.

    Dim soustotal As Double = 0

    For Each Rangee As DataGridViewRow In DataGridViewFacture.Rows
      soustotal += CDbl(Rangee.Cells("item_ext").Value)
    Next

    TextBoxFactureSousTotal.Text = CStr(Math.Round(soustotal, 2)) & " $"
    TextBoxFactureTPS.Text = CStr(Math.Round(soustotal * VariablesGlobales.TPS_VALEUR, 2)) & " $"
    TextBoxFactureTVQ.Text = CStr(Math.Round(soustotal * VariablesGlobales.TVQ_VALEUR, 2)) & " $"
    TextBoxFactureTotal.Text = CStr(Math.Round(soustotal + soustotal * VariablesGlobales.TPS_VALEUR + soustotal * VariablesGlobales.TVQ_VALEUR, 2)) & " $"
  End Sub

  Private Sub VerifierQuantite()
    ' Méthode pour vérifier les quantités

    ' Si ce flag est vrai, alors toutes les quantités sont positives
    VerificateurQuantite = True

    For Each Rangee As DataGridViewRow In DataGridViewFacture.Rows
      If CInt(Rangee.Cells("item_nouv_qt").Value) < 0 Or CInt(Rangee.Cells("item_qt").Value) < 1 Then
        Rangee.DefaultCellStyle.ForeColor = Color.Red
        VerificateurQuantite = False
      Else
        Rangee.DefaultCellStyle.ForeColor = Color.Black
      End If
    Next
  End Sub

  Private Function ConstruireDictionnaireQuantites() As Dictionary(Of Integer, Integer)
    ' Fonction pour construire un dictionnaire des item_id et item_qt

    Dim DictQuantite As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)

    For Each Rangee As DataGridViewRow In DataGridViewFacture.Rows
      DictQuantite.Add(CInt(Rangee.Cells("item_id").Value), CInt(Rangee.Cells("item_qt").Value))
    Next

    Return DictQuantite
  End Function

  Private Sub FormAjoutItem_Closing(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) _
    Handles MyBase.Closing
    ' Source : https://bytes.com/topic/visual-basic-net/answers/371062-hide-main-form-instead-closing
    ' Fonction pour cacher le formulaire au lieu de le fermer
    Me.ViderFormulaire()
    Me.Hide()
    e.Cancel = True
  End Sub

  Private Sub BoutonFactureOK_Click(sender As Object, e As EventArgs) Handles BoutonFactureOK.Click
    ' Ce bouton verifie si la facture est correcte, puis la facture

    ' On vérifie si les quantités sont ok
    If VerificateurQuantite Then
      If MsgBox(
          "Êtes-vous certain de votre facture?",
          MsgBoxStyle.YesNo,
          "Facturation") = DialogResult.Yes Then

        ' Si l'utilisateur répond positivement

        ' Enlever les quantités de l'inventaire
        DataTableTrav.EnleverQuantite(ConstruireDictionnaireQuantites())

        ' On instancie un formulaire pour l'affichage de la facture. Ceci demande aussi à l'utilisateur s'il veut l'imprimer.
        Dim FormAffichageFacture As FormAffichageFacture = New FormAffichageFacture(Me.DataGridViewFacture, GetTotaux(), TextBoxFactureCodeEtu.Text, RichTextBoxComm.Text)

        FormAffichageFacture.Show()

        ' J'ai besoin de ce flag pour que le msgbox soit fermé lorsqu'on imprime
        Dim VaTilDireOui As Boolean = False

        If MsgBox(
          "Voici l'affichage de votre facture" & Environment.NewLine & "Souhaitez-vous l'imprimer?",
          MsgBoxStyle.YesNo,
          "Impression") = DialogResult.Yes Then
          VaTilDireOui = True
        End If

        If VaTilDireOui Then
          ' Soure : http://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154
          Threading.Thread.Sleep(500)
          FormAffichageFacture.ImprimerDialogue()
        End If

        FormAffichageFacture.Hide()

        ' On ferme ensuite tout ça :D
        Me.ViderFormulaire()
        Me.Hide()
      End If
    Else
      MsgBox("Facture invalide.")
    End If
  End Sub

  Private Function GetTotaux() As List(Of String)
    ' Fonction qui retourne une liste des totaux de la facture

    Dim ListeTotaux As List(Of String) = New List(Of String)

    ListeTotaux.Add(TextBoxFactureSousTotal.Text)
    ListeTotaux.Add(TextBoxFactureTPS.Text)
    ListeTotaux.Add(TextBoxFactureTVQ.Text)
    ListeTotaux.Add(TextBoxFactureTotal.Text)

    Return ListeTotaux
  End Function

  Private Sub BoutonFactureAnnuler_Click(sender As Object, e As EventArgs) Handles BoutonFactureAnnuler.Click
    Me.ViderFormulaire()
    Me.Hide()
  End Sub

  Private Sub ViderFormulaire()
    ' On vide les textboxs
    TextBoxFactureCodeEtu.Text = ""
    TextBoxFactureSousTotal.Text = ""
    TextBoxFactureTPS.Text = ""
    TextBoxFactureTVQ.Text = ""
    TextBoxFactureTotal.Text = ""

    ' On met les tailles normales
    Me.Height = 378
    DataGridViewFacture.Height = 175

    ' On enlève toutes les rangées de la table
    ListeID = Nothing
  End Sub

  Private Sub DataGridViewFacture_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFacture.CellEndEdit
    ' Il faut recalculer les extensions et les totaux lorsqu'on change les quantités

    CalculerExtensions()

    CalculerTotaux()

    VerifierQuantite()
  End Sub
End Class