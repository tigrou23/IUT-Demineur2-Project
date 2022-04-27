Imports System.ComponentModel

Public Class reglages

    Private nbLigneDefaut As Integer = 8
    Private nbMin As Integer = 2
    Private nbMax As Integer = 16
    Private nbColonneDefaut As Integer = 8
    Private pathDefaut As String = ".\config\config.txt"
    Private tempsDefaut As Integer = 10
    Private nbBombeMax As Integer = 50
    Private nbBombeDefaut As Integer = 10

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim estOk As Boolean = True
        If TextBox1.Text.Length() = 0 Then
            Label11.Visible = True
            estOk = False
        End If
        If TextBox2.Text.Length() = 0 Then
            Label10.Visible = True
            estOk = False
        End If
        If estOk Then
            Hide()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label11.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Label10.Visible = False
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Or TextBox2.Text.Length() > 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accueil.Enabled = False
        For i = 1 To nbBombeMax
            ListBox1.Items.Add(i & " bombes")
        Next
        ListBox1.SelectedIndex = nbBombeDefaut - 1
        TextBox2.Text = tempsDefaut
        HScrollBar1.Minimum = nbMin
        HScrollBar1.Maximum = nbMax
        HScrollBar1.Value = nbMax / 2
        HScrollBar2.Minimum = nbMin
        HScrollBar2.Maximum = nbMax
        HScrollBar2.Value = nbMax / 2
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label8.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label4.Text = HScrollBar2.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.SelectedIndex = nbBombeDefaut - 1
        TextBox2.Text = tempsDefaut
        TextBox1.Text = pathDefaut
        HScrollBar1.Value = nbMax / 2
        HScrollBar2.Value = nbMax / 2
        Label8.Text = HScrollBar1.Value
        Label4.Text = HScrollBar2.Value
    End Sub

    Private Sub reglages_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim choix As MsgBoxResult
        choix = MsgBox("Etes-vous certain de vouloir quitter ? Toute modification sera perdue", vbOKCancel, "Attention")
        If choix = vbOK Then
            Hide()
            Button3.PerformClick()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub reglages_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
            accueil.Enabled = False
        Else
            accueil.Enabled = True
        End If
    End Sub

End Class

