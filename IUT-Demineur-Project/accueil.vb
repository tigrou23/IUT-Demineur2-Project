Imports System.ComponentModel

Public Class accueil

    Private Const maxLettre As Integer = 50

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Voulez-vous vraiment quitter l'application ?", vbOKCancel, "Quitter") = vbOK Then
            Close()
        End If
    End Sub

    Private Sub accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'à optimiser mais indispensable pour charger les réglages
        reglages.Show()
        reglages.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        reglages.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem <> "" Then
            Hide()
            jeu.init(reglages.getNbLigne, reglages.getNbColonne, reglages.getPath, reglages.getNbBombe, reglages.getTemps, New Theme(Color.Blue, Color.Red, Color.Gray, Color.Black))
            jeu.Show()
        ElseIf ComboBox1.Text.Length = 0 Then
            Label2.Visible = True
            ComboBox1.Focus()
        ElseIf ComboBox1.Text.Length < 3 Then
            ComboBox1.Text = ""
            Label4.Visible = True
            ComboBox1.Focus()
        Else
            stockJoueur.enregistrementJoueur(ComboBox1.Text, 0, 0, 0, 0)
            Hide()
            jeu.init(reglages.getNbLigne, reglages.getNbColonne, reglages.getPath, reglages.getNbBombe, reglages.getTemps, New Theme(Color.Blue, Color.Red, Color.Gray, Color.Black))
            jeu.Show()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        Label4.Visible = False
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Or ComboBox1.Text.Length > maxLettre - 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub accueil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If reglages.aChange() = True Then
            If reglages.verifFichier() = True Then
                stockJoueur.debut(reglages.getPath())
                Button1.Enabled = True
                Button2.Enabled = True
                ComboBox1.Enabled = True
                Label3.Visible = False
            Else
                Label3.Visible = True
                Button1.Enabled = False
                Button2.Enabled = False
                ComboBox1.Enabled = False
            End If
            reglages.Change()
        End If
    End Sub

    Private Sub accueil_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        fin(reglages.getPath)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Enabled = False
        scores.Show()
    End Sub

End Class