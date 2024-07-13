Public Class frmHistorial
    Private objNegocios As Facturas
    Private objTiquete As Tiquete
    Private objProductoOrdenes As ProductoOrdenes

    Private Sub cargar()
        Try
            objNegocios.getHistorial(lstDatos)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub frmHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objNegocios = New Facturas
            objTiquete = New Tiquete
            objProductoOrdenes = New ProductoOrdenes
            cargar()
            chkCedula.Visible = False
            chkNombre.Visible = False
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim vNombre As String = ""
            Dim vCedula As String = ""

            If lstDatos.SelectedItems.Count = 0 Then
                Throw New Exception("Debe seleccionar el registro a imprimir")
            End If

            Dim obj As Factura = objNegocios.getFactura(Me.lstDatos.SelectedItems(0).SubItems(0).Text.ToString)

            If chkCedula.Checked AndAlso Me.lstDatos.SelectedItems(0).SubItems(1).Text.ToString.Length > 0 Then
                vCedula = Me.lstDatos.SelectedItems(0).SubItems(1).Text.ToString
            Else
                vCedula = ""
            End If

            If chkNombre.Checked AndAlso Me.lstDatos.SelectedItems(0).SubItems(2).Text.ToString.Length > 0 Then
                vNombre = Me.lstDatos.SelectedItems(0).SubItems(2).Text.ToString
            ElseIf chkNombre.Checked Then
                vNombre = Me.lstDatos.SelectedItems(0).SubItems(1).Text.ToString
            End If



            objTiquete.getTiquete(objProductoOrdenes.GetProductosByFactura(obj.idFactura), obj.fecha, obj.idFactura.ToString, vNombre, vCedula, obj.descuento)
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub lstDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDatos.SelectedIndexChanged
        Try
            If lstDatos.SelectedItems.Count > 0 Then

                Dim vFlagCed As Boolean = (Me.lstDatos.SelectedItems(0).SubItems(2).Text.ToString.Trim.Length > 0)
                chkCedula.Checked = False
                chkCedula.Visible = vFlagCed

                Dim vFlagNom As Boolean = (Me.lstDatos.SelectedItems(0).SubItems(1).Text.ToString.Trim.Length > 0)
                chkNombre.Checked = False
                chkNombre.Visible = vFlagNom

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class