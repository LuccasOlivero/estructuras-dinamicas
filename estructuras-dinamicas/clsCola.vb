Public Class clsCola
    Private Primero As clsNodo
    Private Ultimo As clsNodo

    ' Constructor
    Public Sub New()
        Primero = Nothing
        Ultimo = Nothing
    End Sub

    ' Agregar un elemento a la cola (enqueue)
    Public Sub Agregar(Nuevo As clsNodo)
        If Primero Is Nothing Then
            Primero = Nuevo
            Ultimo = Nuevo
        Else
            Ultimo.Siguiente = Nuevo
            Ultimo = Nuevo
        End If
    End Sub

    ' Eliminar un elemento de la cola (dequeue)
    Public Function Eliminar() As Integer
        If Primero Is Nothing Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If
        Dim valor As Integer = Primero.Dato
        Primero = Primero.Siguiente
        If Primero Is Nothing Then
            Ultimo = Nothing
        End If
        Return valor
    End Function

    ' Recorrer la cola y mostrar los valores
    Public Sub Recorrer()
        Dim actual As clsNodo = Primero
        While actual IsNot Nothing
            Console.WriteLine(actual.Dato)
            actual = actual.Siguiente
        End While
    End Sub
End Class
