Imports System.ComponentModel

Public Class reglages

    Private Const nbLigneDefaut As Integer = 8
    Private Const nbMin As Integer = 2
    Private Const nbMax As Integer = 16
    Private Const nbColonneDefaut As Integer = 8
    Private Const tempsDefaut As Integer = 1
    Private Const nbBombeMax As Integer = 50
    Private Const nbBombeDefaut As Integer = 10

    Private nbLigne As Integer
    Private nbColonne As Integer
    Private path As String
    Private temps As Integer
    Private nbBombe As Integer

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
            nbLigne = HScrollBar1.Value
            nbColonne = HScrollBar2.Value
            path = TextBox1.Text
            temps = TextBox2.Text
            nbBombe = ListBox1.SelectedValue
            TextBox1.Enabled = False
            PictureBox2.Visible = False
            PictureBox1.Visible = True
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
        TextBox1.Text = Application.StartupPath & "\config.txt"
        TextBox2.Text = tempsDefaut
        HScrollBar1.Minimum = nbMin
        HScrollBar1.Maximum = nbMax
        HScrollBar1.Value = nbMax / 2
        HScrollBar2.Minimum = nbMin
        HScrollBar2.Maximum = nbMax
        HScrollBar2.Value = nbMax / 2
        nbLigne = nbLigneDefaut
        nbColonne = nbColonneDefaut
        path = Application.StartupPath & "\config.txt"
        temps = tempsDefaut
        nbBombe = nbBombeDefaut
        CheckBox1.CheckState = CheckState.Checked
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
        TextBox1.Text = Application.StartupPath & "\config.txt"
        TextBox1.Enabled = False
        PictureBox2.Visible = False
        PictureBox1.Visible = True
        HScrollBar1.Value = nbMax / 2
        HScrollBar2.Value = nbMax / 2
        Label8.Text = HScrollBar1.Value
        Label4.Text = HScrollBar2.Value
        CheckBox1.CheckState = CheckState.Checked
    End Sub

    Private Sub reglages_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Etes-vous certain de vouloir quitter ? Toute modification sera perdue", vbOKCancel, "Attention") = vbOK Then
            Button3.PerformClick()
            TextBox1.Enabled = False
            PictureBox2.Visible = False
            PictureBox1.Visible = True
            nbLigne = HScrollBar1.Value
            nbColonne = HScrollBar2.Value
            path = TextBox1.Text
            temps = TextBox2.Text
            nbBombe = ListBox1.SelectedValue
            CheckBox1.CheckState = CheckState.Checked
            Hide()
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBox1.Enabled = False
        PictureBox2.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox1.Enabled = True
        PictureBox1.Visible = False
        PictureBox2.Visible = True
    End Sub

    Public Function getNbLigne() As Integer
        Return nbLigne
    End Function

    Public Function getNbColonne() As Integer
        Return nbColonne
    End Function

    Public Function getPath() As String
        Return path
    End Function

    Public Function getTemps() As Integer
        Return temps
    End Function

    Public Function getNbBombe() As String
        Return nbBombe
    End Function

    Public Function verifFichier() As Boolean
        Try
            Dim readFile As System.IO.StreamReader
            readFile = New System.IO.StreamReader(path)
            readFile.ReadLine()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class

