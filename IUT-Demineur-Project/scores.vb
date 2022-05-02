Public Class scores

    Private Sub scores_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        stockJoueur.refreshList()
        If ListBox1.Items.Count <> 0 Then
            ListBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim tmp() As String = Split(ListBox1.SelectedItem)
        ComboBox1.Text = tmp(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        accueil.Enabled = True
        Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim tmp As New List(Of String)
        For Each item In ListBox1.Items
            tmp.Add(item)
        Next

        ListBox1.Items.Clear()

        For i As Integer = tmp.Count - 1 To 0 Step -1
            ListBox1.Items.Add(tmp(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As Joueur = stockJoueur.getJoueur(ComboBox1.Text)
        If stockJoueur.verifJoueur(ComboBox1.Text) Then
            MsgBox("Nom : " & j.getNom & vbCrLf & "Meilleur nombre de cases révélées : " & j.getNbCasePerf & vbCrLf & "Temps de cette performance : " & j.getTempsPerf & " minutes" & vbCrLf & "Nombre de parties jouées : " & j.getPartieJouee & vbCrLf & "Nombre de minutes en partie : " & j.getTempsJoue & vbCrLf, vbOKOnly, "Statistiques du joueur")
        Else
            MsgBox("Le joueur n'est pas enregistré.", vbOKOnly, "Attention")
        End If
    End Sub

    Private Sub scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class