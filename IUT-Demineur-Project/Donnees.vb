Module Donnees
    Private grille()() As Box
    Private nbLignes As Integer
    Private nbColonnes As Integer
    Private temps As Integer
    Private nbBombe As Integer
    Private theme As Theme
    Public Sub enregistrement(nbL As Integer, nbC As Integer, nbB As Integer, th As Theme) 'ajouter le temps
        nbBombe = nbB
        nbLignes = nbL
        nbColonnes = nbC
        theme = th
        grille = New Box(nbLignes - 1)() {}
        For i As Integer = 0 To nbLignes - 1
            grille(i) = New Box(nbColonnes - 1) {}
        Next
        For i As Integer = 0 To nbLignes - 1
            For j As Integer = 0 To nbColonnes - 1
                grille(i)(j) = New Box(theme.get_couleur_Fo_Case, theme.get_couleur_Bd_Case)
            Next
        Next
        'ajouter le temps
    End Sub

    Public Sub placementBombes()
        Dim random As New Random(), locLigne As Integer, locColonne As Integer
        For i As Integer = 0 To nbBombe - 1
            Dim b As Box
            Do
                locLigne = random.Next(0, nbLignes)
                locColonne = random.Next(0, nbColonnes)

                'b = New Box(Color.Black, Color.Black, 1)
            Loop Until grille(locLigne)(locColonne).get_Valeur <> Box.Valeur.Bomb
            'grille(locLigne)(locColonne) = b
            grille(locLigne)(locColonne).set_Color(Color.Red)
            grille(locLigne)(locColonne).set_Valeur(1)
        Next
    End Sub
    Public Function get_Ligne()
        Return nbLignes
    End Function
    Public Function get_Colonne()
        Return nbColonnes
    End Function
    Public Function get_Theme()
        Return theme
    End Function
    Public Function get_BoxBtn(i As Integer, j As Integer)
        Return grille(i)(j).btn
    End Function
    'Public Function get_Ligne()
    'Return ligne
    'End Function
    'Public Function get_Colonne()
    'Return colonne
    'End Function
    'Public Function get_Theme()
    'Return theme
    'End Function
End Module
