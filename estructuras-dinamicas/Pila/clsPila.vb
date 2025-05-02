Public Class clsPila
    Public Primero As clsNodo2

    Public Sub Agregar(Nuevo As clsNodo2)
        If Primero Is Nothing Then
            Primero = Nuevo
        Else
            Nuevo.Siguiente = Primero
            Primero = Nuevo
        End If
    End Sub

    Public Sub Eliminar()
        If Primero IsNot Nothing Then
            Primero = Primero.Siguiente
        End If
    End Sub

    Public Sub Recorrer(grilla As DataGridView)
        Dim aux As clsNodo2 = Primero
        grilla.Rows.Clear()
        While aux IsNot Nothing
            grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite)
            aux = aux.Siguiente
        End While
    End Sub
End Class
