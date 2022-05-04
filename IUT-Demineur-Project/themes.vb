Public Class themes

    Private theme As Theme

    Public Function getTheme() As Theme
        If RadioButton3.Checked = True Then
            theme = New Theme(Color.Yellow, Color.Green, Color.Snow, Color.Blue)
        ElseIf RadioButton2.Checked = True Then
            theme = New Theme(Color.Black, Color.Blue, Color.Black, Color.Green)
        Else
            theme = New Theme(Color.White, Color.Red, Color.White, Color.Blue)
        End If
        Return theme
    End Function

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            PictureBox2.Visible = False
            PictureBox1.Visible = True
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBox4.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            PictureBox4.Visible = False
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        reglages.Enabled = True
        Hide()
    End Sub

End Class