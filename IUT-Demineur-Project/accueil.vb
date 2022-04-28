Public Class accueil

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'faut le mettre en focus
        'en attendant de gérer le fichier

        ComboBox1.Items.Add("Hugo")
        ComboBox1.Items.Add("Eylea")
        ComboBox1.Items.Add("Jean")
        ComboBox1.Items.Add("Anne")
        ComboBox1.Items.Add("Aurelie")
        ComboBox1.Items.Add("Franck")
        ComboBox1.Items.Add("Magali")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        reglages.Show()
    End Sub
End Class