Public Class frmCategoria
    Public pID As Int32
    Private objUtil As Utilitarios
    Private objNegocios As Categorias

    Private Function validar() As Boolean
        Try
            If Not objUtil.validaTxtLleno(txtNombre) Then
                Throw New Exception("Ingrese un nombre")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargar()
        Try
            txtId.Enabled = False

            If pID <> 0 Then
                Dim obj As Categoria = objNegocios.getCategoria(pID)
                txtId.Text = obj.IdCategoria
                txtNombre.Text = obj.Descripcion
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objUtil = New Utilitarios
            objNegocios = New Categorias
            cargar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If validar() Then
                Dim obj As New Categoria(Integer.Parse(txtId.Text.Trim), txtNombre.Text.Trim)
                If pID = 0 Then
                    objNegocios.Agregar(obj)
                    MsgBox.Info("Se ha agregado la categoría")
                Else
                    objNegocios.Modificar(obj)
                    MsgBox.Info("Se ha modificado la categoría")
                End If
                Me.Close()
            End If
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
End Class