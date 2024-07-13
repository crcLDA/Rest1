Public Class frmCliente
    Private objUtil As Utilitarios
    Private objNegocios As Clientes
    Public pID As String

    Private Function validar() As Boolean
        Try
            If Not objUtil.validaTxtLleno(txtId) Then
                Throw New Exception("Ingrese una cédula")
            End If

            If Not objUtil.validaTxtInteger(txtId) Then
                Throw New Exception("La cédula debe contener solo números")
            End If

            If Not objUtil.validaTxtLleno(txtNombre) Then
                Throw New Exception("Ingrese un nombre")
            End If

            If objUtil.validaTxtLleno(txtTelefono) Then
                If Not objUtil.validaTxtInteger(txtTelefono) Then
                    Throw New Exception("El teléfono debe contener solo números")
                End If
            End If

            If String.IsNullOrEmpty(pId) Then ' Porque está ingresando uno nuevo
                If objNegocios.existe(txtId.Text) Then
                    Throw New Exception("El Id ingresado ya existe")
                End If
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargar()
        Try
            If Not String.IsNullOrEmpty(pId) Then
                Dim obj As Cliente = objNegocios.getCliente(pID)
                txtId.Text = obj.Cedula
                txtNombre.Text = obj.Nombre
                txtTelefono.Text = obj.Telefono
                txtId.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            objUtil = New Utilitarios
            objNegocios = New Clientes
            cargar()
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If validar() Then
                Dim obj As New Cliente(txtId.Text.Trim, txtNombre.Text.Trim, txtTelefono.Text.Trim)
                If String.IsNullOrEmpty(pId) Then
                    objNegocios.agregar(obj)
                    MsgBox.Info("Se ha agregado el cliente")
                Else
                    objNegocios.Modificar(obj)
                    MsgBox.Info("Se ha modificado el cliente")
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class