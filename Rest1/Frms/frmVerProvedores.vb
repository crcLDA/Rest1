Public Class frmVerProvedores
    Private objProveedurias As Proveedurias
    Private objIngredientes As Ingredientes
    Private objProveedores As Proveedores

    Private listadoIngredientes As List(Of Ingrediente)
    Private listadoProveedores As List(Of Proveedor)

    Private porIngrediente As Boolean

    Private Sub cargarModo()
        Try
            lstResultados.Clear()
            lstFiltro.Clear()

            If porIngrediente Then
                btnIngrediente.BackColor = Color.Gray
                btnProveedor.BackColor = Button.DefaultBackColor
                cargarListadoIngredientes()
            Else
                btnProveedor.BackColor = Color.Gray
                btnIngrediente.BackColor = Button.DefaultBackColor
                cargarListadoProveedores()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarResultados(vId As Integer)
        Try
            If porIngrediente Then
                objProveedurias.cargarLstProveeduriaByIngrediente(vId, lstResultados)
            Else
                objProveedurias.cargarLstProveeduriaByProveedor(vId, lstResultados)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarInfo()
        Try
            If porIngrediente Then
                Dim obj1 As Ingrediente = objIngredientes.getIngrediente(Me.lstResultados.SelectedItems(0).SubItems(0).Text.ToString)
                Dim obj2 As Proveedor = objProveedores.getProveedor(Me.lstResultados.SelectedItems(0).SubItems(1).Text.ToString)
                MsgBox.Info("INFORMACIÓN DEL PROVEERDOR" & vbCrLf & obj2.Info & vbCrLf & vbCrLf & "INFORMACIÓN DEL INGREDIENTE" & vbCrLf & obj1.Info)
            Else
                Dim obj1 As Proveedor = objProveedores.getProveedor(Me.lstResultados.SelectedItems(0).SubItems(0).Text.ToString)
                Dim obj2 As Ingrediente = objIngredientes.getIngrediente(Me.lstResultados.SelectedItems(0).SubItems(1).Text.ToString)
                MsgBox.Info("INFORMACIÓN DEL INGREDIENTE" & vbCrLf & obj2.Info & vbCrLf & vbCrLf & "INFORMACIÓN DEL PROVEEDOR" & vbCrLf & obj1.Info)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub cargarListadoProveedores()
        Try
            lstFiltro.Clear()

            If listadoProveedores.Count > 0 Then
                lstFiltro.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "ID", .Width = 40},
                    New ColumnHeader() With {.Text = "Nombre", .Width = 230}
                })

                For Each vProveedor As Proveedor In listadoProveedores
                    If vProveedor.Nombre.ToLower.Contains(txtFiltro.Text.Trim) Then
                        Dim item As New ListViewItem(vProveedor.IdProveedor)
                        item.SubItems.Add(vProveedor.Nombre)

                        lstFiltro.Items.Add(item)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarListadoIngredientes()
        Try
            lstFiltro.Clear()

            If listadoIngredientes.Count > 0 Then
                lstFiltro.Columns.AddRange(New ColumnHeader() {
                    New ColumnHeader() With {.Text = "ID", .Width = 40},
                    New ColumnHeader() With {.Text = "Nombre", .Width = 230}
                })

                For Each vIngrediente As Ingrediente In listadoIngredientes
                    If vIngrediente.Nombre.ToLower.Contains(txtFiltro.Text.Trim) Then
                        Dim item As New ListViewItem(vIngrediente.IdIngrediente)
                        item.SubItems.Add(vIngrediente.Nombre)

                        lstFiltro.Items.Add(item)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub frmVerProvedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objIngredientes = New Ingredientes
            objProveedores = New Proveedores
            objProveedurias = New Proveedurias

            listadoIngredientes = objIngredientes.getIngredientes
            listadoProveedores = objProveedores.getProveedores

            porIngrediente = True
            cargarModo()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnIngrediente_Click(sender As Object, e As EventArgs) Handles btnIngrediente.Click
        Try
            porIngrediente = True
            cargarModo()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        Try
            porIngrediente = False
            cargarModo()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstFiltro_DoubleClick(sender As Object, e As EventArgs) Handles lstFiltro.DoubleClick
        Try
            cargarResultados(Me.lstFiltro.SelectedItems(0).SubItems(0).Text.ToString)
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstResultados_DoubleClick(sender As Object, e As EventArgs) Handles lstResultados.DoubleClick
        Try
            cargarInfo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class