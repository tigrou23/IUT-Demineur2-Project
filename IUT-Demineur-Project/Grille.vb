Public Class Grille
    Private ligne As Integer
    Private colonne As Integer
    Private path As String
    Private nb_mines As Integer
    Private temps As String
    Private theme As Theme
    Public Sub New(l As Integer, c As Integer, p As String, n As Integer, tmp As String, th As Theme)
        ligne = l
        colonne = c
        path = p
        nb_mines = n
        temps = tmp
        theme = th
    End Sub
    Public Function get_Ligne()
        Return ligne
    End Function
    Public Function get_Colonne()
        Return colonne
    End Function
    Public Function get_Theme()
        Return theme
    End Function

End Class
