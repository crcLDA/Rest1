Public Class frmProducto
    Public pID As Int32
    Private objUtil As Utilitarios
    Private objNegocios As Productos

    Private Function validar() As Boolean
        Try
            If Not objUtil.validaTxtLleno(txtNombre) Then
                Throw New Exception("Ingrese un nombre")
            End If
            If Not objUtil.validaTxtLleno(txtDescripcion) Then
                Throw New Exception("Ingrese una descripción")
            End If

            If Not objUtil.validaTxtLleno(txtPrecio) Then
                Throw New Exception("Ingrese un precio")
            End If

            If Not objUtil.validaTxtInteger(txtPrecio) Then
                Throw New Exception("El precio debe contener solo números")
            End If

            If Not objUtil.validaCboSeleccionado(cboCategoria) Then
                Throw New Exception("Seleccione una categoría")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargar()
        Try
            txtId.Enabled = False
            Dim objCat As New Categorias
            objCat.cargarCBO(Me.cboCategoria)

            If pID <> 0 Then
                Dim obj As Producto = objNegocios.ConsultarID(pID)
                txtId.Text = obj.IdProducto
                txtNombre.Text = obj.Nombre
                txtDescripcion.Text = obj.Descripcion
                txtPrecio.Text = CInt(obj.Precio)
                cboCategoria.SelectedValue = obj.IdCategoria
                chkActivo.Checked = obj.Activo
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            objUtil = New Utilitarios
            objNegocios = New Productos
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
                Dim obj As New Producto(Integer.Parse(txtId.Text.Trim), txtNombre.Text.Trim, txtDescripcion.Text.Trim, Integer.Parse(txtPrecio.Text), cboCategoria.SelectedValue, chkActivo.Checked)
                If pID = 0 Then
                    objNegocios.Agregar(obj)
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