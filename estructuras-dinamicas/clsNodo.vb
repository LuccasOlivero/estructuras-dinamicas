Public Class clsNodo
    Public Property Dato As Integer
    Public Property Siguiente As clsNodo

    Public Sub New(valor As Integer)
        Dato = valor
        Siguiente = Nothing
    End Sub
End Class
