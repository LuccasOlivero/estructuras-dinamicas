Public Class clsNodo
    Public Nombre As String
    Public Tramite As String
    Public Anterior As clsNodo
    Public Property Dato As Integer
    Public Property Siguiente As clsNodo
    Public Property Codigo As Integer

    Public Sub New()
    End Sub

    Public Sub New(valor As Integer)
        Me.Codigo = valor
        Me.Siguiente = Nothing
        Me.Anterior = Nothing
        Me.Dato = valor
    End Sub
End Class
