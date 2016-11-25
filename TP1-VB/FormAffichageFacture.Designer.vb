<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAffichageFacture
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAffichageFacture))
    Me.LabelAFactNom = New System.Windows.Forms.Label()
    Me.LabelAFactAdd = New System.Windows.Forms.Label()
    Me.LabelAFactVille = New System.Windows.Forms.Label()
    Me.LabelAFactTel = New System.Windows.Forms.Label()
    Me.LabelAFactFax = New System.Windows.Forms.Label()
    Me.LabelAFactCourriel = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.LabelAFactDate = New System.Windows.Forms.Label()
    Me.LabelAFactNo = New System.Windows.Forms.Label()
    Me.LabelAFactTitre = New System.Windows.Forms.Label()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.LabelAFactNoEtu = New System.Windows.Forms.Label()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.LabelAFactAutre1 = New System.Windows.Forms.Label()
    Me.Panel8 = New System.Windows.Forms.Panel()
    Me.LabelAFactTVQ = New System.Windows.Forms.Label()
    Me.LabelAFactTPS = New System.Windows.Forms.Label()
    Me.LabelAFactSousTotal = New System.Windows.Forms.Label()
    Me.LabelAFactAutre4 = New System.Windows.Forms.Label()
    Me.LabelAFactAutre3 = New System.Windows.Forms.Label()
    Me.LabelAFactAutre2 = New System.Windows.Forms.Label()
    Me.Panel9 = New System.Windows.Forms.Panel()
    Me.DataGridViewAFact = New System.Windows.Forms.DataGridView()
    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.LabelAFactTotal = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Panel10 = New System.Windows.Forms.Panel()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.Panel6 = New System.Windows.Forms.Panel()
    Me.RichTextBoxAFactComm = New System.Windows.Forms.RichTextBox()
    Me.Panel11 = New System.Windows.Forms.Panel()
    Me.LabelAFactAutre5 = New System.Windows.Forms.Label()
    Me.PrintDialogAFact = New System.Windows.Forms.PrintDialog()
    Me.PrintDocumentAFact = New System.Drawing.Printing.PrintDocument()
    Me.PrintPreviewDialogAFact = New System.Windows.Forms.PrintPreviewDialog()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.Panel8.SuspendLayout()
    CType(Me.DataGridViewAFact, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel5.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.Panel11.SuspendLayout()
    Me.SuspendLayout()
    '
    'LabelAFactNom
    '
    Me.LabelAFactNom.AutoSize = True
    Me.LabelAFactNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactNom.Location = New System.Drawing.Point(12, 10)
    Me.LabelAFactNom.Name = "LabelAFactNom"
    Me.LabelAFactNom.Size = New System.Drawing.Size(121, 39)
    Me.LabelAFactNom.TabIndex = 2
    Me.LabelAFactNom.Text = "COOP"
    '
    'LabelAFactAdd
    '
    Me.LabelAFactAdd.AutoSize = True
    Me.LabelAFactAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactAdd.Location = New System.Drawing.Point(16, 69)
    Me.LabelAFactAdd.Name = "LabelAFactAdd"
    Me.LabelAFactAdd.Size = New System.Drawing.Size(68, 17)
    Me.LabelAFactAdd.TabIndex = 3
    Me.LabelAFactAdd.Text = "Addresse"
    '
    'LabelAFactVille
    '
    Me.LabelAFactVille.AutoSize = True
    Me.LabelAFactVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactVille.Location = New System.Drawing.Point(16, 86)
    Me.LabelAFactVille.Name = "LabelAFactVille"
    Me.LabelAFactVille.Size = New System.Drawing.Size(34, 17)
    Me.LabelAFactVille.TabIndex = 4
    Me.LabelAFactVille.Text = "Ville"
    '
    'LabelAFactTel
    '
    Me.LabelAFactTel.AutoSize = True
    Me.LabelAFactTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactTel.Location = New System.Drawing.Point(16, 103)
    Me.LabelAFactTel.Name = "LabelAFactTel"
    Me.LabelAFactTel.Size = New System.Drawing.Size(76, 17)
    Me.LabelAFactTel.TabIndex = 5
    Me.LabelAFactTel.Text = "Téléphone"
    '
    'LabelAFactFax
    '
    Me.LabelAFactFax.AutoSize = True
    Me.LabelAFactFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactFax.Location = New System.Drawing.Point(16, 120)
    Me.LabelAFactFax.Name = "LabelAFactFax"
    Me.LabelAFactFax.Size = New System.Drawing.Size(30, 17)
    Me.LabelAFactFax.TabIndex = 6
    Me.LabelAFactFax.Text = "Fax"
    '
    'LabelAFactCourriel
    '
    Me.LabelAFactCourriel.AutoSize = True
    Me.LabelAFactCourriel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactCourriel.Location = New System.Drawing.Point(16, 137)
    Me.LabelAFactCourriel.Name = "LabelAFactCourriel"
    Me.LabelAFactCourriel.Size = New System.Drawing.Size(57, 17)
    Me.LabelAFactCourriel.TabIndex = 7
    Me.LabelAFactCourriel.Text = "Courriel"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel1.Controls.Add(Me.LabelAFactNom)
    Me.Panel1.Controls.Add(Me.LabelAFactFax)
    Me.Panel1.Controls.Add(Me.LabelAFactCourriel)
    Me.Panel1.Controls.Add(Me.LabelAFactAdd)
    Me.Panel1.Controls.Add(Me.LabelAFactVille)
    Me.Panel1.Controls.Add(Me.LabelAFactTel)
    Me.Panel1.Location = New System.Drawing.Point(12, 12)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(451, 165)
    Me.Panel1.TabIndex = 8
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel2.Controls.Add(Me.LabelAFactDate)
    Me.Panel2.Controls.Add(Me.LabelAFactNo)
    Me.Panel2.Controls.Add(Me.LabelAFactTitre)
    Me.Panel2.Location = New System.Drawing.Point(469, 12)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(305, 236)
    Me.Panel2.TabIndex = 9
    '
    'LabelAFactDate
    '
    Me.LabelAFactDate.AutoSize = True
    Me.LabelAFactDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactDate.Location = New System.Drawing.Point(20, 69)
    Me.LabelAFactDate.Name = "LabelAFactDate"
    Me.LabelAFactDate.Size = New System.Drawing.Size(38, 17)
    Me.LabelAFactDate.TabIndex = 8
    Me.LabelAFactDate.Text = "Date"
    '
    'LabelAFactNo
    '
    Me.LabelAFactNo.AutoSize = True
    Me.LabelAFactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactNo.Location = New System.Drawing.Point(20, 86)
    Me.LabelAFactNo.Name = "LabelAFactNo"
    Me.LabelAFactNo.Size = New System.Drawing.Size(68, 17)
    Me.LabelAFactNo.TabIndex = 9
    Me.LabelAFactNo.Text = "Facture #"
    '
    'LabelAFactTitre
    '
    Me.LabelAFactTitre.AutoSize = True
    Me.LabelAFactTitre.Font = New System.Drawing.Font("Palatino Linotype", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactTitre.ForeColor = System.Drawing.SystemColors.WindowFrame
    Me.LabelAFactTitre.Location = New System.Drawing.Point(45, 10)
    Me.LabelAFactTitre.Name = "LabelAFactTitre"
    Me.LabelAFactTitre.Size = New System.Drawing.Size(215, 55)
    Me.LabelAFactTitre.TabIndex = 8
    Me.LabelAFactTitre.Text = "FACTURE"
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel3.Controls.Add(Me.LabelAFactNoEtu)
    Me.Panel3.Location = New System.Drawing.Point(12, 183)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(451, 65)
    Me.Panel3.TabIndex = 9
    '
    'LabelAFactNoEtu
    '
    Me.LabelAFactNoEtu.AutoSize = True
    Me.LabelAFactNoEtu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactNoEtu.Location = New System.Drawing.Point(16, 37)
    Me.LabelAFactNoEtu.Name = "LabelAFactNoEtu"
    Me.LabelAFactNoEtu.Size = New System.Drawing.Size(47, 17)
    Me.LabelAFactNoEtu.TabIndex = 8
    Me.LabelAFactNoEtu.Text = "NoÉtu"
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.Panel4.Controls.Add(Me.LabelAFactAutre1)
    Me.Panel4.Location = New System.Drawing.Point(12, 183)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(451, 25)
    Me.Panel4.TabIndex = 0
    '
    'LabelAFactAutre1
    '
    Me.LabelAFactAutre1.AutoSize = True
    Me.LabelAFactAutre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactAutre1.Location = New System.Drawing.Point(16, 5)
    Me.LabelAFactAutre1.Name = "LabelAFactAutre1"
    Me.LabelAFactAutre1.Size = New System.Drawing.Size(77, 17)
    Me.LabelAFactAutre1.TabIndex = 8
    Me.LabelAFactAutre1.Text = "Facturé à"
    '
    'Panel8
    '
    Me.Panel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.Panel8.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel8.Controls.Add(Me.LabelAFactTVQ)
    Me.Panel8.Controls.Add(Me.LabelAFactTPS)
    Me.Panel8.Controls.Add(Me.LabelAFactSousTotal)
    Me.Panel8.Controls.Add(Me.LabelAFactAutre4)
    Me.Panel8.Controls.Add(Me.LabelAFactAutre3)
    Me.Panel8.Controls.Add(Me.LabelAFactAutre2)
    Me.Panel8.Controls.Add(Me.Panel9)
    Me.Panel8.Location = New System.Drawing.Point(469, 360)
    Me.Panel8.Name = "Panel8"
    Me.Panel8.Size = New System.Drawing.Size(305, 72)
    Me.Panel8.TabIndex = 11
    '
    'LabelAFactTVQ
    '
    Me.LabelAFactTVQ.AutoSize = True
    Me.LabelAFactTVQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactTVQ.Location = New System.Drawing.Point(161, 43)
    Me.LabelAFactTVQ.Name = "LabelAFactTVQ"
    Me.LabelAFactTVQ.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelAFactTVQ.Size = New System.Drawing.Size(37, 17)
    Me.LabelAFactTVQ.TabIndex = 15
    Me.LabelAFactTVQ.Text = "TVQ"
    '
    'LabelAFactTPS
    '
    Me.LabelAFactTPS.AutoSize = True
    Me.LabelAFactTPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactTPS.Location = New System.Drawing.Point(161, 26)
    Me.LabelAFactTPS.Name = "LabelAFactTPS"
    Me.LabelAFactTPS.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelAFactTPS.Size = New System.Drawing.Size(35, 17)
    Me.LabelAFactTPS.TabIndex = 14
    Me.LabelAFactTPS.Text = "TPS"
    '
    'LabelAFactSousTotal
    '
    Me.LabelAFactSousTotal.AutoSize = True
    Me.LabelAFactSousTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactSousTotal.Location = New System.Drawing.Point(161, 9)
    Me.LabelAFactSousTotal.Name = "LabelAFactSousTotal"
    Me.LabelAFactSousTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelAFactSousTotal.Size = New System.Drawing.Size(72, 17)
    Me.LabelAFactSousTotal.TabIndex = 13
    Me.LabelAFactSousTotal.Text = "Sous-total"
    '
    'LabelAFactAutre4
    '
    Me.LabelAFactAutre4.AutoSize = True
    Me.LabelAFactAutre4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactAutre4.Location = New System.Drawing.Point(20, 43)
    Me.LabelAFactAutre4.Name = "LabelAFactAutre4"
    Me.LabelAFactAutre4.Size = New System.Drawing.Size(49, 17)
    Me.LabelAFactAutre4.TabIndex = 12
    Me.LabelAFactAutre4.Text = "TVQ : "
    '
    'LabelAFactAutre3
    '
    Me.LabelAFactAutre3.AutoSize = True
    Me.LabelAFactAutre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactAutre3.Location = New System.Drawing.Point(20, 26)
    Me.LabelAFactAutre3.Name = "LabelAFactAutre3"
    Me.LabelAFactAutre3.Size = New System.Drawing.Size(47, 17)
    Me.LabelAFactAutre3.TabIndex = 11
    Me.LabelAFactAutre3.Text = "TPS : "
    '
    'LabelAFactAutre2
    '
    Me.LabelAFactAutre2.AutoSize = True
    Me.LabelAFactAutre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactAutre2.Location = New System.Drawing.Point(20, 9)
    Me.LabelAFactAutre2.Name = "LabelAFactAutre2"
    Me.LabelAFactAutre2.Size = New System.Drawing.Size(84, 17)
    Me.LabelAFactAutre2.TabIndex = 10
    Me.LabelAFactAutre2.Text = "Sous-total : "
    '
    'Panel9
    '
    Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel9.Location = New System.Drawing.Point(457, 0)
    Me.Panel9.Name = "Panel9"
    Me.Panel9.Size = New System.Drawing.Size(305, 168)
    Me.Panel9.TabIndex = 10
    '
    'DataGridViewAFact
    '
    Me.DataGridViewAFact.AllowUserToAddRows = False
    Me.DataGridViewAFact.AllowUserToDeleteRows = False
    Me.DataGridViewAFact.AllowUserToResizeColumns = False
    Me.DataGridViewAFact.AllowUserToResizeRows = False
    Me.DataGridViewAFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewAFact.Location = New System.Drawing.Point(12, 254)
    Me.DataGridViewAFact.Name = "DataGridViewAFact"
    Me.DataGridViewAFact.ReadOnly = True
    Me.DataGridViewAFact.RowHeadersVisible = False
    Me.DataGridViewAFact.Size = New System.Drawing.Size(762, 100)
    Me.DataGridViewAFact.TabIndex = 0
    '
    'Panel5
    '
    Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel5.Controls.Add(Me.LabelAFactTotal)
    Me.Panel5.Controls.Add(Me.Label3)
    Me.Panel5.Controls.Add(Me.Panel10)
    Me.Panel5.Location = New System.Drawing.Point(469, 438)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(305, 90)
    Me.Panel5.TabIndex = 13
    '
    'LabelAFactTotal
    '
    Me.LabelAFactTotal.AutoSize = True
    Me.LabelAFactTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactTotal.Location = New System.Drawing.Point(160, 35)
    Me.LabelAFactTotal.Name = "LabelAFactTotal"
    Me.LabelAFactTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.LabelAFactTotal.Size = New System.Drawing.Size(100, 20)
    Me.LabelAFactTotal.TabIndex = 11
    Me.LabelAFactTotal.Text = "Grand total"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(19, 35)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(115, 20)
    Me.Label3.TabIndex = 10
    Me.Label3.Text = "Grand total : "
    '
    'Panel10
    '
    Me.Panel10.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel10.Location = New System.Drawing.Point(457, 0)
    Me.Panel10.Name = "Panel10"
    Me.Panel10.Size = New System.Drawing.Size(305, 168)
    Me.Panel10.TabIndex = 10
    '
    'Panel7
    '
    Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel7.Location = New System.Drawing.Point(457, 0)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(305, 168)
    Me.Panel7.TabIndex = 10
    '
    'Panel6
    '
    Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.Panel6.Controls.Add(Me.RichTextBoxAFactComm)
    Me.Panel6.Controls.Add(Me.Panel7)
    Me.Panel6.Location = New System.Drawing.Point(12, 360)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(451, 168)
    Me.Panel6.TabIndex = 9
    '
    'RichTextBoxAFactComm
    '
    Me.RichTextBoxAFactComm.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.RichTextBoxAFactComm.Location = New System.Drawing.Point(19, 32)
    Me.RichTextBoxAFactComm.Name = "RichTextBoxAFactComm"
    Me.RichTextBoxAFactComm.Size = New System.Drawing.Size(414, 127)
    Me.RichTextBoxAFactComm.TabIndex = 11
    Me.RichTextBoxAFactComm.Text = "Commentaires"
    '
    'Panel11
    '
    Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.Panel11.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.Panel11.Controls.Add(Me.LabelAFactAutre5)
    Me.Panel11.Location = New System.Drawing.Point(12, 360)
    Me.Panel11.Name = "Panel11"
    Me.Panel11.Size = New System.Drawing.Size(451, 26)
    Me.Panel11.TabIndex = 12
    '
    'LabelAFactAutre5
    '
    Me.LabelAFactAutre5.AutoSize = True
    Me.LabelAFactAutre5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAFactAutre5.Location = New System.Drawing.Point(16, 5)
    Me.LabelAFactAutre5.Name = "LabelAFactAutre5"
    Me.LabelAFactAutre5.Size = New System.Drawing.Size(160, 17)
    Me.LabelAFactAutre5.TabIndex = 8
    Me.LabelAFactAutre5.Text = "Autres commentaires"
    '
    'PrintDialogAFact
    '
    Me.PrintDialogAFact.UseEXDialog = True
    '
    'PrintDocumentAFact
    '
    '
    'PrintPreviewDialogAFact
    '
    Me.PrintPreviewDialogAFact.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialogAFact.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialogAFact.ClientSize = New System.Drawing.Size(400, 300)
    Me.PrintPreviewDialogAFact.Enabled = True
    Me.PrintPreviewDialogAFact.Icon = CType(resources.GetObject("PrintPreviewDialogAFact.Icon"), System.Drawing.Icon)
    Me.PrintPreviewDialogAFact.Name = "PrintPreviewDialogAFact"
    Me.PrintPreviewDialogAFact.Visible = False
    '
    'FormAffichageFacture
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(786, 540)
    Me.Controls.Add(Me.Panel11)
    Me.Controls.Add(Me.Panel5)
    Me.Controls.Add(Me.DataGridViewAFact)
    Me.Controls.Add(Me.Panel8)
    Me.Controls.Add(Me.Panel6)
    Me.Controls.Add(Me.Panel4)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FormAffichageFacture"
    Me.Text = "Affichage de la facture"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.Panel4.ResumeLayout(False)
    Me.Panel4.PerformLayout()
    Me.Panel8.ResumeLayout(False)
    Me.Panel8.PerformLayout()
    CType(Me.DataGridViewAFact, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel5.ResumeLayout(False)
    Me.Panel5.PerformLayout()
    Me.Panel6.ResumeLayout(False)
    Me.Panel11.ResumeLayout(False)
    Me.Panel11.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LabelAFactNom As System.Windows.Forms.Label
  Friend WithEvents LabelAFactCourriel As System.Windows.Forms.Label
  Friend WithEvents LabelAFactVille As System.Windows.Forms.Label
  Friend WithEvents LabelAFactAdd As System.Windows.Forms.Label
  Friend WithEvents LabelAFactFax As System.Windows.Forms.Label
  Friend WithEvents LabelAFactTel As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents LabelAFactTitre As System.Windows.Forms.Label
  Friend WithEvents LabelAFactDate As System.Windows.Forms.Label
  Friend WithEvents LabelAFactNo As System.Windows.Forms.Label
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents LabelAFactAutre1 As System.Windows.Forms.Label
  Friend WithEvents LabelAFactNoEtu As System.Windows.Forms.Label
  Friend WithEvents Panel8 As System.Windows.Forms.Panel
  Friend WithEvents Panel9 As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewAFact As System.Windows.Forms.DataGridView
  Friend WithEvents LabelAFactAutre4 As System.Windows.Forms.Label
  Friend WithEvents LabelAFactAutre3 As System.Windows.Forms.Label
  Friend WithEvents LabelAFactAutre2 As System.Windows.Forms.Label
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Panel10 As System.Windows.Forms.Panel
  Friend WithEvents LabelAFactTVQ As System.Windows.Forms.Label
  Friend WithEvents LabelAFactTPS As System.Windows.Forms.Label
  Friend WithEvents LabelAFactSousTotal As System.Windows.Forms.Label
  Friend WithEvents LabelAFactTotal As System.Windows.Forms.Label
  Friend WithEvents Panel7 As System.Windows.Forms.Panel
  Friend WithEvents Panel6 As System.Windows.Forms.Panel
  Friend WithEvents RichTextBoxAFactComm As System.Windows.Forms.RichTextBox
  Friend WithEvents Panel11 As System.Windows.Forms.Panel
  Friend WithEvents LabelAFactAutre5 As System.Windows.Forms.Label
  Friend WithEvents PrintDialogAFact As System.Windows.Forms.PrintDialog
  Friend WithEvents PrintDocumentAFact As System.Drawing.Printing.PrintDocument
  Friend WithEvents PrintPreviewDialogAFact As System.Windows.Forms.PrintPreviewDialog
End Class
