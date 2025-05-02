Public Class FormPila
    Private pila As New clsPila()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevoNodo As New clsNodo2 With {
            .Codigo = Val(txtCodigo.Text),
            .Nombre = txtNombre.Text,
            .Tramite = txtTramite.Text
        }

        pila.Agregar(nuevoNodo)
        LimpiarCampos()
        pila.Recorrer(dgvPila)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        pila.Eliminar()
        pila.Recorrer(dgvPila)
    End Sub

    Private Sub LimpiarCampos()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtTramite.Clear()
        txtCodigo.Focus()
    End Sub
End Class