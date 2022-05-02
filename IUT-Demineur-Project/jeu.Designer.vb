<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jeu
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
        Me.tlp = New System.Windows.Forms.TableLayoutPanel()
        Me.Drapeau = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tlp
        '
        Me.tlp.ColumnCount = 2
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp.Location = New System.Drawing.Point(12, 40)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 2
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp.Size = New System.Drawing.Size(214, 164)
        Me.tlp.TabIndex = 0
        '
        'Drapeau
        '
        Me.Drapeau.Location = New System.Drawing.Point(12, 11)
        Me.Drapeau.Name = "Drapeau"
        Me.Drapeau.Size = New System.Drawing.Size(75, 23)
        Me.Drapeau.TabIndex = 0
        Me.Drapeau.Text = "Drapeau"
        Me.Drapeau.UseVisualStyleBackColor = True
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 216)
        Me.Controls.Add(Me.Drapeau)
        Me.Controls.Add(Me.tlp)
        Me.Name = "jeu"
        Me.Text = "jeu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp As TableLayoutPanel
    Friend WithEvents Drapeau As Button
End Class
