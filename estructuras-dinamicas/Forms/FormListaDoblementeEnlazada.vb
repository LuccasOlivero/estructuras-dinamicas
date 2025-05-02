Public Class formListaDoblementeEnlazada
    Dim lista As New clsListaDoble()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New clsNodo()
        nvo.Codigo = CInt(txtCodigo.Text)
        nvo.Nombre = txtNombre.Text
        nvo.Tramite = txtTramite.Text
        lista.Agregar(nvo)
        lista.Recorrer(dgvLista)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If IsNumeric(txtCodigo.Text) Then
            Dim codigo As Integer = CInt(txtCodigo.Text)
            lista.Eliminar(codigo)
            lista.Recorrer(dgvLista)
        Else
            MessageBox.Show("ingresa un código numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAscendente_Click(sender As Object, e As EventArgs) Handles btnAscendente.Click
        lista.Recorrer(dgvLista)
    End Sub

    Private Sub btnDescendente_Click(sender As Object, e As EventArgs) Handles btnDescendente.Click
        lista.RecorrerDes(dgvLista)
    End Sub

End Class