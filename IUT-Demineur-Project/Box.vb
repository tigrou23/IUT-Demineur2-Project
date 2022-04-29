Public Class Box
    Private val As Valeur
    Private form As Etat
    Public btn As Button

    Public Sub New(fore As Color, border As Color)
        btn = New Button
        btn.Size = New Size(50, 50)
        btn.BackColor = fore
        btn.FlatAppearance.BorderColor = border
        val = Valeur.Vide
        form = Etat.Inconnu
    End Sub
    Public Sub New(fore As Color, border As Color, nb As Integer)
        btn = New Button
        btn.Size = New Size(50, 50)
        btn.BackColor = fore
        btn.FlatAppearance.BorderColor = border
        val = Valeur.Bomb
        form = Etat.Inconnu
    End Sub
    Public Sub set_Color(color As Color)
        btn.BackColor = color
    End Sub
    Public Sub set_Valeur(num As Integer) ' OU UN BOOL : true = bomb et false = vide
        If (num = 1) Then
            val = Valeur.Bomb
        End If
    End Sub
    Public Function get_Valeur()
        Return val
    End Function
    Public Function get_Etat()
        Return form
    End Function
    Public Function get_Button()
        Return btn
    End Function
    Public Enum Valeur
        Bomb
        Nombre
        Vide
    End Enum
    Public Enum Etat
        Inconnu
        Connu
        Drapeau
    End Enum
End Class