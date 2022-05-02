<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jeu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Drapeau = New System.Windows.Forms.Button()
        Me.tlp = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Drapeau)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 100)
        Me.Panel1.TabIndex = 3
        '
        'Drapeau
        '
        Me.Drapeau.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Drapeau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Drapeau.Enabled = False
        Me.Drapeau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Drapeau.Location = New System.Drawing.Point(847, 14)
        Me.Drapeau.Margin = New System.Windows.Forms.Padding(10)
        Me.Drapeau.Name = "Drapeau"
        Me.Drapeau.Size = New System.Drawing.Size(98, 71)
        Me.Drapeau.TabIndex = 3
        Me.Drapeau.Text = "Drapeau"
        Me.Drapeau.UseVisualStyleBackColor = True
        '
        'tlp
        '
        Me.tlp.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp.BackColor = System.Drawing.Color.Gray
        Me.tlp.ColumnCount = 2
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp.Location = New System.Drawing.Point(0, 100)
        Me.tlp.Margin = New System.Windows.Forms.Padding(0, 100, 0, 0)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 2
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.Size = New System.Drawing.Size(217, 97)
        Me.tlp.TabIndex = 1
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(961, 764)
        Me.Controls.Add(Me.tlp)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "jeu"
        Me.Text = "jeu"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Drapeau As Button
    Friend WithEvents tlp As TableLayoutPanel
End Class
