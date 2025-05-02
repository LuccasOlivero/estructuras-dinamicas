Public Class FormCola
    Private cola As New clsCola()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim valor As Integer
        If Integer.TryParse(txtValor.Text, valor) Then
            Dim nodo As New clsNodo(valor)
            cola.Agregar(nodo)
            txtValor.Clear()
            MostrarCola()
        Else
            MessageBox.Show("Ingrese un número válido.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            cola.Eliminar()
            MostrarCola()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarCola()
    End Sub

    Private Sub MostrarCola()
        Dim lista As New List(Of Integer)
        Dim actual As clsNodo = ObtenerPrimero()
        While actual IsNot Nothing
            lista.Add(actual.Dato)
            actual = actual.Siguiente
        End While
        dgvCola.DataSource = lista.Select(Function(x) New With {.Valor = x}).ToList()
    End Sub

    ' Función auxiliar para acceder al nodo Primero
    Private Function ObtenerPrimero() As clsNodo
        Dim tipoCola = cola.GetType()
        Dim campo = tipoCola.GetField("Primero", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        Return CType(campo.GetValue(cola), clsNodo)
    End Function
End Class