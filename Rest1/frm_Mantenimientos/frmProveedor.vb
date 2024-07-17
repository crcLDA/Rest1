Public Class frmProveedor
    Public pID As Int32
    Private objUtil As Utilitarios
    Private objNegocios As Proveedores

    Private Function validar() As Boolean
        Try
            If Not objUtil.validaTxtLleno(txtNombre) Then
                Throw New Exception("Ingrese un nombre")
            End If

            If Not objUtil.validaTxtLleno(txtTelefono) Then
                Throw New Exception("Ingrese un teléfono")
            End If

            If Not objUtil.validaTxtLleno(txtDireccion) Then
                Throw New Exception("Ingrese una direccion")
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
                Dim obj As Proveedor = objNegocios.getProveedor(pID)
                txtId.Text = obj.IdProveedor
                txtNombre.Text = obj.Nombre
                txtTelefono.Text = obj.Telefono
                txtDireccion.Text = obj.Direccion
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objUtil = New Utilitarios
            objNegocios = New Proveedores
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
                Dim obj As New Proveedor(Integer.Parse(txtId.Text.Trim), txtNombre.Text.Trim, txtTelefono.Text.Trim, txtDireccion.Text.Trim)
                If pID = 0 Then
                    objNegocios.Agregar(obj)
                    MsgBox.Info("Se ha agregado el proveedor")
                Else
                    objNegocios.Modificar(obj)
                    MsgBox.Info("Se ha modificado el proveedor")
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox.Error(ex)
        End Try
    End Sub
End Class