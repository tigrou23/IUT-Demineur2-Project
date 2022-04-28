Public Class Theme
    Private couleur_Fo_Case, couleur_Bd_Case, couleur_Fo_Form, couleur_Ec_Form As Color
    'Fo : Fore
    'Ba : Border
    'Ec : Ecriture
    Public Sub New(cFc As Color, cBc As Color, cFf As Color, cEc As Color)
        couleur_Fo_Case = cFc
        couleur_Bd_Case = cBc
        couleur_Fo_Form = cFf
        couleur_Ec_Form = cEc
    End Sub
    Public Function get_couleur_Fo_Case()
        Return couleur_Fo_Case
    End Function
    Public Function get_couleur_Bd_Case()
        Return couleur_Bd_Case
    End Function
    Public Function get_couleur_Fo_Form()
        Return couleur_Fo_Form
    End Function
    Public Function get_couleur_Ec_Form()
        Return couleur_Ec_Form
    End Function
End Class
