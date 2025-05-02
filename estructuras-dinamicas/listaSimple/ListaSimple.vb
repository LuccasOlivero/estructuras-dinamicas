Public Class ListaSimple
    Public Primero As clsNodo
    Public Sub Agregar(Nuevo As clsNodo)
        If Primero Is Nothing Then
            Primero = Nuevo
        Else
            If Nuevo.Codigo <= Primero.Codigo Then
                Nuevo.Siguiente = Primero
                Primero = Nuevo
            Else
                Dim aux As clsNodo = Primero
                Dim ant As clsNodo = Primero
                While aux IsNot Nothing AndAlso Nuevo.Codigo > aux.Codigo
                    ant = aux
                    aux = aux.Siguiente
                End While
                ant.Siguiente = Nuevo
                Nuevo.Siguiente = aux
            End If
        End If
    End Sub
    Public Sub Eliminar(Codigo As Integer)
        If Primero IsNot Nothing Then
            If Primero.Codigo = Codigo Then
                Primero = Primero.Siguiente
            Else
                Dim Ant As clsNodo = Primero
                Dim Aux As clsNodo = Primero
                While Aux IsNot Nothing AndAlso Aux.Codigo <> Codigo
                    Ant = Aux
                    Aux = Aux.Siguiente
                End While

                If Aux IsNot Nothing Then
                    Ant.Siguiente = Aux.Siguiente
                End If
            End If
        End If
    End Sub

    Public Sub Recorrer(Grilla As DataGridView)
        Dim aux As clsNodo = Primero
        Grilla.Rows.Clear()
        While aux IsNot Nothing
            Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite)
            aux = aux.Siguiente
        End While
    End Sub
End Class
