Imports com.sun.imageio.plugins.gif
Imports javax.security.auth.login

Public Class frmLogin
    Dim objUtil As Utilitarios
    Dim objNeg As Usuarios

    Private Function validar() As Boolean
        Try
            If txtUsuario.Text.Trim.Length = 0 Then
                Throw New Exception("Ingrese un usuario")
            End If
            If txtContrasena.Text.Trim.Length = 0 Then
                Throw New Exception("Ingrese una contraseña")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objNeg = New Usuarios
            objUtil = New Utilitarios
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If validar() Then
                If objNeg.validateLogin(txtUsuario.Text.ToLower.Trim, objUtil.Cifrar(txtContrasena.Text)) Then
                    GlobalVariables.user = objNeg.getUsuario(txtUsuario.Text.Trim)
                    Dim frm As New frmPrincipal
                    frm.frm = Me
                    frm.Show()
                    Me.Visible = False
                Else
                    Throw New LoginException("Usuario y/o contraseña incorrectos.")
                End If
            End If
            txtContrasena.Text = objUtil.Cifrar(txtUsuario.Text)
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub txtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasena.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                btnIniciar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class