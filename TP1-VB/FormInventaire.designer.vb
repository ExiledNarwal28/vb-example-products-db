<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventaire
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requise par le Concepteur Windows Form
  Private components As System.ComponentModel.IContainer

  'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
  'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
  'Ne la modifiez pas à l'aide de l'éditeur de code.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.PageInventaire = New System.Windows.Forms.TabControl()
    Me.TabPageItems = New System.Windows.Forms.TabPage()
    Me.LabelItemsNb = New System.Windows.Forms.Label()
    Me.CheckBoxItemsNb = New System.Windows.Forms.CheckBox()
    Me.TextBoxItemsTotal = New System.Windows.Forms.TextBox()
    Me.LabelItemsTotal = New System.Windows.Forms.Label()
    Me.LabelItemsFourn = New System.Windows.Forms.Label()
    Me.TextBoxRechItemsFourn = New System.Windows.Forms.TextBox()
    Me.LabelItemsDesc = New System.Windows.Forms.Label()
    Me.TextBoxRechItemsDesc = New System.Windows.Forms.TextBox()
    Me.LabelItemsEmp = New System.Windows.Forms.Label()
    Me.TextBoxRechItemsEmp = New System.Windows.Forms.TextBox()
    Me.LabelItemsCat = New System.Windows.Forms.Label()
    Me.TextBoxRechItemsCat = New System.Windows.Forms.TextBox()
    Me.LabelItemsDep = New System.Windows.Forms.Label()
    Me.TextBoxRechItemsDep = New System.Windows.Forms.TextBox()
    Me.LabelItemsCode = New System.Windows.Forms.Label()
    Me.ButtonSupprimerItems = New System.Windows.Forms.Button()
    Me.ButtonModifierItems = New System.Windows.Forms.Button()
    Me.LabelItemRecherche = New System.Windows.Forms.Label()
    Me.ButtonItemFacture = New System.Windows.Forms.Button()
    Me.ButtonAjoutItems = New System.Windows.Forms.Button()
    Me.TextBoxRechItemsCode = New System.Windows.Forms.TextBox()
    Me.LabelRechItems = New System.Windows.Forms.Label()
    Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.LabelFacturesNb = New System.Windows.Forms.Label()
    Me.DataGridViewFactures = New System.Windows.Forms.DataGridView()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.LabelUtilisateursNb = New System.Windows.Forms.Label()
    Me.DataGridView2 = New System.Windows.Forms.DataGridView()
    Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.UtilisateurNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VoirInventaire = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.AjoutInventaire = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ModifierInventaire = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.SupprimerInventaire = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.AdminInventaire = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.VoirFacture = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.AjoutFacture = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ModifierFacture = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.SupprimerFacture = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.VoirUtilisateur = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.AjoutUtilisateur = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ModifierUtilisateur = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.SupprimerUtilisateur = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.fact_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.fact_stotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.nb_items_fact = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.code_etu = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Date_fact = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.no_fact = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ButtonConnexionAdmin = New System.Windows.Forms.Button()
    Me.ButtonSauvegarder = New System.Windows.Forms.Button()
    Me.ButtonFactureFacture = New System.Windows.Forms.Button()
    Me.ButtonUtilisateurFacture = New System.Windows.Forms.Button()
    Me.ButtonAjoutFacture = New System.Windows.Forms.Button()
    Me.ButtonAjoutUtilisateur = New System.Windows.Forms.Button()
    Me.ButtonModifierFacture = New System.Windows.Forms.Button()
    Me.ButtonModifierUtilisateur = New System.Windows.Forms.Button()
    Me.ButtonSupprimerFacture = New System.Windows.Forms.Button()
    Me.ButtonSupprimerUtilisateur = New System.Windows.Forms.Button()
    Me.PageInventaire.SuspendLayout()
    Me.TabPageItems.SuspendLayout()
    CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage1.SuspendLayout()
    CType(Me.DataGridViewFactures, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage2.SuspendLayout()
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PageInventaire
    '
    Me.PageInventaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PageInventaire.Controls.Add(Me.TabPageItems)
    Me.PageInventaire.Controls.Add(Me.TabPage1)
    Me.PageInventaire.Controls.Add(Me.TabPage2)
    Me.PageInventaire.Location = New System.Drawing.Point(12, 12)
    Me.PageInventaire.Name = "PageInventaire"
    Me.PageInventaire.SelectedIndex = 0
    Me.PageInventaire.Size = New System.Drawing.Size(1017, 534)
    Me.PageInventaire.TabIndex = 0
    '
    'TabPageItems
    '
    Me.TabPageItems.BackColor = System.Drawing.Color.Khaki
    Me.TabPageItems.Controls.Add(Me.LabelItemsNb)
    Me.TabPageItems.Controls.Add(Me.CheckBoxItemsNb)
    Me.TabPageItems.Controls.Add(Me.TextBoxItemsTotal)
    Me.TabPageItems.Controls.Add(Me.LabelItemsTotal)
    Me.TabPageItems.Controls.Add(Me.LabelItemsFourn)
    Me.TabPageItems.Controls.Add(Me.TextBoxRechItemsFourn)
    Me.TabPageItems.Controls.Add(Me.LabelItemsDesc)
    Me.TabPageItems.Controls.Add(Me.TextBoxRechItemsDesc)
    Me.TabPageItems.Controls.Add(Me.LabelItemsEmp)
    Me.TabPageItems.Controls.Add(Me.TextBoxRechItemsEmp)
    Me.TabPageItems.Controls.Add(Me.LabelItemsCat)
    Me.TabPageItems.Controls.Add(Me.TextBoxRechItemsCat)
    Me.TabPageItems.Controls.Add(Me.LabelItemsDep)
    Me.TabPageItems.Controls.Add(Me.TextBoxRechItemsDep)
    Me.TabPageItems.Controls.Add(Me.LabelItemsCode)
    Me.TabPageItems.Controls.Add(Me.ButtonSupprimerItems)
    Me.TabPageItems.Controls.Add(Me.ButtonModifierItems)
    Me.TabPageItems.Controls.Add(Me.LabelItemRecherche)
    Me.TabPageItems.Controls.Add(Me.ButtonItemFacture)
    Me.TabPageItems.Controls.Add(Me.ButtonAjoutItems)
    Me.TabPageItems.Controls.Add(Me.TextBoxRechItemsCode)
    Me.TabPageItems.Controls.Add(Me.LabelRechItems)
    Me.TabPageItems.Controls.Add(Me.DataGridViewItems)
    Me.TabPageItems.Location = New System.Drawing.Point(4, 22)
    Me.TabPageItems.Name = "TabPageItems"
    Me.TabPageItems.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPageItems.Size = New System.Drawing.Size(1009, 508)
    Me.TabPageItems.TabIndex = 0
    Me.TabPageItems.Text = "Inventaire"
    '
    'LabelItemsNb
    '
    Me.LabelItemsNb.AutoSize = True
    Me.LabelItemsNb.Location = New System.Drawing.Point(160, 489)
    Me.LabelItemsNb.Name = "LabelItemsNb"
    Me.LabelItemsNb.Size = New System.Drawing.Size(213, 13)
    Me.LabelItemsNb.TabIndex = 27
    Me.LabelItemsNb.Text = "Nombre d'items d'inventaire sélectionnés : 0"
    '
    'CheckBoxItemsNb
    '
    Me.CheckBoxItemsNb.AutoSize = True
    Me.CheckBoxItemsNb.Location = New System.Drawing.Point(9, 397)
    Me.CheckBoxItemsNb.Name = "CheckBoxItemsNb"
    Me.CheckBoxItemsNb.Size = New System.Drawing.Size(113, 17)
    Me.CheckBoxItemsNb.TabIndex = 26
    Me.CheckBoxItemsNb.Text = "Items sélectionnés"
    Me.CheckBoxItemsNb.UseVisualStyleBackColor = True
    '
    'TextBoxItemsTotal
    '
    Me.TextBoxItemsTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.TextBoxItemsTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.TextBoxItemsTotal.Location = New System.Drawing.Point(7, 465)
    Me.TextBoxItemsTotal.Name = "TextBoxItemsTotal"
    Me.TextBoxItemsTotal.ReadOnly = True
    Me.TextBoxItemsTotal.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxItemsTotal.TabIndex = 24
    Me.TextBoxItemsTotal.Visible = False
    '
    'LabelItemsTotal
    '
    Me.LabelItemsTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.LabelItemsTotal.AutoSize = True
    Me.LabelItemsTotal.Location = New System.Drawing.Point(11, 448)
    Me.LabelItemsTotal.Name = "LabelItemsTotal"
    Me.LabelItemsTotal.Size = New System.Drawing.Size(134, 13)
    Me.LabelItemsTotal.TabIndex = 23
    Me.LabelItemsTotal.Text = "Total de l'inventaire affiché"
    Me.LabelItemsTotal.Visible = False
    '
    'LabelItemsFourn
    '
    Me.LabelItemsFourn.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemsFourn.AutoSize = True
    Me.LabelItemsFourn.Location = New System.Drawing.Point(6, 355)
    Me.LabelItemsFourn.Name = "LabelItemsFourn"
    Me.LabelItemsFourn.Size = New System.Drawing.Size(61, 13)
    Me.LabelItemsFourn.TabIndex = 22
    Me.LabelItemsFourn.Text = "Fournisseur"
    '
    'TextBoxRechItemsFourn
    '
    Me.TextBoxRechItemsFourn.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.TextBoxRechItemsFourn.Location = New System.Drawing.Point(9, 371)
    Me.TextBoxRechItemsFourn.Name = "TextBoxRechItemsFourn"
    Me.TextBoxRechItemsFourn.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxRechItemsFourn.TabIndex = 21
    '
    'LabelItemsDesc
    '
    Me.LabelItemsDesc.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemsDesc.AutoSize = True
    Me.LabelItemsDesc.Location = New System.Drawing.Point(6, 183)
    Me.LabelItemsDesc.Name = "LabelItemsDesc"
    Me.LabelItemsDesc.Size = New System.Drawing.Size(60, 13)
    Me.LabelItemsDesc.TabIndex = 20
    Me.LabelItemsDesc.Text = "Description"
    '
    'TextBoxRechItemsDesc
    '
    Me.TextBoxRechItemsDesc.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.TextBoxRechItemsDesc.Location = New System.Drawing.Point(9, 199)
    Me.TextBoxRechItemsDesc.Name = "TextBoxRechItemsDesc"
    Me.TextBoxRechItemsDesc.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxRechItemsDesc.TabIndex = 19
    '
    'LabelItemsEmp
    '
    Me.LabelItemsEmp.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemsEmp.AutoSize = True
    Me.LabelItemsEmp.Location = New System.Drawing.Point(6, 225)
    Me.LabelItemsEmp.Name = "LabelItemsEmp"
    Me.LabelItemsEmp.Size = New System.Drawing.Size(71, 13)
    Me.LabelItemsEmp.TabIndex = 18
    Me.LabelItemsEmp.Text = "Emplacement"
    '
    'TextBoxRechItemsEmp
    '
    Me.TextBoxRechItemsEmp.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.TextBoxRechItemsEmp.Location = New System.Drawing.Point(9, 241)
    Me.TextBoxRechItemsEmp.Name = "TextBoxRechItemsEmp"
    Me.TextBoxRechItemsEmp.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxRechItemsEmp.TabIndex = 17
    '
    'LabelItemsCat
    '
    Me.LabelItemsCat.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemsCat.AutoSize = True
    Me.LabelItemsCat.Location = New System.Drawing.Point(6, 270)
    Me.LabelItemsCat.Name = "LabelItemsCat"
    Me.LabelItemsCat.Size = New System.Drawing.Size(52, 13)
    Me.LabelItemsCat.TabIndex = 16
    Me.LabelItemsCat.Text = "Catégorie"
    '
    'TextBoxRechItemsCat
    '
    Me.TextBoxRechItemsCat.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.TextBoxRechItemsCat.Location = New System.Drawing.Point(9, 286)
    Me.TextBoxRechItemsCat.Name = "TextBoxRechItemsCat"
    Me.TextBoxRechItemsCat.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxRechItemsCat.TabIndex = 15
    '
    'LabelItemsDep
    '
    Me.LabelItemsDep.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemsDep.AutoSize = True
    Me.LabelItemsDep.Location = New System.Drawing.Point(6, 313)
    Me.LabelItemsDep.Name = "LabelItemsDep"
    Me.LabelItemsDep.Size = New System.Drawing.Size(68, 13)
    Me.LabelItemsDep.TabIndex = 14
    Me.LabelItemsDep.Text = "Département"
    '
    'TextBoxRechItemsDep
    '
    Me.TextBoxRechItemsDep.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.TextBoxRechItemsDep.Location = New System.Drawing.Point(9, 329)
    Me.TextBoxRechItemsDep.Name = "TextBoxRechItemsDep"
    Me.TextBoxRechItemsDep.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxRechItemsDep.TabIndex = 13
    '
    'LabelItemsCode
    '
    Me.LabelItemsCode.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemsCode.AutoSize = True
    Me.LabelItemsCode.Location = New System.Drawing.Point(6, 142)
    Me.LabelItemsCode.Name = "LabelItemsCode"
    Me.LabelItemsCode.Size = New System.Drawing.Size(82, 13)
    Me.LabelItemsCode.TabIndex = 12
    Me.LabelItemsCode.Text = "Code de produit"
    '
    'ButtonSupprimerItems
    '
    Me.ButtonSupprimerItems.BackColor = System.Drawing.Color.Crimson
    Me.ButtonSupprimerItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonSupprimerItems.Location = New System.Drawing.Point(6, 93)
    Me.ButtonSupprimerItems.Name = "ButtonSupprimerItems"
    Me.ButtonSupprimerItems.Size = New System.Drawing.Size(148, 23)
    Me.ButtonSupprimerItems.TabIndex = 7
    Me.ButtonSupprimerItems.Text = "Supprimer"
    Me.ButtonSupprimerItems.UseVisualStyleBackColor = False
    Me.ButtonSupprimerItems.Visible = False
    '
    'ButtonModifierItems
    '
    Me.ButtonModifierItems.BackColor = System.Drawing.Color.DarkOrange
    Me.ButtonModifierItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonModifierItems.Location = New System.Drawing.Point(6, 64)
    Me.ButtonModifierItems.Name = "ButtonModifierItems"
    Me.ButtonModifierItems.Size = New System.Drawing.Size(148, 23)
    Me.ButtonModifierItems.TabIndex = 6
    Me.ButtonModifierItems.Text = "Modifier"
    Me.ButtonModifierItems.UseVisualStyleBackColor = False
    Me.ButtonModifierItems.Visible = False
    '
    'LabelItemRecherche
    '
    Me.LabelItemRecherche.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.LabelItemRecherche.AutoSize = True
    Me.LabelItemRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelItemRecherche.Location = New System.Drawing.Point(50, 122)
    Me.LabelItemRecherche.Name = "LabelItemRecherche"
    Me.LabelItemRecherche.Size = New System.Drawing.Size(60, 13)
    Me.LabelItemRecherche.TabIndex = 5
    Me.LabelItemRecherche.Text = "Recherche"
    '
    'ButtonItemFacture
    '
    Me.ButtonItemFacture.BackColor = System.Drawing.Color.SteelBlue
    Me.ButtonItemFacture.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonItemFacture.Location = New System.Drawing.Point(6, 6)
    Me.ButtonItemFacture.Name = "ButtonItemFacture"
    Me.ButtonItemFacture.Size = New System.Drawing.Size(148, 23)
    Me.ButtonItemFacture.TabIndex = 4
    Me.ButtonItemFacture.Text = "Nouvelle facture"
    Me.ButtonItemFacture.UseVisualStyleBackColor = False
    '
    'ButtonAjoutItems
    '
    Me.ButtonAjoutItems.BackColor = System.Drawing.Color.SeaGreen
    Me.ButtonAjoutItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonAjoutItems.Location = New System.Drawing.Point(6, 35)
    Me.ButtonAjoutItems.Name = "ButtonAjoutItems"
    Me.ButtonAjoutItems.Size = New System.Drawing.Size(148, 23)
    Me.ButtonAjoutItems.TabIndex = 3
    Me.ButtonAjoutItems.Text = "Ajouter"
    Me.ButtonAjoutItems.UseVisualStyleBackColor = False
    Me.ButtonAjoutItems.Visible = False
    '
    'TextBoxRechItemsCode
    '
    Me.TextBoxRechItemsCode.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.TextBoxRechItemsCode.Location = New System.Drawing.Point(9, 158)
    Me.TextBoxRechItemsCode.Name = "TextBoxRechItemsCode"
    Me.TextBoxRechItemsCode.Size = New System.Drawing.Size(145, 20)
    Me.TextBoxRechItemsCode.TabIndex = 2
    Me.TextBoxRechItemsCode.Tag = ""
    '
    'LabelRechItems
    '
    Me.LabelRechItems.AutoSize = True
    Me.LabelRechItems.Location = New System.Drawing.Point(6, 9)
    Me.LabelRechItems.Name = "LabelRechItems"
    Me.LabelRechItems.Size = New System.Drawing.Size(0, 13)
    Me.LabelRechItems.TabIndex = 1
    '
    'DataGridViewItems
    '
    Me.DataGridViewItems.AllowUserToAddRows = False
    Me.DataGridViewItems.AllowUserToDeleteRows = False
    Me.DataGridViewItems.AllowUserToResizeRows = False
    Me.DataGridViewItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
    Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewItems.DefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridViewItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.DataGridViewItems.Location = New System.Drawing.Point(160, 9)
    Me.DataGridViewItems.Name = "DataGridViewItems"
    Me.DataGridViewItems.ReadOnly = True
    Me.DataGridViewItems.RowHeadersVisible = False
    Me.DataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewItems.Size = New System.Drawing.Size(843, 475)
    Me.DataGridViewItems.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.BackColor = System.Drawing.Color.Khaki
    Me.TabPage1.Controls.Add(Me.ButtonSupprimerFacture)
    Me.TabPage1.Controls.Add(Me.ButtonModifierFacture)
    Me.TabPage1.Controls.Add(Me.ButtonAjoutFacture)
    Me.TabPage1.Controls.Add(Me.ButtonFactureFacture)
    Me.TabPage1.Controls.Add(Me.LabelFacturesNb)
    Me.TabPage1.Controls.Add(Me.DataGridViewFactures)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(1009, 508)
    Me.TabPage1.TabIndex = 1
    Me.TabPage1.Text = "Factures"
    '
    'LabelFacturesNb
    '
    Me.LabelFacturesNb.AutoSize = True
    Me.LabelFacturesNb.Location = New System.Drawing.Point(160, 489)
    Me.LabelFacturesNb.Name = "LabelFacturesNb"
    Me.LabelFacturesNb.Size = New System.Drawing.Size(213, 13)
    Me.LabelFacturesNb.TabIndex = 28
    Me.LabelFacturesNb.Text = "Nombre d'items d'inventaire sélectionnés : 0"
    '
    'DataGridViewFactures
    '
    Me.DataGridViewFactures.AllowUserToAddRows = False
    Me.DataGridViewFactures.AllowUserToDeleteRows = False
    Me.DataGridViewFactures.AllowUserToResizeRows = False
    Me.DataGridViewFactures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridViewFactures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
    Me.DataGridViewFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewFactures.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridViewFactures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.DataGridViewFactures.Location = New System.Drawing.Point(160, 9)
    Me.DataGridViewFactures.Name = "DataGridViewFactures"
    Me.DataGridViewFactures.ReadOnly = True
    Me.DataGridViewFactures.RowHeadersVisible = False
    Me.DataGridViewFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewFactures.Size = New System.Drawing.Size(843, 475)
    Me.DataGridViewFactures.TabIndex = 1
    '
    'TabPage2
    '
    Me.TabPage2.BackColor = System.Drawing.Color.Khaki
    Me.TabPage2.Controls.Add(Me.ButtonSupprimerUtilisateur)
    Me.TabPage2.Controls.Add(Me.ButtonModifierUtilisateur)
    Me.TabPage2.Controls.Add(Me.ButtonAjoutUtilisateur)
    Me.TabPage2.Controls.Add(Me.ButtonUtilisateurFacture)
    Me.TabPage2.Controls.Add(Me.LabelUtilisateursNb)
    Me.TabPage2.Controls.Add(Me.DataGridView2)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(1009, 508)
    Me.TabPage2.TabIndex = 2
    Me.TabPage2.Text = "Utilisateurs"
    '
    'LabelUtilisateursNb
    '
    Me.LabelUtilisateursNb.AutoSize = True
    Me.LabelUtilisateursNb.Location = New System.Drawing.Point(160, 489)
    Me.LabelUtilisateursNb.Name = "LabelUtilisateursNb"
    Me.LabelUtilisateursNb.Size = New System.Drawing.Size(213, 13)
    Me.LabelUtilisateursNb.TabIndex = 28
    Me.LabelUtilisateursNb.Text = "Nombre d'items d'inventaire sélectionnés : 0"
    '
    'DataGridView2
    '
    Me.DataGridView2.AllowUserToAddRows = False
    Me.DataGridView2.AllowUserToDeleteRows = False
    Me.DataGridView2.AllowUserToResizeRows = False
    Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
    Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.UtilisateurNom, Me.VoirInventaire, Me.AjoutInventaire, Me.ModifierInventaire, Me.SupprimerInventaire, Me.AdminInventaire, Me.VoirFacture, Me.AjoutFacture, Me.ModifierFacture, Me.SupprimerFacture, Me.VoirUtilisateur, Me.AjoutUtilisateur, Me.ModifierUtilisateur, Me.SupprimerUtilisateur})
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.DataGridView2.Location = New System.Drawing.Point(160, 9)
    Me.DataGridView2.Name = "DataGridView2"
    Me.DataGridView2.ReadOnly = True
    Me.DataGridView2.RowHeadersVisible = False
    Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridView2.Size = New System.Drawing.Size(843, 475)
    Me.DataGridView2.TabIndex = 1
    '
    'ID
    '
    Me.ID.HeaderText = "ID"
    Me.ID.Name = "ID"
    Me.ID.ReadOnly = True
    Me.ID.Visible = False
    Me.ID.Width = 24
    '
    'UtilisateurNom
    '
    Me.UtilisateurNom.HeaderText = "Utilisateur"
    Me.UtilisateurNom.Name = "UtilisateurNom"
    Me.UtilisateurNom.ReadOnly = True
    Me.UtilisateurNom.Width = 78
    '
    'VoirInventaire
    '
    Me.VoirInventaire.HeaderText = "Voir Inventaire"
    Me.VoirInventaire.Name = "VoirInventaire"
    Me.VoirInventaire.ReadOnly = True
    Me.VoirInventaire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.VoirInventaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.VoirInventaire.Width = 92
    '
    'AjoutInventaire
    '
    Me.AjoutInventaire.HeaderText = "Ajout Inventaire"
    Me.AjoutInventaire.Name = "AjoutInventaire"
    Me.AjoutInventaire.ReadOnly = True
    Me.AjoutInventaire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.AjoutInventaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.AjoutInventaire.Width = 97
    '
    'ModifierInventaire
    '
    Me.ModifierInventaire.HeaderText = "Modifier Inventaire"
    Me.ModifierInventaire.Name = "ModifierInventaire"
    Me.ModifierInventaire.ReadOnly = True
    Me.ModifierInventaire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.ModifierInventaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.ModifierInventaire.Width = 109
    '
    'SupprimerInventaire
    '
    Me.SupprimerInventaire.HeaderText = "Supprimer Inventaire"
    Me.SupprimerInventaire.Name = "SupprimerInventaire"
    Me.SupprimerInventaire.ReadOnly = True
    Me.SupprimerInventaire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.SupprimerInventaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.SupprimerInventaire.Width = 118
    '
    'AdminInventaire
    '
    Me.AdminInventaire.HeaderText = "Admin Inventaire"
    Me.AdminInventaire.Name = "AdminInventaire"
    Me.AdminInventaire.ReadOnly = True
    Me.AdminInventaire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.AdminInventaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.AdminInventaire.Width = 102
    '
    'VoirFacture
    '
    Me.VoirFacture.HeaderText = "Voir Facture"
    Me.VoirFacture.Name = "VoirFacture"
    Me.VoirFacture.ReadOnly = True
    Me.VoirFacture.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.VoirFacture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.VoirFacture.Width = 82
    '
    'AjoutFacture
    '
    Me.AjoutFacture.HeaderText = "Ajout Facture"
    Me.AjoutFacture.Name = "AjoutFacture"
    Me.AjoutFacture.ReadOnly = True
    Me.AjoutFacture.Width = 68
    '
    'ModifierFacture
    '
    Me.ModifierFacture.HeaderText = "Modifier Facture"
    Me.ModifierFacture.Name = "ModifierFacture"
    Me.ModifierFacture.ReadOnly = True
    Me.ModifierFacture.Width = 80
    '
    'SupprimerFacture
    '
    Me.SupprimerFacture.HeaderText = "Supprimer Facture"
    Me.SupprimerFacture.Name = "SupprimerFacture"
    Me.SupprimerFacture.ReadOnly = True
    Me.SupprimerFacture.Width = 89
    '
    'VoirUtilisateur
    '
    Me.VoirUtilisateur.HeaderText = "VoirUtilisateur"
    Me.VoirUtilisateur.Name = "VoirUtilisateur"
    Me.VoirUtilisateur.ReadOnly = True
    Me.VoirUtilisateur.Width = 77
    '
    'AjoutUtilisateur
    '
    Me.AjoutUtilisateur.HeaderText = "Ajout Utilisateur"
    Me.AjoutUtilisateur.Name = "AjoutUtilisateur"
    Me.AjoutUtilisateur.ReadOnly = True
    Me.AjoutUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.AjoutUtilisateur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.AjoutUtilisateur.Width = 96
    '
    'ModifierUtilisateur
    '
    Me.ModifierUtilisateur.HeaderText = "Modifier Utilisateur"
    Me.ModifierUtilisateur.Name = "ModifierUtilisateur"
    Me.ModifierUtilisateur.ReadOnly = True
    Me.ModifierUtilisateur.Width = 89
    '
    'SupprimerUtilisateur
    '
    Me.SupprimerUtilisateur.HeaderText = "Supprimer Utilisateur"
    Me.SupprimerUtilisateur.Name = "SupprimerUtilisateur"
    Me.SupprimerUtilisateur.ReadOnly = True
    Me.SupprimerUtilisateur.Width = 98
    '
    'fact_total
    '
    Me.fact_total.HeaderText = "Total"
    Me.fact_total.Name = "fact_total"
    '
    'fact_stotal
    '
    Me.fact_stotal.HeaderText = "Sous total"
    Me.fact_stotal.Name = "fact_stotal"
    '
    'nb_items_fact
    '
    Me.nb_items_fact.HeaderText = "Nombre d'items"
    Me.nb_items_fact.Name = "nb_items_fact"
    '
    'code_etu
    '
    Me.code_etu.HeaderText = "Code étudiant"
    Me.code_etu.Name = "code_etu"
    '
    'Date_fact
    '
    Me.Date_fact.HeaderText = "Date"
    Me.Date_fact.Name = "Date_fact"
    '
    'no_fact
    '
    Me.no_fact.HeaderText = "No"
    Me.no_fact.Name = "no_fact"
    '
    'ButtonConnexionAdmin
    '
    Me.ButtonConnexionAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonConnexionAdmin.BackColor = System.Drawing.Color.Coral
    Me.ButtonConnexionAdmin.ForeColor = System.Drawing.SystemColors.Control
    Me.ButtonConnexionAdmin.Location = New System.Drawing.Point(874, 552)
    Me.ButtonConnexionAdmin.Name = "ButtonConnexionAdmin"
    Me.ButtonConnexionAdmin.Size = New System.Drawing.Size(145, 23)
    Me.ButtonConnexionAdmin.TabIndex = 6
    Me.ButtonConnexionAdmin.Text = "Connexion (admin)"
    Me.ButtonConnexionAdmin.UseVisualStyleBackColor = False
    '
    'ButtonSauvegarder
    '
    Me.ButtonSauvegarder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.ButtonSauvegarder.BackColor = System.Drawing.Color.DarkSlateBlue
    Me.ButtonSauvegarder.ForeColor = System.Drawing.SystemColors.Control
    Me.ButtonSauvegarder.Location = New System.Drawing.Point(25, 552)
    Me.ButtonSauvegarder.Name = "ButtonSauvegarder"
    Me.ButtonSauvegarder.Size = New System.Drawing.Size(145, 23)
    Me.ButtonSauvegarder.TabIndex = 8
    Me.ButtonSauvegarder.Text = "Sauvegarder"
    Me.ButtonSauvegarder.UseVisualStyleBackColor = False
    '
    'ButtonFactureFacture
    '
    Me.ButtonFactureFacture.BackColor = System.Drawing.Color.SteelBlue
    Me.ButtonFactureFacture.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonFactureFacture.Location = New System.Drawing.Point(6, 6)
    Me.ButtonFactureFacture.Name = "ButtonFactureFacture"
    Me.ButtonFactureFacture.Size = New System.Drawing.Size(148, 23)
    Me.ButtonFactureFacture.TabIndex = 29
    Me.ButtonFactureFacture.Text = "Nouvelle facture"
    Me.ButtonFactureFacture.UseVisualStyleBackColor = False
    '
    'ButtonUtilisateurFacture
    '
    Me.ButtonUtilisateurFacture.BackColor = System.Drawing.Color.SteelBlue
    Me.ButtonUtilisateurFacture.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonUtilisateurFacture.Location = New System.Drawing.Point(6, 6)
    Me.ButtonUtilisateurFacture.Name = "ButtonUtilisateurFacture"
    Me.ButtonUtilisateurFacture.Size = New System.Drawing.Size(148, 23)
    Me.ButtonUtilisateurFacture.TabIndex = 29
    Me.ButtonUtilisateurFacture.Text = "Nouvelle facture"
    Me.ButtonUtilisateurFacture.UseVisualStyleBackColor = False
    '
    'ButtonAjoutFacture
    '
    Me.ButtonAjoutFacture.BackColor = System.Drawing.Color.SeaGreen
    Me.ButtonAjoutFacture.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonAjoutFacture.Location = New System.Drawing.Point(6, 35)
    Me.ButtonAjoutFacture.Name = "ButtonAjoutFacture"
    Me.ButtonAjoutFacture.Size = New System.Drawing.Size(148, 23)
    Me.ButtonAjoutFacture.TabIndex = 30
    Me.ButtonAjoutFacture.Text = "Ajouter"
    Me.ButtonAjoutFacture.UseVisualStyleBackColor = False
    Me.ButtonAjoutFacture.Visible = False
    '
    'ButtonAjoutUtilisateur
    '
    Me.ButtonAjoutUtilisateur.BackColor = System.Drawing.Color.SeaGreen
    Me.ButtonAjoutUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonAjoutUtilisateur.Location = New System.Drawing.Point(6, 35)
    Me.ButtonAjoutUtilisateur.Name = "ButtonAjoutUtilisateur"
    Me.ButtonAjoutUtilisateur.Size = New System.Drawing.Size(148, 23)
    Me.ButtonAjoutUtilisateur.TabIndex = 30
    Me.ButtonAjoutUtilisateur.Text = "Ajouter"
    Me.ButtonAjoutUtilisateur.UseVisualStyleBackColor = False
    Me.ButtonAjoutUtilisateur.Visible = False
    '
    'ButtonModifierFacture
    '
    Me.ButtonModifierFacture.BackColor = System.Drawing.Color.DarkOrange
    Me.ButtonModifierFacture.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonModifierFacture.Location = New System.Drawing.Point(6, 64)
    Me.ButtonModifierFacture.Name = "ButtonModifierFacture"
    Me.ButtonModifierFacture.Size = New System.Drawing.Size(148, 23)
    Me.ButtonModifierFacture.TabIndex = 31
    Me.ButtonModifierFacture.Text = "Modifier"
    Me.ButtonModifierFacture.UseVisualStyleBackColor = False
    Me.ButtonModifierFacture.Visible = False
    '
    'ButtonModifierUtilisateur
    '
    Me.ButtonModifierUtilisateur.BackColor = System.Drawing.Color.DarkOrange
    Me.ButtonModifierUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonModifierUtilisateur.Location = New System.Drawing.Point(6, 64)
    Me.ButtonModifierUtilisateur.Name = "ButtonModifierUtilisateur"
    Me.ButtonModifierUtilisateur.Size = New System.Drawing.Size(148, 23)
    Me.ButtonModifierUtilisateur.TabIndex = 31
    Me.ButtonModifierUtilisateur.Text = "Modifier"
    Me.ButtonModifierUtilisateur.UseVisualStyleBackColor = False
    Me.ButtonModifierUtilisateur.Visible = False
    '
    'ButtonSupprimerFacture
    '
    Me.ButtonSupprimerFacture.BackColor = System.Drawing.Color.Crimson
    Me.ButtonSupprimerFacture.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonSupprimerFacture.Location = New System.Drawing.Point(6, 93)
    Me.ButtonSupprimerFacture.Name = "ButtonSupprimerFacture"
    Me.ButtonSupprimerFacture.Size = New System.Drawing.Size(148, 23)
    Me.ButtonSupprimerFacture.TabIndex = 32
    Me.ButtonSupprimerFacture.Text = "Supprimer"
    Me.ButtonSupprimerFacture.UseVisualStyleBackColor = False
    Me.ButtonSupprimerFacture.Visible = False
    '
    'ButtonSupprimerUtilisateur
    '
    Me.ButtonSupprimerUtilisateur.BackColor = System.Drawing.Color.Crimson
    Me.ButtonSupprimerUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.ButtonSupprimerUtilisateur.Location = New System.Drawing.Point(6, 93)
    Me.ButtonSupprimerUtilisateur.Name = "ButtonSupprimerUtilisateur"
    Me.ButtonSupprimerUtilisateur.Size = New System.Drawing.Size(148, 23)
    Me.ButtonSupprimerUtilisateur.TabIndex = 32
    Me.ButtonSupprimerUtilisateur.Text = "Supprimer"
    Me.ButtonSupprimerUtilisateur.UseVisualStyleBackColor = False
    Me.ButtonSupprimerUtilisateur.Visible = False
    '
    'FormInventaire
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Pink
    Me.ClientSize = New System.Drawing.Size(1041, 587)
    Me.Controls.Add(Me.ButtonSauvegarder)
    Me.Controls.Add(Me.ButtonConnexionAdmin)
    Me.Controls.Add(Me.PageInventaire)
    Me.MinimumSize = New System.Drawing.Size(365, 441)
    Me.Name = "FormInventaire"
    Me.Text = "Inventaire COOP"
    Me.PageInventaire.ResumeLayout(False)
    Me.TabPageItems.ResumeLayout(False)
    Me.TabPageItems.PerformLayout()
    CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    CType(Me.DataGridViewFactures, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodeproduitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FournidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DepidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CatidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodefournDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrixachatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrixventeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FournnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CatnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EmplacementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PageInventaire As System.Windows.Forms.TabControl
  Friend WithEvents TabPageItems As System.Windows.Forms.TabPage
  Friend WithEvents TextBoxRechItemsCode As System.Windows.Forms.TextBox
  Friend WithEvents LabelRechItems As System.Windows.Forms.Label
  Friend WithEvents DataGridViewItems As System.Windows.Forms.DataGridView
  Friend WithEvents LabelItemRecherche As System.Windows.Forms.Label
  Friend WithEvents ButtonItemFacture As System.Windows.Forms.Button
  Friend WithEvents fact_total As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents fact_stotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents nb_items_fact As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents code_etu As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Date_fact As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents no_fact As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ButtonAjoutItems As System.Windows.Forms.Button
  Friend WithEvents ButtonConnexionAdmin As System.Windows.Forms.Button
  Friend WithEvents ButtonSauvegarder As System.Windows.Forms.Button
  Friend WithEvents ButtonSupprimerItems As System.Windows.Forms.Button
  Friend WithEvents ButtonModifierItems As System.Windows.Forms.Button
  Friend WithEvents LabelItemsDesc As System.Windows.Forms.Label
  Friend WithEvents TextBoxRechItemsDesc As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemsEmp As System.Windows.Forms.Label
  Friend WithEvents TextBoxRechItemsEmp As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemsCat As System.Windows.Forms.Label
  Friend WithEvents TextBoxRechItemsCat As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemsDep As System.Windows.Forms.Label
  Friend WithEvents TextBoxRechItemsDep As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemsCode As System.Windows.Forms.Label
  Friend WithEvents LabelItemsFourn As System.Windows.Forms.Label
  Friend WithEvents TextBoxRechItemsFourn As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxItemsTotal As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemsTotal As System.Windows.Forms.Label
  Friend WithEvents CheckBoxItemsNb As System.Windows.Forms.CheckBox
  Friend WithEvents LabelItemsNb As System.Windows.Forms.Label
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewFactures As System.Windows.Forms.DataGridView
  Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
  Friend WithEvents LabelFacturesNb As System.Windows.Forms.Label
  Friend WithEvents LabelUtilisateursNb As System.Windows.Forms.Label
  Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents UtilisateurNom As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VoirInventaire As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents AjoutInventaire As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents ModifierInventaire As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents SupprimerInventaire As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents AdminInventaire As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents VoirFacture As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents AjoutFacture As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents ModifierFacture As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents SupprimerFacture As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents VoirUtilisateur As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents AjoutUtilisateur As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents ModifierUtilisateur As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents SupprimerUtilisateur As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents ButtonSupprimerFacture As System.Windows.Forms.Button
  Friend WithEvents ButtonModifierFacture As System.Windows.Forms.Button
  Friend WithEvents ButtonAjoutFacture As System.Windows.Forms.Button
  Friend WithEvents ButtonFactureFacture As System.Windows.Forms.Button
  Friend WithEvents ButtonSupprimerUtilisateur As System.Windows.Forms.Button
  Friend WithEvents ButtonModifierUtilisateur As System.Windows.Forms.Button
  Friend WithEvents ButtonAjoutUtilisateur As System.Windows.Forms.Button
  Friend WithEvents ButtonUtilisateurFacture As System.Windows.Forms.Button

End Class
