Imports System.ComponentModel

Public Class frmFacturas
    Private objCliente As Cliente
    Private objOrdenes As Ordenes
    Private objProductosOrdenes As ProductoOrdenes
    Private objUtil As Utilitarios
    Private objTiquete As Tiquete

    Private vNumeroFactura As String
    Private vFechaFactura As String

    Public frmPadre As frmPrincipal

    Public Sub confirmarPago(impCedula As Boolean, impNombre As Boolean, pDescuento As Decimal, pUser As String)
        Try
            limpiarVariables()
            Dim objClientes As New Clientes
            objCliente = objClientes.getCliente(lblNombre.Text.Substring(lblNombre.Text.IndexOf("-") + 1))
            crearFactura(pDescuento, pUser)
            modificarDetalles()
            imprimir(impCedula, impNombre, pDescuento)
            MsgBox.Info("Se ha realizado la factura")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub limpiarVariables()
        Try
            vNumeroFactura = ""
            vFechaFactura = ""
            objCliente = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub limpiarPantalla()
        Try
            lblNombre.Text = "-"
            lblSubtotal.Text = 0
            lstProdFactura.Items.Clear()
            lstProdPendientes.Items.Clear()
            cargarOrdenesPendientes()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub crearFactura(pDescuento As Decimal, pUser As String)
        Try
            Dim obj As New Factura(0, lblNombre.Text.Remove(lblNombre.Text.IndexOf("-")), pUser, objUtil.getHora, calcularSubtotal(), pDescuento, objCliente.Cedula)
            vNumeroFactura = objProductosOrdenes.agregarFactura(obj)
            vFechaFactura = obj.fecha
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub modificarDetalles()
        Try
            Dim vDetalles As New List(Of Integer)()
            For Each item As ListViewItem In lstProdFactura.Items
                vDetalles.Add(CInt(item.SubItems(0).Text))
            Next


            objProductosOrdenes.pagarDetalles(vNumeroFactura, vDetalles)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub imprimir(impCedula As Boolean, impNombre As Boolean, pDescuento As Decimal)
        Try
            Dim vNombre As String = ""
            Dim vCedula As String = ""

            If impNombre Then
                vNombre = objCliente.Nombre
            End If
            If impCedula Then
                vCedula = objCliente.Cedula
            End If

            objTiquete.getTiquete(objProductosOrdenes.GetProductosByFactura(vNumeroFactura), vFechaFactura, vNumeroFactura.ToString, vNombre, vCedula, pDescuento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function contarProductosFacturas() As Integer
        Try
            Dim vContador As Integer = 0
            For Each item As ListViewItem In lstProdFactura.Items
                vContador += 1
            Next
            Return vContador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function calcularSubtotal() As Decimal
        Try
            Dim vSubtotal As Decimal = 0
            For Each item As ListViewItem In lstProdFactura.Items
                vSubtotal += Convert.ToDecimal(item.SubItems(2).Text)
            Next
            lblSubtotal.Text = vSubtotal
            Return vSubtotal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExisteID(idBuscado As Long) As Boolean
        For Each item As ListViewItem In lstProdFactura.Items
            If item.SubItems(0).Text = idBuscado Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub agregaItemAFactura(item As ListViewItem)
        Try
            If Not ExisteID(item.SubItems(0).Text.ToString) Then
                Dim nuevoItem As New ListViewItem(item.SubItems(0).Text.ToString)
                nuevoItem.SubItems.Add(item.SubItems(1).Text.ToString)
                nuevoItem.SubItems.Add(item.SubItems(2).Text.ToString)
                lstProdFactura.Items.Add(nuevoItem)
            End If

            calcularSubtotal()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub setColumnasProductos(plst As ListView)
        Try
            plst.Clear()
            plst.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID", .Width = 30},
                New ColumnHeader() With {.Text = "Nombre", .Width = 175},
                New ColumnHeader() With {.Text = "Subtotal", .Width = 95}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cargarOrdenesPendientes()
        Try
            objOrdenes.cargarOrdenesPendientes(lstOrdenPendientes)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cargarProductos(pId As Long)
        Try
            objProductosOrdenes.GetProductosByOrden(pId, lstProdPendientes)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objOrdenes = New Ordenes
            objProductosOrdenes = New ProductoOrdenes
            objUtil = New Utilitarios
            objTiquete = New Tiquete
            setColumnasProductos(lstProdPendientes)
            setColumnasProductos(lstProdFactura)
            cargarOrdenesPendientes()
            vNumeroFactura = ""
            vFechaFactura = ""
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstOrdenPendientes_DoubleClick(sender As Object, e As EventArgs) Handles lstOrdenPendientes.DoubleClick
        Try
            lblNombre.Text = Me.lstOrdenPendientes.SelectedItems(0).SubItems(0).Text.ToString & "-" & Me.lstOrdenPendientes.SelectedItems(0).SubItems(1).Text.ToString
            cargarProductos(CLng(lstOrdenPendientes.SelectedItems(0).SubItems(0).Text.ToString))
            lstProdFactura.Items.Clear()
            lblSubtotal.Text = 0
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstProdPendientes_DoubleClick(sender As Object, e As EventArgs) Handles lstProdPendientes.DoubleClick
        Try
            agregaItemAFactura(lstProdPendientes.SelectedItems(0))
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarTodo.Click
        Try
            For Each item As ListViewItem In lstProdPendientes.Items
                agregaItemAFactura(item)
            Next
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If lstProdFactura.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a quitar")
            End If

            lstProdFactura.Items.RemoveAt(lstProdFactura.SelectedIndices(0))
            calcularSubtotal()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Try
            If contarProductosFacturas() > 0 Then
                Dim frm As New frmCrearFactura
                frm.vSubtototal = lblSubtotal.Text
                frm.setPadre(Me)
                frm.ShowDialog()
                limpiarPantalla()
            Else
                Throw New Exception("No hay productos seleccionados para facturar")
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub frmFacturas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            frmPadre.cargarLista()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class