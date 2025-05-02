<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDelDesarrolladorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstrucutrasLinealesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaEnlazadaSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDoblementeEnlazadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrafoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.EstrucutrasLinealesToolStripMenuItem, Me.ArbolBinarioDeBúsquedaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelDesarrolladorToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'DatosDelDesarrolladorToolStripMenuItem
        '
        Me.DatosDelDesarrolladorToolStripMenuItem.Name = "DatosDelDesarrolladorToolStripMenuItem"
        Me.DatosDelDesarrolladorToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DatosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador"
        '
        'EstrucutrasLinealesToolStripMenuItem
        '
        Me.EstrucutrasLinealesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColaToolStripMenuItem, Me.PilaToolStripMenuItem, Me.ListaEnlazadaSimpleToolStripMenuItem, Me.ListaDoblementeEnlazadaToolStripMenuItem})
        Me.EstrucutrasLinealesToolStripMenuItem.Name = "EstrucutrasLinealesToolStripMenuItem"
        Me.EstrucutrasLinealesToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.EstrucutrasLinealesToolStripMenuItem.Text = "Estrucutras lineales"
        '
        'ColaToolStripMenuItem
        '
        Me.ColaToolStripMenuItem.Name = "ColaToolStripMenuItem"
        Me.ColaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ColaToolStripMenuItem.Text = "Cola.."
        '
        'PilaToolStripMenuItem
        '
        Me.PilaToolStripMenuItem.Name = "PilaToolStripMenuItem"
        Me.PilaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.PilaToolStripMenuItem.Text = "Pila.."
        '
        'ListaEnlazadaSimpleToolStripMenuItem
        '
        Me.ListaEnlazadaSimpleToolStripMenuItem.Name = "ListaEnlazadaSimpleToolStripMenuItem"
        Me.ListaEnlazadaSimpleToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ListaEnlazadaSimpleToolStripMenuItem.Text = "Lista enlazada simple.."
        '
        'ListaDoblementeEnlazadaToolStripMenuItem
        '
        Me.ListaDoblementeEnlazadaToolStripMenuItem.Name = "ListaDoblementeEnlazadaToolStripMenuItem"
        Me.ListaDoblementeEnlazadaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ListaDoblementeEnlazadaToolStripMenuItem.Text = "Lista doblemente enlazada"
        '
        'ArbolBinarioDeBúsquedaToolStripMenuItem
        '
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArbolBinarioDeBúsquedaToolStripMenuItem1, Me.GrafoToolStripMenuItem})
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem.Name = "ArbolBinarioDeBúsquedaToolStripMenuItem"
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem.Text = "Estructuras ramificadas"
        '
        'ArbolBinarioDeBúsquedaToolStripMenuItem1
        '
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem1.Name = "ArbolBinarioDeBúsquedaToolStripMenuItem1"
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.ArbolBinarioDeBúsquedaToolStripMenuItem1.Text = "Arbol binario de búsqueda"
        '
        'GrafoToolStripMenuItem
        '
        Me.GrafoToolStripMenuItem.Name = "GrafoToolStripMenuItem"
        Me.GrafoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GrafoToolStripMenuItem.Text = "Grafo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDelDesarrolladorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstrucutrasLinealesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PilaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaEnlazadaSimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDoblementeEnlazadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArbolBinarioDeBúsquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArbolBinarioDeBúsquedaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GrafoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
