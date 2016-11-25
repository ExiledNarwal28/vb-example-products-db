<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNouvelleFacture
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.DataGridViewFacture = New System.Windows.Forms.DataGridView()
    Me.LabelFactureCodeEtu = New System.Windows.Forms.Label()
    Me.TextBoxFactureCodeEtu = New System.Windows.Forms.TextBox()
    Me.TextBoxFactureSousTotal = New System.Windows.Forms.TextBox()
    Me.LabelFactureSousTotal = New System.Windows.Forms.Label()
    Me.TextBoxFactureTPS = New System.Windows.Forms.TextBox()
    Me.LabelFactureTPS = New System.Windows.Forms.Label()
    Me.TextBoxFactureTVQ = New System.Windows.Forms.TextBox()
    Me.LabelFactureTVQ = New System.Windows.Forms.Label()
    Me.TextBoxFactureTotal = New System.Windows.Forms.TextBox()
    Me.LabelFactureTotal = New System.Windows.Forms.Label()
    Me.BoutonFactureAnnuler = New System.Windows.Forms.Button()
    Me.BoutonFactureOK = New System.Windows.Forms.Button()
    Me.LabelFactureInstructions = New System.Windows.Forms.Label()
    Me.RichTextBoxComm = New System.Windows.Forms.RichTextBox()
    Me.LabelFactureComm = New System.Windows.Forms.Label()
    CType(Me.DataGridViewFacture, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataGridViewFacture
    '
    Me.DataGridViewFacture.AllowUserToAddRows = False
    Me.DataGridViewFacture.AllowUserToDeleteRows = False
    Me.DataGridViewFacture.AllowUserToResizeRows = False
    Me.DataGridViewFacture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridViewFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewFacture.Location = New System.Drawing.Point(12, 12)
    Me.DataGridViewFacture.Name = "DataGridViewFacture"
    Me.DataGridViewFacture.RowHeadersVisible = False
    Me.DataGridViewFacture.Size = New System.Drawing.Size(727, 175)
    Me.DataGridViewFacture.TabIndex = 0
    '
    'LabelFactureCodeEtu
    '
    Me.LabelFactureCodeEtu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureCodeEtu.AutoSize = True
    Me.LabelFactureCodeEtu.Location = New System.Drawing.Point(9, 197)
    Me.LabelFactureCodeEtu.Name = "LabelFactureCodeEtu"
    Me.LabelFactureCodeEtu.Size = New System.Drawing.Size(90, 13)
    Me.LabelFactureCodeEtu.TabIndex = 1
    Me.LabelFactureCodeEtu.Text = "Code d'étudiant : "
    '
    'TextBoxFactureCodeEtu
    '
    Me.TextBoxFactureCodeEtu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.TextBoxFactureCodeEtu.Location = New System.Drawing.Point(105, 194)
    Me.TextBoxFactureCodeEtu.Name = "TextBoxFactureCodeEtu"
    Me.TextBoxFactureCodeEtu.Size = New System.Drawing.Size(276, 20)
    Me.TextBoxFactureCodeEtu.TabIndex = 2
    '
    'TextBoxFactureSousTotal
    '
    Me.TextBoxFactureSousTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxFactureSousTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.TextBoxFactureSousTotal.Location = New System.Drawing.Point(452, 194)
    Me.TextBoxFactureSousTotal.Name = "TextBoxFactureSousTotal"
    Me.TextBoxFactureSousTotal.ReadOnly = True
    Me.TextBoxFactureSousTotal.Size = New System.Drawing.Size(287, 20)
    Me.TextBoxFactureSousTotal.TabIndex = 4
    '
    'LabelFactureSousTotal
    '
    Me.LabelFactureSousTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureSousTotal.AutoSize = True
    Me.LabelFactureSousTotal.Location = New System.Drawing.Point(383, 197)
    Me.LabelFactureSousTotal.Name = "LabelFactureSousTotal"
    Me.LabelFactureSousTotal.Size = New System.Drawing.Size(63, 13)
    Me.LabelFactureSousTotal.TabIndex = 3
    Me.LabelFactureSousTotal.Text = "Sous-total : "
    '
    'TextBoxFactureTPS
    '
    Me.TextBoxFactureTPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxFactureTPS.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.TextBoxFactureTPS.Location = New System.Drawing.Point(452, 220)
    Me.TextBoxFactureTPS.Name = "TextBoxFactureTPS"
    Me.TextBoxFactureTPS.ReadOnly = True
    Me.TextBoxFactureTPS.Size = New System.Drawing.Size(287, 20)
    Me.TextBoxFactureTPS.TabIndex = 6
    '
    'LabelFactureTPS
    '
    Me.LabelFactureTPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureTPS.AutoSize = True
    Me.LabelFactureTPS.Location = New System.Drawing.Point(383, 223)
    Me.LabelFactureTPS.Name = "LabelFactureTPS"
    Me.LabelFactureTPS.Size = New System.Drawing.Size(37, 13)
    Me.LabelFactureTPS.TabIndex = 5
    Me.LabelFactureTPS.Text = "TPS : "
    '
    'TextBoxFactureTVQ
    '
    Me.TextBoxFactureTVQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxFactureTVQ.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.TextBoxFactureTVQ.Location = New System.Drawing.Point(452, 246)
    Me.TextBoxFactureTVQ.Name = "TextBoxFactureTVQ"
    Me.TextBoxFactureTVQ.ReadOnly = True
    Me.TextBoxFactureTVQ.Size = New System.Drawing.Size(287, 20)
    Me.TextBoxFactureTVQ.TabIndex = 8
    '
    'LabelFactureTVQ
    '
    Me.LabelFactureTVQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureTVQ.AutoSize = True
    Me.LabelFactureTVQ.Location = New System.Drawing.Point(383, 249)
    Me.LabelFactureTVQ.Name = "LabelFactureTVQ"
    Me.LabelFactureTVQ.Size = New System.Drawing.Size(38, 13)
    Me.LabelFactureTVQ.TabIndex = 7
    Me.LabelFactureTVQ.Text = "TVQ : "
    '
    'TextBoxFactureTotal
    '
    Me.TextBoxFactureTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxFactureTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.TextBoxFactureTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxFactureTotal.Location = New System.Drawing.Point(452, 272)
    Me.TextBoxFactureTotal.Name = "TextBoxFactureTotal"
    Me.TextBoxFactureTotal.ReadOnly = True
    Me.TextBoxFactureTotal.Size = New System.Drawing.Size(287, 20)
    Me.TextBoxFactureTotal.TabIndex = 10
    '
    'LabelFactureTotal
    '
    Me.LabelFactureTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureTotal.AutoSize = True
    Me.LabelFactureTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelFactureTotal.Location = New System.Drawing.Point(383, 275)
    Me.LabelFactureTotal.Name = "LabelFactureTotal"
    Me.LabelFactureTotal.Size = New System.Drawing.Size(48, 13)
    Me.LabelFactureTotal.TabIndex = 9
    Me.LabelFactureTotal.Text = "Total : "
    '
    'BoutonFactureAnnuler
    '
    Me.BoutonFactureAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.BoutonFactureAnnuler.BackColor = System.Drawing.Color.Crimson
    Me.BoutonFactureAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.BoutonFactureAnnuler.Location = New System.Drawing.Point(12, 305)
    Me.BoutonFactureAnnuler.Name = "BoutonFactureAnnuler"
    Me.BoutonFactureAnnuler.Size = New System.Drawing.Size(372, 23)
    Me.BoutonFactureAnnuler.TabIndex = 27
    Me.BoutonFactureAnnuler.Text = "Annuler"
    Me.BoutonFactureAnnuler.UseVisualStyleBackColor = False
    '
    'BoutonFactureOK
    '
    Me.BoutonFactureOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BoutonFactureOK.BackColor = System.Drawing.Color.SeaGreen
    Me.BoutonFactureOK.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.BoutonFactureOK.Location = New System.Drawing.Point(386, 305)
    Me.BoutonFactureOK.Name = "BoutonFactureOK"
    Me.BoutonFactureOK.Size = New System.Drawing.Size(353, 23)
    Me.BoutonFactureOK.TabIndex = 26
    Me.BoutonFactureOK.Text = "Facturer"
    Me.BoutonFactureOK.UseVisualStyleBackColor = False
    '
    'LabelFactureInstructions
    '
    Me.LabelFactureInstructions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureInstructions.AutoSize = True
    Me.LabelFactureInstructions.Location = New System.Drawing.Point(9, 217)
    Me.LabelFactureInstructions.Name = "LabelFactureInstructions"
    Me.LabelFactureInstructions.Size = New System.Drawing.Size(220, 13)
    Me.LabelFactureInstructions.TabIndex = 28
    Me.LabelFactureInstructions.Text = "* Laissez vide s'il n'y a aucun code d'étudiant"
    '
    'RichTextBoxComm
    '
    Me.RichTextBoxComm.Location = New System.Drawing.Point(105, 239)
    Me.RichTextBoxComm.Name = "RichTextBoxComm"
    Me.RichTextBoxComm.Size = New System.Drawing.Size(276, 60)
    Me.RichTextBoxComm.TabIndex = 29
    Me.RichTextBoxComm.Text = ""
    '
    'LabelFactureComm
    '
    Me.LabelFactureComm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.LabelFactureComm.AutoSize = True
    Me.LabelFactureComm.Location = New System.Drawing.Point(9, 242)
    Me.LabelFactureComm.Name = "LabelFactureComm"
    Me.LabelFactureComm.Size = New System.Drawing.Size(77, 13)
    Me.LabelFactureComm.TabIndex = 30
    Me.LabelFactureComm.Text = "Commentaire : "
    '
    'FormNouvelleFacture
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(751, 340)
    Me.Controls.Add(Me.LabelFactureComm)
    Me.Controls.Add(Me.RichTextBoxComm)
    Me.Controls.Add(Me.LabelFactureInstructions)
    Me.Controls.Add(Me.BoutonFactureAnnuler)
    Me.Controls.Add(Me.BoutonFactureOK)
    Me.Controls.Add(Me.TextBoxFactureTotal)
    Me.Controls.Add(Me.LabelFactureTotal)
    Me.Controls.Add(Me.TextBoxFactureTVQ)
    Me.Controls.Add(Me.LabelFactureTVQ)
    Me.Controls.Add(Me.TextBoxFactureTPS)
    Me.Controls.Add(Me.LabelFactureTPS)
    Me.Controls.Add(Me.TextBoxFactureSousTotal)
    Me.Controls.Add(Me.LabelFactureSousTotal)
    Me.Controls.Add(Me.TextBoxFactureCodeEtu)
    Me.Controls.Add(Me.LabelFactureCodeEtu)
    Me.Controls.Add(Me.DataGridViewFacture)
    Me.Name = "FormNouvelleFacture"
    Me.Text = "Nouvelle facture"
    CType(Me.DataGridViewFacture, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents DataGridViewFacture As DataGridView
  Friend WithEvents LabelFactureCodeEtu As Label
  Friend WithEvents TextBoxFactureCodeEtu As TextBox
  Friend WithEvents TextBoxFactureSousTotal As TextBox
  Friend WithEvents LabelFactureSousTotal As Label
  Friend WithEvents TextBoxFactureTPS As TextBox
  Friend WithEvents LabelFactureTPS As Label
  Friend WithEvents TextBoxFactureTVQ As TextBox
  Friend WithEvents LabelFactureTVQ As Label
  Friend WithEvents TextBoxFactureTotal As TextBox
  Friend WithEvents LabelFactureTotal As Label
  Friend WithEvents BoutonFactureAnnuler As Button
  Friend WithEvents BoutonFactureOK As Button
  Friend WithEvents LabelFactureInstructions As Label
  Friend WithEvents RichTextBoxComm As System.Windows.Forms.RichTextBox
  Friend WithEvents LabelFactureComm As System.Windows.Forms.Label
End Class
