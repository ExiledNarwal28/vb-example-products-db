<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnection
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
    Me.ButtonConnAnnuler = New System.Windows.Forms.Button()
    Me.ButtonConnOK = New System.Windows.Forms.Button()
    Me.TextBoxConnMDP = New System.Windows.Forms.TextBox()
    Me.LabelConnMDP = New System.Windows.Forms.Label()
    Me.TextBoxConnUtilisateur = New System.Windows.Forms.TextBox()
    Me.LabelConnUtilisateur = New System.Windows.Forms.Label()
    Me.TextBoxConnAdresse = New System.Windows.Forms.TextBox()
    Me.LabelConnAdresse = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'ButtonItemsAdminAnnuler
    '
    Me.ButtonConnAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.ButtonConnAnnuler.BackColor = System.Drawing.Color.Crimson
    Me.ButtonConnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonConnAnnuler.Location = New System.Drawing.Point(13, 90)
    Me.ButtonConnAnnuler.Name = "ButtonItemsAdminAnnuler"
    Me.ButtonConnAnnuler.Size = New System.Drawing.Size(181, 23)
    Me.ButtonConnAnnuler.TabIndex = 25
    Me.ButtonConnAnnuler.Text = "Annuler"
    Me.ButtonConnAnnuler.UseVisualStyleBackColor = False
    '
    'ButtonItemsAdminOK
    '
    Me.ButtonConnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonConnOK.BackColor = System.Drawing.Color.SeaGreen
    Me.ButtonConnOK.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonConnOK.Location = New System.Drawing.Point(195, 90)
    Me.ButtonConnOK.Name = "ButtonItemsAdminOK"
    Me.ButtonConnOK.Size = New System.Drawing.Size(181, 23)
    Me.ButtonConnOK.TabIndex = 24
    Me.ButtonConnOK.Text = "Connexion"
    Me.ButtonConnOK.UseVisualStyleBackColor = False
    '
    'TextBoxAdminMDP
    '
    Me.TextBoxConnMDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxConnMDP.Location = New System.Drawing.Point(143, 38)
    Me.TextBoxConnMDP.Name = "TextBoxAdminMDP"
    Me.TextBoxConnMDP.Size = New System.Drawing.Size(233, 20)
    Me.TextBoxConnMDP.TabIndex = 23
    Me.TextBoxConnMDP.UseSystemPasswordChar = True
    '
    'LabelConnMDP
    '
    Me.LabelConnMDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelConnMDP.AutoSize = True
    Me.LabelConnMDP.Location = New System.Drawing.Point(10, 41)
    Me.LabelConnMDP.Name = "LabelConnMDP"
    Me.LabelConnMDP.Size = New System.Drawing.Size(80, 13)
    Me.LabelConnMDP.TabIndex = 22
    Me.LabelConnMDP.Text = "Mot de passe : "
    '
    'TextBoxAdminUtilisateur
    '
    Me.TextBoxConnUtilisateur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxConnUtilisateur.Location = New System.Drawing.Point(143, 12)
    Me.TextBoxConnUtilisateur.Name = "TextBoxAdminUtilisateur"
    Me.TextBoxConnUtilisateur.Size = New System.Drawing.Size(233, 20)
    Me.TextBoxConnUtilisateur.TabIndex = 21
    '
    'LabelConnUtilisateur
    '
    Me.LabelConnUtilisateur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelConnUtilisateur.AutoSize = True
    Me.LabelConnUtilisateur.Location = New System.Drawing.Point(10, 15)
    Me.LabelConnUtilisateur.Name = "LabelConnUtilisateur"
    Me.LabelConnUtilisateur.Size = New System.Drawing.Size(93, 13)
    Me.LabelConnUtilisateur.TabIndex = 20
    Me.LabelConnUtilisateur.Text = "Nom d'utilisateur : "
    '
    'TextBoxConnAdresse
    '
    Me.TextBoxConnAdresse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxConnAdresse.Location = New System.Drawing.Point(143, 64)
    Me.TextBoxConnAdresse.Name = "TextBoxConnAdresse"
    Me.TextBoxConnAdresse.Size = New System.Drawing.Size(233, 20)
    Me.TextBoxConnAdresse.TabIndex = 27
    Me.TextBoxConnAdresse.UseSystemPasswordChar = True
    '
    'LabelConnAdresse
    '
    Me.LabelConnAdresse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelConnAdresse.AutoSize = True
    Me.LabelConnAdresse.Location = New System.Drawing.Point(10, 67)
    Me.LabelConnAdresse.Name = "LabelConnAdresse"
    Me.LabelConnAdresse.Size = New System.Drawing.Size(121, 13)
    Me.LabelConnAdresse.TabIndex = 26
    Me.LabelConnAdresse.Text = "Adresse de connexion : "
    '
    'FormConnection
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Thistle
    Me.ClientSize = New System.Drawing.Size(381, 115)
    Me.Controls.Add(Me.TextBoxConnAdresse)
    Me.Controls.Add(Me.LabelConnAdresse)
    Me.Controls.Add(Me.ButtonConnAnnuler)
    Me.Controls.Add(Me.ButtonConnOK)
    Me.Controls.Add(Me.TextBoxConnMDP)
    Me.Controls.Add(Me.LabelConnMDP)
    Me.Controls.Add(Me.TextBoxConnUtilisateur)
    Me.Controls.Add(Me.LabelConnUtilisateur)
    Me.Name = "FormConnection"
    Me.Text = "Connexion : administrateur"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ButtonConnAnnuler As System.Windows.Forms.Button
  Friend WithEvents ButtonConnOK As System.Windows.Forms.Button
  Friend WithEvents TextBoxConnMDP As System.Windows.Forms.TextBox
  Friend WithEvents LabelConnMDP As System.Windows.Forms.Label
  Friend WithEvents TextBoxConnUtilisateur As System.Windows.Forms.TextBox
  Friend WithEvents LabelConnUtilisateur As System.Windows.Forms.Label
  Friend WithEvents TextBoxConnAdresse As System.Windows.Forms.TextBox
  Friend WithEvents LabelConnAdresse As System.Windows.Forms.Label
End Class
