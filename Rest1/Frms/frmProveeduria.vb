Public Class frmProveeduria
    Private vIdIngrediente As Integer
    Private vIdProveedor As Integer

    Private objUtil As Utilitarios
    Private objIngredientes As Ingredientes
    Private objProveedores As Proveedores
    Private objProveedurias As Proveedurias

    Private listadoIngredientes As List(Of Ingrediente)
    Private listadoProveedores As List(Of Proveedor)

    Private Sub limpiarProveedor()
        Try
            vIdProveedor = 0
            lblProveedorSelec.Text = "."
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub validar()
        Try
            If vIdIngrediente = 0 Then
                Throw New Exception("Seleccione un ingrediente")
            End If

            If vIdProveedor = 0 Then
                Throw New Exception("Seleccione un proveedor")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargar()
        Try
            listadoIngredientes = objIngredientes.getIngredientes
            listadoProveedores = objProveedores.getProveedores
            cargarListadoIngredientes()
            cargarListadoProveedores()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cargarListadoProveedores()
        Try
            lstProveedores.Clear()

            If listadoProveedores.Count > 0 Then
                lstProveedores.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "ID", .Width = 40},
                    New ColumnHeader() With {.Text = "Nombre", .Width = 230}
                })

                For Each vProveedor As Proveedor In listadoProveedores
                    If vProveedor.Nombre.ToLower.Contains(txtFiltroProveedor.Text.Trim) Then
                        Dim item As New ListViewItem(vProveedor.IdProveedor)
                        item.SubItems.Add(vProveedor.Nombre)

                        lstProveedores.Items.Add(item)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarListadoIngredientes()
        Try
            lstIngredientes.Clear()

            If listadoIngredientes.Count > 0 Then
                lstIngredientes.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "ID", .Width = 40},
                    New ColumnHeader() With {.Text = "Nombre", .Width = 230}
                })

                For Each vIngrediente As Ingrediente In listadoIngredientes
                    If vIngrediente.Nombre.ToLower.Contains(txtFiltroIngrediente.Text.Trim) Then
                        Dim item As New ListViewItem(vIngrediente.IdIngrediente)
                        item.SubItems.Add(vIngrediente.Nombre)

                        lstIngredientes.Items.Add(item)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarListadoProveeduria()
        Try
            objProveedurias.cargarLstProveeduriaByIngrediente(vIdIngrediente, lstProveeduria)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmProveeduria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objUtil = New Utilitarios
            objIngredientes = New Ingredientes
            objProveedores = New Proveedores
            objProveedurias = New Proveedurias
            cargar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub txtFiltroIngrediente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroIngrediente.TextChanged
        Try
            cargarListadoIngredientes()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub txtFiltroProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroProveedor.TextChanged
        Try
            cargarListadoProveedores()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstIngredientes_DoubleClick(sender As Object, e As EventArgs) Handles lstIngredientes.DoubleClick
        Try
            lblIngredienteSelec.Text = Me.lstIngredientes.SelectedItems(0).SubItems(1).Text.ToString
            vIdIngrediente = CInt(Me.lstIngredientes.SelectedItems(0).SubItems(0).Text.ToString)
            cargarListadoProveeduria()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstProveedores_DoubleClick(sender As Object, e As EventArgs) Handles lstProveedores.DoubleClick
        Try
            lblProveedorSelec.Text = Me.lstProveedores.SelectedItems(0).SubItems(1).Text.ToString
            vIdProveedor = CInt(Me.lstProveedores.SelectedItems(0).SubItems(0).Text.ToString)
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            validar()

            If Not objProveedurias.existe(New Proveeduria(vIdIngrediente, vIdProveedor)) Then
                objProveedurias.Agregar(New Proveeduria(vIdIngrediente, vIdProveedor))
                cargarListadoProveeduria()
            Else
                Throw New Exception("El proveedor " & lblProveedorSelec.Text & " ya está agregado para el producto: " & lblIngredienteSelec.Text)
            End If

            limpiarProveedor()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Try
            If lstProveeduria.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a eliminar")
            End If

            If MsgBox.YesNo("¿Desea eliminar el registro?") = MsgBox.YesResponse Then
                objProveedurias.Eliminar(New Proveeduria(Me.lstProveeduria.SelectedItems(0).SubItems(0).Text.ToString, Me.lstProveeduria.SelectedItems(0).SubItems(1).Text.ToString))
                cargarListadoProveeduria()
            End If

            limpiarProveedor()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class