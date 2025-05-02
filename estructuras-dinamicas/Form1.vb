Public Class Form1
    Private Sub DatosDelDesarrolladorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelDesarrolladorToolStripMenuItem.Click
        FormDatosDelDesarrollador.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ColaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColaToolStripMenuItem.Click
        FormCola.Show()
    End Sub

    Private Sub PilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilaToolStripMenuItem.Click
        FormPila.Show()
    End Sub

    Private Sub ListaEnlazadaSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaEnlazadaSimpleToolStripMenuItem.Click
        FormListaEnlazadaSimple.Show()
    End Sub

    Private Sub ListaDoblementeEnlazadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDoblementeEnlazadaToolStripMenuItem.Click
        FormListaDoblementeEnlazada.Show()
    End Sub

    Private Sub ArbolBinarioDeBúsquedaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArbolBinarioDeBúsquedaToolStripMenuItem1.Click
        FormArbolBinario.Show()
    End Sub

    Private Sub GrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrafoToolStripMenuItem.Click
        FormGrafo.Show()
    End Sub
End Class
