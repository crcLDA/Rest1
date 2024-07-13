Public Class frmListaClientes
    Private objNegocios As Clientes
    Public frmParent As frmOrdenes

    Private Sub frmListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objNegocios = New Clientes
            objNegocios.cargarListViewSeleccionar(lstDatos)
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            frmParent.setCliente("", "")
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstDatos_DoubleClick(sender As Object, e As EventArgs) Handles lstDatos.DoubleClick
        Try
            If lstDatos.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a cargar")
            End If
            frmParent.setCliente(Me.lstDatos.SelectedItems(0).SubItems(0).Text.ToString, Me.lstDatos.SelectedItems(0).SubItems(1).Text.ToString)
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class