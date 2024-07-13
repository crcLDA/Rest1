Public Class frmCrearFactura
    Public vSubtototal As Int32
    Private vDescuento As Int32
    Private frmPadre1 As frmFacturas
    Private frmPadre2 As frmOrdenes

    Public Sub setPadre(frm As frmFacturas)
        Try
            frmPadre1 = frm
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub setPadre(frm As frmOrdenes)
        Try
            frmPadre2 = frm
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub back()
        Try
            Dim vUser As String = ""
            If GlobalVariables.user IsNot Nothing Then
                vUser = GlobalVariables.user.Usuario
            End If

            If frmPadre1 IsNot Nothing Then
                frmPadre1.confirmarPago(chkCedula.Checked, chkNombre.Checked, vDescuento, vUser)
            ElseIf frmPadre2 IsNot Nothing Then
                frmPadre2.confirmarPago(chkCedula.Checked, chkNombre.Checked, vDescuento, vUser)
            Else
                Throw New Exception("Error al generar factura. [At back method]")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function calculaTotal()
        Try
            vDescuento = 0
            Integer.TryParse(txtDescuento.Text, vDescuento)

            txtTotal.Text = vSubtototal - vDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub validaVuelto()
        Try
            Dim vVuelto As Decimal = 0
            Dim vPago As Int32 = 0

            If txtDescuento.Text.Trim.Length = 0 Then
                txtDescuento.Text = 0
            End If
            If txtPago.Text.Trim.Length = 0 Then
                txtPago.Text = 0
            End If

            Integer.TryParse(txtPago.Text, vPago)

            If CInt(txtDescuento.Text) > vSubtototal Then
                Throw New Exception("El descuento no puede ser mayor a la cantidad a pagar")
            End If

            If vPago <> 0 Then
                If vPago < CInt(txtTotal.Text) Then
                    Throw New Exception("El pago no es suficiente para cubrir el monto de la factura")
                End If
                If vPago > CInt(txtTotal.Text) Then
                    vVuelto = vPago - CInt(txtTotal.Text)
                    MsgBox.Info("El vuelto es: " & vVuelto)
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Try
            validaVuelto()
            back()
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub frmCrearFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSubtotal.Text = vSubtototal
            txtTotal.Text = vSubtototal
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        Try
            calculaTotal()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class