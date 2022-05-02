Public Class Joueur

    Private nom As String
    Private nbCasePerf As Integer
    Private tempsPerf
    Private partieJouee As Integer
    Private tempsJoue As Integer

    Public Sub New(n As String, c As Integer, tD As Integer, p As Integer, t As Integer)
        nom = n
        nbCasePerf = c
        tempsPerf = tD
        partieJouee = p
        tempsJoue = t
    End Sub

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getPartieJouee() As Integer
        Return partieJouee
    End Function

    Public Function getTempsJoue() As Integer
        Return tempsJoue
    End Function

    Public Function getTempsPerf() As Integer
        Return tempsPerf
    End Function
    Public Function getNbCasePerf() As Integer
        Return nbCasePerf
    End Function

    Public Function setPartieJouee(p As Integer)
        partieJouee = p
    End Function

    Public Function setTempsJoue(t As Integer)
        tempsJoue = t
    End Function

    Public Function setTempsPerf(t As Integer)
        tempsPerf = t
    End Function

    Public Function setNbCasePerf(c As Integer)
        nbCasePerf = c
    End Function

End Class
