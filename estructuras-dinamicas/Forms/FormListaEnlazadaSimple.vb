Public Class FormListaEnlazadaSimple
    Dim lista As New ListaSimple()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nvo As New clsNodo(CInt(txtCodigo.Text))
        nvo.Nombre = txtNombre.Text
        nvo.Tramite = txtTramite.Text
        lista.Agregar(nvo)
        lista.Recorrer(dgvLista)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        lista.Eliminar(CInt(txtCodigo.Text))
        lista.Recorrer(dgvLista)
    End Sub


    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        lista.Recorrer(dgvLista)
    End Sub

    Private Sub FormListaEnlazadaSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.Columns.Add("Codigo", "Código")
        dgvLista.Columns.Add("Nombre", "Nombre")
        dgvLista.Columns.Add("Tramite", "Trámite")
    End Sub
End Class
