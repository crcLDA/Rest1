Public Class frmCalcularConversion
    Public frmPadre As frmConversion

    Private Sub calcular()
        Try
            Dim porciones As Integer = CInt(txtPorciones.Text.Trim)
            Dim conversion As Decimal = (1 / porciones)
            txtConversion.Text = conversion
        Catch ex As Exception
            txtConversion.Text = 0
        End Try
    End Sub

    Private Sub frmCalcularConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtConversion.Enabled = False
            txtConversion.Text = 0
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            frmPadre.setUoC(0)
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            frmPadre.setUoC(Decimal.Parse(txtConversion.Text))
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub txtPorciones_TextChanged(sender As Object, e As EventArgs) Handles txtPorciones.TextChanged
        Try
            calcular()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class