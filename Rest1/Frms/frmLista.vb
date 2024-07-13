Imports javax.naming.directory

Public Class frmLista
    Public vModo As String
    Dim objUtil As Utilitarios
    Dim objProductos As Productos
    Dim objClientes As Clientes

    Private Sub cargarLista()
        Try
            If Not String.IsNullOrEmpty(vModo) Then
                Select Case vModo
                    Case "Productos"
                        'btnEliminar.Visible = False
                        objProductos.cargarListView(lstDatos)
                    Case "Clientes"
                        objClientes.cargarListView(lstDatos)
                    Case Else
                        Throw New Exception("No se pudo validar el modo. CONTACTE A Anthony")
                End Select
            Else
                Throw New Exception("No se pudo validar el modo. CONTACTE A Anthony")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub agregar()
        Try
            If Not String.IsNullOrEmpty(vModo) Then
                Select Case vModo
                    Case "Productos"
                        Dim frm As New frmProducto
                        frm.ShowDialog()
                    Case "Clientes"
                        Dim frm As New frmCliente
                        frm.ShowDialog()
                End Select
                cargarLista()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub modificar()
        Try
            If lstDatos.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a modificar")
            End If

            Dim vID As String = Me.lstDatos.SelectedItems(0).SubItems(0).Text.ToString

            If Not String.IsNullOrEmpty(vModo) Then
                Select Case vModo
                    Case "Productos"
                        Dim frm As New frmProducto
                        frm.pID = vID
                        frm.ShowDialog()
                    Case "Clientes"
                        Dim frm As New frmCliente
                        frm.pID = vID
                        frm.ShowDialog()
                End Select
                cargarLista()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub eliminar()
        Try
            If lstDatos.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a eliminar")
            End If

            Dim vID As String = Me.lstDatos.SelectedItems(0).SubItems(0).Text.ToString
            Dim vNombre As String = Me.lstDatos.SelectedItems(0).SubItems(1).Text.ToString

            If Not String.IsNullOrEmpty(vModo) Then
                If MsgBox.YesNo("¿Desea eliminar " & vNombre & "?") = MsgBox.YesResponse Then
                    Select Case vModo
                        Case "Productos"
                            objProductos.Eliminar(vID)
                        Case "Clientes"
                            objClientes.Eliminar(vID)
                    End Select
                    MsgBox.Info("Se ha eliminado el registro.")
                    cargarLista()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub consultar()
        Try
            If lstDatos.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a consultar")
            End If

            If Not String.IsNullOrEmpty(vModo) Then
                Select Case vModo
                    Case "Productos"
                        Dim obj As Producto = objProductos.ConsultarID(Me.lstDatos.SelectedItems(0).SubItems(0).Text.ToString)
                        MsgBox.Info(obj.Info)
                    Case "Clientes"
                        Dim obj As Cliente = objClientes.getCliente(Me.lstDatos.SelectedItems(0).SubItems(0).Text.ToString)
                        MsgBox.Info(obj.Info)
                End Select
            End If

            Me.lstDatos.SelectedItems.Clear()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            objUtil = New Utilitarios
            objProductos = New Productos
            objClientes = New Clientes

            cargarLista()
        Catch ex As Exception
            MsgBox.Error(ex)
            Me.Close()
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            consultar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            agregar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            modificar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            eliminar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class