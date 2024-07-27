Imports javax.transaction.xa

Public Class frmUsuario
    Public pID As String
    Private objUtil As Utilitarios
    Private objNegocios As Usuarios

    Private Function validar() As Boolean
        Try
            If Not objUtil.validaTxtLleno(txtUsuario) Then
                Throw New Exception("Ingrese un usuario")
            End If

            If Not objUtil.validaTxtLleno(txtContrasena) Then
                Throw New Exception("Ingrese una contraseña")
            End If

            If Not objUtil.validaCboSeleccionado(cboRol) Then
                Throw New Exception("Seleccione un rol")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargar()
        Try
            cboRol.Items.Clear()
            cboRol.Items.Add("admin")
            cboRol.Items.Add("user")

            If Not String.IsNullOrEmpty(pID) Then
                txtUsuario.Enabled = False
                Dim obj As Usuario = objNegocios.getUsuario(pID)
                txtUsuario.Text = obj.Usuario
                txtContrasena.Text = objUtil.Decifrar(obj.Contrasena)
                cboRol.SelectedItem = obj.Rol
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objUtil = New Utilitarios
            objNegocios = New Usuarios
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
                Dim obj As New Usuario(txtUsuario.Text.Trim, objUtil.Cifrar(txtContrasena.Text.Trim), cboRol.SelectedItem.ToString)
                If String.IsNullOrEmpty(pID) Then
                    objNegocios.Agregar(obj)
                    MsgBox.Info("Se ha agregado el usuario")
                Else
                    objNegocios.Modificar(obj)
                    MsgBox.Info("Se ha modificado el usuario")
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class