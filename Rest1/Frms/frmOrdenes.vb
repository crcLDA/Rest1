Imports System.ComponentModel

Public Class frmOrdenes
    Private objUtil As Utilitarios
    Private objProductos As Productos
    Private objNegocios As ProductoOrdenes
    Private listadoProductos As List(Of Producto)
    Private objTiquete As Tiquete

    Private vFechaFactura As String = ""
    Private vNumeroFactura As Long
    Private vNumeroOrden As Long

    Private vCedulaCliente As String
    Public frmPadre As frmPrincipal

    Public Sub confirmarPago(impCedula As Boolean, impNombre As Boolean, pDescuento As Decimal, pUser As String)
        Try
            Dim vNom, vCed As String
            vNom = "" : vCed = ""
            If impCedula Then
                vCed = vCedulaCliente
            End If
            If impNombre Then
                vNom = txtUsuario.Text
            End If

            limpiarVariables()
            validarDetallesOrden()
            crearOrden()
            crearFactura(pDescuento, pUser)
            crearDetallesOrden(True)
            objTiquete.getTiquete(objNegocios.GetProductosByFactura(vNumeroFactura), vFechaFactura, vNumeroFactura.ToString, vNom, vCed, pDescuento)
            LimpiarPantalla()
            MsgBox.Info("Se ha realizado la factura")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargar()
        Try
            lstPedido.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID", .Width = 5},
                New ColumnHeader() With {.Text = "Nombre", .Width = 281},
                New ColumnHeader() With {.Text = "Precio", .Width = 80}
            })

            cargarListado()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub setCliente(cedula As String, nombre As String)
        Try
            vCedulaCliente = cedula
            txtUsuario.Text = nombre
            Dim vAux As Boolean = (cedula.Trim.Length = 0)

            txtUsuario.Enabled = vAux
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarListado()
        Try
            lstProductos.Clear()
            listadoProductos = objProductos.getProductosActivos
            If listadoProductos.Count > 0 Then
                lstProductos.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "ID", .Width = 40},
                    New ColumnHeader() With {.Text = "Nombre", .Width = 230},
                    New ColumnHeader() With {.Text = "Precio", .Width = 80}
                })

                For Each vProducto As Producto In listadoProductos
                    ' Aquí puedes acceder a cada producto dentro de la lista
                    If vProducto.Nombre.ToLower.Contains(txtFiltro.Text.Trim) Then
                        Dim item As New ListViewItem(vProducto.IdProducto)
                        item.SubItems.Add(vProducto.Nombre)
                        item.SubItems.Add(vProducto.Precio)

                        lstProductos.Items.Add(item)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function calcularTotal() As Long
        Try
            Dim vTotal As Long = 0
            If lstPedido.Items.Count > 0 Then
                For Each item As ListViewItem In lstPedido.Items
                    vTotal += CInt(Decimal.Parse(item.SubItems(2).Text))
                Next
            End If

            lblTotal.Text = objUtil.FormatearNumeroConEspacios(vTotal)

            Return vTotal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function validar() As Boolean
        Try
            If Not objUtil.validaTxtLleno(txtUsuario) Then
                Throw New Exception("Ingrese un usuario para el pedido")
            End If
            If lstPedido.Items.Count = 0 Then
                Throw New Exception("Agregue al menos un producto al pedido")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub limpiarVariables()
        Try
            vNumeroOrden = 0
            vFechaFactura = ""
            vNumeroFactura = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarPantalla()
        Try
            lstPedido.Items.Clear()
            txtFiltro.Text = ""
            txtUsuario.Text = ""
            vCedulaCliente = ""
            lblTotal.Text = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub crearOrden()
        Try
            Dim vUsuario As String = txtUsuario.Text
            If vCedulaCliente.Trim.Length > 0 Then
                vUsuario = vCedulaCliente
            End If

            Dim obj As New Orden(0, vUsuario, objUtil.getHora)
            vNumeroOrden = objNegocios.agregarOrden(obj)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub validarDetallesOrden()
        Try
            Dim idDetalles As New List(Of Integer)

            For Each item As ListViewItem In lstPedido.Items
                idDetalles.Add(item.SubItems(0).Text)
            Next

            objNegocios.validaDisponibilidad(idDetalles)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub crearDetallesOrden(cancelado As Boolean)
        Try
            Dim vDetalles As New List(Of DetalleOrden)()

            For Each item As ListViewItem In lstPedido.Items
                Dim detalle As New DetalleOrden(0, vNumeroOrden, vNumeroFactura, CInt(item.SubItems(0).Text), CInt(item.SubItems(2).Text), cancelado)
                vDetalles.Add(detalle)
            Next

            objNegocios.agregarDetalles(vDetalles)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub crearFactura(pDescuento As Decimal, pUser As String)
        Try

            Dim obj As New Factura(0, vNumeroOrden, pUser, objUtil.getHora, calcularTotal(), pDescuento, vCedulaCliente)
            vNumeroFactura = objNegocios.agregarFactura(obj)
            vFechaFactura = obj.fecha
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            vCedulaCliente = ""
            objUtil = New Utilitarios
            objNegocios = New ProductoOrdenes
            objProductos = New Productos
            objTiquete = New Tiquete
            cargar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Try
            cargarListado()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstProductos_DoubleClick(sender As Object, e As EventArgs) Handles lstProductos.DoubleClick
        Try
            Dim item As New ListViewItem(Me.lstProductos.SelectedItems(0).SubItems(0).Text.ToString)
            item.SubItems.Add(Me.lstProductos.SelectedItems(0).SubItems(1).Text.ToString)
            item.SubItems.Add(Me.lstProductos.SelectedItems(0).SubItems(2).Text.ToString)

            lstPedido.Items.Add(item)

            calcularTotal()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If lstPedido.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el producto a eliminar")
            End If

            lstPedido.Items.Remove(lstPedido.SelectedItems(0))

            calcularTotal()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnCrearOrden_Click(sender As Object, e As EventArgs) Handles btnCrearOrden.Click
        Try
            If validar() Then
                limpiarVariables()
                validarDetallesOrden()
                crearOrden()
                crearDetallesOrden(False)
                LimpiarPantalla()
                MsgBox.Info("Se ha creado la orden")
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnCrearFactura_Click(sender As Object, e As EventArgs) Handles btnCrearFactura.Click
        Try
            If validar() Then
                Dim frm As New frmCrearFactura
                frm.vSubtototal = lblTotal.Text
                frm.setPadre(Me)
                frm.ShowDialog()
                LimpiarPantalla()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim frm As New frmListaClientes
            frm.frmParent = Me
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub frmOrdenes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            frmPadre.cargarLista()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class