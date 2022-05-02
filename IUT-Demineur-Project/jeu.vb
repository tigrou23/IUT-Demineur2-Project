Imports System.ComponentModel

Public Class jeu
    Private flag As Boolean
    Private cptCase As Integer
    Public Sub init(l As Integer, c As Integer, p As String, n As Integer, tmp As String, th As Theme)
        cptCase = l * c - n
        enregistrement(l, c, n, th)
    End Sub

    Private Sub Formulaire_Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim th As Theme = Donnees.get_Theme
        tlp.AutoSize = True
        tlp.Margin = New Padding(0, 100, 0, 0)
        tlp.SuspendLayout()
        tlp.ColumnCount = Donnees.get_Colonne
        tlp.RowCount = Donnees.get_Ligne
        For j As Integer = 0 To Donnees.get_Colonne - 1
            For i As Integer = 0 To Donnees.get_Ligne - 1
                tlp.Controls.Add(Donnees.get_BoxBtn(i, j), j, i)
            Next
        Next
        Me.Controls.Add(tlp)
        tlp.ResumeLayout()
        For Each btn As Control In tlp.Controls
            AddHandler btn.Click, AddressOf First_Click
        Next
    End Sub
    Private Sub First_Click(sender As Object, e As EventArgs)
        Drapeau.Enabled = True
        Drapeau.FlatStyle = FlatStyle.Flat
        Drapeau.FlatAppearance.BorderColor = Donnees.get_Theme().get_backColor_Box()
        flag = False
        For Each btn As Control In tlp.Controls
            RemoveHandler btn.Click, AddressOf First_Click
        Next
        placementBombes(tlp.GetRow(sender), tlp.GetColumn(sender))
        placementNombres()
        Btn_Clicked(sender, e)
        For Each btn As Control In tlp.Controls
            AddHandler btn.Click, AddressOf Btn_Clicked
        Next
    End Sub

    Private Sub jeu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Etes-vous certain de vouloir quitter ? Votre partie sera perdue", vbOKCancel, "Attention") = vbOK Then
            accueil.Show()
        End If
    End Sub

    Private Sub Btn_Clicked(sender As Object, e As EventArgs)
        If isBomb(tlp.GetRow(sender), tlp.GetColumn(sender)) Then
            Partie_Perdue()
        Else
            If affichageText(tlp.GetRow(sender), tlp.GetColumn(sender)).Text = "" Then
                Donnees.caseVide(tlp.GetRow(sender), tlp.GetColumn(sender))
                For Each l As Integer In Donnees.get_ListeVide
                    Dim numero As Control = tlp.Controls.Item((l Mod Donnees.get_Colonne) * Donnees.get_Colonne + (l \ Donnees.get_Colonne))
                    numero.Visible = False
                    tlp.Controls.Add(Donnees.affichageText(tlp.GetRow(numero), tlp.GetColumn(numero)), tlp.GetColumn(numero), tlp.GetRow(numero))
                    cptCase -= 1
                Next
                Donnees.clear_ListVide()
            Else
                Dim lbl As Label = Donnees.reveler(tlp.GetRow(sender), tlp.GetColumn(sender))
                sender.Visible = False
                tlp.Controls.Add(lbl, tlp.GetColumn(sender), tlp.GetRow(sender))
                cptCase -= 1
            End If
            If cptCase = 0 Then
                Partie_Gagnee()
            End If
        End If
    End Sub
    Private Sub Flag_Click(sender As Object, e As EventArgs)
        If sender.BackColor = Donnees.get_Theme().get_flagColor() Then
            sender.BackColor = Donnees.get_Theme().get_backColor_Box()
        Else
            If TypeOf sender Is System.Windows.Forms.Button Then
                sender.BackColor = Donnees.get_Theme().get_flagColor()
            End If
        End If
    End Sub
    Private Sub Partie_Gagnee()
        MsgBox("finito")
    End Sub
    Private Sub Partie_Perdue()
        MsgBox("BOUM")
    End Sub
End Class