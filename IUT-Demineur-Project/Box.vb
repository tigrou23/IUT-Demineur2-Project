Public Class Box
    Private val As Valeur
    Private form As Etat
    Public btn As Button

    Public Sub New(fore As Color, border As Color)
        btn = New Button
        btn.Size = New Size(50, 50)
        btn.ForeColor = fore
        btn.FlatAppearance.BorderColor = border
    End Sub
    Public Function get_Button()
        Return btn
    End Function
    Private Enum Valeur
        Bomb
        Nombre
        Vide
    End Enum
    Private Enum Etat
        Inconnu
        Connu
        Drapeau
    End Enum
End Class