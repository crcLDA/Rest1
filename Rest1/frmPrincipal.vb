Imports System.ComponentModel
Imports System.Drawing.Printing
Public Class frmPrincipal
    Private objOrdenes As Ordenes
    Public frm As frmLogin

    Public Sub cargarLista()
        Try
            objOrdenes.cargarOrdenesPendientes(lstPendientes)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            objOrdenes = New Ordenes
            cargarLista()
            lblUsuario.Text = "Usuario: " + GlobalVariables.getUser
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Try
            Dim frm As New frmCliente()
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Try
            Dim frm As New frmLista()
            frm.vModo = "Productos"
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Try
            Dim frm As New frmLista
            frm.vModo = "Clientes"
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnOrdenes_Click(sender As Object, e As EventArgs) Handles btnOrdenes.Click
        Try
            Dim frm As New frmOrdenes
            frm.frmPadre = Me
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Try
            Dim frm As New frmHistorial
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Try
            Dim frm As New frmFacturas
            frm.frmPadre = Me
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If lstPendientes.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a eliminar")
            End If

            If MsgBox.YesNo("¿Desea eliminar el pedido?") = MsgBox.YesResponse Then
                objOrdenes.EliminarPedido(lstPendientes.SelectedItems(0).SubItems(0).Text.ToString)
                MsgBox.Info("Pedido anulado")
                cargarLista()
            End If

        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        Try
            cargarLista()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If frm IsNot Nothing Then
                frm.Dispose()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Try
            Dim frm As New frmLista()
            frm.vModo = "Categorias"
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub IngredientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngredientesToolStripMenuItem.Click
        Try
            Dim frm As New frmLista()
            frm.vModo = "Ingredientes"
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Try
            Dim frm As New frmLista()
            frm.vModo = "Proveedores"
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Try
            Dim frm As New frmLista()
            frm.vModo = "Usuarios"
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub ConsumosStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumosStripMenuItem.Click
        Try
            Dim frm As New frmConversion()
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub ProveeduriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveeduriaToolStripMenuItem.Click
        Try
            Dim frm As New frmProveeduria()
            frm.Show()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub ProveeduríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveeduríaToolStripMenuItem.Click
        Try
            Dim frm As New frmVerProvedores
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class
