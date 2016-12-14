Option Strict On
Option Explicit On

Public Class FormAffichageFacture
  Private Totaux As List(Of String)
  Private NoEtu As String
  Private Comm As String
  Private DataTableAFact As DataTable

  Dim memoireImage As Bitmap ' Pour l'impression

  Public Sub New(ByVal DataGridViewFacture As DataGridView, ByVal Totaux As List(Of String), ByVal NoEtu As String, ByVal Comm As String)
    InitializeComponent()

    Me.Totaux = Totaux
    Me.NoEtu = NoEtu
    Me.Comm = Comm

    ' S'il n'y pas de texte, on veut mettre ça beau quand même!
    If Me.NoEtu = "" Then
      Me.NoEtu = "AUCUN"
    End If
    If Me.Comm = "" Then
      Me.Comm = "Aucun."
    End If

    PreparerTexte()

    PreparerDataTable()

    RemplirDataTable(DataGridViewFacture)

    ' La source du gridview est cette table
    DataGridViewAFact.DataSource = DataTableAFact

    PreparerDataGridView()

    TaillerFormulaire()
  End Sub

  Private Sub PreparerTexte()
    ' Méthode pour préparer le texte des labels

    ' On initialise des labels avec les variables globales
    LabelAFactNom.Text = VariablesGlobales.FACT_NOM
    LabelAFactAdd.Text = VariablesGlobales.FACT_ADD
    LabelAFactVille.Text = VariablesGlobales.FACT_VILLE & " (" & VariablesGlobales.FACT_PROV & "), " & VariablesGlobales.FACT_CP
    LabelAFactTel.Text = "Téléphone : " & VariablesGlobales.FACT_TEL
    LabelAFactFax.Text = "Fax : " & VariablesGlobales.FACT_FAX
    LabelAFactCourriel.Text = "Courriel : " & VariablesGlobales.FACT_COURRIEL

    ' On initialise des labels avec des valeurs calculés
    LabelAFactDate.Text = "Date : " & Date.Now.ToString("dd/MM/yy")

    ' Source : http://stackoverflow.com/questions/3253157/generation-9-digits-random-number-including-leading-zero
    ' Pour l'instant, le numéro de facture est un nombre aléatoire de 9 décimales
    ' TO ADD : Numéro de facture unique? Base de données?
    Dim rng As New Random
    LabelAFactNo.Text = "Facture # " & rng.Next(1, 1000000000).ToString("D9")

    ' On initialise le code étudiant et les commentaires
    LabelAFactNoEtu.Text = "Code étudiant : " & Me.NoEtu
    RichTextBoxAFactComm.Text = Me.Comm

    ' On initialise les totaux
    LabelAFactSousTotal.Text = Me.Totaux(0)
    LabelAFactTPS.Text = Me.Totaux(1)
    LabelAFactTVQ.Text = Me.Totaux(2)
    LabelAFactTotal.Text = Me.Totaux(3)
  End Sub

  Private Sub PreparerDataTable()
    DataTableAFact = New DataTable("Affichage_facture")

    With DataTableAFact
      .Columns.Add("item_desc", Type.GetType("System.String"))
      .Columns.Add("item_qt", Type.GetType("System.Int32"))
      .Columns.Add("item_prix_vente", Type.GetType("System.Double"))
      .Columns.Add("item_ext", Type.GetType("System.Double"))
    End With
  End Sub
  Private Sub RemplirDataTable(ByVal DataGridViewFacture As DataGridView)
    ' Méthode qui ajoute les rangées au datagridview

    Dim NouvelleRangee As DataRow

    For Each Rangee As DataGridViewRow In DataGridViewFacture.Rows
      NouvelleRangee = DataTableAFact.NewRow()

      NouvelleRangee("item_desc") = Rangee.Cells(2).Value
      NouvelleRangee("item_qt") = 1
      NouvelleRangee("item_prix_vente") = Rangee.Cells(4).Value
      NouvelleRangee("item_ext") = CDbl(Rangee.Cells(4).Value) * CDbl(Rangee.Cells(3).Value)

      DataTableAFact.Rows.Add(NouvelleRangee)
    Next
  End Sub


  Private Sub PreparerDataGridView()
    ' Méthode qui construit le DataGridViewAFact
    ' Source : https://msdn.microsoft.com/en-us/library/wkfe535h(v=vs.110).aspx

    ' On construit les colonnes
    With DataGridViewAFact
      .Columns("item_desc").DisplayIndex = 0
      .Columns("item_qt").DisplayIndex = 1
      .Columns("item_prix_vente").DisplayIndex = 2
      .Columns("item_ext").DisplayIndex = 3

      .Columns("item_desc").HeaderText = "Description"
      .Columns("item_qt").HeaderText = "Quantité"
      .Columns("item_prix_vente").HeaderText = "Prix de vente"
      .Columns("item_ext").HeaderText = "Extension"

      ' Source : http://stackoverflow.com/questions/15578945/datagridview-column-widths-as-percentage
      .Columns("item_desc").FillWeight = 400
      .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

      ' Source : http://stackoverflow.com/questions/11529228/datagridview-needs-to-hide-scrollbar-but-scroll-should-be-achievable-through-co
      .ScrollBars = ScrollBars.None
    End With
  End Sub

  Private Sub TaillerFormulaire()
    ' Hey c'est l'fun, tout va bien!
    ' Eh non. Si un utilisateur entre trop d'objets dans la facture, il y a un scrollbar.
    ' Pas fort pour l'imprimante ça mon homme.
    ' Il faut ajuster la taille de l'écran avec celle du DataGridView.

    ' Source : http://stackoverflow.com/questions/11669092/how-to-vertically-auto-size-a-winforms-datagridview-control-so-that-its-rows-ar
    Dim HauteurDataGridView As Integer = 20 ' 20 = la taille du header par défaut

    For Each Rangee As DataGridViewRow In DataGridViewAFact.Rows
      HauteurDataGridView += Rangee.Height
    Next

    ' On règle la taille de la fenêtre. 100 c'est la taille originale du datagridView
    Me.Height = Me.Height - 100 + HauteurDataGridView

    ' On met la hauteur du DataGridView comme optimal
    DataGridViewAFact.Height = HauteurDataGridView
  End Sub

  Public Sub ImprimerDialogue()
    ' Méthode qui affiche la facture et demande si l'utilisateur veut l'imprimer

    ' Source : https://www.tutorialspoint.com/vb.net/vb.net_print_dialog.htm

    CapturerFormulaire()

    PrintPreviewDialogAFact.Document = PrintDocumentAFact
    PrintPreviewDialogAFact.ShowDialog()
  End Sub

  Private Sub CapturerFormulaire()
    ' Source : https://www.tutorialspoint.com/vb.net/vb.net_print_dialog.htm

    Dim Graphique As Graphics = Me.CreateGraphics()
    Dim s As Size = Me.Size
    memoireImage = New Bitmap(s.Width, s.Height, Graphique)
    Dim memoireGraphique As Graphics = Graphics.FromImage(memoireImage)
    memoireGraphique.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, s)
  End Sub

  Private Sub printDocumentAFact_PrintPage(ByVal sender As System.Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _
       PrintDocumentAFact.PrintPage
    e.Graphics.DrawImage(memoireImage, 0, 0)
  End Sub
End Class