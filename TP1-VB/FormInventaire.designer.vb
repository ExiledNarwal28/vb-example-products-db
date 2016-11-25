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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TabControlInventaire = New System.Windows.Forms.TabControl()
    Me.TabPageItems = New System.Windows.Forms.TabPage()
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
    Me.fact_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.fact_stotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.nb_items_fact = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.code_etu = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Date_fact = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.no_fact = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ButtonConnexionAdmin = New System.Windows.Forms.Button()
    Me.ButtonSauvegarder = New System.Windows.Forms.Button()
    Me.LabelItemsNb = New System.Windows.Forms.Label()
    Me.TabControlInventaire.SuspendLayout()
    Me.TabPageItems.SuspendLayout()
    CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TabControlInventaire
    '
    Me.TabControlInventaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControlInventaire.Controls.Add(Me.TabPageItems)
    Me.TabControlInventaire.Location = New System.Drawing.Point(12, 12)
    Me.TabControlInventaire.Name = "TabControlInventaire"
    Me.TabControlInventaire.SelectedIndex = 0
    Me.TabControlInventaire.Size = New System.Drawing.Size(1017, 534)
    Me.TabControlInventaire.TabIndex = 0
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
    Me.TabPageItems.Text = "Items"
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
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewItems.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridViewItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.DataGridViewItems.Location = New System.Drawing.Point(160, 9)
    Me.DataGridViewItems.Name = "DataGridViewItems"
    Me.DataGridViewItems.ReadOnly = True
    Me.DataGridViewItems.RowHeadersVisible = False
    Me.DataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewItems.Size = New System.Drawing.Size(843, 475)
    Me.DataGridViewItems.TabIndex = 0
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
    'LabelItemsNb
    '
    Me.LabelItemsNb.AutoSize = True
    Me.LabelItemsNb.Location = New System.Drawing.Point(160, 489)
    Me.LabelItemsNb.Name = "LabelItemsNb"
    Me.LabelItemsNb.Size = New System.Drawing.Size(150, 13)
    Me.LabelItemsNb.TabIndex = 27
    Me.LabelItemsNb.Text = "Nombre d'items sélectionnés : "
    '
    'FormInventaire
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Pink
    Me.ClientSize = New System.Drawing.Size(1041, 587)
    Me.Controls.Add(Me.ButtonSauvegarder)
    Me.Controls.Add(Me.ButtonConnexionAdmin)
    Me.Controls.Add(Me.TabControlInventaire)
    Me.MinimumSize = New System.Drawing.Size(365, 441)
    Me.Name = "FormInventaire"
    Me.Text = "Inventaire COOP"
    Me.TabControlInventaire.ResumeLayout(False)
    Me.TabPageItems.ResumeLayout(False)
    Me.TabPageItems.PerformLayout()
    CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents TabControlInventaire As System.Windows.Forms.TabControl
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

End Class
