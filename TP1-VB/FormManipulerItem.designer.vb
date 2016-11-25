<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManipulerItem
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
    Me.LabelItemAjoutCodeProduit = New System.Windows.Forms.Label()
    Me.TextBoxItemAjoutCodeProduit = New System.Windows.Forms.TextBox()
    Me.TextBoxItemAjoutDesc = New System.Windows.Forms.TextBox()
    Me.LabelItemAjoutDesc = New System.Windows.Forms.Label()
    Me.TextBoxItemAjoutEmp = New System.Windows.Forms.TextBox()
    Me.LabelItemAjoutEmp = New System.Windows.Forms.Label()
    Me.LabelItemAjoutFournNom = New System.Windows.Forms.Label()
    Me.ComboBoxItemAjoutFournNom = New System.Windows.Forms.ComboBox()
    Me.ComboBoxItemAjoutCatNom = New System.Windows.Forms.ComboBox()
    Me.LabelItemAjoutCatNom = New System.Windows.Forms.Label()
    Me.ComboBoxItemAjoutDepNom = New System.Windows.Forms.ComboBox()
    Me.LabelItemAjoutDepNom = New System.Windows.Forms.Label()
    Me.TextBoxItemAjoutPrixA = New System.Windows.Forms.TextBox()
    Me.LabelItemAjoutPrixA = New System.Windows.Forms.Label()
    Me.TextBoxItemAjoutPrixV = New System.Windows.Forms.TextBox()
    Me.LabelItemAjoutPrixV = New System.Windows.Forms.Label()
    Me.TextBoxItemAjoutQt = New System.Windows.Forms.TextBox()
    Me.LabelItemAjoutQt = New System.Windows.Forms.Label()
    Me.ButtonItemsAjoutAction = New System.Windows.Forms.Button()
    Me.ButtonItemsAjoutAnnuler = New System.Windows.Forms.Button()
    Me.TextBoxItemAjoutFournCode = New System.Windows.Forms.TextBox()
    Me.LabelItemAjoutFournCode = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'LabelItemAjoutCodeProduit
    '
    Me.LabelItemAjoutCodeProduit.AutoSize = True
    Me.LabelItemAjoutCodeProduit.Location = New System.Drawing.Point(12, 9)
    Me.LabelItemAjoutCodeProduit.Name = "LabelItemAjoutCodeProduit"
    Me.LabelItemAjoutCodeProduit.Size = New System.Drawing.Size(91, 13)
    Me.LabelItemAjoutCodeProduit.TabIndex = 0
    Me.LabelItemAjoutCodeProduit.Text = "Code du produit : "
    '
    'TextBoxItemAjoutCodeProduit
    '
    Me.TextBoxItemAjoutCodeProduit.Location = New System.Drawing.Point(109, 6)
    Me.TextBoxItemAjoutCodeProduit.Name = "TextBoxItemAjoutCodeProduit"
    Me.TextBoxItemAjoutCodeProduit.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutCodeProduit.TabIndex = 1
    '
    'TextBoxItemAjoutDesc
    '
    Me.TextBoxItemAjoutDesc.Location = New System.Drawing.Point(109, 32)
    Me.TextBoxItemAjoutDesc.Name = "TextBoxItemAjoutDesc"
    Me.TextBoxItemAjoutDesc.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutDesc.TabIndex = 3
    '
    'LabelItemAjoutDesc
    '
    Me.LabelItemAjoutDesc.AutoSize = True
    Me.LabelItemAjoutDesc.Location = New System.Drawing.Point(12, 35)
    Me.LabelItemAjoutDesc.Name = "LabelItemAjoutDesc"
    Me.LabelItemAjoutDesc.Size = New System.Drawing.Size(69, 13)
    Me.LabelItemAjoutDesc.TabIndex = 2
    Me.LabelItemAjoutDesc.Text = "Description : "
    '
    'TextBoxItemAjoutEmp
    '
    Me.TextBoxItemAjoutEmp.Location = New System.Drawing.Point(109, 58)
    Me.TextBoxItemAjoutEmp.Name = "TextBoxItemAjoutEmp"
    Me.TextBoxItemAjoutEmp.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutEmp.TabIndex = 5
    '
    'LabelItemAjoutEmp
    '
    Me.LabelItemAjoutEmp.AutoSize = True
    Me.LabelItemAjoutEmp.Location = New System.Drawing.Point(12, 61)
    Me.LabelItemAjoutEmp.Name = "LabelItemAjoutEmp"
    Me.LabelItemAjoutEmp.Size = New System.Drawing.Size(80, 13)
    Me.LabelItemAjoutEmp.TabIndex = 4
    Me.LabelItemAjoutEmp.Text = "Emplacement : "
    '
    'LabelItemAjoutFournNom
    '
    Me.LabelItemAjoutFournNom.AutoSize = True
    Me.LabelItemAjoutFournNom.Location = New System.Drawing.Point(12, 87)
    Me.LabelItemAjoutFournNom.Name = "LabelItemAjoutFournNom"
    Me.LabelItemAjoutFournNom.Size = New System.Drawing.Size(70, 13)
    Me.LabelItemAjoutFournNom.TabIndex = 6
    Me.LabelItemAjoutFournNom.Text = "Fournisseur : "
    '
    'ComboBoxItemAjoutFournNom
    '
    Me.ComboBoxItemAjoutFournNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxItemAjoutFournNom.FormattingEnabled = True
    Me.ComboBoxItemAjoutFournNom.Location = New System.Drawing.Point(109, 85)
    Me.ComboBoxItemAjoutFournNom.Name = "ComboBoxItemAjoutFournNom"
    Me.ComboBoxItemAjoutFournNom.Size = New System.Drawing.Size(274, 21)
    Me.ComboBoxItemAjoutFournNom.TabIndex = 7
    '
    'ComboBoxItemAjoutCatNom
    '
    Me.ComboBoxItemAjoutCatNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxItemAjoutCatNom.FormattingEnabled = True
    Me.ComboBoxItemAjoutCatNom.Location = New System.Drawing.Point(109, 165)
    Me.ComboBoxItemAjoutCatNom.Name = "ComboBoxItemAjoutCatNom"
    Me.ComboBoxItemAjoutCatNom.Size = New System.Drawing.Size(274, 21)
    Me.ComboBoxItemAjoutCatNom.TabIndex = 9
    '
    'LabelItemAjoutCatNom
    '
    Me.LabelItemAjoutCatNom.AutoSize = True
    Me.LabelItemAjoutCatNom.Location = New System.Drawing.Point(12, 168)
    Me.LabelItemAjoutCatNom.Name = "LabelItemAjoutCatNom"
    Me.LabelItemAjoutCatNom.Size = New System.Drawing.Size(61, 13)
    Me.LabelItemAjoutCatNom.TabIndex = 8
    Me.LabelItemAjoutCatNom.Text = "Catégorie : "
    '
    'ComboBoxItemAjoutDepNom
    '
    Me.ComboBoxItemAjoutDepNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxItemAjoutDepNom.FormattingEnabled = True
    Me.ComboBoxItemAjoutDepNom.Location = New System.Drawing.Point(109, 138)
    Me.ComboBoxItemAjoutDepNom.Name = "ComboBoxItemAjoutDepNom"
    Me.ComboBoxItemAjoutDepNom.Size = New System.Drawing.Size(274, 21)
    Me.ComboBoxItemAjoutDepNom.TabIndex = 11
    '
    'LabelItemAjoutDepNom
    '
    Me.LabelItemAjoutDepNom.AutoSize = True
    Me.LabelItemAjoutDepNom.Location = New System.Drawing.Point(12, 140)
    Me.LabelItemAjoutDepNom.Name = "LabelItemAjoutDepNom"
    Me.LabelItemAjoutDepNom.Size = New System.Drawing.Size(77, 13)
    Me.LabelItemAjoutDepNom.TabIndex = 10
    Me.LabelItemAjoutDepNom.Text = "Département : "
    '
    'TextBoxItemAjoutPrixA
    '
    Me.TextBoxItemAjoutPrixA.Location = New System.Drawing.Point(109, 192)
    Me.TextBoxItemAjoutPrixA.Name = "TextBoxItemAjoutPrixA"
    Me.TextBoxItemAjoutPrixA.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutPrixA.TabIndex = 13
    '
    'LabelItemAjoutPrixA
    '
    Me.LabelItemAjoutPrixA.AutoSize = True
    Me.LabelItemAjoutPrixA.Location = New System.Drawing.Point(12, 195)
    Me.LabelItemAjoutPrixA.Name = "LabelItemAjoutPrixA"
    Me.LabelItemAjoutPrixA.Size = New System.Drawing.Size(71, 13)
    Me.LabelItemAjoutPrixA.TabIndex = 12
    Me.LabelItemAjoutPrixA.Text = "Prix d'achat : "
    '
    'TextBoxItemAjoutPrixV
    '
    Me.TextBoxItemAjoutPrixV.Location = New System.Drawing.Point(109, 218)
    Me.TextBoxItemAjoutPrixV.Name = "TextBoxItemAjoutPrixV"
    Me.TextBoxItemAjoutPrixV.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutPrixV.TabIndex = 15
    '
    'LabelItemAjoutPrixV
    '
    Me.LabelItemAjoutPrixV.AutoSize = True
    Me.LabelItemAjoutPrixV.Location = New System.Drawing.Point(12, 221)
    Me.LabelItemAjoutPrixV.Name = "LabelItemAjoutPrixV"
    Me.LabelItemAjoutPrixV.Size = New System.Drawing.Size(78, 13)
    Me.LabelItemAjoutPrixV.TabIndex = 14
    Me.LabelItemAjoutPrixV.Text = "Prix de vente : "
    '
    'TextBoxItemAjoutQt
    '
    Me.TextBoxItemAjoutQt.Location = New System.Drawing.Point(109, 244)
    Me.TextBoxItemAjoutQt.Name = "TextBoxItemAjoutQt"
    Me.TextBoxItemAjoutQt.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutQt.TabIndex = 17
    '
    'LabelItemAjoutQt
    '
    Me.LabelItemAjoutQt.AutoSize = True
    Me.LabelItemAjoutQt.Location = New System.Drawing.Point(12, 247)
    Me.LabelItemAjoutQt.Name = "LabelItemAjoutQt"
    Me.LabelItemAjoutQt.Size = New System.Drawing.Size(56, 13)
    Me.LabelItemAjoutQt.TabIndex = 16
    Me.LabelItemAjoutQt.Text = "Quantité : "
    '
    'ButtonItemsAjoutAction
    '
    Me.ButtonItemsAjoutAction.BackColor = System.Drawing.Color.SeaGreen
    Me.ButtonItemsAjoutAction.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonItemsAjoutAction.Location = New System.Drawing.Point(202, 270)
    Me.ButtonItemsAjoutAction.Name = "ButtonItemsAjoutAction"
    Me.ButtonItemsAjoutAction.Size = New System.Drawing.Size(181, 23)
    Me.ButtonItemsAjoutAction.TabIndex = 18
    Me.ButtonItemsAjoutAction.Text = "Ajouter"
    Me.ButtonItemsAjoutAction.UseVisualStyleBackColor = False
    '
    'ButtonItemsAjoutAnnuler
    '
    Me.ButtonItemsAjoutAnnuler.BackColor = System.Drawing.Color.Crimson
    Me.ButtonItemsAjoutAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonItemsAjoutAnnuler.Location = New System.Drawing.Point(15, 270)
    Me.ButtonItemsAjoutAnnuler.Name = "ButtonItemsAjoutAnnuler"
    Me.ButtonItemsAjoutAnnuler.Size = New System.Drawing.Size(181, 23)
    Me.ButtonItemsAjoutAnnuler.TabIndex = 19
    Me.ButtonItemsAjoutAnnuler.Text = "Annuler"
    Me.ButtonItemsAjoutAnnuler.UseVisualStyleBackColor = False
    '
    'TextBoxItemAjoutFournCode
    '
    Me.TextBoxItemAjoutFournCode.Location = New System.Drawing.Point(109, 112)
    Me.TextBoxItemAjoutFournCode.Name = "TextBoxItemAjoutFournCode"
    Me.TextBoxItemAjoutFournCode.Size = New System.Drawing.Size(274, 20)
    Me.TextBoxItemAjoutFournCode.TabIndex = 21
    '
    'LabelItemAjoutFournCode
    '
    Me.LabelItemAjoutFournCode.AutoSize = True
    Me.LabelItemAjoutFournCode.Location = New System.Drawing.Point(12, 115)
    Me.LabelItemAjoutFournCode.Name = "LabelItemAjoutFournCode"
    Me.LabelItemAjoutFournCode.Size = New System.Drawing.Size(74, 13)
    Me.LabelItemAjoutFournCode.TabIndex = 20
    Me.LabelItemAjoutFournCode.Text = "Code Fourn. : "
    '
    'FormAjoutItem
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
    Me.BackColor = System.Drawing.Color.PaleTurquoise
    Me.ClientSize = New System.Drawing.Size(395, 298)
    Me.Controls.Add(Me.TextBoxItemAjoutFournCode)
    Me.Controls.Add(Me.LabelItemAjoutFournCode)
    Me.Controls.Add(Me.ButtonItemsAjoutAnnuler)
    Me.Controls.Add(Me.ButtonItemsAjoutAction)
    Me.Controls.Add(Me.TextBoxItemAjoutQt)
    Me.Controls.Add(Me.LabelItemAjoutQt)
    Me.Controls.Add(Me.TextBoxItemAjoutPrixV)
    Me.Controls.Add(Me.LabelItemAjoutPrixV)
    Me.Controls.Add(Me.TextBoxItemAjoutPrixA)
    Me.Controls.Add(Me.LabelItemAjoutPrixA)
    Me.Controls.Add(Me.ComboBoxItemAjoutDepNom)
    Me.Controls.Add(Me.LabelItemAjoutDepNom)
    Me.Controls.Add(Me.ComboBoxItemAjoutCatNom)
    Me.Controls.Add(Me.LabelItemAjoutCatNom)
    Me.Controls.Add(Me.ComboBoxItemAjoutFournNom)
    Me.Controls.Add(Me.LabelItemAjoutFournNom)
    Me.Controls.Add(Me.TextBoxItemAjoutEmp)
    Me.Controls.Add(Me.LabelItemAjoutEmp)
    Me.Controls.Add(Me.TextBoxItemAjoutDesc)
    Me.Controls.Add(Me.LabelItemAjoutDesc)
    Me.Controls.Add(Me.TextBoxItemAjoutCodeProduit)
    Me.Controls.Add(Me.LabelItemAjoutCodeProduit)
    Me.Name = "FormAjoutItem"
    Me.Text = "Ajout d'un item"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelItemAjoutCodeProduit As System.Windows.Forms.Label
  Friend WithEvents TextBoxItemAjoutCodeProduit As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxItemAjoutDesc As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemAjoutDesc As System.Windows.Forms.Label
  Friend WithEvents TextBoxItemAjoutEmp As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemAjoutEmp As System.Windows.Forms.Label
  Friend WithEvents LabelItemAjoutFournNom As System.Windows.Forms.Label
  Friend WithEvents ComboBoxItemAjoutFournNom As System.Windows.Forms.ComboBox
  Friend WithEvents ComboBoxItemAjoutCatNom As System.Windows.Forms.ComboBox
  Friend WithEvents LabelItemAjoutCatNom As System.Windows.Forms.Label
  Friend WithEvents ComboBoxItemAjoutDepNom As System.Windows.Forms.ComboBox
  Friend WithEvents LabelItemAjoutDepNom As System.Windows.Forms.Label
  Friend WithEvents TextBoxItemAjoutPrixA As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemAjoutPrixA As System.Windows.Forms.Label
  Friend WithEvents TextBoxItemAjoutPrixV As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemAjoutPrixV As System.Windows.Forms.Label
  Friend WithEvents TextBoxItemAjoutQt As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemAjoutQt As System.Windows.Forms.Label
  Friend WithEvents ButtonItemsAjoutAction As System.Windows.Forms.Button
  Friend WithEvents ButtonItemsAjoutAnnuler As System.Windows.Forms.Button
  Friend WithEvents TextBoxItemAjoutFournCode As System.Windows.Forms.TextBox
  Friend WithEvents LabelItemAjoutFournCode As System.Windows.Forms.Label
End Class
