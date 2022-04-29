Public Class accueil

    Private Const maxLettre As Integer = 50

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reglages.Show()
        reglages.Hide()
        'à optimiser mais indispensable pour charger les réglages
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        reglages.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem <> "" Then
            Hide()
            jeu.init(reglages.getNbColonne, reglages.getNbLigne, reglages.getPath, reglages.getNbBombe, reglages.getTemps, New Theme(Color.Blue, Color.Red, Color.White, Color.Black))
            jeu.Show()
        Else
            Label2.Visible = True
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Or ComboBox1.Text.Length > maxLettre - 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Label2.Visible = False
    End Sub

    Private Sub accueil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If reglages.verifFichier() = True Then
            Button1.Enabled = True
            Button2.Enabled = True
            ComboBox1.Enabled = True
            Label3.Visible = False
            Dim readFile As System.IO.StreamReader
            readFile = New System.IO.StreamReader(reglages.getPath)
            Dim line As String = "tmp"
            While line <> ""
                line = readFile.ReadLine()
                If line <> "" Then
                    ComboBox1.Items.Add(line)
                End If
            End While
        Else
            Label3.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            ComboBox1.Enabled = False
        End If
    End Sub

End Class