<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnexionAdmin
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
    Me.ButtonItemsAdminAnnuler = New System.Windows.Forms.Button()
    Me.ButtonItemsAdminOK = New System.Windows.Forms.Button()
    Me.TextBoxAdminMDP = New System.Windows.Forms.TextBox()
    Me.LabelAdminMDP = New System.Windows.Forms.Label()
    Me.TextBoxAdminUtilisateur = New System.Windows.Forms.TextBox()
    Me.LabelAdminUtilisateur = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'ButtonItemsAjoutAnnuler
    '
    Me.ButtonItemsAdminAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.ButtonItemsAdminAnnuler.BackColor = System.Drawing.Color.Crimson
    Me.ButtonItemsAdminAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonItemsAdminAnnuler.Location = New System.Drawing.Point(13, 64)
    Me.ButtonItemsAdminAnnuler.Name = "ButtonItemsAjoutAnnuler"
    Me.ButtonItemsAdminAnnuler.Size = New System.Drawing.Size(181, 23)
    Me.ButtonItemsAdminAnnuler.TabIndex = 25
    Me.ButtonItemsAdminAnnuler.Text = "Annuler"
    Me.ButtonItemsAdminAnnuler.UseVisualStyleBackColor = False
    '
    'ButtonItemsAjoutAjout
    '
    Me.ButtonItemsAdminOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonItemsAdminOK.BackColor = System.Drawing.Color.SeaGreen
    Me.ButtonItemsAdminOK.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.ButtonItemsAdminOK.Location = New System.Drawing.Point(195, 64)
    Me.ButtonItemsAdminOK.Name = "ButtonItemsAjoutAjout"
    Me.ButtonItemsAdminOK.Size = New System.Drawing.Size(181, 23)
    Me.ButtonItemsAdminOK.TabIndex = 24
    Me.ButtonItemsAdminOK.Text = "Connexion"
    Me.ButtonItemsAdminOK.UseVisualStyleBackColor = False
    '
    'TextBoxAdminMDP
    '
    Me.TextBoxAdminMDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxAdminMDP.Location = New System.Drawing.Point(107, 38)
    Me.TextBoxAdminMDP.Name = "TextBoxAdminMDP"
    Me.TextBoxAdminMDP.Size = New System.Drawing.Size(269, 20)
    Me.TextBoxAdminMDP.TabIndex = 23
    Me.TextBoxAdminMDP.UseSystemPasswordChar = True
    '
    'LabelAdminMDP
    '
    Me.LabelAdminMDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelAdminMDP.AutoSize = True
    Me.LabelAdminMDP.Location = New System.Drawing.Point(10, 41)
    Me.LabelAdminMDP.Name = "LabelAdminMDP"
    Me.LabelAdminMDP.Size = New System.Drawing.Size(80, 13)
    Me.LabelAdminMDP.TabIndex = 22
    Me.LabelAdminMDP.Text = "Mot de passe : "
    '
    'TextBoxAdminUtilisateur
    '
    Me.TextBoxAdminUtilisateur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxAdminUtilisateur.Location = New System.Drawing.Point(107, 12)
    Me.TextBoxAdminUtilisateur.Name = "TextBoxAdminUtilisateur"
    Me.TextBoxAdminUtilisateur.Size = New System.Drawing.Size(269, 20)
    Me.TextBoxAdminUtilisateur.TabIndex = 21
    '
    'LabelAdminUtilisateur
    '
    Me.LabelAdminUtilisateur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelAdminUtilisateur.AutoSize = True
    Me.LabelAdminUtilisateur.Location = New System.Drawing.Point(10, 15)
    Me.LabelAdminUtilisateur.Name = "LabelAdminUtilisateur"
    Me.LabelAdminUtilisateur.Size = New System.Drawing.Size(93, 13)
    Me.LabelAdminUtilisateur.TabIndex = 20
    Me.LabelAdminUtilisateur.Text = "Nom d'utilisateur : "
    '
    'FormConnexionAdmin
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Thistle
    Me.ClientSize = New System.Drawing.Size(381, 89)
    Me.Controls.Add(Me.ButtonItemsAdminAnnuler)
    Me.Controls.Add(Me.ButtonItemsAdminOK)
    Me.Controls.Add(Me.TextBoxAdminMDP)
    Me.Controls.Add(Me.LabelAdminMDP)
    Me.Controls.Add(Me.TextBoxAdminUtilisateur)
    Me.Controls.Add(Me.LabelAdminUtilisateur)
    Me.Name = "FormConnexionAdmin"
    Me.Text = "Connexion : administrateur"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ButtonItemsAdminAnnuler As System.Windows.Forms.Button
  Friend WithEvents ButtonItemsAdminOK As System.Windows.Forms.Button
  Friend WithEvents TextBoxAdminMDP As System.Windows.Forms.TextBox
  Friend WithEvents LabelAdminMDP As System.Windows.Forms.Label
  Friend WithEvents TextBoxAdminUtilisateur As System.Windows.Forms.TextBox
  Friend WithEvents LabelAdminUtilisateur As System.Windows.Forms.Label
End Class
