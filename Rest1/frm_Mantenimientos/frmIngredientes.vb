Public Class frmIngredientes
    Private objUtil As Utilitarios
    Private objNegocios As Ingredientes
    Public pID As String

    Private Function validar() As Boolean
        Try
            txtExistencias.Text = txtExistencias.Text.Replace(".", ",")

            If Not objUtil.validaTxtLleno(txtNombre) Then
                Throw New Exception("Ingrese un nombre")
            End If

            If objUtil.validaTxtLleno(txtExistencias) Then
                If Not objUtil.validaTxtDecimal(txtExistencias) Then
                    Throw New Exception("La existencias debe ser números")
                End If
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargar()
        Try
            txtId.Enabled = False

            If Not String.IsNullOrEmpty(pID) Then
                Dim obj As Ingrediente = objNegocios.getIngrediente(pID)
                txtId.Text = obj.IdIngrediente
                txtNombre.Text = obj.Nombre
                txtExistencias.Text = obj.Existencias
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmIngredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objUtil = New Utilitarios
            objNegocios = New Ingredientes
            cargar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If validar() Then
                Dim obj As New Ingrediente(Integer.Parse(txtId.Text.Trim), txtNombre.Text.Trim, Decimal.Parse(txtExistencias.Text.Trim))
                If pID = 0 Then
                    objNegocios.Agregar(obj)
                    MsgBox.Info("Se ha agregado el ingrediente")
                Else
                    objNegocios.Modificar(obj)
                    MsgBox.Info("Se ha modificado el ingrediente")
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class