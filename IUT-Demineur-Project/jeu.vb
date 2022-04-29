Imports System.ComponentModel

Public Class jeu

    Private grille As Grille

    Public Sub init(l As Integer, c As Integer, p As String, n As Integer, tmp As String, th As Theme)
        grille = New Grille(l, c, p, n, tmp, th)
    End Sub

    Private Sub Formulaire_Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim th As Theme = grille.get_Theme
        Dim tlp = New TableLayoutPanel
        tlp.AutoSize = True
        tlp.SuspendLayout()
        For i As Integer = 0 To grille.get_Colonne() - 1
            For j As Integer = 0 To grille.get_Ligne() - 1
                Dim box = New Box(th.get_couleur_Fo_Case, th.get_couleur_Bd_Case)
                tlp.Controls.Add(box.get_Button, i, j)
            Next
        Next
        Me.Controls.Add(tlp)
        tlp.Dock = DockStyle.Fill
        tlp.ResumeLayout()
        tlp.BackColor = th.get_couleur_Fo_Form
    End Sub

    Private Sub jeu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Etes-vous certain de vouloir quitter ? Votre partie sera perdue", vbOKCancel, "Attention") = vbOK Then
            accueil.Show()
        End If
    End Sub

End Class