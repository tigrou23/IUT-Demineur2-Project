Public Class JoueurComparer

    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return x.getNbCasePerf > y.getNbCasePerf
    End Function

End Class
