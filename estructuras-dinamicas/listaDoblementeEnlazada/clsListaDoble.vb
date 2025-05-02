Public Class clsListaDoble
    Private pri As clsNodo
    Private ult As clsNodo

    Public Property Primero As clsNodo
        Get
            Return pri
        End Get
        Set(value As clsNodo)
            pri = value
        End Set
    End Property

    Public Property Ultimo As clsNodo
        Get
            Return ult
        End Get
        Set(value As clsNodo)
            ult = value
        End Set
    End Property

    Public Sub Agregar(nvo As clsNodo)
        If pri Is Nothing Then
            pri = nvo
            ult = nvo
        Else
            If nvo.Codigo < pri.Codigo Then
                nvo.Siguiente = pri
                pri.Anterior = nvo
                pri = nvo
            ElseIf nvo.Codigo > ult.Codigo Then
                ult.Siguiente = nvo
                nvo.Anterior = ult
                ult = nvo
            Else
                Dim aux As clsNodo = pri
                Dim ant As clsNodo = pri
                While aux.Codigo < nvo.Codigo
                    ant = aux
                    aux = aux.Siguiente
                End While
                ant.Siguiente = nvo
                nvo.Siguiente = aux
                aux.Anterior = nvo
                nvo.Anterior = ant
            End If
        End If
    End Sub

    Public Sub Eliminar(codigo As Integer)
        If pri.Codigo = codigo AndAlso pri Is ult Then
            pri = Nothing
            ult = Nothing
        ElseIf pri.Codigo = codigo Then
            pri = pri.Siguiente
            pri.Anterior = Nothing
        ElseIf ult.Codigo = codigo Then
            ult = ult.Anterior
            ult.Siguiente = Nothing
        Else
            Dim aux As clsNodo = pri
            Dim ant As clsNodo = pri
            While aux.Codigo < codigo
                ant = aux
                aux = aux.Siguiente
            End While
            ant.Siguiente = aux.Siguiente
            aux = aux.Siguiente
            aux.Anterior = ant
        End If
    End Sub

    Public Sub Recorrer(grilla As DataGridView)
        Dim aux As clsNodo = pri
        grilla.Rows.Clear()
        While aux IsNot Nothing
            grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite)
            aux = aux.Siguiente
        End While
    End Sub

    Public Sub RecorrerDes(grilla As DataGridView)
        Dim aux As clsNodo = ult
        grilla.Rows.Clear()
        While aux IsNot Nothing
            grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite)
            aux = aux.Anterior
        End While
    End Sub
End Class
