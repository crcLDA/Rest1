Public Class frmConversion
    Private objUtil As Utilitarios
    Private objConversiones As Conversiones
    Private objProdOrdenes As ProductoOrdenes
    Private objIngredientes As Ingredientes
    Private listadoProductos As List(Of Producto)
    Private idProducto As Integer

    Public Function getNombreIngrediente(ByVal id As Integer) As String
        Try
            For Each item In cboInsumo.Items
                Dim ingrediente = CType(item, Ingrediente)
                If ingrediente.IdIngrediente = id Then
                    Return ingrediente.Nombre
                End If
            Next
            Return Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub setUoC(UoC As Decimal)
        txtUoC.Text = UoC
    End Sub

    Public Sub validar()
        Try
            txtUoC.Text = txtUoC.Text.Trim.Replace(".", ",")

            If Not objUtil.validaTxtDecimal(txtUoC) Then
                Throw New Exception("Ingrese una conversion correcta")
            End If
            If idProducto = 0 Then
                Throw New Exception("Seleccione un producto")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargar()
        Try
            cargarListadoProductos()
            objIngredientes.cargarCBO(Me.cboInsumo)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cargarListadoProductos()
        Try
            lstProductos.Clear()
            listadoProductos = objProdOrdenes.cargarLstProductos
            If listadoProductos.Count > 0 Then
                lstProductos.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "ID", .Width = 40},
                    New ColumnHeader() With {.Text = "Nombre", .Width = 230}
                })

                For Each vProducto As Producto In listadoProductos
                    If vProducto.Nombre.ToLower.Contains(txtFiltro.Text.Trim) Then
                        Dim item As New ListViewItem(vProducto.IdProducto)
                        item.SubItems.Add(vProducto.Nombre)

                        lstProductos.Items.Add(item)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarListadoConversiones()
        Try
            btnAgregar.Text = "Agregar"

            lstConversiones.Clear()
            Dim lista As List(Of Conversion) = objConversiones.cargarLstConversiones(idProducto)
            If lista.Count > 0 Then
                lstConversiones.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "Id Producto", .Width = 5},
                    New ColumnHeader() With {.Text = "Id Ingrediente", .Width = 5},
                    New ColumnHeader() With {.Text = "Ingrediente", .Width = 235},
                    New ColumnHeader() With {.Text = "Conversion", .Width = 50}
                })

                For Each vConversion As Conversion In lista
                    Dim item As New ListViewItem(vConversion.IdProducto)
                    item.SubItems.Add(vConversion.IdIngrediente)
                    item.SubItems.Add(getNombreIngrediente(vConversion.IdIngrediente))
                    item.SubItems.Add(vConversion.Conversion)
                    lstConversiones.Items.Add(item)
                Next
            End If
            txtUoC.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub limpiarVariables()
        Try
            lblProducto.Text = "."
            idProducto = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objUtil = New Utilitarios
            objConversiones = New Conversiones
            objProdOrdenes = New ProductoOrdenes
            objIngredientes = New Ingredientes
            cargar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Try
            cargarListadoProductos()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstProductos_DoubleClick(sender As Object, e As EventArgs) Handles lstProductos.DoubleClick
        Try
            lblProducto.Text = Me.lstProductos.SelectedItems(0).SubItems(1).Text.ToString
            idProducto = CInt(Me.lstProductos.SelectedItems(0).SubItems(0).Text.ToString)
            cargarListadoConversiones()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            validar()

            If btnAgregar.Text = "Agregar" Then
                If Not objConversiones.existe(New Conversion(idProducto, cboInsumo.SelectedValue, 0)) Then
                    objConversiones.Agregar(New Conversion(idProducto, cboInsumo.SelectedValue, Decimal.Parse(txtUoC.Text.Trim)))
                    cargarListadoConversiones()
                Else
                    Throw New Exception("La conversion de producto-ingrediente ya existe")
                End If
            End If
            If btnAgregar.Text = "Modificar" Then
                objConversiones.Modificar(New Conversion(idProducto, cboInsumo.SelectedValue, Decimal.Parse(txtUoC.Text.Trim)))
                cargarListadoConversiones()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstConversiones_DoubleClick(sender As Object, e As EventArgs) Handles lstConversiones.DoubleClick
        Try
            Dim conv As Conversion = objConversiones.getConversion(New Conversion(idProducto, CInt(Me.lstConversiones.SelectedItems(0).SubItems(1).Text.ToString), 0))
            cboInsumo.SelectedValue = conv.IdIngrediente
            txtUoC.Text = conv.Conversion
            btnAgregar.Text = "Modificar"
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub cboInsumo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboInsumo.SelectedValueChanged
        Try
            btnAgregar.Text = "Agregar"
            txtUoC.Text = ""
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnObtenerConversion_Click(sender As Object, e As EventArgs) Handles btnObtenerConversion.Click
        Try
            Dim frm As New frmCalcularConversion
            frm.frmPadre = Me
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Try
            If lstConversiones.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a eliminar")
            End If

            If MsgBox.YesNo("¿Desea eliminar el registro?") = MsgBox.YesResponse Then
                objConversiones.Eliminar(New Conversion(idProducto, cboInsumo.SelectedValue, 0))
                cargarListadoConversiones()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class